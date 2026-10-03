using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.StationFramework;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x0200037B RID: 891
	public class Botanist : Employee
	{
		// Token: 0x06004CEC RID: 19692 RVA: 0x00182F90 File Offset: 0x00181190
		// Note: this type is marked as 'beforefieldinit'.
		static Botanist()
		{
			Il2CppClassPointerStore<Botanist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "Botanist");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist>.NativeClassPtr);
			Botanist.NativeFieldInfoPtr_CriticalWateringThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "CriticalWateringThreshold");
			Botanist.NativeFieldInfoPtr_WateringThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WateringThreshold");
			Botanist.NativeFieldInfoPtr_MoistureLevelRandomMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MoistureLevelRandomMin");
			Botanist.NativeFieldInfoPtr_MoistureLevelRandomMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MoistureLevelRandomMax");
			Botanist.NativeFieldInfoPtr_SoilPourTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SoilPourTime");
			Botanist.NativeFieldInfoPtr_WaterPourTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WaterPourTime");
			Botanist.NativeFieldInfoPtr_AdditivePourTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "AdditivePourTime");
			Botanist.NativeFieldInfoPtr_SeedSowTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "SeedSowTime");
			Botanist.NativeFieldInfoPtr_IndividualHarvestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "IndividualHarvestTime");
			Botanist.NativeFieldInfoPtr_ApplySpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "ApplySpawnTime");
			Botanist.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "typeIcon");
			Botanist.NativeFieldInfoPtr_configReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "configReplicator");
			Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "WorldspaceUIPrefab");
			Botanist.NativeFieldInfoPtr_uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "uiPoint");
			Botanist.NativeFieldInfoPtr_MaxAssignedPots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MaxAssignedPots");
			Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoAssignedStationsDialogue");
			Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "UnspecifiedPotsDialogue");
			Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NullDestinationPotsDialogue");
			Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "MissingMaterialsDialogue");
			Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NoPotsRequireWorkDialogue");
			Botanist.NativeFieldInfoPtr__configuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<configuration>k__BackingField");
			Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr__startDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_startDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr__stopDryingRackBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_stopDryingRackBehaviour");
			Botanist.NativeFieldInfoPtr__useSpawnStationBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_useSpawnStationBehaviour");
			Botanist.NativeFieldInfoPtr__addSoilToGrowContainerBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_addSoilToGrowContainerBehaviour");
			Botanist.NativeFieldInfoPtr__applyAdditiveToGrowContainerBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_applyAdditiveToGrowContainerBehaviour");
			Botanist.NativeFieldInfoPtr__sowSeedInPotBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_sowSeedInPotBehaviour");
			Botanist.NativeFieldInfoPtr__waterPotBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_waterPotBehaviour");
			Botanist.NativeFieldInfoPtr__harvestPotBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_harvestPotBehaviour");
			Botanist.NativeFieldInfoPtr__mistMushroomBedBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_mistMushroomBedBehaviour");
			Botanist.NativeFieldInfoPtr__harvestMushroomBedBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_harvestMushroomBedBehaviour");
			Botanist.NativeFieldInfoPtr__applySpawnToMushroomBedBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_applySpawnToMushroomBedBehaviour");
			Botanist.NativeFieldInfoPtr__workBehaviours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "_workBehaviours");
			Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.BotanistAssembly-CSharp.dll_Excuted");
			Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673253);
			Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673254);
			Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673255);
			Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673256);
			Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673257);
			Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673258);
			Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673259);
			Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673260);
			Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673261);
			Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673262);
			Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673263);
			Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673264);
			Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673265);
			Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673266);
			Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673267);
			Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673268);
			Botanist.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673269);
			Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673270);
			Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673271);
			Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673272);
			Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673273);
			Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673274);
			Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673275);
			Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673276);
			Botanist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673277);
			Botanist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673278);
			Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673279);
			Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673280);
			Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673281);
			Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673282);
			Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673283);
			Botanist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673284);
			Botanist.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Public_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673285);
			Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673286);
			Botanist.NativeMethodInfoPtr_GetGrowContainersForSoilPour_Private_List_1_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673287);
			Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673288);
			Botanist.NativeMethodInfoPtr_GetGrowContainersForAdditives_Private_List_1_GrowContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673289);
			Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673290);
			Botanist.NativeMethodInfoPtr_GetMushroomBedForMisting_Private_MushroomBed_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673291);
			Botanist.NativeMethodInfoPtr_GetMushroomBedsForHarvest_Private_List_1_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673292);
			Botanist.NativeMethodInfoPtr_GetBedsReadyForSpawn_Private_List_1_MushroomBed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673293);
			Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673294);
			Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673295);
			Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673296);
			Botanist.NativeMethodInfoPtr_GetSpawnStationsReadyToUse_Private_List_1_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673297);
			Botanist.NativeMethodInfoPtr_GetSpawnStationsReadyToMove_Private_List_1_MushroomSpawnStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673298);
			Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673299);
			Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673300);
			Botanist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673301);
			Botanist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673302);
			Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673303);
			Botanist.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673304);
			Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673305);
			Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673306);
			Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673307);
			Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673308);
			Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673309);
			Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673310);
			Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673311);
			Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673312);
			Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673313);
			Botanist.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist>.NativeClassPtr, 100673314);
		}

		// Token: 0x17001818 RID: 6168
		// (get) Token: 0x06004CED RID: 19693 RVA: 0x00183790 File Offset: 0x00181990
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 174453, RefRangeEnd = 174468, XrefRangeStart = 174453, XrefRangeEnd = 174453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17001819 RID: 6169
		// (get) Token: 0x06004CEE RID: 19694 RVA: 0x001837D0 File Offset: 0x001819D0
		// (set) Token: 0x06004CEF RID: 19695 RVA: 0x00183810 File Offset: 0x00181A10
		public unsafe BotanistConfiguration configuration
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 174453, RefRangeEnd = 174468, XrefRangeStart = 174453, XrefRangeEnd = 174468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174468, XrefRangeEnd = 174469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700181A RID: 6170
		// (get) Token: 0x06004CF0 RID: 19696 RVA: 0x00183854 File Offset: 0x00181A54
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 174469, RefRangeEnd = 174474, XrefRangeStart = 174469, XrefRangeEnd = 174469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x1700181B RID: 6171
		// (get) Token: 0x06004CF1 RID: 19697 RVA: 0x00183894 File Offset: 0x00181A94
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 118222, RefRangeEnd = 118228, XrefRangeStart = 118222, XrefRangeEnd = 118228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700181C RID: 6172
		// (get) Token: 0x06004CF2 RID: 19698 RVA: 0x001838D0 File Offset: 0x00181AD0
		// (set) Token: 0x06004CF3 RID: 19699 RVA: 0x00183910 File Offset: 0x00181B10
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 174474, RefRangeEnd = 174482, XrefRangeStart = 174474, XrefRangeEnd = 174474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174482, XrefRangeEnd = 174483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700181D RID: 6173
		// (get) Token: 0x06004CF4 RID: 19700 RVA: 0x00183954 File Offset: 0x00181B54
		// (set) Token: 0x06004CF5 RID: 19701 RVA: 0x00183994 File Offset: 0x00181B94
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 174491, RefRangeEnd = 174493, XrefRangeStart = 174483, XrefRangeEnd = 174491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x001839D8 File Offset: 0x00181BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174493, XrefRangeEnd = 174515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700181E RID: 6174
		// (get) Token: 0x06004CF7 RID: 19703 RVA: 0x00183A1C File Offset: 0x00181C1C
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x1700181F RID: 6175
		// (get) Token: 0x06004CF8 RID: 19704 RVA: 0x00183A5C File Offset: 0x00181C5C
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44652, RefRangeEnd = 44654, XrefRangeStart = 44652, XrefRangeEnd = 44654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001820 RID: 6176
		// (get) Token: 0x06004CF9 RID: 19705 RVA: 0x00183A9C File Offset: 0x00181C9C
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17001821 RID: 6177
		// (get) Token: 0x06004CFA RID: 19706 RVA: 0x00183ADC File Offset: 0x00181CDC
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001822 RID: 6178
		// (get) Token: 0x06004CFB RID: 19707 RVA: 0x00183B18 File Offset: 0x00181D18
		public unsafe virtual Property ParentProperty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00183B58 File Offset: 0x00181D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174515, XrefRangeEnd = 174516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00183B94 File Offset: 0x00181D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174516, XrefRangeEnd = 174534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsAnyWorkInProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00183BDC File Offset: 0x00181DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174534, XrefRangeEnd = 174908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateBehaviour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00183C18 File Offset: 0x00181E18
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 174916, RefRangeEnd = 174930, XrefRangeStart = 174908, XrefRangeEnd = 174916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEntityAccessible(ITransitEntity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00183C68 File Offset: 0x00181E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174933, RefRangeEnd = 174934, XrefRangeStart = 174930, XrefRangeEnd = 174933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00183CAC File Offset: 0x00181EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174937, RefRangeEnd = 174938, XrefRangeStart = 174934, XrefRangeEnd = 174937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDryingRack(DryingRack rack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x00183CF0 File Offset: 0x00181EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174938, XrefRangeEnd = 174956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00183D40 File Offset: 0x00181F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174956, XrefRangeEnd = 174973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00183D84 File Offset: 0x00181F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174973, XrefRangeEnd = 174982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AssignProperty(Property prop, bool warp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(prop);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref warp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00183DE0 File Offset: 0x00181FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174982, XrefRangeEnd = 174985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnassignProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00183E1C File Offset: 0x0018201C
		[CallerCount(0)]
		public unsafe override void ResetConfiguration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00183E58 File Offset: 0x00182058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174985, XrefRangeEnd = 174991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Fire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Fire_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00183E94 File Offset: 0x00182094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174991, XrefRangeEnd = 175009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanMoveDryableToRack(out QualityItemInstance dryable, out DryingRack destinationRack, out int moveQuantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &moveQuantity;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			dryable = ((intPtr5 == 0) ? null : new QualityItemInstance(intPtr5));
			IntPtr intPtr6 = intPtr2;
			destinationRack = ((intPtr6 == 0) ? null : new DryingRack(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x00183F24 File Offset: 0x00182124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175047, RefRangeEnd = 175049, XrefRangeStart = 175009, XrefRangeEnd = 175047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetDryableInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00183F64 File Offset: 0x00182164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175065, RefRangeEnd = 175067, XrefRangeStart = 175049, XrefRangeEnd = 175065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRack GetAssignedDryingRackFor(QualityItemInstance dryable, out int rackInputCapacity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dryable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rackInputCapacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00183FC4 File Offset: 0x001821C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175067, XrefRangeEnd = 175068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldIdle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x0018400C File Offset: 0x0018220C
		[CallerCount(0)]
		public unsafe override EmployeeHome GetHome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeHome>(intPtr3) : null;
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00184058 File Offset: 0x00182258
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 175075, RefRangeEnd = 175078, XrefRangeStart = 175068, XrefRangeEnd = 175075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetSuppliesAsTransitEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Public_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00184098 File Offset: 0x00182298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175088, RefRangeEnd = 175090, XrefRangeStart = 175078, XrefRangeEnd = 175088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot GetPotForWatering(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x001840E4 File Offset: 0x001822E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175129, RefRangeEnd = 175130, XrefRangeStart = 175090, XrefRangeEnd = 175129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GrowContainer> GetGrowContainersForSoilPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetGrowContainersForSoilPour_Private_List_1_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GrowContainer>>(intPtr3) : null;
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00184124 File Offset: 0x00182324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175130, XrefRangeEnd = 175146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsReadyForSeed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00184164 File Offset: 0x00182364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175187, RefRangeEnd = 175188, XrefRangeStart = 175146, XrefRangeEnd = 175187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<GrowContainer> GetGrowContainersForAdditives()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetGrowContainersForAdditives_Private_List_1_GrowContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GrowContainer>>(intPtr3) : null;
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x001841A4 File Offset: 0x001823A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175216, RefRangeEnd = 175217, XrefRangeStart = 175188, XrefRangeEnd = 175216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Pot> GetPotsForHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x001841E4 File Offset: 0x001823E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 175227, RefRangeEnd = 175229, XrefRangeStart = 175217, XrefRangeEnd = 175227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBed GetMushroomBedForMisting(float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetMushroomBedForMisting_Private_MushroomBed_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr3) : null;
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x00184230 File Offset: 0x00182430
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175257, RefRangeEnd = 175258, XrefRangeStart = 175229, XrefRangeEnd = 175257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MushroomBed> GetMushroomBedsForHarvest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetMushroomBedsForHarvest_Private_List_1_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomBed>>(intPtr3) : null;
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x00184270 File Offset: 0x00182470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175258, XrefRangeEnd = 175274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MushroomBed> GetBedsReadyForSpawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetBedsReadyForSpawn_Private_List_1_MushroomBed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomBed>>(intPtr3) : null;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x001842B0 File Offset: 0x001824B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175274, XrefRangeEnd = 175291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x001842F0 File Offset: 0x001824F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175291, XrefRangeEnd = 175308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksToStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x00184330 File Offset: 0x00182530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175332, RefRangeEnd = 175333, XrefRangeStart = 175308, XrefRangeEnd = 175332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DryingRack> GetRacksReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr3) : null;
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x00184370 File Offset: 0x00182570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175333, XrefRangeEnd = 175350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MushroomSpawnStation> GetSpawnStationsReadyToUse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetSpawnStationsReadyToUse_Private_List_1_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomSpawnStation>>(intPtr3) : null;
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x001843B0 File Offset: 0x001825B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175374, RefRangeEnd = 175375, XrefRangeStart = 175350, XrefRangeEnd = 175374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<MushroomSpawnStation> GetSpawnStationsReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_GetSpawnStationsReadyToMove_Private_List_1_MushroomSpawnStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<MushroomSpawnStation>>(intPtr3) : null;
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x001843F0 File Offset: 0x001825F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175402, RefRangeEnd = 175403, XrefRangeStart = 175375, XrefRangeEnd = 175402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x00184430 File Offset: 0x00182630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175403, XrefRangeEnd = 175407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x00184464 File Offset: 0x00182664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175407, XrefRangeEnd = 175419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NPCData GetNPCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPCData>(intPtr3) : null;
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x001844B0 File Offset: 0x001826B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175419, XrefRangeEnd = 175423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr3) : null;
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x001844FC File Offset: 0x001826FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175423, XrefRangeEnd = 175429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00184558 File Offset: 0x00182758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175429, XrefRangeEnd = 175437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Botanist() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x00184594 File Offset: 0x00182794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175437, XrefRangeEnd = 175461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x001845D0 File Offset: 0x001827D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175461, XrefRangeEnd = 175462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x0018460C File Offset: 0x0018280C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x00184648 File Offset: 0x00182848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175462, XrefRangeEnd = 175472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x0018468C File Offset: 0x0018288C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 174491, RefRangeEnd = 174493, XrefRangeStart = 174491, XrefRangeEnd = 174493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x001846D0 File Offset: 0x001828D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175472, XrefRangeEnd = 175476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001823 RID: 6179
		// (get) Token: 0x06004D27 RID: 19751 RVA: 0x00184734 File Offset: 0x00182934
		// (set) Token: 0x06004D28 RID: 19752 RVA: 0x00184774 File Offset: 0x00182974
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175476, XrefRangeEnd = 175485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x001847C4 File Offset: 0x001829C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175485, XrefRangeEnd = 175486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Employees_Botanist(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00184838 File Offset: 0x00182A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175582, RefRangeEnd = 175583, XrefRangeStart = 175486, XrefRangeEnd = 175582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Botanist.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00024E02 File Offset: 0x00023002
		public Botanist(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x06004D2C RID: 19756 RVA: 0x00184874 File Offset: 0x00182A74
		// (set) Token: 0x06004D2D RID: 19757 RVA: 0x00024E0B File Offset: 0x0002300B
		public unsafe static float CriticalWateringThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_CriticalWateringThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_CriticalWateringThreshold, (void*)(&value));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x06004D2E RID: 19758 RVA: 0x00184890 File Offset: 0x00182A90
		// (set) Token: 0x06004D2F RID: 19759 RVA: 0x00024E19 File Offset: 0x00023019
		public unsafe static float WateringThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_WateringThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_WateringThreshold, (void*)(&value));
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x06004D30 RID: 19760 RVA: 0x001848AC File Offset: 0x00182AAC
		// (set) Token: 0x06004D31 RID: 19761 RVA: 0x00024E27 File Offset: 0x00023027
		public unsafe static float MoistureLevelRandomMin
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_MoistureLevelRandomMin, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_MoistureLevelRandomMin, (void*)(&value));
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004D32 RID: 19762 RVA: 0x001848C8 File Offset: 0x00182AC8
		// (set) Token: 0x06004D33 RID: 19763 RVA: 0x00024E35 File Offset: 0x00023035
		public unsafe static float MoistureLevelRandomMax
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_MoistureLevelRandomMax, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_MoistureLevelRandomMax, (void*)(&value));
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x001848E4 File Offset: 0x00182AE4
		// (set) Token: 0x06004D35 RID: 19765 RVA: 0x00024E43 File Offset: 0x00023043
		public unsafe static float SoilPourTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_SoilPourTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_SoilPourTime, (void*)(&value));
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x00184900 File Offset: 0x00182B00
		// (set) Token: 0x06004D37 RID: 19767 RVA: 0x00024E51 File Offset: 0x00023051
		public unsafe static float WaterPourTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_WaterPourTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_WaterPourTime, (void*)(&value));
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x0018491C File Offset: 0x00182B1C
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x00024E5F File Offset: 0x0002305F
		public unsafe static float AdditivePourTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_AdditivePourTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_AdditivePourTime, (void*)(&value));
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x00184938 File Offset: 0x00182B38
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x00024E6D File Offset: 0x0002306D
		public unsafe static float SeedSowTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_SeedSowTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_SeedSowTime, (void*)(&value));
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x00184954 File Offset: 0x00182B54
		// (set) Token: 0x06004D3D RID: 19773 RVA: 0x00024E7B File Offset: 0x0002307B
		public unsafe static float IndividualHarvestTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_IndividualHarvestTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_IndividualHarvestTime, (void*)(&value));
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004D3E RID: 19774 RVA: 0x00184970 File Offset: 0x00182B70
		// (set) Token: 0x06004D3F RID: 19775 RVA: 0x00024E89 File Offset: 0x00023089
		public unsafe static float ApplySpawnTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Botanist.NativeFieldInfoPtr_ApplySpawnTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Botanist.NativeFieldInfoPtr_ApplySpawnTime, (void*)(&value));
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06004D40 RID: 19776 RVA: 0x0018498C File Offset: 0x00182B8C
		// (set) Token: 0x06004D41 RID: 19777 RVA: 0x00024E97 File Offset: 0x00023097
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x06004D42 RID: 19778 RVA: 0x001849BC File Offset: 0x00182BBC
		// (set) Token: 0x06004D43 RID: 19779 RVA: 0x00024EB6 File Offset: 0x000230B6
		public unsafe ConfigurationReplicator configReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_configReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x06004D44 RID: 19780 RVA: 0x001849EC File Offset: 0x00182BEC
		// (set) Token: 0x06004D45 RID: 19781 RVA: 0x00024ED5 File Offset: 0x000230D5
		public unsafe BotanistUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x06004D46 RID: 19782 RVA: 0x00184A1C File Offset: 0x00182C1C
		// (set) Token: 0x06004D47 RID: 19783 RVA: 0x00024EF4 File Offset: 0x000230F4
		public unsafe Transform uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x06004D48 RID: 19784 RVA: 0x00184A4C File Offset: 0x00182C4C
		// (set) Token: 0x06004D49 RID: 19785 RVA: 0x00024F13 File Offset: 0x00023113
		public unsafe int MaxAssignedPots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MaxAssignedPots)) = value;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x06004D4A RID: 19786 RVA: 0x00184A74 File Offset: 0x00182C74
		// (set) Token: 0x06004D4B RID: 19787 RVA: 0x00024F2E File Offset: 0x0002312E
		public unsafe DialogueContainer NoAssignedStationsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoAssignedStationsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06004D4C RID: 19788 RVA: 0x00184AA4 File Offset: 0x00182CA4
		// (set) Token: 0x06004D4D RID: 19789 RVA: 0x00024F4D File Offset: 0x0002314D
		public unsafe DialogueContainer UnspecifiedPotsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_UnspecifiedPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06004D4E RID: 19790 RVA: 0x00184AD4 File Offset: 0x00182CD4
		// (set) Token: 0x06004D4F RID: 19791 RVA: 0x00024F6C File Offset: 0x0002316C
		public unsafe DialogueContainer NullDestinationPotsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NullDestinationPotsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06004D50 RID: 19792 RVA: 0x00184B04 File Offset: 0x00182D04
		// (set) Token: 0x06004D51 RID: 19793 RVA: 0x00024F8B File Offset: 0x0002318B
		public unsafe DialogueContainer MissingMaterialsDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_MissingMaterialsDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06004D52 RID: 19794 RVA: 0x00184B34 File Offset: 0x00182D34
		// (set) Token: 0x06004D53 RID: 19795 RVA: 0x00024FAA File Offset: 0x000231AA
		public unsafe DialogueContainer NoPotsRequireWorkDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_NoPotsRequireWorkDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06004D54 RID: 19796 RVA: 0x00184B64 File Offset: 0x00182D64
		// (set) Token: 0x06004D55 RID: 19797 RVA: 0x00024FC9 File Offset: 0x000231C9
		public unsafe BotanistConfiguration _configuration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BotanistConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__configuration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x00184B94 File Offset: 0x00182D94
		// (set) Token: 0x06004D57 RID: 19799 RVA: 0x00024FE8 File Offset: 0x000231E8
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x00184BC4 File Offset: 0x00182DC4
		// (set) Token: 0x06004D59 RID: 19801 RVA: 0x00025007 File Offset: 0x00023207
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06004D5A RID: 19802 RVA: 0x00184BF4 File Offset: 0x00182DF4
		// (set) Token: 0x06004D5B RID: 19803 RVA: 0x00025026 File Offset: 0x00023226
		public unsafe StartDryingRackBehaviour _startDryingRackBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__startDryingRackBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__startDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06004D5C RID: 19804 RVA: 0x00184C24 File Offset: 0x00182E24
		// (set) Token: 0x06004D5D RID: 19805 RVA: 0x00025045 File Offset: 0x00023245
		public unsafe StopDryingRackBehaviour _stopDryingRackBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__stopDryingRackBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StopDryingRackBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__stopDryingRackBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06004D5E RID: 19806 RVA: 0x00184C54 File Offset: 0x00182E54
		// (set) Token: 0x06004D5F RID: 19807 RVA: 0x00025064 File Offset: 0x00023264
		public unsafe UseSpawnStationBehaviour _useSpawnStationBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__useSpawnStationBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseSpawnStationBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__useSpawnStationBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06004D60 RID: 19808 RVA: 0x00184C84 File Offset: 0x00182E84
		// (set) Token: 0x06004D61 RID: 19809 RVA: 0x00025083 File Offset: 0x00023283
		public unsafe AddSoilToGrowContainerBehaviour _addSoilToGrowContainerBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__addSoilToGrowContainerBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddSoilToGrowContainerBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__addSoilToGrowContainerBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x00184CB4 File Offset: 0x00182EB4
		// (set) Token: 0x06004D63 RID: 19811 RVA: 0x000250A2 File Offset: 0x000232A2
		public unsafe ApplyAdditiveToGrowContainerBehaviour _applyAdditiveToGrowContainerBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__applyAdditiveToGrowContainerBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplyAdditiveToGrowContainerBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__applyAdditiveToGrowContainerBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x00184CE4 File Offset: 0x00182EE4
		// (set) Token: 0x06004D65 RID: 19813 RVA: 0x000250C1 File Offset: 0x000232C1
		public unsafe SowSeedInPotBehaviour _sowSeedInPotBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__sowSeedInPotBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SowSeedInPotBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__sowSeedInPotBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x00184D14 File Offset: 0x00182F14
		// (set) Token: 0x06004D67 RID: 19815 RVA: 0x000250E0 File Offset: 0x000232E0
		public unsafe WaterPotBehaviour _waterPotBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__waterPotBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaterPotBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__waterPotBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06004D68 RID: 19816 RVA: 0x00184D44 File Offset: 0x00182F44
		// (set) Token: 0x06004D69 RID: 19817 RVA: 0x000250FF File Offset: 0x000232FF
		public unsafe HarvestPotBehaviour _harvestPotBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__harvestPotBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HarvestPotBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__harvestPotBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00184D74 File Offset: 0x00182F74
		// (set) Token: 0x06004D6B RID: 19819 RVA: 0x0002511E File Offset: 0x0002331E
		public unsafe MistMushroomBedBehaviour _mistMushroomBedBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__mistMushroomBedBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MistMushroomBedBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__mistMushroomBedBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06004D6C RID: 19820 RVA: 0x00184DA4 File Offset: 0x00182FA4
		// (set) Token: 0x06004D6D RID: 19821 RVA: 0x0002513D File Offset: 0x0002333D
		public unsafe HarvestMushroomBedBehaviour _harvestMushroomBedBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__harvestMushroomBedBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HarvestMushroomBedBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__harvestMushroomBedBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06004D6E RID: 19822 RVA: 0x00184DD4 File Offset: 0x00182FD4
		// (set) Token: 0x06004D6F RID: 19823 RVA: 0x0002515C File Offset: 0x0002335C
		public unsafe ApplySpawnToMushroomBedBehaviour _applySpawnToMushroomBedBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__applySpawnToMushroomBedBehaviour);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ApplySpawnToMushroomBedBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__applySpawnToMushroomBedBehaviour), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06004D70 RID: 19824 RVA: 0x00184E04 File Offset: 0x00183004
		// (set) Token: 0x06004D71 RID: 19825 RVA: 0x0002517B File Offset: 0x0002337B
		public unsafe List<Il2CppScheduleOne.NPCs.Behaviour.Behaviour> _workBehaviours
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__workBehaviours);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppScheduleOne.NPCs.Behaviour.Behaviour>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr__workBehaviours), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00184E34 File Offset: 0x00183034
		// (set) Token: 0x06004D73 RID: 19827 RVA: 0x0002519A File Offset: 0x0002339A
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06004D74 RID: 19828 RVA: 0x00184E64 File Offset: 0x00183064
		// (set) Token: 0x06004D75 RID: 19829 RVA: 0x000251B9 File Offset: 0x000233B9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001817 RID: 6167
		// (get) Token: 0x06004D76 RID: 19830 RVA: 0x00184E8C File Offset: 0x0018308C
		// (set) Token: 0x06004D77 RID: 19831 RVA: 0x000251D4 File Offset: 0x000233D4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003499 RID: 13465
		private static readonly IntPtr NativeFieldInfoPtr_CriticalWateringThreshold;

		// Token: 0x0400349A RID: 13466
		private static readonly IntPtr NativeFieldInfoPtr_WateringThreshold;

		// Token: 0x0400349B RID: 13467
		private static readonly IntPtr NativeFieldInfoPtr_MoistureLevelRandomMin;

		// Token: 0x0400349C RID: 13468
		private static readonly IntPtr NativeFieldInfoPtr_MoistureLevelRandomMax;

		// Token: 0x0400349D RID: 13469
		private static readonly IntPtr NativeFieldInfoPtr_SoilPourTime;

		// Token: 0x0400349E RID: 13470
		private static readonly IntPtr NativeFieldInfoPtr_WaterPourTime;

		// Token: 0x0400349F RID: 13471
		private static readonly IntPtr NativeFieldInfoPtr_AdditivePourTime;

		// Token: 0x040034A0 RID: 13472
		private static readonly IntPtr NativeFieldInfoPtr_SeedSowTime;

		// Token: 0x040034A1 RID: 13473
		private static readonly IntPtr NativeFieldInfoPtr_IndividualHarvestTime;

		// Token: 0x040034A2 RID: 13474
		private static readonly IntPtr NativeFieldInfoPtr_ApplySpawnTime;

		// Token: 0x040034A3 RID: 13475
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x040034A4 RID: 13476
		private static readonly IntPtr NativeFieldInfoPtr_configReplicator;

		// Token: 0x040034A5 RID: 13477
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x040034A6 RID: 13478
		private static readonly IntPtr NativeFieldInfoPtr_uiPoint;

		// Token: 0x040034A7 RID: 13479
		private static readonly IntPtr NativeFieldInfoPtr_MaxAssignedPots;

		// Token: 0x040034A8 RID: 13480
		private static readonly IntPtr NativeFieldInfoPtr_NoAssignedStationsDialogue;

		// Token: 0x040034A9 RID: 13481
		private static readonly IntPtr NativeFieldInfoPtr_UnspecifiedPotsDialogue;

		// Token: 0x040034AA RID: 13482
		private static readonly IntPtr NativeFieldInfoPtr_NullDestinationPotsDialogue;

		// Token: 0x040034AB RID: 13483
		private static readonly IntPtr NativeFieldInfoPtr_MissingMaterialsDialogue;

		// Token: 0x040034AC RID: 13484
		private static readonly IntPtr NativeFieldInfoPtr_NoPotsRequireWorkDialogue;

		// Token: 0x040034AD RID: 13485
		private static readonly IntPtr NativeFieldInfoPtr__configuration_k__BackingField;

		// Token: 0x040034AE RID: 13486
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x040034AF RID: 13487
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x040034B0 RID: 13488
		private static readonly IntPtr NativeFieldInfoPtr__startDryingRackBehaviour;

		// Token: 0x040034B1 RID: 13489
		private static readonly IntPtr NativeFieldInfoPtr__stopDryingRackBehaviour;

		// Token: 0x040034B2 RID: 13490
		private static readonly IntPtr NativeFieldInfoPtr__useSpawnStationBehaviour;

		// Token: 0x040034B3 RID: 13491
		private static readonly IntPtr NativeFieldInfoPtr__addSoilToGrowContainerBehaviour;

		// Token: 0x040034B4 RID: 13492
		private static readonly IntPtr NativeFieldInfoPtr__applyAdditiveToGrowContainerBehaviour;

		// Token: 0x040034B5 RID: 13493
		private static readonly IntPtr NativeFieldInfoPtr__sowSeedInPotBehaviour;

		// Token: 0x040034B6 RID: 13494
		private static readonly IntPtr NativeFieldInfoPtr__waterPotBehaviour;

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeFieldInfoPtr__harvestPotBehaviour;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeFieldInfoPtr__mistMushroomBedBehaviour;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeFieldInfoPtr__harvestMushroomBedBehaviour;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeFieldInfoPtr__applySpawnToMushroomBedBehaviour;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeFieldInfoPtr__workBehaviours;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_get_configuration_Protected_get_BotanistConfiguration_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_set_configuration_Protected_set_Void_BotanistConfiguration_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_Virtual_Final_New_get_Property_0;

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeMethodInfoPtr_IsAnyWorkInProgress_Protected_Virtual_Boolean_0;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBehaviour_Protected_Virtual_Void_1;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeMethodInfoPtr_IsEntityAccessible_Private_Boolean_ITransitEntity_0;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeMethodInfoPtr_StartDryingRack_Private_Void_DryingRack_0;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeMethodInfoPtr_StopDryingRack_Private_Void_DryingRack_0;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x040034D6 RID: 13526
		private static readonly IntPtr NativeMethodInfoPtr_AssignProperty_Protected_Virtual_Void_Property_Boolean_0;

		// Token: 0x040034D7 RID: 13527
		private static readonly IntPtr NativeMethodInfoPtr_UnassignProperty_Protected_Virtual_Void_1;

		// Token: 0x040034D8 RID: 13528
		private static readonly IntPtr NativeMethodInfoPtr_ResetConfiguration_Protected_Virtual_Void_1;

		// Token: 0x040034D9 RID: 13529
		private static readonly IntPtr NativeMethodInfoPtr_Fire_Protected_Virtual_Void_1;

		// Token: 0x040034DA RID: 13530
		private static readonly IntPtr NativeMethodInfoPtr_CanMoveDryableToRack_Private_Boolean_byref_QualityItemInstance_byref_DryingRack_byref_Int32_0;

		// Token: 0x040034DB RID: 13531
		private static readonly IntPtr NativeMethodInfoPtr_GetDryableInSupplies_Public_QualityItemInstance_0;

		// Token: 0x040034DC RID: 13532
		private static readonly IntPtr NativeMethodInfoPtr_GetAssignedDryingRackFor_Private_DryingRack_QualityItemInstance_byref_Int32_0;

		// Token: 0x040034DD RID: 13533
		private static readonly IntPtr NativeMethodInfoPtr_ShouldIdle_Protected_Virtual_Boolean_0;

		// Token: 0x040034DE RID: 13534
		private static readonly IntPtr NativeMethodInfoPtr_GetHome_Public_Virtual_EmployeeHome_0;

		// Token: 0x040034DF RID: 13535
		private static readonly IntPtr NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Public_ITransitEntity_0;

		// Token: 0x040034E0 RID: 13536
		private static readonly IntPtr NativeMethodInfoPtr_GetPotForWatering_Private_Pot_Single_0;

		// Token: 0x040034E1 RID: 13537
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowContainersForSoilPour_Private_List_1_GrowContainer_0;

		// Token: 0x040034E2 RID: 13538
		private static readonly IntPtr NativeMethodInfoPtr_GetPotsReadyForSeed_Private_List_1_Pot_0;

		// Token: 0x040034E3 RID: 13539
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowContainersForAdditives_Private_List_1_GrowContainer_0;

		// Token: 0x040034E4 RID: 13540
		private static readonly IntPtr NativeMethodInfoPtr_GetPotsForHarvest_Private_List_1_Pot_0;

		// Token: 0x040034E5 RID: 13541
		private static readonly IntPtr NativeMethodInfoPtr_GetMushroomBedForMisting_Private_MushroomBed_Single_0;

		// Token: 0x040034E6 RID: 13542
		private static readonly IntPtr NativeMethodInfoPtr_GetMushroomBedsForHarvest_Private_List_1_MushroomBed_0;

		// Token: 0x040034E7 RID: 13543
		private static readonly IntPtr NativeMethodInfoPtr_GetBedsReadyForSpawn_Private_List_1_MushroomBed_0;

		// Token: 0x040034E8 RID: 13544
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksToStart_Private_List_1_DryingRack_0;

		// Token: 0x040034E9 RID: 13545
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksToStop_Private_List_1_DryingRack_0;

		// Token: 0x040034EA RID: 13546
		private static readonly IntPtr NativeMethodInfoPtr_GetRacksReadyToMove_Private_List_1_DryingRack_0;

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnStationsReadyToUse_Private_List_1_MushroomSpawnStation_0;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeMethodInfoPtr_GetSpawnStationsReadyToMove_Private_List_1_MushroomSpawnStation_0;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCData_Public_Virtual_NPCData_0;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_List_1_String_String_0;

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Employees_Botanist_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040034FC RID: 13564
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A83 RID: 2691
		[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E1A0 RID: 57760 RVA: 0x0037652C File Offset: 0x0037472C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr);
				Botanist.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, "<>9");
				Botanist.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, "<>9__62_0");
				Botanist.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, "<>9__63_0");
				Botanist.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, 100673316);
				Botanist.__c.NativeMethodInfoPtr__IsAnyWorkInProgress_b__62_0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, 100673317);
				Botanist.__c.NativeMethodInfoPtr__UpdateBehaviour_b__63_0_Internal_Boolean_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr, 100673318);
			}

			// Token: 0x0600E1A1 RID: 57761 RVA: 0x003765D0 File Offset: 0x003747D0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1A2 RID: 57762 RVA: 0x0037660C File Offset: 0x0037480C
			[CallerCount(0)]
			public unsafe bool _IsAnyWorkInProgress_b__62_0(Il2CppScheduleOne.NPCs.Behaviour.Behaviour b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c.NativeMethodInfoPtr__IsAnyWorkInProgress_b__62_0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A3 RID: 57763 RVA: 0x0037665C File Offset: 0x0037485C
			[CallerCount(0)]
			public unsafe bool _UpdateBehaviour_b__63_0(Il2CppScheduleOne.NPCs.Behaviour.Behaviour b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c.NativeMethodInfoPtr__UpdateBehaviour_b__63_0_Internal_Boolean_Behaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1A4 RID: 57764 RVA: 0x0006A541 File Offset: 0x00068741
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AD RID: 17581
			// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x003766AC File Offset: 0x003748AC
			// (set) Token: 0x0600E1A6 RID: 57766 RVA: 0x0006A54A File Offset: 0x0006874A
			public unsafe static Botanist.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Botanist.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Botanist.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AE RID: 17582
			// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x003766D4 File Offset: 0x003748D4
			// (set) Token: 0x0600E1A8 RID: 57768 RVA: 0x0006A55C File Offset: 0x0006875C
			public unsafe static Func<Il2CppScheduleOne.NPCs.Behaviour.Behaviour, bool> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Botanist.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppScheduleOne.NPCs.Behaviour.Behaviour, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Botanist.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AF RID: 17583
			// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x003766FC File Offset: 0x003748FC
			// (set) Token: 0x0600E1AA RID: 57770 RVA: 0x0006A56E File Offset: 0x0006876E
			public unsafe static Func<Il2CppScheduleOne.NPCs.Behaviour.Behaviour, bool> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Botanist.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppScheduleOne.NPCs.Behaviour.Behaviour, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Botanist.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400999A RID: 39322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400999B RID: 39323
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x0400999C RID: 39324
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x0400999D RID: 39325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400999E RID: 39326
			private static readonly IntPtr NativeMethodInfoPtr__IsAnyWorkInProgress_b__62_0_Internal_Boolean_Behaviour_0;

			// Token: 0x0400999F RID: 39327
			private static readonly IntPtr NativeMethodInfoPtr__UpdateBehaviour_b__63_0_Internal_Boolean_Behaviour_0;
		}

		// Token: 0x02000A84 RID: 2692
		[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E1AB RID: 57771 RVA: 0x00376724 File Offset: 0x00374924
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr);
				Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
				Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, "conn");
				Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, 100673319);
				Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, 100673320);
				Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, 100673321);
			}

			// Token: 0x0600E1AC RID: 57772 RVA: 0x003767B4 File Offset: 0x003749B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E1AD RID: 57773 RVA: 0x003767F0 File Offset: 0x003749F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174448, XrefRangeEnd = 174453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E1AE RID: 57774 RVA: 0x00376830 File Offset: 0x00374A30
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E1AF RID: 57775 RVA: 0x0006A580 File Offset: 0x00068780
			public __c__DisplayClass68_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B0 RID: 17584
			// (get) Token: 0x0600E1B0 RID: 57776 RVA: 0x0037686C File Offset: 0x00374A6C
			// (set) Token: 0x0600E1B1 RID: 57777 RVA: 0x0006A589 File Offset: 0x00068789
			public unsafe Botanist __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B1 RID: 17585
			// (get) Token: 0x0600E1B2 RID: 57778 RVA: 0x0037689C File Offset: 0x00374A9C
			// (set) Token: 0x0600E1B3 RID: 57779 RVA: 0x0006A5A8 File Offset: 0x000687A8
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099A0 RID: 39328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099A1 RID: 39329
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x040099A2 RID: 39330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040099A3 RID: 39331
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040099A4 RID: 39332
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000DC6 RID: 3526
			[ObfuscatedName("ScheduleOne.Employees.Botanist+<>c__DisplayClass68_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FEBD RID: 65213 RVA: 0x003C9904 File Offset: 0x003C7B04
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673322);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673323);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673324);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673325);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673326);
					Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100673327);
				}

				// Token: 0x0600FEBE RID: 65214 RVA: 0x003C99E4 File Offset: 0x003C7BE4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEBF RID: 65215 RVA: 0x003C9A2C File Offset: 0x003C7C2C
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FEC0 RID: 65216 RVA: 0x003C9A60 File Offset: 0x003C7C60
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174432, XrefRangeEnd = 174443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D88 RID: 19848
				// (get) Token: 0x0600FEC1 RID: 65217 RVA: 0x003C9A9C File Offset: 0x003C7C9C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEC2 RID: 65218 RVA: 0x003C9ADC File Offset: 0x003C7CDC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174443, XrefRangeEnd = 174448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D89 RID: 19849
				// (get) Token: 0x0600FEC3 RID: 65219 RVA: 0x003C9B10 File Offset: 0x003C7D10
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FEC4 RID: 65220 RVA: 0x00078B8A File Offset: 0x00076D8A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004D85 RID: 19845
				// (get) Token: 0x0600FEC5 RID: 65221 RVA: 0x003C9B50 File Offset: 0x003C7D50
				// (set) Token: 0x0600FEC6 RID: 65222 RVA: 0x00078B93 File Offset: 0x00076D93
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004D86 RID: 19846
				// (get) Token: 0x0600FEC7 RID: 65223 RVA: 0x003C9B78 File Offset: 0x003C7D78
				// (set) Token: 0x0600FEC8 RID: 65224 RVA: 0x00078BAE File Offset: 0x00076DAE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D87 RID: 19847
				// (get) Token: 0x0600FEC9 RID: 65225 RVA: 0x003C9BA8 File Offset: 0x003C7DA8
				// (set) Token: 0x0600FECA RID: 65226 RVA: 0x00078BCD File Offset: 0x00076DCD
				public unsafe Botanist.__c__DisplayClass68_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist.__c__DisplayClass68_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Botanist.__c__DisplayClass68_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400ABAB RID: 43947
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400ABAC RID: 43948
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400ABAD RID: 43949
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400ABAE RID: 43950
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400ABAF RID: 43951
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABB0 RID: 43952
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400ABB1 RID: 43953
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400ABB2 RID: 43954
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400ABB3 RID: 43955
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
