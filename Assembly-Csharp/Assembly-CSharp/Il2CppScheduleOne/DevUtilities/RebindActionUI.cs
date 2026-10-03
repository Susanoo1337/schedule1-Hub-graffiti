using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000415 RID: 1045
	public class RebindActionUI : MonoBehaviour
	{
		// Token: 0x06005BAB RID: 23467 RVA: 0x001B7278 File Offset: 0x001B5478
		// Note: this type is marked as 'beforefieldinit'.
		static RebindActionUI()
		{
			Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "RebindActionUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr);
			RebindActionUI.NativeFieldInfoPtr_onRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "onRebind");
			RebindActionUI.NativeFieldInfoPtr__timeOnLastRebind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "_timeOnLastRebind");
			RebindActionUI.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_Action");
			RebindActionUI.NativeFieldInfoPtr_m_DerivedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_DerivedActions");
			RebindActionUI.NativeFieldInfoPtr_m_BindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingId");
			RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_DisplayStringOptions");
			RebindActionUI.NativeFieldInfoPtr_m_ActionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_ActionLabel");
			RebindActionUI.NativeFieldInfoPtr_m_BindingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_BindingText");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOverlay");
			RebindActionUI.NativeFieldInfoPtr_m_RebindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindText");
			RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_UpdateBindingUIEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStartEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindStopEvent");
			RebindActionUI.NativeFieldInfoPtr_m_RebindOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "m_RebindOperation");
			RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "s_RebindActionUIs");
			RebindActionUI.NativeMethodInfoPtr_get_IsRebindingInProgress_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675255);
			RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675256);
			RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675257);
			RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675258);
			RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675259);
			RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675260);
			RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675261);
			RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675262);
			RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675263);
			RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675264);
			RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675265);
			RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675266);
			RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675267);
			RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675268);
			RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675269);
			RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675270);
			RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675271);
			RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675272);
			RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675273);
			RebindActionUI.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675274);
			RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675275);
			RebindActionUI.NativeMethodInfoPtr_IsRebinding_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675276);
			RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675277);
			RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675278);
			RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675279);
			RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675280);
			RebindActionUI.NativeMethodInfoPtr_SwapConflictingBindings_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675281);
			RebindActionUI.NativeMethodInfoPtr_SyncDerivedActions_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675282);
			RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675283);
			RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675284);
			RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675285);
			RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675286);
			RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675287);
			RebindActionUI.NativeMethodInfoPtr__Start_b__33_0_Private_Void_RebindActionUI_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675288);
			RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__36_0_Private_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, 100675289);
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005BAC RID: 23468 RVA: 0x001B7690 File Offset: 0x001B5890
		public unsafe static bool IsRebindingInProgress
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 197226, RefRangeEnd = 197231, XrefRangeStart = 197220, XrefRangeEnd = 197226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_IsRebindingInProgress_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06005BAD RID: 23469 RVA: 0x001B76C0 File Offset: 0x001B58C0
		// (set) Token: 0x06005BAE RID: 23470 RVA: 0x001B7700 File Offset: 0x001B5900
		public unsafe InputActionReference actionReference
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197231, XrefRangeEnd = 197234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06005BAF RID: 23471 RVA: 0x001B7744 File Offset: 0x001B5944
		// (set) Token: 0x06005BB0 RID: 23472 RVA: 0x001B777C File Offset: 0x001B597C
		public unsafe string bindingId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197234, XrefRangeEnd = 197236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005BB1 RID: 23473 RVA: 0x001B77C0 File Offset: 0x001B59C0
		// (set) Token: 0x06005BB2 RID: 23474 RVA: 0x001B77FC File Offset: 0x001B59FC
		public unsafe InputBinding.DisplayStringOptions displayStringOptions
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 38121, RefRangeEnd = 38127, XrefRangeStart = 38121, XrefRangeEnd = 38127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197236, XrefRangeEnd = 197237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005BB3 RID: 23475 RVA: 0x001B783C File Offset: 0x001B5A3C
		// (set) Token: 0x06005BB4 RID: 23476 RVA: 0x001B787C File Offset: 0x001B5A7C
		public unsafe TextMeshProUGUI actionLabel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197237, XrefRangeEnd = 197239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06005BB5 RID: 23477 RVA: 0x001B78C0 File Offset: 0x001B5AC0
		// (set) Token: 0x06005BB6 RID: 23478 RVA: 0x001B7900 File Offset: 0x001B5B00
		public unsafe TextMeshProUGUI bindingText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197239, XrefRangeEnd = 197241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06005BB7 RID: 23479 RVA: 0x001B7944 File Offset: 0x001B5B44
		// (set) Token: 0x06005BB8 RID: 23480 RVA: 0x001B7984 File Offset: 0x001B5B84
		public unsafe TextMeshProUGUI rebindPrompt
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 21999, RefRangeEnd = 22015, XrefRangeStart = 21999, XrefRangeEnd = 22015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06005BB9 RID: 23481 RVA: 0x001B79C8 File Offset: 0x001B5BC8
		// (set) Token: 0x06005BBA RID: 23482 RVA: 0x001B7A08 File Offset: 0x001B5C08
		public unsafe GameObject rebindOverlay
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06005BBB RID: 23483 RVA: 0x001B7A4C File Offset: 0x001B5C4C
		public unsafe RebindActionUI.UpdateBindingUIEvent updateBindingUIEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197241, XrefRangeEnd = 197248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x001B7A8C File Offset: 0x001B5C8C
		public unsafe RebindActionUI.InteractiveRebindEvent startRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197248, XrefRangeEnd = 197255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06005BBD RID: 23485 RVA: 0x001B7ACC File Offset: 0x001B5CCC
		public unsafe RebindActionUI.InteractiveRebindEvent stopRebindEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197255, XrefRangeEnd = 197262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr3) : null;
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x001B7B0C File Offset: 0x001B5D0C
		public unsafe InputActionRebindingExtensions.RebindingOperation ongoingRebind
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr3) : null;
			}
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x001B7B4C File Offset: 0x001B5D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197262, XrefRangeEnd = 197272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x001B7B80 File Offset: 0x001B5D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197272, XrefRangeEnd = 197294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResolveActionAndBinding(out InputAction action, out int bindingIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bindingIndex;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			action = ((intPtr4 == 0) ? null : new InputAction(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x001B7BEC File Offset: 0x001B5DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197294, XrefRangeEnd = 197296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRebinding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_IsRebinding_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BC2 RID: 23490 RVA: 0x001B7C28 File Offset: 0x001B5E28
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 197319, RefRangeEnd = 197330, XrefRangeStart = 197296, XrefRangeEnd = 197319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindingDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x001B7C5C File Offset: 0x001B5E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197330, XrefRangeEnd = 197369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetToDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_ResetToDefault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x001B7C90 File Offset: 0x001B5E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197369, XrefRangeEnd = 197411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartInteractiveRebind()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x001B7CC4 File Offset: 0x001B5EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197500, RefRangeEnd = 197502, XrefRangeStart = 197411, XrefRangeEnd = 197500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformInteractiveRebind(InputAction action, int bindingIndex, bool allCompositeParts = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allCompositeParts;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x001B7D24 File Offset: 0x001B5F24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197587, RefRangeEnd = 197588, XrefRangeStart = 197502, XrefRangeEnd = 197587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapConflictingBindings(string oldPath, string newPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_SwapConflictingBindings_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x001B7D78 File Offset: 0x001B5F78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197622, RefRangeEnd = 197625, XrefRangeStart = 197588, XrefRangeEnd = 197622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncDerivedActions(string oldPath, string newPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_SyncDerivedActions_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x001B7DCC File Offset: 0x001B5FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197625, XrefRangeEnd = 197657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x001B7E00 File Offset: 0x001B6000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197657, XrefRangeEnd = 197678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x001B7E34 File Offset: 0x001B6034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197678, XrefRangeEnd = 197707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActionChange(Il2CppSystem.Object obj, InputActionChange change)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x001B7E78 File Offset: 0x001B6078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197715, RefRangeEnd = 197717, XrefRangeStart = 197707, XrefRangeEnd = 197715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActionLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x001B7EAC File Offset: 0x001B60AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197717, XrefRangeEnd = 197725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RebindActionUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x001B7EE8 File Offset: 0x001B60E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197725, XrefRangeEnd = 197726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__33_0(RebindActionUI x, InputActionRebindingExtensions.RebindingOperation y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__Start_b__33_0_Private_Void_RebindActionUI_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x001B7F3C File Offset: 0x001B613C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197726, XrefRangeEnd = 197729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UpdateBindingDisplay_b__36_0(InputBinding x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.NativeMethodInfoPtr__UpdateBindingDisplay_b__36_0_Private_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x0002B6F6 File Offset: 0x000298F6
		public RebindActionUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x001B7F90 File Offset: 0x001B6190
		// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x0002B6FF File Offset: 0x000298FF
		public unsafe Action onRebind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_onRebind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x001B7FC0 File Offset: 0x001B61C0
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x0002B71E File Offset: 0x0002991E
		public unsafe float _timeOnLastRebind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr__timeOnLastRebind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr__timeOnLastRebind)) = value;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x001B7FE8 File Offset: 0x001B61E8
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x0002B739 File Offset: 0x00029939
		public unsafe InputActionReference m_Action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x001B8018 File Offset: 0x001B6218
		// (set) Token: 0x06005BD7 RID: 23511 RVA: 0x0002B758 File Offset: 0x00029958
		public unsafe List<InputActionReference> m_DerivedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DerivedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DerivedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06005BD8 RID: 23512 RVA: 0x001B8048 File Offset: 0x001B6248
		// (set) Token: 0x06005BD9 RID: 23513 RVA: 0x0002B777 File Offset: 0x00029977
		public unsafe string m_BindingId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06005BDA RID: 23514 RVA: 0x001B8070 File Offset: 0x001B6270
		// (set) Token: 0x06005BDB RID: 23515 RVA: 0x0002B796 File Offset: 0x00029996
		public unsafe InputBinding.DisplayStringOptions m_DisplayStringOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_DisplayStringOptions)) = value;
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06005BDC RID: 23516 RVA: 0x001B8098 File Offset: 0x001B6298
		// (set) Token: 0x06005BDD RID: 23517 RVA: 0x0002B7B1 File Offset: 0x000299B1
		public unsafe TextMeshProUGUI m_ActionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_ActionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06005BDE RID: 23518 RVA: 0x001B80C8 File Offset: 0x001B62C8
		// (set) Token: 0x06005BDF RID: 23519 RVA: 0x0002B7D0 File Offset: 0x000299D0
		public unsafe TextMeshProUGUI m_BindingText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_BindingText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06005BE0 RID: 23520 RVA: 0x001B80F8 File Offset: 0x001B62F8
		// (set) Token: 0x06005BE1 RID: 23521 RVA: 0x0002B7EF File Offset: 0x000299EF
		public unsafe GameObject m_RebindOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06005BE2 RID: 23522 RVA: 0x001B8128 File Offset: 0x001B6328
		// (set) Token: 0x06005BE3 RID: 23523 RVA: 0x0002B80E File Offset: 0x00029A0E
		public unsafe TextMeshProUGUI m_RebindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06005BE4 RID: 23524 RVA: 0x001B8158 File Offset: 0x001B6358
		// (set) Token: 0x06005BE5 RID: 23525 RVA: 0x0002B82D File Offset: 0x00029A2D
		public unsafe RebindActionUI.UpdateBindingUIEvent m_UpdateBindingUIEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.UpdateBindingUIEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_UpdateBindingUIEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06005BE6 RID: 23526 RVA: 0x001B8188 File Offset: 0x001B6388
		// (set) Token: 0x06005BE7 RID: 23527 RVA: 0x0002B84C File Offset: 0x00029A4C
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005BE8 RID: 23528 RVA: 0x001B81B8 File Offset: 0x001B63B8
		// (set) Token: 0x06005BE9 RID: 23529 RVA: 0x0002B86B File Offset: 0x00029A6B
		public unsafe RebindActionUI.InteractiveRebindEvent m_RebindStopEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.InteractiveRebindEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindStopEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005BEA RID: 23530 RVA: 0x001B81E8 File Offset: 0x001B63E8
		// (set) Token: 0x06005BEB RID: 23531 RVA: 0x0002B88A File Offset: 0x00029A8A
		public unsafe InputActionRebindingExtensions.RebindingOperation m_RebindOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionRebindingExtensions.RebindingOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.NativeFieldInfoPtr_m_RebindOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005BEC RID: 23532 RVA: 0x001B8218 File Offset: 0x001B6418
		// (set) Token: 0x06005BED RID: 23533 RVA: 0x0002B8A9 File Offset: 0x00029AA9
		public unsafe static List<RebindActionUI> s_RebindActionUIs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RebindActionUI>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RebindActionUI.NativeFieldInfoPtr_s_RebindActionUIs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003ED8 RID: 16088
		private static readonly IntPtr NativeFieldInfoPtr_onRebind;

		// Token: 0x04003ED9 RID: 16089
		private static readonly IntPtr NativeFieldInfoPtr__timeOnLastRebind;

		// Token: 0x04003EDA RID: 16090
		private static readonly IntPtr NativeFieldInfoPtr_m_Action;

		// Token: 0x04003EDB RID: 16091
		private static readonly IntPtr NativeFieldInfoPtr_m_DerivedActions;

		// Token: 0x04003EDC RID: 16092
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingId;

		// Token: 0x04003EDD RID: 16093
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayStringOptions;

		// Token: 0x04003EDE RID: 16094
		private static readonly IntPtr NativeFieldInfoPtr_m_ActionLabel;

		// Token: 0x04003EDF RID: 16095
		private static readonly IntPtr NativeFieldInfoPtr_m_BindingText;

		// Token: 0x04003EE0 RID: 16096
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOverlay;

		// Token: 0x04003EE1 RID: 16097
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindText;

		// Token: 0x04003EE2 RID: 16098
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdateBindingUIEvent;

		// Token: 0x04003EE3 RID: 16099
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStartEvent;

		// Token: 0x04003EE4 RID: 16100
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindStopEvent;

		// Token: 0x04003EE5 RID: 16101
		private static readonly IntPtr NativeFieldInfoPtr_m_RebindOperation;

		// Token: 0x04003EE6 RID: 16102
		private static readonly IntPtr NativeFieldInfoPtr_s_RebindActionUIs;

		// Token: 0x04003EE7 RID: 16103
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRebindingInProgress_Public_Static_get_Boolean_0;

		// Token: 0x04003EE8 RID: 16104
		private static readonly IntPtr NativeMethodInfoPtr_get_actionReference_Public_get_InputActionReference_0;

		// Token: 0x04003EE9 RID: 16105
		private static readonly IntPtr NativeMethodInfoPtr_set_actionReference_Public_set_Void_InputActionReference_0;

		// Token: 0x04003EEA RID: 16106
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingId_Public_get_String_0;

		// Token: 0x04003EEB RID: 16107
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingId_Public_set_Void_String_0;

		// Token: 0x04003EEC RID: 16108
		private static readonly IntPtr NativeMethodInfoPtr_get_displayStringOptions_Public_get_DisplayStringOptions_0;

		// Token: 0x04003EED RID: 16109
		private static readonly IntPtr NativeMethodInfoPtr_set_displayStringOptions_Public_set_Void_DisplayStringOptions_0;

		// Token: 0x04003EEE RID: 16110
		private static readonly IntPtr NativeMethodInfoPtr_get_actionLabel_Public_get_TextMeshProUGUI_0;

		// Token: 0x04003EEF RID: 16111
		private static readonly IntPtr NativeMethodInfoPtr_set_actionLabel_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04003EF0 RID: 16112
		private static readonly IntPtr NativeMethodInfoPtr_get_bindingText_Public_get_TextMeshProUGUI_0;

		// Token: 0x04003EF1 RID: 16113
		private static readonly IntPtr NativeMethodInfoPtr_set_bindingText_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04003EF2 RID: 16114
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindPrompt_Public_get_TextMeshProUGUI_0;

		// Token: 0x04003EF3 RID: 16115
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindPrompt_Public_set_Void_TextMeshProUGUI_0;

		// Token: 0x04003EF4 RID: 16116
		private static readonly IntPtr NativeMethodInfoPtr_get_rebindOverlay_Public_get_GameObject_0;

		// Token: 0x04003EF5 RID: 16117
		private static readonly IntPtr NativeMethodInfoPtr_set_rebindOverlay_Public_set_Void_GameObject_0;

		// Token: 0x04003EF6 RID: 16118
		private static readonly IntPtr NativeMethodInfoPtr_get_updateBindingUIEvent_Public_get_UpdateBindingUIEvent_0;

		// Token: 0x04003EF7 RID: 16119
		private static readonly IntPtr NativeMethodInfoPtr_get_startRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x04003EF8 RID: 16120
		private static readonly IntPtr NativeMethodInfoPtr_get_stopRebindEvent_Public_get_InteractiveRebindEvent_0;

		// Token: 0x04003EF9 RID: 16121
		private static readonly IntPtr NativeMethodInfoPtr_get_ongoingRebind_Public_get_RebindingOperation_0;

		// Token: 0x04003EFA RID: 16122
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003EFB RID: 16123
		private static readonly IntPtr NativeMethodInfoPtr_ResolveActionAndBinding_Public_Boolean_byref_InputAction_byref_Int32_0;

		// Token: 0x04003EFC RID: 16124
		private static readonly IntPtr NativeMethodInfoPtr_IsRebinding_Public_Boolean_0;

		// Token: 0x04003EFD RID: 16125
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindingDisplay_Public_Void_0;

		// Token: 0x04003EFE RID: 16126
		private static readonly IntPtr NativeMethodInfoPtr_ResetToDefault_Public_Void_0;

		// Token: 0x04003EFF RID: 16127
		private static readonly IntPtr NativeMethodInfoPtr_StartInteractiveRebind_Public_Void_0;

		// Token: 0x04003F00 RID: 16128
		private static readonly IntPtr NativeMethodInfoPtr_PerformInteractiveRebind_Private_Void_InputAction_Int32_Boolean_0;

		// Token: 0x04003F01 RID: 16129
		private static readonly IntPtr NativeMethodInfoPtr_SwapConflictingBindings_Private_Void_String_String_0;

		// Token: 0x04003F02 RID: 16130
		private static readonly IntPtr NativeMethodInfoPtr_SyncDerivedActions_Private_Void_String_String_0;

		// Token: 0x04003F03 RID: 16131
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x04003F04 RID: 16132
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

		// Token: 0x04003F05 RID: 16133
		private static readonly IntPtr NativeMethodInfoPtr_OnActionChange_Private_Static_Void_Object_InputActionChange_0;

		// Token: 0x04003F06 RID: 16134
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActionLabel_Private_Void_0;

		// Token: 0x04003F07 RID: 16135
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F08 RID: 16136
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__33_0_Private_Void_RebindActionUI_RebindingOperation_0;

		// Token: 0x04003F09 RID: 16137
		private static readonly IntPtr NativeMethodInfoPtr__UpdateBindingDisplay_b__36_0_Private_Boolean_InputBinding_0;

		// Token: 0x02000AFA RID: 2810
		[Serializable]
		public class UpdateBindingUIEvent : UnityEvent<RebindActionUI, string, string, string>
		{
			// Token: 0x0600E53E RID: 58686 RVA: 0x0006C157 File Offset: 0x0006A357
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateBindingUIEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "UpdateBindingUIEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr);
				RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr, 100675290);
			}

			// Token: 0x0600E53F RID: 58687 RVA: 0x00380794 File Offset: 0x0037E994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197154, XrefRangeEnd = 197157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateBindingUIEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.UpdateBindingUIEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.UpdateBindingUIEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E540 RID: 58688 RVA: 0x0006C18B File Offset: 0x0006A38B
			public UpdateBindingUIEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009BA3 RID: 39843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFB RID: 2811
		[Serializable]
		public class InteractiveRebindEvent : UnityEvent<RebindActionUI, InputActionRebindingExtensions.RebindingOperation>
		{
			// Token: 0x0600E541 RID: 58689 RVA: 0x0006C194 File Offset: 0x0006A394
			// Note: this type is marked as 'beforefieldinit'.
			static InteractiveRebindEvent()
			{
				Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "InteractiveRebindEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr);
				RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr, 100675291);
			}

			// Token: 0x0600E542 RID: 58690 RVA: 0x003807D0 File Offset: 0x0037E9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197157, XrefRangeEnd = 197160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InteractiveRebindEvent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.InteractiveRebindEvent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.InteractiveRebindEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E543 RID: 58691 RVA: 0x0006C1C8 File Offset: 0x0006A3C8
			public InteractiveRebindEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04009BA4 RID: 39844
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFC RID: 2812
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E544 RID: 58692 RVA: 0x0038080C File Offset: 0x0037EA0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr);
				RebindActionUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr, "<>9");
				RebindActionUI.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr, "<>9__1_0");
				RebindActionUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr, 100675293);
				RebindActionUI.__c.NativeMethodInfoPtr__get_IsRebindingInProgress_b__1_0_Internal_Boolean_RebindActionUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr, 100675294);
			}

			// Token: 0x0600E545 RID: 58693 RVA: 0x00380888 File Offset: 0x0037EA88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E546 RID: 58694 RVA: 0x003808C4 File Offset: 0x0037EAC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197160, XrefRangeEnd = 197162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsRebindingInProgress_b__1_0(RebindActionUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c.NativeMethodInfoPtr__get_IsRebindingInProgress_b__1_0_Internal_Boolean_RebindActionUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E547 RID: 58695 RVA: 0x0006C1D1 File Offset: 0x0006A3D1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A9 RID: 17833
			// (get) Token: 0x0600E548 RID: 58696 RVA: 0x00380914 File Offset: 0x0037EB14
			// (set) Token: 0x0600E549 RID: 58697 RVA: 0x0006C1DA File Offset: 0x0006A3DA
			public unsafe static RebindActionUI.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RebindActionUI.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RebindActionUI.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AA RID: 17834
			// (get) Token: 0x0600E54A RID: 58698 RVA: 0x0038093C File Offset: 0x0037EB3C
			// (set) Token: 0x0600E54B RID: 58699 RVA: 0x0006C1EC File Offset: 0x0006A3EC
			public unsafe static Predicate<RebindActionUI> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RebindActionUI.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<RebindActionUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RebindActionUI.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BA5 RID: 39845
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009BA6 RID: 39846
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04009BA7 RID: 39847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BA8 RID: 39848
			private static readonly IntPtr NativeMethodInfoPtr__get_IsRebindingInProgress_b__1_0_Internal_Boolean_RebindActionUI_0;
		}

		// Token: 0x02000AFD RID: 2813
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E54C RID: 58700 RVA: 0x00380964 File Offset: 0x0037EB64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, "bindingId");
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675295);
				RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr, 100675296);
			}

			// Token: 0x0600E54D RID: 58701 RVA: 0x003809CC File Offset: 0x0037EBCC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E54E RID: 58702 RVA: 0x00380A08 File Offset: 0x0037EC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197162, XrefRangeEnd = 197164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveActionAndBinding_b__0(InputBinding x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass34_0.NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E54F RID: 58703 RVA: 0x0006C1FE File Offset: 0x0006A3FE
			public __c__DisplayClass34_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045AB RID: 17835
			// (get) Token: 0x0600E550 RID: 58704 RVA: 0x00380A5C File Offset: 0x0037EC5C
			// (set) Token: 0x0600E551 RID: 58705 RVA: 0x0006C207 File Offset: 0x0006A407
			public unsafe Guid bindingId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass34_0.NativeFieldInfoPtr_bindingId)) = value;
				}
			}

			// Token: 0x04009BA9 RID: 39849
			private static readonly IntPtr NativeFieldInfoPtr_bindingId;

			// Token: 0x04009BAA RID: 39850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BAB RID: 39851
			private static readonly IntPtr NativeMethodInfoPtr__ResolveActionAndBinding_b__0_Internal_Boolean_InputBinding_0;
		}

		// Token: 0x02000AFE RID: 2814
		[ObfuscatedName("ScheduleOne.DevUtilities.RebindActionUI+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E552 RID: 58706 RVA: 0x00380A84 File Offset: 0x0037EC84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RebindActionUI>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr);
				RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
				RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_oldPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, "oldPath");
				RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, "action");
				RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_bindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, "bindingIndex");
				RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_allCompositeParts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, "allCompositeParts");
				RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, 100675297);
				RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, 100675298);
				RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, 100675299);
				RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr, 100675300);
			}

			// Token: 0x0600E553 RID: 58707 RVA: 0x00380B64 File Offset: 0x0037ED64
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RebindActionUI.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E554 RID: 58708 RVA: 0x00380BA0 File Offset: 0x0037EDA0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197169, RefRangeEnd = 197171, XrefRangeStart = 197164, XrefRangeEnd = 197169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E555 RID: 58709 RVA: 0x00380BD4 File Offset: 0x0037EDD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197171, XrefRangeEnd = 197191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__1(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E556 RID: 58710 RVA: 0x00380C18 File Offset: 0x0037EE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197191, XrefRangeEnd = 197220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _PerformInteractiveRebind_b__2(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RebindActionUI.__c__DisplayClass39_0.NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E557 RID: 58711 RVA: 0x0006C222 File Offset: 0x0006A422
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045AC RID: 17836
			// (get) Token: 0x0600E558 RID: 58712 RVA: 0x00380C5C File Offset: 0x0037EE5C
			// (set) Token: 0x0600E559 RID: 58713 RVA: 0x0006C22B File Offset: 0x0006A42B
			public unsafe RebindActionUI __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RebindActionUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AD RID: 17837
			// (get) Token: 0x0600E55A RID: 58714 RVA: 0x00380C8C File Offset: 0x0037EE8C
			// (set) Token: 0x0600E55B RID: 58715 RVA: 0x0006C24A File Offset: 0x0006A44A
			public unsafe string oldPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_oldPath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_oldPath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045AE RID: 17838
			// (get) Token: 0x0600E55C RID: 58716 RVA: 0x00380CB4 File Offset: 0x0037EEB4
			// (set) Token: 0x0600E55D RID: 58717 RVA: 0x0006C269 File Offset: 0x0006A469
			public unsafe InputAction action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AF RID: 17839
			// (get) Token: 0x0600E55E RID: 58718 RVA: 0x00380CE4 File Offset: 0x0037EEE4
			// (set) Token: 0x0600E55F RID: 58719 RVA: 0x0006C288 File Offset: 0x0006A488
			public unsafe int bindingIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_bindingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_bindingIndex)) = value;
				}
			}

			// Token: 0x170045B0 RID: 17840
			// (get) Token: 0x0600E560 RID: 58720 RVA: 0x00380D0C File Offset: 0x0037EF0C
			// (set) Token: 0x0600E561 RID: 58721 RVA: 0x0006C2A3 File Offset: 0x0006A4A3
			public unsafe bool allCompositeParts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_allCompositeParts);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RebindActionUI.__c__DisplayClass39_0.NativeFieldInfoPtr_allCompositeParts)) = value;
				}
			}

			// Token: 0x04009BAC RID: 39852
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BAD RID: 39853
			private static readonly IntPtr NativeFieldInfoPtr_oldPath;

			// Token: 0x04009BAE RID: 39854
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04009BAF RID: 39855
			private static readonly IntPtr NativeFieldInfoPtr_bindingIndex;

			// Token: 0x04009BB0 RID: 39856
			private static readonly IntPtr NativeFieldInfoPtr_allCompositeParts;

			// Token: 0x04009BB1 RID: 39857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BB2 RID: 39858
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04009BB3 RID: 39859
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__1_Internal_Void_RebindingOperation_0;

			// Token: 0x04009BB4 RID: 39860
			private static readonly IntPtr NativeMethodInfoPtr__PerformInteractiveRebind_b__2_Internal_Void_RebindingOperation_0;
		}
	}
}
