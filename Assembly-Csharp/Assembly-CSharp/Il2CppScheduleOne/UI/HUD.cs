using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073B RID: 1851
	public class HUD : Singleton<HUD>
	{
		// Token: 0x0600B2BB RID: 45755 RVA: 0x002E924C File Offset: 0x002E744C
		// Note: this type is marked as 'beforefieldinit'.
		static HUD()
		{
			Il2CppClassPointerStore<HUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "HUD");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD>.NativeClassPtr);
			HUD.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvas");
			HUD.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "canvasRect");
			HUD.NativeFieldInfoPtr_crosshair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "crosshair");
			HUD.NativeFieldInfoPtr_blackOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlay");
			HUD.NativeFieldInfoPtr_radialIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicator");
			HUD.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "raycaster");
			HUD.NativeFieldInfoPtr_topScreenText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText");
			HUD.NativeFieldInfoPtr_topScreenText_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "topScreenText_Background");
			HUD.NativeFieldInfoPtr_fpsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "fpsLabel");
			HUD.NativeFieldInfoPtr_cashSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotContainer");
			HUD.NativeFieldInfoPtr_cashSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "cashSlotUI");
			HUD.NativeFieldInfoPtr_onlineBalanceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceContainer");
			HUD.NativeFieldInfoPtr_onlineBalanceSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "onlineBalanceSlotUI");
			HUD.NativeFieldInfoPtr_managementSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotContainer");
			HUD.NativeFieldInfoPtr_managementSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "managementSlotUI");
			HUD.NativeFieldInfoPtr_HotbarContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "HotbarContainer");
			HUD.NativeFieldInfoPtr_SlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SlotContainer");
			HUD.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlot");
			HUD.NativeFieldInfoPtr_discardSlotFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "discardSlotFill");
			HUD.NativeFieldInfoPtr_selectedItemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "selectedItemLabel");
			HUD.NativeFieldInfoPtr_QuestEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryContainer");
			HUD.NativeFieldInfoPtr_QuestEntryTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "QuestEntryTitle");
			HUD.NativeFieldInfoPtr_CrimeStatusUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrimeStatusUI");
			HUD.NativeFieldInfoPtr_OnlineBalanceDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "OnlineBalanceDisplay");
			HUD.NativeFieldInfoPtr_CrosshairText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CrosshairText");
			HUD.NativeFieldInfoPtr_UnreadMessagesPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "UnreadMessagesPrompt");
			HUD.NativeFieldInfoPtr_SleepPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SleepPrompt");
			HUD.NativeFieldInfoPtr_CurfewPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CurfewPrompt");
			HUD.NativeFieldInfoPtr_NotificationsCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "NotificationsCanvasGroup");
			HUD.NativeFieldInfoPtr_CashSlotHintAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CashSlotHintAnim");
			HUD.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "CashSlotHintAnimCanvasGroup");
			HUD.NativeFieldInfoPtr__reticleController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "_reticleController");
			HUD.NativeFieldInfoPtr_StackSplitTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "StackSplitTutorial");
			HUD.NativeFieldInfoPtr_RedGreenGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "RedGreenGradient");
			HUD.NativeFieldInfoPtr_SampleSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "SampleSize");
			HUD.NativeFieldInfoPtr__previousFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "_previousFPS");
			HUD.NativeFieldInfoPtr_blackOverlayFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "blackOverlayFade");
			HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD>.NativeClassPtr, "radialIndicatorSetThisFrame");
			HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686792);
			HUD.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686793);
			HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686794);
			HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686795);
			HUD.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686796);
			HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686797);
			HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686798);
			HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686799);
			HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686800);
			HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686801);
			HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686802);
			HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686803);
			HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686804);
			HUD.NativeMethodInfoPtr_ShowFirearmReticle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686805);
			HUD.NativeMethodInfoPtr_HideFirearmReticle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686806);
			HUD.NativeMethodInfoPtr_SetFirearmReticle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686807);
			HUD.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD>.NativeClassPtr, 100686808);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x002E96C8 File Offset: 0x002E78C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302438, XrefRangeEnd = 302446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x002E9704 File Offset: 0x002E7904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302446, XrefRangeEnd = 302458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x002E9740 File Offset: 0x002E7940
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 230144, RefRangeEnd = 230156, XrefRangeStart = 230144, XrefRangeEnd = 230156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrosshairVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x002E9780 File Offset: 0x002E7980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302458, XrefRangeEnd = 302466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBlackOverlayVisible(bool vis, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x002E97CC File Offset: 0x002E79CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302466, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x002E9800 File Offset: 0x002E7A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302502, XrefRangeEnd = 302508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuestEntryTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x002E9834 File Offset: 0x002E7A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302527, RefRangeEnd = 302528, XrefRangeStart = 302508, XrefRangeEnd = 302527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_RefreshFPS_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x002E9868 File Offset: 0x002E7A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302528, XrefRangeEnd = 302533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageFPS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_GetAverageFPS_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x002E98A4 File Offset: 0x002E7AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302533, XrefRangeEnd = 302551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HUD.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x002E98E0 File Offset: 0x002E7AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302551, XrefRangeEnd = 302556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator FadeBlackOverlay(bool visible, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x002E993C File Offset: 0x002E7B3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302559, RefRangeEnd = 302562, XrefRangeStart = 302556, XrefRangeEnd = 302559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowRadialIndicator(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x002E997C File Offset: 0x002E7B7C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302567, RefRangeEnd = 302572, XrefRangeStart = 302562, XrefRangeEnd = 302567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTopScreenText(string t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x002E99C0 File Offset: 0x002E7BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302575, RefRangeEnd = 302577, XrefRangeStart = 302572, XrefRangeEnd = 302575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTopScreenText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_HideTopScreenText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x002E99F4 File Offset: 0x002E7BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302578, RefRangeEnd = 302579, XrefRangeStart = 302577, XrefRangeEnd = 302578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowFirearmReticle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_ShowFirearmReticle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x002E9A28 File Offset: 0x002E7C28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302580, RefRangeEnd = 302582, XrefRangeStart = 302579, XrefRangeEnd = 302580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideFirearmReticle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_HideFirearmReticle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x002E9A5C File Offset: 0x002E7C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302584, RefRangeEnd = 302585, XrefRangeStart = 302582, XrefRangeEnd = 302584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFirearmReticle(float spreadAngle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref spreadAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr_SetFirearmReticle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x002E9A9C File Offset: 0x002E7C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302585, XrefRangeEnd = 302595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HUD() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x00052468 File Offset: 0x00050668
		public HUD(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x002E9AD8 File Offset: 0x002E7CD8
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x00052471 File Offset: 0x00050671
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x002E9B08 File Offset: 0x002E7D08
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x00052490 File Offset: 0x00050690
		public unsafe RectTransform canvasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600B2D2 RID: 45778 RVA: 0x002E9B38 File Offset: 0x002E7D38
		// (set) Token: 0x0600B2D3 RID: 45779 RVA: 0x000524AF File Offset: 0x000506AF
		public unsafe Image crosshair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_crosshair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600B2D4 RID: 45780 RVA: 0x002E9B68 File Offset: 0x002E7D68
		// (set) Token: 0x0600B2D5 RID: 45781 RVA: 0x000524CE File Offset: 0x000506CE
		public unsafe Image blackOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600B2D6 RID: 45782 RVA: 0x002E9B98 File Offset: 0x002E7D98
		// (set) Token: 0x0600B2D7 RID: 45783 RVA: 0x000524ED File Offset: 0x000506ED
		public unsafe Image radialIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600B2D8 RID: 45784 RVA: 0x002E9BC8 File Offset: 0x002E7DC8
		// (set) Token: 0x0600B2D9 RID: 45785 RVA: 0x0005250C File Offset: 0x0005070C
		public unsafe GraphicRaycaster raycaster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicRaycaster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600B2DA RID: 45786 RVA: 0x002E9BF8 File Offset: 0x002E7DF8
		// (set) Token: 0x0600B2DB RID: 45787 RVA: 0x0005252B File Offset: 0x0005072B
		public unsafe TextMeshProUGUI topScreenText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600B2DC RID: 45788 RVA: 0x002E9C28 File Offset: 0x002E7E28
		// (set) Token: 0x0600B2DD RID: 45789 RVA: 0x0005254A File Offset: 0x0005074A
		public unsafe RectTransform topScreenText_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_topScreenText_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600B2DE RID: 45790 RVA: 0x002E9C58 File Offset: 0x002E7E58
		// (set) Token: 0x0600B2DF RID: 45791 RVA: 0x00052569 File Offset: 0x00050769
		public unsafe Text fpsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_fpsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600B2E0 RID: 45792 RVA: 0x002E9C88 File Offset: 0x002E7E88
		// (set) Token: 0x0600B2E1 RID: 45793 RVA: 0x00052588 File Offset: 0x00050788
		public unsafe RectTransform cashSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600B2E2 RID: 45794 RVA: 0x002E9CB8 File Offset: 0x002E7EB8
		// (set) Token: 0x0600B2E3 RID: 45795 RVA: 0x000525A7 File Offset: 0x000507A7
		public unsafe RectTransform cashSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_cashSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600B2E4 RID: 45796 RVA: 0x002E9CE8 File Offset: 0x002E7EE8
		// (set) Token: 0x0600B2E5 RID: 45797 RVA: 0x000525C6 File Offset: 0x000507C6
		public unsafe RectTransform onlineBalanceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600B2E6 RID: 45798 RVA: 0x002E9D18 File Offset: 0x002E7F18
		// (set) Token: 0x0600B2E7 RID: 45799 RVA: 0x000525E5 File Offset: 0x000507E5
		public unsafe RectTransform onlineBalanceSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_onlineBalanceSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600B2E8 RID: 45800 RVA: 0x002E9D48 File Offset: 0x002E7F48
		// (set) Token: 0x0600B2E9 RID: 45801 RVA: 0x00052604 File Offset: 0x00050804
		public unsafe RectTransform managementSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600B2EA RID: 45802 RVA: 0x002E9D78 File Offset: 0x002E7F78
		// (set) Token: 0x0600B2EB RID: 45803 RVA: 0x00052623 File Offset: 0x00050823
		public unsafe ItemSlotUI managementSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_managementSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600B2EC RID: 45804 RVA: 0x002E9DA8 File Offset: 0x002E7FA8
		// (set) Token: 0x0600B2ED RID: 45805 RVA: 0x00052642 File Offset: 0x00050842
		public unsafe RectTransform HotbarContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_HotbarContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600B2EE RID: 45806 RVA: 0x002E9DD8 File Offset: 0x002E7FD8
		// (set) Token: 0x0600B2EF RID: 45807 RVA: 0x00052661 File Offset: 0x00050861
		public unsafe RectTransform SlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600B2F0 RID: 45808 RVA: 0x002E9E08 File Offset: 0x002E8008
		// (set) Token: 0x0600B2F1 RID: 45809 RVA: 0x00052680 File Offset: 0x00050880
		public unsafe ItemSlotUI discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600B2F2 RID: 45810 RVA: 0x002E9E38 File Offset: 0x002E8038
		// (set) Token: 0x0600B2F3 RID: 45811 RVA: 0x0005269F File Offset: 0x0005089F
		public unsafe Image discardSlotFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_discardSlotFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600B2F4 RID: 45812 RVA: 0x002E9E68 File Offset: 0x002E8068
		// (set) Token: 0x0600B2F5 RID: 45813 RVA: 0x000526BE File Offset: 0x000508BE
		public unsafe TextMeshProUGUI selectedItemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_selectedItemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600B2F6 RID: 45814 RVA: 0x002E9E98 File Offset: 0x002E8098
		// (set) Token: 0x0600B2F7 RID: 45815 RVA: 0x000526DD File Offset: 0x000508DD
		public unsafe RectTransform QuestEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600B2F8 RID: 45816 RVA: 0x002E9EC8 File Offset: 0x002E80C8
		// (set) Token: 0x0600B2F9 RID: 45817 RVA: 0x000526FC File Offset: 0x000508FC
		public unsafe TextMeshProUGUI QuestEntryTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_QuestEntryTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600B2FA RID: 45818 RVA: 0x002E9EF8 File Offset: 0x002E80F8
		// (set) Token: 0x0600B2FB RID: 45819 RVA: 0x0005271B File Offset: 0x0005091B
		public unsafe CrimeStatusUI CrimeStatusUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrimeStatusUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrimeStatusUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x002E9F28 File Offset: 0x002E8128
		// (set) Token: 0x0600B2FD RID: 45821 RVA: 0x0005273A File Offset: 0x0005093A
		public unsafe BalanceDisplay OnlineBalanceDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BalanceDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_OnlineBalanceDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600B2FE RID: 45822 RVA: 0x002E9F58 File Offset: 0x002E8158
		// (set) Token: 0x0600B2FF RID: 45823 RVA: 0x00052759 File Offset: 0x00050959
		public unsafe CrosshairText CrosshairText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CrosshairText>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CrosshairText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600B300 RID: 45824 RVA: 0x002E9F88 File Offset: 0x002E8188
		// (set) Token: 0x0600B301 RID: 45825 RVA: 0x00052778 File Offset: 0x00050978
		public unsafe RectTransform UnreadMessagesPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_UnreadMessagesPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600B302 RID: 45826 RVA: 0x002E9FB8 File Offset: 0x002E81B8
		// (set) Token: 0x0600B303 RID: 45827 RVA: 0x00052797 File Offset: 0x00050997
		public unsafe TextMeshProUGUI SleepPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SleepPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600B304 RID: 45828 RVA: 0x002E9FE8 File Offset: 0x002E81E8
		// (set) Token: 0x0600B305 RID: 45829 RVA: 0x000527B6 File Offset: 0x000509B6
		public unsafe TextMeshProUGUI CurfewPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CurfewPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600B306 RID: 45830 RVA: 0x002EA018 File Offset: 0x002E8218
		// (set) Token: 0x0600B307 RID: 45831 RVA: 0x000527D5 File Offset: 0x000509D5
		public unsafe CanvasGroup NotificationsCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_NotificationsCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_NotificationsCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600B308 RID: 45832 RVA: 0x002EA048 File Offset: 0x002E8248
		// (set) Token: 0x0600B309 RID: 45833 RVA: 0x000527F4 File Offset: 0x000509F4
		public unsafe Animation CashSlotHintAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CashSlotHintAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CashSlotHintAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600B30A RID: 45834 RVA: 0x002EA078 File Offset: 0x002E8278
		// (set) Token: 0x0600B30B RID: 45835 RVA: 0x00052813 File Offset: 0x00050A13
		public unsafe CanvasGroup CashSlotHintAnimCanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600B30C RID: 45836 RVA: 0x002EA0A8 File Offset: 0x002E82A8
		// (set) Token: 0x0600B30D RID: 45837 RVA: 0x00052832 File Offset: 0x00050A32
		public unsafe ReticleController _reticleController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__reticleController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReticleController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__reticleController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600B30E RID: 45838 RVA: 0x002EA0D8 File Offset: 0x002E82D8
		// (set) Token: 0x0600B30F RID: 45839 RVA: 0x00052851 File Offset: 0x00050A51
		public unsafe StackSplitTutorial StackSplitTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_StackSplitTutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackSplitTutorial>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_StackSplitTutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600B310 RID: 45840 RVA: 0x002EA108 File Offset: 0x002E8308
		// (set) Token: 0x0600B311 RID: 45841 RVA: 0x00052870 File Offset: 0x00050A70
		public unsafe Gradient RedGreenGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_RedGreenGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600B312 RID: 45842 RVA: 0x002EA138 File Offset: 0x002E8338
		// (set) Token: 0x0600B313 RID: 45843 RVA: 0x0005288F File Offset: 0x00050A8F
		public unsafe int SampleSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_SampleSize)) = value;
			}
		}

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x002EA160 File Offset: 0x002E8360
		// (set) Token: 0x0600B315 RID: 45845 RVA: 0x000528AA File Offset: 0x00050AAA
		public unsafe List<float> _previousFPS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr__previousFPS), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x002EA190 File Offset: 0x002E8390
		// (set) Token: 0x0600B317 RID: 45847 RVA: 0x000528C9 File Offset: 0x00050AC9
		public unsafe Coroutine blackOverlayFade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_blackOverlayFade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600B318 RID: 45848 RVA: 0x002EA1C0 File Offset: 0x002E83C0
		// (set) Token: 0x0600B319 RID: 45849 RVA: 0x000528E8 File Offset: 0x00050AE8
		public unsafe bool radialIndicatorSetThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD.NativeFieldInfoPtr_radialIndicatorSetThisFrame)) = value;
			}
		}

		// Token: 0x04007B15 RID: 31509
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007B16 RID: 31510
		private static readonly IntPtr NativeFieldInfoPtr_canvasRect;

		// Token: 0x04007B17 RID: 31511
		private static readonly IntPtr NativeFieldInfoPtr_crosshair;

		// Token: 0x04007B18 RID: 31512
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlay;

		// Token: 0x04007B19 RID: 31513
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicator;

		// Token: 0x04007B1A RID: 31514
		private static readonly IntPtr NativeFieldInfoPtr_raycaster;

		// Token: 0x04007B1B RID: 31515
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText;

		// Token: 0x04007B1C RID: 31516
		private static readonly IntPtr NativeFieldInfoPtr_topScreenText_Background;

		// Token: 0x04007B1D RID: 31517
		private static readonly IntPtr NativeFieldInfoPtr_fpsLabel;

		// Token: 0x04007B1E RID: 31518
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotContainer;

		// Token: 0x04007B1F RID: 31519
		private static readonly IntPtr NativeFieldInfoPtr_cashSlotUI;

		// Token: 0x04007B20 RID: 31520
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceContainer;

		// Token: 0x04007B21 RID: 31521
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceSlotUI;

		// Token: 0x04007B22 RID: 31522
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotContainer;

		// Token: 0x04007B23 RID: 31523
		private static readonly IntPtr NativeFieldInfoPtr_managementSlotUI;

		// Token: 0x04007B24 RID: 31524
		private static readonly IntPtr NativeFieldInfoPtr_HotbarContainer;

		// Token: 0x04007B25 RID: 31525
		private static readonly IntPtr NativeFieldInfoPtr_SlotContainer;

		// Token: 0x04007B26 RID: 31526
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x04007B27 RID: 31527
		private static readonly IntPtr NativeFieldInfoPtr_discardSlotFill;

		// Token: 0x04007B28 RID: 31528
		private static readonly IntPtr NativeFieldInfoPtr_selectedItemLabel;

		// Token: 0x04007B29 RID: 31529
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryContainer;

		// Token: 0x04007B2A RID: 31530
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryTitle;

		// Token: 0x04007B2B RID: 31531
		private static readonly IntPtr NativeFieldInfoPtr_CrimeStatusUI;

		// Token: 0x04007B2C RID: 31532
		private static readonly IntPtr NativeFieldInfoPtr_OnlineBalanceDisplay;

		// Token: 0x04007B2D RID: 31533
		private static readonly IntPtr NativeFieldInfoPtr_CrosshairText;

		// Token: 0x04007B2E RID: 31534
		private static readonly IntPtr NativeFieldInfoPtr_UnreadMessagesPrompt;

		// Token: 0x04007B2F RID: 31535
		private static readonly IntPtr NativeFieldInfoPtr_SleepPrompt;

		// Token: 0x04007B30 RID: 31536
		private static readonly IntPtr NativeFieldInfoPtr_CurfewPrompt;

		// Token: 0x04007B31 RID: 31537
		private static readonly IntPtr NativeFieldInfoPtr_NotificationsCanvasGroup;

		// Token: 0x04007B32 RID: 31538
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnim;

		// Token: 0x04007B33 RID: 31539
		private static readonly IntPtr NativeFieldInfoPtr_CashSlotHintAnimCanvasGroup;

		// Token: 0x04007B34 RID: 31540
		private static readonly IntPtr NativeFieldInfoPtr__reticleController;

		// Token: 0x04007B35 RID: 31541
		private static readonly IntPtr NativeFieldInfoPtr_StackSplitTutorial;

		// Token: 0x04007B36 RID: 31542
		private static readonly IntPtr NativeFieldInfoPtr_RedGreenGradient;

		// Token: 0x04007B37 RID: 31543
		private static readonly IntPtr NativeFieldInfoPtr_SampleSize;

		// Token: 0x04007B38 RID: 31544
		private static readonly IntPtr NativeFieldInfoPtr__previousFPS;

		// Token: 0x04007B39 RID: 31545
		private static readonly IntPtr NativeFieldInfoPtr_blackOverlayFade;

		// Token: 0x04007B3A RID: 31546
		private static readonly IntPtr NativeFieldInfoPtr_radialIndicatorSetThisFrame;

		// Token: 0x04007B3B RID: 31547
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007B3C RID: 31548
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007B3D RID: 31549
		private static readonly IntPtr NativeMethodInfoPtr_SetCrosshairVisible_Public_Void_Boolean_0;

		// Token: 0x04007B3E RID: 31550
		private static readonly IntPtr NativeMethodInfoPtr_SetBlackOverlayVisible_Public_Void_Boolean_Single_0;

		// Token: 0x04007B3F RID: 31551
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007B40 RID: 31552
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuestEntryTitle_Private_Void_0;

		// Token: 0x04007B41 RID: 31553
		private static readonly IntPtr NativeMethodInfoPtr_RefreshFPS_Private_Void_0;

		// Token: 0x04007B42 RID: 31554
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageFPS_Private_Single_0;

		// Token: 0x04007B43 RID: 31555
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04007B44 RID: 31556
		private static readonly IntPtr NativeMethodInfoPtr_FadeBlackOverlay_Protected_IEnumerator_Boolean_Single_0;

		// Token: 0x04007B45 RID: 31557
		private static readonly IntPtr NativeMethodInfoPtr_ShowRadialIndicator_Public_Void_Single_0;

		// Token: 0x04007B46 RID: 31558
		private static readonly IntPtr NativeMethodInfoPtr_ShowTopScreenText_Public_Void_String_0;

		// Token: 0x04007B47 RID: 31559
		private static readonly IntPtr NativeMethodInfoPtr_HideTopScreenText_Public_Void_0;

		// Token: 0x04007B48 RID: 31560
		private static readonly IntPtr NativeMethodInfoPtr_ShowFirearmReticle_Public_Void_0;

		// Token: 0x04007B49 RID: 31561
		private static readonly IntPtr NativeMethodInfoPtr_HideFirearmReticle_Public_Void_0;

		// Token: 0x04007B4A RID: 31562
		private static readonly IntPtr NativeMethodInfoPtr_SetFirearmReticle_Public_Void_Single_0;

		// Token: 0x04007B4B RID: 31563
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CD0 RID: 3280
		[ObfuscatedName("ScheduleOne.UI.HUD+<FadeBlackOverlay>d__46")]
		public sealed class _FadeBlackOverlay_d__46 : Il2CppSystem.Object
		{
			// Token: 0x0600F516 RID: 62742 RVA: 0x003AE1C0 File Offset: 0x003AC3C0
			// Note: this type is marked as 'beforefieldinit'.
			static _FadeBlackOverlay_d__46()
			{
				Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HUD>.NativeClassPtr, "<FadeBlackOverlay>d__46");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr);
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<>1__state");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<>2__current");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "visible");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<>4__this");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "fadeTime");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<startAlpha>5__2");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__endAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<endAlpha>5__3");
				HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, "<i>5__4");
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686809);
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686810);
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686811);
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686812);
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686813);
				HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr, 100686814);
			}

			// Token: 0x0600F517 RID: 62743 RVA: 0x003AE304 File Offset: 0x003AC504
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FadeBlackOverlay_d__46(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUD._FadeBlackOverlay_d__46>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F518 RID: 62744 RVA: 0x003AE34C File Offset: 0x003AC54C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F519 RID: 62745 RVA: 0x003AE380 File Offset: 0x003AC580
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302410, XrefRangeEnd = 302433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004A78 RID: 19064
			// (get) Token: 0x0600F51A RID: 62746 RVA: 0x003AE3BC File Offset: 0x003AC5BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F51B RID: 62747 RVA: 0x003AE3FC File Offset: 0x003AC5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302433, XrefRangeEnd = 302438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004A79 RID: 19065
			// (get) Token: 0x0600F51C RID: 62748 RVA: 0x003AE430 File Offset: 0x003AC630
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HUD._FadeBlackOverlay_d__46.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F51D RID: 62749 RVA: 0x00073D2F File Offset: 0x00071F2F
			public _FadeBlackOverlay_d__46(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A70 RID: 19056
			// (get) Token: 0x0600F51E RID: 62750 RVA: 0x003AE470 File Offset: 0x003AC670
			// (set) Token: 0x0600F51F RID: 62751 RVA: 0x00073D38 File Offset: 0x00071F38
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A71 RID: 19057
			// (get) Token: 0x0600F520 RID: 62752 RVA: 0x003AE498 File Offset: 0x003AC698
			// (set) Token: 0x0600F521 RID: 62753 RVA: 0x00073D53 File Offset: 0x00071F53
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A72 RID: 19058
			// (get) Token: 0x0600F522 RID: 62754 RVA: 0x003AE4C8 File Offset: 0x003AC6C8
			// (set) Token: 0x0600F523 RID: 62755 RVA: 0x00073D72 File Offset: 0x00071F72
			public unsafe bool visible
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x17004A73 RID: 19059
			// (get) Token: 0x0600F524 RID: 62756 RVA: 0x003AE4F0 File Offset: 0x003AC6F0
			// (set) Token: 0x0600F525 RID: 62757 RVA: 0x00073D8D File Offset: 0x00071F8D
			public unsafe HUD __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HUD>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A74 RID: 19060
			// (get) Token: 0x0600F526 RID: 62758 RVA: 0x003AE520 File Offset: 0x003AC720
			// (set) Token: 0x0600F527 RID: 62759 RVA: 0x00073DAC File Offset: 0x00071FAC
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x17004A75 RID: 19061
			// (get) Token: 0x0600F528 RID: 62760 RVA: 0x003AE548 File Offset: 0x003AC748
			// (set) Token: 0x0600F529 RID: 62761 RVA: 0x00073DC7 File Offset: 0x00071FC7
			public unsafe float _startAlpha_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__startAlpha_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__startAlpha_5__2)) = value;
				}
			}

			// Token: 0x17004A76 RID: 19062
			// (get) Token: 0x0600F52A RID: 62762 RVA: 0x003AE570 File Offset: 0x003AC770
			// (set) Token: 0x0600F52B RID: 62763 RVA: 0x00073DE2 File Offset: 0x00071FE2
			public unsafe float _endAlpha_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__endAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__endAlpha_5__3)) = value;
				}
			}

			// Token: 0x17004A77 RID: 19063
			// (get) Token: 0x0600F52C RID: 62764 RVA: 0x003AE598 File Offset: 0x003AC798
			// (set) Token: 0x0600F52D RID: 62765 RVA: 0x00073DFD File Offset: 0x00071FFD
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HUD._FadeBlackOverlay_d__46.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x0400A5D8 RID: 42456
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A5D9 RID: 42457
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A5DA RID: 42458
			private static readonly IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x0400A5DB RID: 42459
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A5DC RID: 42460
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x0400A5DD RID: 42461
			private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

			// Token: 0x0400A5DE RID: 42462
			private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__3;

			// Token: 0x0400A5DF RID: 42463
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x0400A5E0 RID: 42464
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A5E1 RID: 42465
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5E2 RID: 42466
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A5E3 RID: 42467
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A5E4 RID: 42468
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A5E5 RID: 42469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
