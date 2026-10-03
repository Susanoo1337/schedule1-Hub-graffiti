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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.NPCs.Relation;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Handover;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200038E RID: 910
	public class Customer : NetworkBehaviour
	{
		// Token: 0x060050A6 RID: 20646 RVA: 0x001906D0 File Offset: 0x0018E8D0
		// Note: this type is marked as 'beforefieldinit'.
		static Customer()
		{
			Il2CppClassPointerStore<Customer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "Customer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer>.NativeClassPtr);
			Customer.NativeFieldInfoPtr_onCustomerUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onCustomerUnlocked");
			Customer.NativeFieldInfoPtr_LockedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "LockedCustomers");
			Customer.NativeFieldInfoPtr_UnlockedCustomers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "UnlockedCustomers");
			Customer.NativeFieldInfoPtr_QualityTierTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "QualityTierTolerance");
			Customer.NativeFieldInfoPtr_MaxOrderQuantityPerProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MaxOrderQuantityPerProduct");
			Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "AFFINITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PROPERTY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "QUALITY_MAX_EFFECT");
			Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_REJECTED_RELATIONSHIP_CHANGE");
			Customer.NativeFieldInfoPtr_ATTACK_DEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ATTACK_DEAL_COOLDOWN");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL");
			Customer.NativeFieldInfoPtr_CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE");
			Customer.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEBUG");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_ADDICTION");
			Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_CHANCE_PER_DAY_MAX");
			Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MIN_COOLDOWN");
			Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "APPROACH_MAX_COOLDOWN");
			Customer.NativeFieldInfoPtr_DEAL_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_COOLDOWN");
			Customer.NativeFieldInfoPtr_PlayerAcceptMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerAcceptMessages");
			Customer.NativeFieldInfoPtr_PlayerRejectMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "PlayerRejectMessages");
			Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "DEAL_ATTENDANCE_TOLERANCE");
			Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MAX_TRAVEL_TIME");
			Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "OFFER_EXPIRY_TIME_MINS");
			Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_ORDER_APPEAL");
			Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ADDICTION_DRAIN_PER_DAY");
			Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "SAMPLE_REQUIRES_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION");
			Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_offeredContractInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offeredContractInfo");
			Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedContractTime>k__BackingField");
			Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CurrentContract>k__BackingField");
			Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<IsAwaitingDelivery>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealCompleted>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceLastDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSincePlayerApproached>k__BackingField");
			Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<TimeSinceInstantDealOffered>k__BackingField");
			Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<OfferedDeals>k__BackingField");
			Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<CompletedDeliveries>k__BackingField");
			Customer.NativeFieldInfoPtr__WeeklyPurchaseRecord_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<WeeklyPurchaseRecord>k__BackingField");
			Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<NPC>k__BackingField");
			Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<AssignedDealer>k__BackingField");
			Customer.NativeFieldInfoPtr_customerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "customerData");
			Customer.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onUnlocked");
			Customer.NativeFieldInfoPtr_onDealCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onDealCompleted");
			Customer.NativeFieldInfoPtr_onContractAssigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "onContractAssigned");
			Customer.NativeFieldInfoPtr_awaitingSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingSample");
			Customer.NativeFieldInfoPtr_sampleChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleChoice");
			Customer.NativeFieldInfoPtr_completeContractChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "completeContractChoice");
			Customer.NativeFieldInfoPtr_offerDealChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "offerDealChoice");
			Customer.NativeFieldInfoPtr_awaitingDealGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "awaitingDealGreeting");
			Customer.NativeFieldInfoPtr_minsSinceUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "minsSinceUnlocked");
			Customer.NativeFieldInfoPtr_sampleOfferedToday = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "sampleOfferedToday");
			Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<potentialCustomerPoI>k__BackingField");
			Customer.NativeFieldInfoPtr_currentAffinityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "currentAffinityData");
			Customer.NativeFieldInfoPtr_pendingInstantDeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "pendingInstantDeal");
			Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Customer.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<HasChanged>k__BackingField");
			Customer.NativeFieldInfoPtr_consumedSample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "consumedSample");
			Customer.NativeFieldInfoPtr__attendDealBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "_attendDealBehaviour");
			Customer.NativeFieldInfoPtr__cachedOrderDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "_cachedOrderDays");
			Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<CurrentAddiction>k__BackingField");
			Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "syncVar___<HasBeenRecommended>k__BackingField");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Economy.CustomerAssembly-CSharp.dll_Excuted");
			Customer.NativeMethodInfoPtr_MinsSinceLastDealOfferedAllCustomers_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673748);
			Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673749);
			Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673750);
			Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673751);
			Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673752);
			Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673753);
			Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673754);
			Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673755);
			Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673756);
			Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673757);
			Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673758);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673759);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673760);
			Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673761);
			Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673762);
			Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673763);
			Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673764);
			Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673765);
			Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673766);
			Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673767);
			Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673768);
			Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673769);
			Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673770);
			Customer.NativeMethodInfoPtr_get_WeeklyPurchaseRecord_Public_get_List_1_ProductPurchaseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673771);
			Customer.NativeMethodInfoPtr_set_WeeklyPurchaseRecord_Protected_set_Void_List_1_ProductPurchaseRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673772);
			Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673773);
			Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673774);
			Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673775);
			Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673776);
			Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673777);
			Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673778);
			Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673779);
			Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673780);
			Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673781);
			Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673782);
			Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673783);
			Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673784);
			Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673785);
			Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673786);
			Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673787);
			Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673788);
			Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673789);
			Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673790);
			Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673791);
			Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673792);
			Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673793);
			Customer.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673794);
			Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673795);
			Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673796);
			Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673797);
			Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673798);
			Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673799);
			Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673800);
			Customer.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673801);
			Customer.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673802);
			Customer.NativeMethodInfoPtr_OfferContractToDealer_Private_Void_ContractInfo_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673803);
			Customer.NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673804);
			Customer.NativeMethodInfoPtr_GetContractTimings_Public_Static_Void_QuestWindowConfig_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673805);
			Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673806);
			Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673807);
			Customer.NativeMethodInfoPtr_ForceDealOffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673808);
			Customer.NativeMethodInfoPtr_GetOrderableProducts_Private_List_1_ProductDefinition_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673809);
			Customer.NativeMethodInfoPtr_GetOrderableProductsWithQuantities_Private_List_1_Tuple_2_ProductDefinition_Int32_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673810);
			Customer.NativeMethodInfoPtr_TryGenerateContract_Private_ContractInfo_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673811);
			Customer.NativeMethodInfoPtr_GetDeliveryLocation_Private_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673812);
			Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_Dealer_byref_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673813);
			Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673814);
			Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673815);
			Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673816);
			Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673817);
			Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673818);
			Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673819);
			Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673820);
			Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673821);
			Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673822);
			Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673823);
			Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673824);
			Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673825);
			Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673826);
			Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673827);
			Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673828);
			Customer.NativeMethodInfoPtr_ContractAccepted_Public_Contract_EDealWindow_Boolean_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673829);
			Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673830);
			Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673831);
			Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673832);
			Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673833);
			Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673834);
			Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673835);
			Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673836);
			Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673837);
			Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673838);
			Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673839);
			Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673840);
			Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673841);
			Customer.NativeMethodInfoPtr_IsDealTime_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673842);
			Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673843);
			Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673844);
			Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673845);
			Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673846);
			Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673847);
			Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673848);
			Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673849);
			Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673850);
			Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673851);
			Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673852);
			Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673853);
			Customer.NativeMethodInfoPtr_CalculateTopWeeklyPurchases_Public_Void_byref_List_1_StringIntPair_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673854);
			Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673855);
			Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673856);
			Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673857);
			Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673858);
			Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673859);
			Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673860);
			Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673861);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673862);
			Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673863);
			Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673864);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673865);
			Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673866);
			Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673867);
			Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673868);
			Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673869);
			Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673870);
			Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673871);
			Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673872);
			Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673873);
			Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673874);
			Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673875);
			Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673876);
			Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673877);
			Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673878);
			Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673879);
			Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673880);
			Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673881);
			Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673882);
			Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673883);
			Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673884);
			Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673885);
			Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673886);
			Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673887);
			Customer.NativeMethodInfoPtr_EndWait_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673888);
			Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673889);
			Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673890);
			Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673891);
			Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673892);
			Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673893);
			Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673894);
			Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673895);
			Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673896);
			Customer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673897);
			Customer.NativeMethodInfoPtr__Awake_b__139_0_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673899);
			Customer.NativeMethodInfoPtr__Start_b__140_1_Private_Void_EUnlockType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673900);
			Customer.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673901);
			Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673902);
			Customer.NativeMethodInfoPtr__HandoverChosen_b__221_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673903);
			Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__240_0_Private_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673904);
			Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673905);
			Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673906);
			Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673907);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673908);
			Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673909);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673910);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673911);
			Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673912);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673913);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673914);
			Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673915);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673916);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673917);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673918);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673919);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673920);
			Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673921);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673922);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673923);
			Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673924);
			Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673925);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673926);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673927);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673928);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673929);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673930);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673931);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673932);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673933);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673934);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673935);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673936);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_2441224929_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673937);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673938);
			Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673939);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673940);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673941);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673942);
			Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673943);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673944);
			Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673945);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673946);
			Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673947);
			Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673948);
			Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673949);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673950);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673951);
			Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673952);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673953);
			Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673954);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673955);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673956);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673957);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673958);
			Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673959);
			Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673960);
			Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673961);
			Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673962);
			Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673963);
			Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673964);
			Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673965);
			Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673966);
			Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673967);
			Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673968);
			Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673969);
			Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer>.NativeClassPtr, 100673970);
		}

		// Token: 0x060050A7 RID: 20647 RVA: 0x00191DBC File Offset: 0x0018FFBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179344, RefRangeEnd = 179345, XrefRangeStart = 179326, XrefRangeEnd = 179344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MinsSinceLastDealOfferedAllCustomers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_MinsSinceLastDealOfferedAllCustomers_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x060050A8 RID: 20648 RVA: 0x00191DEC File Offset: 0x0018FFEC
		// (set) Token: 0x060050A9 RID: 20649 RVA: 0x00191E28 File Offset: 0x00190028
		public unsafe float CurrentAddiction
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 179352, RefRangeEnd = 179356, XrefRangeStart = 179345, XrefRangeEnd = 179352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x060050AA RID: 20650 RVA: 0x00191E68 File Offset: 0x00190068
		// (set) Token: 0x060050AB RID: 20651 RVA: 0x00191EA8 File Offset: 0x001900A8
		public unsafe ContractInfo OfferedContractInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x060050AC RID: 20652 RVA: 0x00191EEC File Offset: 0x001900EC
		// (set) Token: 0x060050AD RID: 20653 RVA: 0x00191F28 File Offset: 0x00190128
		public unsafe GameDateTime OfferedContractTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x060050AE RID: 20654 RVA: 0x00191F68 File Offset: 0x00190168
		// (set) Token: 0x060050AF RID: 20655 RVA: 0x00191FA8 File Offset: 0x001901A8
		public unsafe Contract CurrentContract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060050B0 RID: 20656 RVA: 0x00191FEC File Offset: 0x001901EC
		// (set) Token: 0x060050B1 RID: 20657 RVA: 0x00192028 File Offset: 0x00190228
		public unsafe bool IsAwaitingDelivery
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060050B2 RID: 20658 RVA: 0x00192068 File Offset: 0x00190268
		// (set) Token: 0x060050B3 RID: 20659 RVA: 0x001920A4 File Offset: 0x001902A4
		public unsafe int TimeSinceLastDealCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x060050B4 RID: 20660 RVA: 0x001920E4 File Offset: 0x001902E4
		// (set) Token: 0x060050B5 RID: 20661 RVA: 0x00192120 File Offset: 0x00190320
		public unsafe int TimeSinceLastDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x060050B6 RID: 20662 RVA: 0x00192160 File Offset: 0x00190360
		// (set) Token: 0x060050B7 RID: 20663 RVA: 0x0019219C File Offset: 0x0019039C
		public unsafe int TimeSincePlayerApproached
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060050B8 RID: 20664 RVA: 0x001921DC File Offset: 0x001903DC
		// (set) Token: 0x060050B9 RID: 20665 RVA: 0x00192218 File Offset: 0x00190418
		public unsafe int TimeSinceInstantDealOffered
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060050BA RID: 20666 RVA: 0x00192258 File Offset: 0x00190458
		// (set) Token: 0x060050BB RID: 20667 RVA: 0x00192294 File Offset: 0x00190494
		public unsafe int OfferedDeals
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060050BC RID: 20668 RVA: 0x001922D4 File Offset: 0x001904D4
		// (set) Token: 0x060050BD RID: 20669 RVA: 0x00192310 File Offset: 0x00190510
		public unsafe int CompletedDeliveries
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060050BE RID: 20670 RVA: 0x00192350 File Offset: 0x00190550
		// (set) Token: 0x060050BF RID: 20671 RVA: 0x00192390 File Offset: 0x00190590
		public unsafe List<Customer.ProductPurchaseRecord> WeeklyPurchaseRecord
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_WeeklyPurchaseRecord_Public_get_List_1_ProductPurchaseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Customer.ProductPurchaseRecord>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_WeeklyPurchaseRecord_Protected_set_Void_List_1_ProductPurchaseRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060050C0 RID: 20672 RVA: 0x001923D4 File Offset: 0x001905D4
		// (set) Token: 0x060050C1 RID: 20673 RVA: 0x00192410 File Offset: 0x00190610
		public unsafe bool HasBeenRecommended
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 179363, RefRangeEnd = 179366, XrefRangeStart = 179356, XrefRangeEnd = 179363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060050C2 RID: 20674 RVA: 0x00192450 File Offset: 0x00190650
		// (set) Token: 0x060050C3 RID: 20675 RVA: 0x00192490 File Offset: 0x00190690
		public unsafe NPC NPC
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060050C4 RID: 20676 RVA: 0x001924D4 File Offset: 0x001906D4
		// (set) Token: 0x060050C5 RID: 20677 RVA: 0x00192514 File Offset: 0x00190714
		public unsafe Dealer AssignedDealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060050C6 RID: 20678 RVA: 0x00192558 File Offset: 0x00190758
		public unsafe CustomerData CustomerData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060050C7 RID: 20679 RVA: 0x00192598 File Offset: 0x00190798
		public unsafe DialogueDatabase dialogueDatabase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr3) : null;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060050C8 RID: 20680 RVA: 0x001925D8 File Offset: 0x001907D8
		// (set) Token: 0x060050C9 RID: 20681 RVA: 0x00192618 File Offset: 0x00190818
		public unsafe NPCPoI potentialCustomerPoI
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 75688, RefRangeEnd = 75698, XrefRangeStart = 75688, XrefRangeEnd = 75698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060050CA RID: 20682 RVA: 0x0019265C File Offset: 0x0019085C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179366, XrefRangeEnd = 179368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060050CB RID: 20683 RVA: 0x00192694 File Offset: 0x00190894
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179368, XrefRangeEnd = 179370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060050CC RID: 20684 RVA: 0x001926CC File Offset: 0x001908CC
		public unsafe virtual Loader Loader
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060050CD RID: 20685 RVA: 0x0019270C File Offset: 0x0019090C
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060050CE RID: 20686 RVA: 0x00192748 File Offset: 0x00190948
		// (set) Token: 0x060050CF RID: 20687 RVA: 0x00192788 File Offset: 0x00190988
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179370, XrefRangeEnd = 179371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x001927CC File Offset: 0x001909CC
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x0019280C File Offset: 0x00190A0C
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 153634, RefRangeEnd = 153653, XrefRangeStart = 153634, XrefRangeEnd = 153653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179371, XrefRangeEnd = 179372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x00192850 File Offset: 0x00190A50
		// (set) Token: 0x060050D3 RID: 20691 RVA: 0x0019288C File Offset: 0x00190A8C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x001928CC File Offset: 0x00190ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179372, XrefRangeEnd = 179373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00192908 File Offset: 0x00190B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179373, XrefRangeEnd = 179450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0019293C File Offset: 0x00190B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179450, XrefRangeEnd = 179452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00192978 File Offset: 0x00190B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179452, XrefRangeEnd = 179465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x001929C8 File Offset: 0x00190BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179465, XrefRangeEnd = 179510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050D9 RID: 20697 RVA: 0x001929FC File Offset: 0x00190BFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179613, RefRangeEnd = 179614, XrefRangeStart = 179510, XrefRangeEnd = 179613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpDialogue_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00192A30 File Offset: 0x00190C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179646, RefRangeEnd = 179647, XrefRangeStart = 179614, XrefRangeEnd = 179646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetupPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00192A64 File Offset: 0x00190C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179647, XrefRangeEnd = 179653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DC RID: 20700 RVA: 0x00192AA0 File Offset: 0x00190CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179653, XrefRangeEnd = 179750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DD RID: 20701 RVA: 0x00192ADC File Offset: 0x00190CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179750, XrefRangeEnd = 179756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DE RID: 20702 RVA: 0x00192B18 File Offset: 0x00190D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179762, RefRangeEnd = 179763, XrefRangeStart = 179756, XrefRangeEnd = 179762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OfferContractToDealer(ContractInfo info, Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_OfferContractToDealer_Private_Void_ContractInfo_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050DF RID: 20703 RVA: 0x00192B6C File Offset: 0x00190D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179763, XrefRangeEnd = 179765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E0 RID: 20704 RVA: 0x00192BA8 File Offset: 0x00190DA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179771, RefRangeEnd = 179772, XrefRangeStart = 179765, XrefRangeEnd = 179771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetContractTimings(QuestWindowConfig dealWindow, out int softStartTime, out int hardStartTime, out int endTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealWindow);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &softStartTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hardStartTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetContractTimings_Public_Static_Void_QuestWindowConfig_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E1 RID: 20705 RVA: 0x00192C08 File Offset: 0x00190E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179835, RefRangeEnd = 179836, XrefRangeStart = 179772, XrefRangeEnd = 179835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDealAttendance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E2 RID: 20706 RVA: 0x00192C3C File Offset: 0x00190E3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 179855, RefRangeEnd = 179856, XrefRangeStart = 179836, XrefRangeEnd = 179855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOfferExpiry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E3 RID: 20707 RVA: 0x00192C70 File Offset: 0x00190E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179856, XrefRangeEnd = 179862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ForceDealOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ForceDealOffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050E4 RID: 20708 RVA: 0x00192CA4 File Offset: 0x00190EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179862, XrefRangeEnd = 179884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetOrderableProducts(Dealer dealer = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderableProducts_Private_List_1_ProductDefinition_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x060050E5 RID: 20709 RVA: 0x00192CF4 File Offset: 0x00190EF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 179949, RefRangeEnd = 179952, XrefRangeStart = 179884, XrefRangeEnd = 179949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<ProductDefinition, int>> GetOrderableProductsWithQuantities(Dealer dealer = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderableProductsWithQuantities_Private_List_1_Tuple_2_ProductDefinition_Int32_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<ProductDefinition, int>>>(intPtr3) : null;
		}

		// Token: 0x060050E6 RID: 20710 RVA: 0x00192D44 File Offset: 0x00190F44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180044, RefRangeEnd = 180047, XrefRangeStart = 179952, XrefRangeEnd = 180044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContractInfo TryGenerateContract(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_TryGenerateContract_Private_ContractInfo_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr3) : null;
		}

		// Token: 0x060050E7 RID: 20711 RVA: 0x00192D94 File Offset: 0x00190F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180047, XrefRangeEnd = 180062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryLocation GetDeliveryLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetDeliveryLocation_Private_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
		}

		// Token: 0x060050E8 RID: 20712 RVA: 0x00192DD4 File Offset: 0x00190FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 180122, RefRangeEnd = 180123, XrefRangeStart = 180062, XrefRangeEnd = 180122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetWeightedRandomProduct(Dealer dealer, out float appeal, out int orderableQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &appeal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &orderableQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_Dealer_byref_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
		}

		// Token: 0x060050E9 RID: 20713 RVA: 0x00192E40 File Offset: 0x00191040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180123, XrefRangeEnd = 180162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCustomerUnlocked(NPCRelationData.EUnlockType unlockType, bool notify)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref unlockType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EA RID: 20714 RVA: 0x00192E98 File Offset: 0x00191098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180162, XrefRangeEnd = 180163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHasBeenRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EB RID: 20715 RVA: 0x00192ECC File Offset: 0x001910CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180163, XrefRangeEnd = 180205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferContract(ContractInfo info)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EC RID: 20716 RVA: 0x00192F1C File Offset: 0x0019111C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180205, XrefRangeEnd = 180216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOfferedContract(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050ED RID: 20717 RVA: 0x00192F6C File Offset: 0x0019116C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180216, XrefRangeEnd = 180237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExpireOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EE RID: 20718 RVA: 0x00192FA8 File Offset: 0x001911A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180237, XrefRangeEnd = 180249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050EF RID: 20719 RVA: 0x00192FF8 File Offset: 0x001911F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180249, XrefRangeEnd = 180303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyPlayerOfContract(ContractInfo contract, MessageChain offerMessage, bool canAccept, bool canReject, bool canCounterOffer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(offerMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canAccept;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canReject;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canCounterOffer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F0 RID: 20720 RVA: 0x00193084 File Offset: 0x00191284
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180324, RefRangeEnd = 180326, XrefRangeStart = 180303, XrefRangeEnd = 180324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUpResponseCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F1 RID: 20721 RVA: 0x001930B8 File Offset: 0x001912B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180326, XrefRangeEnd = 180337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AcceptContractClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F2 RID: 20722 RVA: 0x001930F4 File Offset: 0x001912F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180337, XrefRangeEnd = 180356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CounterOfferClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F3 RID: 20723 RVA: 0x00193130 File Offset: 0x00191330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180356, XrefRangeEnd = 180402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F4 RID: 20724 RVA: 0x0019319C File Offset: 0x0019139C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180402, XrefRangeEnd = 180415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCounterOfferServerSide(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F5 RID: 20725 RVA: 0x001931FC File Offset: 0x001913FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180415, XrefRangeEnd = 180434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContractIsCounterOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F6 RID: 20726 RVA: 0x00193230 File Offset: 0x00191430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180434, XrefRangeEnd = 180503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayerAcceptedContract(EDealWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F7 RID: 20727 RVA: 0x0019327C File Offset: 0x0019147C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180503, XrefRangeEnd = 180514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendContractAccepted(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050F8 RID: 20728 RVA: 0x001932C8 File Offset: 0x001914C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180552, RefRangeEnd = 180555, XrefRangeStart = 180514, XrefRangeEnd = 180552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract ContractAccepted(EDealWindow window, bool trackContract, Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ContractAccepted_Public_Contract_EDealWindow_Boolean_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
		}

		// Token: 0x060050F9 RID: 20729 RVA: 0x00193334 File Offset: 0x00191534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180555, XrefRangeEnd = 180576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FA RID: 20730 RVA: 0x00193368 File Offset: 0x00191568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180576, XrefRangeEnd = 180582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractAcceptedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FB RID: 20731 RVA: 0x001933A4 File Offset: 0x001915A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180582, XrefRangeEnd = 180617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool EvaluateCounteroffer(ProductDefinition product, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050FC RID: 20732 RVA: 0x00193418 File Offset: 0x00191618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180617, XrefRangeEnd = 180618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetValueProposition(ProductDefinition product, float price)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060050FD RID: 20733 RVA: 0x00193468 File Offset: 0x00191668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180618, XrefRangeEnd = 180647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x001934A4 File Offset: 0x001916A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180647, XrefRangeEnd = 180668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveContractRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x001934D8 File Offset: 0x001916D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180668, XrefRangeEnd = 180674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayContractRejectedReaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x00193514 File Offset: 0x00191714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180674, XrefRangeEnd = 180698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsAwaitingDelivery(bool awaiting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref awaiting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00193560 File Offset: 0x00191760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180707, RefRangeEnd = 180710, XrefRangeStart = 180698, XrefRangeEnd = 180707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDealLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x0019359C File Offset: 0x0019179C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 180716, RefRangeEnd = 180719, XrefRangeStart = 180710, XrefRangeEnd = 180716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePotentialCustomerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005103 RID: 20739 RVA: 0x001935D0 File Offset: 0x001917D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180719, XrefRangeEnd = 180724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPotentialCustomerPoIEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00193610 File Offset: 0x00191810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180724, XrefRangeEnd = 180744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryGenerateDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00193658 File Offset: 0x00191858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180765, RefRangeEnd = 180767, XrefRangeStart = 180744, XrefRangeEnd = 180765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDealTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_IsDealTime_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00193694 File Offset: 0x00191894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180767, XrefRangeEnd = 180779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OfferDealItems(List<ItemInstance> items, bool offeredByPlayer, out bool accepted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offeredByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &accepted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00193700 File Offset: 0x00191900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180779, XrefRangeEnd = 180805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CustomerRejectedDeal(bool offeredByPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offeredByPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x0019374C File Offset: 0x0019194C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180805, XrefRangeEnd = 180941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessHandover(HandoverScreen.EHandoverOutcome outcome, Contract contract, List<ItemInstance> items, bool handoverByPlayer, bool giveBonuses = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref giveBonuses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x001937D8 File Offset: 0x001919D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180941, XrefRangeEnd = 180957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverServerSide(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510A RID: 20746 RVA: 0x00193878 File Offset: 0x00191A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180957, XrefRangeEnd = 180970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessHandoverClient(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_EHandoverOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x001938E4 File Offset: 0x00191AE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180990, RefRangeEnd = 180992, XrefRangeStart = 180970, XrefRangeEnd = 180990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContractWellReceived(string npcToRecommend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510C RID: 20748 RVA: 0x00193928 File Offset: 0x00191B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180992, XrefRangeEnd = 181078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x0019396C File Offset: 0x00191B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181078, XrefRangeEnd = 181153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x001939B0 File Offset: 0x00191BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181153, XrefRangeEnd = 181236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecommendCustomer(Customer friend)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600510F RID: 20751 RVA: 0x001939F4 File Offset: 0x00191BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181236, XrefRangeEnd = 181243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CurrentContractEnded(EQuestState outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005110 RID: 20752 RVA: 0x00193A40 File Offset: 0x00191C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181243, XrefRangeEnd = 181336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float EvaluateDelivery(Contract contract, List<ItemInstance> providedItems, out float highestAddiction, out EDrugType mainTypeType, out int matchedProductCount, out float qualityDifference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedItems);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &highestAddiction;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &mainTypeType;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchedProductCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &qualityDifference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_byref_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005111 RID: 20753 RVA: 0x00193AE8 File Offset: 0x00191CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181336, XrefRangeEnd = 181427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateTopWeeklyPurchases(out List<StringIntPair> mostPurchasedProducts, out float totalSpent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &totalSpent;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_CalculateTopWeeklyPurchases_Public_Void_byref_List_1_StringIntPair_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			mostPurchasedProducts = ((intPtr4 == 0) ? null : new List<StringIntPair>(intPtr4));
		}

		// Token: 0x06005112 RID: 20754 RVA: 0x00193B48 File Offset: 0x00191D48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181437, RefRangeEnd = 181439, XrefRangeStart = 181427, XrefRangeEnd = 181437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAddiction(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005113 RID: 20755 RVA: 0x00193B88 File Offset: 0x00191D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181439, XrefRangeEnd = 181452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x00193BCC File Offset: 0x00191DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181452, XrefRangeEnd = 181464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowOfferDealOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00193C20 File Offset: 0x00191E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181464, XrefRangeEnd = 181473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool OfferDealValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00193C84 File Offset: 0x00191E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181473, XrefRangeEnd = 181485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InstantDealOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00193CC0 File Offset: 0x00191EC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181571, RefRangeEnd = 181573, XrefRangeStart = 181485, XrefRangeEnd = 181571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOfferSuccessChance(List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00193D1C File Offset: 0x00191F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181573, XrefRangeEnd = 181622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldTryApproachPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005119 RID: 20761 RVA: 0x00193D64 File Offset: 0x00191F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181622, XrefRangeEnd = 181624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00193D98 File Offset: 0x00191F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181636, RefRangeEnd = 181638, XrefRangeStart = 181624, XrefRangeEnd = 181636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestProduct(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x00193DDC File Offset: 0x00191FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181657, RefRangeEnd = 181658, XrefRangeStart = 181638, XrefRangeEnd = 181657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerRejectedProductRequest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511C RID: 20764 RVA: 0x00193E10 File Offset: 0x00192010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181667, RefRangeEnd = 181668, XrefRangeStart = 181658, XrefRangeEnd = 181667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511D RID: 20765 RVA: 0x00193E44 File Offset: 0x00192044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181668, XrefRangeEnd = 181689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RejectProductRequestOffer_Local()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511E RID: 20766 RVA: 0x00193E78 File Offset: 0x00192078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 140441, RefRangeEnd = 140444, XrefRangeStart = 140441, XrefRangeEnd = 140444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600511F RID: 20767 RVA: 0x00193EBC File Offset: 0x001920BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181689, XrefRangeEnd = 181691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005120 RID: 20768 RVA: 0x00193F00 File Offset: 0x00192100
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181703, RefRangeEnd = 181705, XrefRangeStart = 181691, XrefRangeEnd = 181703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerData GetCustomerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr3) : null;
		}

		// Token: 0x06005121 RID: 20769 RVA: 0x00193F40 File Offset: 0x00192140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181705, XrefRangeEnd = 181711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06005122 RID: 20770 RVA: 0x00193F9C File Offset: 0x0019219C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181711, XrefRangeEnd = 181721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveCustomerData(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005123 RID: 20771 RVA: 0x00193FF0 File Offset: 0x001921F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181721, XrefRangeEnd = 181742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005124 RID: 20772 RVA: 0x00194040 File Offset: 0x00192240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181742, XrefRangeEnd = 181750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsReadyForHandover(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005125 RID: 20773 RVA: 0x00194094 File Offset: 0x00192294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181750, XrefRangeEnd = 181762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsHandoverChoiceValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005126 RID: 20774 RVA: 0x001940F8 File Offset: 0x001922F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181762, XrefRangeEnd = 181774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandoverChosen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_HandoverChosen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005127 RID: 20775 RVA: 0x0019412C File Offset: 0x0019232C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181774, XrefRangeEnd = 181782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowDirectApproachOption(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005128 RID: 20776 RVA: 0x00194180 File Offset: 0x00192380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181782, XrefRangeEnd = 181783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsUnlockable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005129 RID: 20777 RVA: 0x001941C8 File Offset: 0x001923C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181783, XrefRangeEnd = 181800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool SampleOptionValid(out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600512A RID: 20778 RVA: 0x0019422C File Offset: 0x0019242C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181800, XrefRangeEnd = 181807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KnownAndRecommended()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600512B RID: 20779 RVA: 0x00194268 File Offset: 0x00192468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181807, XrefRangeEnd = 181808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleOffered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleOffered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600512C RID: 20780 RVA: 0x0019429C File Offset: 0x0019249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181808, XrefRangeEnd = 181814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetSampleRequestSuccessChance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600512D RID: 20781 RVA: 0x001942E4 File Offset: 0x001924E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181814, XrefRangeEnd = 181833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SampleAccepted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600512E RID: 20782 RVA: 0x00194320 File Offset: 0x00192520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181863, RefRangeEnd = 181864, XrefRangeStart = 181833, XrefRangeEnd = 181863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSampleSuccess(List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0019437C File Offset: 0x0019257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181864, XrefRangeEnd = 181894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSample(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005130 RID: 20784 RVA: 0x001943DC File Offset: 0x001925DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181894, XrefRangeEnd = 181916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleServerSide(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x00194420 File Offset: 0x00192620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181916, XrefRangeEnd = 181937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessSampleClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00194454 File Offset: 0x00192654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 181937, XrefRangeEnd = 182038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleConsumed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleConsumed_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00194488 File Offset: 0x00192688
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182047, RefRangeEnd = 182049, XrefRangeStart = 182038, XrefRangeEnd = 182047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_EndWait_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005134 RID: 20788 RVA: 0x001944BC File Offset: 0x001926BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182049, XrefRangeEnd = 182069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DirectApproachRejected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005135 RID: 20789 RVA: 0x001944F8 File Offset: 0x001926F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182069, XrefRangeEnd = 182078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasSufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005136 RID: 20790 RVA: 0x0019452C File Offset: 0x0019272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182078, XrefRangeEnd = 182087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SampleWasInsufficient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005137 RID: 20791 RVA: 0x00194560 File Offset: 0x00192760
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182120, RefRangeEnd = 182122, XrefRangeStart = 182087, XrefRangeEnd = 182120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductEnjoyment(ProductDefinition product, EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005138 RID: 20792 RVA: 0x001945BC File Offset: 0x001927BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182150, RefRangeEnd = 182153, XrefRangeStart = 182122, XrefRangeEnd = 182150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductEnjoyment(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x0019460C File Offset: 0x0019280C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182182, RefRangeEnd = 182184, XrefRangeStart = 182153, XrefRangeEnd = 182182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EDrugType> GetOrderedDrugTypes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EDrugType>>(intPtr3) : null;
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x0019464C File Offset: 0x0019284C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182184, XrefRangeEnd = 182195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustAffinity(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00194698 File Offset: 0x00192898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182195, XrefRangeEnd = 182205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutocreateCustomerSettings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x001946CC File Offset: 0x001928CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182205, XrefRangeEnd = 182232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Customer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00194708 File Offset: 0x00192908
		[CallerCount(0)]
		public unsafe void _Awake_b__139_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Awake_b__139_0_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x0019473C File Offset: 0x0019293C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182232, XrefRangeEnd = 182233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__140_1(NPCRelationData.EUnlockType <p0>, bool <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref <p1>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__Start_b__140_1_Private_Void_EUnlockType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00194788 File Offset: 0x00192988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182259, RefRangeEnd = 182260, XrefRangeStart = 182233, XrefRangeEnd = 182259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x001947BC File Offset: 0x001929BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182260, XrefRangeEnd = 182321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float askingPrice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askingPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x0019481C File Offset: 0x00192A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182321, XrefRangeEnd = 182322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _HandoverChosen_b__221_0(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__HandoverChosen_b__221_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x0019487C File Offset: 0x00192A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182322, XrefRangeEnd = 182335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _GetOrderedDrugTypes_b__240_0(EDrugType x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr__GetOrderedDrugTypes_b__240_0_Private_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x001948C8 File Offset: 0x00192AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182335, XrefRangeEnd = 182497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00194904 File Offset: 0x00192B04
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00194940 File Offset: 0x00192B40
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x0019497C File Offset: 0x00192B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x001949CC File Offset: 0x00192BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182497, XrefRangeEnd = 182498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetOfferedContract_4277245194(ContractInfo info, GameDateTime offerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00194A1C File Offset: 0x00192C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182498, XrefRangeEnd = 182502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetOfferedContract_4277245194(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00194A6C File Offset: 0x00192C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182502, XrefRangeEnd = 182511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00194AA0 File Offset: 0x00192CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182518, RefRangeEnd = 182520, XrefRangeStart = 182511, XrefRangeEnd = 182518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___ExpireOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00194ADC File Offset: 0x00192CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182520, XrefRangeEnd = 182523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ExpireOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00194B40 File Offset: 0x00192D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182523, XrefRangeEnd = 182532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00194B74 File Offset: 0x00192D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 182573, RefRangeEnd = 182575, XrefRangeStart = 182532, XrefRangeEnd = 182573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUpResponseCallbacks_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00194BA8 File Offset: 0x00192DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182575, XrefRangeEnd = 182578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUpResponseCallbacks_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00194BF8 File Offset: 0x00192DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00194C58 File Offset: 0x00192E58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182663, RefRangeEnd = 182664, XrefRangeStart = 182578, XrefRangeEnd = 182663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessCounterOfferServerSide_900355577(string productID, int quantity, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x00194CB8 File Offset: 0x00192EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182664, XrefRangeEnd = 182670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessCounterOfferServerSide_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x00194D1C File Offset: 0x00192F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182670, XrefRangeEnd = 182679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00194D50 File Offset: 0x00192F50
		[CallerCount(0)]
		public unsafe void RpcLogic___SetContractIsCounterOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x00194D84 File Offset: 0x00192F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182679, XrefRangeEnd = 182681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetContractIsCounterOffer_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00194DD4 File Offset: 0x00192FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x00194E20 File Offset: 0x00193020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182681, XrefRangeEnd = 182682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendContractAccepted_507093020(EDealWindow window, bool trackContract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref window;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackContract;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00194E6C File Offset: 0x0019306C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182682, XrefRangeEnd = 182685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendContractAccepted_507093020(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00194ED0 File Offset: 0x001930D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182685, XrefRangeEnd = 182694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00194F04 File Offset: 0x00193104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182694, XrefRangeEnd = 182695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractAccepted_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x00194F38 File Offset: 0x00193138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182695, XrefRangeEnd = 182698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractAccepted_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00194F88 File Offset: 0x00193188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182698, XrefRangeEnd = 182707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00194FBC File Offset: 0x001931BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveContractRejected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x00194FF0 File Offset: 0x001931F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveContractRejected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x00195040 File Offset: 0x00193240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600515F RID: 20831 RVA: 0x001950E0 File Offset: 0x001932E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182916, RefRangeEnd = 182917, XrefRangeStart = 182707, XrefRangeEnd = 182916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverServerSide_3760244802(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, bool handoverByPlayer, float totalPayment, ProductList productList, float satisfaction, NetworkObject dealerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productList);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00195180 File Offset: 0x00193380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182917, XrefRangeEnd = 182925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessHandoverServerSide_3760244802(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005161 RID: 20833 RVA: 0x001951E4 File Offset: 0x001933E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessHandoverClient_2441224929(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00195250 File Offset: 0x00193450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182925, XrefRangeEnd = 182931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessHandoverClient_2441224929(float satisfaction, bool handoverByPlayer, string npcToRecommend, HandoverScreen.EHandoverOutcome outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handoverByPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(npcToRecommend);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outcome;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x001952BC File Offset: 0x001934BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182931, XrefRangeEnd = 182941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessHandoverClient_2441224929(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_2441224929_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x0019530C File Offset: 0x0019350C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 181437, RefRangeEnd = 181439, XrefRangeStart = 181437, XrefRangeEnd = 181439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x0019534C File Offset: 0x0019354C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182941, XrefRangeEnd = 182942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ChangeAddiction_431000436(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x0019538C File Offset: 0x0019358C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182942, XrefRangeEnd = 182945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ChangeAddiction_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005167 RID: 20839 RVA: 0x001953F0 File Offset: 0x001935F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 181667, RefRangeEnd = 181668, XrefRangeStart = 181667, XrefRangeEnd = 181668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005168 RID: 20840 RVA: 0x00195424 File Offset: 0x00193624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 182976, RefRangeEnd = 182977, XrefRangeStart = 182945, XrefRangeEnd = 182976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005169 RID: 20841 RVA: 0x00195458 File Offset: 0x00193658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182977, XrefRangeEnd = 182979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RejectProductRequestOffer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x001954BC File Offset: 0x001936BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182979, XrefRangeEnd = 182988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x001954F0 File Offset: 0x001936F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182997, RefRangeEnd = 183000, XrefRangeStart = 182988, XrefRangeEnd = 182997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RejectProductRequestOffer_Local_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x00195524 File Offset: 0x00193724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183000, XrefRangeEnd = 183003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RejectProductRequestOffer_Local_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x00195574 File Offset: 0x00193774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516E RID: 20846 RVA: 0x001955C8 File Offset: 0x001937C8
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveCustomerData_2280244125(NetworkConnection conn, CustomerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600516F RID: 20847 RVA: 0x0019561C File Offset: 0x0019381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183003, XrefRangeEnd = 183006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveCustomerData_2280244125(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x0019566C File Offset: 0x0019386C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183006, XrefRangeEnd = 183016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x001956B0 File Offset: 0x001938B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 183054, RefRangeEnd = 183059, XrefRangeStart = 183016, XrefRangeEnd = 183054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleServerSide_3704012609(List<ItemInstance> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x001956F4 File Offset: 0x001938F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183059, XrefRangeEnd = 183063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ProcessSampleServerSide_3704012609(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00195758 File Offset: 0x00193958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183063, XrefRangeEnd = 183072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005174 RID: 20852 RVA: 0x0019578C File Offset: 0x0019398C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183079, RefRangeEnd = 183082, XrefRangeStart = 183072, XrefRangeEnd = 183079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ProcessSampleClient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x001957C0 File Offset: 0x001939C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183082, XrefRangeEnd = 183085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ProcessSampleClient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00195810 File Offset: 0x00193A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005177 RID: 20855 RVA: 0x00195844 File Offset: 0x00193A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183085, XrefRangeEnd = 183093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasSufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005178 RID: 20856 RVA: 0x00195878 File Offset: 0x00193A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183093, XrefRangeEnd = 183102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasSufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005179 RID: 20857 RVA: 0x001958C8 File Offset: 0x00193AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x001958FC File Offset: 0x00193AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183125, RefRangeEnd = 183126, XrefRangeStart = 183102, XrefRangeEnd = 183125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SampleWasInsufficient_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00195930 File Offset: 0x00193B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183126, XrefRangeEnd = 183128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SampleWasInsufficient_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00195980 File Offset: 0x00193B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517D RID: 20861 RVA: 0x001959CC File Offset: 0x00193BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183128, XrefRangeEnd = 183141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AdjustAffinity_3036964899(EDrugType drugType, float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref drugType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00195A18 File Offset: 0x00193C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183141, XrefRangeEnd = 183157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AdjustAffinity_3036964899(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x00195A7C File Offset: 0x00193C7C
		// (set) Token: 0x06005180 RID: 20864 RVA: 0x00195AB8 File Offset: 0x00193CB8
		public unsafe float SyncAccessor_<CurrentAddiction>k__BackingField
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75479, RefRangeEnd = 75481, XrefRangeStart = 75479, XrefRangeEnd = 75481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183157, XrefRangeEnd = 183165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005181 RID: 20865 RVA: 0x00195B04 File Offset: 0x00193D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183165, XrefRangeEnd = 183167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Economy_Customer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x00195B78 File Offset: 0x00193D78
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x00195BB4 File Offset: 0x00193DB4
		public unsafe bool SyncAccessor_<HasBeenRecommended>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183167, XrefRangeEnd = 183175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00195C00 File Offset: 0x00193E00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183218, RefRangeEnd = 183219, XrefRangeStart = 183175, XrefRangeEnd = 183218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Customer.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00026A0E File Offset: 0x00024C0E
		public Customer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06005186 RID: 20870 RVA: 0x00195C3C File Offset: 0x00193E3C
		// (set) Token: 0x06005187 RID: 20871 RVA: 0x00026A17 File Offset: 0x00024C17
		public unsafe static Action<Customer> onCustomerUnlocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_onCustomerUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x00195C64 File Offset: 0x00193E64
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x00026A29 File Offset: 0x00024C29
		public unsafe static List<Customer> LockedCustomers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_LockedCustomers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_LockedCustomers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700192F RID: 6447
		// (get) Token: 0x0600518A RID: 20874 RVA: 0x00195C8C File Offset: 0x00193E8C
		// (set) Token: 0x0600518B RID: 20875 RVA: 0x00026A3B File Offset: 0x00024C3B
		public unsafe static List<Customer> UnlockedCustomers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_UnlockedCustomers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600518C RID: 20876 RVA: 0x00195CB4 File Offset: 0x00193EB4
		// (set) Token: 0x0600518D RID: 20877 RVA: 0x00026A4D File Offset: 0x00024C4D
		public unsafe static int QualityTierTolerance
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_QualityTierTolerance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_QualityTierTolerance, (void*)(&value));
			}
		}

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x0600518E RID: 20878 RVA: 0x00195CD0 File Offset: 0x00193ED0
		// (set) Token: 0x0600518F RID: 20879 RVA: 0x00026A5B File Offset: 0x00024C5B
		public unsafe static int MaxOrderQuantityPerProduct
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MaxOrderQuantityPerProduct, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MaxOrderQuantityPerProduct, (void*)(&value));
			}
		}

		// Token: 0x17001932 RID: 6450
		// (get) Token: 0x06005190 RID: 20880 RVA: 0x00195CEC File Offset: 0x00193EEC
		// (set) Token: 0x06005191 RID: 20881 RVA: 0x00026A69 File Offset: 0x00024C69
		public unsafe static float AFFINITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_AFFINITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001933 RID: 6451
		// (get) Token: 0x06005192 RID: 20882 RVA: 0x00195D08 File Offset: 0x00193F08
		// (set) Token: 0x06005193 RID: 20883 RVA: 0x00026A77 File Offset: 0x00024C77
		public unsafe static float PROPERTY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PROPERTY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001934 RID: 6452
		// (get) Token: 0x06005194 RID: 20884 RVA: 0x00195D24 File Offset: 0x00193F24
		// (set) Token: 0x06005195 RID: 20885 RVA: 0x00026A85 File Offset: 0x00024C85
		public unsafe static float QUALITY_MAX_EFFECT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_QUALITY_MAX_EFFECT, (void*)(&value));
			}
		}

		// Token: 0x17001935 RID: 6453
		// (get) Token: 0x06005196 RID: 20886 RVA: 0x00195D40 File Offset: 0x00193F40
		// (set) Token: 0x06005197 RID: 20887 RVA: 0x00026A93 File Offset: 0x00024C93
		public unsafe static float DEAL_REJECTED_RELATIONSHIP_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001936 RID: 6454
		// (get) Token: 0x06005198 RID: 20888 RVA: 0x00195D5C File Offset: 0x00193F5C
		// (set) Token: 0x06005199 RID: 20889 RVA: 0x00026AA1 File Offset: 0x00024CA1
		public unsafe static int ATTACK_DEAL_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_ATTACK_DEAL_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_ATTACK_DEAL_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001937 RID: 6455
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x00195D78 File Offset: 0x00193F78
		// (set) Token: 0x0600519B RID: 20891 RVA: 0x00026AAF File Offset: 0x00024CAF
		public unsafe static float RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL, (void*)(&value));
			}
		}

		// Token: 0x17001938 RID: 6456
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x00195D94 File Offset: 0x00193F94
		// (set) Token: 0x0600519D RID: 20893 RVA: 0x00026ABD File Offset: 0x00024CBD
		public unsafe static float CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE, (void*)(&value));
			}
		}

		// Token: 0x17001939 RID: 6457
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x00195DB0 File Offset: 0x00193FB0
		// (set) Token: 0x0600519F RID: 20895 RVA: 0x00026ACB File Offset: 0x00024CCB
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x1700193A RID: 6458
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x00195DD8 File Offset: 0x00193FD8
		// (set) Token: 0x060051A1 RID: 20897 RVA: 0x00026AE6 File Offset: 0x00024CE6
		public unsafe static float APPROACH_MIN_ADDICTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_ADDICTION, (void*)(&value));
			}
		}

		// Token: 0x1700193B RID: 6459
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x00195DF4 File Offset: 0x00193FF4
		// (set) Token: 0x060051A3 RID: 20899 RVA: 0x00026AF4 File Offset: 0x00024CF4
		public unsafe static float APPROACH_CHANCE_PER_DAY_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX, (void*)(&value));
			}
		}

		// Token: 0x1700193C RID: 6460
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x00195E10 File Offset: 0x00194010
		// (set) Token: 0x060051A5 RID: 20901 RVA: 0x00026B02 File Offset: 0x00024D02
		public unsafe static float APPROACH_MIN_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700193D RID: 6461
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x00195E2C File Offset: 0x0019402C
		// (set) Token: 0x060051A7 RID: 20903 RVA: 0x00026B10 File Offset: 0x00024D10
		public unsafe static float APPROACH_MAX_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x00195E48 File Offset: 0x00194048
		// (set) Token: 0x060051A9 RID: 20905 RVA: 0x00026B1E File Offset: 0x00024D1E
		public unsafe static int DEAL_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x00195E64 File Offset: 0x00194064
		// (set) Token: 0x060051AB RID: 20907 RVA: 0x00026B2C File Offset: 0x00024D2C
		public unsafe static Il2CppStringArray PlayerAcceptMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerAcceptMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x00195E8C File Offset: 0x0019408C
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x00026B3E File Offset: 0x00024D3E
		public unsafe static Il2CppStringArray PlayerRejectMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_PlayerRejectMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x00195EB4 File Offset: 0x001940B4
		// (set) Token: 0x060051AF RID: 20911 RVA: 0x00026B50 File Offset: 0x00024D50
		public unsafe static int DEAL_ATTENDANCE_TOLERANCE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE, (void*)(&value));
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x00195ED0 File Offset: 0x001940D0
		// (set) Token: 0x060051B1 RID: 20913 RVA: 0x00026B5E File Offset: 0x00024D5E
		public unsafe static int MIN_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001943 RID: 6467
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x00195EEC File Offset: 0x001940EC
		// (set) Token: 0x060051B3 RID: 20915 RVA: 0x00026B6C File Offset: 0x00024D6C
		public unsafe static int MAX_TRAVEL_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MAX_TRAVEL_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001944 RID: 6468
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x00195F08 File Offset: 0x00194108
		// (set) Token: 0x060051B5 RID: 20917 RVA: 0x00026B7A File Offset: 0x00024D7A
		public unsafe static int OFFER_EXPIRY_TIME_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001945 RID: 6469
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x00195F24 File Offset: 0x00194124
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x00026B88 File Offset: 0x00024D88
		public unsafe static float MIN_ORDER_APPEAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_ORDER_APPEAL, (void*)(&value));
			}
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x00195F40 File Offset: 0x00194140
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x00026B96 File Offset: 0x00024D96
		public unsafe static float ADDICTION_DRAIN_PER_DAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY, (void*)(&value));
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x00195F5C File Offset: 0x0019415C
		// (set) Token: 0x060051BB RID: 20923 RVA: 0x00026BA4 File Offset: 0x00024DA4
		public unsafe static bool SAMPLE_REQUIRES_RECOMMENDATION
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x00195F78 File Offset: 0x00194178
		// (set) Token: 0x060051BD RID: 20925 RVA: 0x00026BB2 File Offset: 0x00024DB2
		public unsafe static float MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x00195F94 File Offset: 0x00194194
		// (set) Token: 0x060051BF RID: 20927 RVA: 0x00026BC0 File Offset: 0x00024DC0
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x00195FB0 File Offset: 0x001941B0
		// (set) Token: 0x060051C1 RID: 20929 RVA: 0x00026BCE File Offset: 0x00024DCE
		public unsafe static float RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Customer.NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION, (void*)(&value));
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00195FCC File Offset: 0x001941CC
		// (set) Token: 0x060051C3 RID: 20931 RVA: 0x00026BDC File Offset: 0x00024DDC
		public unsafe float _CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentAddiction_k__BackingField)) = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00195FF4 File Offset: 0x001941F4
		// (set) Token: 0x060051C5 RID: 20933 RVA: 0x00026BF7 File Offset: 0x00024DF7
		public unsafe ContractInfo offeredContractInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContractInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offeredContractInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x00196024 File Offset: 0x00194224
		// (set) Token: 0x060051C7 RID: 20935 RVA: 0x00026C16 File Offset: 0x00024E16
		public unsafe GameDateTime _OfferedContractTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedContractTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060051C8 RID: 20936 RVA: 0x0019604C File Offset: 0x0019424C
		// (set) Token: 0x060051C9 RID: 20937 RVA: 0x00026C31 File Offset: 0x00024E31
		public unsafe Contract _CurrentContract_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CurrentContract_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060051CA RID: 20938 RVA: 0x0019607C File Offset: 0x0019427C
		// (set) Token: 0x060051CB RID: 20939 RVA: 0x00026C50 File Offset: 0x00024E50
		public unsafe bool _IsAwaitingDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField)) = value;
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060051CC RID: 20940 RVA: 0x001960A4 File Offset: 0x001942A4
		// (set) Token: 0x060051CD RID: 20941 RVA: 0x00026C6B File Offset: 0x00024E6B
		public unsafe int _TimeSinceLastDealCompleted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField)) = value;
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x060051CE RID: 20942 RVA: 0x001960CC File Offset: 0x001942CC
		// (set) Token: 0x060051CF RID: 20943 RVA: 0x00026C86 File Offset: 0x00024E86
		public unsafe int _TimeSinceLastDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x060051D0 RID: 20944 RVA: 0x001960F4 File Offset: 0x001942F4
		// (set) Token: 0x060051D1 RID: 20945 RVA: 0x00026CA1 File Offset: 0x00024EA1
		public unsafe int _TimeSincePlayerApproached_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField)) = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x0019611C File Offset: 0x0019431C
		// (set) Token: 0x060051D3 RID: 20947 RVA: 0x00026CBC File Offset: 0x00024EBC
		public unsafe int _TimeSinceInstantDealOffered_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField)) = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x060051D4 RID: 20948 RVA: 0x00196144 File Offset: 0x00194344
		// (set) Token: 0x060051D5 RID: 20949 RVA: 0x00026CD7 File Offset: 0x00024ED7
		public unsafe int _OfferedDeals_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__OfferedDeals_k__BackingField)) = value;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x060051D6 RID: 20950 RVA: 0x0019616C File Offset: 0x0019436C
		// (set) Token: 0x060051D7 RID: 20951 RVA: 0x00026CF2 File Offset: 0x00024EF2
		public unsafe int _CompletedDeliveries_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__CompletedDeliveries_k__BackingField)) = value;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x060051D8 RID: 20952 RVA: 0x00196194 File Offset: 0x00194394
		// (set) Token: 0x060051D9 RID: 20953 RVA: 0x00026D0D File Offset: 0x00024F0D
		public unsafe List<Customer.ProductPurchaseRecord> _WeeklyPurchaseRecord_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__WeeklyPurchaseRecord_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Customer.ProductPurchaseRecord>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__WeeklyPurchaseRecord_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x001961C4 File Offset: 0x001943C4
		// (set) Token: 0x060051DB RID: 20955 RVA: 0x00026D2C File Offset: 0x00024F2C
		public unsafe bool _HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasBeenRecommended_k__BackingField)) = value;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x001961EC File Offset: 0x001943EC
		// (set) Token: 0x060051DD RID: 20957 RVA: 0x00026D47 File Offset: 0x00024F47
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x0019621C File Offset: 0x0019441C
		// (set) Token: 0x060051DF RID: 20959 RVA: 0x00026D66 File Offset: 0x00024F66
		public unsafe Dealer _AssignedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__AssignedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x060051E0 RID: 20960 RVA: 0x0019624C File Offset: 0x0019444C
		// (set) Token: 0x060051E1 RID: 20961 RVA: 0x00026D85 File Offset: 0x00024F85
		public unsafe CustomerData customerData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_customerData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x060051E2 RID: 20962 RVA: 0x0019627C File Offset: 0x0019447C
		// (set) Token: 0x060051E3 RID: 20963 RVA: 0x00026DA4 File Offset: 0x00024FA4
		public unsafe UnityEvent onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x060051E4 RID: 20964 RVA: 0x001962AC File Offset: 0x001944AC
		// (set) Token: 0x060051E5 RID: 20965 RVA: 0x00026DC3 File Offset: 0x00024FC3
		public unsafe UnityEvent onDealCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onDealCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x060051E6 RID: 20966 RVA: 0x001962DC File Offset: 0x001944DC
		// (set) Token: 0x060051E7 RID: 20967 RVA: 0x00026DE2 File Offset: 0x00024FE2
		public unsafe UnityEvent<Contract> onContractAssigned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Contract>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_onContractAssigned), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x060051E8 RID: 20968 RVA: 0x0019630C File Offset: 0x0019450C
		// (set) Token: 0x060051E9 RID: 20969 RVA: 0x00026E01 File Offset: 0x00025001
		public unsafe bool awaitingSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingSample)) = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x060051EA RID: 20970 RVA: 0x00196334 File Offset: 0x00194534
		// (set) Token: 0x060051EB RID: 20971 RVA: 0x00026E1C File Offset: 0x0002501C
		public unsafe DialogueController.DialogueChoice sampleChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x060051EC RID: 20972 RVA: 0x00196364 File Offset: 0x00194564
		// (set) Token: 0x060051ED RID: 20973 RVA: 0x00026E3B File Offset: 0x0002503B
		public unsafe DialogueController.DialogueChoice completeContractChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_completeContractChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x060051EE RID: 20974 RVA: 0x00196394 File Offset: 0x00194594
		// (set) Token: 0x060051EF RID: 20975 RVA: 0x00026E5A File Offset: 0x0002505A
		public unsafe DialogueController.DialogueChoice offerDealChoice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_offerDealChoice), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x060051F0 RID: 20976 RVA: 0x001963C4 File Offset: 0x001945C4
		// (set) Token: 0x060051F1 RID: 20977 RVA: 0x00026E79 File Offset: 0x00025079
		public unsafe DialogueController.GreetingOverride awaitingDealGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.GreetingOverride>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_awaitingDealGreeting), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x060051F2 RID: 20978 RVA: 0x001963F4 File Offset: 0x001945F4
		// (set) Token: 0x060051F3 RID: 20979 RVA: 0x00026E98 File Offset: 0x00025098
		public unsafe int minsSinceUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_minsSinceUnlocked)) = value;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x060051F4 RID: 20980 RVA: 0x0019641C File Offset: 0x0019461C
		// (set) Token: 0x060051F5 RID: 20981 RVA: 0x00026EB3 File Offset: 0x000250B3
		public unsafe bool sampleOfferedToday
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_sampleOfferedToday)) = value;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x00196444 File Offset: 0x00194644
		// (set) Token: 0x060051F7 RID: 20983 RVA: 0x00026ECE File Offset: 0x000250CE
		public unsafe NPCPoI _potentialCustomerPoI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x00196474 File Offset: 0x00194674
		// (set) Token: 0x060051F9 RID: 20985 RVA: 0x00026EED File Offset: 0x000250ED
		public unsafe CustomerAffinityData currentAffinityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAffinityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_currentAffinityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x060051FA RID: 20986 RVA: 0x001964A4 File Offset: 0x001946A4
		// (set) Token: 0x060051FB RID: 20987 RVA: 0x00026F0C File Offset: 0x0002510C
		public unsafe bool pendingInstantDeal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_pendingInstantDeal)) = value;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x001964CC File Offset: 0x001946CC
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x00026F27 File Offset: 0x00025127
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x001964FC File Offset: 0x001946FC
		// (set) Token: 0x060051FF RID: 20991 RVA: 0x00026F46 File Offset: 0x00025146
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x06005200 RID: 20992 RVA: 0x0019652C File Offset: 0x0019472C
		// (set) Token: 0x06005201 RID: 20993 RVA: 0x00026F65 File Offset: 0x00025165
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x00196554 File Offset: 0x00194754
		// (set) Token: 0x06005203 RID: 20995 RVA: 0x00026F80 File Offset: 0x00025180
		public unsafe ProductItemInstance consumedSample
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_consumedSample), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x06005204 RID: 20996 RVA: 0x00196584 File Offset: 0x00194784
		// (set) Token: 0x06005205 RID: 20997 RVA: 0x00026F9F File Offset: 0x0002519F
		public unsafe CustomerAttendDealBehaviour _attendDealBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__attendDealBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerAttendDealBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__attendDealBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x06005206 RID: 20998 RVA: 0x001965B4 File Offset: 0x001947B4
		// (set) Token: 0x06005207 RID: 20999 RVA: 0x00026FBE File Offset: 0x000251BE
		public unsafe List<EDay> _cachedOrderDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__cachedOrderDays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EDay>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr__cachedOrderDays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x001965E4 File Offset: 0x001947E4
		// (set) Token: 0x06005209 RID: 21001 RVA: 0x00026FDD File Offset: 0x000251DD
		public unsafe SyncVar<float> syncVar____CurrentAddiction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00196614 File Offset: 0x00194814
		// (set) Token: 0x0600520B RID: 21003 RVA: 0x00026FFC File Offset: 0x000251FC
		public unsafe SyncVar<bool> syncVar____HasBeenRecommended_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600520C RID: 21004 RVA: 0x00196644 File Offset: 0x00194844
		// (set) Token: 0x0600520D RID: 21005 RVA: 0x0002701B File Offset: 0x0002521B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x0019666C File Offset: 0x0019486C
		// (set) Token: 0x0600520F RID: 21007 RVA: 0x00027036 File Offset: 0x00025236
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400373A RID: 14138
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerUnlocked;

		// Token: 0x0400373B RID: 14139
		private static readonly IntPtr NativeFieldInfoPtr_LockedCustomers;

		// Token: 0x0400373C RID: 14140
		private static readonly IntPtr NativeFieldInfoPtr_UnlockedCustomers;

		// Token: 0x0400373D RID: 14141
		private static readonly IntPtr NativeFieldInfoPtr_QualityTierTolerance;

		// Token: 0x0400373E RID: 14142
		private static readonly IntPtr NativeFieldInfoPtr_MaxOrderQuantityPerProduct;

		// Token: 0x0400373F RID: 14143
		private static readonly IntPtr NativeFieldInfoPtr_AFFINITY_MAX_EFFECT;

		// Token: 0x04003740 RID: 14144
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_MAX_EFFECT;

		// Token: 0x04003741 RID: 14145
		private static readonly IntPtr NativeFieldInfoPtr_QUALITY_MAX_EFFECT;

		// Token: 0x04003742 RID: 14146
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_REJECTED_RELATIONSHIP_CHANGE;

		// Token: 0x04003743 RID: 14147
		private static readonly IntPtr NativeFieldInfoPtr_ATTACK_DEAL_COOLDOWN;

		// Token: 0x04003744 RID: 14148
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_THRESHOLD_TO_GIVE_DEAL_TO_CARTEL;

		// Token: 0x04003745 RID: 14149
		private static readonly IntPtr NativeFieldInfoPtr_CUSTOMER_UNLOCKED_CARTEL_INFLUENCE_CHANGE;

		// Token: 0x04003746 RID: 14150
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04003747 RID: 14151
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_ADDICTION;

		// Token: 0x04003748 RID: 14152
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_CHANCE_PER_DAY_MAX;

		// Token: 0x04003749 RID: 14153
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MIN_COOLDOWN;

		// Token: 0x0400374A RID: 14154
		private static readonly IntPtr NativeFieldInfoPtr_APPROACH_MAX_COOLDOWN;

		// Token: 0x0400374B RID: 14155
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_COOLDOWN;

		// Token: 0x0400374C RID: 14156
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAcceptMessages;

		// Token: 0x0400374D RID: 14157
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRejectMessages;

		// Token: 0x0400374E RID: 14158
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_ATTENDANCE_TOLERANCE;

		// Token: 0x0400374F RID: 14159
		private static readonly IntPtr NativeFieldInfoPtr_MIN_TRAVEL_TIME;

		// Token: 0x04003750 RID: 14160
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TRAVEL_TIME;

		// Token: 0x04003751 RID: 14161
		private static readonly IntPtr NativeFieldInfoPtr_OFFER_EXPIRY_TIME_MINS;

		// Token: 0x04003752 RID: 14162
		private static readonly IntPtr NativeFieldInfoPtr_MIN_ORDER_APPEAL;

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeFieldInfoPtr_ADDICTION_DRAIN_PER_DAY;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_REQUIRES_RECOMMENDATION;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeFieldInfoPtr_MIN_NORMALIZED_RELATIONSHIP_FOR_RECOMMENDATION;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_DEALER_RECOMMENDATION;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeFieldInfoPtr_RELATIONSHIP_FOR_GUARANTEED_SUPPLIER_RECOMMENDATION;

		// Token: 0x04003758 RID: 14168
		private static readonly IntPtr NativeFieldInfoPtr__CurrentAddiction_k__BackingField;

		// Token: 0x04003759 RID: 14169
		private static readonly IntPtr NativeFieldInfoPtr_offeredContractInfo;

		// Token: 0x0400375A RID: 14170
		private static readonly IntPtr NativeFieldInfoPtr__OfferedContractTime_k__BackingField;

		// Token: 0x0400375B RID: 14171
		private static readonly IntPtr NativeFieldInfoPtr__CurrentContract_k__BackingField;

		// Token: 0x0400375C RID: 14172
		private static readonly IntPtr NativeFieldInfoPtr__IsAwaitingDelivery_k__BackingField;

		// Token: 0x0400375D RID: 14173
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealCompleted_k__BackingField;

		// Token: 0x0400375E RID: 14174
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDealOffered_k__BackingField;

		// Token: 0x0400375F RID: 14175
		private static readonly IntPtr NativeFieldInfoPtr__TimeSincePlayerApproached_k__BackingField;

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceInstantDealOffered_k__BackingField;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeFieldInfoPtr__OfferedDeals_k__BackingField;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeFieldInfoPtr__CompletedDeliveries_k__BackingField;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeFieldInfoPtr__WeeklyPurchaseRecord_k__BackingField;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr__HasBeenRecommended_k__BackingField;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr__AssignedDealer_k__BackingField;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_customerData;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeFieldInfoPtr_onDealCompleted;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeFieldInfoPtr_onContractAssigned;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeFieldInfoPtr_awaitingSample;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeFieldInfoPtr_sampleChoice;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeFieldInfoPtr_completeContractChoice;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeFieldInfoPtr_offerDealChoice;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeFieldInfoPtr_awaitingDealGreeting;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeFieldInfoPtr_minsSinceUnlocked;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeFieldInfoPtr_sampleOfferedToday;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeFieldInfoPtr__potentialCustomerPoI_k__BackingField;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_currentAffinityData;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_pendingInstantDeal;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeFieldInfoPtr_consumedSample;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeFieldInfoPtr__attendDealBehaviour;

		// Token: 0x0400377A RID: 14202
		private static readonly IntPtr NativeFieldInfoPtr__cachedOrderDays;

		// Token: 0x0400377B RID: 14203
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentAddiction_k__BackingField;

		// Token: 0x0400377C RID: 14204
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____HasBeenRecommended_k__BackingField;

		// Token: 0x0400377D RID: 14205
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400377E RID: 14206
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400377F RID: 14207
		private static readonly IntPtr NativeMethodInfoPtr_MinsSinceLastDealOfferedAllCustomers_Public_Static_Int32_0;

		// Token: 0x04003780 RID: 14208
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAddiction_Public_get_Single_0;

		// Token: 0x04003781 RID: 14209
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentAddiction_Protected_set_Void_Single_0;

		// Token: 0x04003782 RID: 14210
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractInfo_Public_get_ContractInfo_0;

		// Token: 0x04003783 RID: 14211
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractInfo_Protected_set_Void_ContractInfo_0;

		// Token: 0x04003784 RID: 14212
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedContractTime_Public_get_GameDateTime_0;

		// Token: 0x04003785 RID: 14213
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedContractTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x04003786 RID: 14214
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContract_Public_get_Contract_0;

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentContract_Protected_set_Void_Contract_0;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAwaitingDelivery_Public_get_Boolean_0;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAwaitingDelivery_Protected_set_Void_Boolean_0;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealCompleted_Public_get_Int32_0;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealCompleted_Protected_set_Void_Int32_0;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDealOffered_Public_get_Int32_0;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSincePlayerApproached_Public_get_Int32_0;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSincePlayerApproached_Protected_set_Void_Int32_0;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceInstantDealOffered_Public_get_Int32_0;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceInstantDealOffered_Protected_set_Void_Int32_0;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeMethodInfoPtr_get_OfferedDeals_Public_get_Int32_0;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeMethodInfoPtr_set_OfferedDeals_Protected_set_Void_Int32_0;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedDeliveries_Public_get_Int32_0;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeMethodInfoPtr_set_CompletedDeliveries_Protected_set_Void_Int32_0;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeMethodInfoPtr_get_WeeklyPurchaseRecord_Public_get_List_1_ProductPurchaseRecord_0;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeMethodInfoPtr_set_WeeklyPurchaseRecord_Protected_set_Void_List_1_ProductPurchaseRecord_0;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_get_HasBeenRecommended_Public_get_Boolean_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr_set_HasBeenRecommended_Protected_set_Void_Boolean_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x0400379C RID: 14236
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedDealer_Public_get_Dealer_0;

		// Token: 0x0400379D RID: 14237
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedDealer_Protected_set_Void_Dealer_0;

		// Token: 0x0400379E RID: 14238
		private static readonly IntPtr NativeMethodInfoPtr_get_CustomerData_Public_get_CustomerData_0;

		// Token: 0x0400379F RID: 14239
		private static readonly IntPtr NativeMethodInfoPtr_get_dialogueDatabase_Private_get_DialogueDatabase_0;

		// Token: 0x040037A0 RID: 14240
		private static readonly IntPtr NativeMethodInfoPtr_get_potentialCustomerPoI_Public_get_NPCPoI_0;

		// Token: 0x040037A1 RID: 14241
		private static readonly IntPtr NativeMethodInfoPtr_set_potentialCustomerPoI_Private_set_Void_NPCPoI_0;

		// Token: 0x040037A2 RID: 14242
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040037A3 RID: 14243
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040037A4 RID: 14244
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040037A5 RID: 14245
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040037A6 RID: 14246
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040037A7 RID: 14247
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040037A8 RID: 14248
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040037A9 RID: 14249
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040037AA RID: 14250
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040037AB RID: 14251
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040037AC RID: 14252
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040037AD RID: 14253
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x040037AE RID: 14254
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040037AF RID: 14255
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040037B0 RID: 14256
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x040037B1 RID: 14257
		private static readonly IntPtr NativeMethodInfoPtr_SetUpDialogue_Private_Void_1;

		// Token: 0x040037B2 RID: 14258
		private static readonly IntPtr NativeMethodInfoPtr_SetupPoI_Private_Void_1;

		// Token: 0x040037B3 RID: 14259
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040037B4 RID: 14260
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_1;

		// Token: 0x040037B5 RID: 14261
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1;

		// Token: 0x040037B6 RID: 14262
		private static readonly IntPtr NativeMethodInfoPtr_OfferContractToDealer_Private_Void_ContractInfo_Dealer_0;

		// Token: 0x040037B7 RID: 14263
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepStart_Protected_Virtual_New_Void_1;

		// Token: 0x040037B8 RID: 14264
		private static readonly IntPtr NativeMethodInfoPtr_GetContractTimings_Public_Static_Void_QuestWindowConfig_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040037B9 RID: 14265
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDealAttendance_Private_Void_1;

		// Token: 0x040037BA RID: 14266
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOfferExpiry_Private_Void_1;

		// Token: 0x040037BB RID: 14267
		private static readonly IntPtr NativeMethodInfoPtr_ForceDealOffer_Public_Void_0;

		// Token: 0x040037BC RID: 14268
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProducts_Private_List_1_ProductDefinition_Dealer_0;

		// Token: 0x040037BD RID: 14269
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderableProductsWithQuantities_Private_List_1_Tuple_2_ProductDefinition_Int32_Dealer_0;

		// Token: 0x040037BE RID: 14270
		private static readonly IntPtr NativeMethodInfoPtr_TryGenerateContract_Private_ContractInfo_Dealer_0;

		// Token: 0x040037BF RID: 14271
		private static readonly IntPtr NativeMethodInfoPtr_GetDeliveryLocation_Private_DeliveryLocation_0;

		// Token: 0x040037C0 RID: 14272
		private static readonly IntPtr NativeMethodInfoPtr_GetWeightedRandomProduct_Private_ProductDefinition_Dealer_byref_Single_byref_Int32_0;

		// Token: 0x040037C1 RID: 14273
		private static readonly IntPtr NativeMethodInfoPtr_OnCustomerUnlocked_Protected_Virtual_New_Void_EUnlockType_Boolean_0;

		// Token: 0x040037C2 RID: 14274
		private static readonly IntPtr NativeMethodInfoPtr_SetHasBeenRecommended_Public_Void_0;

		// Token: 0x040037C3 RID: 14275
		private static readonly IntPtr NativeMethodInfoPtr_OfferContract_Public_Virtual_New_Void_ContractInfo_0;

		// Token: 0x040037C4 RID: 14276
		private static readonly IntPtr NativeMethodInfoPtr_SetOfferedContract_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x040037C5 RID: 14277
		private static readonly IntPtr NativeMethodInfoPtr_ExpireOffer_Public_Virtual_New_Void_0;

		// Token: 0x040037C6 RID: 14278
		private static readonly IntPtr NativeMethodInfoPtr_AssignContract_Public_Virtual_New_Void_Contract_0;

		// Token: 0x040037C7 RID: 14279
		private static readonly IntPtr NativeMethodInfoPtr_NotifyPlayerOfContract_Protected_Virtual_New_Void_ContractInfo_MessageChain_Boolean_Boolean_Boolean_0;

		// Token: 0x040037C8 RID: 14280
		private static readonly IntPtr NativeMethodInfoPtr_SetUpResponseCallbacks_Private_Void_1;

		// Token: 0x040037C9 RID: 14281
		private static readonly IntPtr NativeMethodInfoPtr_AcceptContractClicked_Protected_Virtual_New_Void_1;

		// Token: 0x040037CA RID: 14282
		private static readonly IntPtr NativeMethodInfoPtr_CounterOfferClicked_Protected_Virtual_New_Void_1;

		// Token: 0x040037CB RID: 14283
		private static readonly IntPtr NativeMethodInfoPtr_SendCounteroffer_Protected_Virtual_New_Void_ProductDefinition_Int32_Single_0;

		// Token: 0x040037CC RID: 14284
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCounterOfferServerSide_Private_Void_String_Int32_Single_0;

		// Token: 0x040037CD RID: 14285
		private static readonly IntPtr NativeMethodInfoPtr_SetContractIsCounterOffer_Private_Void_1;

		// Token: 0x040037CE RID: 14286
		private static readonly IntPtr NativeMethodInfoPtr_PlayerAcceptedContract_Protected_Virtual_New_Void_EDealWindow_0;

		// Token: 0x040037CF RID: 14287
		private static readonly IntPtr NativeMethodInfoPtr_SendContractAccepted_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x040037D0 RID: 14288
		private static readonly IntPtr NativeMethodInfoPtr_ContractAccepted_Public_Contract_EDealWindow_Boolean_Dealer_0;

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractAccepted_Private_Void_1;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractAcceptedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounteroffer_Protected_Virtual_New_Boolean_ProductDefinition_Int32_Single_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_GetValueProposition_Public_Static_Single_ProductDefinition_Single_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_ContractRejected_Protected_Virtual_New_Void_1;

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveContractRejected_Private_Void_1;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_PlayContractRejectedReaction_Protected_Virtual_New_Void_1;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAwaitingDelivery_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040037D9 RID: 14297
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDealLocation_Public_Boolean_0;

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialCustomerPoI_Private_Void_1;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_SetPotentialCustomerPoIEnabled_Public_Void_Boolean_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryGenerateDeal_Protected_Virtual_New_Boolean_0;

		// Token: 0x040037DD RID: 14301
		private static readonly IntPtr NativeMethodInfoPtr_IsDealTime_Private_Boolean_0;

		// Token: 0x040037DE RID: 14302
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealItems_Public_Virtual_New_Void_List_1_ItemInstance_Boolean_byref_Boolean_0;

		// Token: 0x040037DF RID: 14303
		private static readonly IntPtr NativeMethodInfoPtr_CustomerRejectedDeal_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandover_Public_Virtual_New_Void_EHandoverOutcome_Contract_List_1_ItemInstance_Boolean_Boolean_0;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverServerSide_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeMethodInfoPtr_ProcessHandoverClient_Private_Void_Single_Boolean_String_EHandoverOutcome_0;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeMethodInfoPtr_ContractWellReceived_Public_Void_String_0;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeMethodInfoPtr_RecommendDealer_Private_Void_Dealer_0;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr_RecommendSupplier_Private_Void_Supplier_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr_RecommendCustomer_Private_Void_Customer_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr_CurrentContractEnded_Public_Virtual_New_Void_EQuestState_0;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateDelivery_Public_Virtual_New_Single_Contract_List_1_ItemInstance_byref_Single_byref_EDrugType_byref_Int32_byref_Single_0;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeMethodInfoPtr_CalculateTopWeeklyPurchases_Public_Void_byref_List_1_StringIntPair_byref_Single_0;

		// Token: 0x040037EA RID: 14314
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAddiction_Public_Void_Single_0;

		// Token: 0x040037EB RID: 14315
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Private_Void_ItemInstance_0;

		// Token: 0x040037EC RID: 14316
		private static readonly IntPtr NativeMethodInfoPtr_ShowOfferDealOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040037ED RID: 14317
		private static readonly IntPtr NativeMethodInfoPtr_OfferDealValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040037EE RID: 14318
		private static readonly IntPtr NativeMethodInfoPtr_InstantDealOffered_Protected_Virtual_New_Void_1;

		// Token: 0x040037EF RID: 14319
		private static readonly IntPtr NativeMethodInfoPtr_GetOfferSuccessChance_Public_Single_List_1_ItemInstance_Single_0;

		// Token: 0x040037F0 RID: 14320
		private static readonly IntPtr NativeMethodInfoPtr_ShouldTryApproachPlayer_Protected_Virtual_New_Boolean_0;

		// Token: 0x040037F1 RID: 14321
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_0;

		// Token: 0x040037F2 RID: 14322
		private static readonly IntPtr NativeMethodInfoPtr_RequestProduct_Public_Void_Player_0;

		// Token: 0x040037F3 RID: 14323
		private static readonly IntPtr NativeMethodInfoPtr_PlayerRejectedProductRequest_Public_Void_0;

		// Token: 0x040037F4 RID: 14324
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Public_Void_0;

		// Token: 0x040037F5 RID: 14325
		private static readonly IntPtr NativeMethodInfoPtr_RejectProductRequestOffer_Local_Private_Void_1;

		// Token: 0x040037F6 RID: 14326
		private static readonly IntPtr NativeMethodInfoPtr_AssignDealer_Public_Void_Dealer_0;

		// Token: 0x040037F7 RID: 14327
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040037F8 RID: 14328
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomerData_Public_CustomerData_0;

		// Token: 0x040037F9 RID: 14329
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x040037FA RID: 14330
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveCustomerData_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x040037FB RID: 14331
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_CustomerData_0;

		// Token: 0x040037FC RID: 14332
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHandover_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040037FD RID: 14333
		private static readonly IntPtr NativeMethodInfoPtr_IsHandoverChoiceValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040037FE RID: 14334
		private static readonly IntPtr NativeMethodInfoPtr_HandoverChosen_Public_Void_0;

		// Token: 0x040037FF RID: 14335
		private static readonly IntPtr NativeMethodInfoPtr_ShowDirectApproachOption_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04003800 RID: 14336
		private static readonly IntPtr NativeMethodInfoPtr_IsUnlockable_Public_Virtual_New_Boolean_0;

		// Token: 0x04003801 RID: 14337
		private static readonly IntPtr NativeMethodInfoPtr_SampleOptionValid_Protected_Virtual_New_Boolean_byref_String_0;

		// Token: 0x04003802 RID: 14338
		private static readonly IntPtr NativeMethodInfoPtr_KnownAndRecommended_Public_Boolean_0;

		// Token: 0x04003803 RID: 14339
		private static readonly IntPtr NativeMethodInfoPtr_SampleOffered_Public_Void_0;

		// Token: 0x04003804 RID: 14340
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleRequestSuccessChance_Protected_Virtual_New_Single_0;

		// Token: 0x04003805 RID: 14341
		private static readonly IntPtr NativeMethodInfoPtr_SampleAccepted_Protected_Virtual_New_Void_1;

		// Token: 0x04003806 RID: 14342
		private static readonly IntPtr NativeMethodInfoPtr_GetSampleSuccess_Private_Single_List_1_ItemInstance_Single_0;

		// Token: 0x04003807 RID: 14343
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSample_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04003808 RID: 14344
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleServerSide_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003809 RID: 14345
		private static readonly IntPtr NativeMethodInfoPtr_ProcessSampleClient_Private_Void_1;

		// Token: 0x0400380A RID: 14346
		private static readonly IntPtr NativeMethodInfoPtr_SampleConsumed_Private_Void_1;

		// Token: 0x0400380B RID: 14347
		private static readonly IntPtr NativeMethodInfoPtr_EndWait_Private_Void_1;

		// Token: 0x0400380C RID: 14348
		private static readonly IntPtr NativeMethodInfoPtr_DirectApproachRejected_Protected_Virtual_New_Void_1;

		// Token: 0x0400380D RID: 14349
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasSufficient_Private_Void_1;

		// Token: 0x0400380E RID: 14350
		private static readonly IntPtr NativeMethodInfoPtr_SampleWasInsufficient_Private_Void_1;

		// Token: 0x0400380F RID: 14351
		private static readonly IntPtr NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_EQuality_0;

		// Token: 0x04003810 RID: 14352
		private static readonly IntPtr NativeMethodInfoPtr_GetProductEnjoyment_Public_Single_ProductDefinition_0;

		// Token: 0x04003811 RID: 14353
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedDrugTypes_Public_List_1_EDrugType_0;

		// Token: 0x04003812 RID: 14354
		private static readonly IntPtr NativeMethodInfoPtr_AdjustAffinity_Public_Void_EDrugType_Single_0;

		// Token: 0x04003813 RID: 14355
		private static readonly IntPtr NativeMethodInfoPtr_AutocreateCustomerSettings_Public_Void_0;

		// Token: 0x04003814 RID: 14356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003815 RID: 14357
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__139_0_Private_Void_1;

		// Token: 0x04003816 RID: 14358
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__140_1_Private_Void_EUnlockType_Boolean_0;

		// Token: 0x04003817 RID: 14359
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04003818 RID: 14360
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_PDM_0;

		// Token: 0x04003819 RID: 14361
		private static readonly IntPtr NativeMethodInfoPtr__HandoverChosen_b__221_0_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x0400381A RID: 14362
		private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__240_0_Private_Single_EDrugType_0;

		// Token: 0x0400381B RID: 14363
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400381C RID: 14364
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400381D RID: 14365
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400381E RID: 14366
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x0400381F RID: 14367
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetOfferedContract_4277245194_Private_Void_ContractInfo_GameDateTime_0;

		// Token: 0x04003820 RID: 14368
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetOfferedContract_4277245194_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003821 RID: 14369
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ExpireOffer_2166136261_Private_Void_1;

		// Token: 0x04003822 RID: 14370
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ExpireOffer_2166136261_Public_Virtual_New_Void_0;

		// Token: 0x04003823 RID: 14371
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ExpireOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003824 RID: 14372
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003825 RID: 14373
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUpResponseCallbacks_2166136261_Private_Void_1;

		// Token: 0x04003826 RID: 14374
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUpResponseCallbacks_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003827 RID: 14375
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessCounterOfferServerSide_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessCounterOfferServerSide_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetContractIsCounterOffer_2166136261_Private_Void_1;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetContractIsCounterOffer_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendContractAccepted_507093020_Private_Void_EDealWindow_Boolean_0;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendContractAccepted_507093020_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractAccepted_2166136261_Private_Void_1;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractAccepted_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveContractRejected_2166136261_Private_Void_1;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveContractRejected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003836 RID: 14390
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003837 RID: 14391
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverServerSide_3760244802_Private_Void_EHandoverOutcome_List_1_ItemInstance_Boolean_Single_ProductList_Single_NetworkObject_0;

		// Token: 0x04003838 RID: 14392
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessHandoverServerSide_3760244802_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003839 RID: 14393
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0;

		// Token: 0x0400383A RID: 14394
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessHandoverClient_2441224929_Private_Void_Single_Boolean_String_EHandoverOutcome_0;

		// Token: 0x0400383B RID: 14395
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessHandoverClient_2441224929_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400383C RID: 14396
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ChangeAddiction_431000436_Private_Void_Single_0;

		// Token: 0x0400383D RID: 14397
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ChangeAddiction_431000436_Public_Void_Single_0;

		// Token: 0x0400383E RID: 14398
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ChangeAddiction_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400383F RID: 14399
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RejectProductRequestOffer_2166136261_Private_Void_1;

		// Token: 0x04003840 RID: 14400
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_2166136261_Public_Void_0;

		// Token: 0x04003841 RID: 14401
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RejectProductRequestOffer_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003842 RID: 14402
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003843 RID: 14403
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RejectProductRequestOffer_Local_2166136261_Private_Void_1;

		// Token: 0x04003844 RID: 14404
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RejectProductRequestOffer_Local_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003845 RID: 14405
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003846 RID: 14406
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveCustomerData_2280244125_Private_Void_NetworkConnection_CustomerData_0;

		// Token: 0x04003847 RID: 14407
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveCustomerData_2280244125_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003848 RID: 14408
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04003849 RID: 14409
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleServerSide_3704012609_Private_Void_List_1_ItemInstance_0;

		// Token: 0x0400384A RID: 14410
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ProcessSampleServerSide_3704012609_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400384B RID: 14411
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x0400384C RID: 14412
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ProcessSampleClient_2166136261_Private_Void_1;

		// Token: 0x0400384D RID: 14413
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ProcessSampleClient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400384E RID: 14414
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x0400384F RID: 14415
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasSufficient_2166136261_Private_Void_1;

		// Token: 0x04003850 RID: 14416
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasSufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003851 RID: 14417
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003852 RID: 14418
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SampleWasInsufficient_2166136261_Private_Void_1;

		// Token: 0x04003853 RID: 14419
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SampleWasInsufficient_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003854 RID: 14420
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AdjustAffinity_3036964899_Private_Void_EDrugType_Single_0;

		// Token: 0x04003855 RID: 14421
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AdjustAffinity_3036964899_Public_Void_EDrugType_Single_0;

		// Token: 0x04003856 RID: 14422
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AdjustAffinity_3036964899_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003857 RID: 14423
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentAddiction_k__BackingField_Public_get_Single_0;

		// Token: 0x04003858 RID: 14424
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentAddiction_k__BackingField_Public_set_Void_Single_Boolean_0;

		// Token: 0x04003859 RID: 14425
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Economy_Customer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400385A RID: 14426
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__HasBeenRecommended_k__BackingField_Public_get_Boolean_0;

		// Token: 0x0400385B RID: 14427
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__HasBeenRecommended_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x0400385C RID: 14428
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000A94 RID: 2708
		[Serializable]
		public class ScheduleGroupPair : Il2CppSystem.Object
		{
			// Token: 0x0600E24A RID: 57930 RVA: 0x00378154 File Offset: 0x00376354
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduleGroupPair()
			{
				Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ScheduleGroupPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr);
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "NormalScheduleGroup");
				Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, "CurfewScheduleGroup");
				Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr, 100673971);
			}

			// Token: 0x0600E24B RID: 57931 RVA: 0x003781BC File Offset: 0x003763BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduleGroupPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.ScheduleGroupPair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.ScheduleGroupPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E24C RID: 57932 RVA: 0x0006AAD6 File Offset: 0x00068CD6
			public ScheduleGroupPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044DF RID: 17631
			// (get) Token: 0x0600E24D RID: 57933 RVA: 0x003781F8 File Offset: 0x003763F8
			// (set) Token: 0x0600E24E RID: 57934 RVA: 0x0006AADF File Offset: 0x00068CDF
			public unsafe GameObject NormalScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_NormalScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0600E24F RID: 57935 RVA: 0x00378228 File Offset: 0x00376428
			// (set) Token: 0x0600E250 RID: 57936 RVA: 0x0006AAFE File Offset: 0x00068CFE
			public unsafe GameObject CurfewScheduleGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ScheduleGroupPair.NativeFieldInfoPtr_CurfewScheduleGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099F2 RID: 39410
			private static readonly IntPtr NativeFieldInfoPtr_NormalScheduleGroup;

			// Token: 0x040099F3 RID: 39411
			private static readonly IntPtr NativeFieldInfoPtr_CurfewScheduleGroup;

			// Token: 0x040099F4 RID: 39412
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A95 RID: 2709
		[Serializable]
		public class CustomerPreference : Il2CppSystem.Object
		{
			// Token: 0x0600E251 RID: 57937 RVA: 0x00378258 File Offset: 0x00376458
			// Note: this type is marked as 'beforefieldinit'.
			static CustomerPreference()
			{
				Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "CustomerPreference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr);
				Customer.CustomerPreference.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "DrugType");
				Customer.CustomerPreference.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "Definition");
				Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, "MinimumQuality");
				Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr, 100673972);
			}

			// Token: 0x0600E252 RID: 57938 RVA: 0x003782D4 File Offset: 0x003764D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomerPreference() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.CustomerPreference>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.CustomerPreference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E253 RID: 57939 RVA: 0x0006AB1D File Offset: 0x00068D1D
			public CustomerPreference(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E1 RID: 17633
			// (get) Token: 0x0600E254 RID: 57940 RVA: 0x00378310 File Offset: 0x00376510
			// (set) Token: 0x0600E255 RID: 57941 RVA: 0x0006AB26 File Offset: 0x00068D26
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170044E2 RID: 17634
			// (get) Token: 0x0600E256 RID: 57942 RVA: 0x00378338 File Offset: 0x00376538
			// (set) Token: 0x0600E257 RID: 57943 RVA: 0x0006AB41 File Offset: 0x00068D41
			public unsafe ProductDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E3 RID: 17635
			// (get) Token: 0x0600E258 RID: 57944 RVA: 0x00378368 File Offset: 0x00376568
			// (set) Token: 0x0600E259 RID: 57945 RVA: 0x0006AB60 File Offset: 0x00068D60
			public unsafe EQuality MinimumQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.CustomerPreference.NativeFieldInfoPtr_MinimumQuality)) = value;
				}
			}

			// Token: 0x040099F5 RID: 39413
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x040099F6 RID: 39414
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040099F7 RID: 39415
			private static readonly IntPtr NativeFieldInfoPtr_MinimumQuality;

			// Token: 0x040099F8 RID: 39416
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A96 RID: 2710
		[Serializable]
		public class ProductPurchaseRecord : Il2CppSystem.Object
		{
			// Token: 0x0600E25A RID: 57946 RVA: 0x00378390 File Offset: 0x00376590
			// Note: this type is marked as 'beforefieldinit'.
			static ProductPurchaseRecord()
			{
				Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "ProductPurchaseRecord");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr);
				Customer.ProductPurchaseRecord.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr, "ProductID");
				Customer.ProductPurchaseRecord.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr, "Quantity");
				Customer.ProductPurchaseRecord.NativeFieldInfoPtr_TotalSpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr, "TotalSpent");
				Customer.ProductPurchaseRecord.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr, 100673973);
			}

			// Token: 0x0600E25B RID: 57947 RVA: 0x0037840C File Offset: 0x0037660C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductPurchaseRecord() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.ProductPurchaseRecord>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.ProductPurchaseRecord.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E25C RID: 57948 RVA: 0x0006AB7B File Offset: 0x00068D7B
			public ProductPurchaseRecord(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E4 RID: 17636
			// (get) Token: 0x0600E25D RID: 57949 RVA: 0x00378448 File Offset: 0x00376648
			// (set) Token: 0x0600E25E RID: 57950 RVA: 0x0006AB84 File Offset: 0x00068D84
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044E5 RID: 17637
			// (get) Token: 0x0600E25F RID: 57951 RVA: 0x00378470 File Offset: 0x00376670
			// (set) Token: 0x0600E260 RID: 57952 RVA: 0x0006ABA3 File Offset: 0x00068DA3
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x170044E6 RID: 17638
			// (get) Token: 0x0600E261 RID: 57953 RVA: 0x00378498 File Offset: 0x00376698
			// (set) Token: 0x0600E262 RID: 57954 RVA: 0x0006ABBE File Offset: 0x00068DBE
			public unsafe float TotalSpent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_TotalSpent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.ProductPurchaseRecord.NativeFieldInfoPtr_TotalSpent)) = value;
				}
			}

			// Token: 0x040099F9 RID: 39417
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x040099FA RID: 39418
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x040099FB RID: 39419
			private static readonly IntPtr NativeFieldInfoPtr_TotalSpent;

			// Token: 0x040099FC RID: 39420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A97 RID: 2711
		[OriginalName("Assembly-CSharp.dll", "", "ESampleFeedback")]
		public enum ESampleFeedback
		{
			// Token: 0x040099FE RID: 39422
			WrongProduct,
			// Token: 0x040099FF RID: 39423
			WrongQuality,
			// Token: 0x04009A00 RID: 39424
			Correct
		}

		// Token: 0x02000A98 RID: 2712
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E263 RID: 57955 RVA: 0x003784C0 File Offset: 0x003766C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Customer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr);
				Customer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9");
				Customer.__c.NativeFieldInfoPtr___9__155_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__155_0");
				Customer.__c.NativeFieldInfoPtr___9__199_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__199_1");
				Customer.__c.NativeFieldInfoPtr___9__200_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, "<>9__200_1");
				Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100673975);
				Customer.__c.NativeMethodInfoPtr__GetOrderableProducts_b__155_0_Internal_ProductDefinition_Tuple_2_ProductDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100673976);
				Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__199_1_Internal_EQuality_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100673977);
				Customer.__c.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__200_1_Internal_Int32_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr, 100673978);
			}

			// Token: 0x0600E264 RID: 57956 RVA: 0x0037858C File Offset: 0x0037678C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E265 RID: 57957 RVA: 0x003785C8 File Offset: 0x003767C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179232, XrefRangeEnd = 179233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductDefinition _GetOrderableProducts_b__155_0(Tuple<ProductDefinition, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__GetOrderableProducts_b__155_0_Internal_ProductDefinition_Tuple_2_ProductDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}

			// Token: 0x0600E266 RID: 57958 RVA: 0x00378618 File Offset: 0x00376818
			[CallerCount(0)]
			public unsafe EQuality _EvaluateDelivery_b__199_1(ProductItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__EvaluateDelivery_b__199_1_Internal_EQuality_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E267 RID: 57959 RVA: 0x00378668 File Offset: 0x00376868
			[CallerCount(0)]
			public unsafe int _CalculateTopWeeklyPurchases_b__200_1(StringIntPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__200_1_Internal_Int32_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E268 RID: 57960 RVA: 0x0006ABD9 File Offset: 0x00068DD9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0600E269 RID: 57961 RVA: 0x003786B8 File Offset: 0x003768B8
			// (set) Token: 0x0600E26A RID: 57962 RVA: 0x0006ABE2 File Offset: 0x00068DE2
			public unsafe static Customer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0600E26B RID: 57963 RVA: 0x003786E0 File Offset: 0x003768E0
			// (set) Token: 0x0600E26C RID: 57964 RVA: 0x0006ABF4 File Offset: 0x00068DF4
			public unsafe static Func<Tuple<ProductDefinition, int>, ProductDefinition> __9__155_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__155_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<ProductDefinition, int>, ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__155_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E9 RID: 17641
			// (get) Token: 0x0600E26D RID: 57965 RVA: 0x00378708 File Offset: 0x00376908
			// (set) Token: 0x0600E26E RID: 57966 RVA: 0x0006AC06 File Offset: 0x00068E06
			public unsafe static Func<ProductItemInstance, EQuality> __9__199_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__199_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductItemInstance, EQuality>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__199_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EA RID: 17642
			// (get) Token: 0x0600E26F RID: 57967 RVA: 0x00378730 File Offset: 0x00376930
			// (set) Token: 0x0600E270 RID: 57968 RVA: 0x0006AC18 File Offset: 0x00068E18
			public unsafe static Func<StringIntPair, int> __9__200_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Customer.__c.NativeFieldInfoPtr___9__200_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StringIntPair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Customer.__c.NativeFieldInfoPtr___9__200_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A01 RID: 39425
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009A02 RID: 39426
			private static readonly IntPtr NativeFieldInfoPtr___9__155_0;

			// Token: 0x04009A03 RID: 39427
			private static readonly IntPtr NativeFieldInfoPtr___9__199_1;

			// Token: 0x04009A04 RID: 39428
			private static readonly IntPtr NativeFieldInfoPtr___9__200_1;

			// Token: 0x04009A05 RID: 39429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A06 RID: 39430
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderableProducts_b__155_0_Internal_ProductDefinition_Tuple_2_ProductDefinition_Int32_0;

			// Token: 0x04009A07 RID: 39431
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__199_1_Internal_EQuality_ProductItemInstance_0;

			// Token: 0x04009A08 RID: 39432
			private static readonly IntPtr NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__200_1_Internal_Int32_StringIntPair_0;
		}

		// Token: 0x02000A99 RID: 2713
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass159_0")]
		public sealed class __c__DisplayClass159_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E271 RID: 57969 RVA: 0x00378758 File Offset: 0x00376958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass159_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass159_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr);
				Customer.__c__DisplayClass159_0.NativeFieldInfoPtr_productAppeal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr, "productAppeal");
				Customer.__c__DisplayClass159_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr, 100673979);
				Customer.__c__DisplayClass159_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_Tuple_2_ProductDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr, 100673980);
			}

			// Token: 0x0600E272 RID: 57970 RVA: 0x003787C0 File Offset: 0x003769C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass159_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass159_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass159_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E273 RID: 57971 RVA: 0x003787FC File Offset: 0x003769FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179233, XrefRangeEnd = 179238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetWeightedRandomProduct_b__0(Tuple<ProductDefinition, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass159_0.NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_Tuple_2_ProductDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E274 RID: 57972 RVA: 0x0006AC2A File Offset: 0x00068E2A
			public __c__DisplayClass159_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044EB RID: 17643
			// (get) Token: 0x0600E275 RID: 57973 RVA: 0x0037884C File Offset: 0x00376A4C
			// (set) Token: 0x0600E276 RID: 57974 RVA: 0x0006AC33 File Offset: 0x00068E33
			public unsafe Dictionary<ProductDefinition, float> productAppeal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass159_0.NativeFieldInfoPtr_productAppeal);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass159_0.NativeFieldInfoPtr_productAppeal), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A09 RID: 39433
			private static readonly IntPtr NativeFieldInfoPtr_productAppeal;

			// Token: 0x04009A0A RID: 39434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A0B RID: 39435
			private static readonly IntPtr NativeMethodInfoPtr__GetWeightedRandomProduct_b__0_Internal_Single_Tuple_2_ProductDefinition_Int32_0;
		}

		// Token: 0x02000A9A RID: 2714
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass195_0")]
		public sealed class __c__DisplayClass195_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E277 RID: 57975 RVA: 0x0037887C File Offset: 0x00376A7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass195_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass195_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr);
				Customer.__c__DisplayClass195_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass195_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr, 100673981);
				Customer.__c__DisplayClass195_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr, 100673982);
			}

			// Token: 0x0600E278 RID: 57976 RVA: 0x003788F8 File Offset: 0x00376AF8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass195_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E279 RID: 57977 RVA: 0x00378934 File Offset: 0x00376B34
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179253, RefRangeEnd = 179254, XrefRangeStart = 179248, XrefRangeEnd = 179253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E27A RID: 57978 RVA: 0x0006AC52 File Offset: 0x00068E52
			public __c__DisplayClass195_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044EC RID: 17644
			// (get) Token: 0x0600E27B RID: 57979 RVA: 0x00378974 File Offset: 0x00376B74
			// (set) Token: 0x0600E27C RID: 57980 RVA: 0x0006AC5B File Offset: 0x00068E5B
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044ED RID: 17645
			// (get) Token: 0x0600E27D RID: 57981 RVA: 0x003789A4 File Offset: 0x00376BA4
			// (set) Token: 0x0600E27E RID: 57982 RVA: 0x0006AC7A File Offset: 0x00068E7A
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A0C RID: 39436
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A0D RID: 39437
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04009A0E RID: 39438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A0F RID: 39439
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DCB RID: 3531
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass195_0+<<RecommendDealer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF03 RID: 65283 RVA: 0x003CA728 File Offset: 0x003C8928
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0>.NativeClassPtr, "<<RecommendDealer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673983);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673984);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673985);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673986);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673987);
					Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673988);
				}

				// Token: 0x0600FF04 RID: 65284 RVA: 0x003CA808 File Offset: 0x003C8A08
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF05 RID: 65285 RVA: 0x003CA850 File Offset: 0x003C8A50
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF06 RID: 65286 RVA: 0x003CA884 File Offset: 0x003C8A84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179238, XrefRangeEnd = 179243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DA1 RID: 19873
				// (get) Token: 0x0600FF07 RID: 65287 RVA: 0x003CA8C0 File Offset: 0x003C8AC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF08 RID: 65288 RVA: 0x003CA900 File Offset: 0x003C8B00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179243, XrefRangeEnd = 179248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DA2 RID: 19874
				// (get) Token: 0x0600FF09 RID: 65289 RVA: 0x003CA934 File Offset: 0x003C8B34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF0A RID: 65290 RVA: 0x00078D74 File Offset: 0x00076F74
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D9E RID: 19870
				// (get) Token: 0x0600FF0B RID: 65291 RVA: 0x003CA974 File Offset: 0x003C8B74
				// (set) Token: 0x0600FF0C RID: 65292 RVA: 0x00078D7D File Offset: 0x00076F7D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D9F RID: 19871
				// (get) Token: 0x0600FF0D RID: 65293 RVA: 0x003CA99C File Offset: 0x003C8B9C
				// (set) Token: 0x0600FF0E RID: 65294 RVA: 0x00078D98 File Offset: 0x00076F98
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DA0 RID: 19872
				// (get) Token: 0x0600FF0F RID: 65295 RVA: 0x003CA9CC File Offset: 0x003C8BCC
				// (set) Token: 0x0600FF10 RID: 65296 RVA: 0x00078DB7 File Offset: 0x00076FB7
				public unsafe Customer.__c__DisplayClass195_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass195_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass195_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABD8 RID: 43992
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABD9 RID: 43993
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABDA RID: 43994
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABDB RID: 43995
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABDC RID: 43996
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABDD RID: 43997
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABDE RID: 43998
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABDF RID: 43999
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABE0 RID: 44000
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A9B RID: 2715
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass196_0")]
		public sealed class __c__DisplayClass196_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E27F RID: 57983 RVA: 0x003789D4 File Offset: 0x00376BD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass196_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass196_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr);
				Customer.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass196_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr, 100673989);
				Customer.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr, 100673990);
			}

			// Token: 0x0600E280 RID: 57984 RVA: 0x00378A50 File Offset: 0x00376C50
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass196_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E281 RID: 57985 RVA: 0x00378A8C File Offset: 0x00376C8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179269, RefRangeEnd = 179270, XrefRangeStart = 179264, XrefRangeEnd = 179269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E282 RID: 57986 RVA: 0x0006AC99 File Offset: 0x00068E99
			public __c__DisplayClass196_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044EE RID: 17646
			// (get) Token: 0x0600E283 RID: 57987 RVA: 0x00378ACC File Offset: 0x00376CCC
			// (set) Token: 0x0600E284 RID: 57988 RVA: 0x0006ACA2 File Offset: 0x00068EA2
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044EF RID: 17647
			// (get) Token: 0x0600E285 RID: 57989 RVA: 0x00378AFC File Offset: 0x00376CFC
			// (set) Token: 0x0600E286 RID: 57990 RVA: 0x0006ACC1 File Offset: 0x00068EC1
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A10 RID: 39440
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A11 RID: 39441
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04009A12 RID: 39442
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A13 RID: 39443
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DCC RID: 3532
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass196_0+<<RecommendSupplier>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF11 RID: 65297 RVA: 0x003CA9FC File Offset: 0x003C8BFC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0>.NativeClassPtr, "<<RecommendSupplier>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673991);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673992);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673993);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673994);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673995);
					Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673996);
				}

				// Token: 0x0600FF12 RID: 65298 RVA: 0x003CAADC File Offset: 0x003C8CDC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF13 RID: 65299 RVA: 0x003CAB24 File Offset: 0x003C8D24
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF14 RID: 65300 RVA: 0x003CAB58 File Offset: 0x003C8D58
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179254, XrefRangeEnd = 179259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DA6 RID: 19878
				// (get) Token: 0x0600FF15 RID: 65301 RVA: 0x003CAB94 File Offset: 0x003C8D94
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF16 RID: 65302 RVA: 0x003CABD4 File Offset: 0x003C8DD4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179259, XrefRangeEnd = 179264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DA7 RID: 19879
				// (get) Token: 0x0600FF17 RID: 65303 RVA: 0x003CAC08 File Offset: 0x003C8E08
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF18 RID: 65304 RVA: 0x00078DD6 File Offset: 0x00076FD6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DA3 RID: 19875
				// (get) Token: 0x0600FF19 RID: 65305 RVA: 0x003CAC48 File Offset: 0x003C8E48
				// (set) Token: 0x0600FF1A RID: 65306 RVA: 0x00078DDF File Offset: 0x00076FDF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DA4 RID: 19876
				// (get) Token: 0x0600FF1B RID: 65307 RVA: 0x003CAC70 File Offset: 0x003C8E70
				// (set) Token: 0x0600FF1C RID: 65308 RVA: 0x00078DFA File Offset: 0x00076FFA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DA5 RID: 19877
				// (get) Token: 0x0600FF1D RID: 65309 RVA: 0x003CACA0 File Offset: 0x003C8EA0
				// (set) Token: 0x0600FF1E RID: 65310 RVA: 0x00078E19 File Offset: 0x00077019
				public unsafe Customer.__c__DisplayClass196_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass196_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass196_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABE1 RID: 44001
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABE2 RID: 44002
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABE3 RID: 44003
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABE4 RID: 44004
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABE5 RID: 44005
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABE6 RID: 44006
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABE7 RID: 44007
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABE8 RID: 44008
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABE9 RID: 44009
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A9C RID: 2716
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass197_0")]
		public sealed class __c__DisplayClass197_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E287 RID: 57991 RVA: 0x00378B2C File Offset: 0x00376D2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass197_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass197_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr);
				Customer.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass197_0.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr, "container");
				Customer.__c__DisplayClass197_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr, 100673997);
				Customer.__c__DisplayClass197_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr, 100673998);
			}

			// Token: 0x0600E288 RID: 57992 RVA: 0x00378BA8 File Offset: 0x00376DA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass197_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E289 RID: 57993 RVA: 0x00378BE4 File Offset: 0x00376DE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 179285, RefRangeEnd = 179286, XrefRangeStart = 179280, XrefRangeEnd = 179285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E28A RID: 57994 RVA: 0x0006ACE0 File Offset: 0x00068EE0
			public __c__DisplayClass197_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F0 RID: 17648
			// (get) Token: 0x0600E28B RID: 57995 RVA: 0x00378C24 File Offset: 0x00376E24
			// (set) Token: 0x0600E28C RID: 57996 RVA: 0x0006ACE9 File Offset: 0x00068EE9
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F1 RID: 17649
			// (get) Token: 0x0600E28D RID: 57997 RVA: 0x00378C54 File Offset: 0x00376E54
			// (set) Token: 0x0600E28E RID: 57998 RVA: 0x0006AD08 File Offset: 0x00068F08
			public unsafe DialogueContainer container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.NativeFieldInfoPtr_container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A14 RID: 39444
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A15 RID: 39445
			private static readonly IntPtr NativeFieldInfoPtr_container;

			// Token: 0x04009A16 RID: 39446
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A17 RID: 39447
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DCD RID: 3533
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass197_0+<<RecommendCustomer>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF1F RID: 65311 RVA: 0x003CACD0 File Offset: 0x003C8ED0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0>.NativeClassPtr, "<<RecommendCustomer>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673999);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674000);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674001);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674002);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674003);
					Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674004);
				}

				// Token: 0x0600FF20 RID: 65312 RVA: 0x003CADB0 File Offset: 0x003C8FB0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF21 RID: 65313 RVA: 0x003CADF8 File Offset: 0x003C8FF8
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF22 RID: 65314 RVA: 0x003CAE2C File Offset: 0x003C902C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179270, XrefRangeEnd = 179275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DAB RID: 19883
				// (get) Token: 0x0600FF23 RID: 65315 RVA: 0x003CAE68 File Offset: 0x003C9068
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF24 RID: 65316 RVA: 0x003CAEA8 File Offset: 0x003C90A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179275, XrefRangeEnd = 179280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DAC RID: 19884
				// (get) Token: 0x0600FF25 RID: 65317 RVA: 0x003CAEDC File Offset: 0x003C90DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF26 RID: 65318 RVA: 0x00078E38 File Offset: 0x00077038
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DA8 RID: 19880
				// (get) Token: 0x0600FF27 RID: 65319 RVA: 0x003CAF1C File Offset: 0x003C911C
				// (set) Token: 0x0600FF28 RID: 65320 RVA: 0x00078E41 File Offset: 0x00077041
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DA9 RID: 19881
				// (get) Token: 0x0600FF29 RID: 65321 RVA: 0x003CAF44 File Offset: 0x003C9144
				// (set) Token: 0x0600FF2A RID: 65322 RVA: 0x00078E5C File Offset: 0x0007705C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DAA RID: 19882
				// (get) Token: 0x0600FF2B RID: 65323 RVA: 0x003CAF74 File Offset: 0x003C9174
				// (set) Token: 0x0600FF2C RID: 65324 RVA: 0x00078E7B File Offset: 0x0007707B
				public unsafe Customer.__c__DisplayClass197_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass197_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass197_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABEA RID: 44010
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABEB RID: 44011
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABEC RID: 44012
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABED RID: 44013
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABEE RID: 44014
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABEF RID: 44015
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABF0 RID: 44016
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABF1 RID: 44017
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABF2 RID: 44018
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A9D RID: 2717
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass199_0")]
		public sealed class __c__DisplayClass199_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E28F RID: 57999 RVA: 0x00378C84 File Offset: 0x00376E84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass199_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass199_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr);
				Customer.__c__DisplayClass199_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr, "entry");
				Customer.__c__DisplayClass199_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr, 100674005);
				Customer.__c__DisplayClass199_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr, 100674006);
			}

			// Token: 0x0600E290 RID: 58000 RVA: 0x00378CEC File Offset: 0x00376EEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass199_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass199_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass199_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E291 RID: 58001 RVA: 0x00378D28 File Offset: 0x00376F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EvaluateDelivery_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass199_0.NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E292 RID: 58002 RVA: 0x0006AD27 File Offset: 0x00068F27
			public __c__DisplayClass199_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F2 RID: 17650
			// (get) Token: 0x0600E293 RID: 58003 RVA: 0x00378D78 File Offset: 0x00376F78
			// (set) Token: 0x0600E294 RID: 58004 RVA: 0x0006AD30 File Offset: 0x00068F30
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass199_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass199_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A18 RID: 39448
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x04009A19 RID: 39449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A1A RID: 39450
			private static readonly IntPtr NativeMethodInfoPtr__EvaluateDelivery_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000A9E RID: 2718
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass200_0")]
		public sealed class __c__DisplayClass200_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E295 RID: 58005 RVA: 0x00378DA8 File Offset: 0x00376FA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass200_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass200_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr);
				Customer.__c__DisplayClass200_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass200_0.NativeFieldInfoPtr_oneWeekAgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr, "oneWeekAgo");
				Customer.__c__DisplayClass200_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr, 100674007);
				Customer.__c__DisplayClass200_0.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__0_Internal_Boolean_ContractReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr, 100674008);
			}

			// Token: 0x0600E296 RID: 58006 RVA: 0x00378E24 File Offset: 0x00377024
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass200_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass200_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass200_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E297 RID: 58007 RVA: 0x00378E60 File Offset: 0x00377060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179286, XrefRangeEnd = 179288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateTopWeeklyPurchases_b__0(ContractReceipt c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass200_0.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__0_Internal_Boolean_ContractReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E298 RID: 58008 RVA: 0x0006AD4F File Offset: 0x00068F4F
			public __c__DisplayClass200_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F3 RID: 17651
			// (get) Token: 0x0600E299 RID: 58009 RVA: 0x00378EB0 File Offset: 0x003770B0
			// (set) Token: 0x0600E29A RID: 58010 RVA: 0x0006AD58 File Offset: 0x00068F58
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F4 RID: 17652
			// (get) Token: 0x0600E29B RID: 58011 RVA: 0x00378EE0 File Offset: 0x003770E0
			// (set) Token: 0x0600E29C RID: 58012 RVA: 0x0006AD77 File Offset: 0x00068F77
			public unsafe GameDateTime oneWeekAgo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_0.NativeFieldInfoPtr_oneWeekAgo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_0.NativeFieldInfoPtr_oneWeekAgo)) = value;
				}
			}

			// Token: 0x04009A1B RID: 39451
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A1C RID: 39452
			private static readonly IntPtr NativeFieldInfoPtr_oneWeekAgo;

			// Token: 0x04009A1D RID: 39453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A1E RID: 39454
			private static readonly IntPtr NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__0_Internal_Boolean_ContractReceipt_0;
		}

		// Token: 0x02000A9F RID: 2719
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass200_1")]
		public sealed class __c__DisplayClass200_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E29D RID: 58013 RVA: 0x00378F08 File Offset: 0x00377108
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass200_1()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass200_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr);
				Customer.__c__DisplayClass200_1.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr, "item");
				Customer.__c__DisplayClass200_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr, 100674009);
				Customer.__c__DisplayClass200_1.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__2_Internal_Boolean_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr, 100674010);
			}

			// Token: 0x0600E29E RID: 58014 RVA: 0x00378F70 File Offset: 0x00377170
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass200_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass200_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass200_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E29F RID: 58015 RVA: 0x00378FAC File Offset: 0x003771AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179288, XrefRangeEnd = 179290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateTopWeeklyPurchases_b__2(StringIntPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass200_1.NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__2_Internal_Boolean_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2A0 RID: 58016 RVA: 0x0006AD92 File Offset: 0x00068F92
			public __c__DisplayClass200_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F5 RID: 17653
			// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x00378FFC File Offset: 0x003771FC
			// (set) Token: 0x0600E2A2 RID: 58018 RVA: 0x0006AD9B File Offset: 0x00068F9B
			public unsafe StringIntPair item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_1.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass200_1.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A1F RID: 39455
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04009A20 RID: 39456
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A21 RID: 39457
			private static readonly IntPtr NativeMethodInfoPtr__CalculateTopWeeklyPurchases_b__2_Internal_Boolean_StringIntPair_0;
		}

		// Token: 0x02000AA0 RID: 2720
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass202_0")]
		public sealed class __c__DisplayClass202_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2A3 RID: 58019 RVA: 0x0037902C File Offset: 0x0037722C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass202_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass202_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr);
				Customer.__c__DisplayClass202_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr, "item");
				Customer.__c__DisplayClass202_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass202_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr, 100674011);
				Customer.__c__DisplayClass202_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr, 100674012);
			}

			// Token: 0x0600E2A4 RID: 58020 RVA: 0x003790A8 File Offset: 0x003772A8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass202_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2A5 RID: 58021 RVA: 0x003790E4 File Offset: 0x003772E4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 179308, RefRangeEnd = 179310, XrefRangeStart = 179303, XrefRangeEnd = 179308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E2A6 RID: 58022 RVA: 0x0006ADBA File Offset: 0x00068FBA
			public __c__DisplayClass202_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F6 RID: 17654
			// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x00379124 File Offset: 0x00377324
			// (set) Token: 0x0600E2A8 RID: 58024 RVA: 0x0006ADC3 File Offset: 0x00068FC3
			public unsafe ItemInstance item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F7 RID: 17655
			// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x00379154 File Offset: 0x00377354
			// (set) Token: 0x0600E2AA RID: 58026 RVA: 0x0006ADE2 File Offset: 0x00068FE2
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A22 RID: 39458
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04009A23 RID: 39459
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A24 RID: 39460
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A25 RID: 39461
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DCE RID: 3534
			[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass202_0+<<ConsumeProduct>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FF2D RID: 65325 RVA: 0x003CAFA4 File Offset: 0x003C91A4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0>.NativeClassPtr, "<<ConsumeProduct>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674013);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674014);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674015);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674016);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674017);
					Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100674018);
				}

				// Token: 0x0600FF2E RID: 65326 RVA: 0x003CB084 File Offset: 0x003C9284
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF2F RID: 65327 RVA: 0x003CB0CC File Offset: 0x003C92CC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FF30 RID: 65328 RVA: 0x003CB100 File Offset: 0x003C9300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179290, XrefRangeEnd = 179298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004DB0 RID: 19888
				// (get) Token: 0x0600FF31 RID: 65329 RVA: 0x003CB13C File Offset: 0x003C933C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF32 RID: 65330 RVA: 0x003CB17C File Offset: 0x003C937C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179298, XrefRangeEnd = 179303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004DB1 RID: 19889
				// (get) Token: 0x0600FF33 RID: 65331 RVA: 0x003CB1B0 File Offset: 0x003C93B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FF34 RID: 65332 RVA: 0x00078E9A File Offset: 0x0007709A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004DAD RID: 19885
				// (get) Token: 0x0600FF35 RID: 65333 RVA: 0x003CB1F0 File Offset: 0x003C93F0
				// (set) Token: 0x0600FF36 RID: 65334 RVA: 0x00078EA3 File Offset: 0x000770A3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004DAE RID: 19886
				// (get) Token: 0x0600FF37 RID: 65335 RVA: 0x003CB218 File Offset: 0x003C9418
				// (set) Token: 0x0600FF38 RID: 65336 RVA: 0x00078EBE File Offset: 0x000770BE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004DAF RID: 19887
				// (get) Token: 0x0600FF39 RID: 65337 RVA: 0x003CB248 File Offset: 0x003C9448
				// (set) Token: 0x0600FF3A RID: 65338 RVA: 0x00078EDD File Offset: 0x000770DD
				public unsafe Customer.__c__DisplayClass202_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer.__c__DisplayClass202_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass202_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABF3 RID: 44019
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABF4 RID: 44020
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABF5 RID: 44021
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABF6 RID: 44022
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABF7 RID: 44023
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABF8 RID: 44024
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABF9 RID: 44025
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABFA RID: 44026
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABFB RID: 44027
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AA1 RID: 2721
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass238_0")]
		public sealed class __c__DisplayClass238_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2AB RID: 58027 RVA: 0x00379184 File Offset: 0x00377384
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass238_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass238_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr);
				Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass238_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr, "i");
				Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr, "<>9__0");
				Customer.__c__DisplayClass238_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr, 100674019);
				Customer.__c__DisplayClass238_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr, 100674020);
			}

			// Token: 0x0600E2AC RID: 58028 RVA: 0x00379214 File Offset: 0x00377414
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass238_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass238_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass238_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2AD RID: 58029 RVA: 0x00379250 File Offset: 0x00377450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179310, XrefRangeEnd = 179318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductEnjoyment_b__0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass238_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2AE RID: 58030 RVA: 0x0006AE01 File Offset: 0x00069001
			public __c__DisplayClass238_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044F8 RID: 17656
			// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x003792A0 File Offset: 0x003774A0
			// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x0006AE0A File Offset: 0x0006900A
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044F9 RID: 17657
			// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x003792D0 File Offset: 0x003774D0
			// (set) Token: 0x0600E2B2 RID: 58034 RVA: 0x0006AE29 File Offset: 0x00069029
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170044FA RID: 17658
			// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x003792F8 File Offset: 0x003774F8
			// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x0006AE44 File Offset: 0x00069044
			public unsafe Predicate<Effect> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Effect>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass238_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A26 RID: 39462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A27 RID: 39463
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04009A28 RID: 39464
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009A29 RID: 39465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A2A RID: 39466
			private static readonly IntPtr NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0;
		}

		// Token: 0x02000AA2 RID: 2722
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass239_0")]
		public sealed class __c__DisplayClass239_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2B5 RID: 58037 RVA: 0x00379328 File Offset: 0x00377528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass239_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass239_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr);
				Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr, "<>4__this");
				Customer.__c__DisplayClass239_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr, "i");
				Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr, "<>9__0");
				Customer.__c__DisplayClass239_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr, 100674021);
				Customer.__c__DisplayClass239_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr, 100674022);
			}

			// Token: 0x0600E2B6 RID: 58038 RVA: 0x003793B8 File Offset: 0x003775B8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass239_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass239_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass239_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2B7 RID: 58039 RVA: 0x003793F4 File Offset: 0x003775F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 179318, XrefRangeEnd = 179326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProductEnjoyment_b__0(Effect x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass239_0.NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2B8 RID: 58040 RVA: 0x0006AE63 File Offset: 0x00069063
			public __c__DisplayClass239_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FB RID: 17659
			// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x00379444 File Offset: 0x00377644
			// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x0006AE6C File Offset: 0x0006906C
			public unsafe Customer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044FC RID: 17660
			// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x00379474 File Offset: 0x00377674
			// (set) Token: 0x0600E2BC RID: 58044 RVA: 0x0006AE8B File Offset: 0x0006908B
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170044FD RID: 17661
			// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x0037949C File Offset: 0x0037769C
			// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x0006AEA6 File Offset: 0x000690A6
			public unsafe Predicate<Effect> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Effect>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass239_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A2B RID: 39467
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A2C RID: 39468
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04009A2D RID: 39469
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04009A2E RID: 39470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A2F RID: 39471
			private static readonly IntPtr NativeMethodInfoPtr__GetProductEnjoyment_b__0_Internal_Boolean_Effect_0;
		}

		// Token: 0x02000AA3 RID: 2723
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass240_0")]
		public sealed class __c__DisplayClass240_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2BF RID: 58047 RVA: 0x003794CC File Offset: 0x003776CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass240_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass240_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr);
				Customer.__c__DisplayClass240_0.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr, "x");
				Customer.__c__DisplayClass240_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr, 100674023);
				Customer.__c__DisplayClass240_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr, 100674024);
			}

			// Token: 0x0600E2C0 RID: 58048 RVA: 0x00379534 File Offset: 0x00377734
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass240_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass240_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass240_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2C1 RID: 58049 RVA: 0x00379570 File Offset: 0x00377770
			[CallerCount(0)]
			public unsafe bool _GetOrderedDrugTypes_b__1(ProductTypeAffinity y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass240_0.NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2C2 RID: 58050 RVA: 0x0006AEC5 File Offset: 0x000690C5
			public __c__DisplayClass240_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FE RID: 17662
			// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x003795C0 File Offset: 0x003777C0
			// (set) Token: 0x0600E2C4 RID: 58052 RVA: 0x0006AECE File Offset: 0x000690CE
			public unsafe EDrugType x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass240_0.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass240_0.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x04009A30 RID: 39472
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009A31 RID: 39473
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A32 RID: 39474
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDrugTypes_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x02000AA4 RID: 2724
		[ObfuscatedName("ScheduleOne.Economy.Customer+<>c__DisplayClass241_0")]
		public sealed class __c__DisplayClass241_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E2C5 RID: 58053 RVA: 0x003795E8 File Offset: 0x003777E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass241_0()
			{
				Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Customer>.NativeClassPtr, "<>c__DisplayClass241_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr);
				Customer.__c__DisplayClass241_0.NativeFieldInfoPtr_drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr, "drugType");
				Customer.__c__DisplayClass241_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr, 100674025);
				Customer.__c__DisplayClass241_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr, 100674026);
			}

			// Token: 0x0600E2C6 RID: 58054 RVA: 0x00379650 File Offset: 0x00377850
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass241_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Customer.__c__DisplayClass241_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass241_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E2C7 RID: 58055 RVA: 0x0037968C File Offset: 0x0037788C
			[CallerCount(0)]
			public unsafe bool _AdjustAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Customer.__c__DisplayClass241_0.NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E2C8 RID: 58056 RVA: 0x0006AEE9 File Offset: 0x000690E9
			public __c__DisplayClass241_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044FF RID: 17663
			// (get) Token: 0x0600E2C9 RID: 58057 RVA: 0x003796DC File Offset: 0x003778DC
			// (set) Token: 0x0600E2CA RID: 58058 RVA: 0x0006AEF2 File Offset: 0x000690F2
			public unsafe EDrugType drugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass241_0.NativeFieldInfoPtr_drugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Customer.__c__DisplayClass241_0.NativeFieldInfoPtr_drugType)) = value;
				}
			}

			// Token: 0x04009A33 RID: 39475
			private static readonly IntPtr NativeFieldInfoPtr_drugType;

			// Token: 0x04009A34 RID: 39476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A35 RID: 39477
			private static readonly IntPtr NativeMethodInfoPtr__AdjustAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
