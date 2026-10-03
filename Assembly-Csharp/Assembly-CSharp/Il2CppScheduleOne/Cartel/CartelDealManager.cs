using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044C RID: 1100
	public class CartelDealManager : NetworkBehaviour
	{
		// Token: 0x06006388 RID: 25480 RVA: 0x001D41BC File Offset: 0x001D23BC
		// Note: this type is marked as 'beforefieldinit'.
		static CartelDealManager()
		{
			Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelDealManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr);
			CartelDealManager.NativeFieldInfoPtr_DEAL_DUE_TIME_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "DEAL_DUE_TIME_DAYS");
			CartelDealManager.NativeFieldInfoPtr_PAYMENT_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "PAYMENT_MULTIPLIER");
			CartelDealManager.NativeFieldInfoPtr_DEAL_COOLDOWN_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "DEAL_COOLDOWN_HOURS");
			CartelDealManager.NativeFieldInfoPtr__ActiveDeal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "<ActiveDeal>k__BackingField");
			CartelDealManager.NativeFieldInfoPtr__HoursUntilNextDealRequest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "<HoursUntilNextDealRequest>k__BackingField");
			CartelDealManager.NativeFieldInfoPtr_RequestingNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "RequestingNPC");
			CartelDealManager.NativeFieldInfoPtr_DealQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "DealQuest");
			CartelDealManager.NativeFieldInfoPtr_DeliveryEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "DeliveryEntity");
			CartelDealManager.NativeFieldInfoPtr_CashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "CashSpawnPoint");
			CartelDealManager.NativeFieldInfoPtr_MethRequestPrereqQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "MethRequestPrereqQuest");
			CartelDealManager.NativeFieldInfoPtr_CokeRequestPrereqSupplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "CokeRequestPrereqSupplier");
			CartelDealManager.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "CashPrefab");
			CartelDealManager.NativeFieldInfoPtr_RequestableWeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "RequestableWeed");
			CartelDealManager.NativeFieldInfoPtr_MethDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "MethDefinition");
			CartelDealManager.NativeFieldInfoPtr_CocaineDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "CocaineDefinition");
			CartelDealManager.NativeFieldInfoPtr_ProductQuantityMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "ProductQuantityMin");
			CartelDealManager.NativeFieldInfoPtr_ProductQuantityMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "ProductQuantityMax");
			CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted");
			CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelDealManagerAssembly-CSharp.dll_Excuted");
			CartelDealManager.NativeMethodInfoPtr_get_ActiveDeal_Public_get_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676370);
			CartelDealManager.NativeMethodInfoPtr_set_ActiveDeal_Private_set_Void_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676371);
			CartelDealManager.NativeMethodInfoPtr_get_HoursUntilNextDealRequest_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676372);
			CartelDealManager.NativeMethodInfoPtr_set_HoursUntilNextDealRequest_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676373);
			CartelDealManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676374);
			CartelDealManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676375);
			CartelDealManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676376);
			CartelDealManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676377);
			CartelDealManager.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676378);
			CartelDealManager.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676379);
			CartelDealManager.NativeMethodInfoPtr_SetHoursUntilDealRequest_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676380);
			CartelDealManager.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676381);
			CartelDealManager.NativeMethodInfoPtr_MarkDealOverdue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676382);
			CartelDealManager.NativeMethodInfoPtr_ExpireDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676383);
			CartelDealManager.NativeMethodInfoPtr_CheckDealCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676384);
			CartelDealManager.NativeMethodInfoPtr_CompleteDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676385);
			CartelDealManager.NativeMethodInfoPtr_DepositCash_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676386);
			CartelDealManager.NativeMethodInfoPtr_StartDeal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676387);
			CartelDealManager.NativeMethodInfoPtr_LoadDeal_Public_Void_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676388);
			CartelDealManager.NativeMethodInfoPtr_InitializeDealQuest_Private_Void_NetworkConnection_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676389);
			CartelDealManager.NativeMethodInfoPtr_SendRequestMessage_Private_Void_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676390);
			CartelDealManager.NativeMethodInfoPtr_SendOverdueMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676391);
			CartelDealManager.NativeMethodInfoPtr_SendExpiryMessage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676392);
			CartelDealManager.NativeMethodInfoPtr_Load_Public_Void_CartelData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676393);
			CartelDealManager.NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676394);
			CartelDealManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676395);
			CartelDealManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676396);
			CartelDealManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676397);
			CartelDealManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676398);
			CartelDealManager.NativeMethodInfoPtr_RpcWriter___Observers_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676399);
			CartelDealManager.NativeMethodInfoPtr_RpcLogic___InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676400);
			CartelDealManager.NativeMethodInfoPtr_RpcReader___Observers_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676401);
			CartelDealManager.NativeMethodInfoPtr_RpcWriter___Target_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676402);
			CartelDealManager.NativeMethodInfoPtr_RpcReader___Target_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676403);
			CartelDealManager.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, 100676404);
		}

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06006389 RID: 25481 RVA: 0x001D4624 File Offset: 0x001D2824
		// (set) Token: 0x0600638A RID: 25482 RVA: 0x001D4664 File Offset: 0x001D2864
		public unsafe CartelDealInfo ActiveDeal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_get_ActiveDeal_Public_get_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelDealInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_set_ActiveDeal_Private_set_Void_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x001D46A8 File Offset: 0x001D28A8
		// (set) Token: 0x0600638C RID: 25484 RVA: 0x001D46E4 File Offset: 0x001D28E4
		public unsafe int HoursUntilNextDealRequest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_get_HoursUntilNextDealRequest_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_set_HoursUntilNextDealRequest_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x001D4724 File Offset: 0x001D2924
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600638E RID: 25486 RVA: 0x001D4760 File Offset: 0x001D2960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209506, XrefRangeEnd = 209586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x001D4794 File Offset: 0x001D2994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209586, XrefRangeEnd = 209589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006390 RID: 25488 RVA: 0x001D47E4 File Offset: 0x001D29E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209589, XrefRangeEnd = 209596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x001D4818 File Offset: 0x001D2A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209596, XrefRangeEnd = 209601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkip(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x001D4858 File Offset: 0x001D2A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209601, XrefRangeEnd = 209606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x001D488C File Offset: 0x001D2A8C
		[CallerCount(0)]
		public unsafe void SetHoursUntilDealRequest(int hours)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hours;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_SetHoursUntilDealRequest_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x001D48CC File Offset: 0x001D2ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209606, XrefRangeEnd = 209624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x001D4900 File Offset: 0x001D2B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209624, XrefRangeEnd = 209629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkDealOverdue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_MarkDealOverdue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x001D4934 File Offset: 0x001D2B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209629, XrefRangeEnd = 209640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpireDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_ExpireDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x001D4968 File Offset: 0x001D2B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209659, RefRangeEnd = 209660, XrefRangeStart = 209640, XrefRangeEnd = 209659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDealCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_CheckDealCompletion_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x001D499C File Offset: 0x001D2B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209702, RefRangeEnd = 209703, XrefRangeStart = 209660, XrefRangeEnd = 209702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_CompleteDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x001D49D0 File Offset: 0x001D2BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209703, XrefRangeEnd = 209715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DepositCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_DepositCash_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x001D4A10 File Offset: 0x001D2C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209775, RefRangeEnd = 209776, XrefRangeStart = 209715, XrefRangeEnd = 209775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_StartDeal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x001D4A44 File Offset: 0x001D2C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209776, XrefRangeEnd = 209777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDeal(CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_LoadDeal_Public_Void_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639C RID: 25500 RVA: 0x001D4A88 File Offset: 0x001D2C88
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 209787, RefRangeEnd = 209792, XrefRangeStart = 209777, XrefRangeEnd = 209787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDealQuest(NetworkConnection conn, CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_InitializeDealQuest_Private_Void_NetworkConnection_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x001D4ADC File Offset: 0x001D2CDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209824, RefRangeEnd = 209825, XrefRangeStart = 209792, XrefRangeEnd = 209824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRequestMessage(CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_SendRequestMessage_Private_Void_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639E RID: 25502 RVA: 0x001D4B20 File Offset: 0x001D2D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209825, XrefRangeEnd = 209830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendOverdueMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_SendOverdueMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x001D4B54 File Offset: 0x001D2D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209830, XrefRangeEnd = 209835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendExpiryMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_SendExpiryMessage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x001D4B88 File Offset: 0x001D2D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209835, XrefRangeEnd = 209841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(CartelData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_Load_Public_Void_CartelData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x001D4BCC File Offset: 0x001D2DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209841, XrefRangeEnd = 209843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldStatus;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x001D4C18 File Offset: 0x001D2E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209843, XrefRangeEnd = 209844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelDealManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x001D4C54 File Offset: 0x001D2E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209844, XrefRangeEnd = 209857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x001D4C90 File Offset: 0x001D2E90
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A5 RID: 25509 RVA: 0x001D4CCC File Offset: 0x001D2ECC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelDealManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A6 RID: 25510 RVA: 0x001D4D08 File Offset: 0x001D2F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209857, XrefRangeEnd = 209867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_RpcWriter___Observers_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x001D4D5C File Offset: 0x001D2F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209867, XrefRangeEnd = 209869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_RpcLogic___InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x001D4DB0 File Offset: 0x001D2FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209869, XrefRangeEnd = 209874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_RpcReader___Observers_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x001D4E00 File Offset: 0x001D3000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209874, XrefRangeEnd = 209884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeDealQuest_2137933519(NetworkConnection conn, CartelDealInfo dealInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_RpcWriter___Target_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063AA RID: 25514 RVA: 0x001D4E54 File Offset: 0x001D3054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209884, XrefRangeEnd = 209889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeDealQuest_2137933519(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_RpcReader___Target_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x001D4EA4 File Offset: 0x001D30A4
		[CallerCount(0)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063AC RID: 25516 RVA: 0x0002EF03 File Offset: 0x0002D103
		public CartelDealManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x060063AD RID: 25517 RVA: 0x001D4ED8 File Offset: 0x001D30D8
		// (set) Token: 0x060063AE RID: 25518 RVA: 0x0002EF0C File Offset: 0x0002D10C
		public unsafe static int DEAL_DUE_TIME_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealManager.NativeFieldInfoPtr_DEAL_DUE_TIME_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealManager.NativeFieldInfoPtr_DEAL_DUE_TIME_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x060063AF RID: 25519 RVA: 0x001D4EF4 File Offset: 0x001D30F4
		// (set) Token: 0x060063B0 RID: 25520 RVA: 0x0002EF1A File Offset: 0x0002D11A
		public unsafe static float PAYMENT_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealManager.NativeFieldInfoPtr_PAYMENT_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealManager.NativeFieldInfoPtr_PAYMENT_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x001D4F10 File Offset: 0x001D3110
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x0002EF28 File Offset: 0x0002D128
		public unsafe static int DEAL_COOLDOWN_HOURS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelDealManager.NativeFieldInfoPtr_DEAL_COOLDOWN_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelDealManager.NativeFieldInfoPtr_DEAL_COOLDOWN_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x001D4F2C File Offset: 0x001D312C
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x0002EF36 File Offset: 0x0002D136
		public unsafe CartelDealInfo _ActiveDeal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr__ActiveDeal_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr__ActiveDeal_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x060063B5 RID: 25525 RVA: 0x001D4F5C File Offset: 0x001D315C
		// (set) Token: 0x060063B6 RID: 25526 RVA: 0x0002EF55 File Offset: 0x0002D155
		public unsafe int _HoursUntilNextDealRequest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr__HoursUntilNextDealRequest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr__HoursUntilNextDealRequest_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x060063B7 RID: 25527 RVA: 0x001D4F84 File Offset: 0x001D3184
		// (set) Token: 0x060063B8 RID: 25528 RVA: 0x0002EF70 File Offset: 0x0002D170
		public unsafe NPC RequestingNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_RequestingNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_RequestingNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x060063B9 RID: 25529 RVA: 0x001D4FB4 File Offset: 0x001D31B4
		// (set) Token: 0x060063BA RID: 25530 RVA: 0x0002EF8F File Offset: 0x0002D18F
		public unsafe Quest_DealForCartel DealQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_DealQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest_DealForCartel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_DealQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x001D4FE4 File Offset: 0x001D31E4
		// (set) Token: 0x060063BC RID: 25532 RVA: 0x0002EFAE File Offset: 0x0002D1AE
		public unsafe WorldStorageEntity DeliveryEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_DeliveryEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_DeliveryEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x001D5014 File Offset: 0x001D3214
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x0002EFCD File Offset: 0x0002D1CD
		public unsafe Transform CashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x001D5044 File Offset: 0x001D3244
		// (set) Token: 0x060063C0 RID: 25536 RVA: 0x0002EFEC File Offset: 0x0002D1EC
		public unsafe Quest MethRequestPrereqQuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_MethRequestPrereqQuest);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Quest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_MethRequestPrereqQuest), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x060063C1 RID: 25537 RVA: 0x001D5074 File Offset: 0x001D3274
		// (set) Token: 0x060063C2 RID: 25538 RVA: 0x0002F00B File Offset: 0x0002D20B
		public unsafe Supplier CokeRequestPrereqSupplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CokeRequestPrereqSupplier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CokeRequestPrereqSupplier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x001D50A4 File Offset: 0x001D32A4
		// (set) Token: 0x060063C4 RID: 25540 RVA: 0x0002F02A File Offset: 0x0002D22A
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x060063C5 RID: 25541 RVA: 0x001D50D4 File Offset: 0x001D32D4
		// (set) Token: 0x060063C6 RID: 25542 RVA: 0x0002F049 File Offset: 0x0002D249
		public unsafe Il2CppReferenceArray<ProductDefinition> RequestableWeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_RequestableWeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_RequestableWeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x060063C7 RID: 25543 RVA: 0x001D5104 File Offset: 0x001D3304
		// (set) Token: 0x060063C8 RID: 25544 RVA: 0x0002F068 File Offset: 0x0002D268
		public unsafe ProductDefinition MethDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_MethDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_MethDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x001D5134 File Offset: 0x001D3334
		// (set) Token: 0x060063CA RID: 25546 RVA: 0x0002F087 File Offset: 0x0002D287
		public unsafe ProductDefinition CocaineDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CocaineDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_CocaineDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x060063CB RID: 25547 RVA: 0x001D5164 File Offset: 0x001D3364
		// (set) Token: 0x060063CC RID: 25548 RVA: 0x0002F0A6 File Offset: 0x0002D2A6
		public unsafe int ProductQuantityMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_ProductQuantityMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_ProductQuantityMin)) = value;
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x001D518C File Offset: 0x001D338C
		// (set) Token: 0x060063CE RID: 25550 RVA: 0x0002F0C1 File Offset: 0x0002D2C1
		public unsafe int ProductQuantityMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_ProductQuantityMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_ProductQuantityMax)) = value;
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x060063CF RID: 25551 RVA: 0x001D51B4 File Offset: 0x001D33B4
		// (set) Token: 0x060063D0 RID: 25552 RVA: 0x0002F0DC File Offset: 0x0002D2DC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x060063D1 RID: 25553 RVA: 0x001D51DC File Offset: 0x001D33DC
		// (set) Token: 0x060063D2 RID: 25554 RVA: 0x0002F0F7 File Offset: 0x0002D2F7
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400449A RID: 17562
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_DUE_TIME_DAYS;

		// Token: 0x0400449B RID: 17563
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MULTIPLIER;

		// Token: 0x0400449C RID: 17564
		private static readonly IntPtr NativeFieldInfoPtr_DEAL_COOLDOWN_HOURS;

		// Token: 0x0400449D RID: 17565
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDeal_k__BackingField;

		// Token: 0x0400449E RID: 17566
		private static readonly IntPtr NativeFieldInfoPtr__HoursUntilNextDealRequest_k__BackingField;

		// Token: 0x0400449F RID: 17567
		private static readonly IntPtr NativeFieldInfoPtr_RequestingNPC;

		// Token: 0x040044A0 RID: 17568
		private static readonly IntPtr NativeFieldInfoPtr_DealQuest;

		// Token: 0x040044A1 RID: 17569
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryEntity;

		// Token: 0x040044A2 RID: 17570
		private static readonly IntPtr NativeFieldInfoPtr_CashSpawnPoint;

		// Token: 0x040044A3 RID: 17571
		private static readonly IntPtr NativeFieldInfoPtr_MethRequestPrereqQuest;

		// Token: 0x040044A4 RID: 17572
		private static readonly IntPtr NativeFieldInfoPtr_CokeRequestPrereqSupplier;

		// Token: 0x040044A5 RID: 17573
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x040044A6 RID: 17574
		private static readonly IntPtr NativeFieldInfoPtr_RequestableWeed;

		// Token: 0x040044A7 RID: 17575
		private static readonly IntPtr NativeFieldInfoPtr_MethDefinition;

		// Token: 0x040044A8 RID: 17576
		private static readonly IntPtr NativeFieldInfoPtr_CocaineDefinition;

		// Token: 0x040044A9 RID: 17577
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantityMin;

		// Token: 0x040044AA RID: 17578
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantityMax;

		// Token: 0x040044AB RID: 17579
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040044AC RID: 17580
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040044AD RID: 17581
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDeal_Public_get_CartelDealInfo_0;

		// Token: 0x040044AE RID: 17582
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDeal_Private_set_Void_CartelDealInfo_0;

		// Token: 0x040044AF RID: 17583
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursUntilNextDealRequest_Public_get_Int32_0;

		// Token: 0x040044B0 RID: 17584
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursUntilNextDealRequest_Private_set_Void_Int32_0;

		// Token: 0x040044B1 RID: 17585
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040044B2 RID: 17586
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040044B3 RID: 17587
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040044B4 RID: 17588
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x040044B5 RID: 17589
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkip_Private_Void_Int32_0;

		// Token: 0x040044B6 RID: 17590
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x040044B7 RID: 17591
		private static readonly IntPtr NativeMethodInfoPtr_SetHoursUntilDealRequest_Public_Void_Int32_0;

		// Token: 0x040044B8 RID: 17592
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x040044B9 RID: 17593
		private static readonly IntPtr NativeMethodInfoPtr_MarkDealOverdue_Private_Void_0;

		// Token: 0x040044BA RID: 17594
		private static readonly IntPtr NativeMethodInfoPtr_ExpireDeal_Private_Void_0;

		// Token: 0x040044BB RID: 17595
		private static readonly IntPtr NativeMethodInfoPtr_CheckDealCompletion_Private_Void_0;

		// Token: 0x040044BC RID: 17596
		private static readonly IntPtr NativeMethodInfoPtr_CompleteDeal_Private_Void_0;

		// Token: 0x040044BD RID: 17597
		private static readonly IntPtr NativeMethodInfoPtr_DepositCash_Private_Void_Single_0;

		// Token: 0x040044BE RID: 17598
		private static readonly IntPtr NativeMethodInfoPtr_StartDeal_Private_Void_0;

		// Token: 0x040044BF RID: 17599
		private static readonly IntPtr NativeMethodInfoPtr_LoadDeal_Public_Void_CartelDealInfo_0;

		// Token: 0x040044C0 RID: 17600
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDealQuest_Private_Void_NetworkConnection_CartelDealInfo_0;

		// Token: 0x040044C1 RID: 17601
		private static readonly IntPtr NativeMethodInfoPtr_SendRequestMessage_Private_Void_CartelDealInfo_0;

		// Token: 0x040044C2 RID: 17602
		private static readonly IntPtr NativeMethodInfoPtr_SendOverdueMessage_Private_Void_0;

		// Token: 0x040044C3 RID: 17603
		private static readonly IntPtr NativeMethodInfoPtr_SendExpiryMessage_Private_Void_0;

		// Token: 0x040044C4 RID: 17604
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_CartelData_0;

		// Token: 0x040044C5 RID: 17605
		private static readonly IntPtr NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0;

		// Token: 0x040044C6 RID: 17606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044C7 RID: 17607
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040044C8 RID: 17608
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040044C9 RID: 17609
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040044CA RID: 17610
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0;

		// Token: 0x040044CB RID: 17611
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0;

		// Token: 0x040044CC RID: 17612
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044CD RID: 17613
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeDealQuest_2137933519_Private_Void_NetworkConnection_CartelDealInfo_0;

		// Token: 0x040044CE RID: 17614
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeDealQuest_2137933519_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044CF RID: 17615
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000B3C RID: 2876
		[ObfuscatedName("ScheduleOne.Cartel.CartelDealManager+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E6DA RID: 59098 RVA: 0x00384F38 File Offset: 0x00383138
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelDealManager>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr);
				CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr, "amount");
				CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				CartelDealManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr, 100676405);
				CartelDealManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr, 100676406);
			}

			// Token: 0x0600E6DB RID: 59099 RVA: 0x00384FB4 File Offset: 0x003831B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6DC RID: 59100 RVA: 0x00384FF0 File Offset: 0x003831F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209501, XrefRangeEnd = 209506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E6DD RID: 59101 RVA: 0x0006CE0D File Offset: 0x0006B00D
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004610 RID: 17936
			// (get) Token: 0x0600E6DE RID: 59102 RVA: 0x00385030 File Offset: 0x00383230
			// (set) Token: 0x0600E6DF RID: 59103 RVA: 0x0006CE16 File Offset: 0x0006B016
			public unsafe float amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17004611 RID: 17937
			// (get) Token: 0x0600E6E0 RID: 59104 RVA: 0x00385058 File Offset: 0x00383258
			// (set) Token: 0x0600E6E1 RID: 59105 RVA: 0x0006CE31 File Offset: 0x0006B031
			public unsafe CartelDealManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CB7 RID: 40119
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04009CB8 RID: 40120
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009CB9 RID: 40121
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CBA RID: 40122
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000DDD RID: 3549
			[ObfuscatedName("ScheduleOne.Cartel.CartelDealManager+<>c__DisplayClass35_0+<<DepositCash>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601001A RID: 65562 RVA: 0x003CDD1C File Offset: 0x003CBF1C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0>.NativeClassPtr, "<<DepositCash>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676407);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676408);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676409);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676410);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676411);
					CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100676412);
				}

				// Token: 0x0601001B RID: 65563 RVA: 0x003CDDFC File Offset: 0x003CBFFC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601001C RID: 65564 RVA: 0x003CDE44 File Offset: 0x003CC044
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601001D RID: 65565 RVA: 0x003CDE78 File Offset: 0x003CC078
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209465, XrefRangeEnd = 209496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E05 RID: 19973
				// (get) Token: 0x0601001E RID: 65566 RVA: 0x003CDEB4 File Offset: 0x003CC0B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601001F RID: 65567 RVA: 0x003CDEF4 File Offset: 0x003CC0F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209496, XrefRangeEnd = 209501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E06 RID: 19974
				// (get) Token: 0x06010020 RID: 65568 RVA: 0x003CDF28 File Offset: 0x003CC128
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010021 RID: 65569 RVA: 0x000795F5 File Offset: 0x000777F5
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E02 RID: 19970
				// (get) Token: 0x06010022 RID: 65570 RVA: 0x003CDF68 File Offset: 0x003CC168
				// (set) Token: 0x06010023 RID: 65571 RVA: 0x000795FE File Offset: 0x000777FE
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E03 RID: 19971
				// (get) Token: 0x06010024 RID: 65572 RVA: 0x003CDF90 File Offset: 0x003CC190
				// (set) Token: 0x06010025 RID: 65573 RVA: 0x00079619 File Offset: 0x00077819
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E04 RID: 19972
				// (get) Token: 0x06010026 RID: 65574 RVA: 0x003CDFC0 File Offset: 0x003CC1C0
				// (set) Token: 0x06010027 RID: 65575 RVA: 0x00079638 File Offset: 0x00077838
				public unsafe CartelDealManager.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealManager.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelDealManager.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AC84 RID: 44164
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AC85 RID: 44165
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AC86 RID: 44166
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AC87 RID: 44167
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AC88 RID: 44168
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC89 RID: 44169
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AC8A RID: 44170
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AC8B RID: 44171
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AC8C RID: 44172
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
