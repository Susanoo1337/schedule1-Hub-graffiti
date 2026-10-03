using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Phone.Delivery;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200041A RID: 1050
	public class DeliveryManager : NetworkSingleton<DeliveryManager>
	{
		// Token: 0x06005C7D RID: 23677 RVA: 0x001B9ED4 File Offset: 0x001B80D4
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryManager()
		{
			Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr);
			DeliveryManager.NativeFieldInfoPtr_Deliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "Deliveries");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCreated");
			DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "onDeliveryCompleted");
			DeliveryManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "loader");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr_writtenVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "writtenVehicles");
			DeliveryManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			DeliveryManager.NativeFieldInfoPtr__deliveryHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "_deliveryHistory");
			DeliveryManager.NativeFieldInfoPtr__displayedDeliveryHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "_displayedDeliveryHistory");
			DeliveryManager.NativeFieldInfoPtr__minsSinceVehicleEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "_minsSinceVehicleEmpty");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted");
			DeliveryManager.NativeMethodInfoPtr_add_onDeliveryCreated_Public_add_Void_Action_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675366);
			DeliveryManager.NativeMethodInfoPtr_remove_onDeliveryCreated_Public_rem_Void_Action_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675367);
			DeliveryManager.NativeMethodInfoPtr_add_onDeliveryCompleted_Public_add_Void_Action_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675368);
			DeliveryManager.NativeMethodInfoPtr_remove_onDeliveryCompleted_Public_rem_Void_Action_1_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675369);
			DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675370);
			DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675371);
			DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675372);
			DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675373);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675374);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675375);
			DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675376);
			DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675377);
			DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675378);
			DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675379);
			DeliveryManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675380);
			DeliveryManager.NativeMethodInfoPtr_get_DisplayedDeliveryHistory_Public_get_List_1_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675381);
			DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675382);
			DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675383);
			DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675384);
			DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675385);
			DeliveryManager.NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675386);
			DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675387);
			DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675388);
			DeliveryManager.NativeMethodInfoPtr_RecordDeliveryReceipt_Server_Public_Void_DeliveryReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675389);
			DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675390);
			DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675391);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675392);
			DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675393);
			DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675394);
			DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675395);
			DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675396);
			DeliveryManager.NativeMethodInfoPtr_Load_Public_Void_DeliveriesData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675397);
			DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675398);
			DeliveryManager.NativeMethodInfoPtr__Start_b__38_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675399);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675400);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675401);
			DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675402);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675403);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675404);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675405);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_DeliveryReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675406);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___RecordDeliveryReceipt_Server_2582461062_Public_Void_DeliveryReceipt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675407);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675408);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675409);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675410);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675411);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675412);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675413);
			DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675414);
			DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675415);
			DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675416);
			DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, 100675417);
		}

		// Token: 0x06005C7E RID: 23678 RVA: 0x001BA42C File Offset: 0x001B862C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198558, RefRangeEnd = 198559, XrefRangeStart = 198553, XrefRangeEnd = 198558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onDeliveryCreated(Action<DeliveryInstance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_add_onDeliveryCreated_Public_add_Void_Action_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C7F RID: 23679 RVA: 0x001BA470 File Offset: 0x001B8670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198559, XrefRangeEnd = 198564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onDeliveryCreated(Action<DeliveryInstance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_remove_onDeliveryCreated_Public_rem_Void_Action_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C80 RID: 23680 RVA: 0x001BA4B4 File Offset: 0x001B86B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198569, RefRangeEnd = 198570, XrefRangeStart = 198564, XrefRangeEnd = 198569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onDeliveryCompleted(Action<DeliveryInstance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_add_onDeliveryCompleted_Public_add_Void_Action_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x001BA4F8 File Offset: 0x001B86F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198570, XrefRangeEnd = 198575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onDeliveryCompleted(Action<DeliveryInstance> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_remove_onDeliveryCompleted_Public_rem_Void_Action_1_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06005C82 RID: 23682 RVA: 0x001BA53C File Offset: 0x001B873C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198575, XrefRangeEnd = 198577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06005C83 RID: 23683 RVA: 0x001BA574 File Offset: 0x001B8774
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198577, XrefRangeEnd = 198579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06005C84 RID: 23684 RVA: 0x001BA5AC File Offset: 0x001B87AC
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06005C85 RID: 23685 RVA: 0x001BA5EC File Offset: 0x001B87EC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06005C86 RID: 23686 RVA: 0x001BA628 File Offset: 0x001B8828
		// (set) Token: 0x06005C87 RID: 23687 RVA: 0x001BA668 File Offset: 0x001B8868
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06005C88 RID: 23688 RVA: 0x001BA6AC File Offset: 0x001B88AC
		// (set) Token: 0x06005C89 RID: 23689 RVA: 0x001BA6EC File Offset: 0x001B88EC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94584, XrefRangeEnd = 94585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x001BA730 File Offset: 0x001B8930
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x001BA76C File Offset: 0x001B896C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001BA7AC File Offset: 0x001B89AC
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06005C8D RID: 23693 RVA: 0x001BA7E8 File Offset: 0x001B89E8
		public unsafe List<DeliveryReceipt> DisplayedDeliveryHistory
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 198582, RefRangeEnd = 198584, XrefRangeStart = 198579, XrefRangeEnd = 198582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_get_DisplayedDeliveryHistory_Public_get_List_1_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DeliveryReceipt>>(intPtr3) : null;
			}
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x001BA828 File Offset: 0x001B8A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198584, XrefRangeEnd = 198587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x001BA864 File Offset: 0x001B8A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198587, XrefRangeEnd = 198621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x001BA8A0 File Offset: 0x001B8AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198621, XrefRangeEnd = 198627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x001BA8DC File Offset: 0x001B8ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198627, XrefRangeEnd = 198646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x001BA92C File Offset: 0x001B8B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198683, RefRangeEnd = 198684, XrefRangeStart = 198646, XrefRangeEnd = 198683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimePass(int minutes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C93 RID: 23699 RVA: 0x001BA96C File Offset: 0x001B8B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198688, RefRangeEnd = 198689, XrefRangeStart = 198684, XrefRangeEnd = 198688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLoadingBayFree(Property destination, int loadingDockIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadingDockIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x001BA9C8 File Offset: 0x001B8BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198711, RefRangeEnd = 198712, XrefRangeStart = 198689, XrefRangeEnd = 198711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendDelivery(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x001BAA0C File Offset: 0x001B8C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198723, RefRangeEnd = 198724, XrefRangeStart = 198712, XrefRangeEnd = 198723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordDeliveryReceipt_Server(DeliveryReceipt receipt, string originalOrderID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalOrderID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RecordDeliveryReceipt_Server_Public_Void_DeliveryReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x001BAA60 File Offset: 0x001B8C60
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 198763, RefRangeEnd = 198768, XrefRangeStart = 198724, XrefRangeEnd = 198763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C97 RID: 23703 RVA: 0x001BAAB4 File Offset: 0x001B8CB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198791, RefRangeEnd = 198793, XrefRangeStart = 198768, XrefRangeEnd = 198791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeliveryState(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C98 RID: 23704 RVA: 0x001BAB04 File Offset: 0x001B8D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 198808, RefRangeEnd = 198810, XrefRangeStart = 198793, XrefRangeEnd = 198808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(string deliveryID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06005C99 RID: 23705 RVA: 0x001BAB54 File Offset: 0x001B8D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198810, XrefRangeEnd = 198825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetDelivery(Property destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06005C9A RID: 23706 RVA: 0x001BABA4 File Offset: 0x001B8DA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 198840, RefRangeEnd = 198843, XrefRangeStart = 198825, XrefRangeEnd = 198840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryInstance GetActiveShopDelivery(DeliveryShop shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x001BABF4 File Offset: 0x001B8DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198843, XrefRangeEnd = 198862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface GetShopInterface(string shopName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x001BAC44 File Offset: 0x001B8E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198862, XrefRangeEnd = 198904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x001BAC88 File Offset: 0x001B8E88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198931, RefRangeEnd = 198932, XrefRangeStart = 198904, XrefRangeEnd = 198931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(DeliveriesData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_Load_Public_Void_DeliveriesData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x001BACCC File Offset: 0x001B8ECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198932, XrefRangeEnd = 198983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x001BAD08 File Offset: 0x001B8F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198983, XrefRangeEnd = 198984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__38_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr__Start_b__38_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x001BAD3C File Offset: 0x001B8F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198984, XrefRangeEnd = 199021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x001BAD78 File Offset: 0x001B8F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199021, XrefRangeEnd = 199024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x001BADB4 File Offset: 0x001B8FB4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x001BADF0 File Offset: 0x001B8FF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199024, XrefRangeEnd = 199034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x001BAE34 File Offset: 0x001B9034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199034, XrefRangeEnd = 199035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x001BAE78 File Offset: 0x001B9078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199035, XrefRangeEnd = 199039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x001BAEDC File Offset: 0x001B90DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 198723, RefRangeEnd = 198724, XrefRangeStart = 198723, XrefRangeEnd = 198724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RecordDeliveryReceipt_Server_2582461062(DeliveryReceipt receipt, string originalOrderID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalOrderID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_DeliveryReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x001BAF30 File Offset: 0x001B9130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199106, RefRangeEnd = 199107, XrefRangeStart = 199039, XrefRangeEnd = 199106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RecordDeliveryReceipt_Server_2582461062(DeliveryReceipt receipt, string originalOrderID = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalOrderID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___RecordDeliveryReceipt_Server_2582461062_Public_Void_DeliveryReceipt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x001BAF84 File Offset: 0x001B9184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199107, XrefRangeEnd = 199111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RecordDeliveryReceipt_Server_2582461062(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x001BAFE8 File Offset: 0x001B91E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199111, XrefRangeEnd = 199121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x001BB03C File Offset: 0x001B923C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199128, RefRangeEnd = 199131, XrefRangeStart = 199121, XrefRangeEnd = 199128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x001BB090 File Offset: 0x001B9290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199131, XrefRangeEnd = 199135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x001BB0E0 File Offset: 0x001B92E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199135, XrefRangeEnd = 199145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(delivery);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x001BB134 File Offset: 0x001B9334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199145, XrefRangeEnd = 199149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x001BB184 File Offset: 0x001B9384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199149, XrefRangeEnd = 199160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CAF RID: 23727 RVA: 0x001BB1D4 File Offset: 0x001B93D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199177, RefRangeEnd = 199179, XrefRangeStart = 199160, XrefRangeEnd = 199177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(deliveryID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB0 RID: 23728 RVA: 0x001BB224 File Offset: 0x001B9424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199179, XrefRangeEnd = 199184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB1 RID: 23729 RVA: 0x001BB274 File Offset: 0x001B9474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199184, XrefRangeEnd = 199187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeliveryManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x0002BDA7 File Offset: 0x00029FA7
		public DeliveryManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005CB3 RID: 23731 RVA: 0x001BB2B0 File Offset: 0x001B94B0
		// (set) Token: 0x06005CB4 RID: 23732 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		public unsafe List<DeliveryInstance> Deliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_Deliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005CB5 RID: 23733 RVA: 0x001BB2E0 File Offset: 0x001B94E0
		// (set) Token: 0x06005CB6 RID: 23734 RVA: 0x0002BDCF File Offset: 0x00029FCF
		public unsafe Action<DeliveryInstance> onDeliveryCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCreated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06005CB7 RID: 23735 RVA: 0x001BB310 File Offset: 0x001B9510
		// (set) Token: 0x06005CB8 RID: 23736 RVA: 0x0002BDEE File Offset: 0x00029FEE
		public unsafe Action<DeliveryInstance> onDeliveryCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_onDeliveryCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06005CB9 RID: 23737 RVA: 0x001BB340 File Offset: 0x001B9540
		// (set) Token: 0x06005CBA RID: 23738 RVA: 0x0002BE0D File Offset: 0x0002A00D
		public unsafe DeliveriesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveriesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005CBB RID: 23739 RVA: 0x001BB370 File Offset: 0x001B9570
		// (set) Token: 0x06005CBC RID: 23740 RVA: 0x0002BE2C File Offset: 0x0002A02C
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005CBD RID: 23741 RVA: 0x001BB3A0 File Offset: 0x001B95A0
		// (set) Token: 0x06005CBE RID: 23742 RVA: 0x0002BE4B File Offset: 0x0002A04B
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06005CBF RID: 23743 RVA: 0x001BB3D0 File Offset: 0x001B95D0
		// (set) Token: 0x06005CC0 RID: 23744 RVA: 0x0002BE6A File Offset: 0x0002A06A
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x001BB3F8 File Offset: 0x001B95F8
		// (set) Token: 0x06005CC2 RID: 23746 RVA: 0x0002BE85 File Offset: 0x0002A085
		public unsafe List<string> writtenVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_writtenVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x06005CC3 RID: 23747 RVA: 0x001BB428 File Offset: 0x001B9628
		// (set) Token: 0x06005CC4 RID: 23748 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06005CC5 RID: 23749 RVA: 0x001BB450 File Offset: 0x001B9650
		// (set) Token: 0x06005CC6 RID: 23750 RVA: 0x0002BEBF File Offset: 0x0002A0BF
		public unsafe SyncList<DeliveryReceipt> _deliveryHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__deliveryHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<DeliveryReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__deliveryHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06005CC7 RID: 23751 RVA: 0x001BB480 File Offset: 0x001B9680
		// (set) Token: 0x06005CC8 RID: 23752 RVA: 0x0002BEDE File Offset: 0x0002A0DE
		public unsafe SyncList<DeliveryReceipt> _displayedDeliveryHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__displayedDeliveryHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<DeliveryReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__displayedDeliveryHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06005CC9 RID: 23753 RVA: 0x001BB4B0 File Offset: 0x001B96B0
		// (set) Token: 0x06005CCA RID: 23754 RVA: 0x0002BEFD File Offset: 0x0002A0FD
		public unsafe Dictionary<DeliveryInstance, int> _minsSinceVehicleEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__minsSinceVehicleEmpty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<DeliveryInstance, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr__minsSinceVehicleEmpty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x001BB4E0 File Offset: 0x001B96E0
		// (set) Token: 0x06005CCC RID: 23756 RVA: 0x0002BF1C File Offset: 0x0002A11C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06005CCD RID: 23757 RVA: 0x001BB508 File Offset: 0x001B9708
		// (set) Token: 0x06005CCE RID: 23758 RVA: 0x0002BF37 File Offset: 0x0002A137
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003F6F RID: 16239
		private static readonly IntPtr NativeFieldInfoPtr_Deliveries;

		// Token: 0x04003F70 RID: 16240
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCreated;

		// Token: 0x04003F71 RID: 16241
		private static readonly IntPtr NativeFieldInfoPtr_onDeliveryCompleted;

		// Token: 0x04003F72 RID: 16242
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04003F73 RID: 16243
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04003F74 RID: 16244
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04003F75 RID: 16245
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04003F76 RID: 16246
		private static readonly IntPtr NativeFieldInfoPtr_writtenVehicles;

		// Token: 0x04003F77 RID: 16247
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04003F78 RID: 16248
		private static readonly IntPtr NativeFieldInfoPtr__deliveryHistory;

		// Token: 0x04003F79 RID: 16249
		private static readonly IntPtr NativeFieldInfoPtr__displayedDeliveryHistory;

		// Token: 0x04003F7A RID: 16250
		private static readonly IntPtr NativeFieldInfoPtr__minsSinceVehicleEmpty;

		// Token: 0x04003F7B RID: 16251
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003F7C RID: 16252
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003F7D RID: 16253
		private static readonly IntPtr NativeMethodInfoPtr_add_onDeliveryCreated_Public_add_Void_Action_1_DeliveryInstance_0;

		// Token: 0x04003F7E RID: 16254
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDeliveryCreated_Public_rem_Void_Action_1_DeliveryInstance_0;

		// Token: 0x04003F7F RID: 16255
		private static readonly IntPtr NativeMethodInfoPtr_add_onDeliveryCompleted_Public_add_Void_Action_1_DeliveryInstance_0;

		// Token: 0x04003F80 RID: 16256
		private static readonly IntPtr NativeMethodInfoPtr_remove_onDeliveryCompleted_Public_rem_Void_Action_1_DeliveryInstance_0;

		// Token: 0x04003F81 RID: 16257
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003F82 RID: 16258
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04003F83 RID: 16259
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04003F84 RID: 16260
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003F85 RID: 16261
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003F86 RID: 16262
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003F87 RID: 16263
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04003F88 RID: 16264
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04003F89 RID: 16265
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04003F8A RID: 16266
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04003F8B RID: 16267
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04003F8C RID: 16268
		private static readonly IntPtr NativeMethodInfoPtr_get_DisplayedDeliveryHistory_Public_get_List_1_DeliveryReceipt_0;

		// Token: 0x04003F8D RID: 16269
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003F8E RID: 16270
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04003F8F RID: 16271
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04003F90 RID: 16272
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003F91 RID: 16273
		private static readonly IntPtr NativeMethodInfoPtr_OnTimePass_Private_Void_Int32_0;

		// Token: 0x04003F92 RID: 16274
		private static readonly IntPtr NativeMethodInfoPtr_IsLoadingBayFree_Public_Boolean_Property_Int32_0;

		// Token: 0x04003F93 RID: 16275
		private static readonly IntPtr NativeMethodInfoPtr_SendDelivery_Public_Void_DeliveryInstance_0;

		// Token: 0x04003F94 RID: 16276
		private static readonly IntPtr NativeMethodInfoPtr_RecordDeliveryReceipt_Server_Public_Void_DeliveryReceipt_String_0;

		// Token: 0x04003F95 RID: 16277
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveDelivery_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04003F96 RID: 16278
		private static readonly IntPtr NativeMethodInfoPtr_SetDeliveryState_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04003F97 RID: 16279
		private static readonly IntPtr NativeMethodInfoPtr_GetDelivery_Private_DeliveryInstance_String_0;

		// Token: 0x04003F98 RID: 16280
		private static readonly IntPtr NativeMethodInfoPtr_GetDelivery_Public_DeliveryInstance_Property_0;

		// Token: 0x04003F99 RID: 16281
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveShopDelivery_Public_DeliveryInstance_DeliveryShop_0;

		// Token: 0x04003F9A RID: 16282
		private static readonly IntPtr NativeMethodInfoPtr_GetShopInterface_Public_ShopInterface_String_0;

		// Token: 0x04003F9B RID: 16283
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04003F9C RID: 16284
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_DeliveriesData_0;

		// Token: 0x04003F9D RID: 16285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003F9E RID: 16286
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__38_0_Private_Void_0;

		// Token: 0x04003F9F RID: 16287
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003FA0 RID: 16288
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003FA1 RID: 16289
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003FA2 RID: 16290
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendDelivery_2813439055_Private_Void_DeliveryInstance_0;

		// Token: 0x04003FA3 RID: 16291
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendDelivery_2813439055_Public_Void_DeliveryInstance_0;

		// Token: 0x04003FA4 RID: 16292
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendDelivery_2813439055_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FA5 RID: 16293
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_DeliveryReceipt_String_0;

		// Token: 0x04003FA6 RID: 16294
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RecordDeliveryReceipt_Server_2582461062_Public_Void_DeliveryReceipt_String_0;

		// Token: 0x04003FA7 RID: 16295
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RecordDeliveryReceipt_Server_2582461062_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003FA8 RID: 16296
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04003FA9 RID: 16297
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04003FAA RID: 16298
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FAB RID: 16299
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveDelivery_2795369214_Private_Void_NetworkConnection_DeliveryInstance_0;

		// Token: 0x04003FAC RID: 16300
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveDelivery_2795369214_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FAD RID: 16301
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04003FAE RID: 16302
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetDeliveryState_316609003_Private_Void_String_EDeliveryStatus_0;

		// Token: 0x04003FAF RID: 16303
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetDeliveryState_316609003_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003FB0 RID: 16304
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B02 RID: 2818
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass40_0")]
		public sealed class __c__DisplayClass40_0 : Object
		{
			// Token: 0x0600E572 RID: 58738 RVA: 0x00380FDC File Offset: 0x0037F1DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass40_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass40_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr_deliveryCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr, "deliveryCache");
				DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr, "<>4__this");
				DeliveryManager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr, 100675418);
				DeliveryManager.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr, 100675419);
			}

			// Token: 0x0600E573 RID: 58739 RVA: 0x00381058 File Offset: 0x0037F258
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass40_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass40_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass40_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E574 RID: 58740 RVA: 0x00381094 File Offset: 0x0037F294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198544, XrefRangeEnd = 198549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_NetworkConnection_PDM_0(NetworkConnection conn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass40_0.NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E575 RID: 58741 RVA: 0x0006C340 File Offset: 0x0006A540
			public __c__DisplayClass40_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B5 RID: 17845
			// (get) Token: 0x0600E576 RID: 58742 RVA: 0x003810D8 File Offset: 0x0037F2D8
			// (set) Token: 0x0600E577 RID: 58743 RVA: 0x0006C349 File Offset: 0x0006A549
			public unsafe Il2CppReferenceArray<DeliveryInstance> deliveryCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr_deliveryCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryInstance>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr_deliveryCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B6 RID: 17846
			// (get) Token: 0x0600E578 RID: 58744 RVA: 0x00381108 File Offset: 0x0037F308
			// (set) Token: 0x0600E579 RID: 58745 RVA: 0x0006C368 File Offset: 0x0006A568
			public unsafe DeliveryManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass40_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BC0 RID: 39872
			private static readonly IntPtr NativeFieldInfoPtr_deliveryCache;

			// Token: 0x04009BC1 RID: 39873
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BC2 RID: 39874
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BC3 RID: 39875
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_NetworkConnection_PDM_0;
		}

		// Token: 0x02000B03 RID: 2819
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass47_0")]
		public sealed class __c__DisplayClass47_0 : Object
		{
			// Token: 0x0600E57A RID: 58746 RVA: 0x00381138 File Offset: 0x0037F338
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass47_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass47_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass47_0.NativeFieldInfoPtr_deliveryID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr, "deliveryID");
				DeliveryManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr, 100675420);
				DeliveryManager.__c__DisplayClass47_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr, 100675421);
			}

			// Token: 0x0600E57B RID: 58747 RVA: 0x003811A0 File Offset: 0x0037F3A0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass47_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass47_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass47_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E57C RID: 58748 RVA: 0x003811DC File Offset: 0x0037F3DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass47_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E57D RID: 58749 RVA: 0x0006C387 File Offset: 0x0006A587
			public __c__DisplayClass47_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B7 RID: 17847
			// (get) Token: 0x0600E57E RID: 58750 RVA: 0x0038122C File Offset: 0x0037F42C
			// (set) Token: 0x0600E57F RID: 58751 RVA: 0x0006C390 File Offset: 0x0006A590
			public unsafe string deliveryID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass47_0.NativeFieldInfoPtr_deliveryID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass47_0.NativeFieldInfoPtr_deliveryID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009BC4 RID: 39876
			private static readonly IntPtr NativeFieldInfoPtr_deliveryID;

			// Token: 0x04009BC5 RID: 39877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BC6 RID: 39878
			private static readonly IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000B04 RID: 2820
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass48_0")]
		public sealed class __c__DisplayClass48_0 : Object
		{
			// Token: 0x0600E580 RID: 58752 RVA: 0x00381254 File Offset: 0x0037F454
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass48_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass48_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass48_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr, "destination");
				DeliveryManager.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr, 100675422);
				DeliveryManager.__c__DisplayClass48_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr, 100675423);
			}

			// Token: 0x0600E581 RID: 58753 RVA: 0x003812BC File Offset: 0x0037F4BC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass48_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass48_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E582 RID: 58754 RVA: 0x003812F8 File Offset: 0x0037F4F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198549, XrefRangeEnd = 198551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass48_0.NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E583 RID: 58755 RVA: 0x0006C3AF File Offset: 0x0006A5AF
			public __c__DisplayClass48_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B8 RID: 17848
			// (get) Token: 0x0600E584 RID: 58756 RVA: 0x00381348 File Offset: 0x0037F548
			// (set) Token: 0x0600E585 RID: 58757 RVA: 0x0006C3B8 File Offset: 0x0006A5B8
			public unsafe Property destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass48_0.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass48_0.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BC7 RID: 39879
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04009BC8 RID: 39880
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BC9 RID: 39881
			private static readonly IntPtr NativeMethodInfoPtr__GetDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000B05 RID: 2821
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass49_0")]
		public sealed class __c__DisplayClass49_0 : Object
		{
			// Token: 0x0600E586 RID: 58758 RVA: 0x00381378 File Offset: 0x0037F578
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass49_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass49_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass49_0.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr, "shop");
				DeliveryManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr, 100675424);
				DeliveryManager.__c__DisplayClass49_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr, 100675425);
			}

			// Token: 0x0600E587 RID: 58759 RVA: 0x003813E0 File Offset: 0x0037F5E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass49_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass49_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass49_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E588 RID: 58760 RVA: 0x0038141C File Offset: 0x0037F61C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198551, XrefRangeEnd = 198553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetActiveShopDelivery_b__0(DeliveryInstance d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass49_0.NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E589 RID: 58761 RVA: 0x0006C3D7 File Offset: 0x0006A5D7
			public __c__DisplayClass49_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045B9 RID: 17849
			// (get) Token: 0x0600E58A RID: 58762 RVA: 0x0038146C File Offset: 0x0037F66C
			// (set) Token: 0x0600E58B RID: 58763 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
			public unsafe DeliveryShop shop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass49_0.NativeFieldInfoPtr_shop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass49_0.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BCA RID: 39882
			private static readonly IntPtr NativeFieldInfoPtr_shop;

			// Token: 0x04009BCB RID: 39883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BCC RID: 39884
			private static readonly IntPtr NativeMethodInfoPtr__GetActiveShopDelivery_b__0_Internal_Boolean_DeliveryInstance_0;
		}

		// Token: 0x02000B06 RID: 2822
		[ObfuscatedName("ScheduleOne.Delivery.DeliveryManager+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Object
		{
			// Token: 0x0600E58C RID: 58764 RVA: 0x0038149C File Offset: 0x0037F69C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryManager>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr);
				DeliveryManager.__c__DisplayClass50_0.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr, "shopName");
				DeliveryManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr, 100675426);
				DeliveryManager.__c__DisplayClass50_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr, 100675427);
			}

			// Token: 0x0600E58D RID: 58765 RVA: 0x00381504 File Offset: 0x0037F704
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryManager.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E58E RID: 58766 RVA: 0x00381540 File Offset: 0x0037F740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetShopInterface_b__0(ShopInterface x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryManager.__c__DisplayClass50_0.NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E58F RID: 58767 RVA: 0x0006C3FF File Offset: 0x0006A5FF
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045BA RID: 17850
			// (get) Token: 0x0600E590 RID: 58768 RVA: 0x00381590 File Offset: 0x0037F790
			// (set) Token: 0x0600E591 RID: 58769 RVA: 0x0006C408 File Offset: 0x0006A608
			public unsafe string shopName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass50_0.NativeFieldInfoPtr_shopName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryManager.__c__DisplayClass50_0.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009BCD RID: 39885
			private static readonly IntPtr NativeFieldInfoPtr_shopName;

			// Token: 0x04009BCE RID: 39886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BCF RID: 39887
			private static readonly IntPtr NativeMethodInfoPtr__GetShopInterface_b__0_Internal_Boolean_ShopInterface_0;
		}
	}
}
