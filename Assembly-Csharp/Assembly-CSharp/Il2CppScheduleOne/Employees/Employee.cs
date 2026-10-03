using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tools;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200037F RID: 895
	public class Employee : NPC
	{
		// Token: 0x06004E27 RID: 20007 RVA: 0x00187BB8 File Offset: 0x00185DB8
		// Note: this type is marked as 'beforefieldinit'.
		static Employee()
		{
			Il2CppClassPointerStore<Employee>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Employee");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee>.NativeClassPtr);
			Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			Employee.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DEBUG");
			Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AssignedProperty>k__BackingField");
			Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<EmployeeIndex>k__BackingField");
			Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr__Fired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<Fired>k__BackingField");
			Employee.NativeFieldInfoPtr__IsMale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<IsMale>k__BackingField");
			Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<AppearanceIndex>k__BackingField");
			Employee.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "Type");
			Employee.NativeFieldInfoPtr_WorkSpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkSpeedController");
			Employee.NativeFieldInfoPtr_SigningFee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "SigningFee");
			Employee.NativeFieldInfoPtr_DailyWage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "DailyWage");
			Employee.NativeFieldInfoPtr_WaitOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WaitOutside");
			Employee.NativeFieldInfoPtr_MoveItemBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "MoveItemBehaviour");
			Employee.NativeFieldInfoPtr_BedNotAssignedDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "BedNotAssignedDialogue");
			Employee.NativeFieldInfoPtr_NotPaidDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NotPaidDialogue");
			Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssueDialogueTemplate");
			Employee.NativeFieldInfoPtr_FireDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "FireDialogue");
			Employee.NativeFieldInfoPtr_TransferDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "TransferDialogue");
			Employee.NativeFieldInfoPtr_WorkIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "WorkIssues");
			Employee.NativeFieldInfoPtr__TicksSinceLastWork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<TicksSinceLastWork>k__BackingField");
			Employee.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "initialized");
			Employee.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "consecutivePathingFailures");
			Employee.NativeFieldInfoPtr_timeOnLastPathingFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "timeOnLastPathingFailure");
			Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "cachedNPCSpawnPoint");
			Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "syncVar___<PaidForToday>k__BackingField");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted");
			Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673454);
			Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673455);
			Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673456);
			Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673457);
			Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673458);
			Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673459);
			Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673460);
			Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673461);
			Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673462);
			Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673463);
			Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673464);
			Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673465);
			Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673466);
			Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673467);
			Employee.NativeMethodInfoPtr_get_CurrentWorkSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673468);
			Employee.NativeMethodInfoPtr_get_TicksSinceLastWork_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673469);
			Employee.NativeMethodInfoPtr_set_TicksSinceLastWork_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673470);
			Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673471);
			Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673472);
			Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673473);
			Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673474);
			Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673475);
			Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673476);
			Employee.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673477);
			Employee.NativeMethodInfoPtr_SendTransfer_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673478);
			Employee.NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673479);
			Employee.NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673480);
			Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673481);
			Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673482);
			Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673483);
			Employee.NativeMethodInfoPtr_SendFire_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673484);
			Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673485);
			Employee.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673486);
			Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673487);
			Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673488);
			Employee.NativeMethodInfoPtr_CanConsumeProduct_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673489);
			Employee.NativeMethodInfoPtr_GetFirstInventorySlotContainingProduct_Protected_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673490);
			Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673491);
			Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673492);
			Employee.NativeMethodInfoPtr_UpdateConsumeProduct_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673493);
			Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673494);
			Employee.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673495);
			Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673496);
			Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673497);
			Employee.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673498);
			Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673499);
			Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673500);
			Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673501);
			Employee.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673502);
			Employee.NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673503);
			Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673504);
			Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673505);
			Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673506);
			Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673507);
			Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673508);
			Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673509);
			Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673510);
			Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673511);
			Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673512);
			Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673513);
			Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673514);
			Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673515);
			Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673516);
			Employee.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673517);
			Employee.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673518);
			Employee.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673519);
			Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673520);
			Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673521);
			Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673522);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673523);
			Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673524);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673525);
			Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673526);
			Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673527);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673528);
			Employee.NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673529);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673530);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673531);
			Employee.NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673532);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673533);
			Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673534);
			Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673535);
			Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673536);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673537);
			Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673538);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673539);
			Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673540);
			Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673541);
			Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673542);
			Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673543);
			Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673544);
			Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673545);
			Employee.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee>.NativeClassPtr, 100673546);
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x0018855C File Offset: 0x0018675C
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x0018859C File Offset: 0x0018679C
		public unsafe Property AssignedProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176563, XrefRangeEnd = 176564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x001885E0 File Offset: 0x001867E0
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x0018861C File Offset: 0x0018681C
		public unsafe int EmployeeIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x0018865C File Offset: 0x0018685C
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x00188698 File Offset: 0x00186898
		public unsafe bool PaidForToday
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176564, RefRangeEnd = 176565, XrefRangeStart = 176564, XrefRangeEnd = 176564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 176572, RefRangeEnd = 176575, XrefRangeStart = 176565, XrefRangeEnd = 176572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x001886D8 File Offset: 0x001868D8
		// (set) Token: 0x06004E2F RID: 20015 RVA: 0x00188714 File Offset: 0x00186914
		public unsafe bool Fired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x00188754 File Offset: 0x00186954
		public unsafe bool IsWaitingOutside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06004E31 RID: 20017 RVA: 0x00188790 File Offset: 0x00186990
		// (set) Token: 0x06004E32 RID: 20018 RVA: 0x001887CC File Offset: 0x001869CC
		public unsafe bool IsMale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06004E33 RID: 20019 RVA: 0x0018880C File Offset: 0x00186A0C
		// (set) Token: 0x06004E34 RID: 20020 RVA: 0x00188848 File Offset: 0x00186A48
		public unsafe int AppearanceIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06004E35 RID: 20021 RVA: 0x00188888 File Offset: 0x00186A88
		public unsafe EEmployeeType EmployeeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x001888C4 File Offset: 0x00186AC4
		public unsafe float CurrentWorkSpeed
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 176575, RefRangeEnd = 176583, XrefRangeStart = 176575, XrefRangeEnd = 176575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_CurrentWorkSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06004E37 RID: 20023 RVA: 0x00188900 File Offset: 0x00186B00
		// (set) Token: 0x06004E38 RID: 20024 RVA: 0x0018893C File Offset: 0x00186B3C
		public unsafe int TicksSinceLastWork
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_get_TicksSinceLastWork_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_set_TicksSinceLastWork_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x0018897C File Offset: 0x00186B7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176592, RefRangeEnd = 176596, XrefRangeStart = 176583, XrefRangeEnd = 176592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x001889B8 File Offset: 0x00186BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176596, XrefRangeEnd = 176671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3B RID: 20027 RVA: 0x001889F4 File Offset: 0x00186BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176671, XrefRangeEnd = 176680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00188A30 File Offset: 0x00186C30
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176686, RefRangeEnd = 176690, XrefRangeStart = 176680, XrefRangeEnd = 176686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00188A80 File Offset: 0x00186C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176690, XrefRangeEnd = 176746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3E RID: 20030 RVA: 0x00188B48 File Offset: 0x00186D48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176754, RefRangeEnd = 176758, XrefRangeStart = 176746, XrefRangeEnd = 176754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E3F RID: 20031 RVA: 0x00188BA4 File Offset: 0x00186DA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176764, RefRangeEnd = 176768, XrefRangeStart = 176758, XrefRangeEnd = 176764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E40 RID: 20032 RVA: 0x00188BE0 File Offset: 0x00186DE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176778, RefRangeEnd = 176779, XrefRangeStart = 176768, XrefRangeEnd = 176778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTransfer(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendTransfer_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E41 RID: 20033 RVA: 0x00188C24 File Offset: 0x00186E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176779, XrefRangeEnd = 176789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransferToProperty(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E42 RID: 20034 RVA: 0x00188C68 File Offset: 0x00186E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176789, XrefRangeEnd = 176815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TransferToProperty(Property prop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E43 RID: 20035 RVA: 0x00188CB8 File Offset: 0x00186EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176815, XrefRangeEnd = 176841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeInfo(string firstName, string lastName, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E44 RID: 20036 RVA: 0x00188D2C File Offset: 0x00186F2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176841, XrefRangeEnd = 176872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E45 RID: 20037 RVA: 0x00188D84 File Offset: 0x00186F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176872, XrefRangeEnd = 176892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckDialogueChoice(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E46 RID: 20038 RVA: 0x00188DD4 File Offset: 0x00186FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176892, XrefRangeEnd = 176901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SendFire_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E47 RID: 20039 RVA: 0x00188E08 File Offset: 0x00187008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176901, XrefRangeEnd = 176910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveFire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ReceiveFire_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E48 RID: 20040 RVA: 0x00188E3C File Offset: 0x0018703C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E49 RID: 20041 RVA: 0x00188E78 File Offset: 0x00187078
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176927, RefRangeEnd = 176931, XrefRangeStart = 176910, XrefRangeEnd = 176927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4A RID: 20042 RVA: 0x00188EB4 File Offset: 0x001870B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 176939, RefRangeEnd = 176943, XrefRangeStart = 176931, XrefRangeEnd = 176939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanWork()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_CanWork_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E4B RID: 20043 RVA: 0x00188EF0 File Offset: 0x001870F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176943, XrefRangeEnd = 176951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanConsumeProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_CanConsumeProduct_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E4C RID: 20044 RVA: 0x00188F38 File Offset: 0x00187138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176951, XrefRangeEnd = 176971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot GetFirstInventorySlotContainingProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_GetFirstInventorySlotContainingProduct_Protected_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x06004E4D RID: 20045 RVA: 0x00188F78 File Offset: 0x00187178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176971, XrefRangeEnd = 177000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4E RID: 20046 RVA: 0x00188FB4 File Offset: 0x001871B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177044, RefRangeEnd = 177048, XrefRangeStart = 177000, XrefRangeEnd = 177044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E4F RID: 20047 RVA: 0x00188FF0 File Offset: 0x001871F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177082, RefRangeEnd = 177083, XrefRangeStart = 177048, XrefRangeEnd = 177082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateConsumeProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_UpdateConsumeProduct_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E50 RID: 20048 RVA: 0x00189024 File Offset: 0x00187224
		[CallerCount(0)]
		public unsafe void MarkIsWorking()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E51 RID: 20049 RVA: 0x00189058 File Offset: 0x00187258
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsAnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E52 RID: 20050 RVA: 0x001890A0 File Offset: 0x001872A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177085, RefRangeEnd = 177087, XrefRangeStart = 177083, XrefRangeEnd = 177085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWaitOutside(bool wait)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref wait;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E53 RID: 20051 RVA: 0x001890E0 File Offset: 0x001872E0
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E54 RID: 20052 RVA: 0x00189128 File Offset: 0x00187328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177087, XrefRangeEnd = 177091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00189164 File Offset: 0x00187364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177091, XrefRangeEnd = 177092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnSleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00189198 File Offset: 0x00187398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 177093, RefRangeEnd = 177094, XrefRangeStart = 177092, XrefRangeEnd = 177093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsPaid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetIsPaid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x001891CC File Offset: 0x001873CC
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x00189214 File Offset: 0x00187414
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177094, XrefRangeEnd = 177105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00189260 File Offset: 0x00187460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177105, XrefRangeEnd = 177111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr3) : null;
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x001892AC File Offset: 0x001874AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177116, RefRangeEnd = 177118, XrefRangeStart = 177111, XrefRangeEnd = 177116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPayAvailable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x001892E8 File Offset: 0x001874E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177118, XrefRangeEnd = 177125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDailyWage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0018931C File Offset: 0x0018751C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177125, XrefRangeEnd = 177159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			notWorkingReason = ((intPtr4 == 0) ? null : new DialogueContainer(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00189388 File Offset: 0x00187588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177159, XrefRangeEnd = 177160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIdle(bool idle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref idle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x001893D4 File Offset: 0x001875D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177166, RefRangeEnd = 177169, XrefRangeStart = 177160, XrefRangeEnd = 177166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeavePropertyAndDespawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x00189408 File Offset: 0x00187608
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 177194, RefRangeEnd = 177206, XrefRangeStart = 177169, XrefRangeEnd = 177194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x0018946C File Offset: 0x0018766C
		[CallerCount(0)]
		public unsafe bool ShouldShowNoWorkDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x001894B8 File Offset: 0x001876B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177206, XrefRangeEnd = 177207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotWorkingDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x001894EC File Offset: 0x001876EC
		[CallerCount(0)]
		public unsafe bool ShouldShowFireDialogue(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x00189538 File Offset: 0x00187738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177207, XrefRangeEnd = 177224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x0018956C File Offset: 0x0018776C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177224, XrefRangeEnd = 177226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TradeItemsDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_TradeItemsDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x001895A0 File Offset: 0x001877A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177226, XrefRangeEnd = 177232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transitEntity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x001895F0 File Offset: 0x001877F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177249, RefRangeEnd = 177251, XrefRangeStart = 177232, XrefRangeEnd = 177249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x0018963C File Offset: 0x0018783C
		[CallerCount(0)]
		public unsafe virtual void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x00189688 File Offset: 0x00187888
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177264, RefRangeEnd = 177268, XrefRangeStart = 177251, XrefRangeEnd = 177264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x001896C4 File Offset: 0x001878C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177268, XrefRangeEnd = 177272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__53_0(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr__Awake_b__53_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00189704 File Offset: 0x00187904
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 177333, RefRangeEnd = 177337, XrefRangeStart = 177272, XrefRangeEnd = 177333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00189740 File Offset: 0x00187940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177337, XrefRangeEnd = 177338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x0018977C File Offset: 0x0018797C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x001897B8 File Offset: 0x001879B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177338, XrefRangeEnd = 177355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00189874 File Offset: 0x00187A74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 177402, RefRangeEnd = 177405, XrefRangeStart = 177355, XrefRangeEnd = 177402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x0018993C File Offset: 0x00187B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177405, XrefRangeEnd = 177415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E70 RID: 20080 RVA: 0x0018998C File Offset: 0x00187B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177415, XrefRangeEnd = 177432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyID);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E71 RID: 20081 RVA: 0x00189A48 File Offset: 0x00187C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177432, XrefRangeEnd = 177442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00189A98 File Offset: 0x00187C98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176778, RefRangeEnd = 176779, XrefRangeStart = 176778, XrefRangeEnd = 176779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendTransfer_3615296227(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00189ADC File Offset: 0x00187CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendTransfer_3615296227(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00189B20 File Offset: 0x00187D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177442, XrefRangeEnd = 177454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendTransfer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00189B84 File Offset: 0x00187D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_TransferToProperty_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00189BC8 File Offset: 0x00187DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177454, XrefRangeEnd = 177471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___TransferToProperty_3615296227(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00189C0C File Offset: 0x00187E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177471, XrefRangeEnd = 177484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_TransferToProperty_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x00189C5C File Offset: 0x00187E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00189C90 File Offset: 0x00187E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00189CC4 File Offset: 0x00187EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177484, XrefRangeEnd = 177494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00189D28 File Offset: 0x00187F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x00189D5C File Offset: 0x00187F5C
		[CallerCount(0)]
		public unsafe void RpcLogic___ReceiveFire_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x00189D90 File Offset: 0x00187F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177494, XrefRangeEnd = 177495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00189DE0 File Offset: 0x00187FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177495, XrefRangeEnd = 177508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00189E44 File Offset: 0x00188044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 177528, RefRangeEnd = 177530, XrefRangeStart = 177508, XrefRangeEnd = 177528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00189EA8 File Offset: 0x001880A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177530, XrefRangeEnd = 177537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x00189EF8 File Offset: 0x001880F8
		// (set) Token: 0x06004E82 RID: 20098 RVA: 0x00189F34 File Offset: 0x00188134
		public unsafe bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 176564, RefRangeEnd = 176565, XrefRangeStart = 176564, XrefRangeEnd = 176565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177537, XrefRangeEnd = 177545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x00189F80 File Offset: 0x00188180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177545, XrefRangeEnd = 177546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x00189FF4 File Offset: 0x001881F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177546, XrefRangeEnd = 177555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Employee.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x000255CE File Offset: 0x000237CE
		public Employee(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700185E RID: 6238
		// (get) Token: 0x06004E86 RID: 20102 RVA: 0x0018A030 File Offset: 0x00188230
		// (set) Token: 0x06004E87 RID: 20103 RVA: 0x000255D7 File Offset: 0x000237D7
		public unsafe static int MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Employee.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x1700185F RID: 6239
		// (get) Token: 0x06004E88 RID: 20104 RVA: 0x0018A04C File Offset: 0x0018824C
		// (set) Token: 0x06004E89 RID: 20105 RVA: 0x000255E5 File Offset: 0x000237E5
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001860 RID: 6240
		// (get) Token: 0x06004E8A RID: 20106 RVA: 0x0018A074 File Offset: 0x00188274
		// (set) Token: 0x06004E8B RID: 20107 RVA: 0x00025600 File Offset: 0x00023800
		public unsafe Property _AssignedProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AssignedProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001861 RID: 6241
		// (get) Token: 0x06004E8C RID: 20108 RVA: 0x0018A0A4 File Offset: 0x001882A4
		// (set) Token: 0x06004E8D RID: 20109 RVA: 0x0002561F File Offset: 0x0002381F
		public unsafe int _EmployeeIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__EmployeeIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001862 RID: 6242
		// (get) Token: 0x06004E8E RID: 20110 RVA: 0x0018A0CC File Offset: 0x001882CC
		// (set) Token: 0x06004E8F RID: 20111 RVA: 0x0002563A File Offset: 0x0002383A
		public unsafe bool _PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__PaidForToday_k__BackingField)) = value;
			}
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x0018A0F4 File Offset: 0x001882F4
		// (set) Token: 0x06004E91 RID: 20113 RVA: 0x00025655 File Offset: 0x00023855
		public unsafe bool _Fired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__Fired_k__BackingField)) = value;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06004E92 RID: 20114 RVA: 0x0018A11C File Offset: 0x0018831C
		// (set) Token: 0x06004E93 RID: 20115 RVA: 0x00025670 File Offset: 0x00023870
		public unsafe bool _IsMale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__IsMale_k__BackingField)) = value;
			}
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06004E94 RID: 20116 RVA: 0x0018A144 File Offset: 0x00188344
		// (set) Token: 0x06004E95 RID: 20117 RVA: 0x0002568B File Offset: 0x0002388B
		public unsafe int _AppearanceIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__AppearanceIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06004E96 RID: 20118 RVA: 0x0018A16C File Offset: 0x0018836C
		// (set) Token: 0x06004E97 RID: 20119 RVA: 0x000256A6 File Offset: 0x000238A6
		public unsafe EEmployeeType Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_Type)) = value;
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06004E98 RID: 20120 RVA: 0x0018A194 File Offset: 0x00188394
		// (set) Token: 0x06004E99 RID: 20121 RVA: 0x000256C1 File Offset: 0x000238C1
		public unsafe FloatStack WorkSpeedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkSpeedController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkSpeedController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06004E9A RID: 20122 RVA: 0x0018A1C4 File Offset: 0x001883C4
		// (set) Token: 0x06004E9B RID: 20123 RVA: 0x000256E0 File Offset: 0x000238E0
		public unsafe float SigningFee
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_SigningFee)) = value;
			}
		}

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06004E9C RID: 20124 RVA: 0x0018A1EC File Offset: 0x001883EC
		// (set) Token: 0x06004E9D RID: 20125 RVA: 0x000256FB File Offset: 0x000238FB
		public unsafe float DailyWage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_DailyWage)) = value;
			}
		}

		// Token: 0x1700186A RID: 6250
		// (get) Token: 0x06004E9E RID: 20126 RVA: 0x0018A214 File Offset: 0x00188414
		// (set) Token: 0x06004E9F RID: 20127 RVA: 0x00025716 File Offset: 0x00023916
		public unsafe IdleBehaviour WaitOutside
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IdleBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WaitOutside), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186B RID: 6251
		// (get) Token: 0x06004EA0 RID: 20128 RVA: 0x0018A244 File Offset: 0x00188444
		// (set) Token: 0x06004EA1 RID: 20129 RVA: 0x00025735 File Offset: 0x00023935
		public unsafe MoveItemBehaviour MoveItemBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MoveItemBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_MoveItemBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186C RID: 6252
		// (get) Token: 0x06004EA2 RID: 20130 RVA: 0x0018A274 File Offset: 0x00188474
		// (set) Token: 0x06004EA3 RID: 20131 RVA: 0x00025754 File Offset: 0x00023954
		public unsafe DialogueContainer BedNotAssignedDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_BedNotAssignedDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186D RID: 6253
		// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x0018A2A4 File Offset: 0x001884A4
		// (set) Token: 0x06004EA5 RID: 20133 RVA: 0x00025773 File Offset: 0x00023973
		public unsafe DialogueContainer NotPaidDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_NotPaidDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186E RID: 6254
		// (get) Token: 0x06004EA6 RID: 20134 RVA: 0x0018A2D4 File Offset: 0x001884D4
		// (set) Token: 0x06004EA7 RID: 20135 RVA: 0x00025792 File Offset: 0x00023992
		public unsafe DialogueContainer WorkIssueDialogueTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssueDialogueTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06004EA8 RID: 20136 RVA: 0x0018A304 File Offset: 0x00188504
		// (set) Token: 0x06004EA9 RID: 20137 RVA: 0x000257B1 File Offset: 0x000239B1
		public unsafe DialogueContainer FireDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_FireDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06004EAA RID: 20138 RVA: 0x0018A334 File Offset: 0x00188534
		// (set) Token: 0x06004EAB RID: 20139 RVA: 0x000257D0 File Offset: 0x000239D0
		public unsafe DialogueContainer TransferDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_TransferDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_TransferDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06004EAC RID: 20140 RVA: 0x0018A364 File Offset: 0x00188564
		// (set) Token: 0x06004EAD RID: 20141 RVA: 0x000257EF File Offset: 0x000239EF
		public unsafe List<Employee.NoWorkReason> WorkIssues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee.NoWorkReason>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_WorkIssues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06004EAE RID: 20142 RVA: 0x0018A394 File Offset: 0x00188594
		// (set) Token: 0x06004EAF RID: 20143 RVA: 0x0002580E File Offset: 0x00023A0E
		public unsafe int _TicksSinceLastWork_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TicksSinceLastWork_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr__TicksSinceLastWork_k__BackingField)) = value;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004EB0 RID: 20144 RVA: 0x0018A3BC File Offset: 0x001885BC
		// (set) Token: 0x06004EB1 RID: 20145 RVA: 0x00025829 File Offset: 0x00023A29
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004EB2 RID: 20146 RVA: 0x0018A3E4 File Offset: 0x001885E4
		// (set) Token: 0x06004EB3 RID: 20147 RVA: 0x00025844 File Offset: 0x00023A44
		public unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06004EB4 RID: 20148 RVA: 0x0018A40C File Offset: 0x0018860C
		// (set) Token: 0x06004EB5 RID: 20149 RVA: 0x0002585F File Offset: 0x00023A5F
		public unsafe float timeOnLastPathingFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_timeOnLastPathingFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_timeOnLastPathingFailure)) = value;
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06004EB6 RID: 20150 RVA: 0x0018A434 File Offset: 0x00188634
		// (set) Token: 0x06004EB7 RID: 20151 RVA: 0x0002587A File Offset: 0x00023A7A
		public unsafe Transform cachedNPCSpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_cachedNPCSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001877 RID: 6263
		// (get) Token: 0x06004EB8 RID: 20152 RVA: 0x0018A464 File Offset: 0x00188664
		// (set) Token: 0x06004EB9 RID: 20153 RVA: 0x00025899 File Offset: 0x00023A99
		public unsafe SyncVar<bool> syncVar____PaidForToday_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001878 RID: 6264
		// (get) Token: 0x06004EBA RID: 20154 RVA: 0x0018A494 File Offset: 0x00188694
		// (set) Token: 0x06004EBB RID: 20155 RVA: 0x000258B8 File Offset: 0x00023AB8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06004EBC RID: 20156 RVA: 0x0018A4BC File Offset: 0x001886BC
		// (set) Token: 0x06004EBD RID: 20157 RVA: 0x000258D3 File Offset: 0x00023AD3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeFieldInfoPtr__AssignedProperty_k__BackingField;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeFieldInfoPtr__EmployeeIndex_k__BackingField;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeFieldInfoPtr__PaidForToday_k__BackingField;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeFieldInfoPtr__Fired_k__BackingField;

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeFieldInfoPtr__IsMale_k__BackingField;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeFieldInfoPtr__AppearanceIndex_k__BackingField;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeFieldInfoPtr_WorkSpeedController;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeFieldInfoPtr_SigningFee;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeFieldInfoPtr_DailyWage;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeFieldInfoPtr_WaitOutside;

		// Token: 0x04003599 RID: 13721
		private static readonly IntPtr NativeFieldInfoPtr_MoveItemBehaviour;

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeFieldInfoPtr_BedNotAssignedDialogue;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeFieldInfoPtr_NotPaidDialogue;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssueDialogueTemplate;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeFieldInfoPtr_FireDialogue;

		// Token: 0x0400359E RID: 13726
		private static readonly IntPtr NativeFieldInfoPtr_TransferDialogue;

		// Token: 0x0400359F RID: 13727
		private static readonly IntPtr NativeFieldInfoPtr_WorkIssues;

		// Token: 0x040035A0 RID: 13728
		private static readonly IntPtr NativeFieldInfoPtr__TicksSinceLastWork_k__BackingField;

		// Token: 0x040035A1 RID: 13729
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040035A2 RID: 13730
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x040035A3 RID: 13731
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastPathingFailure;

		// Token: 0x040035A4 RID: 13732
		private static readonly IntPtr NativeFieldInfoPtr_cachedNPCSpawnPoint;

		// Token: 0x040035A5 RID: 13733
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PaidForToday_k__BackingField;

		// Token: 0x040035A6 RID: 13734
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040035A7 RID: 13735
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040035A8 RID: 13736
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedProperty_Public_get_Property_0;

		// Token: 0x040035A9 RID: 13737
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedProperty_Protected_set_Void_Property_0;

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeIndex_Public_get_Int32_0;

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeMethodInfoPtr_set_EmployeeIndex_Protected_set_Void_Int32_0;

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeMethodInfoPtr_get_PaidForToday_Public_get_Boolean_0;

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeMethodInfoPtr_set_PaidForToday_Private_set_Void_Boolean_0;

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeMethodInfoPtr_get_Fired_Public_get_Boolean_0;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeMethodInfoPtr_set_Fired_Private_set_Void_Boolean_0;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaitingOutside_Public_get_Boolean_0;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeMethodInfoPtr_get_IsMale_Public_get_Boolean_0;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeMethodInfoPtr_set_IsMale_Private_set_Void_Boolean_0;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeMethodInfoPtr_get_AppearanceIndex_Protected_get_Int32_0;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeMethodInfoPtr_set_AppearanceIndex_Private_set_Void_Int32_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeMethodInfoPtr_get_EmployeeType_Public_get_EEmployeeType_0;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentWorkSpeed_Public_get_Single_0;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeMethodInfoPtr_get_TicksSinceLastWork_Public_get_Int32_0;

		// Token: 0x040035B8 RID: 13752
		private static readonly IntPtr NativeMethodInfoPtr_set_TicksSinceLastWork_Private_set_Void_Int32_0;

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_New_Void_Property_Boolean_0;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_New_Void_0;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeMethodInfoPtr_SendTransfer_Public_Void_String_0;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeMethodInfoPtr_TransferToProperty_Private_Void_String_0;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeMethodInfoPtr_TransferToProperty_Protected_Virtual_New_Void_Property_0;

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInfo_Protected_Virtual_New_Void_String_String_String_0;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAppearance_Protected_Virtual_New_Void_Boolean_Int32_0;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeMethodInfoPtr_CheckDialogueChoice_Protected_Virtual_New_Void_String_0;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeMethodInfoPtr_SendFire_Public_Void_0;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveFire_Private_Void_0;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_New_Void_0;

		// Token: 0x040035C9 RID: 13769
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_New_Void_0;

		// Token: 0x040035CA RID: 13770
		private static readonly IntPtr NativeMethodInfoPtr_CanWork_Protected_Boolean_0;

		// Token: 0x040035CB RID: 13771
		private static readonly IntPtr NativeMethodInfoPtr_CanConsumeProduct_Protected_Virtual_New_Boolean_0;

		// Token: 0x040035CC RID: 13772
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstInventorySlotContainingProduct_Protected_ItemSlot_0;

		// Token: 0x040035CD RID: 13773
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x040035CE RID: 13774
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_New_Void_0;

		// Token: 0x040035CF RID: 13775
		private static readonly IntPtr NativeMethodInfoPtr_UpdateConsumeProduct_Private_Void_0;

		// Token: 0x040035D0 RID: 13776
		private static readonly IntPtr NativeMethodInfoPtr_MarkIsWorking_Protected_Void_0;

		// Token: 0x040035D1 RID: 13777
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_New_Boolean_0;

		// Token: 0x040035D2 RID: 13778
		private static readonly IntPtr NativeMethodInfoPtr_SetWaitOutside_Private_Void_Boolean_0;

		// Token: 0x040035D3 RID: 13779
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_New_Boolean_0;

		// Token: 0x040035D4 RID: 13780
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_1;

		// Token: 0x040035D5 RID: 13781
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepEnd_Private_Void_0;

		// Token: 0x040035D6 RID: 13782
		private static readonly IntPtr NativeMethodInfoPtr_SetIsPaid_Public_Void_0;

		// Token: 0x040035D7 RID: 13783
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x040035D8 RID: 13784
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x040035D9 RID: 13785
		private static readonly IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_New_EmployeeHome_0;

		// Token: 0x040035DA RID: 13786
		private static readonly IntPtr NativeMethodInfoPtr_IsPayAvailable_Public_Boolean_0;

		// Token: 0x040035DB RID: 13787
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDailyWage_Public_Void_0;

		// Token: 0x040035DC RID: 13788
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkIssue_Public_Virtual_New_Boolean_byref_DialogueContainer_0;

		// Token: 0x040035DD RID: 13789
		private static readonly IntPtr NativeMethodInfoPtr_SetIdle_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040035DE RID: 13790
		private static readonly IntPtr NativeMethodInfoPtr_LeavePropertyAndDespawn_Protected_Void_0;

		// Token: 0x040035DF RID: 13791
		private static readonly IntPtr NativeMethodInfoPtr_SubmitNoWorkReason_Public_Void_String_String_Int32_0;

		// Token: 0x040035E0 RID: 13792
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowNoWorkDialogue_Private_Boolean_Boolean_0;

		// Token: 0x040035E1 RID: 13793
		private static readonly IntPtr NativeMethodInfoPtr_OnNotWorkingDialogue_Private_Void_0;

		// Token: 0x040035E2 RID: 13794
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShowFireDialogue_Private_Boolean_Boolean_0;

		// Token: 0x040035E3 RID: 13795
		private static readonly IntPtr NativeMethodInfoPtr_TradeItems_Private_Void_0;

		// Token: 0x040035E4 RID: 13796
		private static readonly IntPtr NativeMethodInfoPtr_TradeItemsDone_Private_Void_0;

		// Token: 0x040035E5 RID: 13797
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_ITransitEntity_Boolean_0;

		// Token: 0x040035E6 RID: 13798
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Void_Vector3_Boolean_0;

		// Token: 0x040035E7 RID: 13799
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_New_Void_WalkResult_0;

		// Token: 0x040035E8 RID: 13800
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035E9 RID: 13801
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__53_0_Private_Void_Single_0;

		// Token: 0x040035EA RID: 13802
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040035EB RID: 13803
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040035EC RID: 13804
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040035ED RID: 13805
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x040035EE RID: 13806
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Initialize_2260823878_Public_Virtual_New_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x040035EF RID: 13807
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035F0 RID: 13808
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Initialize_2260823878_Private_Void_NetworkConnection_String_String_String_String_String_Boolean_Int32_0;

		// Token: 0x040035F1 RID: 13809
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Initialize_2260823878_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035F2 RID: 13810
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendTransfer_3615296227_Private_Void_String_0;

		// Token: 0x040035F3 RID: 13811
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendTransfer_3615296227_Public_Void_String_0;

		// Token: 0x040035F4 RID: 13812
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendTransfer_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035F5 RID: 13813
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_TransferToProperty_3615296227_Private_Void_String_0;

		// Token: 0x040035F6 RID: 13814
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___TransferToProperty_3615296227_Private_Void_String_0;

		// Token: 0x040035F7 RID: 13815
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_TransferToProperty_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035F8 RID: 13816
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendFire_2166136261_Private_Void_0;

		// Token: 0x040035F9 RID: 13817
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendFire_2166136261_Public_Void_0;

		// Token: 0x040035FA RID: 13818
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendFire_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040035FB RID: 13819
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x040035FC RID: 13820
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveFire_2166136261_Private_Void_0;

		// Token: 0x040035FD RID: 13821
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveFire_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040035FE RID: 13822
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SubmitNoWorkReason_15643032_Private_Void_String_String_Int32_0;

		// Token: 0x040035FF RID: 13823
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SubmitNoWorkReason_15643032_Public_Void_String_String_Int32_0;

		// Token: 0x04003600 RID: 13824
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SubmitNoWorkReason_15643032_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003601 RID: 13825
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PaidForToday_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04003602 RID: 13826
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PaidForToday_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04003603 RID: 13827
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Employee_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003604 RID: 13828
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A88 RID: 2696
		public class NoWorkReason : Il2CppSystem.Object
		{
			// Token: 0x0600E1CE RID: 57806 RVA: 0x00376D74 File Offset: 0x00374F74
			// Note: this type is marked as 'beforefieldinit'.
			static NoWorkReason()
			{
				Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Employee>.NativeClassPtr, "NoWorkReason");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr);
				Employee.NoWorkReason.NativeFieldInfoPtr_Reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Reason");
				Employee.NoWorkReason.NativeFieldInfoPtr_Fix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Fix");
				Employee.NoWorkReason.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, "Priority");
				Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr, 100673547);
			}

			// Token: 0x0600E1CF RID: 57807 RVA: 0x00376DF0 File Offset: 0x00374FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176555, XrefRangeEnd = 176558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoWorkReason(string reason, string fix, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee.NoWorkReason>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fix);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.NoWorkReason.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1D0 RID: 57808 RVA: 0x0006A682 File Offset: 0x00068882
			public NoWorkReason(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B8 RID: 17592
			// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x00376E5C File Offset: 0x0037505C
			// (set) Token: 0x0600E1D2 RID: 57810 RVA: 0x0006A68B File Offset: 0x0006888B
			public unsafe string Reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Reason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044B9 RID: 17593
			// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x00376E84 File Offset: 0x00375084
			// (set) Token: 0x0600E1D4 RID: 57812 RVA: 0x0006A6AA File Offset: 0x000688AA
			public unsafe string Fix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Fix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170044BA RID: 17594
			// (get) Token: 0x0600E1D5 RID: 57813 RVA: 0x00376EAC File Offset: 0x003750AC
			// (set) Token: 0x0600E1D6 RID: 57814 RVA: 0x0006A6C9 File Offset: 0x000688C9
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Employee.NoWorkReason.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x040099B3 RID: 39347
			private static readonly IntPtr NativeFieldInfoPtr_Reason;

			// Token: 0x040099B4 RID: 39348
			private static readonly IntPtr NativeFieldInfoPtr_Fix;

			// Token: 0x040099B5 RID: 39349
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x040099B6 RID: 39350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
		}

		// Token: 0x02000A89 RID: 2697
		[ObfuscatedName("ScheduleOne.Employees.Employee+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E1D7 RID: 57815 RVA: 0x00376ED4 File Offset: 0x003750D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Employee.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Employee>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr);
				Employee.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr, "<>9");
				Employee.__c.NativeFieldInfoPtr___9__72_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr, "<>9__72_0");
				Employee.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr, 100673549);
				Employee.__c.NativeMethodInfoPtr__GetFirstInventorySlotContainingProduct_b__72_0_Internal_Boolean_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr, 100673550);
			}

			// Token: 0x0600E1D8 RID: 57816 RVA: 0x00376F50 File Offset: 0x00375150
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Employee.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1D9 RID: 57817 RVA: 0x00376F8C File Offset: 0x0037518C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176558, XrefRangeEnd = 176563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFirstInventorySlotContainingProduct_b__72_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Employee.__c.NativeMethodInfoPtr__GetFirstInventorySlotContainingProduct_b__72_0_Internal_Boolean_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1DA RID: 57818 RVA: 0x0006A6E4 File Offset: 0x000688E4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044BB RID: 17595
			// (get) Token: 0x0600E1DB RID: 57819 RVA: 0x00376FDC File Offset: 0x003751DC
			// (set) Token: 0x0600E1DC RID: 57820 RVA: 0x0006A6ED File Offset: 0x000688ED
			public unsafe static Employee.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Employee.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Employee.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Employee.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BC RID: 17596
			// (get) Token: 0x0600E1DD RID: 57821 RVA: 0x00377004 File Offset: 0x00375204
			// (set) Token: 0x0600E1DE RID: 57822 RVA: 0x0006A6FF File Offset: 0x000688FF
			public unsafe static Func<ItemSlot, bool> __9__72_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Employee.__c.NativeFieldInfoPtr___9__72_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Employee.__c.NativeFieldInfoPtr___9__72_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099B7 RID: 39351
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040099B8 RID: 39352
			private static readonly IntPtr NativeFieldInfoPtr___9__72_0;

			// Token: 0x040099B9 RID: 39353
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099BA RID: 39354
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstInventorySlotContainingProduct_b__72_0_Internal_Boolean_ItemSlot_0;
		}
	}
}
