using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000680 RID: 1664
	public class NPCBehaviour : NetworkBehaviour
	{
		// Token: 0x0600A09C RID: 41116 RVA: 0x002ACD40 File Offset: 0x002AAF40
		// Note: this type is marked as 'beforefieldinit'.
		static NPCBehaviour()
		{
			Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "NPCBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr);
			NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DEBUG_MODE");
			NPCBehaviour.NativeFieldInfoPtr_ScheduleManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ScheduleManager");
			NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CoweringBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RagdollBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CallPoliceBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "GenericDialogueBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "HeavyFlinchBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FaceTargetBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FaceTargetBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "DeadBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "UnconsciousBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "SummonBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "ConsumeProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "CombatBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "FleeBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "StationaryBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "RequestProductBehaviour");
			NPCBehaviour.NativeFieldInfoPtr_behaviourStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "behaviourStack");
			NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<activeBehaviour>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<Npc>k__BackingField");
			NPCBehaviour.NativeFieldInfoPtr_summonRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "summonRoutine");
			NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "enabledBehaviours");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.NPCBehaviourAssembly-CSharp.dll_Excuted");
			NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684504);
			NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684505);
			NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684506);
			NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684507);
			NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684508);
			NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684509);
			NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684510);
			NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684511);
			NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684512);
			NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684513);
			NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684514);
			NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684515);
			NPCBehaviour.NativeMethodInfoPtr_OnRevive_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684516);
			NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684517);
			NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684518);
			NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684519);
			NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684520);
			NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684521);
			NPCBehaviour.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684522);
			NPCBehaviour.NativeMethodInfoPtr_OnUncappedMinutePass_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684523);
			NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684524);
			NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684525);
			NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684526);
			NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684527);
			NPCBehaviour.NativeMethodInfoPtr_EnableBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684528);
			NPCBehaviour.NativeMethodInfoPtr_EnableBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684529);
			NPCBehaviour.NativeMethodInfoPtr_DisableBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684530);
			NPCBehaviour.NativeMethodInfoPtr_DisableBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684531);
			NPCBehaviour.NativeMethodInfoPtr_ActivateBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684532);
			NPCBehaviour.NativeMethodInfoPtr_ActivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684533);
			NPCBehaviour.NativeMethodInfoPtr_DeactivateBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684534);
			NPCBehaviour.NativeMethodInfoPtr_DeactivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684535);
			NPCBehaviour.NativeMethodInfoPtr_PauseBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684536);
			NPCBehaviour.NativeMethodInfoPtr_PauseBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684537);
			NPCBehaviour.NativeMethodInfoPtr_ResumeBehaviour_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684538);
			NPCBehaviour.NativeMethodInfoPtr_ResumeBehaviour_Client_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684539);
			NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684540);
			NPCBehaviour.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684541);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684542);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684543);
			NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684544);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684545);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684546);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684547);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_3964170259_Private_Void_ProductItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684548);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_3964170259_Public_Void_ProductItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684549);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_3964170259_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684550);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_EnableBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684551);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684552);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_EnableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684553);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684554);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684555);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684556);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684557);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684558);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_DisableBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684559);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684560);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_DisableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684561);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684562);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684563);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684564);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684565);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684566);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ActivateBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684567);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684568);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ActivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684569);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684570);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684571);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684572);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684573);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684574);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_DeactivateBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684575);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684576);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_DeactivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684577);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684578);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684579);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684580);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684581);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684582);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_PauseBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684583);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684584);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_PauseBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684585);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684586);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684587);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684588);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684589);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684590);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ResumeBehaviour_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684591);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684592);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ResumeBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684593);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684594);
			NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684595);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684596);
			NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684597);
			NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684598);
			NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, 100684599);
		}

		// Token: 0x1700309D RID: 12445
		// (get) Token: 0x0600A09D RID: 41117 RVA: 0x002AD6BC File Offset: 0x002AB8BC
		// (set) Token: 0x0600A09E RID: 41118 RVA: 0x002AD6FC File Offset: 0x002AB8FC
		public unsafe Behaviour activeBehaviour
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700309E RID: 12446
		// (get) Token: 0x0600A09F RID: 41119 RVA: 0x002AD740 File Offset: 0x002AB940
		// (set) Token: 0x0600A0A0 RID: 41120 RVA: 0x002AD780 File Offset: 0x002AB980
		public unsafe NPC Npc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_get_Npc_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A0A1 RID: 41121 RVA: 0x002AD7C4 File Offset: 0x002AB9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283531, XrefRangeEnd = 283541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A2 RID: 41122 RVA: 0x002AD800 File Offset: 0x002ABA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283541, XrefRangeEnd = 283624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A3 RID: 41123 RVA: 0x002AD83C File Offset: 0x002ABA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283624, XrefRangeEnd = 283645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x002AD870 File Offset: 0x002ABA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283645, XrefRangeEnd = 283680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x002AD8AC File Offset: 0x002ABAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283680, XrefRangeEnd = 283690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x002AD8FC File Offset: 0x002ABAFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283691, RefRangeEnd = 283692, XrefRangeStart = 283690, XrefRangeEnd = 283691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Summon(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x002AD95C File Offset: 0x002ABB5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283703, RefRangeEnd = 283705, XrefRangeStart = 283692, XrefRangeEnd = 283703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConsumeProduct(ProductItemInstance product, bool removeFromInventory = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeFromInventory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x002AD9AC File Offset: 0x002ABBAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283728, RefRangeEnd = 283729, XrefRangeStart = 283705, XrefRangeEnd = 283728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnKnockOut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnKnockOut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x002AD9E0 File Offset: 0x002ABBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283729, XrefRangeEnd = 283745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRevive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_OnRevive_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x002ADA14 File Offset: 0x002ABC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283745, XrefRangeEnd = 283748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x002ADA50 File Offset: 0x002ABC50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 283775, RefRangeEnd = 283779, XrefRangeStart = 283748, XrefRangeEnd = 283775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetBehaviour(string BehaviourName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(BehaviourName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x002ADAA0 File Offset: 0x002ABCA0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 283799, RefRangeEnd = 283816, XrefRangeStart = 283779, XrefRangeEnd = 283799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetBehaviour<T>() where T : Behaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.MethodInfoStoreGeneric_GetBehaviour_Public_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x002ADADC File Offset: 0x002ABCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283816, XrefRangeEnd = 283877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x002ADB18 File Offset: 0x002ABD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283877, XrefRangeEnd = 283881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x002ADB54 File Offset: 0x002ABD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283881, XrefRangeEnd = 283885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x002ADB90 File Offset: 0x002ABD90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283885, XrefRangeEnd = 283889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnUncappedMinutePass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_OnUncappedMinutePass_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x002ADBCC File Offset: 0x002ABDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283889, XrefRangeEnd = 283916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortBehaviourStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x002ADC00 File Offset: 0x002ABE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283916, XrefRangeEnd = 283919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Behaviour GetEnabledBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr3) : null;
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x002ADC40 File Offset: 0x002ABE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283947, RefRangeEnd = 283948, XrefRangeStart = 283919, XrefRangeEnd = 283947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x002ADC84 File Offset: 0x002ABE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 283976, RefRangeEnd = 283977, XrefRangeStart = 283948, XrefRangeEnd = 283976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEnabledBehaviour(Behaviour b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x002ADCC8 File Offset: 0x002ABEC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 284000, RefRangeEnd = 284005, XrefRangeStart = 283977, XrefRangeEnd = 284000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_EnableBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x002ADD08 File Offset: 0x002ABF08
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284016, RefRangeEnd = 284020, XrefRangeStart = 284005, XrefRangeEnd = 284016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_EnableBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x002ADD58 File Offset: 0x002ABF58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284043, RefRangeEnd = 284046, XrefRangeStart = 284020, XrefRangeEnd = 284043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_DisableBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x002ADD98 File Offset: 0x002ABF98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284057, RefRangeEnd = 284060, XrefRangeStart = 284046, XrefRangeEnd = 284057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_DisableBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x002ADDE8 File Offset: 0x002ABFE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284083, RefRangeEnd = 284084, XrefRangeStart = 284060, XrefRangeEnd = 284083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ActivateBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x002ADE28 File Offset: 0x002AC028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284095, RefRangeEnd = 284098, XrefRangeStart = 284084, XrefRangeEnd = 284095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ActivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x002ADE78 File Offset: 0x002AC078
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284121, RefRangeEnd = 284124, XrefRangeStart = 284098, XrefRangeEnd = 284121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_DeactivateBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x002ADEB8 File Offset: 0x002AC0B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284135, RefRangeEnd = 284138, XrefRangeStart = 284124, XrefRangeEnd = 284135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_DeactivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x002ADF08 File Offset: 0x002AC108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284161, RefRangeEnd = 284162, XrefRangeStart = 284138, XrefRangeEnd = 284161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_PauseBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x002ADF48 File Offset: 0x002AC148
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284173, RefRangeEnd = 284176, XrefRangeStart = 284162, XrefRangeEnd = 284173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PauseBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_PauseBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x002ADF98 File Offset: 0x002AC198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284199, RefRangeEnd = 284200, XrefRangeStart = 284176, XrefRangeEnd = 284199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeBehaviour_Server(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ResumeBehaviour_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x002ADFD8 File Offset: 0x002AC1D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284211, RefRangeEnd = 284214, XrefRangeStart = 284200, XrefRangeEnd = 284211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResumeBehaviour_Client(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_ResumeBehaviour_Client_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x002AE028 File Offset: 0x002AC228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284214, XrefRangeEnd = 284227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x002AE064 File Offset: 0x002AC264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284227, XrefRangeEnd = 284238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NetworkConnection_PDM_0(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x002AE0A8 File Offset: 0x002AC2A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284238, XrefRangeEnd = 284360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x002AE0E4 File Offset: 0x002AC2E4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x002AE120 File Offset: 0x002AC320
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x002AE15C File Offset: 0x002AC35C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284383, RefRangeEnd = 284384, XrefRangeStart = 284360, XrefRangeEnd = 284383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x002AE1BC File Offset: 0x002AC3BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284415, RefRangeEnd = 284416, XrefRangeStart = 284384, XrefRangeEnd = 284415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Summon_900355577(string buildingGUID, int doorIndex, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(buildingGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x002AE21C File Offset: 0x002AC41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284416, XrefRangeEnd = 284422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Summon_900355577(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x002AE280 File Offset: 0x002AC480
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 283703, RefRangeEnd = 283705, XrefRangeStart = 283703, XrefRangeEnd = 283705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ConsumeProduct_3964170259(ProductItemInstance product, bool removeFromInventory = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeFromInventory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_3964170259_Private_Void_ProductItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x002AE2D0 File Offset: 0x002AC4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284422, XrefRangeEnd = 284431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConsumeProduct_3964170259(ProductItemInstance product, bool removeFromInventory = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeFromInventory;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ConsumeProduct_3964170259_Public_Void_ProductItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x002AE320 File Offset: 0x002AC520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284431, XrefRangeEnd = 284437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ConsumeProduct_3964170259(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_3964170259_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x002AE384 File Offset: 0x002AC584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284437, XrefRangeEnd = 284448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_EnableBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x002AE3C4 File Offset: 0x002AC5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284448, XrefRangeEnd = 284449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x002AE404 File Offset: 0x002AC604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284449, XrefRangeEnd = 284454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_EnableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_EnableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x002AE468 File Offset: 0x002AC668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284454, XrefRangeEnd = 284465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x002AE4B8 File Offset: 0x002AC6B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284469, RefRangeEnd = 284470, XrefRangeStart = 284465, XrefRangeEnd = 284469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x002AE508 File Offset: 0x002AC708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284470, XrefRangeEnd = 284475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x002AE558 File Offset: 0x002AC758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284475, XrefRangeEnd = 284486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_EnableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x002AE5A8 File Offset: 0x002AC7A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284486, XrefRangeEnd = 284493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_EnableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x002AE5F8 File Offset: 0x002AC7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284493, XrefRangeEnd = 284504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_DisableBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x002AE638 File Offset: 0x002AC838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284504, XrefRangeEnd = 284505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DisableBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x002AE678 File Offset: 0x002AC878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284505, XrefRangeEnd = 284510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DisableBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_DisableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x002AE6DC File Offset: 0x002AC8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284510, XrefRangeEnd = 284521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x002AE72C File Offset: 0x002AC92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284525, RefRangeEnd = 284526, XrefRangeStart = 284521, XrefRangeEnd = 284525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x002AE77C File Offset: 0x002AC97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284526, XrefRangeEnd = 284531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x002AE7CC File Offset: 0x002AC9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284531, XrefRangeEnd = 284542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_DisableBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x002AE81C File Offset: 0x002ACA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284542, XrefRangeEnd = 284549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_DisableBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x002AE86C File Offset: 0x002ACA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284549, XrefRangeEnd = 284560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ActivateBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x002AE8AC File Offset: 0x002ACAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284560, XrefRangeEnd = 284561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x002AE8EC File Offset: 0x002ACAEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284561, XrefRangeEnd = 284566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ActivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ActivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x002AE950 File Offset: 0x002ACB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284566, XrefRangeEnd = 284577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x002AE9A0 File Offset: 0x002ACBA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284581, RefRangeEnd = 284582, XrefRangeStart = 284577, XrefRangeEnd = 284581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x002AE9F0 File Offset: 0x002ACBF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284582, XrefRangeEnd = 284587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x002AEA40 File Offset: 0x002ACC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284587, XrefRangeEnd = 284598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ActivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x002AEA90 File Offset: 0x002ACC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284598, XrefRangeEnd = 284605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ActivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x002AEAE0 File Offset: 0x002ACCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284605, XrefRangeEnd = 284616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_DeactivateBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x002AEB20 File Offset: 0x002ACD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284616, XrefRangeEnd = 284617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x002AEB60 File Offset: 0x002ACD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284617, XrefRangeEnd = 284622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_DeactivateBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_DeactivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x002AEBC4 File Offset: 0x002ACDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284622, XrefRangeEnd = 284633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x002AEC14 File Offset: 0x002ACE14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284637, RefRangeEnd = 284638, XrefRangeStart = 284633, XrefRangeEnd = 284637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x002AEC64 File Offset: 0x002ACE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284638, XrefRangeEnd = 284643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x002AECB4 File Offset: 0x002ACEB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284643, XrefRangeEnd = 284654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_DeactivateBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x002AED04 File Offset: 0x002ACF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284654, XrefRangeEnd = 284661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_DeactivateBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x002AED54 File Offset: 0x002ACF54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284661, XrefRangeEnd = 284672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_PauseBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x002AED94 File Offset: 0x002ACF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284672, XrefRangeEnd = 284673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PauseBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x002AEDD4 File Offset: 0x002ACFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284673, XrefRangeEnd = 284678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_PauseBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_PauseBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x002AEE38 File Offset: 0x002AD038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284678, XrefRangeEnd = 284689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x002AEE88 File Offset: 0x002AD088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284693, RefRangeEnd = 284694, XrefRangeStart = 284689, XrefRangeEnd = 284693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x002AEED8 File Offset: 0x002AD0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284694, XrefRangeEnd = 284699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x002AEF28 File Offset: 0x002AD128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284699, XrefRangeEnd = 284710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PauseBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x002AEF78 File Offset: 0x002AD178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284710, XrefRangeEnd = 284717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PauseBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x002AEFC8 File Offset: 0x002AD1C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284717, XrefRangeEnd = 284728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Server_ResumeBehaviour_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x002AF008 File Offset: 0x002AD208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284728, XrefRangeEnd = 284729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResumeBehaviour_Server_3316948804(int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x002AF048 File Offset: 0x002AD248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284729, XrefRangeEnd = 284734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ResumeBehaviour_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Server_ResumeBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x002AF0AC File Offset: 0x002AD2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284734, XrefRangeEnd = 284745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F8 RID: 41208 RVA: 0x002AF0FC File Offset: 0x002AD2FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284749, RefRangeEnd = 284750, XrefRangeStart = 284745, XrefRangeEnd = 284749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0F9 RID: 41209 RVA: 0x002AF14C File Offset: 0x002AD34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284750, XrefRangeEnd = 284755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FA RID: 41210 RVA: 0x002AF19C File Offset: 0x002AD39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284755, XrefRangeEnd = 284766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ResumeBehaviour_Client_2681120339(NetworkConnection conn, int behaviourIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref behaviourIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcWriter___Target_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FB RID: 41211 RVA: 0x002AF1EC File Offset: 0x002AD3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284766, XrefRangeEnd = 284773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ResumeBehaviour_Client_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.NativeMethodInfoPtr_RpcReader___Target_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FC RID: 41212 RVA: 0x002AF23C File Offset: 0x002AD43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284773, XrefRangeEnd = 284782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x00049D56 File Offset: 0x00047F56
		public NPCBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003086 RID: 12422
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x002AF278 File Offset: 0x002AD478
		// (set) Token: 0x0600A0FF RID: 41215 RVA: 0x00049D5F File Offset: 0x00047F5F
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17003087 RID: 12423
		// (get) Token: 0x0600A100 RID: 41216 RVA: 0x002AF2A0 File Offset: 0x002AD4A0
		// (set) Token: 0x0600A101 RID: 41217 RVA: 0x00049D7A File Offset: 0x00047F7A
		public unsafe NPCScheduleManager ScheduleManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCScheduleManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ScheduleManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003088 RID: 12424
		// (get) Token: 0x0600A102 RID: 41218 RVA: 0x002AF2D0 File Offset: 0x002AD4D0
		// (set) Token: 0x0600A103 RID: 41219 RVA: 0x00049D99 File Offset: 0x00047F99
		public unsafe CoweringBehaviour CoweringBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CoweringBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CoweringBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003089 RID: 12425
		// (get) Token: 0x0600A104 RID: 41220 RVA: 0x002AF300 File Offset: 0x002AD500
		// (set) Token: 0x0600A105 RID: 41221 RVA: 0x00049DB8 File Offset: 0x00047FB8
		public unsafe RagdollBehaviour RagdollBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RagdollBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RagdollBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308A RID: 12426
		// (get) Token: 0x0600A106 RID: 41222 RVA: 0x002AF330 File Offset: 0x002AD530
		// (set) Token: 0x0600A107 RID: 41223 RVA: 0x00049DD7 File Offset: 0x00047FD7
		public unsafe CallPoliceBehaviour CallPoliceBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallPoliceBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CallPoliceBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308B RID: 12427
		// (get) Token: 0x0600A108 RID: 41224 RVA: 0x002AF360 File Offset: 0x002AD560
		// (set) Token: 0x0600A109 RID: 41225 RVA: 0x00049DF6 File Offset: 0x00047FF6
		public unsafe GenericDialogueBehaviour GenericDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericDialogueBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_GenericDialogueBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308C RID: 12428
		// (get) Token: 0x0600A10A RID: 41226 RVA: 0x002AF390 File Offset: 0x002AD590
		// (set) Token: 0x0600A10B RID: 41227 RVA: 0x00049E15 File Offset: 0x00048015
		public unsafe HeavyFlinchBehaviour HeavyFlinchBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeavyFlinchBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_HeavyFlinchBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308D RID: 12429
		// (get) Token: 0x0600A10C RID: 41228 RVA: 0x002AF3C0 File Offset: 0x002AD5C0
		// (set) Token: 0x0600A10D RID: 41229 RVA: 0x00049E34 File Offset: 0x00048034
		public unsafe FaceTargetBehaviour FaceTargetBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FaceTargetBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FaceTargetBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FaceTargetBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x0600A10E RID: 41230 RVA: 0x002AF3F0 File Offset: 0x002AD5F0
		// (set) Token: 0x0600A10F RID: 41231 RVA: 0x00049E53 File Offset: 0x00048053
		public unsafe DeadBehaviour DeadBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_DeadBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x0600A110 RID: 41232 RVA: 0x002AF420 File Offset: 0x002AD620
		// (set) Token: 0x0600A111 RID: 41233 RVA: 0x00049E72 File Offset: 0x00048072
		public unsafe UnconsciousBehaviour UnconsciousBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnconsciousBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_UnconsciousBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x0600A112 RID: 41234 RVA: 0x002AF450 File Offset: 0x002AD650
		// (set) Token: 0x0600A113 RID: 41235 RVA: 0x00049E91 File Offset: 0x00048091
		public unsafe Behaviour SummonBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_SummonBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003091 RID: 12433
		// (get) Token: 0x0600A114 RID: 41236 RVA: 0x002AF480 File Offset: 0x002AD680
		// (set) Token: 0x0600A115 RID: 41237 RVA: 0x00049EB0 File Offset: 0x000480B0
		public unsafe ConsumeProductBehaviour ConsumeProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsumeProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_ConsumeProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003092 RID: 12434
		// (get) Token: 0x0600A116 RID: 41238 RVA: 0x002AF4B0 File Offset: 0x002AD6B0
		// (set) Token: 0x0600A117 RID: 41239 RVA: 0x00049ECF File Offset: 0x000480CF
		public unsafe CombatBehaviour CombatBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_CombatBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003093 RID: 12435
		// (get) Token: 0x0600A118 RID: 41240 RVA: 0x002AF4E0 File Offset: 0x002AD6E0
		// (set) Token: 0x0600A119 RID: 41241 RVA: 0x00049EEE File Offset: 0x000480EE
		public unsafe FleeBehaviour FleeBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FleeBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_FleeBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003094 RID: 12436
		// (get) Token: 0x0600A11A RID: 41242 RVA: 0x002AF510 File Offset: 0x002AD710
		// (set) Token: 0x0600A11B RID: 41243 RVA: 0x00049F0D File Offset: 0x0004810D
		public unsafe StationaryBehaviour StationaryBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationaryBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_StationaryBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003095 RID: 12437
		// (get) Token: 0x0600A11C RID: 41244 RVA: 0x002AF540 File Offset: 0x002AD740
		// (set) Token: 0x0600A11D RID: 41245 RVA: 0x00049F2C File Offset: 0x0004812C
		public unsafe RequestProductBehaviour RequestProductBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestProductBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_RequestProductBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003096 RID: 12438
		// (get) Token: 0x0600A11E RID: 41246 RVA: 0x002AF570 File Offset: 0x002AD770
		// (set) Token: 0x0600A11F RID: 41247 RVA: 0x00049F4B File Offset: 0x0004814B
		public unsafe List<Behaviour> behaviourStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_behaviourStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003097 RID: 12439
		// (get) Token: 0x0600A120 RID: 41248 RVA: 0x002AF5A0 File Offset: 0x002AD7A0
		// (set) Token: 0x0600A121 RID: 41249 RVA: 0x00049F6A File Offset: 0x0004816A
		public unsafe Behaviour _activeBehaviour_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__activeBehaviour_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003098 RID: 12440
		// (get) Token: 0x0600A122 RID: 41250 RVA: 0x002AF5D0 File Offset: 0x002AD7D0
		// (set) Token: 0x0600A123 RID: 41251 RVA: 0x00049F89 File Offset: 0x00048189
		public unsafe NPC _Npc_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr__Npc_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x0600A124 RID: 41252 RVA: 0x002AF600 File Offset: 0x002AD800
		// (set) Token: 0x0600A125 RID: 41253 RVA: 0x00049FA8 File Offset: 0x000481A8
		public unsafe Coroutine summonRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_summonRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x0600A126 RID: 41254 RVA: 0x002AF630 File Offset: 0x002AD830
		// (set) Token: 0x0600A127 RID: 41255 RVA: 0x00049FC7 File Offset: 0x000481C7
		public unsafe List<Behaviour> enabledBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_enabledBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0600A128 RID: 41256 RVA: 0x002AF660 File Offset: 0x002AD860
		// (set) Token: 0x0600A129 RID: 41257 RVA: 0x00049FE6 File Offset: 0x000481E6
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700309C RID: 12444
		// (get) Token: 0x0600A12A RID: 41258 RVA: 0x002AF688 File Offset: 0x002AD888
		// (set) Token: 0x0600A12B RID: 41259 RVA: 0x0004A001 File Offset: 0x00048201
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006ED8 RID: 28376
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04006ED9 RID: 28377
		private static readonly IntPtr NativeFieldInfoPtr_ScheduleManager;

		// Token: 0x04006EDA RID: 28378
		private static readonly IntPtr NativeFieldInfoPtr_CoweringBehaviour;

		// Token: 0x04006EDB RID: 28379
		private static readonly IntPtr NativeFieldInfoPtr_RagdollBehaviour;

		// Token: 0x04006EDC RID: 28380
		private static readonly IntPtr NativeFieldInfoPtr_CallPoliceBehaviour;

		// Token: 0x04006EDD RID: 28381
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogueBehaviour;

		// Token: 0x04006EDE RID: 28382
		private static readonly IntPtr NativeFieldInfoPtr_HeavyFlinchBehaviour;

		// Token: 0x04006EDF RID: 28383
		private static readonly IntPtr NativeFieldInfoPtr_FaceTargetBehaviour;

		// Token: 0x04006EE0 RID: 28384
		private static readonly IntPtr NativeFieldInfoPtr_DeadBehaviour;

		// Token: 0x04006EE1 RID: 28385
		private static readonly IntPtr NativeFieldInfoPtr_UnconsciousBehaviour;

		// Token: 0x04006EE2 RID: 28386
		private static readonly IntPtr NativeFieldInfoPtr_SummonBehaviour;

		// Token: 0x04006EE3 RID: 28387
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeProductBehaviour;

		// Token: 0x04006EE4 RID: 28388
		private static readonly IntPtr NativeFieldInfoPtr_CombatBehaviour;

		// Token: 0x04006EE5 RID: 28389
		private static readonly IntPtr NativeFieldInfoPtr_FleeBehaviour;

		// Token: 0x04006EE6 RID: 28390
		private static readonly IntPtr NativeFieldInfoPtr_StationaryBehaviour;

		// Token: 0x04006EE7 RID: 28391
		private static readonly IntPtr NativeFieldInfoPtr_RequestProductBehaviour;

		// Token: 0x04006EE8 RID: 28392
		private static readonly IntPtr NativeFieldInfoPtr_behaviourStack;

		// Token: 0x04006EE9 RID: 28393
		private static readonly IntPtr NativeFieldInfoPtr__activeBehaviour_k__BackingField;

		// Token: 0x04006EEA RID: 28394
		private static readonly IntPtr NativeFieldInfoPtr__Npc_k__BackingField;

		// Token: 0x04006EEB RID: 28395
		private static readonly IntPtr NativeFieldInfoPtr_summonRoutine;

		// Token: 0x04006EEC RID: 28396
		private static readonly IntPtr NativeFieldInfoPtr_enabledBehaviours;

		// Token: 0x04006EED RID: 28397
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006EEE RID: 28398
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006EEF RID: 28399
		private static readonly IntPtr NativeMethodInfoPtr_get_activeBehaviour_Public_get_Behaviour_0;

		// Token: 0x04006EF0 RID: 28400
		private static readonly IntPtr NativeMethodInfoPtr_set_activeBehaviour_Public_set_Void_Behaviour_0;

		// Token: 0x04006EF1 RID: 28401
		private static readonly IntPtr NativeMethodInfoPtr_get_Npc_Public_get_NPC_0;

		// Token: 0x04006EF2 RID: 28402
		private static readonly IntPtr NativeMethodInfoPtr_set_Npc_Private_set_Void_NPC_0;

		// Token: 0x04006EF3 RID: 28403
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006EF4 RID: 28404
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_1;

		// Token: 0x04006EF5 RID: 28405
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006EF6 RID: 28406
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04006EF7 RID: 28407
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006EF8 RID: 28408
		private static readonly IntPtr NativeMethodInfoPtr_Summon_Public_Void_String_Int32_Single_0;

		// Token: 0x04006EF9 RID: 28409
		private static readonly IntPtr NativeMethodInfoPtr_ConsumeProduct_Public_Void_ProductItemInstance_Boolean_0;

		// Token: 0x04006EFA RID: 28410
		private static readonly IntPtr NativeMethodInfoPtr_OnKnockOut_Private_Void_0;

		// Token: 0x04006EFB RID: 28411
		private static readonly IntPtr NativeMethodInfoPtr_OnRevive_Private_Void_0;

		// Token: 0x04006EFC RID: 28412
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Protected_Virtual_New_Void_1;

		// Token: 0x04006EFD RID: 28413
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_Behaviour_String_0;

		// Token: 0x04006EFE RID: 28414
		private static readonly IntPtr NativeMethodInfoPtr_GetBehaviour_Public_T_0;

		// Token: 0x04006EFF RID: 28415
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Void_0;

		// Token: 0x04006F00 RID: 28416
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Virtual_New_Void_0;

		// Token: 0x04006F01 RID: 28417
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_New_Void_1;

		// Token: 0x04006F02 RID: 28418
		private static readonly IntPtr NativeMethodInfoPtr_OnUncappedMinutePass_Protected_Virtual_New_Void_1;

		// Token: 0x04006F03 RID: 28419
		private static readonly IntPtr NativeMethodInfoPtr_SortBehaviourStack_Public_Void_0;

		// Token: 0x04006F04 RID: 28420
		private static readonly IntPtr NativeMethodInfoPtr_GetEnabledBehaviour_Private_Behaviour_0;

		// Token: 0x04006F05 RID: 28421
		private static readonly IntPtr NativeMethodInfoPtr_AddEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04006F06 RID: 28422
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEnabledBehaviour_Private_Void_Behaviour_0;

		// Token: 0x04006F07 RID: 28423
		private static readonly IntPtr NativeMethodInfoPtr_EnableBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F08 RID: 28424
		private static readonly IntPtr NativeMethodInfoPtr_EnableBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F09 RID: 28425
		private static readonly IntPtr NativeMethodInfoPtr_DisableBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F0A RID: 28426
		private static readonly IntPtr NativeMethodInfoPtr_DisableBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F0B RID: 28427
		private static readonly IntPtr NativeMethodInfoPtr_ActivateBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F0C RID: 28428
		private static readonly IntPtr NativeMethodInfoPtr_ActivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F0D RID: 28429
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F0E RID: 28430
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F0F RID: 28431
		private static readonly IntPtr NativeMethodInfoPtr_PauseBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F10 RID: 28432
		private static readonly IntPtr NativeMethodInfoPtr_PauseBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F11 RID: 28433
		private static readonly IntPtr NativeMethodInfoPtr_ResumeBehaviour_Server_Public_Void_Int32_0;

		// Token: 0x04006F12 RID: 28434
		private static readonly IntPtr NativeMethodInfoPtr_ResumeBehaviour_Client_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F13 RID: 28435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F14 RID: 28436
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_PDM_0;

		// Token: 0x04006F15 RID: 28437
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006F16 RID: 28438
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006F17 RID: 28439
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006F18 RID: 28440
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Summon_900355577_Private_Void_String_Int32_Single_0;

		// Token: 0x04006F19 RID: 28441
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Summon_900355577_Public_Void_String_Int32_Single_0;

		// Token: 0x04006F1A RID: 28442
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Summon_900355577_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F1B RID: 28443
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ConsumeProduct_3964170259_Private_Void_ProductItemInstance_Boolean_0;

		// Token: 0x04006F1C RID: 28444
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConsumeProduct_3964170259_Public_Void_ProductItemInstance_Boolean_0;

		// Token: 0x04006F1D RID: 28445
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ConsumeProduct_3964170259_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F1E RID: 28446
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_EnableBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F1F RID: 28447
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F20 RID: 28448
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_EnableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F21 RID: 28449
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F22 RID: 28450
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F23 RID: 28451
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F24 RID: 28452
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_EnableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F25 RID: 28453
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_EnableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F26 RID: 28454
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DisableBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F27 RID: 28455
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F28 RID: 28456
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DisableBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F29 RID: 28457
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F2A RID: 28458
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DisableBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F2B RID: 28459
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F2C RID: 28460
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_DisableBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F2D RID: 28461
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_DisableBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F2E RID: 28462
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ActivateBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F2F RID: 28463
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F30 RID: 28464
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ActivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F31 RID: 28465
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F32 RID: 28466
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ActivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F33 RID: 28467
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F34 RID: 28468
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ActivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F35 RID: 28469
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ActivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F36 RID: 28470
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_DeactivateBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F37 RID: 28471
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F38 RID: 28472
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_DeactivateBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F39 RID: 28473
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F3A RID: 28474
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DeactivateBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F3B RID: 28475
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F3C RID: 28476
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_DeactivateBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F3D RID: 28477
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_DeactivateBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F3E RID: 28478
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_PauseBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F3F RID: 28479
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F40 RID: 28480
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_PauseBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F41 RID: 28481
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F42 RID: 28482
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PauseBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F43 RID: 28483
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F44 RID: 28484
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_PauseBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F45 RID: 28485
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_PauseBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F46 RID: 28486
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ResumeBehaviour_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04006F47 RID: 28487
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04006F48 RID: 28488
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ResumeBehaviour_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F49 RID: 28489
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F4A RID: 28490
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResumeBehaviour_Client_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F4B RID: 28491
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F4C RID: 28492
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ResumeBehaviour_Client_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04006F4D RID: 28493
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ResumeBehaviour_Client_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F4E RID: 28494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000C64 RID: 3172
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F139 RID: 61753 RVA: 0x003A3280 File Offset: 0x003A1480
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr);
				NPCBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__39_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__43_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__45_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__45_0");
				NPCBehaviour.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, "<>9__46_0");
				NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100684601);
				NPCBehaviour.__c.NativeMethodInfoPtr__Update_b__39_0_Internal_String_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100684602);
				NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__43_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100684603);
				NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__45_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100684604);
				NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__46_0_Internal_Int32_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr, 100684605);
			}

			// Token: 0x0600F13A RID: 61754 RVA: 0x003A3374 File Offset: 0x003A1574
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F13B RID: 61755 RVA: 0x003A33B0 File Offset: 0x003A15B0
			[CallerCount(0)]
			public unsafe string _Update_b__39_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__Update_b__39_0_Internal_String_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F13C RID: 61756 RVA: 0x003A33F8 File Offset: 0x003A15F8
			[CallerCount(0)]
			public unsafe int _SortBehaviourStack_b__43_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__SortBehaviourStack_b__43_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F13D RID: 61757 RVA: 0x003A3448 File Offset: 0x003A1648
			[CallerCount(0)]
			public unsafe int _AddEnabledBehaviour_b__45_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__AddEnabledBehaviour_b__45_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F13E RID: 61758 RVA: 0x003A3498 File Offset: 0x003A1698
			[CallerCount(0)]
			public unsafe int _RemoveEnabledBehaviour_b__46_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c.NativeMethodInfoPtr__RemoveEnabledBehaviour_b__46_0_Internal_Int32_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F13F RID: 61759 RVA: 0x00071DBD File Offset: 0x0006FFBD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700493A RID: 18746
			// (get) Token: 0x0600F140 RID: 61760 RVA: 0x003A34E8 File Offset: 0x003A16E8
			// (set) Token: 0x0600F141 RID: 61761 RVA: 0x00071DC6 File Offset: 0x0006FFC6
			public unsafe static NPCBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493B RID: 18747
			// (get) Token: 0x0600F142 RID: 61762 RVA: 0x003A3510 File Offset: 0x003A1710
			// (set) Token: 0x0600F143 RID: 61763 RVA: 0x00071DD8 File Offset: 0x0006FFD8
			public unsafe static Func<Behaviour, string> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493C RID: 18748
			// (get) Token: 0x0600F144 RID: 61764 RVA: 0x003A3538 File Offset: 0x003A1738
			// (set) Token: 0x0600F145 RID: 61765 RVA: 0x00071DEA File Offset: 0x0006FFEA
			public unsafe static Func<Behaviour, int> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493D RID: 18749
			// (get) Token: 0x0600F146 RID: 61766 RVA: 0x003A3560 File Offset: 0x003A1760
			// (set) Token: 0x0600F147 RID: 61767 RVA: 0x00071DFC File Offset: 0x0006FFFC
			public unsafe static Func<Behaviour, int> __9__45_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__45_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__45_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700493E RID: 18750
			// (get) Token: 0x0600F148 RID: 61768 RVA: 0x003A3588 File Offset: 0x003A1788
			// (set) Token: 0x0600F149 RID: 61769 RVA: 0x00071E0E File Offset: 0x0007000E
			public unsafe static Func<Behaviour, int> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A34B RID: 41803
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A34C RID: 41804
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x0400A34D RID: 41805
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x0400A34E RID: 41806
			private static readonly IntPtr NativeFieldInfoPtr___9__45_0;

			// Token: 0x0400A34F RID: 41807
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x0400A350 RID: 41808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A351 RID: 41809
			private static readonly IntPtr NativeMethodInfoPtr__Update_b__39_0_Internal_String_Behaviour_0;

			// Token: 0x0400A352 RID: 41810
			private static readonly IntPtr NativeMethodInfoPtr__SortBehaviourStack_b__43_0_Internal_Int32_Behaviour_0;

			// Token: 0x0400A353 RID: 41811
			private static readonly IntPtr NativeMethodInfoPtr__AddEnabledBehaviour_b__45_0_Internal_Int32_Behaviour_0;

			// Token: 0x0400A354 RID: 41812
			private static readonly IntPtr NativeMethodInfoPtr__RemoveEnabledBehaviour_b__46_0_Internal_Int32_Behaviour_0;
		}

		// Token: 0x02000C65 RID: 3173
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__38`1")]
		[Serializable]
		public sealed class __c__38<T> : Il2CppSystem.Object where T : Behaviour
		{
			// Token: 0x0600F14A RID: 61770 RVA: 0x003A35B0 File Offset: 0x003A17B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__38()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__38`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr);
				NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr, "<>9");
				NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr, "<>9__38_0");
				NPCBehaviour.__c__38<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr, 100684607);
				NPCBehaviour.__c__38<T>.NativeMethodInfoPtr__GetBehaviour_b__38_0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr, 100684608);
			}

			// Token: 0x0600F14B RID: 61771 RVA: 0x003A3668 File Offset: 0x003A1868
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__38() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__38<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__38<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F14C RID: 61772 RVA: 0x003A36A4 File Offset: 0x003A18A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283502, XrefRangeEnd = 283504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBehaviour_b__38_0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__38<T>.NativeMethodInfoPtr__GetBehaviour_b__38_0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F14D RID: 61773 RVA: 0x00071E20 File Offset: 0x00070020
			public __c__38(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700493F RID: 18751
			// (get) Token: 0x0600F14E RID: 61774 RVA: 0x003A36F4 File Offset: 0x003A18F4
			// (set) Token: 0x0600F14F RID: 61775 RVA: 0x00071E29 File Offset: 0x00070029
			public unsafe static NPCBehaviour.__c__38<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c__38<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004940 RID: 18752
			// (get) Token: 0x0600F150 RID: 61776 RVA: 0x003A371C File Offset: 0x003A191C
			// (set) Token: 0x0600F151 RID: 61777 RVA: 0x00071E3B File Offset: 0x0007003B
			public unsafe static Func<Behaviour, bool> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Behaviour, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCBehaviour.__c__38<T>.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A355 RID: 41813
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A356 RID: 41814
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x0400A357 RID: 41815
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A358 RID: 41816
			private static readonly IntPtr NativeMethodInfoPtr__GetBehaviour_b__38_0_Internal_Boolean_Behaviour_0;
		}

		// Token: 0x02000C66 RID: 3174
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F152 RID: 61778 RVA: 0x003A3744 File Offset: 0x003A1944
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "b");
				NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100684609);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100684610);
				NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr, 100684611);
			}

			// Token: 0x0600F153 RID: 61779 RVA: 0x003A37D4 File Offset: 0x003A19D4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F154 RID: 61780 RVA: 0x003A3810 File Offset: 0x003A1A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283504, XrefRangeEnd = 283506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F155 RID: 61781 RVA: 0x003A3844 File Offset: 0x003A1A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283506, XrefRangeEnd = 283508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass28_0.NativeMethodInfoPtr__Start_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F156 RID: 61782 RVA: 0x00071E4D File Offset: 0x0007004D
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004941 RID: 18753
			// (get) Token: 0x0600F157 RID: 61783 RVA: 0x003A3878 File Offset: 0x003A1A78
			// (set) Token: 0x0600F158 RID: 61784 RVA: 0x00071E56 File Offset: 0x00070056
			public unsafe Behaviour b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004942 RID: 18754
			// (get) Token: 0x0600F159 RID: 61785 RVA: 0x003A38A8 File Offset: 0x003A1AA8
			// (set) Token: 0x0600F15A RID: 61786 RVA: 0x00071E75 File Offset: 0x00070075
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A359 RID: 41817
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x0400A35A RID: 41818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A35B RID: 41819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A35C RID: 41820
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;

			// Token: 0x0400A35D RID: 41821
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__1_Internal_Void_0;
		}

		// Token: 0x02000C67 RID: 3175
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F15B RID: 61787 RVA: 0x003A38D8 File Offset: 0x003A1AD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "duration");
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100684612);
				NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, 100684613);
			}

			// Token: 0x0600F15C RID: 61788 RVA: 0x003A3954 File Offset: 0x003A1B54
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F15D RID: 61789 RVA: 0x003A3990 File Offset: 0x003A1B90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 283526, RefRangeEnd = 283527, XrefRangeStart = 283521, XrefRangeEnd = 283526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F15E RID: 61790 RVA: 0x00071E94 File Offset: 0x00070094
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004943 RID: 18755
			// (get) Token: 0x0600F15F RID: 61791 RVA: 0x003A39D0 File Offset: 0x003A1BD0
			// (set) Token: 0x0600F160 RID: 61792 RVA: 0x00071E9D File Offset: 0x0007009D
			public unsafe NPCBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004944 RID: 18756
			// (get) Token: 0x0600F161 RID: 61793 RVA: 0x003A3A00 File Offset: 0x003A1C00
			// (set) Token: 0x0600F162 RID: 61794 RVA: 0x00071EBC File Offset: 0x000700BC
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x0400A35E RID: 41822
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A35F RID: 41823
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x0400A360 RID: 41824
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A361 RID: 41825
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x02000DFF RID: 3583
			[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass32_0+<<Summon>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06010238 RID: 66104 RVA: 0x003D4508 File Offset: 0x003D2708
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique()
				{
					Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0>.NativeClassPtr, "<<Summon>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>1__state");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>2__current");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<>4__this");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, "<t>5__2");
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684614);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684615);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684616);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684617);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684618);
					NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr, 100684619);
				}

				// Token: 0x06010239 RID: 66105 RVA: 0x003D45FC File Offset: 0x003D27FC
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601023A RID: 66106 RVA: 0x003D4644 File Offset: 0x003D2844
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601023B RID: 66107 RVA: 0x003D4678 File Offset: 0x003D2878
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283508, XrefRangeEnd = 283516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004ED1 RID: 20177
				// (get) Token: 0x0601023C RID: 66108 RVA: 0x003D46B4 File Offset: 0x003D28B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601023D RID: 66109 RVA: 0x003D46F4 File Offset: 0x003D28F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283516, XrefRangeEnd = 283521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004ED2 RID: 20178
				// (get) Token: 0x0601023E RID: 66110 RVA: 0x003D4728 File Offset: 0x003D2928
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601023F RID: 66111 RVA: 0x0007A678 File Offset: 0x00078878
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004ECD RID: 20173
				// (get) Token: 0x06010240 RID: 66112 RVA: 0x003D4768 File Offset: 0x003D2968
				// (set) Token: 0x06010241 RID: 66113 RVA: 0x0007A681 File Offset: 0x00078881
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004ECE RID: 20174
				// (get) Token: 0x06010242 RID: 66114 RVA: 0x003D4790 File Offset: 0x003D2990
				// (set) Token: 0x06010243 RID: 66115 RVA: 0x0007A69C File Offset: 0x0007889C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004ECF RID: 20175
				// (get) Token: 0x06010244 RID: 66116 RVA: 0x003D47C0 File Offset: 0x003D29C0
				// (set) Token: 0x06010245 RID: 66117 RVA: 0x0007A6BB File Offset: 0x000788BB
				public unsafe NPCBehaviour.__c__DisplayClass32_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCBehaviour.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004ED0 RID: 20176
				// (get) Token: 0x06010246 RID: 66118 RVA: 0x003D47F0 File Offset: 0x003D29F0
				// (set) Token: 0x06010247 RID: 66119 RVA: 0x0007A6DA File Offset: 0x000788DA
				public unsafe float _t_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiObObUnique.NativeFieldInfoPtr__t_5__2)) = value;
					}
				}

				// Token: 0x0400ADD7 RID: 44503
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ADD8 RID: 44504
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ADD9 RID: 44505
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ADDA RID: 44506
				private static readonly IntPtr NativeFieldInfoPtr__t_5__2;

				// Token: 0x0400ADDB RID: 44507
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ADDC RID: 44508
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADDD RID: 44509
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ADDE RID: 44510
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ADDF RID: 44511
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ADE0 RID: 44512
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C68 RID: 3176
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.NPCBehaviour+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F163 RID: 61795 RVA: 0x003A3A28 File Offset: 0x003A1C28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr);
				NPCBehaviour.__c__DisplayClass37_0.NativeFieldInfoPtr_BehaviourName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr, "BehaviourName");
				NPCBehaviour.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr, 100684620);
				NPCBehaviour.__c__DisplayClass37_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr, 100684621);
			}

			// Token: 0x0600F164 RID: 61796 RVA: 0x003A3A90 File Offset: 0x003A1C90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCBehaviour.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F165 RID: 61797 RVA: 0x003A3ACC File Offset: 0x003A1CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283527, XrefRangeEnd = 283531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBehaviour_b__0(Behaviour x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCBehaviour.__c__DisplayClass37_0.NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F166 RID: 61798 RVA: 0x00071ED7 File Offset: 0x000700D7
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004945 RID: 18757
			// (get) Token: 0x0600F167 RID: 61799 RVA: 0x003A3B1C File Offset: 0x003A1D1C
			// (set) Token: 0x0600F168 RID: 61800 RVA: 0x00071EE0 File Offset: 0x000700E0
			public unsafe string BehaviourName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass37_0.NativeFieldInfoPtr_BehaviourName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCBehaviour.__c__DisplayClass37_0.NativeFieldInfoPtr_BehaviourName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A362 RID: 41826
			private static readonly IntPtr NativeFieldInfoPtr_BehaviourName;

			// Token: 0x0400A363 RID: 41827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A364 RID: 41828
			private static readonly IntPtr NativeMethodInfoPtr__GetBehaviour_b__0_Internal_Boolean_Behaviour_0;
		}

		// Token: 0x02000C69 RID: 3177
		private sealed class MethodInfoStoreGeneric_GetBehaviour_Public_T_0<T>
		{
			// Token: 0x0400A365 RID: 41829
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NPCBehaviour.NativeMethodInfoPtr_GetBehaviour_Public_T_0, Il2CppClassPointerStore<NPCBehaviour>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
