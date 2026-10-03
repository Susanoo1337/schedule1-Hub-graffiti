using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005B8 RID: 1464
	public class Pot : GrowContainer
	{
		// Token: 0x06008C63 RID: 35939 RVA: 0x00262608 File Offset: 0x00260808
		// Note: this type is marked as 'beforefieldinit'.
		static Pot()
		{
			Il2CppClassPointerStore<Pot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Pot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot>.NativeClassPtr);
			Pot.NativeFieldInfoPtr_MaxWarmthGrowthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "MaxWarmthGrowthMultiplier");
			Pot.NativeFieldInfoPtr_WarmthMinThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WarmthMinThreshold");
			Pot.NativeFieldInfoPtr_WarmthMaxThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WarmthMaxThreshold");
			Pot.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "RotationSpeed");
			Pot.NativeFieldInfoPtr_ModelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ModelTransform");
			Pot.NativeFieldInfoPtr_SeedStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedStartPoint");
			Pot.NativeFieldInfoPtr_SeedRestingPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SeedRestingPoint");
			Pot.NativeFieldInfoPtr_LookAtPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LookAtPoint");
			Pot.NativeFieldInfoPtr_PlantContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PlantContainer");
			Pot.NativeFieldInfoPtr_TaskBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "TaskBounds");
			Pot.NativeFieldInfoPtr_LeafDropPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "LeafDropPoint");
			Pot.NativeFieldInfoPtr_PoofParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofParticles");
			Pot.NativeFieldInfoPtr_PoofSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PoofSound");
			Pot.NativeFieldInfoPtr_ConfigurationReplicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "ConfigurationReplicator");
			Pot.NativeFieldInfoPtr_Dirt_Flat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Flat");
			Pot.NativeFieldInfoPtr_Dirt_Parted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "Dirt_Parted");
			Pot.NativeFieldInfoPtr_SoilChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "SoilChunks");
			Pot.NativeFieldInfoPtr_WorldspaceUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "WorldspaceUIPrefab");
			Pot.NativeFieldInfoPtr_typeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "typeIcon");
			Pot.NativeFieldInfoPtr_PotRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "PotRadius");
			Pot.NativeFieldInfoPtr_YieldMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "YieldMultiplier");
			Pot.NativeFieldInfoPtr_GrowSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "GrowSpeedMultiplier");
			Pot.NativeFieldInfoPtr__Plant_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<Plant>k__BackingField");
			Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<potConfiguration>k__BackingField");
			Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<WorldspaceUI>k__BackingField");
			Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotation");
			Pot.NativeFieldInfoPtr_rotationOverridden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "rotationOverridden");
			Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "syncVar___<CurrentPlayerConfigurer>k__BackingField");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.PotAssembly-CSharp.dll_Excuted");
			Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681436);
			Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681437);
			Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681438);
			Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681439);
			Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681440);
			Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681441);
			Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681442);
			Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681443);
			Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681444);
			Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681445);
			Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681446);
			Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681447);
			Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681448);
			Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681449);
			Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681450);
			Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681451);
			Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681452);
			Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681453);
			Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681454);
			Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681455);
			Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681456);
			Pot.NativeMethodInfoPtr_GetManagementName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681457);
			Pot.NativeMethodInfoPtr_GetDefaultManagementName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681458);
			Pot.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681459);
			Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681460);
			Pot.NativeMethodInfoPtr_UpdateRotation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681461);
			Pot.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681462);
			Pot.NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681463);
			Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681464);
			Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681465);
			Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681466);
			Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681467);
			Pot.NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_AdditiveDefinition_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681468);
			Pot.NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_Boolean_AdditiveDefinition_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681469);
			Pot.NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Virtual_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681470);
			Pot.NativeMethodInfoPtr_SetGrowableVisible_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681471);
			Pot.NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681472);
			Pot.NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681473);
			Pot.NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681474);
			Pot.NativeMethodInfoPtr_ContainsGrowable_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681475);
			Pot.NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681476);
			Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681477);
			Pot.NativeMethodInfoPtr_PlantSeed_Server_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681478);
			Pot.NativeMethodInfoPtr_PlantSeed_Client_Private_Void_NetworkConnection_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681479);
			Pot.NativeMethodInfoPtr_SetGrowthProgress_Server_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681480);
			Pot.NativeMethodInfoPtr_SetGrowthProgress_Client_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681481);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Server_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681482);
			Pot.NativeMethodInfoPtr_SetHarvestableActive_Client_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681483);
			Pot.NativeMethodInfoPtr_OnPlantFullyHarvested_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681484);
			Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681485);
			Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681486);
			Pot.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681487);
			Pot.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681488);
			Pot.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681489);
			Pot.NativeMethodInfoPtr_LoadPlant_Private_Void_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681490);
			Pot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681491);
			Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681492);
			Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681493);
			Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681494);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681495);
			Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681496);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681497);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_PlantSeed_Server_606697822_Private_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681498);
			Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_Server_606697822_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681499);
			Pot.NativeMethodInfoPtr_RpcReader___Server_PlantSeed_Server_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681500);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681501);
			Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681502);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681503);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681504);
			Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681505);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetGrowthProgress_Server_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681506);
			Pot.NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Server_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681507);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetGrowthProgress_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681508);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthProgress_Client_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681509);
			Pot.NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Client_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681510);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowthProgress_Client_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681511);
			Pot.NativeMethodInfoPtr_RpcWriter___Server_SetHarvestableActive_Server_3658436649_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681512);
			Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Server_3658436649_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681513);
			Pot.NativeMethodInfoPtr_RpcReader___Server_SetHarvestableActive_Server_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681514);
			Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681515);
			Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681516);
			Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681517);
			Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681518);
			Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681519);
			Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681520);
			Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681521);
			Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681522);
			Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot>.NativeClassPtr, 100681523);
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008C64 RID: 35940 RVA: 0x00262F84 File Offset: 0x00261184
		// (set) Token: 0x06008C65 RID: 35941 RVA: 0x00262FC4 File Offset: 0x002611C4
		public unsafe Plant Plant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Plant_Public_get_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259644, XrefRangeEnd = 259645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008C66 RID: 35942 RVA: 0x00263008 File Offset: 0x00261208
		public unsafe virtual EntityConfiguration Configuration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 253801, RefRangeEnd = 253823, XrefRangeStart = 253801, XrefRangeEnd = 253823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityConfiguration>(intPtr3) : null;
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008C67 RID: 35943 RVA: 0x00263048 File Offset: 0x00261248
		// (set) Token: 0x06008C68 RID: 35944 RVA: 0x00263088 File Offset: 0x00261288
		public unsafe PotConfiguration potConfiguration
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 253801, RefRangeEnd = 253823, XrefRangeStart = 253801, XrefRangeEnd = 253823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008C69 RID: 35945 RVA: 0x002630CC File Offset: 0x002612CC
		public unsafe virtual ConfigurationReplicator ConfigReplicator
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 178039, RefRangeEnd = 178044, XrefRangeStart = 178039, XrefRangeEnd = 178044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06008C6A RID: 35946 RVA: 0x0026310C File Offset: 0x0026130C
		public unsafe virtual EConfigurableType ConfigurableType
		{
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 31078, RefRangeEnd = 31151, XrefRangeStart = 31078, XrefRangeEnd = 31151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06008C6B RID: 35947 RVA: 0x00263148 File Offset: 0x00261348
		// (set) Token: 0x06008C6C RID: 35948 RVA: 0x00263188 File Offset: 0x00261388
		public unsafe virtual WorldspaceUIElement WorldspaceUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06008C6D RID: 35949 RVA: 0x002631CC File Offset: 0x002613CC
		// (set) Token: 0x06008C6E RID: 35950 RVA: 0x0026320C File Offset: 0x0026140C
		public unsafe virtual NetworkObject CurrentPlayerConfigurer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 259653, RefRangeEnd = 259655, XrefRangeStart = 259645, XrefRangeEnd = 259653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x00263250 File Offset: 0x00261450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259655, XrefRangeEnd = 259677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetConfigurer(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06008C70 RID: 35952 RVA: 0x00263294 File Offset: 0x00261494
		public unsafe virtual Sprite TypeIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06008C71 RID: 35953 RVA: 0x002632D4 File Offset: 0x002614D4
		public unsafe virtual Transform Transform
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 44652, RefRangeEnd = 44654, XrefRangeStart = 44652, XrefRangeEnd = 44654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002BB1 RID: 11185
		// (get) Token: 0x06008C72 RID: 35954 RVA: 0x00263314 File Offset: 0x00261514
		public unsafe virtual Transform UIPoint
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 228649, RefRangeEnd = 228651, XrefRangeStart = 228649, XrefRangeEnd = 228651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002BB2 RID: 11186
		// (get) Token: 0x06008C73 RID: 35955 RVA: 0x00263354 File Offset: 0x00261554
		public unsafe virtual bool CanBeSelected
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008C74 RID: 35956 RVA: 0x00263390 File Offset: 0x00261590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259677, XrefRangeEnd = 259679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C75 RID: 35957 RVA: 0x002633CC File Offset: 0x002615CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259679, XrefRangeEnd = 259686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C76 RID: 35958 RVA: 0x00263408 File Offset: 0x00261608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259686, XrefRangeEnd = 259716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C77 RID: 35959 RVA: 0x00263458 File Offset: 0x00261658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259716, XrefRangeEnd = 259733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendConfigurationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C78 RID: 35960 RVA: 0x0026349C File Offset: 0x0026169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259733, XrefRangeEnd = 259742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C79 RID: 35961 RVA: 0x0026352C File Offset: 0x0026172C
		[CallerCount(0)]
		public unsafe override string GetManagementName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetManagementName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008C7A RID: 35962 RVA: 0x00263570 File Offset: 0x00261770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259742, XrefRangeEnd = 259743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDefaultManagementName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetDefaultManagementName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008C7B RID: 35963 RVA: 0x002635B4 File Offset: 0x002617B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259743, XrefRangeEnd = 259750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7C RID: 35964 RVA: 0x002635F0 File Offset: 0x002617F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259750, XrefRangeEnd = 259761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7D RID: 35965 RVA: 0x0026362C File Offset: 0x0026182C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_UpdateRotation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7E RID: 35966 RVA: 0x00263660 File Offset: 0x00261860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259761, XrefRangeEnd = 259766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C7F RID: 35967 RVA: 0x0026369C File Offset: 0x0026189C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259766, XrefRangeEnd = 259774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTimeSkipped(int minsSkipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSkipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C80 RID: 35968 RVA: 0x002636E8 File Offset: 0x002618E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259784, RefRangeEnd = 259785, XrefRangeStart = 259774, XrefRangeEnd = 259784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAcceptSeed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C81 RID: 35969 RVA: 0x00263740 File Offset: 0x00261940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259785, XrefRangeEnd = 259799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyForHarvest(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C82 RID: 35970 RVA: 0x00263798 File Offset: 0x00261998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259799, XrefRangeEnd = 259815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C83 RID: 35971 RVA: 0x002637FC File Offset: 0x002619FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259815, RefRangeEnd = 259816, XrefRangeStart = 259815, XrefRangeEnd = 259815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideRotation(float angle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x0026383C File Offset: 0x00261A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259816, XrefRangeEnd = 259826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInitialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_AdditiveDefinition_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr3) : null;
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x002638A8 File Offset: 0x00261AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259826, XrefRangeEnd = 259840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additiveDef);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_Boolean_AdditiveDefinition_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x0026391C File Offset: 0x00261B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259840, XrefRangeEnd = 259847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPointAboveGrowSurface(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Virtual_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00263970 File Offset: 0x00261B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259847, XrefRangeEnd = 259852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetGrowableVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_SetGrowableVisible_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C88 RID: 35976 RVA: 0x002639BC File Offset: 0x00261BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259852, XrefRangeEnd = 259856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Vector3 GetRandomPourTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x00263A04 File Offset: 0x00261C04
		[CallerCount(0)]
		public unsafe override float GetGrowSurfaceSideLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00263A4C File Offset: 0x00261C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 252576, RefRangeEnd = 252577, XrefRangeStart = 252576, XrefRangeEnd = 252577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetTemperatureGrowthMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00263A94 File Offset: 0x00261C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259856, XrefRangeEnd = 259860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ContainsGrowable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ContainsGrowable_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x00263ADC File Offset: 0x00261CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259860, XrefRangeEnd = 259864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetGrowthProgressNormalized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x00263B24 File Offset: 0x00261D24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259872, RefRangeEnd = 259877, XrefRangeStart = 259864, XrefRangeEnd = 259872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilState(Pot.ESoilState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00263B64 File Offset: 0x00261D64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259899, RefRangeEnd = 259901, XrefRangeStart = 259877, XrefRangeEnd = 259899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed_Server(string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Server_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x00263BB4 File Offset: 0x00261DB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259942, RefRangeEnd = 259947, XrefRangeStart = 259901, XrefRangeEnd = 259942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlantSeed_Client(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_PlantSeed_Client_Private_Void_NetworkConnection_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00263C18 File Offset: 0x00261E18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259957, RefRangeEnd = 259958, XrefRangeStart = 259947, XrefRangeEnd = 259957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowthProgress_Server(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetGrowthProgress_Server_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00263C58 File Offset: 0x00261E58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259968, RefRangeEnd = 259971, XrefRangeStart = 259958, XrefRangeEnd = 259968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowthProgress_Client(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetGrowthProgress_Client_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x00263C98 File Offset: 0x00261E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259994, RefRangeEnd = 259997, XrefRangeStart = 259971, XrefRangeEnd = 259994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive_Server(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Server_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x00263CE4 File Offset: 0x00261EE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 260040, RefRangeEnd = 260044, XrefRangeStart = 259997, XrefRangeEnd = 260040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHarvestableActive_Client(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_SetHarvestableActive_Client_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C94 RID: 35988 RVA: 0x00263D44 File Offset: 0x00261F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260044, XrefRangeEnd = 260070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlantFullyHarvested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_OnPlantFullyHarvested_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C95 RID: 35989 RVA: 0x00263D78 File Offset: 0x00261F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260097, RefRangeEnd = 260098, XrefRangeStart = 260070, XrefRangeEnd = 260097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WorldspaceUIElement CreateWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr3) : null;
		}

		// Token: 0x06008C96 RID: 35990 RVA: 0x00263DB8 File Offset: 0x00261FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260098, XrefRangeEnd = 260102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyWorldspaceUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C97 RID: 35991 RVA: 0x00263DEC File Offset: 0x00261FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260102, XrefRangeEnd = 260138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06008C98 RID: 35992 RVA: 0x00263E38 File Offset: 0x00262038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260138, XrefRangeEnd = 260142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DynamicSaveData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DynamicSaveData>(intPtr3) : null;
		}

		// Token: 0x06008C99 RID: 35993 RVA: 0x00263E84 File Offset: 0x00262084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260142, XrefRangeEnd = 260156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(PotData potData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(potData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PotData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9A RID: 35994 RVA: 0x00263ED4 File Offset: 0x002620D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260156, XrefRangeEnd = 260169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadPlant(PlantData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_LoadPlant_Private_Void_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9B RID: 35995 RVA: 0x00263F18 File Offset: 0x00262118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260169, XrefRangeEnd = 260170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Pot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9C RID: 35996 RVA: 0x00263F54 File Offset: 0x00262154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260170, XrefRangeEnd = 260243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9D RID: 35997 RVA: 0x00263F90 File Offset: 0x00262190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260243, XrefRangeEnd = 260244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x00263FCC File Offset: 0x002621CC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x00264008 File Offset: 0x00262208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260244, XrefRangeEnd = 260254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x0026404C File Offset: 0x0026224C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259653, RefRangeEnd = 259655, XrefRangeStart = 259653, XrefRangeEnd = 259655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA1 RID: 36001 RVA: 0x00264090 File Offset: 0x00262290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260254, XrefRangeEnd = 260258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA2 RID: 36002 RVA: 0x002640F4 File Offset: 0x002622F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260258, XrefRangeEnd = 260269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_PlantSeed_Server_606697822_Private_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA3 RID: 36003 RVA: 0x00264144 File Offset: 0x00262344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260269, XrefRangeEnd = 260270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlantSeed_Server_606697822(string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_Server_606697822_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA4 RID: 36004 RVA: 0x00264194 File Offset: 0x00262394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260270, XrefRangeEnd = 260275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_PlantSeed_Server_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_PlantSeed_Server_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x002641F8 File Offset: 0x002623F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260275, XrefRangeEnd = 260286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x0026425C File Offset: 0x0026245C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260362, RefRangeEnd = 260365, XrefRangeStart = 260286, XrefRangeEnd = 260362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x002642C0 File Offset: 0x002624C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260365, XrefRangeEnd = 260370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00264310 File Offset: 0x00262510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260370, XrefRangeEnd = 260381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_PlantSeed_Client_4077118173(NetworkConnection conn, string seedID, float normalizedSeedProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalizedSeedProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CA9 RID: 36009 RVA: 0x00264374 File Offset: 0x00262574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260381, XrefRangeEnd = 260386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_PlantSeed_Client_4077118173(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAA RID: 36010 RVA: 0x002643C4 File Offset: 0x002625C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259957, RefRangeEnd = 259958, XrefRangeStart = 259957, XrefRangeEnd = 259958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetGrowthProgress_Server_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetGrowthProgress_Server_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00264404 File Offset: 0x00262604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260386, XrefRangeEnd = 260387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowthProgress_Server_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Server_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00264444 File Offset: 0x00262644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260387, XrefRangeEnd = 260390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetGrowthProgress_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetGrowthProgress_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x002644A8 File Offset: 0x002626A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 259968, RefRangeEnd = 259971, XrefRangeStart = 259968, XrefRangeEnd = 259971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGrowthProgress_Client_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthProgress_Client_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x002644E8 File Offset: 0x002626E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260390, XrefRangeEnd = 260401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowthProgress_Client_431000436(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Client_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00264528 File Offset: 0x00262728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260401, XrefRangeEnd = 260409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGrowthProgress_Client_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetGrowthProgress_Client_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x00264578 File Offset: 0x00262778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260409, XrefRangeEnd = 260421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Server_SetHarvestableActive_Server_3658436649_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x002645C4 File Offset: 0x002627C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260421, XrefRangeEnd = 260422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHarvestableActive_Server_3658436649(int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Server_3658436649_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB2 RID: 36018 RVA: 0x00264610 File Offset: 0x00262810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260422, XrefRangeEnd = 260427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetHarvestableActive_Server_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Server_SetHarvestableActive_Server_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00264674 File Offset: 0x00262874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260427, XrefRangeEnd = 260439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x002646D4 File Offset: 0x002628D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260451, RefRangeEnd = 260454, XrefRangeStart = 260439, XrefRangeEnd = 260451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00264734 File Offset: 0x00262934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260454, XrefRangeEnd = 260459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB6 RID: 36022 RVA: 0x00264784 File Offset: 0x00262984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260459, XrefRangeEnd = 260471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetHarvestableActive_Client_338960014(NetworkConnection conn, int harvestableIndex, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref harvestableIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x002647E4 File Offset: 0x002629E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260471, XrefRangeEnd = 260476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetHarvestableActive_Client_338960014(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002BB3 RID: 11187
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x00264834 File Offset: 0x00262A34
		// (set) Token: 0x06008CB9 RID: 36025 RVA: 0x00264874 File Offset: 0x00262A74
		public unsafe NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260476, XrefRangeEnd = 260485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x002648C4 File Offset: 0x00262AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260485, XrefRangeEnd = 260486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_ObjectScripts_Pot(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00264938 File Offset: 0x00262B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260486, XrefRangeEnd = 260488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Pot.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x000426FA File Offset: 0x000408FA
		public Pot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x00264974 File Offset: 0x00262B74
		// (set) Token: 0x06008CBE RID: 36030 RVA: 0x00042703 File Offset: 0x00040903
		public unsafe static float MaxWarmthGrowthMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_MaxWarmthGrowthMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_MaxWarmthGrowthMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x00264990 File Offset: 0x00262B90
		// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x00042711 File Offset: 0x00040911
		public unsafe static float WarmthMinThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_WarmthMinThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_WarmthMinThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x002649AC File Offset: 0x00262BAC
		// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x0004271F File Offset: 0x0004091F
		public unsafe static float WarmthMaxThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_WarmthMaxThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_WarmthMaxThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06008CC3 RID: 36035 RVA: 0x002649C8 File Offset: 0x00262BC8
		// (set) Token: 0x06008CC4 RID: 36036 RVA: 0x0004272D File Offset: 0x0004092D
		public unsafe static float RotationSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Pot.NativeFieldInfoPtr_RotationSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Pot.NativeFieldInfoPtr_RotationSpeed, (void*)(&value));
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x002649E4 File Offset: 0x00262BE4
		// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x0004273B File Offset: 0x0004093B
		public unsafe Transform ModelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ModelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x00264A14 File Offset: 0x00262C14
		// (set) Token: 0x06008CC8 RID: 36040 RVA: 0x0004275A File Offset: 0x0004095A
		public unsafe Transform SeedStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06008CC9 RID: 36041 RVA: 0x00264A44 File Offset: 0x00262C44
		// (set) Token: 0x06008CCA RID: 36042 RVA: 0x00042779 File Offset: 0x00040979
		public unsafe Transform SeedRestingPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SeedRestingPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x00264A74 File Offset: 0x00262C74
		// (set) Token: 0x06008CCC RID: 36044 RVA: 0x00042798 File Offset: 0x00040998
		public unsafe Transform LookAtPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LookAtPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x00264AA4 File Offset: 0x00262CA4
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x000427B7 File Offset: 0x000409B7
		public unsafe Transform PlantContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PlantContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06008CCF RID: 36047 RVA: 0x00264AD4 File Offset: 0x00262CD4
		// (set) Token: 0x06008CD0 RID: 36048 RVA: 0x000427D6 File Offset: 0x000409D6
		public unsafe Transform TaskBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_TaskBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x00264B04 File Offset: 0x00262D04
		// (set) Token: 0x06008CD2 RID: 36050 RVA: 0x000427F5 File Offset: 0x000409F5
		public unsafe Transform LeafDropPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_LeafDropPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x00264B34 File Offset: 0x00262D34
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x00042814 File Offset: 0x00040A14
		public unsafe ParticleSystem PoofParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x00264B64 File Offset: 0x00262D64
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x00042833 File Offset: 0x00040A33
		public unsafe AudioSourceController PoofSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PoofSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x00264B94 File Offset: 0x00262D94
		// (set) Token: 0x06008CD8 RID: 36056 RVA: 0x00042852 File Offset: 0x00040A52
		public unsafe ConfigurationReplicator ConfigurationReplicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ConfigurationReplicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_ConfigurationReplicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x00264BC4 File Offset: 0x00262DC4
		// (set) Token: 0x06008CDA RID: 36058 RVA: 0x00042871 File Offset: 0x00040A71
		public unsafe Transform Dirt_Flat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Flat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06008CDB RID: 36059 RVA: 0x00264BF4 File Offset: 0x00262DF4
		// (set) Token: 0x06008CDC RID: 36060 RVA: 0x00042890 File Offset: 0x00040A90
		public unsafe Transform Dirt_Parted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_Dirt_Parted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x00264C24 File Offset: 0x00262E24
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x000428AF File Offset: 0x00040AAF
		public unsafe Il2CppReferenceArray<SoilChunk> SoilChunks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoilChunk>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_SoilChunks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x00264C54 File Offset: 0x00262E54
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x000428CE File Offset: 0x00040ACE
		public unsafe PotUIElement WorldspaceUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_WorldspaceUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x00264C84 File Offset: 0x00262E84
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x000428ED File Offset: 0x00040AED
		public unsafe Sprite typeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_typeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B9C RID: 11164
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x00264CB4 File Offset: 0x00262EB4
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x0004290C File Offset: 0x00040B0C
		public unsafe float PotRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_PotRadius)) = value;
			}
		}

		// Token: 0x17002B9D RID: 11165
		// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x00264CDC File Offset: 0x00262EDC
		// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x00042927 File Offset: 0x00040B27
		public unsafe float YieldMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_YieldMultiplier)) = value;
			}
		}

		// Token: 0x17002B9E RID: 11166
		// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x00264D04 File Offset: 0x00262F04
		// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x00042942 File Offset: 0x00040B42
		public unsafe float GrowSpeedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_GrowSpeedMultiplier)) = value;
			}
		}

		// Token: 0x17002B9F RID: 11167
		// (get) Token: 0x06008CE9 RID: 36073 RVA: 0x00264D2C File Offset: 0x00262F2C
		// (set) Token: 0x06008CEA RID: 36074 RVA: 0x0004295D File Offset: 0x00040B5D
		public unsafe Plant _Plant_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Plant>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__Plant_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA0 RID: 11168
		// (get) Token: 0x06008CEB RID: 36075 RVA: 0x00264D5C File Offset: 0x00262F5C
		// (set) Token: 0x06008CEC RID: 36076 RVA: 0x0004297C File Offset: 0x00040B7C
		public unsafe PotConfiguration _potConfiguration_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotConfiguration>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__potConfiguration_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA1 RID: 11169
		// (get) Token: 0x06008CED RID: 36077 RVA: 0x00264D8C File Offset: 0x00262F8C
		// (set) Token: 0x06008CEE RID: 36078 RVA: 0x0004299B File Offset: 0x00040B9B
		public unsafe WorldspaceUIElement _WorldspaceUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceUIElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__WorldspaceUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA2 RID: 11170
		// (get) Token: 0x06008CEF RID: 36079 RVA: 0x00264DBC File Offset: 0x00262FBC
		// (set) Token: 0x06008CF0 RID: 36080 RVA: 0x000429BA File Offset: 0x00040BBA
		public unsafe NetworkObject _CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA3 RID: 11171
		// (get) Token: 0x06008CF1 RID: 36081 RVA: 0x00264DEC File Offset: 0x00262FEC
		// (set) Token: 0x06008CF2 RID: 36082 RVA: 0x000429D9 File Offset: 0x00040BD9
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17002BA4 RID: 11172
		// (get) Token: 0x06008CF3 RID: 36083 RVA: 0x00264E14 File Offset: 0x00263014
		// (set) Token: 0x06008CF4 RID: 36084 RVA: 0x000429F4 File Offset: 0x00040BF4
		public unsafe bool rotationOverridden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_rotationOverridden)) = value;
			}
		}

		// Token: 0x17002BA5 RID: 11173
		// (get) Token: 0x06008CF5 RID: 36085 RVA: 0x00264E3C File Offset: 0x0026303C
		// (set) Token: 0x06008CF6 RID: 36086 RVA: 0x00042A0F File Offset: 0x00040C0F
		public unsafe SyncVar<NetworkObject> syncVar____CurrentPlayerConfigurer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA6 RID: 11174
		// (get) Token: 0x06008CF7 RID: 36087 RVA: 0x00264E6C File Offset: 0x0026306C
		// (set) Token: 0x06008CF8 RID: 36088 RVA: 0x00042A2E File Offset: 0x00040C2E
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008CF9 RID: 36089 RVA: 0x00264E94 File Offset: 0x00263094
		// (set) Token: 0x06008CFA RID: 36090 RVA: 0x00042A49 File Offset: 0x00040C49
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006040 RID: 24640
		private static readonly IntPtr NativeFieldInfoPtr_MaxWarmthGrowthMultiplier;

		// Token: 0x04006041 RID: 24641
		private static readonly IntPtr NativeFieldInfoPtr_WarmthMinThreshold;

		// Token: 0x04006042 RID: 24642
		private static readonly IntPtr NativeFieldInfoPtr_WarmthMaxThreshold;

		// Token: 0x04006043 RID: 24643
		private static readonly IntPtr NativeFieldInfoPtr_RotationSpeed;

		// Token: 0x04006044 RID: 24644
		private static readonly IntPtr NativeFieldInfoPtr_ModelTransform;

		// Token: 0x04006045 RID: 24645
		private static readonly IntPtr NativeFieldInfoPtr_SeedStartPoint;

		// Token: 0x04006046 RID: 24646
		private static readonly IntPtr NativeFieldInfoPtr_SeedRestingPoint;

		// Token: 0x04006047 RID: 24647
		private static readonly IntPtr NativeFieldInfoPtr_LookAtPoint;

		// Token: 0x04006048 RID: 24648
		private static readonly IntPtr NativeFieldInfoPtr_PlantContainer;

		// Token: 0x04006049 RID: 24649
		private static readonly IntPtr NativeFieldInfoPtr_TaskBounds;

		// Token: 0x0400604A RID: 24650
		private static readonly IntPtr NativeFieldInfoPtr_LeafDropPoint;

		// Token: 0x0400604B RID: 24651
		private static readonly IntPtr NativeFieldInfoPtr_PoofParticles;

		// Token: 0x0400604C RID: 24652
		private static readonly IntPtr NativeFieldInfoPtr_PoofSound;

		// Token: 0x0400604D RID: 24653
		private static readonly IntPtr NativeFieldInfoPtr_ConfigurationReplicator;

		// Token: 0x0400604E RID: 24654
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Flat;

		// Token: 0x0400604F RID: 24655
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Parted;

		// Token: 0x04006050 RID: 24656
		private static readonly IntPtr NativeFieldInfoPtr_SoilChunks;

		// Token: 0x04006051 RID: 24657
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUIPrefab;

		// Token: 0x04006052 RID: 24658
		private static readonly IntPtr NativeFieldInfoPtr_typeIcon;

		// Token: 0x04006053 RID: 24659
		private static readonly IntPtr NativeFieldInfoPtr_PotRadius;

		// Token: 0x04006054 RID: 24660
		private static readonly IntPtr NativeFieldInfoPtr_YieldMultiplier;

		// Token: 0x04006055 RID: 24661
		private static readonly IntPtr NativeFieldInfoPtr_GrowSpeedMultiplier;

		// Token: 0x04006056 RID: 24662
		private static readonly IntPtr NativeFieldInfoPtr__Plant_k__BackingField;

		// Token: 0x04006057 RID: 24663
		private static readonly IntPtr NativeFieldInfoPtr__potConfiguration_k__BackingField;

		// Token: 0x04006058 RID: 24664
		private static readonly IntPtr NativeFieldInfoPtr__WorldspaceUI_k__BackingField;

		// Token: 0x04006059 RID: 24665
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400605A RID: 24666
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400605B RID: 24667
		private static readonly IntPtr NativeFieldInfoPtr_rotationOverridden;

		// Token: 0x0400605C RID: 24668
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPlayerConfigurer_k__BackingField;

		// Token: 0x0400605D RID: 24669
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400605E RID: 24670
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400605F RID: 24671
		private static readonly IntPtr NativeMethodInfoPtr_get_Plant_Public_get_Plant_0;

		// Token: 0x04006060 RID: 24672
		private static readonly IntPtr NativeMethodInfoPtr_set_Plant_Protected_set_Void_Plant_0;

		// Token: 0x04006061 RID: 24673
		private static readonly IntPtr NativeMethodInfoPtr_get_Configuration_Public_Virtual_Final_New_get_EntityConfiguration_0;

		// Token: 0x04006062 RID: 24674
		private static readonly IntPtr NativeMethodInfoPtr_get_potConfiguration_Protected_get_PotConfiguration_0;

		// Token: 0x04006063 RID: 24675
		private static readonly IntPtr NativeMethodInfoPtr_set_potConfiguration_Protected_set_Void_PotConfiguration_0;

		// Token: 0x04006064 RID: 24676
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigReplicator_Public_Virtual_Final_New_get_ConfigurationReplicator_0;

		// Token: 0x04006065 RID: 24677
		private static readonly IntPtr NativeMethodInfoPtr_get_ConfigurableType_Public_Virtual_Final_New_get_EConfigurableType_0;

		// Token: 0x04006066 RID: 24678
		private static readonly IntPtr NativeMethodInfoPtr_get_WorldspaceUI_Public_Virtual_Final_New_get_WorldspaceUIElement_0;

		// Token: 0x04006067 RID: 24679
		private static readonly IntPtr NativeMethodInfoPtr_set_WorldspaceUI_Public_Virtual_Final_New_set_Void_WorldspaceUIElement_0;

		// Token: 0x04006068 RID: 24680
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPlayerConfigurer_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04006069 RID: 24681
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPlayerConfigurer_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x0400606A RID: 24682
		private static readonly IntPtr NativeMethodInfoPtr_SetConfigurer_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400606B RID: 24683
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeIcon_Public_Virtual_Final_New_get_Sprite_0;

		// Token: 0x0400606C RID: 24684
		private static readonly IntPtr NativeMethodInfoPtr_get_Transform_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400606D RID: 24685
		private static readonly IntPtr NativeMethodInfoPtr_get_UIPoint_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x0400606E RID: 24686
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400606F RID: 24687
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006070 RID: 24688
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04006071 RID: 24689
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006072 RID: 24690
		private static readonly IntPtr NativeMethodInfoPtr_SendConfigurationToClient_Public_Virtual_Final_New_Void_NetworkConnection_0;

		// Token: 0x04006073 RID: 24691
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04006074 RID: 24692
		private static readonly IntPtr NativeMethodInfoPtr_GetManagementName_Public_Virtual_String_0;

		// Token: 0x04006075 RID: 24693
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultManagementName_Public_Virtual_String_0;

		// Token: 0x04006076 RID: 24694
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1;

		// Token: 0x04006077 RID: 24695
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04006078 RID: 24696
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Private_Void_0;

		// Token: 0x04006079 RID: 24697
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_Void_1;

		// Token: 0x0400607A RID: 24698
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_Void_Int32_0;

		// Token: 0x0400607B RID: 24699
		private static readonly IntPtr NativeMethodInfoPtr_CanAcceptSeed_Public_Boolean_byref_String_0;

		// Token: 0x0400607C RID: 24700
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyForHarvest_Public_Boolean_byref_String_0;

		// Token: 0x0400607D RID: 24701
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x0400607E RID: 24702
		private static readonly IntPtr NativeMethodInfoPtr_OverrideRotation_Public_Void_Single_0;

		// Token: 0x0400607F RID: 24703
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_AdditiveDefinition_String_Boolean_0;

		// Token: 0x04006080 RID: 24704
		private static readonly IntPtr NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_Boolean_AdditiveDefinition_byref_String_0;

		// Token: 0x04006081 RID: 24705
		private static readonly IntPtr NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Virtual_Boolean_Vector3_0;

		// Token: 0x04006082 RID: 24706
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowableVisible_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006083 RID: 24707
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Virtual_Vector3_0;

		// Token: 0x04006084 RID: 24708
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Virtual_Single_0;

		// Token: 0x04006085 RID: 24709
		private static readonly IntPtr NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_Single_0;

		// Token: 0x04006086 RID: 24710
		private static readonly IntPtr NativeMethodInfoPtr_ContainsGrowable_Public_Virtual_Boolean_0;

		// Token: 0x04006087 RID: 24711
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Virtual_Single_0;

		// Token: 0x04006088 RID: 24712
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilState_Public_Void_ESoilState_0;

		// Token: 0x04006089 RID: 24713
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Server_Public_Void_String_Single_0;

		// Token: 0x0400608A RID: 24714
		private static readonly IntPtr NativeMethodInfoPtr_PlantSeed_Client_Private_Void_NetworkConnection_String_Single_0;

		// Token: 0x0400608B RID: 24715
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowthProgress_Server_Public_Void_Single_0;

		// Token: 0x0400608C RID: 24716
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowthProgress_Client_Private_Void_Single_0;

		// Token: 0x0400608D RID: 24717
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Server_Public_Void_Int32_Boolean_0;

		// Token: 0x0400608E RID: 24718
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Client_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x0400608F RID: 24719
		private static readonly IntPtr NativeMethodInfoPtr_OnPlantFullyHarvested_Private_Void_0;

		// Token: 0x04006090 RID: 24720
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceUI_Public_Virtual_Final_New_WorldspaceUIElement_0;

		// Token: 0x04006091 RID: 24721
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceUI_Public_Virtual_Final_New_Void_0;

		// Token: 0x04006092 RID: 24722
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04006093 RID: 24723
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_DynamicSaveData_0;

		// Token: 0x04006094 RID: 24724
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_PotData_0;

		// Token: 0x04006095 RID: 24725
		private static readonly IntPtr NativeMethodInfoPtr_LoadPlant_Private_Void_PlantData_0;

		// Token: 0x04006096 RID: 24726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006097 RID: 24727
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006098 RID: 24728
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006099 RID: 24729
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400609A RID: 24730
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetConfigurer_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400609B RID: 24731
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetConfigurer_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400609C RID: 24732
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetConfigurer_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400609D RID: 24733
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_PlantSeed_Server_606697822_Private_Void_String_Single_0;

		// Token: 0x0400609E RID: 24734
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlantSeed_Server_606697822_Public_Void_String_Single_0;

		// Token: 0x0400609F RID: 24735
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_PlantSeed_Server_606697822_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040060A0 RID: 24736
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0;

		// Token: 0x040060A1 RID: 24737
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0;

		// Token: 0x040060A2 RID: 24738
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0;

		// Token: 0x040060A3 RID: 24739
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_PlantSeed_Client_4077118173_Private_Void_NetworkConnection_String_Single_0;

		// Token: 0x040060A4 RID: 24740
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_PlantSeed_Client_4077118173_Private_Void_PooledReader_Channel_0;

		// Token: 0x040060A5 RID: 24741
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetGrowthProgress_Server_431000436_Private_Void_Single_0;

		// Token: 0x040060A6 RID: 24742
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Server_431000436_Public_Void_Single_0;

		// Token: 0x040060A7 RID: 24743
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetGrowthProgress_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040060A8 RID: 24744
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthProgress_Client_431000436_Private_Void_Single_0;

		// Token: 0x040060A9 RID: 24745
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowthProgress_Client_431000436_Private_Void_Single_0;

		// Token: 0x040060AA RID: 24746
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGrowthProgress_Client_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x040060AB RID: 24747
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetHarvestableActive_Server_3658436649_Private_Void_Int32_Boolean_0;

		// Token: 0x040060AC RID: 24748
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Server_3658436649_Public_Void_Int32_Boolean_0;

		// Token: 0x040060AD RID: 24749
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetHarvestableActive_Server_3658436649_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040060AE RID: 24750
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040060AF RID: 24751
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040060B0 RID: 24752
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x040060B1 RID: 24753
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetHarvestableActive_Client_338960014_Private_Void_NetworkConnection_Int32_Boolean_0;

		// Token: 0x040060B2 RID: 24754
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetHarvestableActive_Client_338960014_Private_Void_PooledReader_Channel_0;

		// Token: 0x040060B3 RID: 24755
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPlayerConfigurer_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x040060B4 RID: 24756
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPlayerConfigurer_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x040060B5 RID: 24757
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_ObjectScripts_Pot_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040060B6 RID: 24758
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C0E RID: 3086
		[OriginalName("Assembly-CSharp.dll", "", "ESoilState")]
		public enum ESoilState
		{
			// Token: 0x0400A0FE RID: 41214
			Flat,
			// Token: 0x0400A0FF RID: 41215
			Parted,
			// Token: 0x0400A100 RID: 41216
			Packed
		}

		// Token: 0x02000C0F RID: 3087
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EDBE RID: 60862 RVA: 0x00398B2C File Offset: 0x00396D2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Pot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr);
				Pot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9");
				Pot.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, "<>9__91_0");
				Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100681525);
				Pot.__c.NativeMethodInfoPtr__GetBaseData_b__91_0_Internal_String_AdditiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr, 100681526);
			}

			// Token: 0x0600EDBF RID: 60863 RVA: 0x00398BA8 File Offset: 0x00396DA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDC0 RID: 60864 RVA: 0x00398BE4 File Offset: 0x00396DE4
			[CallerCount(0)]
			public unsafe string _GetBaseData_b__91_0(AdditiveDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c.NativeMethodInfoPtr__GetBaseData_b__91_0_Internal_String_AdditiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EDC1 RID: 60865 RVA: 0x00070325 File Offset: 0x0006E525
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700480F RID: 18447
			// (get) Token: 0x0600EDC2 RID: 60866 RVA: 0x00398C2C File Offset: 0x00396E2C
			// (set) Token: 0x0600EDC3 RID: 60867 RVA: 0x0007032E File Offset: 0x0006E52E
			public unsafe static Pot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004810 RID: 18448
			// (get) Token: 0x0600EDC4 RID: 60868 RVA: 0x00398C54 File Offset: 0x00396E54
			// (set) Token: 0x0600EDC5 RID: 60869 RVA: 0x00070340 File Offset: 0x0006E540
			public unsafe static Converter<AdditiveDefinition, string> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Pot.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<AdditiveDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Pot.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A101 RID: 41217
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A102 RID: 41218
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x0400A103 RID: 41219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A104 RID: 41220
			private static readonly IntPtr NativeMethodInfoPtr__GetBaseData_b__91_0_Internal_String_AdditiveDefinition_0;
		}

		// Token: 0x02000C10 RID: 3088
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass59_0")]
		public sealed class __c__DisplayClass59_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EDC6 RID: 60870 RVA: 0x00398C7C File Offset: 0x00396E7C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass59_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass59_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr);
				Pot.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass59_0.NativeFieldInfoPtr_conn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, "conn");
				Pot.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, 100681527);
				Pot.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, 100681528);
				Pot.__c__DisplayClass59_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, 100681529);
			}

			// Token: 0x0600EDC7 RID: 60871 RVA: 0x00398D0C File Offset: 0x00396F0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass59_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDC8 RID: 60872 RVA: 0x00398D48 File Offset: 0x00396F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259579, XrefRangeEnd = 259584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EDC9 RID: 60873 RVA: 0x00398D88 File Offset: 0x00396F88
			[CallerCount(0)]
			public unsafe bool _SendConfigurationToClient_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDCA RID: 60874 RVA: 0x00070352 File Offset: 0x0006E552
			public __c__DisplayClass59_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004811 RID: 18449
			// (get) Token: 0x0600EDCB RID: 60875 RVA: 0x00398DC4 File Offset: 0x00396FC4
			// (set) Token: 0x0600EDCC RID: 60876 RVA: 0x0007035B File Offset: 0x0006E55B
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004812 RID: 18450
			// (get) Token: 0x0600EDCD RID: 60877 RVA: 0x00398DF4 File Offset: 0x00396FF4
			// (set) Token: 0x0600EDCE RID: 60878 RVA: 0x0007037A File Offset: 0x0006E57A
			public unsafe NetworkConnection conn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.NativeFieldInfoPtr_conn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.NativeFieldInfoPtr_conn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A105 RID: 41221
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A106 RID: 41222
			private static readonly IntPtr NativeFieldInfoPtr_conn;

			// Token: 0x0400A107 RID: 41223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A108 RID: 41224
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A109 RID: 41225
			private static readonly IntPtr NativeMethodInfoPtr__SendConfigurationToClient_b__1_Internal_Boolean_0;

			// Token: 0x02000DF6 RID: 3574
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass59_0+<<SendConfigurationToClient>g__WaitForConfig|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601019A RID: 65946 RVA: 0x003D27D4 File Offset: 0x003D09D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0>.NativeClassPtr, "<<SendConfigurationToClient>g__WaitForConfig|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681530);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681531);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681532);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681533);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681534);
					Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681535);
				}

				// Token: 0x0601019B RID: 65947 RVA: 0x003D28B4 File Offset: 0x003D0AB4
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601019C RID: 65948 RVA: 0x003D28FC File Offset: 0x003D0AFC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601019D RID: 65949 RVA: 0x003D2930 File Offset: 0x003D0B30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259563, XrefRangeEnd = 259574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E93 RID: 20115
				// (get) Token: 0x0601019E RID: 65950 RVA: 0x003D296C File Offset: 0x003D0B6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601019F RID: 65951 RVA: 0x003D29AC File Offset: 0x003D0BAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259574, XrefRangeEnd = 259579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E94 RID: 20116
				// (get) Token: 0x060101A0 RID: 65952 RVA: 0x003D29E0 File Offset: 0x003D0BE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101A1 RID: 65953 RVA: 0x0007A156 File Offset: 0x00078356
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E90 RID: 20112
				// (get) Token: 0x060101A2 RID: 65954 RVA: 0x003D2A20 File Offset: 0x003D0C20
				// (set) Token: 0x060101A3 RID: 65955 RVA: 0x0007A15F File Offset: 0x0007835F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E91 RID: 20113
				// (get) Token: 0x060101A4 RID: 65956 RVA: 0x003D2A48 File Offset: 0x003D0C48
				// (set) Token: 0x060101A5 RID: 65957 RVA: 0x0007A17A File Offset: 0x0007837A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E92 RID: 20114
				// (get) Token: 0x060101A6 RID: 65958 RVA: 0x003D2A78 File Offset: 0x003D0C78
				// (set) Token: 0x060101A7 RID: 65959 RVA: 0x0007A199 File Offset: 0x00078399
				public unsafe Pot.__c__DisplayClass59_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass59_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass59_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AD76 RID: 44406
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AD77 RID: 44407
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD78 RID: 44408
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD79 RID: 44409
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD7A RID: 44410
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD7B RID: 44411
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD7C RID: 44412
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD7D RID: 44413
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD7E RID: 44414
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C11 RID: 3089
		[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EDCF RID: 60879 RVA: 0x00398E24 File Offset: 0x00397024
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr);
				Pot.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				Pot.__c__DisplayClass94_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, "data");
				Pot.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, 100681536);
				Pot.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, 100681537);
				Pot.__c__DisplayClass94_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, 100681538);
			}

			// Token: 0x0600EDD0 RID: 60880 RVA: 0x00398EB4 File Offset: 0x003970B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EDD1 RID: 60881 RVA: 0x00398EF0 File Offset: 0x003970F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259637, XrefRangeEnd = 259642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EDD2 RID: 60882 RVA: 0x00398F30 File Offset: 0x00397130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259642, XrefRangeEnd = 259644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadPlant_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EDD3 RID: 60883 RVA: 0x00070399 File Offset: 0x0006E599
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004813 RID: 18451
			// (get) Token: 0x0600EDD4 RID: 60884 RVA: 0x00398F6C File Offset: 0x0039716C
			// (set) Token: 0x0600EDD5 RID: 60885 RVA: 0x000703A2 File Offset: 0x0006E5A2
			public unsafe Pot __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004814 RID: 18452
			// (get) Token: 0x0600EDD6 RID: 60886 RVA: 0x00398F9C File Offset: 0x0039719C
			// (set) Token: 0x0600EDD7 RID: 60887 RVA: 0x000703C1 File Offset: 0x0006E5C1
			public unsafe PlantData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A10A RID: 41226
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A10B RID: 41227
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400A10C RID: 41228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A10D RID: 41229
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400A10E RID: 41230
			private static readonly IntPtr NativeMethodInfoPtr__LoadPlant_b__1_Internal_Boolean_0;

			// Token: 0x02000DF7 RID: 3575
			[ObfuscatedName("ScheduleOne.ObjectScripts.Pot+<>c__DisplayClass94_0+<<LoadPlant>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060101A8 RID: 65960 RVA: 0x003D2AA8 File Offset: 0x003D0CA8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0>.NativeClassPtr, "<<LoadPlant>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681539);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681540);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681541);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681542);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681543);
					Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681544);
				}

				// Token: 0x060101A9 RID: 65961 RVA: 0x003D2B88 File Offset: 0x003D0D88
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101AA RID: 65962 RVA: 0x003D2BD0 File Offset: 0x003D0DD0
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060101AB RID: 65963 RVA: 0x003D2C04 File Offset: 0x003D0E04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259584, XrefRangeEnd = 259632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004E98 RID: 20120
				// (get) Token: 0x060101AC RID: 65964 RVA: 0x003D2C40 File Offset: 0x003D0E40
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101AD RID: 65965 RVA: 0x003D2C80 File Offset: 0x003D0E80
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259632, XrefRangeEnd = 259637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004E99 RID: 20121
				// (get) Token: 0x060101AE RID: 65966 RVA: 0x003D2CB4 File Offset: 0x003D0EB4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060101AF RID: 65967 RVA: 0x0007A1B8 File Offset: 0x000783B8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004E95 RID: 20117
				// (get) Token: 0x060101B0 RID: 65968 RVA: 0x003D2CF4 File Offset: 0x003D0EF4
				// (set) Token: 0x060101B1 RID: 65969 RVA: 0x0007A1C1 File Offset: 0x000783C1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004E96 RID: 20118
				// (get) Token: 0x060101B2 RID: 65970 RVA: 0x003D2D1C File Offset: 0x003D0F1C
				// (set) Token: 0x060101B3 RID: 65971 RVA: 0x0007A1DC File Offset: 0x000783DC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004E97 RID: 20119
				// (get) Token: 0x060101B4 RID: 65972 RVA: 0x003D2D4C File Offset: 0x003D0F4C
				// (set) Token: 0x060101B5 RID: 65973 RVA: 0x0007A1FB File Offset: 0x000783FB
				public unsafe Pot.__c__DisplayClass94_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Pot.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AD7F RID: 44415
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AD80 RID: 44416
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AD81 RID: 44417
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AD82 RID: 44418
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AD83 RID: 44419
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD84 RID: 44420
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AD85 RID: 44421
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AD86 RID: 44422
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AD87 RID: 44423
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
