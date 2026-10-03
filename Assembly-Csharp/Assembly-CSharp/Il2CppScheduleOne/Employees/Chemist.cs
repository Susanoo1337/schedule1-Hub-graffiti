using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200037C RID: 892
	public class Chemist : Employee
	{
		// Token: 0x06004D78 RID: 19832 RVA: 0x00184EB4 File Offset: 0x001830B4
		// Note: this type is marked as 'beforefieldinit'.
		static Chemist()
		{
			Il2CppClassPointerStore<Chemist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Chemist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist>.NativeClassPtr);
			Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "MAX_ASSIGNED_STATIONS");
			Chemist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "typeIcon");
			Chemist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "configReplicator");
			Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartChemistryStationBehaviour");
			Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "FinishLabOvenBehaviour");
			Chemist.NativeFieldInfoPtr_StartCauldronBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartCauldronBehaviour");
			Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "StartMixingStationBehaviour");
			Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "WorldspaceUIPrefab");
			Chemist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "uiPoint");
			Chemist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<configuration>k__BackingField");
			Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.ChemistAssembly-CSharp.dll_Excuted");
			Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673328);
			Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673329);
			Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673330);
			Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673331);
			Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673332);
			Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673333);
			Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673334);
			Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673335);
			Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673336);
			Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673337);
			Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673338);
			Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673339);
			Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673340);
			Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673341);
			Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673342);
			Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673343);
			Chemist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673344);
			Chemist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673345);
			Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673346);
			Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673347);
			Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673348);
			Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673349);
			Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673350);
			Chemist.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673351);
			Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673352);
			Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673353);
			Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673354);
			Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673355);
			Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673356);
			Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673357);
			Chemist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673358);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673359);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673360);
			Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673361);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673362);
			Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673363);
			Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673364);
			Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673365);
			Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673366);
			Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673367);
			Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673368);
			Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673369);
			Chemist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673370);
			Chemist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673371);
			Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673372);
			Chemist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673373);
			Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673374);
			Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673375);
			Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673376);
			Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673377);
			Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673378);
			Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673379);
			Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673380);
			Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673381);
			Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673382);
			Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist>.NativeClassPtr, 100673383);
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06004D79 RID: 19833 RVA: 0x00185484 File Offset: 0x00183684
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 175604, RefRangeEnd = 175609, XrefRangeStart = 175604, XrefRangeEnd = 175604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06004D7A RID: 19834 RVA: 0x001854C4 File Offset: 0x001836C4
		// (set) Token: 0x06004D7B RID: 19835 RVA: 0x00185504 File Offset: 0x00183704
		public unsafe ChemistConfiguration configuration
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 175604, RefRangeEnd = 175609, XrefRangeStart = 175604, XrefRangeEnd = 175609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175609, XrefRangeEnd = 175610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001836 RID: 6198
		// (get) Token: 0x06004D7C RID: 19836 RVA: 0x00185548 File Offset: 0x00183748
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 174469, RefRangeEnd = 174474, XrefRangeStart = 174469, XrefRangeEnd = 174474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17001837 RID: 6199
		// (get) Token: 0x06004D7D RID: 19837 RVA: 0x00185588 File Offset: 0x00183788
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 175610, RefRangeEnd = 175611, XrefRangeStart = 175610, XrefRangeEnd = 175610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001838 RID: 6200
		// (get) Token: 0x06004D7E RID: 19838 RVA: 0x001855C4 File Offset: 0x001837C4
		// (set) Token: 0x06004D7F RID: 19839 RVA: 0x00185604 File Offset: 0x00183804
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 174453, RefRangeEnd = 174468, XrefRangeStart = 174453, XrefRangeEnd = 174468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06004D80 RID: 19840 RVA: 0x00185648 File Offset: 0x00183848
		// (set) Token: 0x06004D81 RID: 19841 RVA: 0x00185688 File Offset: 0x00183888
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 174474, RefRangeEnd = 174482, XrefRangeStart = 174474, XrefRangeEnd = 174482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 175619, RefRangeEnd = 175621, XrefRangeStart = 175611, XrefRangeEnd = 175619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D82 RID: 19842 RVA: 0x001856CC File Offset: 0x001838CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175621, XrefRangeEnd = 175643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06004D83 RID: 19843 RVA: 0x00185710 File Offset: 0x00183910
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700183B RID: 6203
		// (get) Token: 0x06004D84 RID: 19844 RVA: 0x00185750 File Offset: 0x00183950
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44652, RefRangeEnd = 44654, XrefRangeStart = 44652, XrefRangeEnd = 44654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700183C RID: 6204
		// (get) Token: 0x06004D85 RID: 19845 RVA: 0x00185790 File Offset: 0x00183990
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700183D RID: 6205
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x001857D0 File Offset: 0x001839D0
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06004D87 RID: 19847 RVA: 0x0018580C File Offset: 0x00183A0C
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x0018584C File Offset: 0x00183A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175643, XrefRangeEnd = 175652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x001858A8 File Offset: 0x00183AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x001858E4 File Offset: 0x00183AE4
		[CallerCount(0)]
		public unsafe override void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00185920 File Offset: 0x00183B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175652, XrefRangeEnd = 175663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x0018595C File Offset: 0x00183B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175663, XrefRangeEnd = 175681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x001859AC File Offset: 0x00183BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175681, XrefRangeEnd = 175698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x001859F0 File Offset: 0x00183BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175698, XrefRangeEnd = 175710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00185A2C File Offset: 0x00183C2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175736, RefRangeEnd = 175737, XrefRangeStart = 175710, XrefRangeEnd = 175736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartNewTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_TryStartNewTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00185A60 File Offset: 0x00183C60
		[CallerCount(0)]
		public unsafe override bool IsAnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00185AA8 File Offset: 0x00183CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175737, XrefRangeEnd = 175738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00185AF0 File Offset: 0x00183CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175738, XrefRangeEnd = 175741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartChemistryStation(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D93 RID: 19859 RVA: 0x00185B34 File Offset: 0x00183D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175741, XrefRangeEnd = 175744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCauldron(Cauldron cauldron)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cauldron);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D94 RID: 19860 RVA: 0x00185B78 File Offset: 0x00183D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175744, XrefRangeEnd = 175747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D95 RID: 19861 RVA: 0x00185BBC File Offset: 0x00183DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175747, XrefRangeEnd = 175750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishLabOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x00185C00 File Offset: 0x00183E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175750, XrefRangeEnd = 175753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartMixingStation(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00185C44 File Offset: 0x00183E44
		[CallerCount(0)]
		public unsafe override EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr3) : null;
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00185C90 File Offset: 0x00183E90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175782, RefRangeEnd = 175783, XrefRangeStart = 175753, XrefRangeEnd = 175782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToFinish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00185CD0 File Offset: 0x00183ED0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175811, RefRangeEnd = 175812, XrefRangeStart = 175783, XrefRangeEnd = 175811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00185D10 File Offset: 0x00183F10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175847, RefRangeEnd = 175848, XrefRangeStart = 175812, XrefRangeEnd = 175847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemistryStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr3) : null;
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00185D50 File Offset: 0x00183F50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175876, RefRangeEnd = 175877, XrefRangeStart = 175848, XrefRangeEnd = 175876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr3) : null;
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00185D90 File Offset: 0x00183F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175909, RefRangeEnd = 175910, XrefRangeStart = 175877, XrefRangeEnd = 175909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixingStationsReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr3) : null;
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00185DD0 File Offset: 0x00183FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175939, RefRangeEnd = 175940, XrefRangeStart = 175910, XrefRangeEnd = 175939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<LabOven> GetLabOvensReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr3) : null;
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x00185E10 File Offset: 0x00184010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175969, RefRangeEnd = 175970, XrefRangeStart = 175940, XrefRangeEnd = 175969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ChemistryStation> GetChemStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr3) : null;
		}

		// Token: 0x06004D9F RID: 19871 RVA: 0x00185E50 File Offset: 0x00184050
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175999, RefRangeEnd = 176000, XrefRangeStart = 175970, XrefRangeEnd = 175999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Cauldron> GetCauldronsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr3) : null;
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00185E90 File Offset: 0x00184090
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176052, RefRangeEnd = 176053, XrefRangeStart = 176000, XrefRangeEnd = 176052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MixingStation> GetMixStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr3) : null;
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00185ED0 File Offset: 0x001840D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 176080, RefRangeEnd = 176081, XrefRangeStart = 176053, XrefRangeEnd = 176080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00185F10 File Offset: 0x00184110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176081, XrefRangeEnd = 176085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00185F44 File Offset: 0x00184144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176085, XrefRangeEnd = 176097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00185F90 File Offset: 0x00184190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176097, XrefRangeEnd = 176101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr3) : null;
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x00185FDC File Offset: 0x001841DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176101, XrefRangeEnd = 176107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x00186038 File Offset: 0x00184238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176107, XrefRangeEnd = 176108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Chemist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x00186074 File Offset: 0x00184274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176108, XrefRangeEnd = 176132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x001860B0 File Offset: 0x001842B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176132, XrefRangeEnd = 176133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x001860EC File Offset: 0x001842EC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00186128 File Offset: 0x00184328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176133, XrefRangeEnd = 176143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x0018616C File Offset: 0x0018436C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175619, RefRangeEnd = 175621, XrefRangeStart = 175619, XrefRangeEnd = 175621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x001861B0 File Offset: 0x001843B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176143, XrefRangeEnd = 176147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x00186214 File Offset: 0x00184414
		// (set) Token: 0x06004DAE RID: 19886 RVA: 0x00186254 File Offset: 0x00184454
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 174474, RefRangeEnd = 174482, XrefRangeStart = 174474, XrefRangeEnd = 174482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176147, XrefRangeEnd = 176156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x001862A4 File Offset: 0x001844A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176156, XrefRangeEnd = 176157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Chemist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00186318 File Offset: 0x00184518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 176157, XrefRangeEnd = 176158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Chemist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x000251EF File Offset: 0x000233EF
		public Chemist(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001824 RID: 6180
		// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x00186354 File Offset: 0x00184554
		// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x000251F8 File Offset: 0x000233F8
		public unsafe static int MAX_ASSIGNED_STATIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Chemist.NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS, (void*)(&value));
			}
		}

		// Token: 0x17001825 RID: 6181
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x00186370 File Offset: 0x00184570
		// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x00025206 File Offset: 0x00023406
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x001863A0 File Offset: 0x001845A0
		// (set) Token: 0x06004DB7 RID: 19895 RVA: 0x00025225 File Offset: 0x00023425
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x06004DB8 RID: 19896 RVA: 0x001863D0 File Offset: 0x001845D0
		// (set) Token: 0x06004DB9 RID: 19897 RVA: 0x00025244 File Offset: 0x00023444
		public unsafe StartChemistryStationBehaviour StartChemistryStationBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartChemistryStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartChemistryStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x06004DBA RID: 19898 RVA: 0x00186400 File Offset: 0x00184600
		// (set) Token: 0x06004DBB RID: 19899 RVA: 0x00025263 File Offset: 0x00023463
		public unsafe StartLabOvenBehaviour StartLabOvenBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x06004DBC RID: 19900 RVA: 0x00186430 File Offset: 0x00184630
		// (set) Token: 0x06004DBD RID: 19901 RVA: 0x00025282 File Offset: 0x00023482
		public unsafe FinishLabOvenBehaviour FinishLabOvenBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinishLabOvenBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_FinishLabOvenBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x00186460 File Offset: 0x00184660
		// (set) Token: 0x06004DBF RID: 19903 RVA: 0x000252A1 File Offset: 0x000234A1
		public unsafe StartCauldronBehaviour StartCauldronBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartCauldronBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartCauldronBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x00186490 File Offset: 0x00184690
		// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x000252C0 File Offset: 0x000234C0
		public unsafe StartMixingStationBehaviour StartMixingStationBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMixingStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_StartMixingStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x001864C0 File Offset: 0x001846C0
		// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x000252DF File Offset: 0x000234DF
		public unsafe ChemistUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x06004DC4 RID: 19908 RVA: 0x001864F0 File Offset: 0x001846F0
		// (set) Token: 0x06004DC5 RID: 19909 RVA: 0x000252FE File Offset: 0x000234FE
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06004DC6 RID: 19910 RVA: 0x00186520 File Offset: 0x00184720
		// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x0002531D File Offset: 0x0002351D
		public unsafe ChemistConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x00186550 File Offset: 0x00184750
		// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x0002533C File Offset: 0x0002353C
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x00186580 File Offset: 0x00184780
		// (set) Token: 0x06004DCB RID: 19915 RVA: 0x0002535B File Offset: 0x0002355B
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x001865B0 File Offset: 0x001847B0
		// (set) Token: 0x06004DCD RID: 19917 RVA: 0x0002537A File Offset: 0x0002357A
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x001865E0 File Offset: 0x001847E0
		// (set) Token: 0x06004DCF RID: 19919 RVA: 0x00025399 File Offset: 0x00023599
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x00186608 File Offset: 0x00184808
		// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x000253B4 File Offset: 0x000235B4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040034FD RID: 13565
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ASSIGNED_STATIONS;

		// Token: 0x040034FE RID: 13566
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x040034FF RID: 13567
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x04003500 RID: 13568
		private static readonly IntPtr NativeFieldInfoPtr_StartChemistryStationBehaviour;

		// Token: 0x04003501 RID: 13569
		private static readonly IntPtr NativeFieldInfoPtr_StartLabOvenBehaviour;

		// Token: 0x04003502 RID: 13570
		private static readonly IntPtr NativeFieldInfoPtr_FinishLabOvenBehaviour;

		// Token: 0x04003503 RID: 13571
		private static readonly IntPtr NativeFieldInfoPtr_StartCauldronBehaviour;

		// Token: 0x04003504 RID: 13572
		private static readonly IntPtr NativeFieldInfoPtr_StartMixingStationBehaviour;

		// Token: 0x04003505 RID: 13573
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04003506 RID: 13574
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_ChemistConfiguration_0;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_ChemistConfiguration_0;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04003514 RID: 13588
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04003515 RID: 13589
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04003516 RID: 13590
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400351A RID: 13594
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400351B RID: 13595
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x0400351C RID: 13596
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0;

		// Token: 0x0400351D RID: 13597
		private static readonly IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_0;

		// Token: 0x0400351E RID: 13598
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_0;

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_0;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003521 RID: 13601
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04003522 RID: 13602
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_0;

		// Token: 0x04003523 RID: 13603
		private static readonly IntPtr NativeMethodInfoPtr_TryStartNewTask_Private_Void_0;

		// Token: 0x04003524 RID: 13604
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0;

		// Token: 0x04003525 RID: 13605
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x04003526 RID: 13606
		private static readonly IntPtr NativeMethodInfoPtr_StartChemistryStation_Private_Void_ChemistryStation_0;

		// Token: 0x04003527 RID: 13607
		private static readonly IntPtr NativeMethodInfoPtr_StartCauldron_Private_Void_Cauldron_0;

		// Token: 0x04003528 RID: 13608
		private static readonly IntPtr NativeMethodInfoPtr_StartLabOven_Private_Void_LabOven_0;

		// Token: 0x04003529 RID: 13609
		private static readonly IntPtr NativeMethodInfoPtr_FinishLabOven_Private_Void_LabOven_0;

		// Token: 0x0400352A RID: 13610
		private static readonly IntPtr NativeMethodInfoPtr_StartMixingStation_Private_Void_MixingStation_0;

		// Token: 0x0400352B RID: 13611
		private static readonly IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0;

		// Token: 0x0400352C RID: 13612
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToFinish_Public_List_1_LabOven_0;

		// Token: 0x0400352D RID: 13613
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToStart_Public_List_1_LabOven_0;

		// Token: 0x0400352E RID: 13614
		private static readonly IntPtr NativeMethodInfoPtr_GetChemistryStationsReadyToStart_Public_List_1_ChemistryStation_0;

		// Token: 0x0400352F RID: 13615
		private static readonly IntPtr NativeMethodInfoPtr_GetCauldronsReadyToStart_Public_List_1_Cauldron_0;

		// Token: 0x04003530 RID: 13616
		private static readonly IntPtr NativeMethodInfoPtr_GetMixingStationsReadyToStart_Public_List_1_MixingStation_0;

		// Token: 0x04003531 RID: 13617
		private static readonly IntPtr NativeMethodInfoPtr_GetLabOvensReadyToMove_Protected_List_1_LabOven_0;

		// Token: 0x04003532 RID: 13618
		private static readonly IntPtr NativeMethodInfoPtr_GetChemStationsReadyToMove_Protected_List_1_ChemistryStation_0;

		// Token: 0x04003533 RID: 13619
		private static readonly IntPtr NativeMethodInfoPtr_GetCauldronsReadyToMove_Protected_List_1_Cauldron_0;

		// Token: 0x04003534 RID: 13620
		private static readonly IntPtr NativeMethodInfoPtr_GetMixStationsReadyToMove_Protected_List_1_MixingStation_0;

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x04003539 RID: 13625
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x0400353A RID: 13626
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400353B RID: 13627
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400353C RID: 13628
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04003542 RID: 13634
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04003543 RID: 13635
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Chemist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003544 RID: 13636
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000A85 RID: 2693
		[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1B4 RID: 57780 RVA: 0x003768CC File Offset: 0x00374ACC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr);
				Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "conn");
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100673384);
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100673385);
				Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, 100673386);
			}

			// Token: 0x0600E1B5 RID: 57781 RVA: 0x0037695C File Offset: 0x00374B5C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1B6 RID: 57782 RVA: 0x00376998 File Offset: 0x00374B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175599, XrefRangeEnd = 175604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E1B7 RID: 57783 RVA: 0x003769D8 File Offset: 0x00374BD8
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1B8 RID: 57784 RVA: 0x0006A5C7 File Offset: 0x000687C7
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B2 RID: 17586
			// (get) Token: 0x0600E1B9 RID: 57785 RVA: 0x00376A14 File Offset: 0x00374C14
			// (set) Token: 0x0600E1BA RID: 57786 RVA: 0x0006A5D0 File Offset: 0x000687D0
			public unsafe Chemist __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B3 RID: 17587
			// (get) Token: 0x0600E1BB RID: 57787 RVA: 0x00376A44 File Offset: 0x00374C44
			// (set) Token: 0x0600E1BC RID: 57788 RVA: 0x0006A5EF File Offset: 0x000687EF
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099A5 RID: 39333
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099A6 RID: 39334
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040099A7 RID: 39335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099A8 RID: 39336
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040099A9 RID: 39337
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000DC7 RID: 3527
			[ObfuscatedName("ScheduleOne.Employees.Chemist+<>c__DisplayClass44_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FECB RID: 65227 RVA: 0x003C9BD8 File Offset: 0x003C7DD8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673387);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673388);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673389);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673390);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673391);
					Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673392);
				}

				// Token: 0x0600FECC RID: 65228 RVA: 0x003C9CB8 File Offset: 0x003C7EB8
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FECD RID: 65229 RVA: 0x003C9D00 File Offset: 0x003C7F00
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FECE RID: 65230 RVA: 0x003C9D34 File Offset: 0x003C7F34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175583, XrefRangeEnd = 175594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D8D RID: 19853
				// (get) Token: 0x0600FECF RID: 65231 RVA: 0x003C9D70 File Offset: 0x003C7F70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FED0 RID: 65232 RVA: 0x003C9DB0 File Offset: 0x003C7FB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175594, XrefRangeEnd = 175599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D8E RID: 19854
				// (get) Token: 0x0600FED1 RID: 65233 RVA: 0x003C9DE4 File Offset: 0x003C7FE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FED2 RID: 65234 RVA: 0x00078BEC File Offset: 0x00076DEC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D8A RID: 19850
				// (get) Token: 0x0600FED3 RID: 65235 RVA: 0x003C9E24 File Offset: 0x003C8024
				// (set) Token: 0x0600FED4 RID: 65236 RVA: 0x00078BF5 File Offset: 0x00076DF5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D8B RID: 19851
				// (get) Token: 0x0600FED5 RID: 65237 RVA: 0x003C9E4C File Offset: 0x003C804C
				// (set) Token: 0x0600FED6 RID: 65238 RVA: 0x00078C10 File Offset: 0x00076E10
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D8C RID: 19852
				// (get) Token: 0x0600FED7 RID: 65239 RVA: 0x003C9E7C File Offset: 0x003C807C
				// (set) Token: 0x0600FED8 RID: 65240 RVA: 0x00078C2F File Offset: 0x00076E2F
				public unsafe Chemist.__c__DisplayClass44_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist.__c__DisplayClass44_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Chemist.__c__DisplayClass44_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABB4 RID: 43956
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABB5 RID: 43957
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABB6 RID: 43958
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABB7 RID: 43959
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABB8 RID: 43960
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABB9 RID: 43961
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABBA RID: 43962
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABBB RID: 43963
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABBC RID: 43964
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
