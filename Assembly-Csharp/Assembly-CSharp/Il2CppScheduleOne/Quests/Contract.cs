using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x0200013C RID: 316
	public class Contract : Quest
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x000E21FC File Offset: 0x000E03FC
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeFieldInfoPtr_DefaultExpiryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DefaultExpiryTime");
			Contract.NativeFieldInfoPtr_ExcessProductsMatchSumMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "ExcessProductsMatchSumMultiplier");
			Contract.NativeFieldInfoPtr_Contracts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "Contracts");
			Contract.NativeFieldInfoPtr__Customer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Customer>k__BackingField");
			Contract.NativeFieldInfoPtr__Dealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Dealer>k__BackingField");
			Contract.NativeFieldInfoPtr__Payment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<Payment>k__BackingField");
			Contract.NativeFieldInfoPtr_ProductList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "ProductList");
			Contract.NativeFieldInfoPtr_DeliveryLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryLocation");
			Contract.NativeFieldInfoPtr_DeliveryWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "DeliveryWindow");
			Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<PickupScheduleIndex>k__BackingField");
			Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<AcceptTime>k__BackingField");
			Contract.NativeFieldInfoPtr_completedContractsIncremented = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract>.NativeClassPtr, "completedContractsIncremented");
			Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667374);
			Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667375);
			Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667376);
			Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667377);
			Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667378);
			Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667379);
			Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667380);
			Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667381);
			Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667382);
			Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667383);
			Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667384);
			Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667385);
			Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667386);
			Contract.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667387);
			Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667388);
			Contract.NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667389);
			Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667390);
			Contract.NativeMethodInfoPtr_UpdatePoI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667391);
			Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667392);
			Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667393);
			Contract.NativeMethodInfoPtr_Expire_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667394);
			Contract.NativeMethodInfoPtr_Fail_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667395);
			Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667396);
			Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667397);
			Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667398);
			Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667399);
			Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667400);
			Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667401);
			Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667402);
			Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667403);
			Contract.NativeMethodInfoPtr_GetDescendingMatchRatings_Private_Dictionary_2_ProductItemInstance_Single_Entry_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667404);
			Contract.NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667405);
			Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667406);
			Contract.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100667407);
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x000E25C4 File Offset: 0x000E07C4
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x000E2604 File Offset: 0x000E0804
		public unsafe NetworkObject Customer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106909, XrefRangeEnd = 106910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x000E2648 File Offset: 0x000E0848
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x000E2688 File Offset: 0x000E0888
		public unsafe Dealer Dealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106910, XrefRangeEnd = 106911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x000E26CC File Offset: 0x000E08CC
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x000E2708 File Offset: 0x000E0908
		public unsafe float Payment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_Payment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x000E2748 File Offset: 0x000E0948
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x000E2784 File Offset: 0x000E0984
		public unsafe int PickupScheduleIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x000E27C4 File Offset: 0x000E09C4
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x000E2800 File Offset: 0x000E0A00
		public unsafe GameDateTime AcceptTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x000E2840 File Offset: 0x000E0A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106911, XrefRangeEnd = 106912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x000E287C File Offset: 0x000E0A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106912, XrefRangeEnd = 106939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000E297C File Offset: 0x000E0B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106939, XrefRangeEnd = 106953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SilentlyInitializeContract(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, int pickupScheduleIndex, GameDateTime acceptTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000E2A7C File Offset: 0x000E0C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106953, XrefRangeEnd = 106955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnUncappedMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000E2AB8 File Offset: 0x000E0CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106955, XrefRangeEnd = 106963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x000E2AEC File Offset: 0x000E0CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106963, XrefRangeEnd = 106967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldQuestShowUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000E2B34 File Offset: 0x000E0D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107020, RefRangeEnd = 107022, XrefRangeStart = 106967, XrefRangeEnd = 107020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTiming()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_UpdateTiming_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x000E2B68 File Offset: 0x000E0D68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107038, RefRangeEnd = 107041, XrefRangeStart = 107022, XrefRangeEnd = 107038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_UpdatePoI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x000E2B9C File Offset: 0x000E0D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107041, XrefRangeEnd = 107056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000E2BD8 File Offset: 0x000E0DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107056, XrefRangeEnd = 107071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Complete(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x000E2C24 File Offset: 0x000E0E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107071, XrefRangeEnd = 107088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Expire(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Expire_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x000E2C70 File Offset: 0x000E0E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107088, XrefRangeEnd = 107106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fail(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_Fail_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x000E2CBC File Offset: 0x000E0EBC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 107116, RefRangeEnd = 107121, XrefRangeStart = 107106, XrefRangeEnd = 107116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA0 RID: 8096 RVA: 0x000E2D00 File Offset: 0x000E0F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107121, XrefRangeEnd = 107126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SubmitPayment(float bonusTotal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bonusTotal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA1 RID: 8097 RVA: 0x000E2D4C File Offset: 0x000E0F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107126, XrefRangeEnd = 107137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiryReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA2 RID: 8098 RVA: 0x000E2D88 File Offset: 0x000E0F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107137, XrefRangeEnd = 107148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendExpiredNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA3 RID: 8099 RVA: 0x000E2DC4 File Offset: 0x000E0FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107148, XrefRangeEnd = 107152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldShowJournalEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x000E2E0C File Offset: 0x000E100C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107152, XrefRangeEnd = 107163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanExpire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x000E2E54 File Offset: 0x000E1054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107163, XrefRangeEnd = 107235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesProductListMatchSpecified(List<ItemInstance> items, bool enforceQuality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enforceQuality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x000E2EB0 File Offset: 0x000E10B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 107340, RefRangeEnd = 107343, XrefRangeStart = 107235, XrefRangeEnd = 107340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProductListMatch(List<ItemInstance> items, out int matchedProductCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &matchedProductCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x000E2F0C File Offset: 0x000E110C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107409, RefRangeEnd = 107411, XrefRangeStart = 107343, XrefRangeEnd = 107409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<ProductItemInstance, float> GetDescendingMatchRatings(ProductList.Entry requestedItem, List<ItemInstance> providedItems)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(requestedItem);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(providedItems);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_GetDescendingMatchRatings_Private_Dictionary_2_ProductItemInstance_Single_Entry_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductItemInstance, float>>(intPtr3) : null;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x000E2F70 File Offset: 0x000E1170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107411, XrefRangeEnd = 107451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Contract.NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x000E2FBC File Offset: 0x000E11BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107451, XrefRangeEnd = 107456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x000E2FF8 File Offset: 0x000E11F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 107488, RefRangeEnd = 107490, XrefRangeStart = 107456, XrefRangeEnd = 107488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x000110CF File Offset: 0x0000F2CF
		public Contract(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x000E3034 File Offset: 0x000E1234
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x000110D8 File Offset: 0x0000F2D8
		public unsafe static int DefaultExpiryTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_DefaultExpiryTime, (void*)(&value));
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x000E3050 File Offset: 0x000E1250
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x000110E6 File Offset: 0x0000F2E6
		public unsafe static float ExcessProductsMatchSumMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_ExcessProductsMatchSumMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_ExcessProductsMatchSumMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x000E306C File Offset: 0x000E126C
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x000110F4 File Offset: 0x0000F2F4
		public unsafe static List<Contract> Contracts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Contract.NativeFieldInfoPtr_Contracts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Contract.NativeFieldInfoPtr_Contracts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x000E3094 File Offset: 0x000E1294
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00011106 File Offset: 0x0000F306
		public unsafe NetworkObject _Customer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Customer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x000E30C4 File Offset: 0x000E12C4
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00011125 File Offset: 0x0000F325
		public unsafe Dealer _Dealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Dealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x000E30F4 File Offset: 0x000E12F4
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00011144 File Offset: 0x0000F344
		public unsafe float _Payment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__Payment_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x000E311C File Offset: 0x000E131C
		// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0001115F File Offset: 0x0000F35F
		public unsafe ProductList ProductList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_ProductList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x000E314C File Offset: 0x000E134C
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0001117E File Offset: 0x0000F37E
		public unsafe DeliveryLocation DeliveryLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000E317C File Offset: 0x000E137C
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0001119D File Offset: 0x0000F39D
		public unsafe QuestWindowConfig DeliveryWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestWindowConfig>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_DeliveryWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x000E31AC File Offset: 0x000E13AC
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x000111BC File Offset: 0x0000F3BC
		public unsafe int _PickupScheduleIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x000E31D4 File Offset: 0x000E13D4
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x000111D7 File Offset: 0x0000F3D7
		public unsafe GameDateTime _AcceptTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr__AcceptTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000E31FC File Offset: 0x000E13FC
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x000111F2 File Offset: 0x0000F3F2
		public unsafe bool completedContractsIncremented
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.NativeFieldInfoPtr_completedContractsIncremented)) = value;
			}
		}

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeFieldInfoPtr_DefaultExpiryTime;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeFieldInfoPtr_ExcessProductsMatchSumMultiplier;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeFieldInfoPtr_Contracts;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeFieldInfoPtr__Customer_k__BackingField;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeFieldInfoPtr__Dealer_k__BackingField;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr__Payment_k__BackingField;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr_ProductList;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryLocation;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryWindow;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr__PickupScheduleIndex_k__BackingField;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeFieldInfoPtr__AcceptTime_k__BackingField;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeFieldInfoPtr_completedContractsIncremented;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_get_Customer_Public_get_NetworkObject_0;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeMethodInfoPtr_set_Customer_Protected_set_Void_NetworkObject_0;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeMethodInfoPtr_set_Dealer_Protected_set_Void_Dealer_0;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeMethodInfoPtr_get_Payment_Public_get_Single_0;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeMethodInfoPtr_set_Payment_Protected_set_Void_Single_0;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeMethodInfoPtr_get_PickupScheduleIndex_Public_get_Int32_0;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeMethodInfoPtr_set_PickupScheduleIndex_Protected_set_Void_Int32_0;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeMethodInfoPtr_get_AcceptTime_Public_get_GameDateTime_0;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeMethodInfoPtr_set_AcceptTime_Protected_set_Void_GameDateTime_0;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeMethodInfoPtr_InitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeMethodInfoPtr_SilentlyInitializeContract_Public_Virtual_New_Void_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Customer_Single_ProductList_String_QuestWindowConfig_Int32_GameDateTime_0;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinPass_Protected_Virtual_Void_0;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeMethodInfoPtr_ShouldQuestShowUI_Protected_Virtual_Boolean_0;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTiming_Private_Void_0;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePoI_Public_Void_0;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeMethodInfoPtr_Complete_Public_Virtual_Void_Boolean_0;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeMethodInfoPtr_Expire_Public_Virtual_Void_Boolean_0;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeMethodInfoPtr_Fail_Public_Virtual_Void_Boolean_0;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeMethodInfoPtr_SetDealer_Public_Void_Dealer_0;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPayment_Public_Virtual_New_Void_Single_0;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryReminder_Protected_Virtual_Void_0;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiredNotification_Protected_Virtual_Void_0;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowJournalEntry_Protected_Virtual_Boolean_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeMethodInfoPtr_CanExpire_Protected_Virtual_Boolean_0;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_DoesProductListMatchSpecified_Public_Boolean_List_1_ItemInstance_Boolean_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_GetProductListMatch_Public_Single_List_1_ItemInstance_byref_Int32_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_GetDescendingMatchRatings_Private_Dictionary_2_ProductItemInstance_Single_Entry_List_1_ItemInstance_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_SaveData_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000966 RID: 2406
		public class BonusPayment : Object
		{
			// Token: 0x0600D937 RID: 55607 RVA: 0x0035EC68 File Offset: 0x0035CE68
			// Note: this type is marked as 'beforefieldinit'.
			static BonusPayment()
			{
				Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "BonusPayment");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr);
				Contract.BonusPayment.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Title");
				Contract.BonusPayment.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, "Amount");
				Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr, 100667409);
			}

			// Token: 0x0600D938 RID: 55608 RVA: 0x0035ECD0 File Offset: 0x0035CED0
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 106895, RefRangeEnd = 106900, XrefRangeStart = 106893, XrefRangeEnd = 106895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BonusPayment(string title, float amount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.BonusPayment>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.BonusPayment.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D939 RID: 55609 RVA: 0x00066266 File Offset: 0x00064466
			public BonusPayment(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004259 RID: 16985
			// (get) Token: 0x0600D93A RID: 55610 RVA: 0x0035ED2C File Offset: 0x0035CF2C
			// (set) Token: 0x0600D93B RID: 55611 RVA: 0x0006626F File Offset: 0x0006446F
			public unsafe string Title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700425A RID: 16986
			// (get) Token: 0x0600D93C RID: 55612 RVA: 0x0035ED54 File Offset: 0x0035CF54
			// (set) Token: 0x0600D93D RID: 55613 RVA: 0x0006628E File Offset: 0x0006448E
			public unsafe float Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.BonusPayment.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x04009449 RID: 37961
			private static readonly IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x0400944A RID: 37962
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x0400944B RID: 37963
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
		}

		// Token: 0x02000967 RID: 2407
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Object
		{
			// Token: 0x0600D93E RID: 55614 RVA: 0x0035ED7C File Offset: 0x0035CF7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr);
				Contract.__c__DisplayClass46_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr, "entry");
				Contract.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr, 100667410);
				Contract.__c__DisplayClass46_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr, 100667411);
			}

			// Token: 0x0600D93F RID: 55615 RVA: 0x0035EDE4 File Offset: 0x0035CFE4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D940 RID: 55616 RVA: 0x0035EE20 File Offset: 0x0035D020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106900, XrefRangeEnd = 106903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoesProductListMatchSpecified_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass46_0.NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D941 RID: 55617 RVA: 0x000662A9 File Offset: 0x000644A9
			public __c__DisplayClass46_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425B RID: 16987
			// (get) Token: 0x0600D942 RID: 55618 RVA: 0x0035EE70 File Offset: 0x0035D070
			// (set) Token: 0x0600D943 RID: 55619 RVA: 0x000662B2 File Offset: 0x000644B2
			public unsafe ProductList.Entry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass46_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductList.Entry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass46_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400944C RID: 37964
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400944D RID: 37965
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400944E RID: 37966
			private static readonly IntPtr NativeMethodInfoPtr__DoesProductListMatchSpecified_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000968 RID: 2408
		[ObfuscatedName("ScheduleOne.Quests.Contract+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x0600D944 RID: 55620 RVA: 0x0035EEA0 File Offset: 0x0035D0A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Contract>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr);
				Contract.__c__DisplayClass48_0.NativeFieldInfoPtr_matchRatings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr, "matchRatings");
				Contract.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr, 100667412);
				Contract.__c__DisplayClass48_0.NativeMethodInfoPtr__GetDescendingMatchRatings_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr, 100667413);
			}

			// Token: 0x0600D945 RID: 55621 RVA: 0x0035EF08 File Offset: 0x0035D108
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Contract.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D946 RID: 55622 RVA: 0x0035EF44 File Offset: 0x0035D144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106903, XrefRangeEnd = 106909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetDescendingMatchRatings_b__0(ProductItemInstance a, ProductItemInstance b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.__c__DisplayClass48_0.NativeMethodInfoPtr__GetDescendingMatchRatings_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D947 RID: 55623 RVA: 0x000662D1 File Offset: 0x000644D1
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700425C RID: 16988
			// (get) Token: 0x0600D948 RID: 55624 RVA: 0x0035EFA4 File Offset: 0x0035D1A4
			// (set) Token: 0x0600D949 RID: 55625 RVA: 0x000662DA File Offset: 0x000644DA
			public unsafe Dictionary<ProductItemInstance, float> matchRatings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass48_0.NativeFieldInfoPtr_matchRatings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductItemInstance, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Contract.__c__DisplayClass48_0.NativeFieldInfoPtr_matchRatings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400944F RID: 37967
			private static readonly IntPtr NativeFieldInfoPtr_matchRatings;

			// Token: 0x04009450 RID: 37968
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009451 RID: 37969
			private static readonly IntPtr NativeMethodInfoPtr__GetDescendingMatchRatings_b__0_Internal_Int32_ProductItemInstance_ProductItemInstance_0;
		}
	}
}
