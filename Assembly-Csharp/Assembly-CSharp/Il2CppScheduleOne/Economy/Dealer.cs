using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Framework;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000393 RID: 915
	public class Dealer : NPC
	{
		// Token: 0x0600526B RID: 21099 RVA: 0x001975E0 File Offset: 0x001957E0
		// Note: this type is marked as 'beforefieldinit'.
		static Dealer()
		{
			Il2CppClassPointerStore<Dealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Dealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer>.NativeClassPtr);
			Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_CUSTOMERS");
			Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DEAL_ARRIVAL_DELAY");
			Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OVERFLOW_SLOT_COUNT");
			Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "CASH_REMINDER_THRESHOLD");
			Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "RELATIONSHIP_CHANGE_PER_DEAL");
			Dealer.NativeFieldInfoPtr_DealerLabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DealerLabelColor");
			Dealer.NativeFieldInfoPtr_NegativeQualityTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NegativeQualityTolerance");
			Dealer.NativeFieldInfoPtr_PositiveQualityTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "PositiveQualityTolerance");
			Dealer.NativeFieldInfoPtr_onDealerRecruited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onDealerRecruited");
			Dealer.NativeFieldInfoPtr_AllPlayerDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "AllPlayerDealers");
			Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<IsRecruited>k__BackingField");
			Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<ItemSlots>k__BackingField");
			Dealer.NativeFieldInfoPtr__PotentialDealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<PotentialDealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr__DealerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<DealerPoI>k__BackingField");
			Dealer.NativeFieldInfoPtr__Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr__AssignedCustomers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<AssignedCustomers>k__BackingField");
			Dealer.NativeFieldInfoPtr__ActiveContracts_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<ActiveContracts>k__BackingField");
			Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Dealer.NativeFieldInfoPtr_onContractAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "onContractAccepted");
			Dealer.NativeFieldInfoPtr_Home = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "Home");
			Dealer.NativeFieldInfoPtr_HomeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "HomeEvent");
			Dealer.NativeFieldInfoPtr_DialogueController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "DialogueController");
			Dealer.NativeFieldInfoPtr_OnRecommended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OnRecommended");
			Dealer.NativeFieldInfoPtr_OnCompleteDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "OnCompleteDeal");
			Dealer.NativeFieldInfoPtr_overflowSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "overflowSlots");
			Dealer.NativeFieldInfoPtr_currentContract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "currentContract");
			Dealer.NativeFieldInfoPtr_recruitChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "recruitChoice");
			Dealer.NativeFieldInfoPtr_collectCashChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "collectCashChoice");
			Dealer.NativeFieldInfoPtr_assignCustomersChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "assignCustomersChoice");
			Dealer.NativeFieldInfoPtr_itemCountOnTradeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "itemCountOnTradeStart");
			Dealer.NativeFieldInfoPtr__attendDealBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "_attendDealBehaviour");
			Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "syncVar___<Cash>k__BackingField");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.DealerAssembly-CSharp.dll_Excuted");
			Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674061);
			Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674062);
			Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674063);
			Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674064);
			Dealer.NativeMethodInfoPtr_get_PotentialDealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674065);
			Dealer.NativeMethodInfoPtr_set_PotentialDealerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674066);
			Dealer.NativeMethodInfoPtr_get_DealerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674067);
			Dealer.NativeMethodInfoPtr_set_DealerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674068);
			Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674069);
			Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674070);
			Dealer.NativeMethodInfoPtr_get_AssignedCustomers_Public_get_List_1_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674071);
			Dealer.NativeMethodInfoPtr_set_AssignedCustomers_Private_set_Void_List_1_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674072);
			Dealer.NativeMethodInfoPtr_get_ActiveContracts_Public_get_List_1_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674073);
			Dealer.NativeMethodInfoPtr_set_ActiveContracts_Private_set_Void_List_1_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674074);
			Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674075);
			Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674076);
			Dealer.NativeMethodInfoPtr_get_DealerData_Public_get_DealerNPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674077);
			Dealer.NativeMethodInfoPtr_add_OnRecommended_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674078);
			Dealer.NativeMethodInfoPtr_remove_OnRecommended_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674079);
			Dealer.NativeMethodInfoPtr_add_OnCompleteDeal_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674080);
			Dealer.NativeMethodInfoPtr_remove_OnCompleteDeal_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674081);
			Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674082);
			Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674083);
			Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674084);
			Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674085);
			Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674086);
			Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674087);
			Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674088);
			Dealer.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674089);
			Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674090);
			Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674091);
			Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674092);
			Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674093);
			Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674094);
			Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674095);
			Dealer.NativeMethodInfoPtr_DealerUnconscious_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674096);
			Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674097);
			Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674098);
			Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674099);
			Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674100);
			Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674101);
			Dealer.NativeMethodInfoPtr_CheckCurrentDealValidity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674102);
			Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674103);
			Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674104);
			Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674105);
			Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674106);
			Dealer.NativeMethodInfoPtr_AddCustomer_Server_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674107);
			Dealer.NativeMethodInfoPtr_AddCustomer_Client_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674108);
			Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674109);
			Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674110);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674111);
			Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674112);
			Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674113);
			Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674114);
			Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674115);
			Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674116);
			Dealer.NativeMethodInfoPtr_TryRobDealer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674117);
			Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_Tuple_3_ProductDefinition_EQuality_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674118);
			Dealer.NativeMethodInfoPtr_GetOrderableProductQuantity_Public_Int32_String_EQuality_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674119);
			Dealer.NativeMethodInfoPtr_GetAvailableProducts_Private_List_1_Tuple_3_ProductDefinition_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674120);
			Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674121);
			Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674122);
			Dealer.NativeMethodInfoPtr_AddContract_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674123);
			Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674124);
			Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674125);
			Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674126);
			Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Void_Contract_EQuality_byref_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674127);
			Dealer.NativeMethodInfoPtr_RemoveAndReturnProductFromInventory_Private_List_1_ProductItemInstance_String_Int32_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674128);
			Dealer.NativeMethodInfoPtr_SplitItemSlot_Private_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674129);
			Dealer.NativeMethodInfoPtr_FilterAndSortSlots_Private_List_1_ItemSlot_List_1_ItemSlot_String_EQuality_EAmountSortOrder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674130);
			Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674131);
			Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674132);
			Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674133);
			Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674134);
			Dealer.NativeMethodInfoPtr_GetPackagedProductAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674135);
			Dealer.NativeMethodInfoPtr_CheckNotifyPlayerOfDeal_Public_Virtual_New_Void_Dealer_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674136);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674137);
			Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674138);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674139);
			Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674140);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674141);
			Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674142);
			Dealer.NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674143);
			Dealer.NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674144);
			Dealer.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674145);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674146);
			Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674147);
			Dealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674148);
			Dealer.NativeMethodInfoPtr__Awake_b__63_0_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674150);
			Dealer.NativeMethodInfoPtr_Method_Private_Void_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674151);
			Dealer.NativeMethodInfoPtr_Method_Private_Void_List_1_ItemSlot_Boolean_Boolean_byref___c__DisplayClass109_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674152);
			Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674153);
			Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674154);
			Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674155);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674156);
			Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674157);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674158);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674159);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674160);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674161);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674162);
			Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674163);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674164);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674165);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674166);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674167);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674168);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674169);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_AddCustomer_Server_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674170);
			Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_Server_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674171);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_AddCustomer_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674172);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674173);
			Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674174);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674175);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674176);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674177);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674178);
			Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674179);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674180);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674181);
			Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674182);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674183);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674184);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674185);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674186);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674187);
			Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674188);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674189);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674190);
			Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674191);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674192);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674193);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674194);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674195);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674196);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674197);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674198);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674199);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674200);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674201);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674202);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674203);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674204);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674205);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674206);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674207);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674208);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674209);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674210);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674211);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674212);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674213);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674214);
			Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674215);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674216);
			Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674217);
			Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674218);
			Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674219);
			Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674220);
			Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674221);
			Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674222);
			Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674223);
			Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674224);
			Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674225);
			Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer>.NativeClassPtr, 100674226);
		}

		// Token: 0x170019D0 RID: 6608
		// (get) Token: 0x0600526C RID: 21100 RVA: 0x001985C4 File Offset: 0x001967C4
		// (set) Token: 0x0600526D RID: 21101 RVA: 0x00198600 File Offset: 0x00196800
		public unsafe bool IsRecruited
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 183607, RefRangeEnd = 183609, XrefRangeStart = 183607, XrefRangeEnd = 183607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x0600526E RID: 21102 RVA: 0x00198640 File Offset: 0x00196840
		// (set) Token: 0x0600526F RID: 21103 RVA: 0x00198680 File Offset: 0x00196880
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x06005270 RID: 21104 RVA: 0x001986C4 File Offset: 0x001968C4
		// (set) Token: 0x06005271 RID: 21105 RVA: 0x00198704 File Offset: 0x00196904
		public unsafe NPCPoI PotentialDealerPoI
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 153845, RefRangeEnd = 153859, XrefRangeStart = 153845, XrefRangeEnd = 153859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_PotentialDealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_PotentialDealerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x06005272 RID: 21106 RVA: 0x00198748 File Offset: 0x00196948
		// (set) Token: 0x06005273 RID: 21107 RVA: 0x00198788 File Offset: 0x00196988
		public unsafe NPCPoI DealerPoI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_DealerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_DealerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x001987CC File Offset: 0x001969CC
		// (set) Token: 0x06005275 RID: 21109 RVA: 0x00198808 File Offset: 0x00196A08
		public unsafe float Cash
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183609, RefRangeEnd = 183612, XrefRangeStart = 183609, XrefRangeEnd = 183609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_Cash_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183612, XrefRangeEnd = 183619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x00198848 File Offset: 0x00196A48
		// (set) Token: 0x06005277 RID: 21111 RVA: 0x00198888 File Offset: 0x00196A88
		public unsafe List<Customer> AssignedCustomers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_AssignedCustomers_Public_get_List_1_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183619, XrefRangeEnd = 183620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_AssignedCustomers_Private_set_Void_List_1_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x001988CC File Offset: 0x00196ACC
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x0019890C File Offset: 0x00196B0C
		public unsafe List<Contract> ActiveContracts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_ActiveContracts_Public_get_List_1_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_ActiveContracts_Private_set_Void_List_1_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D7 RID: 6615
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x00198950 File Offset: 0x00196B50
		// (set) Token: 0x0600527B RID: 21115 RVA: 0x0019898C File Offset: 0x00196B8C
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170019D8 RID: 6616
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x001989CC File Offset: 0x00196BCC
		public unsafe DealerNPCData DealerData
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 183622, RefRangeEnd = 183641, XrefRangeStart = 183620, XrefRangeEnd = 183622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_get_DealerData_Public_get_DealerNPCData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DealerNPCData>(intPtr3) : null;
			}
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00198A0C File Offset: 0x00196C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183645, RefRangeEnd = 183646, XrefRangeStart = 183641, XrefRangeEnd = 183645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnRecommended(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_add_OnRecommended_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x00198A50 File Offset: 0x00196C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183646, XrefRangeEnd = 183650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnRecommended(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_remove_OnRecommended_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00198A94 File Offset: 0x00196C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183654, RefRangeEnd = 183655, XrefRangeStart = 183650, XrefRangeEnd = 183654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnCompleteDeal(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_add_OnCompleteDeal_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x00198AD8 File Offset: 0x00196CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183655, XrefRangeEnd = 183659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnCompleteDeal(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_remove_OnCompleteDeal_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x00198B1C File Offset: 0x00196D1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 183660, RefRangeEnd = 183667, XrefRangeStart = 183659, XrefRangeEnd = 183660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x00198B58 File Offset: 0x00196D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183667, XrefRangeEnd = 183670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x00198B94 File Offset: 0x00196D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183670, XrefRangeEnd = 183679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00198BD0 File Offset: 0x00196DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183696, RefRangeEnd = 183697, XrefRangeStart = 183679, XrefRangeEnd = 183696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x00198C0C File Offset: 0x00196E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183715, RefRangeEnd = 183717, XrefRangeStart = 183697, XrefRangeEnd = 183715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00198C5C File Offset: 0x00196E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183772, RefRangeEnd = 183773, XrefRangeStart = 183717, XrefRangeEnd = 183772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetupPoI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00198C90 File Offset: 0x00196E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183804, RefRangeEnd = 183805, XrefRangeStart = 183773, XrefRangeEnd = 183804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00198CC4 File Offset: 0x00196EC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183822, RefRangeEnd = 183823, XrefRangeStart = 183805, XrefRangeEnd = 183822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00198D00 File Offset: 0x00196F00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183844, RefRangeEnd = 183847, XrefRangeStart = 183823, XrefRangeEnd = 183844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00198D34 File Offset: 0x00196F34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183866, RefRangeEnd = 183868, XrefRangeStart = 183847, XrefRangeEnd = 183866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetRecommended_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00198D68 File Offset: 0x00196F68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183888, RefRangeEnd = 183889, XrefRangeStart = 183868, XrefRangeEnd = 183888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialRecruitment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_InitialRecruitment_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00198D9C File Offset: 0x00196F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183889, XrefRangeEnd = 183926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsRecruited(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00198DEC File Offset: 0x00196FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183926, XrefRangeEnd = 183935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDealerUnlocked(NPCRelationData.EUnlockType unlockType, bool b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00198E44 File Offset: 0x00197044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183942, RefRangeEnd = 183943, XrefRangeStart = 183935, XrefRangeEnd = 183942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00198E80 File Offset: 0x00197080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183943, XrefRangeEnd = 183954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DealerUnconscious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_DealerUnconscious_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00198EB4 File Offset: 0x001970B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183954, XrefRangeEnd = 183974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00198EE8 File Offset: 0x001970E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183974, XrefRangeEnd = 183984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00198F1C File Offset: 0x0019711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183984, XrefRangeEnd = 183987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCollectCash(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00198F74 File Offset: 0x00197174
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183997, RefRangeEnd = 184000, XrefRangeStart = 183987, XrefRangeEnd = 183997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollectCashChoice(float oldCash, float newCash, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldCash;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newCash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00198FD0 File Offset: 0x001971D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184000, XrefRangeEnd = 184007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CollectCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CollectCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00199004 File Offset: 0x00197204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184007, XrefRangeEnd = 184010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckCurrentDealValidity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CheckCurrentDealValidity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00199038 File Offset: 0x00197238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184010, XrefRangeEnd = 184017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOfferRecruitment(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00199090 File Offset: 0x00197290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184062, RefRangeEnd = 184063, XrefRangeStart = 184017, XrefRangeEnd = 184062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttendStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CheckAttendStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x001990C4 File Offset: 0x001972C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184063, XrefRangeEnd = 184109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldAcceptContract(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00199130 File Offset: 0x00197330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184109, XrefRangeEnd = 184125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractedOffered(ContractInfo contractInfo, Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contractInfo);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00199190 File Offset: 0x00197390
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184147, RefRangeEnd = 184150, XrefRangeStart = 184125, XrefRangeEnd = 184147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer_Server(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddCustomer_Server_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x001991D4 File Offset: 0x001973D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 184189, RefRangeEnd = 184193, XrefRangeStart = 184150, XrefRangeEnd = 184189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer_Client(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddCustomer_Client_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00199228 File Offset: 0x00197428
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184202, RefRangeEnd = 184203, XrefRangeStart = 184193, XrefRangeEnd = 184202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x00199278 File Offset: 0x00197478
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184225, RefRangeEnd = 184227, XrefRangeStart = 184203, XrefRangeEnd = 184225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x001992BC File Offset: 0x001974BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184249, RefRangeEnd = 184251, XrefRangeStart = 184227, XrefRangeEnd = 184249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00199300 File Offset: 0x00197500
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184258, RefRangeEnd = 184259, XrefRangeStart = 184251, XrefRangeEnd = 184258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00199350 File Offset: 0x00197550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184259, XrefRangeEnd = 184260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeCash(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00199390 File Offset: 0x00197590
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184270, RefRangeEnd = 184276, XrefRangeStart = 184260, XrefRangeEnd = 184270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCash(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x001993D0 File Offset: 0x001975D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184276, XrefRangeEnd = 184285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompletedDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x0019940C File Offset: 0x0019760C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184295, RefRangeEnd = 184296, XrefRangeStart = 184285, XrefRangeEnd = 184295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitPayment(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x0019944C File Offset: 0x0019764C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184370, RefRangeEnd = 184371, XrefRangeStart = 184296, XrefRangeEnd = 184370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRobDealer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TryRobDealer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00199480 File Offset: 0x00197680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184389, RefRangeEnd = 184390, XrefRangeStart = 184371, XrefRangeEnd = 184389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<ProductDefinition, EQuality, int>> GetOrderableProducts(EQuality minQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_Tuple_3_ProductDefinition_EQuality_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<ProductDefinition, EQuality, int>>>(intPtr3) : null;
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x001994CC File Offset: 0x001976CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184409, RefRangeEnd = 184410, XrefRangeStart = 184390, XrefRangeEnd = 184409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrderableProductQuantity(string productID, EQuality minQuality, EQuality maxQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetOrderableProductQuantity_Public_Int32_String_EQuality_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00199538 File Offset: 0x00197738
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184553, RefRangeEnd = 184555, XrefRangeStart = 184410, XrefRangeEnd = 184553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<ProductDefinition, EQuality, int>> GetAvailableProducts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetAvailableProducts_Private_List_1_Tuple_3_ProductDefinition_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<ProductDefinition, EQuality, int>>>(intPtr3) : null;
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00199578 File Offset: 0x00197778
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184608, RefRangeEnd = 184609, XrefRangeStart = 184555, XrefRangeEnd = 184608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDealWindow GetDealWindow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x001995B4 File Offset: 0x001977B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184631, RefRangeEnd = 184632, XrefRangeStart = 184609, XrefRangeEnd = 184631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetContractCountInWindow(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00199600 File Offset: 0x00197800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 184658, RefRangeEnd = 184661, XrefRangeStart = 184632, XrefRangeEnd = 184658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddContract_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00199644 File Offset: 0x00197844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184661, XrefRangeEnd = 184671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerContractEnded(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x00199688 File Offset: 0x00197888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184671, XrefRangeEnd = 184693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortContracts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SortContracts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x001996BC File Offset: 0x001978BC
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x001996F8 File Offset: 0x001978F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184753, RefRangeEnd = 184754, XrefRangeStart = 184693, XrefRangeEnd = 184753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveContractItems(Contract contract, EQuality targetQuality, out List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetQuality;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveContractItems_Public_Void_Contract_EQuality_byref_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			items = ((intPtr4 == 0) ? null : new List<ItemInstance>(intPtr4));
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x0019976C File Offset: 0x0019796C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184816, RefRangeEnd = 184817, XrefRangeStart = 184754, XrefRangeEnd = 184816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductItemInstance> RemoveAndReturnProductFromInventory(string productID, int requiredQuantity, EQuality targetQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiredQuantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RemoveAndReturnProductFromInventory_Private_List_1_ProductItemInstance_String_Int32_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductItemInstance>>(intPtr3) : null;
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x001997D8 File Offset: 0x001979D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184881, RefRangeEnd = 184882, XrefRangeStart = 184817, XrefRangeEnd = 184881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SplitItemSlot(ItemSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SplitItemSlot_Private_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x0019981C File Offset: 0x00197A1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184922, RefRangeEnd = 184924, XrefRangeStart = 184882, XrefRangeEnd = 184922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> FilterAndSortSlots(List<ItemSlot> slots, string productID, EQuality productQuality, Dealer.EAmountSortOrder amountSortOrder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amountSortOrder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_FilterAndSortSlots_Private_List_1_ItemSlot_List_1_ItemSlot_String_EQuality_EAmountSortOrder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0019989C File Offset: 0x00197A9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184933, RefRangeEnd = 184939, XrefRangeStart = 184924, XrefRangeEnd = 184933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x001998DC File Offset: 0x00197ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184958, RefRangeEnd = 184959, XrefRangeStart = 184939, XrefRangeEnd = 184958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00199920 File Offset: 0x00197B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184964, RefRangeEnd = 184966, XrefRangeStart = 184959, XrefRangeEnd = 184964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryMoveOverflowItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00199954 File Offset: 0x00197B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184981, RefRangeEnd = 184982, XrefRangeStart = 184966, XrefRangeEnd = 184981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalInventoryItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00199990 File Offset: 0x00197B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185005, RefRangeEnd = 185007, XrefRangeStart = 184982, XrefRangeEnd = 185005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetPackagedProductAmount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_GetPackagedProductAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x001999CC File Offset: 0x00197BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185007, XrefRangeEnd = 185090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckNotifyPlayerOfDeal(Dealer cartelDealer, Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cartelDealer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_CheckNotifyPlayerOfDeal_Public_Virtual_New_Void_Dealer_Contract_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00199A2C File Offset: 0x00197C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185090, XrefRangeEnd = 185117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00199A90 File Offset: 0x00197C90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185129, RefRangeEnd = 185132, XrefRangeStart = 185117, XrefRangeEnd = 185129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00199AF4 File Offset: 0x00197CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185132, XrefRangeEnd = 185157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00199B40 File Offset: 0x00197D40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185185, RefRangeEnd = 185188, XrefRangeStart = 185157, XrefRangeEnd = 185185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00199B8C File Offset: 0x00197D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185188, XrefRangeEnd = 185217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00199C10 File Offset: 0x00197E10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185264, RefRangeEnd = 185267, XrefRangeStart = 185217, XrefRangeEnd = 185264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x00199C94 File Offset: 0x00197E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185267, XrefRangeEnd = 185294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00199CF8 File Offset: 0x00197EF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185337, RefRangeEnd = 185340, XrefRangeStart = 185294, XrefRangeEnd = 185337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00199D5C File Offset: 0x00197F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185340, XrefRangeEnd = 185368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppScheduleOne.Persistence.Datas.NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.Persistence.Datas.NPCData>(intPtr3) : null;
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00199DA8 File Offset: 0x00197FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185368, XrefRangeEnd = 185426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(DynamicSaveData dynamicData, Il2CppScheduleOne.Persistence.Datas.NPCData npcData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npcData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00199E08 File Offset: 0x00198008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185426, XrefRangeEnd = 185490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(Il2CppScheduleOne.Persistence.Datas.NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00199E68 File Offset: 0x00198068
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 185512, RefRangeEnd = 185519, XrefRangeStart = 185490, XrefRangeEnd = 185512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00199EA4 File Offset: 0x001980A4
		[CallerCount(0)]
		public unsafe void _Awake_b__63_0(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr__Awake_b__63_0_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00199EF0 File Offset: 0x001980F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185597, RefRangeEnd = 185598, XrefRangeStart = 185519, XrefRangeEnd = 185597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_List_1_ItemInstance_Single_0(List<ItemInstance> items, float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_Method_Private_Void_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00199F40 File Offset: 0x00198140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185641, RefRangeEnd = 185643, XrefRangeStart = 185598, XrefRangeEnd = 185641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_List_1_ItemSlot_Boolean_Boolean_byref___c__DisplayClass109_0_0(List<ItemSlot> orderedSlots, bool split, bool onlyRemoveIdealQuality, ref Dealer.__c__DisplayClass109_0 A_4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedSlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref split;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyRemoveIdealQuality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(A_4));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_Method_Private_Void_List_1_ItemSlot_Boolean_Boolean_byref___c__DisplayClass109_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00199FB8 File Offset: 0x001981B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 185815, RefRangeEnd = 185822, XrefRangeStart = 185643, XrefRangeEnd = 185815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00199FF4 File Offset: 0x001981F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 185823, RefRangeEnd = 185830, XrefRangeStart = 185822, XrefRangeEnd = 185823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x0019A030 File Offset: 0x00198230
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x0019A06C File Offset: 0x0019826C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185830, XrefRangeEnd = 185839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x0019A0A0 File Offset: 0x001982A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183866, RefRangeEnd = 183868, XrefRangeStart = 183866, XrefRangeEnd = 183868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkAsRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x0019A0D4 File Offset: 0x001982D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185839, XrefRangeEnd = 185842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkAsRecommended_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0019A138 File Offset: 0x00198338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185842, XrefRangeEnd = 185851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0019A16C File Offset: 0x0019836C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetRecommended_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0019A1A0 File Offset: 0x001983A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185851, XrefRangeEnd = 185853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetRecommended_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x0019A1F0 File Offset: 0x001983F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185853, XrefRangeEnd = 185862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0019A224 File Offset: 0x00198424
		[CallerCount(0)]
		public unsafe void RpcLogic___InitialRecruitment_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0019A258 File Offset: 0x00198458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185862, XrefRangeEnd = 185864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_InitialRecruitment_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x0019A2BC File Offset: 0x001984BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185864, XrefRangeEnd = 185873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x0019A300 File Offset: 0x00198500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185947, RefRangeEnd = 185950, XrefRangeStart = 185873, XrefRangeEnd = 185947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x0019A350 File Offset: 0x00198550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185950, XrefRangeEnd = 185953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x0019A3A0 File Offset: 0x001985A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185953, XrefRangeEnd = 185962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsRecruited_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x0019A3E4 File Offset: 0x001985E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185962, XrefRangeEnd = 185965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsRecruited_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x0019A434 File Offset: 0x00198634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185965, XrefRangeEnd = 185975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddCustomer_Server_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_AddCustomer_Server_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x0019A478 File Offset: 0x00198678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185975, XrefRangeEnd = 185976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCustomer_Server_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_Server_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x0019A4BC File Offset: 0x001986BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185976, XrefRangeEnd = 185980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddCustomer_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_AddCustomer_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x0019A520 File Offset: 0x00198720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185980, XrefRangeEnd = 185990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x0019A574 File Offset: 0x00198774
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186018, RefRangeEnd = 186021, XrefRangeStart = 185990, XrefRangeEnd = 186018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x0019A5C8 File Offset: 0x001987C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186021, XrefRangeEnd = 186025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddCustomer_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x0019A618 File Offset: 0x00198818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186025, XrefRangeEnd = 186035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_AddCustomer_Client_2971853958(NetworkConnection conn, string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0019A66C File Offset: 0x0019886C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186035, XrefRangeEnd = 186039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_AddCustomer_Client_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x0019A6BC File Offset: 0x001988BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186039, XrefRangeEnd = 186049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x0019A700 File Offset: 0x00198900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 184249, RefRangeEnd = 184251, XrefRangeStart = 184249, XrefRangeEnd = 184251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendRemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x0019A744 File Offset: 0x00198944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186049, XrefRangeEnd = 186053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendRemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x0019A7A8 File Offset: 0x001989A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186053, XrefRangeEnd = 186063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0019A7EC File Offset: 0x001989EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186091, RefRangeEnd = 186094, XrefRangeStart = 186063, XrefRangeEnd = 186091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveCustomer_3615296227(string npcID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x0019A830 File Offset: 0x00198A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186094, XrefRangeEnd = 186098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveCustomer_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x0019A880 File Offset: 0x00198A80
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184270, RefRangeEnd = 184276, XrefRangeStart = 184270, XrefRangeEnd = 184276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0019A8C0 File Offset: 0x00198AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186098, XrefRangeEnd = 186107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetCash_431000436(float cash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0019A900 File Offset: 0x00198B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186107, XrefRangeEnd = 186118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetCash_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x0019A964 File Offset: 0x00198B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x0019A998 File Offset: 0x00198B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186118, XrefRangeEnd = 186119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___CompletedDeal_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0019A9D4 File Offset: 0x00198BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186119, XrefRangeEnd = 186121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CompletedDeal_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x0019AA38 File Offset: 0x00198C38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 184295, RefRangeEnd = 184296, XrefRangeStart = 184295, XrefRangeEnd = 184296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0019AA78 File Offset: 0x00198C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186150, RefRangeEnd = 186151, XrefRangeStart = 186121, XrefRangeEnd = 186150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitPayment_431000436(float payment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref payment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x0019AAB8 File Offset: 0x00198CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186151, XrefRangeEnd = 186154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SubmitPayment_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x0019AB1C File Offset: 0x00198D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186154, XrefRangeEnd = 186167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0019AB80 File Offset: 0x00198D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186167, XrefRangeEnd = 186171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x0019ABE4 File Offset: 0x00198DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186171, XrefRangeEnd = 186179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0019AC48 File Offset: 0x00198E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186179, XrefRangeEnd = 186191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x0019ACAC File Offset: 0x00198EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186191, XrefRangeEnd = 186195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x0019AD10 File Offset: 0x00198F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186195, XrefRangeEnd = 186203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0019AD60 File Offset: 0x00198F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186203, XrefRangeEnd = 186215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0019ADC4 File Offset: 0x00198FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186215, XrefRangeEnd = 186223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x0019AE14 File Offset: 0x00199014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186223, XrefRangeEnd = 186236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x0019AE60 File Offset: 0x00199060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186236, XrefRangeEnd = 186237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x0019AEAC File Offset: 0x001990AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186237, XrefRangeEnd = 186244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x0019AF10 File Offset: 0x00199110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186244, XrefRangeEnd = 186257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x0019AF5C File Offset: 0x0019915C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186262, RefRangeEnd = 186263, XrefRangeStart = 186257, XrefRangeEnd = 186262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x0019AFA8 File Offset: 0x001991A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186263, XrefRangeEnd = 186270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x0019AFF8 File Offset: 0x001991F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186270, XrefRangeEnd = 186285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x0019B07C File Offset: 0x0019927C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186285, XrefRangeEnd = 186289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x0019B100 File Offset: 0x00199300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186289, XrefRangeEnd = 186298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x0019B164 File Offset: 0x00199364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186298, XrefRangeEnd = 186312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x0019B1E8 File Offset: 0x001993E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186318, RefRangeEnd = 186321, XrefRangeStart = 186312, XrefRangeEnd = 186318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x0019B26C File Offset: 0x0019946C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186321, XrefRangeEnd = 186328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x0019B2BC File Offset: 0x001994BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186328, XrefRangeEnd = 186342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0019B340 File Offset: 0x00199540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186342, XrefRangeEnd = 186349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x0019B390 File Offset: 0x00199590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186349, XrefRangeEnd = 186362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x0019B3F4 File Offset: 0x001995F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186362, XrefRangeEnd = 186366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x0019B458 File Offset: 0x00199658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186366, XrefRangeEnd = 186374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x0019B4BC File Offset: 0x001996BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186374, XrefRangeEnd = 186386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0019B520 File Offset: 0x00199720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 186391, RefRangeEnd = 186394, XrefRangeStart = 186386, XrefRangeEnd = 186391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x0019B584 File Offset: 0x00199784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186394, XrefRangeEnd = 186400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0019B5D4 File Offset: 0x001997D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186400, XrefRangeEnd = 186412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x0019B638 File Offset: 0x00199838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186412, XrefRangeEnd = 186418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170019D9 RID: 6617
		// (get) Token: 0x0600530D RID: 21261 RVA: 0x0019B688 File Offset: 0x00199888
		// (set) Token: 0x0600530E RID: 21262 RVA: 0x0019B6C4 File Offset: 0x001998C4
		public unsafe float SyncAccessor_<Cash>k__BackingField
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 183609, RefRangeEnd = 183612, XrefRangeStart = 183609, XrefRangeEnd = 183612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186418, XrefRangeEnd = 186426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x0019B710 File Offset: 0x00199910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186426, XrefRangeEnd = 186427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Dealer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x0019B784 File Offset: 0x00199984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186467, RefRangeEnd = 186468, XrefRangeStart = 186427, XrefRangeEnd = 186467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dealer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005311 RID: 21265 RVA: 0x000273C2 File Offset: 0x000255C2
		public Dealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06005312 RID: 21266 RVA: 0x0019B7C0 File Offset: 0x001999C0
		// (set) Token: 0x06005313 RID: 21267 RVA: 0x000273CB File Offset: 0x000255CB
		public unsafe static int MAX_CUSTOMERS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_CUSTOMERS, (void*)(&value));
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06005314 RID: 21268 RVA: 0x0019B7DC File Offset: 0x001999DC
		// (set) Token: 0x06005315 RID: 21269 RVA: 0x000273D9 File Offset: 0x000255D9
		public unsafe static int DEAL_ARRIVAL_DELAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY, (void*)(&value));
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x06005316 RID: 21270 RVA: 0x0019B7F8 File Offset: 0x001999F8
		// (set) Token: 0x06005317 RID: 21271 RVA: 0x000273E7 File Offset: 0x000255E7
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x06005318 RID: 21272 RVA: 0x0019B814 File Offset: 0x00199A14
		// (set) Token: 0x06005319 RID: 21273 RVA: 0x000273F5 File Offset: 0x000255F5
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600531A RID: 21274 RVA: 0x0019B830 File Offset: 0x00199A30
		// (set) Token: 0x0600531B RID: 21275 RVA: 0x00027403 File Offset: 0x00025603
		public unsafe static int OVERFLOW_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600531C RID: 21276 RVA: 0x0019B84C File Offset: 0x00199A4C
		// (set) Token: 0x0600531D RID: 21277 RVA: 0x00027411 File Offset: 0x00025611
		public unsafe static float CASH_REMINDER_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600531E RID: 21278 RVA: 0x0019B868 File Offset: 0x00199A68
		// (set) Token: 0x0600531F RID: 21279 RVA: 0x0002741F File Offset: 0x0002561F
		public unsafe static float RELATIONSHIP_CHANGE_PER_DEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL, (void*)(&value));
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x06005320 RID: 21280 RVA: 0x0019B884 File Offset: 0x00199A84
		// (set) Token: 0x06005321 RID: 21281 RVA: 0x0002742D File Offset: 0x0002562D
		public unsafe static Color32 DealerLabelColor
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_DealerLabelColor, (void*)(&value));
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x06005322 RID: 21282 RVA: 0x0019B8A0 File Offset: 0x00199AA0
		// (set) Token: 0x06005323 RID: 21283 RVA: 0x0002743B File Offset: 0x0002563B
		public unsafe static int NegativeQualityTolerance
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_NegativeQualityTolerance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_NegativeQualityTolerance, (void*)(&value));
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x06005324 RID: 21284 RVA: 0x0019B8BC File Offset: 0x00199ABC
		// (set) Token: 0x06005325 RID: 21285 RVA: 0x00027449 File Offset: 0x00025649
		public unsafe static int PositiveQualityTolerance
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_PositiveQualityTolerance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_PositiveQualityTolerance, (void*)(&value));
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x06005326 RID: 21286 RVA: 0x0019B8D8 File Offset: 0x00199AD8
		// (set) Token: 0x06005327 RID: 21287 RVA: 0x00027457 File Offset: 0x00025657
		public unsafe static Action<Dealer> onDealerRecruited
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_onDealerRecruited, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x06005328 RID: 21288 RVA: 0x0019B900 File Offset: 0x00199B00
		// (set) Token: 0x06005329 RID: 21289 RVA: 0x00027469 File Offset: 0x00025669
		public unsafe static List<Dealer> AllPlayerDealers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Dealer.NativeFieldInfoPtr_AllPlayerDealers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dealer.NativeFieldInfoPtr_AllPlayerDealers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x0019B928 File Offset: 0x00199B28
		// (set) Token: 0x0600532B RID: 21291 RVA: 0x0002747B File Offset: 0x0002567B
		public unsafe bool _IsRecruited_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__IsRecruited_k__BackingField)) = value;
			}
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600532C RID: 21292 RVA: 0x0019B950 File Offset: 0x00199B50
		// (set) Token: 0x0600532D RID: 21293 RVA: 0x00027496 File Offset: 0x00025696
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600532E RID: 21294 RVA: 0x0019B980 File Offset: 0x00199B80
		// (set) Token: 0x0600532F RID: 21295 RVA: 0x000274B5 File Offset: 0x000256B5
		public unsafe NPCPoI _PotentialDealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__PotentialDealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__PotentialDealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x0019B9B0 File Offset: 0x00199BB0
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x000274D4 File Offset: 0x000256D4
		public unsafe NPCPoI _DealerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__DealerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__DealerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x0019B9E0 File Offset: 0x00199BE0
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x000274F3 File Offset: 0x000256F3
		public unsafe float _Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__Cash_k__BackingField)) = value;
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x0019BA08 File Offset: 0x00199C08
		// (set) Token: 0x06005335 RID: 21301 RVA: 0x0002750E File Offset: 0x0002570E
		public unsafe List<Customer> _AssignedCustomers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__AssignedCustomers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__AssignedCustomers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x0019BA38 File Offset: 0x00199C38
		// (set) Token: 0x06005337 RID: 21303 RVA: 0x0002752D File Offset: 0x0002572D
		public unsafe List<Contract> _ActiveContracts_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ActiveContracts_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__ActiveContracts_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x0019BA68 File Offset: 0x00199C68
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x0002754C File Offset: 0x0002574C
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x170019C0 RID: 6592
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x0019BA90 File Offset: 0x00199C90
		// (set) Token: 0x0600533B RID: 21307 RVA: 0x00027567 File Offset: 0x00025767
		public unsafe Action onContractAccepted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onContractAccepted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_onContractAccepted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C1 RID: 6593
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x0019BAC0 File Offset: 0x00199CC0
		// (set) Token: 0x0600533D RID: 21309 RVA: 0x00027586 File Offset: 0x00025786
		public unsafe NPCEnterableBuilding Home
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_Home), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C2 RID: 6594
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x0019BAF0 File Offset: 0x00199CF0
		// (set) Token: 0x0600533F RID: 21311 RVA: 0x000275A5 File Offset: 0x000257A5
		public unsafe NPCEvent_StayInBuilding HomeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_StayInBuilding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_HomeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C3 RID: 6595
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x0019BB20 File Offset: 0x00199D20
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x000275C4 File Offset: 0x000257C4
		public unsafe DialogueController_Dealer DialogueController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_DialogueController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C4 RID: 6596
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x0019BB50 File Offset: 0x00199D50
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x000275E3 File Offset: 0x000257E3
		public unsafe Action OnRecommended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OnRecommended);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OnRecommended), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C5 RID: 6597
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x0019BB80 File Offset: 0x00199D80
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x00027602 File Offset: 0x00025802
		public unsafe Action OnCompleteDeal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OnCompleteDeal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_OnCompleteDeal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C6 RID: 6598
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x0019BBB0 File Offset: 0x00199DB0
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x00027621 File Offset: 0x00025821
		public unsafe Il2CppReferenceArray<ItemSlot> overflowSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_overflowSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_overflowSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C7 RID: 6599
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x0019BBE0 File Offset: 0x00199DE0
		// (set) Token: 0x06005349 RID: 21321 RVA: 0x00027640 File Offset: 0x00025840
		public unsafe Contract currentContract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_currentContract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x0019BC10 File Offset: 0x00199E10
		// (set) Token: 0x0600534B RID: 21323 RVA: 0x0002765F File Offset: 0x0002585F
		public unsafe DialogueController.DialogueChoice recruitChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_recruitChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019C9 RID: 6601
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x0019BC40 File Offset: 0x00199E40
		// (set) Token: 0x0600534D RID: 21325 RVA: 0x0002767E File Offset: 0x0002587E
		public unsafe DialogueController.DialogueChoice collectCashChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_collectCashChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CA RID: 6602
		// (get) Token: 0x0600534E RID: 21326 RVA: 0x0019BC70 File Offset: 0x00199E70
		// (set) Token: 0x0600534F RID: 21327 RVA: 0x0002769D File Offset: 0x0002589D
		public unsafe DialogueController.DialogueChoice assignCustomersChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_assignCustomersChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x06005350 RID: 21328 RVA: 0x0019BCA0 File Offset: 0x00199EA0
		// (set) Token: 0x06005351 RID: 21329 RVA: 0x000276BC File Offset: 0x000258BC
		public unsafe int itemCountOnTradeStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_itemCountOnTradeStart)) = value;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x06005352 RID: 21330 RVA: 0x0019BCC8 File Offset: 0x00199EC8
		// (set) Token: 0x06005353 RID: 21331 RVA: 0x000276D7 File Offset: 0x000258D7
		public unsafe DealerAttendDealBehaviour _attendDealBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__attendDealBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerAttendDealBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr__attendDealBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06005354 RID: 21332 RVA: 0x0019BCF8 File Offset: 0x00199EF8
		// (set) Token: 0x06005355 RID: 21333 RVA: 0x000276F6 File Offset: 0x000258F6
		public unsafe SyncVar<float> syncVar____Cash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_syncVar____Cash_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019CE RID: 6606
		// (get) Token: 0x06005356 RID: 21334 RVA: 0x0019BD28 File Offset: 0x00199F28
		// (set) Token: 0x06005357 RID: 21335 RVA: 0x00027715 File Offset: 0x00025915
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170019CF RID: 6607
		// (get) Token: 0x06005358 RID: 21336 RVA: 0x0019BD50 File Offset: 0x00199F50
		// (set) Token: 0x06005359 RID: 21337 RVA: 0x00027730 File Offset: 0x00025930
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003892 RID: 14482
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CUSTOMERS;

		// Token: 0x04003893 RID: 14483
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ARRIVAL_DELAY;

		// Token: 0x04003894 RID: 14484
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003895 RID: 14485
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003896 RID: 14486
		private static readonly IntPtr NativeFieldInfoPtr_OVERFLOW_SLOT_COUNT;

		// Token: 0x04003897 RID: 14487
		private static readonly IntPtr NativeFieldInfoPtr_CASH_REMINDER_THRESHOLD;

		// Token: 0x04003898 RID: 14488
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_CHANGE_PER_DEAL;

		// Token: 0x04003899 RID: 14489
		private static readonly IntPtr NativeFieldInfoPtr_DealerLabelColor;

		// Token: 0x0400389A RID: 14490
		private static readonly IntPtr NativeFieldInfoPtr_NegativeQualityTolerance;

		// Token: 0x0400389B RID: 14491
		private static readonly IntPtr NativeFieldInfoPtr_PositiveQualityTolerance;

		// Token: 0x0400389C RID: 14492
		private static readonly IntPtr NativeFieldInfoPtr_onDealerRecruited;

		// Token: 0x0400389D RID: 14493
		private static readonly IntPtr NativeFieldInfoPtr_AllPlayerDealers;

		// Token: 0x0400389E RID: 14494
		private static readonly IntPtr NativeFieldInfoPtr__IsRecruited_k__BackingField;

		// Token: 0x0400389F RID: 14495
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x040038A0 RID: 14496
		private static readonly IntPtr NativeFieldInfoPtr__PotentialDealerPoI_k__BackingField;

		// Token: 0x040038A1 RID: 14497
		private static readonly IntPtr NativeFieldInfoPtr__DealerPoI_k__BackingField;

		// Token: 0x040038A2 RID: 14498
		private static readonly IntPtr NativeFieldInfoPtr__Cash_k__BackingField;

		// Token: 0x040038A3 RID: 14499
		private static readonly IntPtr NativeFieldInfoPtr__AssignedCustomers_k__BackingField;

		// Token: 0x040038A4 RID: 14500
		private static readonly IntPtr NativeFieldInfoPtr__ActiveContracts_k__BackingField;

		// Token: 0x040038A5 RID: 14501
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x040038A6 RID: 14502
		private static readonly IntPtr NativeFieldInfoPtr_onContractAccepted;

		// Token: 0x040038A7 RID: 14503
		private static readonly IntPtr NativeFieldInfoPtr_Home;

		// Token: 0x040038A8 RID: 14504
		private static readonly IntPtr NativeFieldInfoPtr_HomeEvent;

		// Token: 0x040038A9 RID: 14505
		private static readonly IntPtr NativeFieldInfoPtr_DialogueController;

		// Token: 0x040038AA RID: 14506
		private static readonly IntPtr NativeFieldInfoPtr_OnRecommended;

		// Token: 0x040038AB RID: 14507
		private static readonly IntPtr NativeFieldInfoPtr_OnCompleteDeal;

		// Token: 0x040038AC RID: 14508
		private static readonly IntPtr NativeFieldInfoPtr_overflowSlots;

		// Token: 0x040038AD RID: 14509
		private static readonly IntPtr NativeFieldInfoPtr_currentContract;

		// Token: 0x040038AE RID: 14510
		private static readonly IntPtr NativeFieldInfoPtr_recruitChoice;

		// Token: 0x040038AF RID: 14511
		private static readonly IntPtr NativeFieldInfoPtr_collectCashChoice;

		// Token: 0x040038B0 RID: 14512
		private static readonly IntPtr NativeFieldInfoPtr_assignCustomersChoice;

		// Token: 0x040038B1 RID: 14513
		private static readonly IntPtr NativeFieldInfoPtr_itemCountOnTradeStart;

		// Token: 0x040038B2 RID: 14514
		private static readonly IntPtr NativeFieldInfoPtr__attendDealBehaviour;

		// Token: 0x040038B3 RID: 14515
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Cash_k__BackingField;

		// Token: 0x040038B4 RID: 14516
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040038B5 RID: 14517
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040038B6 RID: 14518
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRecruited_Public_get_Boolean_0;

		// Token: 0x040038B7 RID: 14519
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRecruited_Private_set_Void_Boolean_0;

		// Token: 0x040038B8 RID: 14520
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeMethodInfoPtr_get_PotentialDealerPoI_Public_get_NPCPoI_0;

		// Token: 0x040038BB RID: 14523
		private static readonly IntPtr NativeMethodInfoPtr_set_PotentialDealerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x040038BC RID: 14524
		private static readonly IntPtr NativeMethodInfoPtr_get_DealerPoI_Public_get_NPCPoI_0;

		// Token: 0x040038BD RID: 14525
		private static readonly IntPtr NativeMethodInfoPtr_set_DealerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x040038BE RID: 14526
		private static readonly IntPtr NativeMethodInfoPtr_get_Cash_Public_get_Single_0;

		// Token: 0x040038BF RID: 14527
		private static readonly IntPtr NativeMethodInfoPtr_set_Cash_Private_set_Void_Single_0;

		// Token: 0x040038C0 RID: 14528
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedCustomers_Public_get_List_1_Customer_0;

		// Token: 0x040038C1 RID: 14529
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedCustomers_Private_set_Void_List_1_Customer_0;

		// Token: 0x040038C2 RID: 14530
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveContracts_Public_get_List_1_Contract_0;

		// Token: 0x040038C3 RID: 14531
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveContracts_Private_set_Void_List_1_Contract_0;

		// Token: 0x040038C4 RID: 14532
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x040038C5 RID: 14533
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Private_set_Void_Boolean_0;

		// Token: 0x040038C6 RID: 14534
		private static readonly IntPtr NativeMethodInfoPtr_get_DealerData_Public_get_DealerNPCData_0;

		// Token: 0x040038C7 RID: 14535
		private static readonly IntPtr NativeMethodInfoPtr_add_OnRecommended_Public_add_Void_Action_0;

		// Token: 0x040038C8 RID: 14536
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnRecommended_Public_rem_Void_Action_0;

		// Token: 0x040038C9 RID: 14537
		private static readonly IntPtr NativeMethodInfoPtr_add_OnCompleteDeal_Public_add_Void_Action_0;

		// Token: 0x040038CA RID: 14538
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnCompleteDeal_Public_rem_Void_Action_0;

		// Token: 0x040038CB RID: 14539
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040038CC RID: 14540
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1;

		// Token: 0x040038CD RID: 14541
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x040038CE RID: 14542
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040038CF RID: 14543
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040038D0 RID: 14544
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_0;

		// Token: 0x040038D1 RID: 14545
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_0;

		// Token: 0x040038D2 RID: 14546
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1;

		// Token: 0x040038D3 RID: 14547
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsRecommended_Public_Void_0;

		// Token: 0x040038D4 RID: 14548
		private static readonly IntPtr NativeMethodInfoPtr_SetRecommended_Private_Void_0;

		// Token: 0x040038D5 RID: 14549
		private static readonly IntPtr NativeMethodInfoPtr_InitialRecruitment_Public_Void_0;

		// Token: 0x040038D6 RID: 14550
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRecruited_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040038D7 RID: 14551
		private static readonly IntPtr NativeMethodInfoPtr_OnDealerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x040038D8 RID: 14552
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_New_Void_0;

		// Token: 0x040038D9 RID: 14553
		private static readonly IntPtr NativeMethodInfoPtr_DealerUnconscious_Private_Void_0;

		// Token: 0x040038DA RID: 14554
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x040038DB RID: 14555
		private static readonly IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x040038DC RID: 14556
		private static readonly IntPtr NativeMethodInfoPtr_CanCollectCash_Private_Boolean_byref_String_0;

		// Token: 0x040038DD RID: 14557
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollectCashChoice_Private_Void_Single_Single_Boolean_0;

		// Token: 0x040038DE RID: 14558
		private static readonly IntPtr NativeMethodInfoPtr_CollectCash_Private_Void_0;

		// Token: 0x040038DF RID: 14559
		private static readonly IntPtr NativeMethodInfoPtr_CheckCurrentDealValidity_Private_Void_0;

		// Token: 0x040038E0 RID: 14560
		private static readonly IntPtr NativeMethodInfoPtr_CanOfferRecruitment_Private_Boolean_byref_String_0;

		// Token: 0x040038E1 RID: 14561
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttendStart_Private_Void_0;

		// Token: 0x040038E2 RID: 14562
		private static readonly IntPtr NativeMethodInfoPtr_ShouldAcceptContract_Public_Virtual_New_Boolean_ContractInfo_Customer_0;

		// Token: 0x040038E3 RID: 14563
		private static readonly IntPtr NativeMethodInfoPtr_ContractedOffered_Public_Virtual_New_Void_ContractInfo_Customer_0;

		// Token: 0x040038E4 RID: 14564
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Server_Public_Void_String_0;

		// Token: 0x040038E5 RID: 14565
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Client_Private_Void_NetworkConnection_String_0;

		// Token: 0x040038E6 RID: 14566
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_New_Void_Customer_0;

		// Token: 0x040038E7 RID: 14567
		private static readonly IntPtr NativeMethodInfoPtr_SendRemoveCustomer_Public_Void_String_0;

		// Token: 0x040038E8 RID: 14568
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_String_0;

		// Token: 0x040038E9 RID: 14569
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_New_Void_Customer_0;

		// Token: 0x040038EA RID: 14570
		private static readonly IntPtr NativeMethodInfoPtr_ChangeCash_Public_Void_Single_0;

		// Token: 0x040038EB RID: 14571
		private static readonly IntPtr NativeMethodInfoPtr_SetCash_Public_Void_Single_0;

		// Token: 0x040038EC RID: 14572
		private static readonly IntPtr NativeMethodInfoPtr_CompletedDeal_Public_Virtual_New_Void_0;

		// Token: 0x040038ED RID: 14573
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Void_Single_0;

		// Token: 0x040038EE RID: 14574
		private static readonly IntPtr NativeMethodInfoPtr_TryRobDealer_Public_Void_0;

		// Token: 0x040038EF RID: 14575
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProducts_Public_List_1_Tuple_3_ProductDefinition_EQuality_Int32_EQuality_0;

		// Token: 0x040038F0 RID: 14576
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProductQuantity_Public_Int32_String_EQuality_EQuality_0;

		// Token: 0x040038F1 RID: 14577
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableProducts_Private_List_1_Tuple_3_ProductDefinition_EQuality_Int32_0;

		// Token: 0x040038F2 RID: 14578
		private static readonly IntPtr NativeMethodInfoPtr_GetDealWindow_Private_EDealWindow_0;

		// Token: 0x040038F3 RID: 14579
		private static readonly IntPtr NativeMethodInfoPtr_GetContractCountInWindow_Private_Int32_EDealWindow_0;

		// Token: 0x040038F4 RID: 14580
		private static readonly IntPtr NativeMethodInfoPtr_AddContract_Private_Void_Contract_0;

		// Token: 0x040038F5 RID: 14581
		private static readonly IntPtr NativeMethodInfoPtr_CustomerContractEnded_Private_Void_Contract_0;

		// Token: 0x040038F6 RID: 14582
		private static readonly IntPtr NativeMethodInfoPtr_SortContracts_Private_Void_0;

		// Token: 0x040038F7 RID: 14583
		private static readonly IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_New_Void_0;

		// Token: 0x040038F8 RID: 14584
		private static readonly IntPtr NativeMethodInfoPtr_RemoveContractItems_Public_Void_Contract_EQuality_byref_List_1_ItemInstance_0;

		// Token: 0x040038F9 RID: 14585
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAndReturnProductFromInventory_Private_List_1_ProductItemInstance_String_Int32_EQuality_0;

		// Token: 0x040038FA RID: 14586
		private static readonly IntPtr NativeMethodInfoPtr_SplitItemSlot_Private_Void_ItemSlot_0;

		// Token: 0x040038FB RID: 14587
		private static readonly IntPtr NativeMethodInfoPtr_FilterAndSortSlots_Private_List_1_ItemSlot_List_1_ItemSlot_String_EQuality_EAmountSortOrder_0;

		// Token: 0x040038FC RID: 14588
		private static readonly IntPtr NativeMethodInfoPtr_GetAllSlots_Public_List_1_ItemSlot_0;

		// Token: 0x040038FD RID: 14589
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x040038FE RID: 14590
		private static readonly IntPtr NativeMethodInfoPtr_TryMoveOverflowItems_Public_Void_0;

		// Token: 0x040038FF RID: 14591
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalInventoryItemCount_Public_Int32_0;

		// Token: 0x04003900 RID: 14592
		private static readonly IntPtr NativeMethodInfoPtr_GetPackagedProductAmount_Public_Int32_0;

		// Token: 0x04003901 RID: 14593
		private static readonly IntPtr NativeMethodInfoPtr_CheckNotifyPlayerOfDeal_Public_Virtual_New_Void_Dealer_Contract_0;

		// Token: 0x04003902 RID: 14594
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003903 RID: 14595
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003904 RID: 14596
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003905 RID: 14597
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04003906 RID: 14598
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003907 RID: 14599
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003908 RID: 14600
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotFilter_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003909 RID: 14601
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotFilter_Internal_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x0400390A RID: 14602
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x0400390B RID: 14603
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_DynamicSaveData_NPCData_0;

		// Token: 0x0400390C RID: 14604
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x0400390D RID: 14605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400390E RID: 14606
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__63_0_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x0400390F RID: 14607
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_List_1_ItemInstance_Single_0;

		// Token: 0x04003910 RID: 14608
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_List_1_ItemSlot_Boolean_Boolean_byref___c__DisplayClass109_0_0;

		// Token: 0x04003911 RID: 14609
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003912 RID: 14610
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003913 RID: 14611
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003914 RID: 14612
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkAsRecommended_2166136261_Private_Void_0;

		// Token: 0x04003915 RID: 14613
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkAsRecommended_2166136261_Public_Void_0;

		// Token: 0x04003916 RID: 14614
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkAsRecommended_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003917 RID: 14615
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003918 RID: 14616
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetRecommended_2166136261_Private_Void_0;

		// Token: 0x04003919 RID: 14617
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetRecommended_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400391A RID: 14618
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_InitialRecruitment_2166136261_Private_Void_0;

		// Token: 0x0400391B RID: 14619
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitialRecruitment_2166136261_Public_Void_0;

		// Token: 0x0400391C RID: 14620
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_InitialRecruitment_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400391D RID: 14621
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x0400391E RID: 14622
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsRecruited_328543758_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x0400391F RID: 14623
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003920 RID: 14624
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsRecruited_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003921 RID: 14625
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsRecruited_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003922 RID: 14626
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddCustomer_Server_3615296227_Private_Void_String_0;

		// Token: 0x04003923 RID: 14627
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCustomer_Server_3615296227_Public_Void_String_0;

		// Token: 0x04003924 RID: 14628
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddCustomer_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003925 RID: 14629
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003926 RID: 14630
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003927 RID: 14631
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003928 RID: 14632
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_AddCustomer_Client_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x04003929 RID: 14633
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_AddCustomer_Client_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400392A RID: 14634
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendRemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x0400392B RID: 14635
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendRemoveCustomer_3615296227_Public_Void_String_0;

		// Token: 0x0400392C RID: 14636
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendRemoveCustomer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400392D RID: 14637
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x0400392E RID: 14638
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveCustomer_3615296227_Private_Void_String_0;

		// Token: 0x0400392F RID: 14639
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveCustomer_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003930 RID: 14640
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetCash_431000436_Private_Void_Single_0;

		// Token: 0x04003931 RID: 14641
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCash_431000436_Public_Void_Single_0;

		// Token: 0x04003932 RID: 14642
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetCash_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003933 RID: 14643
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CompletedDeal_2166136261_Private_Void_0;

		// Token: 0x04003934 RID: 14644
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CompletedDeal_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003935 RID: 14645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CompletedDeal_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003936 RID: 14646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SubmitPayment_431000436_Private_Void_Single_0;

		// Token: 0x04003937 RID: 14647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitPayment_431000436_Public_Void_Single_0;

		// Token: 0x04003938 RID: 14648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SubmitPayment_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003939 RID: 14649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400393A RID: 14650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400393B RID: 14651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400393C RID: 14652
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400393D RID: 14653
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400393E RID: 14654
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400393F RID: 14655
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003940 RID: 14656
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003941 RID: 14657
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003942 RID: 14658
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003943 RID: 14659
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003944 RID: 14660
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003945 RID: 14661
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003946 RID: 14662
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003947 RID: 14663
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003948 RID: 14664
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003949 RID: 14665
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400394A RID: 14666
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400394B RID: 14667
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400394C RID: 14668
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400394D RID: 14669
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400394E RID: 14670
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400394F RID: 14671
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotFilter_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003950 RID: 14672
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotFilter_527532783_Public_Virtual_Final_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003951 RID: 14673
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotFilter_527532783_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003952 RID: 14674
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003953 RID: 14675
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003954 RID: 14676
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003955 RID: 14677
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotFilter_Internal_527532783_Private_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x04003956 RID: 14678
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotFilter_Internal_527532783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003957 RID: 14679
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Cash_k__BackingField_Public_get_Single_0;

		// Token: 0x04003958 RID: 14680
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Cash_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003959 RID: 14681
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Dealer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400395A RID: 14682
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000AA9 RID: 2729
		[OriginalName("Assembly-CSharp.dll", "", "EAmountSortOrder")]
		public enum EAmountSortOrder
		{
			// Token: 0x04009A45 RID: 39493
			LowToHigh,
			// Token: 0x04009A46 RID: 39494
			HighToLow
		}

		// Token: 0x02000AAA RID: 2730
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E2E6 RID: 58086 RVA: 0x00379C1C File Offset: 0x00377E1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr);
				Dealer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9");
				Dealer.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__101_0");
				Dealer.__c.NativeFieldInfoPtr___9__106_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__106_0");
				Dealer.__c.NativeFieldInfoPtr___9__108_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__108_0");
				Dealer.__c.NativeFieldInfoPtr___9__109_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__109_0");
				Dealer.__c.NativeFieldInfoPtr___9__118_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, "<>9__118_0");
				Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674228);
				Dealer.__c.NativeMethodInfoPtr__GetAvailableProducts_b__101_0_Internal_EQuality_Tuple_3_ProductDefinition_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674229);
				Dealer.__c.NativeMethodInfoPtr__SortContracts_b__106_0_Internal_Int32_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674230);
				Dealer.__c.NativeMethodInfoPtr__RemoveContractItems_b__108_0_Internal_Int32_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674231);
				Dealer.__c.NativeMethodInfoPtr__RemoveAndReturnProductFromInventory_b__109_0_Internal_Int32_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674232);
				Dealer.__c.NativeMethodInfoPtr__CheckNotifyPlayerOfDeal_b__118_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr, 100674233);
			}

			// Token: 0x0600E2E7 RID: 58087 RVA: 0x00379D38 File Offset: 0x00377F38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2E8 RID: 58088 RVA: 0x00379D74 File Offset: 0x00377F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183571, XrefRangeEnd = 183572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EQuality _GetAvailableProducts_b__101_0(Tuple<ProductDefinition, EQuality, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__GetAvailableProducts_b__101_0_Internal_EQuality_Tuple_3_ProductDefinition_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2E9 RID: 58089 RVA: 0x00379DC4 File Offset: 0x00377FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183572, XrefRangeEnd = 183574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortContracts_b__106_0(Contract x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__SortContracts_b__106_0_Internal_Int32_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2EA RID: 58090 RVA: 0x00379E14 File Offset: 0x00378014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183574, XrefRangeEnd = 183575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveContractItems_b__108_0(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__RemoveContractItems_b__108_0_Internal_Int32_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2EB RID: 58091 RVA: 0x00379E64 File Offset: 0x00378064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveAndReturnProductFromInventory_b__109_0(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__RemoveAndReturnProductFromInventory_b__109_0_Internal_Int32_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2EC RID: 58092 RVA: 0x00379EB4 File Offset: 0x003780B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183575, XrefRangeEnd = 183578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckNotifyPlayerOfDeal_b__118_0(NPC x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c.NativeMethodInfoPtr__CheckNotifyPlayerOfDeal_b__118_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2ED RID: 58093 RVA: 0x0006AFAA File Offset: 0x000691AA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004505 RID: 17669
			// (get) Token: 0x0600E2EE RID: 58094 RVA: 0x00379F04 File Offset: 0x00378104
			// (set) Token: 0x0600E2EF RID: 58095 RVA: 0x0006AFB3 File Offset: 0x000691B3
			public unsafe static Dealer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004506 RID: 17670
			// (get) Token: 0x0600E2F0 RID: 58096 RVA: 0x00379F2C File Offset: 0x0037812C
			// (set) Token: 0x0600E2F1 RID: 58097 RVA: 0x0006AFC5 File Offset: 0x000691C5
			public unsafe static Func<Tuple<ProductDefinition, EQuality, int>, EQuality> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<ProductDefinition, EQuality, int>, EQuality>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004507 RID: 17671
			// (get) Token: 0x0600E2F2 RID: 58098 RVA: 0x00379F54 File Offset: 0x00378154
			// (set) Token: 0x0600E2F3 RID: 58099 RVA: 0x0006AFD7 File Offset: 0x000691D7
			public unsafe static Func<Contract, int> __9__106_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__106_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Contract, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__106_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004508 RID: 17672
			// (get) Token: 0x0600E2F4 RID: 58100 RVA: 0x00379F7C File Offset: 0x0037817C
			// (set) Token: 0x0600E2F5 RID: 58101 RVA: 0x0006AFE9 File Offset: 0x000691E9
			public unsafe static Func<ProductItemInstance, int> __9__108_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__108_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductItemInstance, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__108_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004509 RID: 17673
			// (get) Token: 0x0600E2F6 RID: 58102 RVA: 0x00379FA4 File Offset: 0x003781A4
			// (set) Token: 0x0600E2F7 RID: 58103 RVA: 0x0006AFFB File Offset: 0x000691FB
			public unsafe static Func<ProductItemInstance, int> __9__109_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__109_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductItemInstance, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__109_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450A RID: 17674
			// (get) Token: 0x0600E2F8 RID: 58104 RVA: 0x00379FCC File Offset: 0x003781CC
			// (set) Token: 0x0600E2F9 RID: 58105 RVA: 0x0006B00D File Offset: 0x0006920D
			public unsafe static Func<NPC, bool> __9__118_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Dealer.__c.NativeFieldInfoPtr___9__118_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Dealer.__c.NativeFieldInfoPtr___9__118_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A47 RID: 39495
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009A48 RID: 39496
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x04009A49 RID: 39497
			private static readonly IntPtr NativeFieldInfoPtr___9__106_0;

			// Token: 0x04009A4A RID: 39498
			private static readonly IntPtr NativeFieldInfoPtr___9__108_0;

			// Token: 0x04009A4B RID: 39499
			private static readonly IntPtr NativeFieldInfoPtr___9__109_0;

			// Token: 0x04009A4C RID: 39500
			private static readonly IntPtr NativeFieldInfoPtr___9__118_0;

			// Token: 0x04009A4D RID: 39501
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A4E RID: 39502
			private static readonly IntPtr NativeMethodInfoPtr__GetAvailableProducts_b__101_0_Internal_EQuality_Tuple_3_ProductDefinition_EQuality_Int32_0;

			// Token: 0x04009A4F RID: 39503
			private static readonly IntPtr NativeMethodInfoPtr__SortContracts_b__106_0_Internal_Int32_Contract_0;

			// Token: 0x04009A50 RID: 39504
			private static readonly IntPtr NativeMethodInfoPtr__RemoveContractItems_b__108_0_Internal_Int32_ProductItemInstance_0;

			// Token: 0x04009A51 RID: 39505
			private static readonly IntPtr NativeMethodInfoPtr__RemoveAndReturnProductFromInventory_b__109_0_Internal_Int32_ProductItemInstance_0;

			// Token: 0x04009A52 RID: 39506
			private static readonly IntPtr NativeMethodInfoPtr__CheckNotifyPlayerOfDeal_b__118_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000AAB RID: 2731
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass101_0")]
		public sealed class __c__DisplayClass101_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2FA RID: 58106 RVA: 0x00379FF4 File Offset: 0x003781F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass101_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr);
				Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, "product");
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674234);
				Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__GetAvailableProducts_b__1_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr, 100674235);
			}

			// Token: 0x0600E2FB RID: 58107 RVA: 0x0037A05C File Offset: 0x0037825C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2FC RID: 58108 RVA: 0x0037A098 File Offset: 0x00378298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183578, XrefRangeEnd = 183582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAvailableProducts_b__1(Tuple<ProductDefinition, EQuality, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_0.NativeMethodInfoPtr__GetAvailableProducts_b__1_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2FD RID: 58109 RVA: 0x0006B01F File Offset: 0x0006921F
			public __c__DisplayClass101_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450B RID: 17675
			// (get) Token: 0x0600E2FE RID: 58110 RVA: 0x0037A0E8 File Offset: 0x003782E8
			// (set) Token: 0x0600E2FF RID: 58111 RVA: 0x0006B028 File Offset: 0x00069228
			public unsafe ProductItemInstance product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A53 RID: 39507
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04009A54 RID: 39508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A55 RID: 39509
			private static readonly IntPtr NativeMethodInfoPtr__GetAvailableProducts_b__1_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0;
		}

		// Token: 0x02000AAC RID: 2732
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass101_1")]
		public sealed class __c__DisplayClass101_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E300 RID: 58112 RVA: 0x0037A118 File Offset: 0x00378318
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass101_1()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass101_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr);
				Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr, "entry");
				Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_requiredQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr, "requiredQuality");
				Dealer.__c__DisplayClass101_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr, 100674236);
				Dealer.__c__DisplayClass101_1.NativeMethodInfoPtr__GetAvailableProducts_b__2_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr, 100674237);
			}

			// Token: 0x0600E301 RID: 58113 RVA: 0x0037A194 File Offset: 0x00378394
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass101_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass101_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E302 RID: 58114 RVA: 0x0037A1D0 File Offset: 0x003783D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183582, XrefRangeEnd = 183585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAvailableProducts_b__2(Tuple<ProductDefinition, EQuality, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass101_1.NativeMethodInfoPtr__GetAvailableProducts_b__2_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E303 RID: 58115 RVA: 0x0006B047 File Offset: 0x00069247
			public __c__DisplayClass101_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450C RID: 17676
			// (get) Token: 0x0600E304 RID: 58116 RVA: 0x0037A220 File Offset: 0x00378420
			// (set) Token: 0x0600E305 RID: 58117 RVA: 0x0006B050 File Offset: 0x00069250
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0600E306 RID: 58118 RVA: 0x0037A250 File Offset: 0x00378450
			// (set) Token: 0x0600E307 RID: 58119 RVA: 0x0006B06F File Offset: 0x0006926F
			public unsafe EQuality requiredQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_requiredQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass101_1.NativeFieldInfoPtr_requiredQuality)) = value;
				}
			}

			// Token: 0x04009A56 RID: 39510
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009A57 RID: 39511
			private static readonly IntPtr NativeFieldInfoPtr_requiredQuality;

			// Token: 0x04009A58 RID: 39512
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A59 RID: 39513
			private static readonly IntPtr NativeMethodInfoPtr__GetAvailableProducts_b__2_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0;
		}

		// Token: 0x02000AAD RID: 2733
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass104_0")]
		public sealed class __c__DisplayClass104_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E308 RID: 58120 RVA: 0x0037A278 File Offset: 0x00378478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass104_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass104_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr);
				Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr_contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr, "contract");
				Dealer.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr, 100674238);
				Dealer.__c__DisplayClass104_0.NativeMethodInfoPtr__AddContract_b__0_Internal_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr, 100674239);
			}

			// Token: 0x0600E309 RID: 58121 RVA: 0x0037A2F4 File Offset: 0x003784F4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass104_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass104_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass104_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E30A RID: 58122 RVA: 0x0037A330 File Offset: 0x00378530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183585, XrefRangeEnd = 183595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddContract_b__0(EQuestState <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass104_0.NativeMethodInfoPtr__AddContract_b__0_Internal_Void_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E30B RID: 58123 RVA: 0x0006B08A File Offset: 0x0006928A
			public __c__DisplayClass104_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0600E30C RID: 58124 RVA: 0x0037A370 File Offset: 0x00378570
			// (set) Token: 0x0600E30D RID: 58125 RVA: 0x0006B093 File Offset: 0x00069293
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450F RID: 17679
			// (get) Token: 0x0600E30E RID: 58126 RVA: 0x0037A3A0 File Offset: 0x003785A0
			// (set) Token: 0x0600E30F RID: 58127 RVA: 0x0006B0B2 File Offset: 0x000692B2
			public unsafe Contract contract
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr_contract);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass104_0.NativeFieldInfoPtr_contract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A5A RID: 39514
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A5B RID: 39515
			private static readonly IntPtr NativeFieldInfoPtr_contract;

			// Token: 0x04009A5C RID: 39516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A5D RID: 39517
			private static readonly IntPtr NativeMethodInfoPtr__AddContract_b__0_Internal_Void_EQuestState_0;
		}

		// Token: 0x02000AAE RID: 2734
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass109_0")]
		public sealed class __c__DisplayClass109_0 : ValueType
		{
			// Token: 0x0600E310 RID: 58128 RVA: 0x0037A3D0 File Offset: 0x003785D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass109_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass109_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr);
				Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_remainingRequiredQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr, "remainingRequiredQuantity");
				Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr, "<>4__this");
				Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr, "products");
			}

			// Token: 0x0600E311 RID: 58129 RVA: 0x0006B0D1 File Offset: 0x000692D1
			public __c__DisplayClass109_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E312 RID: 58130 RVA: 0x0006B0DA File Offset: 0x000692DA
			public __c__DisplayClass109_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass109_0>.NativeClassPtr))
			{
			}

			// Token: 0x17004510 RID: 17680
			// (get) Token: 0x0600E313 RID: 58131 RVA: 0x0037A438 File Offset: 0x00378638
			// (set) Token: 0x0600E314 RID: 58132 RVA: 0x0006B0EC File Offset: 0x000692EC
			public unsafe int remainingRequiredQuantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_remainingRequiredQuantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_remainingRequiredQuantity)) = value;
				}
			}

			// Token: 0x17004511 RID: 17681
			// (get) Token: 0x0600E315 RID: 58133 RVA: 0x0037A460 File Offset: 0x00378660
			// (set) Token: 0x0600E316 RID: 58134 RVA: 0x0006B107 File Offset: 0x00069307
			public unsafe Dealer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004512 RID: 17682
			// (get) Token: 0x0600E317 RID: 58135 RVA: 0x0037A490 File Offset: 0x00378690
			// (set) Token: 0x0600E318 RID: 58136 RVA: 0x0006B126 File Offset: 0x00069326
			public unsafe List<ProductItemInstance> products
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_products);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductItemInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass109_0.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A5E RID: 39518
			private static readonly IntPtr NativeFieldInfoPtr_remainingRequiredQuantity;

			// Token: 0x04009A5F RID: 39519
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A60 RID: 39520
			private static readonly IntPtr NativeFieldInfoPtr_products;
		}

		// Token: 0x02000AAF RID: 2735
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E319 RID: 58137 RVA: 0x0037A4C0 File Offset: 0x003786C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr);
				Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_productQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr, "productQuality");
				Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_amountSortOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr, "amountSortOrder");
				Dealer.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr, 100674240);
				Dealer.__c__DisplayClass112_0.NativeMethodInfoPtr__FilterAndSortSlots_b__0_Internal_Int32_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr, 100674241);
			}

			// Token: 0x0600E31A RID: 58138 RVA: 0x0037A53C File Offset: 0x0037873C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E31B RID: 58139 RVA: 0x0037A578 File Offset: 0x00378778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183595, XrefRangeEnd = 183606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _FilterAndSortSlots_b__0(ItemSlot x, ItemSlot y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass112_0.NativeMethodInfoPtr__FilterAndSortSlots_b__0_Internal_Int32_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E31C RID: 58140 RVA: 0x0006B145 File Offset: 0x00069345
			public __c__DisplayClass112_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004513 RID: 17683
			// (get) Token: 0x0600E31D RID: 58141 RVA: 0x0037A5D8 File Offset: 0x003787D8
			// (set) Token: 0x0600E31E RID: 58142 RVA: 0x0006B14E File Offset: 0x0006934E
			public unsafe EQuality productQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_productQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_productQuality)) = value;
				}
			}

			// Token: 0x17004514 RID: 17684
			// (get) Token: 0x0600E31F RID: 58143 RVA: 0x0037A600 File Offset: 0x00378800
			// (set) Token: 0x0600E320 RID: 58144 RVA: 0x0006B169 File Offset: 0x00069369
			public unsafe Dealer.EAmountSortOrder amountSortOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_amountSortOrder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass112_0.NativeFieldInfoPtr_amountSortOrder)) = value;
				}
			}

			// Token: 0x04009A61 RID: 39521
			private static readonly IntPtr NativeFieldInfoPtr_productQuality;

			// Token: 0x04009A62 RID: 39522
			private static readonly IntPtr NativeFieldInfoPtr_amountSortOrder;

			// Token: 0x04009A63 RID: 39523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A64 RID: 39524
			private static readonly IntPtr NativeMethodInfoPtr__FilterAndSortSlots_b__0_Internal_Int32_ItemSlot_ItemSlot_0;
		}

		// Token: 0x02000AB0 RID: 2736
		[ObfuscatedName("ScheduleOne.Economy.Dealer+<>c__DisplayClass99_0")]
		public sealed class __c__DisplayClass99_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E321 RID: 58145 RVA: 0x0037A628 File Offset: 0x00378828
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass99_0()
			{
				Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Dealer>.NativeClassPtr, "<>c__DisplayClass99_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr);
				Dealer.__c__DisplayClass99_0.NativeFieldInfoPtr_minQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr, "minQuality");
				Dealer.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr, 100674242);
				Dealer.__c__DisplayClass99_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr, 100674243);
			}

			// Token: 0x0600E322 RID: 58146 RVA: 0x0037A690 File Offset: 0x00378890
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass99_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dealer.__c__DisplayClass99_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass99_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E323 RID: 58147 RVA: 0x0037A6CC File Offset: 0x003788CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183606, XrefRangeEnd = 183607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetOrderableProducts_b__0(Tuple<ProductDefinition, EQuality, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dealer.__c__DisplayClass99_0.NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E324 RID: 58148 RVA: 0x0006B184 File Offset: 0x00069384
			public __c__DisplayClass99_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004515 RID: 17685
			// (get) Token: 0x0600E325 RID: 58149 RVA: 0x0037A71C File Offset: 0x0037891C
			// (set) Token: 0x0600E326 RID: 58150 RVA: 0x0006B18D File Offset: 0x0006938D
			public unsafe EQuality minQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass99_0.NativeFieldInfoPtr_minQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dealer.__c__DisplayClass99_0.NativeFieldInfoPtr_minQuality)) = value;
				}
			}

			// Token: 0x04009A65 RID: 39525
			private static readonly IntPtr NativeFieldInfoPtr_minQuality;

			// Token: 0x04009A66 RID: 39526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A67 RID: 39527
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderableProducts_b__0_Internal_Boolean_Tuple_3_ProductDefinition_EQuality_Int32_0;
		}
	}
}
