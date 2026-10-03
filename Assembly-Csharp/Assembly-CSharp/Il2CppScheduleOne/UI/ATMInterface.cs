using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000717 RID: 1815
	public class ATMInterface : MonoBehaviour
	{
		// Token: 0x0600AEC9 RID: 44745 RVA: 0x002DD20C File Offset: 0x002DB40C
		// Note: this type is marked as 'beforefieldinit'.
		static ATMInterface()
		{
			Il2CppClassPointerStore<ATMInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ATMInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr);
			ATMInterface.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "canvas");
			ATMInterface.NativeFieldInfoPtr_uiContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "uiContainer");
			ATMInterface.NativeFieldInfoPtr_atm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "atm");
			ATMInterface.NativeFieldInfoPtr_completeSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "completeSound");
			ATMInterface.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "state");
			ATMInterface.NativeFieldInfoPtr_menuScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menuScreen");
			ATMInterface.NativeFieldInfoPtr_menu_TitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_TitleText");
			ATMInterface.NativeFieldInfoPtr_menu_DepositButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_DepositButton");
			ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "menu_WithdrawButton");
			ATMInterface.NativeFieldInfoPtr_depositLimitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitText");
			ATMInterface.NativeFieldInfoPtr_onlineBalanceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "onlineBalanceText");
			ATMInterface.NativeFieldInfoPtr_cleanCashText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "cleanCashText");
			ATMInterface.NativeFieldInfoPtr_depositLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositLimitContainer");
			ATMInterface.NativeFieldInfoPtr_amountSelectorScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorScreen");
			ATMInterface.NativeFieldInfoPtr_amountSelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountSelectorTitle");
			ATMInterface.NativeFieldInfoPtr_amountButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountButtons");
			ATMInterface.NativeFieldInfoPtr_amountLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountLabelText");
			ATMInterface.NativeFieldInfoPtr_amountBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amountBackground");
			ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedButtonIndicator");
			ATMInterface.NativeFieldInfoPtr_confirmAmountButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmAmountButton");
			ATMInterface.NativeFieldInfoPtr_confirmButtonText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "confirmButtonText");
			ATMInterface.NativeFieldInfoPtr_processingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreen");
			ATMInterface.NativeFieldInfoPtr_processingScreenIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "processingScreenIndicator");
			ATMInterface.NativeFieldInfoPtr_successScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreen");
			ATMInterface.NativeFieldInfoPtr_successScreenSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "successScreenSubtitle");
			ATMInterface.NativeFieldInfoPtr_doneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "doneButton");
			ATMInterface.NativeFieldInfoPtr_UIScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "UIScreen");
			ATMInterface.NativeFieldInfoPtr_MenuPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "MenuPanel");
			ATMInterface.NativeFieldInfoPtr_AmountSelectorPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "AmountSelectorPanel");
			ATMInterface.NativeFieldInfoPtr_SuccessPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "SuccessPanel");
			ATMInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			ATMInterface.NativeFieldInfoPtr_activeScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "activeScreen");
			ATMInterface.NativeFieldInfoPtr_amounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "amounts");
			ATMInterface.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "depositing");
			ATMInterface.NativeFieldInfoPtr_selectedAmountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmountIndex");
			ATMInterface.NativeFieldInfoPtr_selectedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "selectedAmount");
			ATMInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686298);
			ATMInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686299);
			ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686300);
			ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686301);
			ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686302);
			ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686303);
			ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686304);
			ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686305);
			ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686306);
			ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686307);
			ATMInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686308);
			ATMInterface.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686309);
			ATMInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686310);
			ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686311);
			ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686312);
			ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686313);
			ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686314);
			ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686315);
			ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686316);
			ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686317);
			ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686318);
			ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686319);
			ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686320);
			ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686321);
			ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686322);
			ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686323);
			ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686324);
			ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686325);
			ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, 100686326);
		}

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x002DD750 File Offset: 0x002DB950
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x002DD78C File Offset: 0x002DB98C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600AECC RID: 44748 RVA: 0x002DD7CC File Offset: 0x002DB9CC
		public unsafe float relevantBalance
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 298185, RefRangeEnd = 298191, XrefRangeStart = 298178, XrefRangeEnd = 298185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600AECD RID: 44749 RVA: 0x002DD808 File Offset: 0x002DBA08
		public unsafe static float remainingAllowedDeposit
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 298195, RefRangeEnd = 298198, XrefRangeStart = 298191, XrefRangeEnd = 298195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600AECE RID: 44750 RVA: 0x002DD838 File Offset: 0x002DBA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298198, XrefRangeEnd = 298243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AECF RID: 44751 RVA: 0x002DD86C File Offset: 0x002DBA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298243, XrefRangeEnd = 298263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x002DD8A0 File Offset: 0x002DBAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298263, XrefRangeEnd = 298321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x002DD8DC File Offset: 0x002DBADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298321, XrefRangeEnd = 298327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x002DD910 File Offset: 0x002DBB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298327, XrefRangeEnd = 298420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x002DD94C File Offset: 0x002DBB4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298420, XrefRangeEnd = 298434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x002DD988 File Offset: 0x002DBB88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298449, RefRangeEnd = 298450, XrefRangeStart = 298434, XrefRangeEnd = 298449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x002DD9BC File Offset: 0x002DBBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298450, XrefRangeEnd = 298452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED6 RID: 44758 RVA: 0x002DD9F0 File Offset: 0x002DBBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298452, XrefRangeEnd = 298472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED7 RID: 44759 RVA: 0x002DDA24 File Offset: 0x002DBC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298472, XrefRangeEnd = 298485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATMInterface.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED8 RID: 44760 RVA: 0x002DDA74 File Offset: 0x002DBC74
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 298514, RefRangeEnd = 298522, XrefRangeStart = 298485, XrefRangeEnd = 298514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveScreen(RectTransform screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AED9 RID: 44761 RVA: 0x002DDAB8 File Offset: 0x002DBCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298546, RefRangeEnd = 298547, XrefRangeStart = 298522, XrefRangeEnd = 298546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDA RID: 44762 RVA: 0x002DDAEC File Offset: 0x002DBCEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298547, XrefRangeEnd = 298551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepositButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDB RID: 44763 RVA: 0x002DDB20 File Offset: 0x002DBD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298551, XrefRangeEnd = 298585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WithdrawButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x002DDB54 File Offset: 0x002DBD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298585, XrefRangeEnd = 298586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAmountSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x002DDB88 File Offset: 0x002DBD88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298591, RefRangeEnd = 298595, XrefRangeStart = 298586, XrefRangeEnd = 298591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountSelected(int amountIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amountIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x002DDBC8 File Offset: 0x002DBDC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298616, RefRangeEnd = 298618, XrefRangeStart = 298595, XrefRangeEnd = 298616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x002DDC08 File Offset: 0x002DBE08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298631, RefRangeEnd = 298633, XrefRangeStart = 298618, XrefRangeEnd = 298631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetAmountFromIndex(int index, bool depositing)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x002DDC54 File Offset: 0x002DBE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298672, RefRangeEnd = 298673, XrefRangeStart = 298633, XrefRangeEnd = 298672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvailableAmounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x002DDC88 File Offset: 0x002DBE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298673, XrefRangeEnd = 298679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AmountConfirmed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_AmountConfirmed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x002DDCBC File Offset: 0x002DBEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298679, XrefRangeEnd = 298680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x002DDCFC File Offset: 0x002DBEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298680, XrefRangeEnd = 298685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ProcessTransaction(float amount, bool depositing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depositing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x002DDD58 File Offset: 0x002DBF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoneButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x002DDD8C File Offset: 0x002DBF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToMenuButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x002DDDC0 File Offset: 0x002DBFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298685, XrefRangeEnd = 298693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATMInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x000500CD File Offset: 0x0004E2CD
		public ATMInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600AEE8 RID: 44776 RVA: 0x002DDDFC File Offset: 0x002DBFFC
		// (set) Token: 0x0600AEE9 RID: 44777 RVA: 0x000500D6 File Offset: 0x0004E2D6
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600AEEA RID: 44778 RVA: 0x002DDE2C File Offset: 0x002DC02C
		// (set) Token: 0x0600AEEB RID: 44779 RVA: 0x000500F5 File Offset: 0x0004E2F5
		public unsafe GameObject uiContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_uiContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_uiContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600AEEC RID: 44780 RVA: 0x002DDE5C File Offset: 0x002DC05C
		// (set) Token: 0x0600AEED RID: 44781 RVA: 0x00050114 File Offset: 0x0004E314
		public unsafe ATM atm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_atm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600AEEE RID: 44782 RVA: 0x002DDE8C File Offset: 0x002DC08C
		// (set) Token: 0x0600AEEF RID: 44783 RVA: 0x00050133 File Offset: 0x0004E333
		public unsafe AudioSourceController completeSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_completeSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_completeSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600AEF0 RID: 44784 RVA: 0x002DDEBC File Offset: 0x002DC0BC
		// (set) Token: 0x0600AEF1 RID: 44785 RVA: 0x00050152 File Offset: 0x0004E352
		public unsafe MonoState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600AEF2 RID: 44786 RVA: 0x002DDEEC File Offset: 0x002DC0EC
		// (set) Token: 0x0600AEF3 RID: 44787 RVA: 0x00050171 File Offset: 0x0004E371
		public unsafe RectTransform menuScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menuScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600AEF4 RID: 44788 RVA: 0x002DDF1C File Offset: 0x002DC11C
		// (set) Token: 0x0600AEF5 RID: 44789 RVA: 0x00050190 File Offset: 0x0004E390
		public unsafe Text menu_TitleText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_TitleText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600AEF6 RID: 44790 RVA: 0x002DDF4C File Offset: 0x002DC14C
		// (set) Token: 0x0600AEF7 RID: 44791 RVA: 0x000501AF File Offset: 0x0004E3AF
		public unsafe Button menu_DepositButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_DepositButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x002DDF7C File Offset: 0x002DC17C
		// (set) Token: 0x0600AEF9 RID: 44793 RVA: 0x000501CE File Offset: 0x0004E3CE
		public unsafe Button menu_WithdrawButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_menu_WithdrawButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x002DDFAC File Offset: 0x002DC1AC
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x000501ED File Offset: 0x0004E3ED
		public unsafe Text depositLimitText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x002DDFDC File Offset: 0x002DC1DC
		// (set) Token: 0x0600AEFD RID: 44797 RVA: 0x0005020C File Offset: 0x0004E40C
		public unsafe Text onlineBalanceText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_onlineBalanceText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600AEFE RID: 44798 RVA: 0x002DE00C File Offset: 0x002DC20C
		// (set) Token: 0x0600AEFF RID: 44799 RVA: 0x0005022B File Offset: 0x0004E42B
		public unsafe Text cleanCashText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_cleanCashText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600AF00 RID: 44800 RVA: 0x002DE03C File Offset: 0x002DC23C
		// (set) Token: 0x0600AF01 RID: 44801 RVA: 0x0005024A File Offset: 0x0004E44A
		public unsafe RectTransform depositLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x002DE06C File Offset: 0x002DC26C
		// (set) Token: 0x0600AF03 RID: 44803 RVA: 0x00050269 File Offset: 0x0004E469
		public unsafe RectTransform amountSelectorScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x002DE09C File Offset: 0x002DC29C
		// (set) Token: 0x0600AF05 RID: 44805 RVA: 0x00050288 File Offset: 0x0004E488
		public unsafe Text amountSelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountSelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x002DE0CC File Offset: 0x002DC2CC
		// (set) Token: 0x0600AF07 RID: 44807 RVA: 0x000502A7 File Offset: 0x0004E4A7
		public unsafe List<Button> amountButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x002DE0FC File Offset: 0x002DC2FC
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x000502C6 File Offset: 0x0004E4C6
		public unsafe Text amountLabelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600AF0A RID: 44810 RVA: 0x002DE12C File Offset: 0x002DC32C
		// (set) Token: 0x0600AF0B RID: 44811 RVA: 0x000502E5 File Offset: 0x0004E4E5
		public unsafe RectTransform amountBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_amountBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600AF0C RID: 44812 RVA: 0x002DE15C File Offset: 0x002DC35C
		// (set) Token: 0x0600AF0D RID: 44813 RVA: 0x00050304 File Offset: 0x0004E504
		public unsafe RectTransform selectedButtonIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedButtonIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600AF0E RID: 44814 RVA: 0x002DE18C File Offset: 0x002DC38C
		// (set) Token: 0x0600AF0F RID: 44815 RVA: 0x00050323 File Offset: 0x0004E523
		public unsafe Button confirmAmountButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmAmountButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x002DE1BC File Offset: 0x002DC3BC
		// (set) Token: 0x0600AF11 RID: 44817 RVA: 0x00050342 File Offset: 0x0004E542
		public unsafe Text confirmButtonText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_confirmButtonText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x002DE1EC File Offset: 0x002DC3EC
		// (set) Token: 0x0600AF13 RID: 44819 RVA: 0x00050361 File Offset: 0x0004E561
		public unsafe RectTransform processingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600AF14 RID: 44820 RVA: 0x002DE21C File Offset: 0x002DC41C
		// (set) Token: 0x0600AF15 RID: 44821 RVA: 0x00050380 File Offset: 0x0004E580
		public unsafe RectTransform processingScreenIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_processingScreenIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600AF16 RID: 44822 RVA: 0x002DE24C File Offset: 0x002DC44C
		// (set) Token: 0x0600AF17 RID: 44823 RVA: 0x0005039F File Offset: 0x0004E59F
		public unsafe RectTransform successScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x0600AF18 RID: 44824 RVA: 0x002DE27C File Offset: 0x002DC47C
		// (set) Token: 0x0600AF19 RID: 44825 RVA: 0x000503BE File Offset: 0x0004E5BE
		public unsafe Text successScreenSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_successScreenSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x0600AF1A RID: 44826 RVA: 0x002DE2AC File Offset: 0x002DC4AC
		// (set) Token: 0x0600AF1B RID: 44827 RVA: 0x000503DD File Offset: 0x0004E5DD
		public unsafe Button doneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_doneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x0600AF1C RID: 44828 RVA: 0x002DE2DC File Offset: 0x002DC4DC
		// (set) Token: 0x0600AF1D RID: 44829 RVA: 0x000503FC File Offset: 0x0004E5FC
		public unsafe UIScreen UIScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_UIScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_UIScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x0600AF1E RID: 44830 RVA: 0x002DE30C File Offset: 0x002DC50C
		// (set) Token: 0x0600AF1F RID: 44831 RVA: 0x0005041B File Offset: 0x0004E61B
		public unsafe UIContentPanel MenuPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_MenuPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_MenuPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348B RID: 13451
		// (get) Token: 0x0600AF20 RID: 44832 RVA: 0x002DE33C File Offset: 0x002DC53C
		// (set) Token: 0x0600AF21 RID: 44833 RVA: 0x0005043A File Offset: 0x0004E63A
		public unsafe UIContentPanel AmountSelectorPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_AmountSelectorPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_AmountSelectorPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348C RID: 13452
		// (get) Token: 0x0600AF22 RID: 44834 RVA: 0x002DE36C File Offset: 0x002DC56C
		// (set) Token: 0x0600AF23 RID: 44835 RVA: 0x00050459 File Offset: 0x0004E659
		public unsafe UIContentPanel SuccessPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_SuccessPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_SuccessPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348D RID: 13453
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x002DE39C File Offset: 0x002DC59C
		// (set) Token: 0x0600AF25 RID: 44837 RVA: 0x00050478 File Offset: 0x0004E678
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700348E RID: 13454
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x002DE3C4 File Offset: 0x002DC5C4
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x00050493 File Offset: 0x0004E693
		public unsafe RectTransform activeScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_activeScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700348F RID: 13455
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x002DE3F4 File Offset: 0x002DC5F4
		// (set) Token: 0x0600AF29 RID: 44841 RVA: 0x000504B2 File Offset: 0x0004E6B2
		public unsafe static Il2CppStructArray<int> amounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ATMInterface.NativeFieldInfoPtr_amounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATMInterface.NativeFieldInfoPtr_amounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600AF2A RID: 44842 RVA: 0x002DE41C File Offset: 0x002DC61C
		// (set) Token: 0x0600AF2B RID: 44843 RVA: 0x000504C4 File Offset: 0x0004E6C4
		public unsafe bool depositing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_depositing)) = value;
			}
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600AF2C RID: 44844 RVA: 0x002DE444 File Offset: 0x002DC644
		// (set) Token: 0x0600AF2D RID: 44845 RVA: 0x000504DF File Offset: 0x0004E6DF
		public unsafe int selectedAmountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmountIndex)) = value;
			}
		}

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x002DE46C File Offset: 0x002DC66C
		// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x000504FA File Offset: 0x0004E6FA
		public unsafe float selectedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.NativeFieldInfoPtr_selectedAmount)) = value;
			}
		}

		// Token: 0x04007898 RID: 30872
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04007899 RID: 30873
		private static readonly IntPtr NativeFieldInfoPtr_uiContainer;

		// Token: 0x0400789A RID: 30874
		private static readonly IntPtr NativeFieldInfoPtr_atm;

		// Token: 0x0400789B RID: 30875
		private static readonly IntPtr NativeFieldInfoPtr_completeSound;

		// Token: 0x0400789C RID: 30876
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400789D RID: 30877
		private static readonly IntPtr NativeFieldInfoPtr_menuScreen;

		// Token: 0x0400789E RID: 30878
		private static readonly IntPtr NativeFieldInfoPtr_menu_TitleText;

		// Token: 0x0400789F RID: 30879
		private static readonly IntPtr NativeFieldInfoPtr_menu_DepositButton;

		// Token: 0x040078A0 RID: 30880
		private static readonly IntPtr NativeFieldInfoPtr_menu_WithdrawButton;

		// Token: 0x040078A1 RID: 30881
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitText;

		// Token: 0x040078A2 RID: 30882
		private static readonly IntPtr NativeFieldInfoPtr_onlineBalanceText;

		// Token: 0x040078A3 RID: 30883
		private static readonly IntPtr NativeFieldInfoPtr_cleanCashText;

		// Token: 0x040078A4 RID: 30884
		private static readonly IntPtr NativeFieldInfoPtr_depositLimitContainer;

		// Token: 0x040078A5 RID: 30885
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorScreen;

		// Token: 0x040078A6 RID: 30886
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorTitle;

		// Token: 0x040078A7 RID: 30887
		private static readonly IntPtr NativeFieldInfoPtr_amountButtons;

		// Token: 0x040078A8 RID: 30888
		private static readonly IntPtr NativeFieldInfoPtr_amountLabelText;

		// Token: 0x040078A9 RID: 30889
		private static readonly IntPtr NativeFieldInfoPtr_amountBackground;

		// Token: 0x040078AA RID: 30890
		private static readonly IntPtr NativeFieldInfoPtr_selectedButtonIndicator;

		// Token: 0x040078AB RID: 30891
		private static readonly IntPtr NativeFieldInfoPtr_confirmAmountButton;

		// Token: 0x040078AC RID: 30892
		private static readonly IntPtr NativeFieldInfoPtr_confirmButtonText;

		// Token: 0x040078AD RID: 30893
		private static readonly IntPtr NativeFieldInfoPtr_processingScreen;

		// Token: 0x040078AE RID: 30894
		private static readonly IntPtr NativeFieldInfoPtr_processingScreenIndicator;

		// Token: 0x040078AF RID: 30895
		private static readonly IntPtr NativeFieldInfoPtr_successScreen;

		// Token: 0x040078B0 RID: 30896
		private static readonly IntPtr NativeFieldInfoPtr_successScreenSubtitle;

		// Token: 0x040078B1 RID: 30897
		private static readonly IntPtr NativeFieldInfoPtr_doneButton;

		// Token: 0x040078B2 RID: 30898
		private static readonly IntPtr NativeFieldInfoPtr_UIScreen;

		// Token: 0x040078B3 RID: 30899
		private static readonly IntPtr NativeFieldInfoPtr_MenuPanel;

		// Token: 0x040078B4 RID: 30900
		private static readonly IntPtr NativeFieldInfoPtr_AmountSelectorPanel;

		// Token: 0x040078B5 RID: 30901
		private static readonly IntPtr NativeFieldInfoPtr_SuccessPanel;

		// Token: 0x040078B6 RID: 30902
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040078B7 RID: 30903
		private static readonly IntPtr NativeFieldInfoPtr_activeScreen;

		// Token: 0x040078B8 RID: 30904
		private static readonly IntPtr NativeFieldInfoPtr_amounts;

		// Token: 0x040078B9 RID: 30905
		private static readonly IntPtr NativeFieldInfoPtr_depositing;

		// Token: 0x040078BA RID: 30906
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmountIndex;

		// Token: 0x040078BB RID: 30907
		private static readonly IntPtr NativeFieldInfoPtr_selectedAmount;

		// Token: 0x040078BC RID: 30908
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040078BD RID: 30909
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040078BE RID: 30910
		private static readonly IntPtr NativeMethodInfoPtr_get_relevantBalance_Private_get_Single_0;

		// Token: 0x040078BF RID: 30911
		private static readonly IntPtr NativeMethodInfoPtr_get_remainingAllowedDeposit_Private_Static_get_Single_0;

		// Token: 0x040078C0 RID: 30912
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040078C1 RID: 30913
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040078C2 RID: 30914
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040078C3 RID: 30915
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x040078C4 RID: 30916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040078C5 RID: 30917
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040078C6 RID: 30918
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040078C7 RID: 30919
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x040078C8 RID: 30920
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x040078C9 RID: 30921
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x040078CA RID: 30922
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveScreen_Public_Void_RectTransform_0;

		// Token: 0x040078CB RID: 30923
		private static readonly IntPtr NativeMethodInfoPtr_DefaultAmountSelection_Private_Void_0;

		// Token: 0x040078CC RID: 30924
		private static readonly IntPtr NativeMethodInfoPtr_DepositButtonPressed_Public_Void_0;

		// Token: 0x040078CD RID: 30925
		private static readonly IntPtr NativeMethodInfoPtr_WithdrawButtonPressed_Public_Void_0;

		// Token: 0x040078CE RID: 30926
		private static readonly IntPtr NativeMethodInfoPtr_CancelAmountSelection_Public_Void_0;

		// Token: 0x040078CF RID: 30927
		private static readonly IntPtr NativeMethodInfoPtr_AmountSelected_Public_Void_Int32_0;

		// Token: 0x040078D0 RID: 30928
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedAmount_Private_Void_Single_0;

		// Token: 0x040078D1 RID: 30929
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountFromIndex_Public_Static_Single_Int32_Boolean_0;

		// Token: 0x040078D2 RID: 30930
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvailableAmounts_Private_Void_0;

		// Token: 0x040078D3 RID: 30931
		private static readonly IntPtr NativeMethodInfoPtr_AmountConfirmed_Public_Void_0;

		// Token: 0x040078D4 RID: 30932
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Public_Void_Single_0;

		// Token: 0x040078D5 RID: 30933
		private static readonly IntPtr NativeMethodInfoPtr_ProcessTransaction_Protected_IEnumerator_Single_Boolean_0;

		// Token: 0x040078D6 RID: 30934
		private static readonly IntPtr NativeMethodInfoPtr_DoneButtonPressed_Public_Void_0;

		// Token: 0x040078D7 RID: 30935
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToMenuButtonPressed_Public_Void_0;

		// Token: 0x040078D8 RID: 30936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CB1 RID: 3249
		[ObfuscatedName("ScheduleOne.UI.ATMInterface+<>c__DisplayClass45_0")]
		public sealed class __c__DisplayClass45_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3A0 RID: 62368 RVA: 0x003AA274 File Offset: 0x003A8474
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass45_0()
			{
				Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<>c__DisplayClass45_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr);
				ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr_cachedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr, "cachedIndex");
				ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr, "<>4__this");
				ATMInterface.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr, 100686328);
				ATMInterface.__c__DisplayClass45_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr, 100686329);
			}

			// Token: 0x0600F3A1 RID: 62369 RVA: 0x003AA2F0 File Offset: 0x003A84F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass45_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface.__c__DisplayClass45_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass45_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3A2 RID: 62370 RVA: 0x003AA32C File Offset: 0x003A852C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298121, XrefRangeEnd = 298123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface.__c__DisplayClass45_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3A3 RID: 62371 RVA: 0x0007307E File Offset: 0x0007127E
			public __c__DisplayClass45_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049F3 RID: 18931
			// (get) Token: 0x0600F3A4 RID: 62372 RVA: 0x003AA360 File Offset: 0x003A8560
			// (set) Token: 0x0600F3A5 RID: 62373 RVA: 0x00073087 File Offset: 0x00071287
			public unsafe int cachedIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr_cachedIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr_cachedIndex)) = value;
				}
			}

			// Token: 0x170049F4 RID: 18932
			// (get) Token: 0x0600F3A6 RID: 62374 RVA: 0x003AA388 File Offset: 0x003A8588
			// (set) Token: 0x0600F3A7 RID: 62375 RVA: 0x000730A2 File Offset: 0x000712A2
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface.__c__DisplayClass45_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A506 RID: 42246
			private static readonly IntPtr NativeFieldInfoPtr_cachedIndex;

			// Token: 0x0400A507 RID: 42247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A508 RID: 42248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A509 RID: 42249
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}

		// Token: 0x02000CB2 RID: 3250
		[ObfuscatedName("ScheduleOne.UI.ATMInterface+<ProcessTransaction>d__64")]
		public sealed class _ProcessTransaction_d__64 : Il2CppSystem.Object
		{
			// Token: 0x0600F3A8 RID: 62376 RVA: 0x003AA3B8 File Offset: 0x003A85B8
			// Note: this type is marked as 'beforefieldinit'.
			static _ProcessTransaction_d__64()
			{
				Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATMInterface>.NativeClassPtr, "<ProcessTransaction>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr);
				ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, "<>1__state");
				ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, "<>2__current");
				ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, "<>4__this");
				ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_depositing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, "depositing");
				ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, "amount");
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686330);
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686331);
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686332);
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686333);
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686334);
				ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr, 100686335);
			}

			// Token: 0x0600F3A9 RID: 62377 RVA: 0x003AA4C0 File Offset: 0x003A86C0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ProcessTransaction_d__64(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATMInterface._ProcessTransaction_d__64>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3AA RID: 62378 RVA: 0x003AA508 File Offset: 0x003A8708
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3AB RID: 62379 RVA: 0x003AA53C File Offset: 0x003A873C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298123, XrefRangeEnd = 298173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049FA RID: 18938
			// (get) Token: 0x0600F3AC RID: 62380 RVA: 0x003AA578 File Offset: 0x003A8778
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F3AD RID: 62381 RVA: 0x003AA5B8 File Offset: 0x003A87B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298173, XrefRangeEnd = 298178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049FB RID: 18939
			// (get) Token: 0x0600F3AE RID: 62382 RVA: 0x003AA5EC File Offset: 0x003A87EC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATMInterface._ProcessTransaction_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F3AF RID: 62383 RVA: 0x000730C1 File Offset: 0x000712C1
			public _ProcessTransaction_d__64(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049F5 RID: 18933
			// (get) Token: 0x0600F3B0 RID: 62384 RVA: 0x003AA62C File Offset: 0x003A882C
			// (set) Token: 0x0600F3B1 RID: 62385 RVA: 0x000730CA File Offset: 0x000712CA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049F6 RID: 18934
			// (get) Token: 0x0600F3B2 RID: 62386 RVA: 0x003AA654 File Offset: 0x003A8854
			// (set) Token: 0x0600F3B3 RID: 62387 RVA: 0x000730E5 File Offset: 0x000712E5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F7 RID: 18935
			// (get) Token: 0x0600F3B4 RID: 62388 RVA: 0x003AA684 File Offset: 0x003A8884
			// (set) Token: 0x0600F3B5 RID: 62389 RVA: 0x00073104 File Offset: 0x00071304
			public unsafe ATMInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049F8 RID: 18936
			// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x003AA6B4 File Offset: 0x003A88B4
			// (set) Token: 0x0600F3B7 RID: 62391 RVA: 0x00073123 File Offset: 0x00071323
			public unsafe bool depositing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_depositing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_depositing)) = value;
				}
			}

			// Token: 0x170049F9 RID: 18937
			// (get) Token: 0x0600F3B8 RID: 62392 RVA: 0x003AA6DC File Offset: 0x003A88DC
			// (set) Token: 0x0600F3B9 RID: 62393 RVA: 0x0007313E File Offset: 0x0007133E
			public unsafe float amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATMInterface._ProcessTransaction_d__64.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x0400A50A RID: 42250
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A50B RID: 42251
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A50C RID: 42252
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A50D RID: 42253
			private static readonly IntPtr NativeFieldInfoPtr_depositing;

			// Token: 0x0400A50E RID: 42254
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x0400A50F RID: 42255
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A510 RID: 42256
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A511 RID: 42257
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A512 RID: 42258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A513 RID: 42259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A514 RID: 42260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
