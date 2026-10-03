using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x02000809 RID: 2057
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		// Token: 0x0600C7C9 RID: 51145 RVA: 0x00328350 File Offset: 0x00326550
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsManager()
		{
			Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr);
			InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "KeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "WideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "ExtraWideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "LeftClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "MiddleClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "RightClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr__inputPromptsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_inputPromptsUI");
			InputPromptsManager.NativeFieldInfoPtr__inputPromptDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_inputPromptDataList");
			InputPromptsManager.NativeFieldInfoPtr__debugModuleId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_debugModuleId");
			InputPromptsManager.NativeFieldInfoPtr__debugUseCustomInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_debugUseCustomInputType");
			InputPromptsManager.NativeFieldInfoPtr__debugInputType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_debugInputType");
			InputPromptsManager.NativeFieldInfoPtr__minAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_minAnchor");
			InputPromptsManager.NativeFieldInfoPtr__maxAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_maxAnchor");
			InputPromptsManager.NativeFieldInfoPtr__pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_pivot");
			InputPromptsManager.NativeFieldInfoPtr__position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_position");
			InputPromptsManager.NativeFieldInfoPtr__inputDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_inputDataLookup");
			InputPromptsManager.NativeFieldInfoPtr__activePrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_activePrompts");
			InputPromptsManager.NativeFieldInfoPtr__promptTextOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_promptTextOverrides");
			InputPromptsManager.NativeFieldInfoPtr__bindingDataList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_bindingDataList");
			InputPromptsManager.NativeFieldInfoPtr__onModuleLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_onModuleLoaded");
			InputPromptsManager.NativeFieldInfoPtr__onModuleUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "_onModuleUnloaded");
			InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689128);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689129);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689130);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689131);
			InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689132);
			InputPromptsManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689133);
			InputPromptsManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689134);
			InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689135);
			InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689136);
			InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_EInputPromptPosition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689137);
			InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_Vector3_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689138);
			InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_Vector3_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689139);
			InputPromptsManager.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689140);
			InputPromptsManager.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689141);
			InputPromptsManager.NativeMethodInfoPtr_GetBindingDataFromDescriptor_Public_InputPromptsBindingData_InputPromptsDescriptorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689142);
			InputPromptsManager.NativeMethodInfoPtr_GetAllBindingDataFromDescriptor_Public_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689143);
			InputPromptsManager.NativeMethodInfoPtr_GetBindingDataFromActionReference_Public_InputPromptsBindingData_InputActionReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689144);
			InputPromptsManager.NativeMethodInfoPtr_GetInputPromptData_Public_InputPromptsData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689145);
			InputPromptsManager.NativeMethodInfoPtr_UpdateDisplayTextOverride_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689146);
			InputPromptsManager.NativeMethodInfoPtr_ShowHideActivePrompt_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689147);
			InputPromptsManager.NativeMethodInfoPtr_HasActivePrompt_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689148);
			InputPromptsManager.NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689149);
			InputPromptsManager.NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_InputAction_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689150);
			InputPromptsManager.NativeMethodInfoPtr_AddInputPrompt_Private_Boolean_String_InputPromptsDescriptorData_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689151);
			InputPromptsManager.NativeMethodInfoPtr_RefreshInputPrompts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689152);
			InputPromptsManager.NativeMethodInfoPtr_GetPromptBindingsForCurrentControlScheme_Private_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689153);
			InputPromptsManager.NativeMethodInfoPtr_HasCorrectControlScheme_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689154);
			InputPromptsManager.NativeMethodInfoPtr_HasCorrectPlatformType_Private_Boolean_EPlatformType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689155);
			InputPromptsManager.NativeMethodInfoPtr_GetControlUsedScheme_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689156);
			InputPromptsManager.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689157);
			InputPromptsManager.NativeMethodInfoPtr_SubscribeToModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689158);
			InputPromptsManager.NativeMethodInfoPtr_UnsubscribeFromModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689159);
			InputPromptsManager.NativeMethodInfoPtr_SubscribeToModuleUnloaded_Public_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689160);
			InputPromptsManager.NativeMethodInfoPtr_UnsubscribeFromModuleUnloaded_Public_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689161);
			InputPromptsManager.NativeMethodInfoPtr_DebugLoadModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689162);
			InputPromptsManager.NativeMethodInfoPtr_DebugUnloadModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689163);
			InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100689164);
		}

		// Token: 0x0600C7CA RID: 51146 RVA: 0x00328808 File Offset: 0x00326A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329127, RefRangeEnd = 329128, XrefRangeStart = 329090, XrefRangeEnd = 329127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage GetPromptImage(string controlPath, RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PromptImage>(intPtr3) : null;
		}

		// Token: 0x0600C7CB RID: 51147 RVA: 0x0032886C File Offset: 0x00326A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329128, XrefRangeEnd = 329137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathMouseRelated(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7CC RID: 51148 RVA: 0x003288BC File Offset: 0x00326ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329176, RefRangeEnd = 329177, XrefRangeStart = 329137, XrefRangeEnd = 329176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7CD RID: 51149 RVA: 0x0032890C File Offset: 0x00326B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329177, XrefRangeEnd = 329180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathExtraWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7CE RID: 51150 RVA: 0x0032895C File Offset: 0x00326B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329330, RefRangeEnd = 329334, XrefRangeStart = 329180, XrefRangeEnd = 329330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayNameForControlPath(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600C7CF RID: 51151 RVA: 0x003289A4 File Offset: 0x00326BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329334, XrefRangeEnd = 329405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputPromptsManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D0 RID: 51152 RVA: 0x003289E0 File Offset: 0x00326BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329405, XrefRangeEnd = 329430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InputPromptsManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D1 RID: 51153 RVA: 0x00328A1C File Offset: 0x00326C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329453, RefRangeEnd = 329454, XrefRangeStart = 329430, XrefRangeEnd = 329453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string id, EInputPromptPosition position = EInputPromptPosition.BottomLeftInGame, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D2 RID: 51154 RVA: 0x00328A80 File Offset: 0x00326C80
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 329470, RefRangeEnd = 329484, XrefRangeStart = 329454, XrefRangeEnd = 329470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D3 RID: 51155 RVA: 0x00328AC4 File Offset: 0x00326CC4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 329522, RefRangeEnd = 329527, XrefRangeStart = 329484, XrefRangeEnd = 329522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(InputPromptsData inputData, EInputPromptPosition position = EInputPromptPosition.BottomLeftInGame, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_EInputPromptPosition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D4 RID: 51156 RVA: 0x00328B28 File Offset: 0x00326D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329527, XrefRangeEnd = 329543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string id, Vector3 position, int canvasSortingOrder, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canvasSortingOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_String_Vector3_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D5 RID: 51157 RVA: 0x00328B9C File Offset: 0x00326D9C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329599, RefRangeEnd = 329603, XrefRangeStart = 329543, XrefRangeEnd = 329599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(InputPromptsData inputData, Vector3 position, int canvasSortingOrder, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canvasSortingOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_Vector3_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D6 RID: 51158 RVA: 0x00328C10 File Offset: 0x00326E10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 329606, RefRangeEnd = 329611, XrefRangeStart = 329603, XrefRangeEnd = 329606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(InputPromptsData inputData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D7 RID: 51159 RVA: 0x00328C54 File Offset: 0x00326E54
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 329622, RefRangeEnd = 329641, XrefRangeStart = 329611, XrefRangeEnd = 329622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_UnloadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7D8 RID: 51160 RVA: 0x00328C98 File Offset: 0x00326E98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329649, RefRangeEnd = 329651, XrefRangeStart = 329641, XrefRangeEnd = 329649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsBindingData GetBindingDataFromDescriptor(InputPromptsDescriptorData descriptor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetBindingDataFromDescriptor_Public_InputPromptsBindingData_InputPromptsDescriptorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsBindingData>(intPtr3) : null;
		}

		// Token: 0x0600C7D9 RID: 51161 RVA: 0x00328CE8 File Offset: 0x00326EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329651, XrefRangeEnd = 329662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<InputPromptsBindingData> GetAllBindingDataFromDescriptor(InputPromptsDescriptorData descriptor, out List<string> bindingDisplayStrings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetAllBindingDataFromDescriptor_Public_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			bindingDisplayStrings = ((intPtr4 == 0) ? null : new List<string>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<List<InputPromptsBindingData>>(intPtr5) : null;
		}

		// Token: 0x0600C7DA RID: 51162 RVA: 0x00328D5C File Offset: 0x00326F5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329744, RefRangeEnd = 329745, XrefRangeStart = 329662, XrefRangeEnd = 329744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsBindingData GetBindingDataFromActionReference(InputActionReference actionReference, string bindingId = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(actionReference);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(bindingId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetBindingDataFromActionReference_Public_InputPromptsBindingData_InputActionReference_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsBindingData>(intPtr3) : null;
		}

		// Token: 0x0600C7DB RID: 51163 RVA: 0x00328DC0 File Offset: 0x00326FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329752, RefRangeEnd = 329753, XrefRangeStart = 329745, XrefRangeEnd = 329752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsData GetInputPromptData(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetInputPromptData_Public_InputPromptsData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr3) : null;
		}

		// Token: 0x0600C7DC RID: 51164 RVA: 0x00328E10 File Offset: 0x00327010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329771, RefRangeEnd = 329773, XrefRangeStart = 329753, XrefRangeEnd = 329771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDisplayTextOverride(string panelId, string displayTextOverride)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(panelId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_UpdateDisplayTextOverride_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7DD RID: 51165 RVA: 0x00328E64 File Offset: 0x00327064
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329785, RefRangeEnd = 329789, XrefRangeStart = 329773, XrefRangeEnd = 329785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowHideActivePrompt(string panelId, bool show)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(panelId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref show;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_ShowHideActivePrompt_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7DE RID: 51166 RVA: 0x00328EB4 File Offset: 0x003270B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 329794, RefRangeEnd = 329798, XrefRangeStart = 329789, XrefRangeEnd = 329794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActivePrompt(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_HasActivePrompt_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7DF RID: 51167 RVA: 0x00328F04 File Offset: 0x00327104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329808, RefRangeEnd = 329809, XrefRangeStart = 329798, XrefRangeEnd = 329808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetActionBindingDisplayString(string actionName, out string displayString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(actionName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			displayString = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C7E0 RID: 51168 RVA: 0x00328F6C File Offset: 0x0032716C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329850, RefRangeEnd = 329851, XrefRangeStart = 329809, XrefRangeEnd = 329850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetActionBindingDisplayString(InputAction action, out string displayString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_InputAction_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			displayString = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C7E1 RID: 51169 RVA: 0x00328FD4 File Offset: 0x003271D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 329879, RefRangeEnd = 329882, XrefRangeStart = 329851, XrefRangeEnd = 329879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddInputPrompt(string panelId, InputPromptsDescriptorData descriptor, bool isPulsing, string displayTextOverride = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(panelId);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPulsing;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(displayTextOverride);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_AddInputPrompt_Private_Boolean_String_InputPromptsDescriptorData_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7E2 RID: 51170 RVA: 0x00329054 File Offset: 0x00327254
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 329937, RefRangeEnd = 329939, XrefRangeStart = 329882, XrefRangeEnd = 329937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshInputPrompts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_RefreshInputPrompts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7E3 RID: 51171 RVA: 0x00329088 File Offset: 0x00327288
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 330089, RefRangeEnd = 330093, XrefRangeStart = 329939, XrefRangeEnd = 330089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<InputPromptsBindingData> GetPromptBindingsForCurrentControlScheme(InputPromptsDescriptorData descriptor, out List<string> bindingDisplayStrings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(descriptor);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetPromptBindingsForCurrentControlScheme_Private_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			bindingDisplayStrings = ((intPtr4 == 0) ? null : new List<string>(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<List<InputPromptsBindingData>>(intPtr5) : null;
		}

		// Token: 0x0600C7E4 RID: 51172 RVA: 0x003290FC File Offset: 0x003272FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 330102, RefRangeEnd = 330105, XrefRangeStart = 330093, XrefRangeEnd = 330102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCorrectControlScheme(string effectivePath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(effectivePath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_HasCorrectControlScheme_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7E5 RID: 51173 RVA: 0x0032914C File Offset: 0x0032734C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330105, XrefRangeEnd = 330112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasCorrectPlatformType(EPlatformType platformType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref platformType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_HasCorrectPlatformType_Private_Boolean_EPlatformType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C7E6 RID: 51174 RVA: 0x00329198 File Offset: 0x00327398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330112, XrefRangeEnd = 330120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetControlUsedScheme()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetControlUsedScheme_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600C7E7 RID: 51175 RVA: 0x003291D0 File Offset: 0x003273D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330120, XrefRangeEnd = 330121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputChange(GameInput.InputDeviceType deviceType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref deviceType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7E8 RID: 51176 RVA: 0x00329210 File Offset: 0x00327410
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330129, RefRangeEnd = 330131, XrefRangeStart = 330121, XrefRangeEnd = 330129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToModuleLoaded(InputPromptReferenceEventHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_SubscribeToModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7E9 RID: 51177 RVA: 0x00329254 File Offset: 0x00327454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330139, RefRangeEnd = 330140, XrefRangeStart = 330131, XrefRangeEnd = 330139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromModuleLoaded(InputPromptReferenceEventHandler callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_UnsubscribeFromModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7EA RID: 51178 RVA: 0x00329298 File Offset: 0x00327498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330150, RefRangeEnd = 330152, XrefRangeStart = 330140, XrefRangeEnd = 330150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToModuleUnloaded(Action<string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_SubscribeToModuleUnloaded_Public_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7EB RID: 51179 RVA: 0x003292DC File Offset: 0x003274DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330162, RefRangeEnd = 330163, XrefRangeStart = 330152, XrefRangeEnd = 330162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromModuleUnloaded(Action<string> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_UnsubscribeFromModuleUnloaded_Public_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7EC RID: 51180 RVA: 0x00329320 File Offset: 0x00327520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330163, XrefRangeEnd = 330179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugLoadModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_DebugLoadModule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7ED RID: 51181 RVA: 0x00329354 File Offset: 0x00327554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330179, XrefRangeEnd = 330180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugUnloadModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_DebugUnloadModule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x00329388 File Offset: 0x00327588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330180, XrefRangeEnd = 330194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C7EF RID: 51183 RVA: 0x0005E730 File Offset: 0x0005C930
		public InputPromptsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x0600C7F0 RID: 51184 RVA: 0x003293C4 File Offset: 0x003275C4
		// (set) Token: 0x0600C7F1 RID: 51185 RVA: 0x0005E739 File Offset: 0x0005C939
		public unsafe GameObject KeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x0600C7F2 RID: 51186 RVA: 0x003293F4 File Offset: 0x003275F4
		// (set) Token: 0x0600C7F3 RID: 51187 RVA: 0x0005E758 File Offset: 0x0005C958
		public unsafe GameObject WideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CA7 RID: 15527
		// (get) Token: 0x0600C7F4 RID: 51188 RVA: 0x00329424 File Offset: 0x00327624
		// (set) Token: 0x0600C7F5 RID: 51189 RVA: 0x0005E777 File Offset: 0x0005C977
		public unsafe GameObject ExtraWideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CA8 RID: 15528
		// (get) Token: 0x0600C7F6 RID: 51190 RVA: 0x00329454 File Offset: 0x00327654
		// (set) Token: 0x0600C7F7 RID: 51191 RVA: 0x0005E796 File Offset: 0x0005C996
		public unsafe GameObject LeftClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CA9 RID: 15529
		// (get) Token: 0x0600C7F8 RID: 51192 RVA: 0x00329484 File Offset: 0x00327684
		// (set) Token: 0x0600C7F9 RID: 51193 RVA: 0x0005E7B5 File Offset: 0x0005C9B5
		public unsafe GameObject MiddleClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CAA RID: 15530
		// (get) Token: 0x0600C7FA RID: 51194 RVA: 0x003294B4 File Offset: 0x003276B4
		// (set) Token: 0x0600C7FB RID: 51195 RVA: 0x0005E7D4 File Offset: 0x0005C9D4
		public unsafe GameObject RightClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CAB RID: 15531
		// (get) Token: 0x0600C7FC RID: 51196 RVA: 0x003294E4 File Offset: 0x003276E4
		// (set) Token: 0x0600C7FD RID: 51197 RVA: 0x0005E7F3 File Offset: 0x0005C9F3
		public unsafe InputPromptsUI _inputPromptsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputPromptsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputPromptsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CAC RID: 15532
		// (get) Token: 0x0600C7FE RID: 51198 RVA: 0x00329514 File Offset: 0x00327714
		// (set) Token: 0x0600C7FF RID: 51199 RVA: 0x0005E812 File Offset: 0x0005CA12
		public unsafe List<InputPromptsData> _inputPromptDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputPromptDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputPromptDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CAD RID: 15533
		// (get) Token: 0x0600C800 RID: 51200 RVA: 0x00329544 File Offset: 0x00327744
		// (set) Token: 0x0600C801 RID: 51201 RVA: 0x0005E831 File Offset: 0x0005CA31
		public unsafe string _debugModuleId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugModuleId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugModuleId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003CAE RID: 15534
		// (get) Token: 0x0600C802 RID: 51202 RVA: 0x0032956C File Offset: 0x0032776C
		// (set) Token: 0x0600C803 RID: 51203 RVA: 0x0005E850 File Offset: 0x0005CA50
		public unsafe bool _debugUseCustomInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugUseCustomInputType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugUseCustomInputType)) = value;
			}
		}

		// Token: 0x17003CAF RID: 15535
		// (get) Token: 0x0600C804 RID: 51204 RVA: 0x00329594 File Offset: 0x00327794
		// (set) Token: 0x0600C805 RID: 51205 RVA: 0x0005E86B File Offset: 0x0005CA6B
		public unsafe string _debugInputType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugInputType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__debugInputType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003CB0 RID: 15536
		// (get) Token: 0x0600C806 RID: 51206 RVA: 0x003295BC File Offset: 0x003277BC
		// (set) Token: 0x0600C807 RID: 51207 RVA: 0x0005E88A File Offset: 0x0005CA8A
		public unsafe Vector2 _minAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__minAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__minAnchor)) = value;
			}
		}

		// Token: 0x17003CB1 RID: 15537
		// (get) Token: 0x0600C808 RID: 51208 RVA: 0x003295E4 File Offset: 0x003277E4
		// (set) Token: 0x0600C809 RID: 51209 RVA: 0x0005E8A5 File Offset: 0x0005CAA5
		public unsafe Vector2 _maxAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__maxAnchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__maxAnchor)) = value;
			}
		}

		// Token: 0x17003CB2 RID: 15538
		// (get) Token: 0x0600C80A RID: 51210 RVA: 0x0032960C File Offset: 0x0032780C
		// (set) Token: 0x0600C80B RID: 51211 RVA: 0x0005E8C0 File Offset: 0x0005CAC0
		public unsafe Vector2 _pivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__pivot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__pivot)) = value;
			}
		}

		// Token: 0x17003CB3 RID: 15539
		// (get) Token: 0x0600C80C RID: 51212 RVA: 0x00329634 File Offset: 0x00327834
		// (set) Token: 0x0600C80D RID: 51213 RVA: 0x0005E8DB File Offset: 0x0005CADB
		public unsafe Vector2 _position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__position)) = value;
			}
		}

		// Token: 0x17003CB4 RID: 15540
		// (get) Token: 0x0600C80E RID: 51214 RVA: 0x0032965C File Offset: 0x0032785C
		// (set) Token: 0x0600C80F RID: 51215 RVA: 0x0005E8F6 File Offset: 0x0005CAF6
		public unsafe Dictionary<string, InputPromptsData> _inputDataLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputDataLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputPromptsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__inputDataLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CB5 RID: 15541
		// (get) Token: 0x0600C810 RID: 51216 RVA: 0x0032968C File Offset: 0x0032788C
		// (set) Token: 0x0600C811 RID: 51217 RVA: 0x0005E915 File Offset: 0x0005CB15
		public unsafe Dictionary<string, InputPromptsData> _activePrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__activePrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, InputPromptsData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__activePrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CB6 RID: 15542
		// (get) Token: 0x0600C812 RID: 51218 RVA: 0x003296BC File Offset: 0x003278BC
		// (set) Token: 0x0600C813 RID: 51219 RVA: 0x0005E934 File Offset: 0x0005CB34
		public unsafe Dictionary<string, string> _promptTextOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__promptTextOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__promptTextOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CB7 RID: 15543
		// (get) Token: 0x0600C814 RID: 51220 RVA: 0x003296EC File Offset: 0x003278EC
		// (set) Token: 0x0600C815 RID: 51221 RVA: 0x0005E953 File Offset: 0x0005CB53
		public unsafe List<InputPromptsBindingData> _bindingDataList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__bindingDataList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsBindingData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__bindingDataList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0600C816 RID: 51222 RVA: 0x0032971C File Offset: 0x0032791C
		// (set) Token: 0x0600C817 RID: 51223 RVA: 0x0005E972 File Offset: 0x0005CB72
		public unsafe InputPromptReferenceEventHandler _onModuleLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__onModuleLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptReferenceEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__onModuleLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0600C818 RID: 51224 RVA: 0x0032974C File Offset: 0x0032794C
		// (set) Token: 0x0600C819 RID: 51225 RVA: 0x0005E991 File Offset: 0x0005CB91
		public unsafe Action<string> _onModuleUnloaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__onModuleUnloaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr__onModuleUnloaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008827 RID: 34855
		private static readonly IntPtr NativeFieldInfoPtr_KeyPromptPrefab;

		// Token: 0x04008828 RID: 34856
		private static readonly IntPtr NativeFieldInfoPtr_WideKeyPromptPrefab;

		// Token: 0x04008829 RID: 34857
		private static readonly IntPtr NativeFieldInfoPtr_ExtraWideKeyPromptPrefab;

		// Token: 0x0400882A RID: 34858
		private static readonly IntPtr NativeFieldInfoPtr_LeftClickPromptPrefab;

		// Token: 0x0400882B RID: 34859
		private static readonly IntPtr NativeFieldInfoPtr_MiddleClickPromptPrefab;

		// Token: 0x0400882C RID: 34860
		private static readonly IntPtr NativeFieldInfoPtr_RightClickPromptPrefab;

		// Token: 0x0400882D RID: 34861
		private static readonly IntPtr NativeFieldInfoPtr__inputPromptsUI;

		// Token: 0x0400882E RID: 34862
		private static readonly IntPtr NativeFieldInfoPtr__inputPromptDataList;

		// Token: 0x0400882F RID: 34863
		private static readonly IntPtr NativeFieldInfoPtr__debugModuleId;

		// Token: 0x04008830 RID: 34864
		private static readonly IntPtr NativeFieldInfoPtr__debugUseCustomInputType;

		// Token: 0x04008831 RID: 34865
		private static readonly IntPtr NativeFieldInfoPtr__debugInputType;

		// Token: 0x04008832 RID: 34866
		private static readonly IntPtr NativeFieldInfoPtr__minAnchor;

		// Token: 0x04008833 RID: 34867
		private static readonly IntPtr NativeFieldInfoPtr__maxAnchor;

		// Token: 0x04008834 RID: 34868
		private static readonly IntPtr NativeFieldInfoPtr__pivot;

		// Token: 0x04008835 RID: 34869
		private static readonly IntPtr NativeFieldInfoPtr__position;

		// Token: 0x04008836 RID: 34870
		private static readonly IntPtr NativeFieldInfoPtr__inputDataLookup;

		// Token: 0x04008837 RID: 34871
		private static readonly IntPtr NativeFieldInfoPtr__activePrompts;

		// Token: 0x04008838 RID: 34872
		private static readonly IntPtr NativeFieldInfoPtr__promptTextOverrides;

		// Token: 0x04008839 RID: 34873
		private static readonly IntPtr NativeFieldInfoPtr__bindingDataList;

		// Token: 0x0400883A RID: 34874
		private static readonly IntPtr NativeFieldInfoPtr__onModuleLoaded;

		// Token: 0x0400883B RID: 34875
		private static readonly IntPtr NativeFieldInfoPtr__onModuleUnloaded;

		// Token: 0x0400883C RID: 34876
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0;

		// Token: 0x0400883D RID: 34877
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0;

		// Token: 0x0400883E RID: 34878
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0;

		// Token: 0x0400883F RID: 34879
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0;

		// Token: 0x04008840 RID: 34880
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0;

		// Token: 0x04008841 RID: 34881
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008842 RID: 34882
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04008843 RID: 34883
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_EInputPromptPosition_String_0;

		// Token: 0x04008844 RID: 34884
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_0;

		// Token: 0x04008845 RID: 34885
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_EInputPromptPosition_String_0;

		// Token: 0x04008846 RID: 34886
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_Vector3_Int32_String_0;

		// Token: 0x04008847 RID: 34887
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_InputPromptsData_Vector3_Int32_String_0;

		// Token: 0x04008848 RID: 34888
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_InputPromptsData_0;

		// Token: 0x04008849 RID: 34889
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_String_0;

		// Token: 0x0400884A RID: 34890
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingDataFromDescriptor_Public_InputPromptsBindingData_InputPromptsDescriptorData_0;

		// Token: 0x0400884B RID: 34891
		private static readonly IntPtr NativeMethodInfoPtr_GetAllBindingDataFromDescriptor_Public_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0;

		// Token: 0x0400884C RID: 34892
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingDataFromActionReference_Public_InputPromptsBindingData_InputActionReference_String_0;

		// Token: 0x0400884D RID: 34893
		private static readonly IntPtr NativeMethodInfoPtr_GetInputPromptData_Public_InputPromptsData_String_0;

		// Token: 0x0400884E RID: 34894
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDisplayTextOverride_Public_Void_String_String_0;

		// Token: 0x0400884F RID: 34895
		private static readonly IntPtr NativeMethodInfoPtr_ShowHideActivePrompt_Public_Void_String_Boolean_0;

		// Token: 0x04008850 RID: 34896
		private static readonly IntPtr NativeMethodInfoPtr_HasActivePrompt_Public_Boolean_String_0;

		// Token: 0x04008851 RID: 34897
		private static readonly IntPtr NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_String_byref_String_0;

		// Token: 0x04008852 RID: 34898
		private static readonly IntPtr NativeMethodInfoPtr_TryGetActionBindingDisplayString_Public_Boolean_InputAction_byref_String_0;

		// Token: 0x04008853 RID: 34899
		private static readonly IntPtr NativeMethodInfoPtr_AddInputPrompt_Private_Boolean_String_InputPromptsDescriptorData_Boolean_String_0;

		// Token: 0x04008854 RID: 34900
		private static readonly IntPtr NativeMethodInfoPtr_RefreshInputPrompts_Private_Void_0;

		// Token: 0x04008855 RID: 34901
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptBindingsForCurrentControlScheme_Private_List_1_InputPromptsBindingData_InputPromptsDescriptorData_byref_List_1_String_0;

		// Token: 0x04008856 RID: 34902
		private static readonly IntPtr NativeMethodInfoPtr_HasCorrectControlScheme_Private_Boolean_String_0;

		// Token: 0x04008857 RID: 34903
		private static readonly IntPtr NativeMethodInfoPtr_HasCorrectPlatformType_Private_Boolean_EPlatformType_0;

		// Token: 0x04008858 RID: 34904
		private static readonly IntPtr NativeMethodInfoPtr_GetControlUsedScheme_Private_String_0;

		// Token: 0x04008859 RID: 34905
		private static readonly IntPtr NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0;

		// Token: 0x0400885A RID: 34906
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0;

		// Token: 0x0400885B RID: 34907
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromModuleLoaded_Public_Void_InputPromptReferenceEventHandler_0;

		// Token: 0x0400885C RID: 34908
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToModuleUnloaded_Public_Void_Action_1_String_0;

		// Token: 0x0400885D RID: 34909
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromModuleUnloaded_Public_Void_Action_1_String_0;

		// Token: 0x0400885E RID: 34910
		private static readonly IntPtr NativeMethodInfoPtr_DebugLoadModule_Public_Void_0;

		// Token: 0x0400885F RID: 34911
		private static readonly IntPtr NativeMethodInfoPtr_DebugUnloadModule_Public_Void_0;

		// Token: 0x04008860 RID: 34912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D70 RID: 3440
		[ObfuscatedName("ScheduleOne.UI.Input.InputPromptsManager+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FB4E RID: 64334 RVA: 0x003C0040 File Offset: 0x003BE240
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr);
				InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr_checkForPlatformMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr, "checkForPlatformMatch");
				InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				InputPromptsManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr, 100689165);
			}

			// Token: 0x0600FB4F RID: 64335 RVA: 0x003C00A8 File Offset: 0x003BE2A8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB50 RID: 64336 RVA: 0x00076EC4 File Offset: 0x000750C4
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C5C RID: 19548
			// (get) Token: 0x0600FB51 RID: 64337 RVA: 0x003C00E4 File Offset: 0x003BE2E4
			// (set) Token: 0x0600FB52 RID: 64338 RVA: 0x00076ECD File Offset: 0x000750CD
			public unsafe bool checkForPlatformMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr_checkForPlatformMatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr_checkForPlatformMatch)) = value;
				}
			}

			// Token: 0x17004C5D RID: 19549
			// (get) Token: 0x0600FB53 RID: 64339 RVA: 0x003C010C File Offset: 0x003BE30C
			// (set) Token: 0x0600FB54 RID: 64340 RVA: 0x00076EE8 File Offset: 0x000750E8
			public unsafe InputPromptsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A98B RID: 43403
			private static readonly IntPtr NativeFieldInfoPtr_checkForPlatformMatch;

			// Token: 0x0400A98C RID: 43404
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A98D RID: 43405
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D71 RID: 3441
		[ObfuscatedName("ScheduleOne.UI.Input.InputPromptsManager+<>c__DisplayClass37_1")]
		public sealed class __c__DisplayClass37_1 : Il2CppSystem.Object
		{
			// Token: 0x0600FB55 RID: 64341 RVA: 0x003C013C File Offset: 0x003BE33C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_1()
			{
				Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "<>c__DisplayClass37_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr);
				InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_binding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr, "binding");
				InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr, "CS$<>8__locals1");
				InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr, 100689166);
				InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__GetBindingDataFromActionReference_b__0_Internal_Boolean_InputPromptsBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr, 100689167);
				InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__GetBindingDataFromActionReference_b__1_Internal_Boolean_InputPromptsBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr, 100689168);
			}

			// Token: 0x0600FB56 RID: 64342 RVA: 0x003C01CC File Offset: 0x003BE3CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass37_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB57 RID: 64343 RVA: 0x003C0208 File Offset: 0x003BE408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329086, XrefRangeEnd = 329088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBindingDataFromActionReference_b__0(InputPromptsBindingData i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__GetBindingDataFromActionReference_b__0_Internal_Boolean_InputPromptsBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FB58 RID: 64344 RVA: 0x003C0258 File Offset: 0x003BE458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 329088, XrefRangeEnd = 329090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBindingDataFromActionReference_b__1(InputPromptsBindingData i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass37_1.NativeMethodInfoPtr__GetBindingDataFromActionReference_b__1_Internal_Boolean_InputPromptsBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FB59 RID: 64345 RVA: 0x00076F07 File Offset: 0x00075107
			public __c__DisplayClass37_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C5E RID: 19550
			// (get) Token: 0x0600FB5A RID: 64346 RVA: 0x003C02A8 File Offset: 0x003BE4A8
			// (set) Token: 0x0600FB5B RID: 64347 RVA: 0x00076F10 File Offset: 0x00075110
			public InputBinding binding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_binding);
					return new InputBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_binding), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004C5F RID: 19551
			// (get) Token: 0x0600FB5C RID: 64348 RVA: 0x003C02D8 File Offset: 0x003BE4D8
			// (set) Token: 0x0600FB5D RID: 64349 RVA: 0x00076F3E File Offset: 0x0007513E
			public unsafe InputPromptsManager.__c__DisplayClass37_0 field_Public___c__DisplayClass37_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsManager.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass37_1.NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A98E RID: 43406
			private static readonly IntPtr NativeFieldInfoPtr_binding;

			// Token: 0x0400A98F RID: 43407
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass37_0_0;

			// Token: 0x0400A990 RID: 43408
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A991 RID: 43409
			private static readonly IntPtr NativeMethodInfoPtr__GetBindingDataFromActionReference_b__0_Internal_Boolean_InputPromptsBindingData_0;

			// Token: 0x0400A992 RID: 43410
			private static readonly IntPtr NativeMethodInfoPtr__GetBindingDataFromActionReference_b__1_Internal_Boolean_InputPromptsBindingData_0;
		}

		// Token: 0x02000D72 RID: 3442
		[ObfuscatedName("ScheduleOne.UI.Input.InputPromptsManager+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FB5E RID: 64350 RVA: 0x003C0308 File Offset: 0x003BE508
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr);
				InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr_checkForPlatformMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr, "checkForPlatformMatch");
				InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr, "<>4__this");
				InputPromptsManager.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr, 100689169);
			}

			// Token: 0x0600FB5F RID: 64351 RVA: 0x003C0370 File Offset: 0x003BE570
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB60 RID: 64352 RVA: 0x00076F5D File Offset: 0x0007515D
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C60 RID: 19552
			// (get) Token: 0x0600FB61 RID: 64353 RVA: 0x003C03AC File Offset: 0x003BE5AC
			// (set) Token: 0x0600FB62 RID: 64354 RVA: 0x00076F66 File Offset: 0x00075166
			public unsafe bool checkForPlatformMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr_checkForPlatformMatch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr_checkForPlatformMatch)) = value;
				}
			}

			// Token: 0x17004C61 RID: 19553
			// (get) Token: 0x0600FB63 RID: 64355 RVA: 0x003C03D4 File Offset: 0x003BE5D4
			// (set) Token: 0x0600FB64 RID: 64356 RVA: 0x00076F81 File Offset: 0x00075181
			public unsafe InputPromptsManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A993 RID: 43411
			private static readonly IntPtr NativeFieldInfoPtr_checkForPlatformMatch;

			// Token: 0x0400A994 RID: 43412
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A995 RID: 43413
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D73 RID: 3443
		[ObfuscatedName("ScheduleOne.UI.Input.InputPromptsManager+<>c__DisplayClass46_1")]
		public sealed class __c__DisplayClass46_1 : Il2CppSystem.Object
		{
			// Token: 0x0600FB65 RID: 64357 RVA: 0x003C0404 File Offset: 0x003BE604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_1()
			{
				Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "<>c__DisplayClass46_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr);
				InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_inputBinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr, "inputBinding");
				InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_field_Public___c__DisplayClass46_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr, "CS$<>8__locals1");
				InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr, 100689170);
				InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__0_Internal_Boolean_InputPromptsBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr, 100689171);
				InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__1_Internal_Boolean_InputPromptsBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr, 100689172);
			}

			// Token: 0x0600FB66 RID: 64358 RVA: 0x003C0494 File Offset: 0x003BE694
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager.__c__DisplayClass46_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FB67 RID: 64359 RVA: 0x003C04D0 File Offset: 0x003BE6D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPromptBindingsForCurrentControlScheme_b__0(InputPromptsBindingData i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__0_Internal_Boolean_InputPromptsBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FB68 RID: 64360 RVA: 0x003C0520 File Offset: 0x003BE720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPromptBindingsForCurrentControlScheme_b__1(InputPromptsBindingData i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.__c__DisplayClass46_1.NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__1_Internal_Boolean_InputPromptsBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FB69 RID: 64361 RVA: 0x00076FA0 File Offset: 0x000751A0
			public __c__DisplayClass46_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C62 RID: 19554
			// (get) Token: 0x0600FB6A RID: 64362 RVA: 0x003C0570 File Offset: 0x003BE770
			// (set) Token: 0x0600FB6B RID: 64363 RVA: 0x00076FA9 File Offset: 0x000751A9
			public InputBinding inputBinding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_inputBinding);
					return new InputBinding(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_inputBinding), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InputBinding>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004C63 RID: 19555
			// (get) Token: 0x0600FB6C RID: 64364 RVA: 0x003C05A0 File Offset: 0x003BE7A0
			// (set) Token: 0x0600FB6D RID: 64365 RVA: 0x00076FD7 File Offset: 0x000751D7
			public unsafe InputPromptsManager.__c__DisplayClass46_0 field_Public___c__DisplayClass46_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_field_Public___c__DisplayClass46_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsManager.__c__DisplayClass46_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.__c__DisplayClass46_1.NativeFieldInfoPtr_field_Public___c__DisplayClass46_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A996 RID: 43414
			private static readonly IntPtr NativeFieldInfoPtr_inputBinding;

			// Token: 0x0400A997 RID: 43415
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass46_0_0;

			// Token: 0x0400A998 RID: 43416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A999 RID: 43417
			private static readonly IntPtr NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__0_Internal_Boolean_InputPromptsBindingData_0;

			// Token: 0x0400A99A RID: 43418
			private static readonly IntPtr NativeMethodInfoPtr__GetPromptBindingsForCurrentControlScheme_b__1_Internal_Boolean_InputPromptsBindingData_0;
		}
	}
}
