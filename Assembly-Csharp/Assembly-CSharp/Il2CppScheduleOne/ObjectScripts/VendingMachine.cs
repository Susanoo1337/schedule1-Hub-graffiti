using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005BC RID: 1468
	public class VendingMachine : NetworkBehaviour
	{
		// Token: 0x06008DD8 RID: 36312 RVA: 0x00267F8C File Offset: 0x0026618C
		// Note: this type is marked as 'beforefieldinit'.
		static VendingMachine()
		{
			Il2CppClassPointerStore<VendingMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "VendingMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr);
			VendingMachine.NativeFieldInfoPtr_AllMachines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AllMachines");
			VendingMachine.NativeFieldInfoPtr_COST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "COST");
			VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "REPAIR_TIME_DAYS");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_FREE_ITEM_CHANCE");
			VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IMPACT_THRESHOLD_BREAK");
			VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MIN_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "MAX_CASH_DROP");
			VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<IsBroken>k__BackingField");
			VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<DaysUntilRepair>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_LitStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitStartTime");
			VendingMachine.NativeFieldInfoPtr_LitOnEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "LitOnEndTime");
			VendingMachine.NativeFieldInfoPtr_CukePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CukePrefab");
			VendingMachine.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashPrefab");
			VendingMachine.NativeFieldInfoPtr_DoorMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DoorMesh");
			VendingMachine.NativeFieldInfoPtr_PaySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "PaySound");
			VendingMachine.NativeFieldInfoPtr_DispenseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "DispenseSound");
			VendingMachine.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Anim");
			VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "ItemSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "IntObj");
			VendingMachine.NativeFieldInfoPtr_AccessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "AccessPoint");
			VendingMachine.NativeFieldInfoPtr_Damageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Damageable");
			VendingMachine.NativeFieldInfoPtr_CashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "CashSpawnPoint");
			VendingMachine.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "Lights");
			VendingMachine.NativeFieldInfoPtr_onBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onBreak");
			VendingMachine.NativeFieldInfoPtr_onRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "onRepair");
			VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<lastDroppedItem>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_isLit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "isLit");
			VendingMachine.NativeFieldInfoPtr_purchaseInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "purchaseInProgress");
			VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "timeOnLastFreeItem");
			VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<GUID>k__BackingField");
			VendingMachine.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "BakedGUID");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.VendingMachineAssembly-CSharp.dll_Excuted");
			VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681666);
			VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681667);
			VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681668);
			VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681669);
			VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_NetworkedItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681670);
			VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_NetworkedItemPickup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681671);
			VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681672);
			VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681673);
			VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681674);
			VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681675);
			VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681676);
			VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681677);
			VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681678);
			VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681679);
			VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681680);
			VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681681);
			VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681682);
			VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681683);
			VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681684);
			VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681685);
			VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681686);
			VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681687);
			VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681688);
			VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681689);
			VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681690);
			VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681691);
			VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681692);
			VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681693);
			VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681694);
			VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681695);
			VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681696);
			VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681697);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681699);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681700);
			VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681701);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681702);
			VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681703);
			VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681704);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681705);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681706);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681707);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681708);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681709);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681710);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681711);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681712);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681713);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681714);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681715);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681716);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681717);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681718);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681719);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681720);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681721);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681722);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681723);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681724);
			VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681725);
			VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681726);
			VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681727);
			VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, 100681728);
		}

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06008DD9 RID: 36313 RVA: 0x0026873C File Offset: 0x0026693C
		// (set) Token: 0x06008DDA RID: 36314 RVA: 0x00268778 File Offset: 0x00266978
		public unsafe bool IsBroken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06008DDB RID: 36315 RVA: 0x002687B8 File Offset: 0x002669B8
		// (set) Token: 0x06008DDC RID: 36316 RVA: 0x002687F4 File Offset: 0x002669F4
		public unsafe int DaysUntilRepair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x06008DDD RID: 36317 RVA: 0x00268834 File Offset: 0x00266A34
		// (set) Token: 0x06008DDE RID: 36318 RVA: 0x00268874 File Offset: 0x00266A74
		public unsafe NetworkedItemPickup lastDroppedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_lastDroppedItem_Public_get_NetworkedItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261783, XrefRangeEnd = 261784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_NetworkedItemPickup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06008DDF RID: 36319 RVA: 0x002688B8 File Offset: 0x00266AB8
		// (set) Token: 0x06008DE0 RID: 36320 RVA: 0x002688F4 File Offset: 0x00266AF4
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x00268934 File Offset: 0x00266B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261784, XrefRangeEnd = 261787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x00268968 File Offset: 0x00266B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261787, XrefRangeEnd = 261788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x002689A4 File Offset: 0x00266BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261788, XrefRangeEnd = 261823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x002689D8 File Offset: 0x00266BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261823, XrefRangeEnd = 261825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x00268A28 File Offset: 0x00266C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261825, XrefRangeEnd = 261829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x00268A68 File Offset: 0x00266C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261829, XrefRangeEnd = 261860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x00268A9C File Offset: 0x00266C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261860, XrefRangeEnd = 261866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_MinPass_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x00268AD0 File Offset: 0x00266CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261866, XrefRangeEnd = 261883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DayPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE9 RID: 36329 RVA: 0x00268B04 File Offset: 0x00266D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261883, XrefRangeEnd = 261891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DEA RID: 36330 RVA: 0x00268B38 File Offset: 0x00266D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261891, XrefRangeEnd = 261896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DEB RID: 36331 RVA: 0x00268B6C File Offset: 0x00266D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261922, RefRangeEnd = 261923, XrefRangeStart = 261896, XrefRangeEnd = 261922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LocalPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_LocalPurchase_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DEC RID: 36332 RVA: 0x00268BA0 File Offset: 0x00266DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261923, XrefRangeEnd = 261944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPurchase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendPurchase_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DED RID: 36333 RVA: 0x00268BD4 File Offset: 0x00266DD4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261965, RefRangeEnd = 261968, XrefRangeStart = 261944, XrefRangeEnd = 261965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PurchaseRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DEE RID: 36334 RVA: 0x00268C08 File Offset: 0x00266E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261968, XrefRangeEnd = 261977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x00268C3C File Offset: 0x00266E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261977, XrefRangeEnd = 261987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLastDropped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00268C70 File Offset: 0x00266E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261987, XrefRangeEnd = 261999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Impacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x00268CB4 File Offset: 0x00266EB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262001, RefRangeEnd = 262006, XrefRangeStart = 261999, XrefRangeEnd = 262001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLit(bool lit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x00268CF4 File Offset: 0x00266EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262006, XrefRangeEnd = 262027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_SendBreak_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x00268D28 File Offset: 0x00266F28
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262065, RefRangeEnd = 262070, XrefRangeStart = 262027, XrefRangeEnd = 262065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF4 RID: 36340 RVA: 0x00268D6C File Offset: 0x00266F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262070, XrefRangeEnd = 262079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Repair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Repair_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x00268DA0 File Offset: 0x00266FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262079, XrefRangeEnd = 262088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_DropCash_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x00268DD4 File Offset: 0x00266FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262088, XrefRangeEnd = 262095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x00268E18 File Offset: 0x00267018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262095, XrefRangeEnd = 262106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x00268E58 File Offset: 0x00267058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262106, XrefRangeEnd = 262110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendingMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DF9 RID: 36345 RVA: 0x00268E94 File Offset: 0x00267094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262110, XrefRangeEnd = 262115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008DFA RID: 36346 RVA: 0x00268ED4 File Offset: 0x002670D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262115, XrefRangeEnd = 262120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x00268F14 File Offset: 0x00267114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262120, XrefRangeEnd = 262125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008DFC RID: 36348 RVA: 0x00268F54 File Offset: 0x00267154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262125, XrefRangeEnd = 262175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DFD RID: 36349 RVA: 0x00268F90 File Offset: 0x00267190
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00268FCC File Offset: 0x002671CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendingMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DFF RID: 36351 RVA: 0x00269008 File Offset: 0x00267208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262175, XrefRangeEnd = 262184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E00 RID: 36352 RVA: 0x0026903C File Offset: 0x0026723C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261965, RefRangeEnd = 261968, XrefRangeStart = 261965, XrefRangeEnd = 261968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPurchase_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x00269070 File Offset: 0x00267270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262184, XrefRangeEnd = 262187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPurchase_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E02 RID: 36354 RVA: 0x002690D4 File Offset: 0x002672D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262187, XrefRangeEnd = 262196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E03 RID: 36355 RVA: 0x00269108 File Offset: 0x00267308
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 262206, RefRangeEnd = 262209, XrefRangeStart = 262196, XrefRangeEnd = 262206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PurchaseRoutine_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x0026913C File Offset: 0x0026733C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262209, XrefRangeEnd = 262212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PurchaseRoutine_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x0026918C File Offset: 0x0026738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x002691C0 File Offset: 0x002673C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262212, XrefRangeEnd = 262224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropItem_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x002691F4 File Offset: 0x002673F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262224, XrefRangeEnd = 262236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropItem_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x00269258 File Offset: 0x00267458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262236, XrefRangeEnd = 262245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x0026928C File Offset: 0x0026748C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262245, XrefRangeEnd = 262246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x002692C0 File Offset: 0x002674C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262246, XrefRangeEnd = 262249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00269324 File Offset: 0x00267524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262249, XrefRangeEnd = 262258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x00269368 File Offset: 0x00267568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262258, XrefRangeEnd = 262260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0D RID: 36365 RVA: 0x002693AC File Offset: 0x002675AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262260, XrefRangeEnd = 262264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0E RID: 36366 RVA: 0x002693FC File Offset: 0x002675FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262264, XrefRangeEnd = 262273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E0F RID: 36367 RVA: 0x00269440 File Offset: 0x00267640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262273, XrefRangeEnd = 262277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x00269490 File Offset: 0x00267690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x002694C4 File Offset: 0x002676C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262277, XrefRangeEnd = 262284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x002694F8 File Offset: 0x002676F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262284, XrefRangeEnd = 262292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x00269548 File Offset: 0x00267748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E14 RID: 36372 RVA: 0x0026957C File Offset: 0x0026777C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262314, RefRangeEnd = 262315, XrefRangeStart = 262292, XrefRangeEnd = 262314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E15 RID: 36373 RVA: 0x002695B0 File Offset: 0x002677B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262315, XrefRangeEnd = 262317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x00269614 File Offset: 0x00267814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262350, RefRangeEnd = 262351, XrefRangeStart = 262317, XrefRangeEnd = 262350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x00043122 File Offset: 0x00041322
		public VendingMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06008E18 RID: 36376 RVA: 0x00269648 File Offset: 0x00267848
		// (set) Token: 0x06008E19 RID: 36377 RVA: 0x0004312B File Offset: 0x0004132B
		public unsafe static List<VendingMachine> AllMachines
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_AllMachines, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VendingMachine>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_AllMachines, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x06008E1A RID: 36378 RVA: 0x00269670 File Offset: 0x00267870
		// (set) Token: 0x06008E1B RID: 36379 RVA: 0x0004313D File Offset: 0x0004133D
		public unsafe static float COST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_COST, (void*)(&value));
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06008E1C RID: 36380 RVA: 0x0026968C File Offset: 0x0026788C
		// (set) Token: 0x06008E1D RID: 36381 RVA: 0x0004314B File Offset: 0x0004134B
		public unsafe static int REPAIR_TIME_DAYS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_REPAIR_TIME_DAYS, (void*)(&value));
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06008E1E RID: 36382 RVA: 0x002696A8 File Offset: 0x002678A8
		// (set) Token: 0x06008E1F RID: 36383 RVA: 0x00043159 File Offset: 0x00041359
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM, (void*)(&value));
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06008E20 RID: 36384 RVA: 0x002696C4 File Offset: 0x002678C4
		// (set) Token: 0x06008E21 RID: 36385 RVA: 0x00043167 File Offset: 0x00041367
		public unsafe static float IMPACT_THRESHOLD_FREE_ITEM_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06008E22 RID: 36386 RVA: 0x002696E0 File Offset: 0x002678E0
		// (set) Token: 0x06008E23 RID: 36387 RVA: 0x00043175 File Offset: 0x00041375
		public unsafe static float IMPACT_THRESHOLD_BREAK
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK, (void*)(&value));
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06008E24 RID: 36388 RVA: 0x002696FC File Offset: 0x002678FC
		// (set) Token: 0x06008E25 RID: 36389 RVA: 0x00043183 File Offset: 0x00041383
		public unsafe static int MIN_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MIN_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06008E26 RID: 36390 RVA: 0x00269718 File Offset: 0x00267918
		// (set) Token: 0x06008E27 RID: 36391 RVA: 0x00043191 File Offset: 0x00041391
		public unsafe static int MAX_CASH_DROP
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VendingMachine.NativeFieldInfoPtr_MAX_CASH_DROP, (void*)(&value));
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x00269734 File Offset: 0x00267934
		// (set) Token: 0x06008E29 RID: 36393 RVA: 0x0004319F File Offset: 0x0004139F
		public unsafe bool _IsBroken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__IsBroken_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06008E2A RID: 36394 RVA: 0x0026975C File Offset: 0x0026795C
		// (set) Token: 0x06008E2B RID: 36395 RVA: 0x000431BA File Offset: 0x000413BA
		public unsafe int _DaysUntilRepair_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00269784 File Offset: 0x00267984
		// (set) Token: 0x06008E2D RID: 36397 RVA: 0x000431D5 File Offset: 0x000413D5
		public unsafe int LitStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitStartTime)) = value;
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06008E2E RID: 36398 RVA: 0x002697AC File Offset: 0x002679AC
		// (set) Token: 0x06008E2F RID: 36399 RVA: 0x000431F0 File Offset: 0x000413F0
		public unsafe int LitOnEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_LitOnEndTime)) = value;
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06008E30 RID: 36400 RVA: 0x002697D4 File Offset: 0x002679D4
		// (set) Token: 0x06008E31 RID: 36401 RVA: 0x0004320B File Offset: 0x0004140B
		public unsafe NetworkedItemPickup CukePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CukePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06008E32 RID: 36402 RVA: 0x00269804 File Offset: 0x00267A04
		// (set) Token: 0x06008E33 RID: 36403 RVA: 0x0004322A File Offset: 0x0004142A
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06008E34 RID: 36404 RVA: 0x00269834 File Offset: 0x00267A34
		// (set) Token: 0x06008E35 RID: 36405 RVA: 0x00043249 File Offset: 0x00041449
		public unsafe MeshRenderer DoorMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DoorMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06008E36 RID: 36406 RVA: 0x00269864 File Offset: 0x00267A64
		// (set) Token: 0x06008E37 RID: 36407 RVA: 0x00043268 File Offset: 0x00041468
		public unsafe AudioSourceController PaySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_PaySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06008E38 RID: 36408 RVA: 0x00269894 File Offset: 0x00267A94
		// (set) Token: 0x06008E39 RID: 36409 RVA: 0x00043287 File Offset: 0x00041487
		public unsafe AudioSourceController DispenseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_DispenseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06008E3A RID: 36410 RVA: 0x002698C4 File Offset: 0x00267AC4
		// (set) Token: 0x06008E3B RID: 36411 RVA: 0x000432A6 File Offset: 0x000414A6
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06008E3C RID: 36412 RVA: 0x002698F4 File Offset: 0x00267AF4
		// (set) Token: 0x06008E3D RID: 36413 RVA: 0x000432C5 File Offset: 0x000414C5
		public unsafe Transform ItemSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_ItemSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06008E3E RID: 36414 RVA: 0x00269924 File Offset: 0x00267B24
		// (set) Token: 0x06008E3F RID: 36415 RVA: 0x000432E4 File Offset: 0x000414E4
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06008E40 RID: 36416 RVA: 0x00269954 File Offset: 0x00267B54
		// (set) Token: 0x06008E41 RID: 36417 RVA: 0x00043303 File Offset: 0x00041503
		public unsafe Transform AccessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_AccessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06008E42 RID: 36418 RVA: 0x00269984 File Offset: 0x00267B84
		// (set) Token: 0x06008E43 RID: 36419 RVA: 0x00043322 File Offset: 0x00041522
		public unsafe PhysicsDamageable Damageable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsDamageable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Damageable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06008E44 RID: 36420 RVA: 0x002699B4 File Offset: 0x00267BB4
		// (set) Token: 0x06008E45 RID: 36421 RVA: 0x00043341 File Offset: 0x00041541
		public unsafe Transform CashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_CashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06008E46 RID: 36422 RVA: 0x002699E4 File Offset: 0x00267BE4
		// (set) Token: 0x06008E47 RID: 36423 RVA: 0x00043360 File Offset: 0x00041560
		public unsafe Il2CppReferenceArray<ToggleableLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06008E48 RID: 36424 RVA: 0x00269A14 File Offset: 0x00267C14
		// (set) Token: 0x06008E49 RID: 36425 RVA: 0x0004337F File Offset: 0x0004157F
		public unsafe UnityEvent onBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0A RID: 11274
		// (get) Token: 0x06008E4A RID: 36426 RVA: 0x00269A44 File Offset: 0x00267C44
		// (set) Token: 0x06008E4B RID: 36427 RVA: 0x0004339E File Offset: 0x0004159E
		public unsafe UnityEvent onRepair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_onRepair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0B RID: 11275
		// (get) Token: 0x06008E4C RID: 36428 RVA: 0x00269A74 File Offset: 0x00267C74
		// (set) Token: 0x06008E4D RID: 36429 RVA: 0x000433BD File Offset: 0x000415BD
		public unsafe NetworkedItemPickup _lastDroppedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__lastDroppedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C0C RID: 11276
		// (get) Token: 0x06008E4E RID: 36430 RVA: 0x00269AA4 File Offset: 0x00267CA4
		// (set) Token: 0x06008E4F RID: 36431 RVA: 0x000433DC File Offset: 0x000415DC
		public unsafe bool isLit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_isLit)) = value;
			}
		}

		// Token: 0x17002C0D RID: 11277
		// (get) Token: 0x06008E50 RID: 36432 RVA: 0x00269ACC File Offset: 0x00267CCC
		// (set) Token: 0x06008E51 RID: 36433 RVA: 0x000433F7 File Offset: 0x000415F7
		public unsafe bool purchaseInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_purchaseInProgress)) = value;
			}
		}

		// Token: 0x17002C0E RID: 11278
		// (get) Token: 0x06008E52 RID: 36434 RVA: 0x00269AF4 File Offset: 0x00267CF4
		// (set) Token: 0x06008E53 RID: 36435 RVA: 0x00043412 File Offset: 0x00041612
		public unsafe float timeOnLastFreeItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_timeOnLastFreeItem)) = value;
			}
		}

		// Token: 0x17002C0F RID: 11279
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x00269B1C File Offset: 0x00267D1C
		// (set) Token: 0x06008E55 RID: 36437 RVA: 0x0004342D File Offset: 0x0004162D
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06008E56 RID: 36438 RVA: 0x00269B44 File Offset: 0x00267D44
		// (set) Token: 0x06008E57 RID: 36439 RVA: 0x00043448 File Offset: 0x00041648
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06008E58 RID: 36440 RVA: 0x00269B6C File Offset: 0x00267D6C
		// (set) Token: 0x06008E59 RID: 36441 RVA: 0x00043467 File Offset: 0x00041667
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06008E5A RID: 36442 RVA: 0x00269B94 File Offset: 0x00267D94
		// (set) Token: 0x06008E5B RID: 36443 RVA: 0x00043482 File Offset: 0x00041682
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006155 RID: 24917
		private static readonly IntPtr NativeFieldInfoPtr_AllMachines;

		// Token: 0x04006156 RID: 24918
		private static readonly IntPtr NativeFieldInfoPtr_COST;

		// Token: 0x04006157 RID: 24919
		private static readonly IntPtr NativeFieldInfoPtr_REPAIR_TIME_DAYS;

		// Token: 0x04006158 RID: 24920
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM;

		// Token: 0x04006159 RID: 24921
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_FREE_ITEM_CHANCE;

		// Token: 0x0400615A RID: 24922
		private static readonly IntPtr NativeFieldInfoPtr_IMPACT_THRESHOLD_BREAK;

		// Token: 0x0400615B RID: 24923
		private static readonly IntPtr NativeFieldInfoPtr_MIN_CASH_DROP;

		// Token: 0x0400615C RID: 24924
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CASH_DROP;

		// Token: 0x0400615D RID: 24925
		private static readonly IntPtr NativeFieldInfoPtr__IsBroken_k__BackingField;

		// Token: 0x0400615E RID: 24926
		private static readonly IntPtr NativeFieldInfoPtr__DaysUntilRepair_k__BackingField;

		// Token: 0x0400615F RID: 24927
		private static readonly IntPtr NativeFieldInfoPtr_LitStartTime;

		// Token: 0x04006160 RID: 24928
		private static readonly IntPtr NativeFieldInfoPtr_LitOnEndTime;

		// Token: 0x04006161 RID: 24929
		private static readonly IntPtr NativeFieldInfoPtr_CukePrefab;

		// Token: 0x04006162 RID: 24930
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x04006163 RID: 24931
		private static readonly IntPtr NativeFieldInfoPtr_DoorMesh;

		// Token: 0x04006164 RID: 24932
		private static readonly IntPtr NativeFieldInfoPtr_PaySound;

		// Token: 0x04006165 RID: 24933
		private static readonly IntPtr NativeFieldInfoPtr_DispenseSound;

		// Token: 0x04006166 RID: 24934
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04006167 RID: 24935
		private static readonly IntPtr NativeFieldInfoPtr_ItemSpawnPoint;

		// Token: 0x04006168 RID: 24936
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04006169 RID: 24937
		private static readonly IntPtr NativeFieldInfoPtr_AccessPoint;

		// Token: 0x0400616A RID: 24938
		private static readonly IntPtr NativeFieldInfoPtr_Damageable;

		// Token: 0x0400616B RID: 24939
		private static readonly IntPtr NativeFieldInfoPtr_CashSpawnPoint;

		// Token: 0x0400616C RID: 24940
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x0400616D RID: 24941
		private static readonly IntPtr NativeFieldInfoPtr_onBreak;

		// Token: 0x0400616E RID: 24942
		private static readonly IntPtr NativeFieldInfoPtr_onRepair;

		// Token: 0x0400616F RID: 24943
		private static readonly IntPtr NativeFieldInfoPtr__lastDroppedItem_k__BackingField;

		// Token: 0x04006170 RID: 24944
		private static readonly IntPtr NativeFieldInfoPtr_isLit;

		// Token: 0x04006171 RID: 24945
		private static readonly IntPtr NativeFieldInfoPtr_purchaseInProgress;

		// Token: 0x04006172 RID: 24946
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastFreeItem;

		// Token: 0x04006173 RID: 24947
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04006174 RID: 24948
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04006175 RID: 24949
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006176 RID: 24950
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006177 RID: 24951
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0;

		// Token: 0x04006178 RID: 24952
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0;

		// Token: 0x04006179 RID: 24953
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0;

		// Token: 0x0400617A RID: 24954
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0;

		// Token: 0x0400617B RID: 24955
		private static readonly IntPtr NativeMethodInfoPtr_get_lastDroppedItem_Public_get_NetworkedItemPickup_0;

		// Token: 0x0400617C RID: 24956
		private static readonly IntPtr NativeMethodInfoPtr_set_lastDroppedItem_Protected_set_Void_NetworkedItemPickup_0;

		// Token: 0x0400617D RID: 24957
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x0400617E RID: 24958
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400617F RID: 24959
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04006180 RID: 24960
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006181 RID: 24961
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x04006182 RID: 24962
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006183 RID: 24963
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04006184 RID: 24964
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04006185 RID: 24965
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_1;

		// Token: 0x04006186 RID: 24966
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Public_Void_0;

		// Token: 0x04006187 RID: 24967
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04006188 RID: 24968
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04006189 RID: 24969
		private static readonly IntPtr NativeMethodInfoPtr_LocalPurchase_Private_Void_1;

		// Token: 0x0400618A RID: 24970
		private static readonly IntPtr NativeMethodInfoPtr_SendPurchase_Public_Void_0;

		// Token: 0x0400618B RID: 24971
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseRoutine_Public_Void_0;

		// Token: 0x0400618C RID: 24972
		private static readonly IntPtr NativeMethodInfoPtr_DropItem_Public_Void_0;

		// Token: 0x0400618D RID: 24973
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLastDropped_Public_Void_0;

		// Token: 0x0400618E RID: 24974
		private static readonly IntPtr NativeMethodInfoPtr_Impacted_Private_Void_Impact_0;

		// Token: 0x0400618F RID: 24975
		private static readonly IntPtr NativeMethodInfoPtr_SetLit_Private_Void_Boolean_0;

		// Token: 0x04006190 RID: 24976
		private static readonly IntPtr NativeMethodInfoPtr_SendBreak_Private_Void_1;

		// Token: 0x04006191 RID: 24977
		private static readonly IntPtr NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0;

		// Token: 0x04006192 RID: 24978
		private static readonly IntPtr NativeMethodInfoPtr_Repair_Private_Void_1;

		// Token: 0x04006193 RID: 24979
		private static readonly IntPtr NativeMethodInfoPtr_DropCash_Private_Void_1;

		// Token: 0x04006194 RID: 24980
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0;

		// Token: 0x04006195 RID: 24981
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0;

		// Token: 0x04006196 RID: 24982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006197 RID: 24983
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006198 RID: 24984
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04006199 RID: 24985
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x0400619A RID: 24986
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400619B RID: 24987
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400619C RID: 24988
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400619D RID: 24989
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPurchase_2166136261_Private_Void_1;

		// Token: 0x0400619E RID: 24990
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPurchase_2166136261_Public_Void_0;

		// Token: 0x0400619F RID: 24991
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPurchase_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040061A0 RID: 24992
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PurchaseRoutine_2166136261_Private_Void_1;

		// Token: 0x040061A1 RID: 24993
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PurchaseRoutine_2166136261_Public_Void_0;

		// Token: 0x040061A2 RID: 24994
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PurchaseRoutine_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040061A3 RID: 24995
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropItem_2166136261_Private_Void_1;

		// Token: 0x040061A4 RID: 24996
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropItem_2166136261_Public_Void_0;

		// Token: 0x040061A5 RID: 24997
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropItem_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040061A6 RID: 24998
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_1;

		// Token: 0x040061A7 RID: 24999
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_1;

		// Token: 0x040061A8 RID: 25000
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040061A9 RID: 25001
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040061AA RID: 25002
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040061AB RID: 25003
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040061AC RID: 25004
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040061AD RID: 25005
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040061AE RID: 25006
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_1;

		// Token: 0x040061AF RID: 25007
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_1;

		// Token: 0x040061B0 RID: 25008
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040061B1 RID: 25009
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_1;

		// Token: 0x040061B2 RID: 25010
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_1;

		// Token: 0x040061B3 RID: 25011
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040061B4 RID: 25012
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000C17 RID: 3095
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__BreakRoutine|59_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600EE1A RID: 60954 RVA: 0x00399B98 File Offset: 0x00397D98
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__BreakRoutine|59_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<cashDrop>5__2");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, "<i>5__3");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681729);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681730);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681731);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681732);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681733);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr, 100681734);
			}

			// Token: 0x0600EE1B RID: 60955 RVA: 0x00399CA0 File Offset: 0x00397EA0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE1C RID: 60956 RVA: 0x00399CE8 File Offset: 0x00397EE8
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE1D RID: 60957 RVA: 0x00399D1C File Offset: 0x00397F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261731, XrefRangeEnd = 261757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004833 RID: 18483
			// (get) Token: 0x0600EE1E RID: 60958 RVA: 0x00399D58 File Offset: 0x00397F58
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE1F RID: 60959 RVA: 0x00399D98 File Offset: 0x00397F98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261757, XrefRangeEnd = 261762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004834 RID: 18484
			// (get) Token: 0x0600EE20 RID: 60960 RVA: 0x00399DCC File Offset: 0x00397FCC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE21 RID: 60961 RVA: 0x00070629 File Offset: 0x0006E829
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700482E RID: 18478
			// (get) Token: 0x0600EE22 RID: 60962 RVA: 0x00399E0C File Offset: 0x0039800C
			// (set) Token: 0x0600EE23 RID: 60963 RVA: 0x00070632 File Offset: 0x0006E832
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700482F RID: 18479
			// (get) Token: 0x0600EE24 RID: 60964 RVA: 0x00399E34 File Offset: 0x00398034
			// (set) Token: 0x0600EE25 RID: 60965 RVA: 0x0007064D File Offset: 0x0006E84D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004830 RID: 18480
			// (get) Token: 0x0600EE26 RID: 60966 RVA: 0x00399E64 File Offset: 0x00398064
			// (set) Token: 0x0600EE27 RID: 60967 RVA: 0x0007066C File Offset: 0x0006E86C
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004831 RID: 18481
			// (get) Token: 0x0600EE28 RID: 60968 RVA: 0x00399E94 File Offset: 0x00398094
			// (set) Token: 0x0600EE29 RID: 60969 RVA: 0x0007068B File Offset: 0x0006E88B
			public unsafe int _cashDrop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2)) = value;
				}
			}

			// Token: 0x17004832 RID: 18482
			// (get) Token: 0x0600EE2A RID: 60970 RVA: 0x00399EBC File Offset: 0x003980BC
			// (set) Token: 0x0600EE2B RID: 60971 RVA: 0x000706A6 File Offset: 0x0006E8A6
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A13A RID: 41274
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A13B RID: 41275
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A13C RID: 41276
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A13D RID: 41277
			private static readonly IntPtr NativeFieldInfoPtr__cashDrop_5__2;

			// Token: 0x0400A13E RID: 41278
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A13F RID: 41279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A140 RID: 41280
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A141 RID: 41281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A142 RID: 41282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A143 RID: 41283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A144 RID: 41284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C18 RID: 3096
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<Impacted>g__Drop|59_1>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600EE2C RID: 60972 RVA: 0x00399EE4 File Offset: 0x003980E4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<Impacted>g__Drop|59_1>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681735);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681736);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681737);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681738);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681739);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr, 100681740);
			}

			// Token: 0x0600EE2D RID: 60973 RVA: 0x00399FC4 File Offset: 0x003981C4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2E RID: 60974 RVA: 0x0039A00C File Offset: 0x0039820C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE2F RID: 60975 RVA: 0x0039A040 File Offset: 0x00398240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261762, XrefRangeEnd = 261767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004838 RID: 18488
			// (get) Token: 0x0600EE30 RID: 60976 RVA: 0x0039A07C File Offset: 0x0039827C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE31 RID: 60977 RVA: 0x0039A0BC File Offset: 0x003982BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261767, XrefRangeEnd = 261772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004839 RID: 18489
			// (get) Token: 0x0600EE32 RID: 60978 RVA: 0x0039A0F0 File Offset: 0x003982F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE33 RID: 60979 RVA: 0x000706C1 File Offset: 0x0006E8C1
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004835 RID: 18485
			// (get) Token: 0x0600EE34 RID: 60980 RVA: 0x0039A130 File Offset: 0x00398330
			// (set) Token: 0x0600EE35 RID: 60981 RVA: 0x000706CA File Offset: 0x0006E8CA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004836 RID: 18486
			// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x0039A158 File Offset: 0x00398358
			// (set) Token: 0x0600EE37 RID: 60983 RVA: 0x000706E5 File Offset: 0x0006E8E5
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004837 RID: 18487
			// (get) Token: 0x0600EE38 RID: 60984 RVA: 0x0039A188 File Offset: 0x00398388
			// (set) Token: 0x0600EE39 RID: 60985 RVA: 0x00070704 File Offset: 0x0006E904
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A145 RID: 41285
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A146 RID: 41286
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A147 RID: 41287
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A148 RID: 41288
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A149 RID: 41289
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A14A RID: 41290
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A14B RID: 41291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A14C RID: 41292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A14D RID: 41293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C19 RID: 3097
		[ObfuscatedName("ScheduleOne.ObjectScripts.VendingMachine+<<PurchaseRoutine>g__Routine|56_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600EE3A RID: 60986 RVA: 0x0039A1B8 File Offset: 0x003983B8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VendingMachine>.NativeClassPtr, "<<PurchaseRoutine>g__Routine|56_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681741);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681742);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681743);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681744);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681745);
				VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr, 100681746);
			}

			// Token: 0x0600EE3B RID: 60987 RVA: 0x0039A298 File Offset: 0x00398498
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE3C RID: 60988 RVA: 0x0039A2E0 File Offset: 0x003984E0
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EE3D RID: 60989 RVA: 0x0039A314 File Offset: 0x00398514
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261772, XrefRangeEnd = 261778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700483D RID: 18493
			// (get) Token: 0x0600EE3E RID: 60990 RVA: 0x0039A350 File Offset: 0x00398550
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE3F RID: 60991 RVA: 0x0039A390 File Offset: 0x00398590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261778, XrefRangeEnd = 261783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700483E RID: 18494
			// (get) Token: 0x0600EE40 RID: 60992 RVA: 0x0039A3C4 File Offset: 0x003985C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EE41 RID: 60993 RVA: 0x00070723 File Offset: 0x0006E923
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700483A RID: 18490
			// (get) Token: 0x0600EE42 RID: 60994 RVA: 0x0039A404 File Offset: 0x00398604
			// (set) Token: 0x0600EE43 RID: 60995 RVA: 0x0007072C File Offset: 0x0006E92C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700483B RID: 18491
			// (get) Token: 0x0600EE44 RID: 60996 RVA: 0x0039A42C File Offset: 0x0039862C
			// (set) Token: 0x0600EE45 RID: 60997 RVA: 0x00070747 File Offset: 0x0006E947
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700483C RID: 18492
			// (get) Token: 0x0600EE46 RID: 60998 RVA: 0x0039A45C File Offset: 0x0039865C
			// (set) Token: 0x0600EE47 RID: 60999 RVA: 0x00070766 File Offset: 0x0006E966
			public unsafe VendingMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VendingMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendingMachine.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A14E RID: 41294
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A14F RID: 41295
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A150 RID: 41296
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A151 RID: 41297
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A152 RID: 41298
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A153 RID: 41299
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A154 RID: 41300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A155 RID: 41301
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A156 RID: 41302
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
