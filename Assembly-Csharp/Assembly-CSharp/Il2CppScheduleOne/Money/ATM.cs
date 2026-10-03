using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Money
{
	// Token: 0x020002AA RID: 682
	public class ATM : NetworkBehaviour
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x001291F4 File Offset: 0x001273F4
		// Note: this type is marked as 'beforefieldinit'.
		static ATM()
		{
			Il2CppClassPointerStore<ATM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Money", "ATM");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATM>.NativeClassPtr);
			ATM.NativeFieldInfoPtr_DepositLimitEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "DepositLimitEnabled");
			ATM.NativeFieldInfoPtr_WeeklyDepositLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "WeeklyDepositLimit");
			ATM.NativeFieldInfoPtr_BreakImpactThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "BreakImpactThreshold");
			ATM.NativeFieldInfoPtr_RepairTimeDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "RepairTimeDays");
			ATM.NativeFieldInfoPtr_MinCashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "MinCashDrop");
			ATM.NativeFieldInfoPtr_MaxCashDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "MaxCashDrop");
			ATM.NativeFieldInfoPtr_WeeklyDepositSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "WeeklyDepositSum");
			ATM.NativeFieldInfoPtr__InUse_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<InUse>k__BackingField");
			ATM.NativeFieldInfoPtr__IsBroken_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<IsBroken>k__BackingField");
			ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<DaysUntilRepair>k__BackingField");
			ATM.NativeFieldInfoPtr_CashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "CashPrefab");
			ATM.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "intObj");
			ATM.NativeFieldInfoPtr_camPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "camPos");
			ATM.NativeFieldInfoPtr_atmInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "atmInterface");
			ATM.NativeFieldInfoPtr_accessPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "accessPoint");
			ATM.NativeFieldInfoPtr_cashSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "cashSpawnPoint");
			ATM.NativeFieldInfoPtr_damageable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "damageable");
			ATM.NativeFieldInfoPtr_viewLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "viewLerpTime");
			ATM.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<GUID>k__BackingField");
			ATM.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "BakedGUID");
			ATM.NativeFieldInfoPtr_onBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "onBreak");
			ATM.NativeFieldInfoPtr_onRepair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "onRepair");
			ATM.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted");
			ATM.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Money.ATMAssembly-CSharp.dll_Excuted");
			ATM.NativeMethodInfoPtr_get_InUse_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669913);
			ATM.NativeMethodInfoPtr_set_InUse_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669914);
			ATM.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669915);
			ATM.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669916);
			ATM.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669917);
			ATM.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669918);
			ATM.NativeMethodInfoPtr_get_AccessPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669919);
			ATM.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669920);
			ATM.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669921);
			ATM.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669922);
			ATM.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669923);
			ATM.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669924);
			ATM.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669925);
			ATM.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669926);
			ATM.NativeMethodInfoPtr_DayPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669927);
			ATM.NativeMethodInfoPtr_WeekPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669928);
			ATM.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669929);
			ATM.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669930);
			ATM.NativeMethodInfoPtr_Enter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669931);
			ATM.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669932);
			ATM.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669933);
			ATM.NativeMethodInfoPtr_SendBreak_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669934);
			ATM.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669935);
			ATM.NativeMethodInfoPtr_Repair_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669936);
			ATM.NativeMethodInfoPtr_DropCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669937);
			ATM.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669938);
			ATM.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669939);
			ATM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669940);
			ATM.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669942);
			ATM.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669943);
			ATM.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669944);
			ATM.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669945);
			ATM.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669946);
			ATM.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669947);
			ATM.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669948);
			ATM.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669949);
			ATM.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669950);
			ATM.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669951);
			ATM.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669952);
			ATM.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669953);
			ATM.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669954);
			ATM.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669955);
			ATM.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669956);
			ATM.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669957);
			ATM.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669958);
			ATM.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669959);
			ATM.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM>.NativeClassPtr, 100669960);
		}

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x001297B0 File Offset: 0x001279B0
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x001297EC File Offset: 0x001279EC
		public unsafe bool InUse
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_InUse_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_InUse_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x0012982C File Offset: 0x00127A2C
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00129868 File Offset: 0x00127A68
		public unsafe bool IsBroken
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x001298A8 File Offset: 0x00127AA8
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x001298E4 File Offset: 0x00127AE4
		public unsafe int DaysUntilRepair
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00129924 File Offset: 0x00127B24
		public unsafe Transform AccessPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_AccessPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x00129964 File Offset: 0x00127B64
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x001299A0 File Offset: 0x00127BA0
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x001299E0 File Offset: 0x00127BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139922, XrefRangeEnd = 139925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00129A14 File Offset: 0x00127C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139925, XrefRangeEnd = 139946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00129A50 File Offset: 0x00127C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139946, XrefRangeEnd = 139982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00129A8C File Offset: 0x00127C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139982, XrefRangeEnd = 139984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00129ADC File Offset: 0x00127CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139984, XrefRangeEnd = 139988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00129B1C File Offset: 0x00127D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139988, XrefRangeEnd = 140006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_DayPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00129B50 File Offset: 0x00127D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140006, XrefRangeEnd = 140010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_WeekPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00129B84 File Offset: 0x00127D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140010, XrefRangeEnd = 140013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00129BB8 File Offset: 0x00127DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140013, XrefRangeEnd = 140014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x00129BEC File Offset: 0x00127DEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140032, RefRangeEnd = 140033, XrefRangeStart = 140014, XrefRangeEnd = 140032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Enter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x00129C20 File Offset: 0x00127E20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140047, RefRangeEnd = 140048, XrefRangeStart = 140033, XrefRangeEnd = 140047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x00129C54 File Offset: 0x00127E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140048, XrefRangeEnd = 140091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Impacted(Impact impact)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(impact);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Impacted_Private_Void_Impact_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x00129C98 File Offset: 0x00127E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140091, XrefRangeEnd = 140112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBreak()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_SendBreak_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003461 RID: 13409 RVA: 0x00129CCC File Offset: 0x00127ECC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 140149, RefRangeEnd = 140155, XrefRangeStart = 140112, XrefRangeEnd = 140149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Break(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003462 RID: 13410 RVA: 0x00129D10 File Offset: 0x00127F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140155, XrefRangeEnd = 140164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Repair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Repair_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00129D44 File Offset: 0x00127F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140164, XrefRangeEnd = 140173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_DropCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003464 RID: 13412 RVA: 0x00129D78 File Offset: 0x00127F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140173, XrefRangeEnd = 140180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(GenericSaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00129DBC File Offset: 0x00127FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140180, XrefRangeEnd = 140191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GenericSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GenericSaveData>(intPtr3) : null;
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00129DFC File Offset: 0x00127FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140191, XrefRangeEnd = 140195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ATM() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATM>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x00129E38 File Offset: 0x00128038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140195, XrefRangeEnd = 140200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x00129E78 File Offset: 0x00128078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140200, XrefRangeEnd = 140232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00129EB4 File Offset: 0x001280B4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x00129EF0 File Offset: 0x001280F0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ATM.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00129F2C File Offset: 0x0012812C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140232, XrefRangeEnd = 140241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00129F60 File Offset: 0x00128160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140241, XrefRangeEnd = 140242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBreak_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346D RID: 13421 RVA: 0x00129F94 File Offset: 0x00128194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140242, XrefRangeEnd = 140245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBreak_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346E RID: 13422 RVA: 0x00129FF8 File Offset: 0x001281F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140245, XrefRangeEnd = 140254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600346F RID: 13423 RVA: 0x0012A03C File Offset: 0x0012823C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140254, XrefRangeEnd = 140255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003470 RID: 13424 RVA: 0x0012A080 File Offset: 0x00128280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140255, XrefRangeEnd = 140258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x0012A0D0 File Offset: 0x001282D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140258, XrefRangeEnd = 140267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Break_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x0012A114 File Offset: 0x00128314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140267, XrefRangeEnd = 140270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Break_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0012A164 File Offset: 0x00128364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x0012A198 File Offset: 0x00128398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140270, XrefRangeEnd = 140271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Repair_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x0012A1CC File Offset: 0x001283CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140271, XrefRangeEnd = 140273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Repair_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x0012A21C File Offset: 0x0012841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0012A250 File Offset: 0x00128450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140294, RefRangeEnd = 140295, XrefRangeStart = 140273, XrefRangeEnd = 140294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DropCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x0012A284 File Offset: 0x00128484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140295, XrefRangeEnd = 140297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DropCash_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x0012A2E8 File Offset: 0x001284E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140297, XrefRangeEnd = 140315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600347A RID: 13434 RVA: 0x0001AAC5 File Offset: 0x00018CC5
		public ATM(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001085 RID: 4229
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x0012A31C File Offset: 0x0012851C
		// (set) Token: 0x0600347C RID: 13436 RVA: 0x0001AACE File Offset: 0x00018CCE
		public unsafe static bool DepositLimitEnabled
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_DepositLimitEnabled, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_DepositLimitEnabled, (void*)(&value));
			}
		}

		// Token: 0x17001086 RID: 4230
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x0012A338 File Offset: 0x00128538
		// (set) Token: 0x0600347E RID: 13438 RVA: 0x0001AADC File Offset: 0x00018CDC
		public unsafe static float WeeklyDepositLimit
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_WeeklyDepositLimit, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_WeeklyDepositLimit, (void*)(&value));
			}
		}

		// Token: 0x17001087 RID: 4231
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x0012A354 File Offset: 0x00128554
		// (set) Token: 0x06003480 RID: 13440 RVA: 0x0001AAEA File Offset: 0x00018CEA
		public unsafe static float BreakImpactThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_BreakImpactThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_BreakImpactThreshold, (void*)(&value));
			}
		}

		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06003481 RID: 13441 RVA: 0x0012A370 File Offset: 0x00128570
		// (set) Token: 0x06003482 RID: 13442 RVA: 0x0001AAF8 File Offset: 0x00018CF8
		public unsafe static int RepairTimeDays
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_RepairTimeDays, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_RepairTimeDays, (void*)(&value));
			}
		}

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x0012A38C File Offset: 0x0012858C
		// (set) Token: 0x06003484 RID: 13444 RVA: 0x0001AB06 File Offset: 0x00018D06
		public unsafe static int MinCashDrop
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_MinCashDrop, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_MinCashDrop, (void*)(&value));
			}
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x0012A3A8 File Offset: 0x001285A8
		// (set) Token: 0x06003486 RID: 13446 RVA: 0x0001AB14 File Offset: 0x00018D14
		public unsafe static int MaxCashDrop
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_MaxCashDrop, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_MaxCashDrop, (void*)(&value));
			}
		}

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x0012A3C4 File Offset: 0x001285C4
		// (set) Token: 0x06003488 RID: 13448 RVA: 0x0001AB22 File Offset: 0x00018D22
		public unsafe static float WeeklyDepositSum
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_WeeklyDepositSum, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_WeeklyDepositSum, (void*)(&value));
			}
		}

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x0012A3E0 File Offset: 0x001285E0
		// (set) Token: 0x0600348A RID: 13450 RVA: 0x0001AB30 File Offset: 0x00018D30
		public unsafe bool _InUse_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__InUse_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__InUse_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108D RID: 4237
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x0012A408 File Offset: 0x00128608
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x0001AB4B File Offset: 0x00018D4B
		public unsafe bool _IsBroken_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__IsBroken_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__IsBroken_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108E RID: 4238
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x0012A430 File Offset: 0x00128630
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x0001AB66 File Offset: 0x00018D66
		public unsafe int _DaysUntilRepair_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__DaysUntilRepair_k__BackingField)) = value;
			}
		}

		// Token: 0x1700108F RID: 4239
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x0012A458 File Offset: 0x00128658
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x0001AB81 File Offset: 0x00018D81
		public unsafe CashPickup CashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_CashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001090 RID: 4240
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x0012A488 File Offset: 0x00128688
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x0001ABA0 File Offset: 0x00018DA0
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x0012A4B8 File Offset: 0x001286B8
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x0001ABBF File Offset: 0x00018DBF
		public unsafe Transform camPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_camPos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_camPos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x0012A4E8 File Offset: 0x001286E8
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x0001ABDE File Offset: 0x00018DDE
		public unsafe ATMInterface atmInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_atmInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATMInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_atmInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001093 RID: 4243
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x0012A518 File Offset: 0x00128718
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x0001ABFD File Offset: 0x00018DFD
		public unsafe Transform accessPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_accessPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_accessPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001094 RID: 4244
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x0012A548 File Offset: 0x00128748
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x0001AC1C File Offset: 0x00018E1C
		public unsafe Transform cashSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_cashSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_cashSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001095 RID: 4245
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x0012A578 File Offset: 0x00128778
		// (set) Token: 0x0600349C RID: 13468 RVA: 0x0001AC3B File Offset: 0x00018E3B
		public unsafe PhysicsDamageable damageable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_damageable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhysicsDamageable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_damageable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x0012A5A8 File Offset: 0x001287A8
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x0001AC5A File Offset: 0x00018E5A
		public unsafe static float viewLerpTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ATM.NativeFieldInfoPtr_viewLerpTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ATM.NativeFieldInfoPtr_viewLerpTime, (void*)(&value));
			}
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x0012A5C4 File Offset: 0x001287C4
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0001AC68 File Offset: 0x00018E68
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x0012A5EC File Offset: 0x001287EC
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0001AC83 File Offset: 0x00018E83
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x0012A614 File Offset: 0x00128814
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0001ACA2 File Offset: 0x00018EA2
		public unsafe UnityEvent onBreak
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onBreak);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onBreak), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x0012A644 File Offset: 0x00128844
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x0001ACC1 File Offset: 0x00018EC1
		public unsafe UnityEvent onRepair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onRepair);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_onRepair), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x0012A674 File Offset: 0x00128874
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x0001ACE0 File Offset: 0x00018EE0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x0012A69C File Offset: 0x0012889C
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x0001ACFB File Offset: 0x00018EFB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeFieldInfoPtr_DepositLimitEnabled;

		// Token: 0x040022FA RID: 8954
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositLimit;

		// Token: 0x040022FB RID: 8955
		private static readonly IntPtr NativeFieldInfoPtr_BreakImpactThreshold;

		// Token: 0x040022FC RID: 8956
		private static readonly IntPtr NativeFieldInfoPtr_RepairTimeDays;

		// Token: 0x040022FD RID: 8957
		private static readonly IntPtr NativeFieldInfoPtr_MinCashDrop;

		// Token: 0x040022FE RID: 8958
		private static readonly IntPtr NativeFieldInfoPtr_MaxCashDrop;

		// Token: 0x040022FF RID: 8959
		private static readonly IntPtr NativeFieldInfoPtr_WeeklyDepositSum;

		// Token: 0x04002300 RID: 8960
		private static readonly IntPtr NativeFieldInfoPtr__InUse_k__BackingField;

		// Token: 0x04002301 RID: 8961
		private static readonly IntPtr NativeFieldInfoPtr__IsBroken_k__BackingField;

		// Token: 0x04002302 RID: 8962
		private static readonly IntPtr NativeFieldInfoPtr__DaysUntilRepair_k__BackingField;

		// Token: 0x04002303 RID: 8963
		private static readonly IntPtr NativeFieldInfoPtr_CashPrefab;

		// Token: 0x04002304 RID: 8964
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002305 RID: 8965
		private static readonly IntPtr NativeFieldInfoPtr_camPos;

		// Token: 0x04002306 RID: 8966
		private static readonly IntPtr NativeFieldInfoPtr_atmInterface;

		// Token: 0x04002307 RID: 8967
		private static readonly IntPtr NativeFieldInfoPtr_accessPoint;

		// Token: 0x04002308 RID: 8968
		private static readonly IntPtr NativeFieldInfoPtr_cashSpawnPoint;

		// Token: 0x04002309 RID: 8969
		private static readonly IntPtr NativeFieldInfoPtr_damageable;

		// Token: 0x0400230A RID: 8970
		private static readonly IntPtr NativeFieldInfoPtr_viewLerpTime;

		// Token: 0x0400230B RID: 8971
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x0400230C RID: 8972
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x0400230D RID: 8973
		private static readonly IntPtr NativeFieldInfoPtr_onBreak;

		// Token: 0x0400230E RID: 8974
		private static readonly IntPtr NativeFieldInfoPtr_onRepair;

		// Token: 0x0400230F RID: 8975
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002310 RID: 8976
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002311 RID: 8977
		private static readonly IntPtr NativeMethodInfoPtr_get_InUse_Public_get_Boolean_0;

		// Token: 0x04002312 RID: 8978
		private static readonly IntPtr NativeMethodInfoPtr_set_InUse_Protected_set_Void_Boolean_0;

		// Token: 0x04002313 RID: 8979
		private static readonly IntPtr NativeMethodInfoPtr_get_IsBroken_Public_get_Boolean_0;

		// Token: 0x04002314 RID: 8980
		private static readonly IntPtr NativeMethodInfoPtr_set_IsBroken_Protected_set_Void_Boolean_0;

		// Token: 0x04002315 RID: 8981
		private static readonly IntPtr NativeMethodInfoPtr_get_DaysUntilRepair_Public_get_Int32_0;

		// Token: 0x04002316 RID: 8982
		private static readonly IntPtr NativeMethodInfoPtr_set_DaysUntilRepair_Protected_set_Void_Int32_0;

		// Token: 0x04002317 RID: 8983
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoint_Public_get_Transform_0;

		// Token: 0x04002318 RID: 8984
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04002319 RID: 8985
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x0400231A RID: 8986
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x0400231B RID: 8987
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400231C RID: 8988
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400231D RID: 8989
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400231E RID: 8990
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x0400231F RID: 8991
		private static readonly IntPtr NativeMethodInfoPtr_DayPass_Public_Void_0;

		// Token: 0x04002320 RID: 8992
		private static readonly IntPtr NativeMethodInfoPtr_WeekPass_Public_Void_0;

		// Token: 0x04002321 RID: 8993
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002322 RID: 8994
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_0;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_Impacted_Private_Void_Impact_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_SendBreak_Private_Void_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_Break_Private_Void_NetworkConnection_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_Repair_Private_Void_0;

		// Token: 0x04002329 RID: 9001
		private static readonly IntPtr NativeMethodInfoPtr_DropCash_Private_Void_0;

		// Token: 0x0400232A RID: 9002
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Final_New_Void_GenericSaveData_0;

		// Token: 0x0400232B RID: 9003
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_Final_New_GenericSaveData_0;

		// Token: 0x0400232C RID: 9004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBreak_2166136261_Private_Void_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBreak_2166136261_Private_Void_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBreak_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002334 RID: 9012
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002335 RID: 9013
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002336 RID: 9014
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002337 RID: 9015
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Break_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04002338 RID: 9016
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Break_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002339 RID: 9017
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Repair_2166136261_Private_Void_0;

		// Token: 0x0400233A RID: 9018
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Repair_2166136261_Private_Void_0;

		// Token: 0x0400233B RID: 9019
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Repair_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400233C RID: 9020
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DropCash_2166136261_Private_Void_0;

		// Token: 0x0400233D RID: 9021
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DropCash_2166136261_Private_Void_0;

		// Token: 0x0400233E RID: 9022
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DropCash_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400233F RID: 9023
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A0B RID: 2571
		[ObfuscatedName("ScheduleOne.Money.ATM+<<Impacted>g__BreakRoutine|47_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DDBB RID: 56763 RVA: 0x0036B8C8 File Offset: 0x00369AC8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique()
			{
				Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ATM>.NativeClassPtr, "<<Impacted>g__BreakRoutine|47_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>1__state");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>2__current");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<>4__this");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<cashDrop>5__2");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, "<i>5__3");
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669961);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669962);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669963);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669964);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669965);
				ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr, 100669966);
			}

			// Token: 0x0600DDBC RID: 56764 RVA: 0x0036B9D0 File Offset: 0x00369BD0
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBD RID: 56765 RVA: 0x0036BA18 File Offset: 0x00369C18
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DDBE RID: 56766 RVA: 0x0036BA4C File Offset: 0x00369C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139891, XrefRangeEnd = 139917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004383 RID: 17283
			// (get) Token: 0x0600DDBF RID: 56767 RVA: 0x0036BA88 File Offset: 0x00369C88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDC0 RID: 56768 RVA: 0x0036BAC8 File Offset: 0x00369CC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139917, XrefRangeEnd = 139922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004384 RID: 17284
			// (get) Token: 0x0600DDC1 RID: 56769 RVA: 0x0036BAFC File Offset: 0x00369CFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DDC2 RID: 56770 RVA: 0x000685DC File Offset: 0x000667DC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700437E RID: 17278
			// (get) Token: 0x0600DDC3 RID: 56771 RVA: 0x0036BB3C File Offset: 0x00369D3C
			// (set) Token: 0x0600DDC4 RID: 56772 RVA: 0x000685E5 File Offset: 0x000667E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700437F RID: 17279
			// (get) Token: 0x0600DDC5 RID: 56773 RVA: 0x0036BB64 File Offset: 0x00369D64
			// (set) Token: 0x0600DDC6 RID: 56774 RVA: 0x00068600 File Offset: 0x00066800
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004380 RID: 17280
			// (get) Token: 0x0600DDC7 RID: 56775 RVA: 0x0036BB94 File Offset: 0x00369D94
			// (set) Token: 0x0600DDC8 RID: 56776 RVA: 0x0006861F File Offset: 0x0006681F
			public unsafe ATM __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ATM>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004381 RID: 17281
			// (get) Token: 0x0600DDC9 RID: 56777 RVA: 0x0036BBC4 File Offset: 0x00369DC4
			// (set) Token: 0x0600DDCA RID: 56778 RVA: 0x0006863E File Offset: 0x0006683E
			public unsafe int _cashDrop_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__cashDrop_5__2)) = value;
				}
			}

			// Token: 0x17004382 RID: 17282
			// (get) Token: 0x0600DDCB RID: 56779 RVA: 0x0036BBEC File Offset: 0x00369DEC
			// (set) Token: 0x0600DDCC RID: 56780 RVA: 0x00068659 File Offset: 0x00066859
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ATM.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObATInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400971D RID: 38685
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400971E RID: 38686
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400971F RID: 38687
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009720 RID: 38688
			private static readonly IntPtr NativeFieldInfoPtr__cashDrop_5__2;

			// Token: 0x04009721 RID: 38689
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009722 RID: 38690
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009723 RID: 38691
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009724 RID: 38692
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009725 RID: 38693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009726 RID: 38694
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009727 RID: 38695
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
