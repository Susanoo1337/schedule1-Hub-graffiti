using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Handover
{
	// Token: 0x02000813 RID: 2067
	public class HandoverScreen : Singleton<HandoverScreen>
	{
		// Token: 0x0600C86E RID: 51310 RVA: 0x0032A774 File Offset: 0x00328974
		// Note: this type is marked as 'beforefieldinit'.
		static HandoverScreen()
		{
			Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Handover", "HandoverScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr);
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotCount");
			HandoverScreen.NativeFieldInfoPtr_VehicleMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleMaxDistance");
			HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentContract>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "<CurrentCustomer>k__BackingField");
			HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "OnHandoverScreenOpened");
			HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "OnHandoverScreenClosed");
			HandoverScreen.NativeFieldInfoPtr_SuccessColorMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessColorMap");
			HandoverScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Canvas");
			HandoverScreen.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "Container");
			HandoverScreen.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CanvasGroup");
			HandoverScreen.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "InstructionLabel");
			HandoverScreen.NativeFieldInfoPtr_ContractDescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ContractDescriptionLabel");
			HandoverScreen.NativeFieldInfoPtr_ExpectationEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ExpectationEntries");
			HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "CustomerSlotContainer");
			HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleSubtitle");
			HandoverScreen.NativeFieldInfoPtr_SuccessLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "SuccessLabel");
			HandoverScreen.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "ErrorLabel");
			HandoverScreen.NativeFieldInfoPtr_WarningLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "WarningLabel");
			HandoverScreen.NativeFieldInfoPtr_DoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DoneButton");
			HandoverScreen.NativeFieldInfoPtr_VehicleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "VehicleContainer");
			HandoverScreen.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "TitleLabel");
			HandoverScreen.NativeFieldInfoPtr_PriceSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "PriceSelector");
			HandoverScreen.NativeFieldInfoPtr_FairPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "FairPriceLabel");
			HandoverScreen.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "DetailPanel");
			HandoverScreen.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "State");
			HandoverScreen.NativeFieldInfoPtr__mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_mode");
			HandoverScreen.NativeFieldInfoPtr__vehicleSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_vehicleSlotUIs");
			HandoverScreen.NativeFieldInfoPtr__customerSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_customerSlotUIs");
			HandoverScreen.NativeFieldInfoPtr__customerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_customerSlots");
			HandoverScreen.NativeFieldInfoPtr__ignoreCustomerChangedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_ignoreCustomerChangedEvents");
			HandoverScreen.NativeFieldInfoPtr__requireFullChanceOfSuccess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_requireFullChanceOfSuccess");
			HandoverScreen.NativeFieldInfoPtr__outcome = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_outcome");
			HandoverScreen.NativeFieldInfoPtr__onHandoverCompleteCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_onHandoverCompleteCallback");
			HandoverScreen.NativeFieldInfoPtr__successChanceMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, "_successChanceMethod");
			HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689196);
			HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689197);
			HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689198);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689199);
			HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689200);
			HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689201);
			HandoverScreen.NativeMethodInfoPtr_add_OnHandoverScreenOpened_Public_add_Void_Action_1_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689202);
			HandoverScreen.NativeMethodInfoPtr_remove_OnHandoverScreenOpened_Public_rem_Void_Action_1_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689203);
			HandoverScreen.NativeMethodInfoPtr_add_OnHandoverScreenClosed_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689204);
			HandoverScreen.NativeMethodInfoPtr_remove_OnHandoverScreenClosed_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689205);
			HandoverScreen.NativeMethodInfoPtr_add__onHandoverCompleteCallback_Private_add_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689206);
			HandoverScreen.NativeMethodInfoPtr_remove__onHandoverCompleteCallback_Private_rem_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689207);
			HandoverScreen.NativeMethodInfoPtr_add__successChanceMethod_Private_add_Void_Func_3_List_1_ItemInstance_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689208);
			HandoverScreen.NativeMethodInfoPtr_remove__successChanceMethod_Private_rem_Void_Func_3_List_1_ItemInstance_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689209);
			HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689210);
			HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689211);
			HandoverScreen.NativeMethodInfoPtr_TestOpen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689212);
			HandoverScreen.NativeMethodInfoPtr_Open_Public_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689213);
			HandoverScreen.NativeMethodInfoPtr_Close_Public_Void_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689214);
			HandoverScreen.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689215);
			HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689216);
			HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689217);
			HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689218);
			HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689219);
			HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689220);
			HandoverScreen.NativeMethodInfoPtr_PriceChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689221);
			HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689222);
			HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689223);
			HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689224);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689225);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689226);
			HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689227);
			HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr, 100689228);
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600C86F RID: 51311 RVA: 0x0032AD08 File Offset: 0x00328F08
		// (set) Token: 0x0600C870 RID: 51312 RVA: 0x0032AD44 File Offset: 0x00328F44
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600C871 RID: 51313 RVA: 0x0032AD84 File Offset: 0x00328F84
		// (set) Token: 0x0600C872 RID: 51314 RVA: 0x0032ADC4 File Offset: 0x00328FC4
		public unsafe Contract CurrentContract
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600C873 RID: 51315 RVA: 0x0032AE08 File Offset: 0x00329008
		// (set) Token: 0x0600C874 RID: 51316 RVA: 0x0032AE48 File Offset: 0x00329048
		public unsafe Customer CurrentCustomer
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 2980, RefRangeEnd = 2987, XrefRangeStart = 2980, XrefRangeEnd = 2987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C875 RID: 51317 RVA: 0x0032AE8C File Offset: 0x0032908C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330386, RefRangeEnd = 330387, XrefRangeStart = 330381, XrefRangeEnd = 330386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnHandoverScreenOpened(Action<HandoverScreen.EMode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_add_OnHandoverScreenOpened_Public_add_Void_Action_1_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C876 RID: 51318 RVA: 0x0032AED0 File Offset: 0x003290D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330387, XrefRangeEnd = 330392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnHandoverScreenOpened(Action<HandoverScreen.EMode> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_remove_OnHandoverScreenOpened_Public_rem_Void_Action_1_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C877 RID: 51319 RVA: 0x0032AF14 File Offset: 0x00329114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330396, RefRangeEnd = 330397, XrefRangeStart = 330392, XrefRangeEnd = 330396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnHandoverScreenClosed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_add_OnHandoverScreenClosed_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C878 RID: 51320 RVA: 0x0032AF58 File Offset: 0x00329158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330397, XrefRangeEnd = 330401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnHandoverScreenClosed(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_remove_OnHandoverScreenClosed_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C879 RID: 51321 RVA: 0x0032AF9C File Offset: 0x0032919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330401, XrefRangeEnd = 330406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__onHandoverCompleteCallback(Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_add__onHandoverCompleteCallback_Private_add_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87A RID: 51322 RVA: 0x0032AFE0 File Offset: 0x003291E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330406, XrefRangeEnd = 330411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__onHandoverCompleteCallback(Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_remove__onHandoverCompleteCallback_Private_rem_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x0032B024 File Offset: 0x00329224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330411, XrefRangeEnd = 330416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add__successChanceMethod(Func<List<ItemInstance>, float, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_add__successChanceMethod_Private_add_Void_Func_3_List_1_ItemInstance_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x0032B068 File Offset: 0x00329268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330416, XrefRangeEnd = 330421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove__successChanceMethod(Func<List<ItemInstance>, float, float> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_remove__successChanceMethod_Private_rem_Void_Func_3_List_1_ItemInstance_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x0032B0AC File Offset: 0x003292AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330421, XrefRangeEnd = 330508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandoverScreen.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x0032B0E8 File Offset: 0x003292E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330508, XrefRangeEnd = 330519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x0032B11C File Offset: 0x0032931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330519, XrefRangeEnd = 330568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_TestOpen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C880 RID: 51328 RVA: 0x0032B150 File Offset: 0x00329350
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 330757, RefRangeEnd = 330762, XrefRangeStart = 330568, XrefRangeEnd = 330757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod, bool requireFullChanceOfSuccess = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(successChanceMethod);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requireFullChanceOfSuccess;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Open_Public_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C881 RID: 51329 RVA: 0x0032B1E8 File Offset: 0x003293E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330762, XrefRangeEnd = 330764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Close_Public_Void_EHandoverOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C882 RID: 51330 RVA: 0x0032B228 File Offset: 0x00329428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330764, XrefRangeEnd = 330799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C883 RID: 51331 RVA: 0x0032B25C File Offset: 0x0032945C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330799, XrefRangeEnd = 330801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DonePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_DonePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x0032B290 File Offset: 0x00329490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330801, XrefRangeEnd = 330804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x0032B2D4 File Offset: 0x003294D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 330812, RefRangeEnd = 330820, XrefRangeStart = 330804, XrefRangeEnd = 330812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCustomerSlots(bool returnToOriginals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnToOriginals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x0032B314 File Offset: 0x00329514
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 330839, RefRangeEnd = 330843, XrefRangeStart = 330820, XrefRangeEnd = 330839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerItemsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x0032B348 File Offset: 0x00329548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330843, XrefRangeEnd = 330851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoneButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x0032B37C File Offset: 0x0032957C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330851, XrefRangeEnd = 330852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceChanged(float newPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_PriceChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C889 RID: 51337 RVA: 0x0032B3BC File Offset: 0x003295BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330867, RefRangeEnd = 330869, XrefRangeStart = 330852, XrefRangeEnd = 330867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C88A RID: 51338 RVA: 0x0032B3F0 File Offset: 0x003295F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330886, RefRangeEnd = 330888, XrefRangeStart = 330869, XrefRangeEnd = 330886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetError(out string err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			err = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C88B RID: 51339 RVA: 0x0032B448 File Offset: 0x00329648
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330901, RefRangeEnd = 330903, XrefRangeStart = 330888, XrefRangeEnd = 330901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C88C RID: 51340 RVA: 0x0032B4A0 File Offset: 0x003296A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 330921, RefRangeEnd = 330925, XrefRangeStart = 330903, XrefRangeEnd = 330921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x0032B4EC File Offset: 0x003296EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330946, RefRangeEnd = 330947, XrefRangeStart = 330925, XrefRangeEnd = 330946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCustomerItemsValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x0032B528 File Offset: 0x00329728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330958, RefRangeEnd = 330959, XrefRangeStart = 330947, XrefRangeEnd = 330958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCustomerItemsCount(bool onlyPackagedProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref onlyPackagedProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x0032B574 File Offset: 0x00329774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330959, XrefRangeEnd = 330966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandoverScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandoverScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandoverScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x0005ECAC File Offset: 0x0005CEAC
		public HandoverScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600C891 RID: 51345 RVA: 0x0032B5B0 File Offset: 0x003297B0
		// (set) Token: 0x0600C892 RID: 51346 RVA: 0x0005ECB5 File Offset: 0x0005CEB5
		public unsafe static int CustomerSlotCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_CustomerSlotCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_CustomerSlotCount, (void*)(&value));
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600C893 RID: 51347 RVA: 0x0032B5CC File Offset: 0x003297CC
		// (set) Token: 0x0600C894 RID: 51348 RVA: 0x0005ECC3 File Offset: 0x0005CEC3
		public unsafe static float VehicleMaxDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(HandoverScreen.NativeFieldInfoPtr_VehicleMaxDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HandoverScreen.NativeFieldInfoPtr_VehicleMaxDistance, (void*)(&value));
			}
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600C895 RID: 51349 RVA: 0x0032B5E8 File Offset: 0x003297E8
		// (set) Token: 0x0600C896 RID: 51350 RVA: 0x0005ECD1 File Offset: 0x0005CED1
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600C897 RID: 51351 RVA: 0x0032B610 File Offset: 0x00329810
		// (set) Token: 0x0600C898 RID: 51352 RVA: 0x0005ECEC File Offset: 0x0005CEEC
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600C899 RID: 51353 RVA: 0x0032B640 File Offset: 0x00329840
		// (set) Token: 0x0600C89A RID: 51354 RVA: 0x0005ED0B File Offset: 0x0005CF0B
		public unsafe Customer _CurrentCustomer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__CurrentCustomer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600C89B RID: 51355 RVA: 0x0032B670 File Offset: 0x00329870
		// (set) Token: 0x0600C89C RID: 51356 RVA: 0x0005ED2A File Offset: 0x0005CF2A
		public unsafe Action<HandoverScreen.EMode> OnHandoverScreenOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HandoverScreen.EMode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600C89D RID: 51357 RVA: 0x0032B6A0 File Offset: 0x003298A0
		// (set) Token: 0x0600C89E RID: 51358 RVA: 0x0005ED49 File Offset: 0x0005CF49
		public unsafe Action OnHandoverScreenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_OnHandoverScreenClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600C89F RID: 51359 RVA: 0x0032B6D0 File Offset: 0x003298D0
		// (set) Token: 0x0600C8A0 RID: 51360 RVA: 0x0005ED68 File Offset: 0x0005CF68
		public unsafe Gradient SuccessColorMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessColorMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CD9 RID: 15577
		// (get) Token: 0x0600C8A1 RID: 51361 RVA: 0x0032B700 File Offset: 0x00329900
		// (set) Token: 0x0600C8A2 RID: 51362 RVA: 0x0005ED87 File Offset: 0x0005CF87
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDA RID: 15578
		// (get) Token: 0x0600C8A3 RID: 51363 RVA: 0x0032B730 File Offset: 0x00329930
		// (set) Token: 0x0600C8A4 RID: 51364 RVA: 0x0005EDA6 File Offset: 0x0005CFA6
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDB RID: 15579
		// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x0032B760 File Offset: 0x00329960
		// (set) Token: 0x0600C8A6 RID: 51366 RVA: 0x0005EDC5 File Offset: 0x0005CFC5
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDC RID: 15580
		// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x0032B790 File Offset: 0x00329990
		// (set) Token: 0x0600C8A8 RID: 51368 RVA: 0x0005EDE4 File Offset: 0x0005CFE4
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDD RID: 15581
		// (get) Token: 0x0600C8A9 RID: 51369 RVA: 0x0032B7C0 File Offset: 0x003299C0
		// (set) Token: 0x0600C8AA RID: 51370 RVA: 0x0005EE03 File Offset: 0x0005D003
		public unsafe TextMeshProUGUI ContractDescriptionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ContractDescriptionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ContractDescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDE RID: 15582
		// (get) Token: 0x0600C8AB RID: 51371 RVA: 0x0032B7F0 File Offset: 0x003299F0
		// (set) Token: 0x0600C8AC RID: 51372 RVA: 0x0005EE22 File Offset: 0x0005D022
		public unsafe Il2CppReferenceArray<RectTransform> ExpectationEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ExpectationEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CDF RID: 15583
		// (get) Token: 0x0600C8AD RID: 51373 RVA: 0x0032B820 File Offset: 0x00329A20
		// (set) Token: 0x0600C8AE RID: 51374 RVA: 0x0005EE41 File Offset: 0x0005D041
		public unsafe RectTransform VehicleSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE0 RID: 15584
		// (get) Token: 0x0600C8AF RID: 51375 RVA: 0x0032B850 File Offset: 0x00329A50
		// (set) Token: 0x0600C8B0 RID: 51376 RVA: 0x0005EE60 File Offset: 0x0005D060
		public unsafe RectTransform CustomerSlotContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_CustomerSlotContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE1 RID: 15585
		// (get) Token: 0x0600C8B1 RID: 51377 RVA: 0x0032B880 File Offset: 0x00329A80
		// (set) Token: 0x0600C8B2 RID: 51378 RVA: 0x0005EE7F File Offset: 0x0005D07F
		public unsafe TextMeshProUGUI VehicleSubtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleSubtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE2 RID: 15586
		// (get) Token: 0x0600C8B3 RID: 51379 RVA: 0x0032B8B0 File Offset: 0x00329AB0
		// (set) Token: 0x0600C8B4 RID: 51380 RVA: 0x0005EE9E File Offset: 0x0005D09E
		public unsafe TextMeshProUGUI SuccessLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_SuccessLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE3 RID: 15587
		// (get) Token: 0x0600C8B5 RID: 51381 RVA: 0x0032B8E0 File Offset: 0x00329AE0
		// (set) Token: 0x0600C8B6 RID: 51382 RVA: 0x0005EEBD File Offset: 0x0005D0BD
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE4 RID: 15588
		// (get) Token: 0x0600C8B7 RID: 51383 RVA: 0x0032B910 File Offset: 0x00329B10
		// (set) Token: 0x0600C8B8 RID: 51384 RVA: 0x0005EEDC File Offset: 0x0005D0DC
		public unsafe TextMeshProUGUI WarningLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_WarningLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE5 RID: 15589
		// (get) Token: 0x0600C8B9 RID: 51385 RVA: 0x0032B940 File Offset: 0x00329B40
		// (set) Token: 0x0600C8BA RID: 51386 RVA: 0x0005EEFB File Offset: 0x0005D0FB
		public unsafe Button DoneButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE6 RID: 15590
		// (get) Token: 0x0600C8BB RID: 51387 RVA: 0x0032B970 File Offset: 0x00329B70
		// (set) Token: 0x0600C8BC RID: 51388 RVA: 0x0005EF1A File Offset: 0x0005D11A
		public unsafe RectTransform VehicleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_VehicleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE7 RID: 15591
		// (get) Token: 0x0600C8BD RID: 51389 RVA: 0x0032B9A0 File Offset: 0x00329BA0
		// (set) Token: 0x0600C8BE RID: 51390 RVA: 0x0005EF39 File Offset: 0x0005D139
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE8 RID: 15592
		// (get) Token: 0x0600C8BF RID: 51391 RVA: 0x0032B9D0 File Offset: 0x00329BD0
		// (set) Token: 0x0600C8C0 RID: 51392 RVA: 0x0005EF58 File Offset: 0x0005D158
		public unsafe AmountSelector PriceSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_PriceSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CE9 RID: 15593
		// (get) Token: 0x0600C8C1 RID: 51393 RVA: 0x0032BA00 File Offset: 0x00329C00
		// (set) Token: 0x0600C8C2 RID: 51394 RVA: 0x0005EF77 File Offset: 0x0005D177
		public unsafe TextMeshProUGUI FairPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_FairPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CEA RID: 15594
		// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x0032BA30 File Offset: 0x00329C30
		// (set) Token: 0x0600C8C4 RID: 51396 RVA: 0x0005EF96 File Offset: 0x0005D196
		public unsafe HandoverScreenDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HandoverScreenDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CEB RID: 15595
		// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x0032BA60 File Offset: 0x00329C60
		// (set) Token: 0x0600C8C6 RID: 51398 RVA: 0x0005EFB5 File Offset: 0x0005D1B5
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CEC RID: 15596
		// (get) Token: 0x0600C8C7 RID: 51399 RVA: 0x0032BA90 File Offset: 0x00329C90
		// (set) Token: 0x0600C8C8 RID: 51400 RVA: 0x0005EFD4 File Offset: 0x0005D1D4
		public unsafe HandoverScreen.EMode _mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__mode)) = value;
			}
		}

		// Token: 0x17003CED RID: 15597
		// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x0032BAB8 File Offset: 0x00329CB8
		// (set) Token: 0x0600C8CA RID: 51402 RVA: 0x0005EFEF File Offset: 0x0005D1EF
		public unsafe Il2CppReferenceArray<ItemSlotUI> _vehicleSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__vehicleSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__vehicleSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CEE RID: 15598
		// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x0032BAE8 File Offset: 0x00329CE8
		// (set) Token: 0x0600C8CC RID: 51404 RVA: 0x0005F00E File Offset: 0x0005D20E
		public unsafe Il2CppReferenceArray<ItemSlotUI> _customerSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__customerSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__customerSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CEF RID: 15599
		// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x0032BB18 File Offset: 0x00329D18
		// (set) Token: 0x0600C8CE RID: 51406 RVA: 0x0005F02D File Offset: 0x0005D22D
		public unsafe Il2CppReferenceArray<ItemSlot> _customerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__customerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__customerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600C8CF RID: 51407 RVA: 0x0032BB48 File Offset: 0x00329D48
		// (set) Token: 0x0600C8D0 RID: 51408 RVA: 0x0005F04C File Offset: 0x0005D24C
		public unsafe bool _ignoreCustomerChangedEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__ignoreCustomerChangedEvents);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__ignoreCustomerChangedEvents)) = value;
			}
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x0032BB70 File Offset: 0x00329D70
		// (set) Token: 0x0600C8D2 RID: 51410 RVA: 0x0005F067 File Offset: 0x0005D267
		public unsafe bool _requireFullChanceOfSuccess
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__requireFullChanceOfSuccess);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__requireFullChanceOfSuccess)) = value;
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x0032BB98 File Offset: 0x00329D98
		// (set) Token: 0x0600C8D4 RID: 51412 RVA: 0x0005F082 File Offset: 0x0005D282
		public unsafe HandoverScreen.EHandoverOutcome _outcome
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__outcome);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__outcome)) = value;
			}
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600C8D5 RID: 51413 RVA: 0x0032BBC0 File Offset: 0x00329DC0
		// (set) Token: 0x0600C8D6 RID: 51414 RVA: 0x0005F09D File Offset: 0x0005D29D
		public unsafe Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> _onHandoverCompleteCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__onHandoverCompleteCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__onHandoverCompleteCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600C8D7 RID: 51415 RVA: 0x0032BBF0 File Offset: 0x00329DF0
		// (set) Token: 0x0600C8D8 RID: 51416 RVA: 0x0005F0BC File Offset: 0x0005D2BC
		public unsafe Func<List<ItemInstance>, float, float> _successChanceMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__successChanceMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<ItemInstance>, float, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandoverScreen.NativeFieldInfoPtr__successChanceMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008898 RID: 34968
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotCount;

		// Token: 0x04008899 RID: 34969
		private static readonly IntPtr NativeFieldInfoPtr_VehicleMaxDistance;

		// Token: 0x0400889A RID: 34970
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400889B RID: 34971
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x0400889C RID: 34972
		private static readonly IntPtr NativeFieldInfoPtr__CurrentCustomer_k__BackingField;

		// Token: 0x0400889D RID: 34973
		private static readonly IntPtr NativeFieldInfoPtr_OnHandoverScreenOpened;

		// Token: 0x0400889E RID: 34974
		private static readonly IntPtr NativeFieldInfoPtr_OnHandoverScreenClosed;

		// Token: 0x0400889F RID: 34975
		private static readonly IntPtr NativeFieldInfoPtr_SuccessColorMap;

		// Token: 0x040088A0 RID: 34976
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040088A1 RID: 34977
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040088A2 RID: 34978
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040088A3 RID: 34979
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x040088A4 RID: 34980
		private static readonly IntPtr NativeFieldInfoPtr_ContractDescriptionLabel;

		// Token: 0x040088A5 RID: 34981
		private static readonly IntPtr NativeFieldInfoPtr_ExpectationEntries;

		// Token: 0x040088A6 RID: 34982
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSlotContainer;

		// Token: 0x040088A7 RID: 34983
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSlotContainer;

		// Token: 0x040088A8 RID: 34984
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSubtitle;

		// Token: 0x040088A9 RID: 34985
		private static readonly IntPtr NativeFieldInfoPtr_SuccessLabel;

		// Token: 0x040088AA RID: 34986
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x040088AB RID: 34987
		private static readonly IntPtr NativeFieldInfoPtr_WarningLabel;

		// Token: 0x040088AC RID: 34988
		private static readonly IntPtr NativeFieldInfoPtr_DoneButton;

		// Token: 0x040088AD RID: 34989
		private static readonly IntPtr NativeFieldInfoPtr_VehicleContainer;

		// Token: 0x040088AE RID: 34990
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x040088AF RID: 34991
		private static readonly IntPtr NativeFieldInfoPtr_PriceSelector;

		// Token: 0x040088B0 RID: 34992
		private static readonly IntPtr NativeFieldInfoPtr_FairPriceLabel;

		// Token: 0x040088B1 RID: 34993
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x040088B2 RID: 34994
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040088B3 RID: 34995
		private static readonly IntPtr NativeFieldInfoPtr__mode;

		// Token: 0x040088B4 RID: 34996
		private static readonly IntPtr NativeFieldInfoPtr__vehicleSlotUIs;

		// Token: 0x040088B5 RID: 34997
		private static readonly IntPtr NativeFieldInfoPtr__customerSlotUIs;

		// Token: 0x040088B6 RID: 34998
		private static readonly IntPtr NativeFieldInfoPtr__customerSlots;

		// Token: 0x040088B7 RID: 34999
		private static readonly IntPtr NativeFieldInfoPtr__ignoreCustomerChangedEvents;

		// Token: 0x040088B8 RID: 35000
		private static readonly IntPtr NativeFieldInfoPtr__requireFullChanceOfSuccess;

		// Token: 0x040088B9 RID: 35001
		private static readonly IntPtr NativeFieldInfoPtr__outcome;

		// Token: 0x040088BA RID: 35002
		private static readonly IntPtr NativeFieldInfoPtr__onHandoverCompleteCallback;

		// Token: 0x040088BB RID: 35003
		private static readonly IntPtr NativeFieldInfoPtr__successChanceMethod;

		// Token: 0x040088BC RID: 35004
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040088BD RID: 35005
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040088BE RID: 35006
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x040088BF RID: 35007
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x040088C0 RID: 35008
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCustomer_Public_get_Customer_0;

		// Token: 0x040088C1 RID: 35009
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCustomer_Private_set_Void_Customer_0;

		// Token: 0x040088C2 RID: 35010
		private static readonly IntPtr NativeMethodInfoPtr_add_OnHandoverScreenOpened_Public_add_Void_Action_1_EMode_0;

		// Token: 0x040088C3 RID: 35011
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnHandoverScreenOpened_Public_rem_Void_Action_1_EMode_0;

		// Token: 0x040088C4 RID: 35012
		private static readonly IntPtr NativeMethodInfoPtr_add_OnHandoverScreenClosed_Public_add_Void_Action_0;

		// Token: 0x040088C5 RID: 35013
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnHandoverScreenClosed_Public_rem_Void_Action_0;

		// Token: 0x040088C6 RID: 35014
		private static readonly IntPtr NativeMethodInfoPtr_add__onHandoverCompleteCallback_Private_add_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x040088C7 RID: 35015
		private static readonly IntPtr NativeMethodInfoPtr_remove__onHandoverCompleteCallback_Private_rem_Void_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x040088C8 RID: 35016
		private static readonly IntPtr NativeMethodInfoPtr_add__successChanceMethod_Private_add_Void_Func_3_List_1_ItemInstance_Single_Single_0;

		// Token: 0x040088C9 RID: 35017
		private static readonly IntPtr NativeMethodInfoPtr_remove__successChanceMethod_Private_rem_Void_Func_3_List_1_ItemInstance_Single_Single_0;

		// Token: 0x040088CA RID: 35018
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040088CB RID: 35019
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040088CC RID: 35020
		private static readonly IntPtr NativeMethodInfoPtr_TestOpen_Public_Void_0;

		// Token: 0x040088CD RID: 35021
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Contract_Customer_EMode_Action_3_EHandoverOutcome_List_1_ItemInstance_Single_Func_3_List_1_ItemInstance_Single_Single_Boolean_0;

		// Token: 0x040088CE RID: 35022
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_EHandoverOutcome_0;

		// Token: 0x040088CF RID: 35023
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x040088D0 RID: 35024
		private static readonly IntPtr NativeMethodInfoPtr_DonePressed_Public_Void_0;

		// Token: 0x040088D1 RID: 35025
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040088D2 RID: 35026
		private static readonly IntPtr NativeMethodInfoPtr_ClearCustomerSlots_Public_Void_Boolean_0;

		// Token: 0x040088D3 RID: 35027
		private static readonly IntPtr NativeMethodInfoPtr_CustomerItemsChanged_Private_Void_0;

		// Token: 0x040088D4 RID: 35028
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoneButton_Private_Void_0;

		// Token: 0x040088D5 RID: 35029
		private static readonly IntPtr NativeMethodInfoPtr_PriceChanged_Private_Void_Single_0;

		// Token: 0x040088D6 RID: 35030
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSuccessChance_Private_Void_0;

		// Token: 0x040088D7 RID: 35031
		private static readonly IntPtr NativeMethodInfoPtr_GetError_Private_Boolean_byref_String_0;

		// Token: 0x040088D8 RID: 35032
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x040088D9 RID: 35033
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItems_Private_List_1_ItemInstance_Boolean_0;

		// Token: 0x040088DA RID: 35034
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsValue_Private_Single_0;

		// Token: 0x040088DB RID: 35035
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerItemsCount_Private_Int32_Boolean_0;

		// Token: 0x040088DC RID: 35036
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D74 RID: 3444
		[OriginalName("Assembly-CSharp.dll", "", "EMode")]
		public enum EMode
		{
			// Token: 0x0400A99C RID: 43420
			Contract,
			// Token: 0x0400A99D RID: 43421
			Sample,
			// Token: 0x0400A99E RID: 43422
			Offer
		}

		// Token: 0x02000D75 RID: 3445
		[OriginalName("Assembly-CSharp.dll", "", "EHandoverOutcome")]
		public enum EHandoverOutcome
		{
			// Token: 0x0400A9A0 RID: 43424
			Cancelled,
			// Token: 0x0400A9A1 RID: 43425
			Finalize
		}
	}
}
