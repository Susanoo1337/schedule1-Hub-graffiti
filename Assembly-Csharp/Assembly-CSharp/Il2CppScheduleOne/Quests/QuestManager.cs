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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.GameTime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x02000142 RID: 322
	public class QuestManager : NetworkSingleton<QuestManager>
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x000E6990 File Offset: 0x000E4B90
		// Note: this type is marked as 'beforefieldinit'.
		static QuestManager()
		{
			Il2CppClassPointerStore<QuestManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager>.NativeClassPtr);
			QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DEFAULT_QUEST_STATE");
			QuestManager.NativeFieldInfoPtr_DefaultQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DefaultQuests");
			QuestManager.NativeFieldInfoPtr_QuestContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestContainer");
			QuestManager.NativeFieldInfoPtr_ContractContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "ContractContainer");
			QuestManager.NativeFieldInfoPtr_QuestCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestCompleteSound");
			QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "QuestEntryCompleteSound");
			QuestManager.NativeFieldInfoPtr_ContractPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "ContractPrefab");
			QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "DeaddropCollectionPrefab");
			QuestManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "loader");
			QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			QuestManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted");
			QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Quests.QuestManagerAssembly-CSharp.dll_Excuted");
			QuestManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667531);
			QuestManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667532);
			QuestManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667533);
			QuestManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667534);
			QuestManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667535);
			QuestManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667536);
			QuestManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667537);
			QuestManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667538);
			QuestManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667539);
			QuestManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667540);
			QuestManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667541);
			QuestManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667542);
			QuestManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667543);
			QuestManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667544);
			QuestManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667545);
			QuestManager.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667546);
			QuestManager.NativeMethodInfoPtr_ContractAccepted_Public_Contract_Customer_ContractInfo_Boolean_String_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667547);
			QuestManager.NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667548);
			QuestManager.NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_Customer_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667549);
			QuestManager.NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667550);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667551);
			QuestManager.NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667552);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667553);
			QuestManager.NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667554);
			QuestManager.NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667555);
			QuestManager.NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667556);
			QuestManager.NativeMethodInfoPtr_PrintQuestStates_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667557);
			QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667558);
			QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667559);
			QuestManager.NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667560);
			QuestManager.NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667561);
			QuestManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667562);
			QuestManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667563);
			QuestManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667564);
			QuestManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667565);
			QuestManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667566);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667567);
			QuestManager.NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_2526053753_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667568);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667569);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667570);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667571);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667572);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667573);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667574);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667575);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667576);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667577);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667578);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667579);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667580);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667581);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667582);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667583);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667584);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667585);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667586);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667587);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667588);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667589);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667590);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667591);
			QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667592);
			QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667593);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667594);
			QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667595);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667596);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667597);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667598);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667599);
			QuestManager.NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667600);
			QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667601);
			QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667602);
			QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667603);
			QuestManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, 100667604);
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000E70B4 File Offset: 0x000E52B4
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109084, XrefRangeEnd = 109086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x000E70EC File Offset: 0x000E52EC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109086, XrefRangeEnd = 109088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000E7124 File Offset: 0x000E5324
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x060020CD RID: 8397 RVA: 0x000E7164 File Offset: 0x000E5364
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000E71A0 File Offset: 0x000E53A0
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x000E71E0 File Offset: 0x000E53E0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109088, XrefRangeEnd = 109089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000E7224 File Offset: 0x000E5424
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x000E7264 File Offset: 0x000E5464
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109089, XrefRangeEnd = 109090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000E72A8 File Offset: 0x000E54A8
		// (set) Token: 0x060020D3 RID: 8403 RVA: 0x000E72E4 File Offset: 0x000E54E4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x000E7324 File Offset: 0x000E5524
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x000E7360 File Offset: 0x000E5560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109096, XrefRangeEnd = 109117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x000E739C File Offset: 0x000E559C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109117, XrefRangeEnd = 109123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x000E73D8 File Offset: 0x000E55D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109123, XrefRangeEnd = 109129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x000E7414 File Offset: 0x000E5614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109129, XrefRangeEnd = 109139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x000E7464 File Offset: 0x000E5664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109139, XrefRangeEnd = 109153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000E7498 File Offset: 0x000E5698
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109237, RefRangeEnd = 109238, XrefRangeStart = 109153, XrefRangeEnd = 109237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract ContractAccepted(Customer customer, ContractInfo contractData, bool track, string guid, Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref track;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ContractAccepted_Public_Contract_Customer_ContractInfo_Boolean_String_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x000E7530 File Offset: 0x000E5730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109296, RefRangeEnd = 109298, XrefRangeStart = 109238, XrefRangeEnd = 109296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateContract_Networked(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x000E7610 File Offset: 0x000E5810
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109330, RefRangeEnd = 109335, XrefRangeStart = 109298, XrefRangeEnd = 109330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Contract CreateContract_Local(string title, string description, Il2CppReferenceArray<QuestEntryData> entries, string guid, bool tracked, Customer customer, float payment, ProductList products, string deliveryLocationGUID, QuestWindowConfig deliveryWindow, bool expires, GameDateTime expiry, int pickupScheduleIndex, GameDateTime acceptTime, Dealer dealer = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entries);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref payment;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(products);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(deliveryLocationGUID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryWindow);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expires;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickupScheduleIndex;
			ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_Customer_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr3) : null;
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000E7754 File Offset: 0x000E5954
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 109357, RefRangeEnd = 109365, XrefRangeStart = 109335, XrefRangeEnd = 109357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestAction(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x000E77A4 File Offset: 0x000E59A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109406, RefRangeEnd = 109409, XrefRangeStart = 109365, XrefRangeEnd = 109406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestAction(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x000E7808 File Offset: 0x000E5A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109409, XrefRangeEnd = 109431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestState(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x000E7858 File Offset: 0x000E5A58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109472, RefRangeEnd = 109477, XrefRangeStart = 109431, XrefRangeEnd = 109472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestState(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x000E78BC File Offset: 0x000E5ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109488, RefRangeEnd = 109489, XrefRangeStart = 109477, XrefRangeEnd = 109488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuestTracked(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x000E7920 File Offset: 0x000E5B20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109513, RefRangeEnd = 109514, XrefRangeStart = 109489, XrefRangeEnd = 109513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendQuestEntryState(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x000E7980 File Offset: 0x000E5B80
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 109559, RefRangeEnd = 109564, XrefRangeStart = 109514, XrefRangeEnd = 109559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveQuestEntryState(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x000E79F0 File Offset: 0x000E5BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109564, XrefRangeEnd = 109588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintQuestStates()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PrintQuestStates_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000E7A24 File Offset: 0x000E5C24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109629, RefRangeEnd = 109631, XrefRangeStart = 109588, XrefRangeEnd = 109629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDeaddropCollectionQuest(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000E7A8C File Offset: 0x000E5C8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109683, RefRangeEnd = 109689, XrefRangeStart = 109631, XrefRangeEnd = 109683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeaddropQuest CreateDeaddropCollectionQuest(string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeaddropQuest>(intPtr3) : null;
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000E7AF0 File Offset: 0x000E5CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109689, XrefRangeEnd = 109692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCompleteQuestSound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000E7B24 File Offset: 0x000E5D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109692, XrefRangeEnd = 109693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayCompleteQuestEntrySound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000E7B58 File Offset: 0x000E5D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109693, XrefRangeEnd = 109794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000E7B9C File Offset: 0x000E5D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109794, XrefRangeEnd = 109814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000E7BD8 File Offset: 0x000E5DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109814, XrefRangeEnd = 109903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000E7C14 File Offset: 0x000E5E14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109903, XrefRangeEnd = 109906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000E7C50 File Offset: 0x000E5E50
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000E7C8C File Offset: 0x000E5E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109906, XrefRangeEnd = 109924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000E7D6C File Offset: 0x000E5F6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109959, RefRangeEnd = 109962, XrefRangeStart = 109924, XrefRangeEnd = 109959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_2526053753_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000E7E4C File Offset: 0x000E604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109962, XrefRangeEnd = 109973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000E7E9C File Offset: 0x000E609C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109973, XrefRangeEnd = 109991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateContract_Networked_2526053753(NetworkConnection conn, string title, string description, string guid, bool tracked, NetworkObject customer, ContractInfo contractData, GameDateTime expiry, GameDateTime acceptTime, NetworkObject dealerObj = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contractData);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expiry;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref acceptTime;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dealerObj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000E7F7C File Offset: 0x000E617C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109991, XrefRangeEnd = 110002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateContract_Networked_2526053753(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000E7FCC File Offset: 0x000E61CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110002, XrefRangeEnd = 110013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000E801C File Offset: 0x000E621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110013, XrefRangeEnd = 110014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestAction_2848227116(string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000E806C File Offset: 0x000E626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110014, XrefRangeEnd = 110019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestAction_2848227116(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000E80D0 File Offset: 0x000E62D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110019, XrefRangeEnd = 110030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000E8134 File Offset: 0x000E6334
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110043, RefRangeEnd = 110046, XrefRangeStart = 110030, XrefRangeEnd = 110043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000E8198 File Offset: 0x000E6398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110046, XrefRangeEnd = 110051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000E81E8 File Offset: 0x000E63E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110051, XrefRangeEnd = 110062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestAction_920727549(NetworkConnection conn, string guid, QuestManager.EQuestAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000E824C File Offset: 0x000E644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110062, XrefRangeEnd = 110067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestAction_920727549(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000E829C File Offset: 0x000E649C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110067, XrefRangeEnd = 110078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestState_4117703421(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000E82EC File Offset: 0x000E64EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110078, XrefRangeEnd = 110079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestState_4117703421(string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000E833C File Offset: 0x000E653C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110079, XrefRangeEnd = 110084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestState_4117703421(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000E83A0 File Offset: 0x000E65A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110084, XrefRangeEnd = 110095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000E8404 File Offset: 0x000E6604
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110108, RefRangeEnd = 110111, XrefRangeStart = 110095, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000E8468 File Offset: 0x000E6668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110111, XrefRangeEnd = 110116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000E84B8 File Offset: 0x000E66B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110116, XrefRangeEnd = 110127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestState_3887376304(NetworkConnection conn, string guid, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000E851C File Offset: 0x000E671C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110127, XrefRangeEnd = 110132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestState_3887376304(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000E856C File Offset: 0x000E676C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109488, RefRangeEnd = 109489, XrefRangeStart = 109488, XrefRangeEnd = 109489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000E85D0 File Offset: 0x000E67D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110132, XrefRangeEnd = 110145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetQuestTracked_619441887(NetworkConnection conn, string guid, bool tracked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tracked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000E8634 File Offset: 0x000E6834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110145, XrefRangeEnd = 110161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetQuestTracked_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000E8684 File Offset: 0x000E6884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110161, XrefRangeEnd = 110174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000E86E4 File Offset: 0x000E68E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110174, XrefRangeEnd = 110175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendQuestEntryState_375159588(string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000E8744 File Offset: 0x000E6944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110175, XrefRangeEnd = 110182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendQuestEntryState_375159588(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000E87A8 File Offset: 0x000E69A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110182, XrefRangeEnd = 110195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000E8818 File Offset: 0x000E6A18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110208, RefRangeEnd = 110211, XrefRangeStart = 110195, XrefRangeEnd = 110208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000E8888 File Offset: 0x000E6A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110211, XrefRangeEnd = 110218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000E88D8 File Offset: 0x000E6AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110218, XrefRangeEnd = 110231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveQuestEntryState_311789429(NetworkConnection conn, string guid, int entryIndex, EQuestState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000E8948 File Offset: 0x000E6B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110231, XrefRangeEnd = 110238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveQuestEntryState_311789429(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000E8998 File Offset: 0x000E6B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110238, XrefRangeEnd = 110249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000E8A00 File Offset: 0x000E6C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110249, XrefRangeEnd = 110250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000E8A68 File Offset: 0x000E6C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110250, XrefRangeEnd = 110255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000E8AB8 File Offset: 0x000E6CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110255, XrefRangeEnd = 110266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758(NetworkConnection conn, string dropGUID, string guidString = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dropGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guidString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000E8B20 File Offset: 0x000E6D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110266, XrefRangeEnd = 110271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_CreateDeaddropCollectionQuest_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000E8B70 File Offset: 0x000E6D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110271, XrefRangeEnd = 110290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QuestManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00011A2F File Offset: 0x0000FC2F
		public QuestManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x000E8BAC File Offset: 0x000E6DAC
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x00011A38 File Offset: 0x0000FC38
		public unsafe static EQuestState DEFAULT_QUEST_STATE
		{
			get
			{
				EQuestState result;
				IL2CPP.il2cpp_field_static_get_value(QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(QuestManager.NativeFieldInfoPtr_DEFAULT_QUEST_STATE, (void*)(&value));
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x000E8BC8 File Offset: 0x000E6DC8
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x00011A46 File Offset: 0x0000FC46
		public unsafe Il2CppReferenceArray<Quest> DefaultQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DefaultQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DefaultQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x000E8BF8 File Offset: 0x000E6DF8
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x00011A65 File Offset: 0x0000FC65
		public unsafe Transform QuestContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x000E8C28 File Offset: 0x000E6E28
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x00011A84 File Offset: 0x0000FC84
		public unsafe Transform ContractContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x000E8C58 File Offset: 0x000E6E58
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x00011AA3 File Offset: 0x0000FCA3
		public unsafe AudioSourceController QuestCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000E8C88 File Offset: 0x000E6E88
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x00011AC2 File Offset: 0x0000FCC2
		public unsafe AudioSourceController QuestEntryCompleteSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_QuestEntryCompleteSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x000E8CB8 File Offset: 0x000E6EB8
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x00011AE1 File Offset: 0x0000FCE1
		public unsafe Contract ContractPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_ContractPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06002123 RID: 8483 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
		// (set) Token: 0x06002124 RID: 8484 RVA: 0x00011B00 File Offset: 0x0000FD00
		public unsafe DeaddropQuest DeaddropCollectionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeaddropQuest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_DeaddropCollectionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06002125 RID: 8485 RVA: 0x000E8D18 File Offset: 0x000E6F18
		// (set) Token: 0x06002126 RID: 8486 RVA: 0x00011B1F File Offset: 0x0000FD1F
		public unsafe QuestsLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestsLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002127 RID: 8487 RVA: 0x000E8D48 File Offset: 0x000E6F48
		// (set) Token: 0x06002128 RID: 8488 RVA: 0x00011B3E File Offset: 0x0000FD3E
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002129 RID: 8489 RVA: 0x000E8D78 File Offset: 0x000E6F78
		// (set) Token: 0x0600212A RID: 8490 RVA: 0x00011B5D File Offset: 0x0000FD5D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600212B RID: 8491 RVA: 0x000E8DA8 File Offset: 0x000E6FA8
		// (set) Token: 0x0600212C RID: 8492 RVA: 0x00011B7C File Offset: 0x0000FD7C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000E8DD0 File Offset: 0x000E6FD0
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x00011B97 File Offset: 0x0000FD97
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x000E8DF8 File Offset: 0x000E6FF8
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x00011BB2 File Offset: 0x0000FDB2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000E8E20 File Offset: 0x000E7020
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x00011BCD File Offset: 0x0000FDCD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_QUEST_STATE;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuests;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeFieldInfoPtr_QuestContainer;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeFieldInfoPtr_ContractContainer;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeFieldInfoPtr_QuestCompleteSound;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeFieldInfoPtr_QuestEntryCompleteSound;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeFieldInfoPtr_ContractPrefab;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeFieldInfoPtr_DeaddropCollectionPrefab;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040016CC RID: 5836
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040016CD RID: 5837
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x040016CE RID: 5838
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040016CF RID: 5839
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040016D0 RID: 5840
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x040016D1 RID: 5841
		private static readonly IntPtr NativeMethodInfoPtr_ContractAccepted_Public_Contract_Customer_ContractInfo_Boolean_String_Dealer_0;

		// Token: 0x040016D2 RID: 5842
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Networked_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x040016D3 RID: 5843
		private static readonly IntPtr NativeMethodInfoPtr_CreateContract_Local_Public_Contract_String_String_Il2CppReferenceArray_1_QuestEntryData_String_Boolean_Customer_Single_ProductList_String_QuestWindowConfig_Boolean_GameDateTime_Int32_GameDateTime_Dealer_0;

		// Token: 0x040016D4 RID: 5844
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestAction_Public_Void_String_EQuestAction_0;

		// Token: 0x040016D5 RID: 5845
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestAction_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x040016D6 RID: 5846
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestState_Public_Void_String_EQuestState_0;

		// Token: 0x040016D7 RID: 5847
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestState_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x040016D8 RID: 5848
		private static readonly IntPtr NativeMethodInfoPtr_SetQuestTracked_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040016D9 RID: 5849
		private static readonly IntPtr NativeMethodInfoPtr_SendQuestEntryState_Public_Void_String_Int32_EQuestState_0;

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveQuestEntryState_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeMethodInfoPtr_PrintQuestStates_Public_Void_0;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeMethodInfoPtr_CreateDeaddropCollectionQuest_Public_DeaddropQuest_String_String_0;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeMethodInfoPtr_PlayCompleteQuestSound_Public_Void_0;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeMethodInfoPtr_PlayCompleteQuestEntrySound_Public_Void_0;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateContract_Networked_2526053753_Public_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateContract_Networked_2526053753_Private_Void_NetworkConnection_String_String_String_Boolean_NetworkObject_ContractInfo_GameDateTime_GameDateTime_NetworkObject_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateContract_Networked_2526053753_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestAction_2848227116_Private_Void_String_EQuestAction_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestAction_2848227116_Public_Void_String_EQuestAction_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestAction_2848227116_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestAction_920727549_Private_Void_NetworkConnection_String_EQuestAction_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestAction_920727549_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016F2 RID: 5874
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestState_4117703421_Private_Void_String_EQuestState_0;

		// Token: 0x040016F3 RID: 5875
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestState_4117703421_Public_Void_String_EQuestState_0;

		// Token: 0x040016F4 RID: 5876
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestState_4117703421_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040016F5 RID: 5877
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x040016F6 RID: 5878
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x040016F7 RID: 5879
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016F8 RID: 5880
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestState_3887376304_Private_Void_NetworkConnection_String_EQuestState_0;

		// Token: 0x040016F9 RID: 5881
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestState_3887376304_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016FA RID: 5882
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040016FB RID: 5883
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetQuestTracked_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x040016FC RID: 5884
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetQuestTracked_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x040016FD RID: 5885
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendQuestEntryState_375159588_Private_Void_String_Int32_EQuestState_0;

		// Token: 0x040016FE RID: 5886
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendQuestEntryState_375159588_Public_Void_String_Int32_EQuestState_0;

		// Token: 0x040016FF RID: 5887
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendQuestEntryState_375159588_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001700 RID: 5888
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001701 RID: 5889
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001702 RID: 5890
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001703 RID: 5891
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveQuestEntryState_311789429_Private_Void_NetworkConnection_String_Int32_EQuestState_0;

		// Token: 0x04001704 RID: 5892
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveQuestEntryState_311789429_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001705 RID: 5893
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04001706 RID: 5894
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateDeaddropCollectionQuest_3895153758_Public_Void_NetworkConnection_String_String_0;

		// Token: 0x04001707 RID: 5895
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001708 RID: 5896
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04001709 RID: 5897
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_CreateDeaddropCollectionQuest_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400170A RID: 5898
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200096B RID: 2411
		[OriginalName("Assembly-CSharp.dll", "", "EQuestAction")]
		public enum EQuestAction
		{
			// Token: 0x0400945A RID: 37978
			Begin,
			// Token: 0x0400945B RID: 37979
			Success,
			// Token: 0x0400945C RID: 37980
			Fail,
			// Token: 0x0400945D RID: 37981
			Expire,
			// Token: 0x0400945E RID: 37982
			Cancel
		}

		// Token: 0x0200096C RID: 2412
		[ObfuscatedName("ScheduleOne.Quests.QuestManager+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D958 RID: 55640 RVA: 0x0035F248 File Offset: 0x0035D448
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestManager>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr);
				QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, "connection");
				QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, 100667605);
				QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, 100667606);
				QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, 100667607);
			}

			// Token: 0x0600D959 RID: 55641 RVA: 0x0035F2D8 File Offset: 0x0035D4D8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D95A RID: 55642 RVA: 0x0035F314 File Offset: 0x0035D514
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109078, RefRangeEnd = 109079, XrefRangeStart = 109073, XrefRangeEnd = 109078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D95B RID: 55643 RVA: 0x0035F354 File Offset: 0x0035D554
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109079, XrefRangeEnd = 109084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnSpawnServer_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D95C RID: 55644 RVA: 0x0006634E File Offset: 0x0006454E
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004260 RID: 16992
			// (get) Token: 0x0600D95D RID: 55645 RVA: 0x0035F390 File Offset: 0x0035D590
			// (set) Token: 0x0600D95E RID: 55646 RVA: 0x00066357 File Offset: 0x00064557
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004261 RID: 16993
			// (get) Token: 0x0600D95F RID: 55647 RVA: 0x0035F3C0 File Offset: 0x0035D5C0
			// (set) Token: 0x0600D960 RID: 55648 RVA: 0x00066376 File Offset: 0x00064576
			public unsafe QuestManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400945F RID: 37983
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x04009460 RID: 37984
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009461 RID: 37985
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009462 RID: 37986
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04009463 RID: 37987
			private static readonly IntPtr NativeMethodInfoPtr__OnSpawnServer_b__1_Internal_Boolean_0;

			// Token: 0x02000DB4 RID: 3508
			[ObfuscatedName("ScheduleOne.Quests.QuestManager+<>c__DisplayClass36_0+<<OnSpawnServer>g__SendQuestStuff|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FD8B RID: 64907 RVA: 0x003C5F70 File Offset: 0x003C4170
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0>.NativeClassPtr, "<<OnSpawnServer>g__SendQuestStuff|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667608);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667609);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667610);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667611);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667612);
					QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667613);
				}

				// Token: 0x0600FD8C RID: 64908 RVA: 0x003C6050 File Offset: 0x003C4250
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD8D RID: 64909 RVA: 0x003C6098 File Offset: 0x003C4298
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD8E RID: 64910 RVA: 0x003C60CC File Offset: 0x003C42CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108975, XrefRangeEnd = 109068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D13 RID: 19731
				// (get) Token: 0x0600FD8F RID: 64911 RVA: 0x003C6108 File Offset: 0x003C4308
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD90 RID: 64912 RVA: 0x003C6148 File Offset: 0x003C4348
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109068, XrefRangeEnd = 109073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D14 RID: 19732
				// (get) Token: 0x0600FD91 RID: 64913 RVA: 0x003C617C File Offset: 0x003C437C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD92 RID: 64914 RVA: 0x000781A1 File Offset: 0x000763A1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D10 RID: 19728
				// (get) Token: 0x0600FD93 RID: 64915 RVA: 0x003C61BC File Offset: 0x003C43BC
				// (set) Token: 0x0600FD94 RID: 64916 RVA: 0x000781AA File Offset: 0x000763AA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D11 RID: 19729
				// (get) Token: 0x0600FD95 RID: 64917 RVA: 0x003C61E4 File Offset: 0x003C43E4
				// (set) Token: 0x0600FD96 RID: 64918 RVA: 0x000781C5 File Offset: 0x000763C5
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D12 RID: 19730
				// (get) Token: 0x0600FD97 RID: 64919 RVA: 0x003C6214 File Offset: 0x003C4414
				// (set) Token: 0x0600FD98 RID: 64920 RVA: 0x000781E4 File Offset: 0x000763E4
				public unsafe QuestManager.__c__DisplayClass36_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<QuestManager.__c__DisplayClass36_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QuestManager.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AAEE RID: 43758
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AAEF RID: 43759
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AAF0 RID: 43760
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AAF1 RID: 43761
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AAF2 RID: 43762
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAF3 RID: 43763
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AAF4 RID: 43764
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AAF5 RID: 43765
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAF6 RID: 43766
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
