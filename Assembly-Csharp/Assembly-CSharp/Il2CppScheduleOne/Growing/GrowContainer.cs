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
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000512 RID: 1298
	public class GrowContainer : GridItem
	{
		// Token: 0x06007504 RID: 29956 RVA: 0x0020ABB8 File Offset: 0x00208DB8
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainer()
		{
			Il2CppClassPointerStore<GrowContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "GrowContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr);
			GrowContainer.NativeFieldInfoPtr_DryThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "DryThreshold");
			GrowContainer.NativeFieldInfoPtr__SoilCapacity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<SoilCapacity>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__MoistureCapacity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<MoistureCapacity>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__HidePlantDuringPourTasks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<HidePlantDuringPourTasks>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__moistureDrainPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_moistureDrainPerHour");
			GrowContainer.NativeFieldInfoPtr_AllowedSoils = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "AllowedSoils");
			GrowContainer.NativeFieldInfoPtr_AllowedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "AllowedAdditives");
			GrowContainer.NativeFieldInfoPtr__interactionHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_interactionHandler");
			GrowContainer.NativeFieldInfoPtr__soilMeshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_soilMeshRenderers");
			GrowContainer.NativeFieldInfoPtr__SoilContainer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<SoilContainer>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__soilMinTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_soilMinTransform");
			GrowContainer.NativeFieldInfoPtr__soilMaxTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_soilMaxTransform");
			GrowContainer.NativeFieldInfoPtr__additiveDisplayTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_additiveDisplayTemplate");
			GrowContainer.NativeFieldInfoPtr__PourableStartPoint_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<PourableStartPoint>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__SurfaceCover_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<SurfaceCover>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__CameraHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<CameraHandler>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<TemperatureDisplay>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__pourTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_pourTarget");
			GrowContainer.NativeFieldInfoPtr__uiPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_uiPoint");
			GrowContainer.NativeFieldInfoPtr__accessPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_accessPoints");
			GrowContainer.NativeFieldInfoPtr__soilClearedParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_soilClearedParticles");
			GrowContainer.NativeFieldInfoPtr__soilClearedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_soilClearedSound");
			GrowContainer.NativeFieldInfoPtr__lightSourceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_lightSourceOverride");
			GrowContainer.NativeFieldInfoPtr__CurrentSoil_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<CurrentSoil>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__AppliedAdditives_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<AppliedAdditives>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<NPCUserObject>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<PlayerUserObject>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__InputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<InputSlots>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__OutputSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<OutputSlots>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__Selectable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<Selectable>k__BackingField");
			GrowContainer.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<IsAcceptingItems>k__BackingField");
			GrowContainer.NativeFieldInfoPtr_onMinPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "onMinPass");
			GrowContainer.NativeFieldInfoPtr_onTimeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "onTimeSkip");
			GrowContainer.NativeFieldInfoPtr__currentSoilAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_currentSoilAmount");
			GrowContainer.NativeFieldInfoPtr__currentMoistureAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_currentMoistureAmount");
			GrowContainer.NativeFieldInfoPtr__remainingSoilUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_remainingSoilUses");
			GrowContainer.NativeFieldInfoPtr__activeAdditiveDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "_activeAdditiveDisplays");
			GrowContainer.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "syncVar___<NPCUserObject>k__BackingField");
			GrowContainer.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "syncVar___<PlayerUserObject>k__BackingField");
			GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted");
			GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Growing.GrowContainerAssembly-CSharp.dll_Excuted");
			GrowContainer.NativeMethodInfoPtr_get_SoilCapacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678340);
			GrowContainer.NativeMethodInfoPtr_set_SoilCapacity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678341);
			GrowContainer.NativeMethodInfoPtr_get_MoistureCapacity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678342);
			GrowContainer.NativeMethodInfoPtr_set_MoistureCapacity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678343);
			GrowContainer.NativeMethodInfoPtr_get_HidePlantDuringPourTasks_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678344);
			GrowContainer.NativeMethodInfoPtr_set_HidePlantDuringPourTasks_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678345);
			GrowContainer.NativeMethodInfoPtr_get_SoilContainer_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678346);
			GrowContainer.NativeMethodInfoPtr_set_SoilContainer_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678347);
			GrowContainer.NativeMethodInfoPtr_get_PourableStartPoint_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678348);
			GrowContainer.NativeMethodInfoPtr_set_PourableStartPoint_Private_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678349);
			GrowContainer.NativeMethodInfoPtr_get_SurfaceCover_Public_get_GrowContainerSurfaceCover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678350);
			GrowContainer.NativeMethodInfoPtr_set_SurfaceCover_Private_set_Void_GrowContainerSurfaceCover_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678351);
			GrowContainer.NativeMethodInfoPtr_get_CameraHandler_Public_get_GrowContainerCameraHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678352);
			GrowContainer.NativeMethodInfoPtr_set_CameraHandler_Private_set_Void_GrowContainerCameraHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678353);
			GrowContainer.NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678354);
			GrowContainer.NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678355);
			GrowContainer.NativeMethodInfoPtr_get_NormalizedSoilAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678356);
			GrowContainer.NativeMethodInfoPtr_get_IsFullyFilledWithSoil_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678357);
			GrowContainer.NativeMethodInfoPtr_get_NormalizedMoistureAmount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678358);
			GrowContainer.NativeMethodInfoPtr_get_CurrentSoil_Public_get_SoilDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678359);
			GrowContainer.NativeMethodInfoPtr_set_CurrentSoil_Private_set_Void_SoilDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678360);
			GrowContainer.NativeMethodInfoPtr_get_AppliedAdditives_Public_get_List_1_AdditiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678361);
			GrowContainer.NativeMethodInfoPtr_set_AppliedAdditives_Private_set_Void_List_1_AdditiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678362);
			GrowContainer.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678363);
			GrowContainer.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678364);
			GrowContainer.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678365);
			GrowContainer.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678366);
			GrowContainer.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678367);
			GrowContainer.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678368);
			GrowContainer.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678369);
			GrowContainer.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678370);
			GrowContainer.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678371);
			GrowContainer.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678372);
			GrowContainer.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678373);
			GrowContainer.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678374);
			GrowContainer.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678375);
			GrowContainer.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678376);
			GrowContainer.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678377);
			GrowContainer.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678378);
			GrowContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678379);
			GrowContainer.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678380);
			GrowContainer.NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678381);
			GrowContainer.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678382);
			GrowContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678383);
			GrowContainer.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678384);
			GrowContainer.NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678385);
			GrowContainer.NativeMethodInfoPtr_DrainMoisture_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678386);
			GrowContainer.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678387);
			GrowContainer.NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Abstract_Virtual_New_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678388);
			GrowContainer.NativeMethodInfoPtr_SetGrowableVisible_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678389);
			GrowContainer.NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678390);
			GrowContainer.NativeMethodInfoPtr_ContainsGrowable_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678391);
			GrowContainer.NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Abstract_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678392);
			GrowContainer.NativeMethodInfoPtr_SetSoil_Public_Virtual_New_Void_SoilDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678393);
			GrowContainer.NativeMethodInfoPtr_ChangeSoilAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678394);
			GrowContainer.NativeMethodInfoPtr_SetSoilAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678395);
			GrowContainer.NativeMethodInfoPtr_SetRemainingSoilUses_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678396);
			GrowContainer.NativeMethodInfoPtr_SyncSoilData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678397);
			GrowContainer.NativeMethodInfoPtr_SetSoilData_Server_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678398);
			GrowContainer.NativeMethodInfoPtr_SetSoilData_Client_Private_Void_NetworkConnection_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678399);
			GrowContainer.NativeMethodInfoPtr_RefreshSoilVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678400);
			GrowContainer.NativeMethodInfoPtr_ClearSoil_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678401);
			GrowContainer.NativeMethodInfoPtr_IsSoilAllowed_Public_Boolean_SoilDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678402);
			GrowContainer.NativeMethodInfoPtr_GetSoilMaterial_Protected_Virtual_New_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678403);
			GrowContainer.NativeMethodInfoPtr_ChangeMoistureAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678404);
			GrowContainer.NativeMethodInfoPtr_SetMoistureAmount_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678405);
			GrowContainer.NativeMethodInfoPtr_SyncMoistureData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678406);
			GrowContainer.NativeMethodInfoPtr_SetMoistureData_Server_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678407);
			GrowContainer.NativeMethodInfoPtr_SetMoistureData_Client_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678408);
			GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Server_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678409);
			GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Client_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678410);
			GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_New_AdditiveDefinition_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678411);
			GrowContainer.NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678412);
			GrowContainer.NativeMethodInfoPtr_IsAdditiveApplied_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678413);
			GrowContainer.NativeMethodInfoPtr_ClearAdditives_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678414);
			GrowContainer.NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_New_Boolean_AdditiveDefinition_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678415);
			GrowContainer.NativeMethodInfoPtr_SetPourTargetActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678416);
			GrowContainer.NativeMethodInfoPtr_RandomizePourTargetPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678417);
			GrowContainer.NativeMethodInfoPtr_GetCurrentTargetPosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678418);
			GrowContainer.NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Abstract_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678419);
			GrowContainer.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678420);
			GrowContainer.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678421);
			GrowContainer.NativeMethodInfoPtr_Load_Protected_Void_GrowContainerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678422);
			GrowContainer.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678423);
			GrowContainer.NativeMethodInfoPtr__InitializeGridItem_b__99_0_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678424);
			GrowContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678425);
			GrowContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678426);
			GrowContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678427);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678428);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678429);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetSoilData_Server_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678430);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678431);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678432);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678433);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678434);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Target_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678435);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetMoistureData_Server_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678436);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetMoistureData_Server_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678437);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetMoistureData_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678438);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678439);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678440);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678441);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678442);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Target_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678443);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_ApplyAdditive_Server_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678444);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Server_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678445);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Server_ApplyAdditive_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678446);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678447);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678448);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678449);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678450);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678451);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678452);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678453);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678454);
			GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678455);
			GrowContainer.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678456);
			GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678457);
			GrowContainer.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678458);
			GrowContainer.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678459);
			GrowContainer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Growing_GrowContainer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678460);
			GrowContainer.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678461);
			GrowContainer.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678462);
			GrowContainer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, 100678463);
		}

		// Token: 0x1700244D RID: 9293
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x0020B8CC File Offset: 0x00209ACC
		// (set) Token: 0x06007506 RID: 29958 RVA: 0x0020B908 File Offset: 0x00209B08
		public unsafe float SoilCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_SoilCapacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_SoilCapacity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700244E RID: 9294
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x0020B948 File Offset: 0x00209B48
		// (set) Token: 0x06007508 RID: 29960 RVA: 0x0020B984 File Offset: 0x00209B84
		public unsafe float MoistureCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_MoistureCapacity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_MoistureCapacity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700244F RID: 9295
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x0020B9C4 File Offset: 0x00209BC4
		// (set) Token: 0x0600750A RID: 29962 RVA: 0x0020BA00 File Offset: 0x00209C00
		public unsafe bool HidePlantDuringPourTasks
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_HidePlantDuringPourTasks_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_HidePlantDuringPourTasks_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002450 RID: 9296
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x0020BA40 File Offset: 0x00209C40
		// (set) Token: 0x0600750C RID: 29964 RVA: 0x0020BA80 File Offset: 0x00209C80
		public unsafe Transform SoilContainer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_SoilContainer_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_SoilContainer_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002451 RID: 9297
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x0020BAC4 File Offset: 0x00209CC4
		// (set) Token: 0x0600750E RID: 29966 RVA: 0x0020BB04 File Offset: 0x00209D04
		public unsafe Transform PourableStartPoint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_PourableStartPoint_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228600, XrefRangeEnd = 228601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_PourableStartPoint_Private_set_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002452 RID: 9298
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x0020BB48 File Offset: 0x00209D48
		// (set) Token: 0x06007510 RID: 29968 RVA: 0x0020BB88 File Offset: 0x00209D88
		public unsafe GrowContainerSurfaceCover SurfaceCover
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 153813, RefRangeEnd = 153814, XrefRangeStart = 153813, XrefRangeEnd = 153814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_SurfaceCover_Public_get_GrowContainerSurfaceCover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_SurfaceCover_Private_set_Void_GrowContainerSurfaceCover_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002453 RID: 9299
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x0020BBCC File Offset: 0x00209DCC
		// (set) Token: 0x06007512 RID: 29970 RVA: 0x0020BC0C File Offset: 0x00209E0C
		public unsafe GrowContainerCameraHandler CameraHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_CameraHandler_Public_get_GrowContainerCameraHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GrowContainerCameraHandler>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_CameraHandler_Private_set_Void_GrowContainerCameraHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002454 RID: 9300
		// (get) Token: 0x06007513 RID: 29971 RVA: 0x0020BC50 File Offset: 0x00209E50
		// (set) Token: 0x06007514 RID: 29972 RVA: 0x0020BC90 File Offset: 0x00209E90
		public unsafe TemperatureDisplay TemperatureDisplay
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 111889, RefRangeEnd = 111907, XrefRangeStart = 111889, XrefRangeEnd = 111907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TemperatureDisplay>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228601, XrefRangeEnd = 228602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002455 RID: 9301
		// (get) Token: 0x06007515 RID: 29973 RVA: 0x0020BCD4 File Offset: 0x00209ED4
		public unsafe float NormalizedSoilAmount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 228602, RefRangeEnd = 228604, XrefRangeStart = 228602, XrefRangeEnd = 228602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_NormalizedSoilAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002456 RID: 9302
		// (get) Token: 0x06007516 RID: 29974 RVA: 0x0020BD10 File Offset: 0x00209F10
		public unsafe bool IsFullyFilledWithSoil
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 228605, RefRangeEnd = 228617, XrefRangeStart = 228604, XrefRangeEnd = 228605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_IsFullyFilledWithSoil_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002457 RID: 9303
		// (get) Token: 0x06007517 RID: 29975 RVA: 0x0020BD4C File Offset: 0x00209F4C
		public unsafe float NormalizedMoistureAmount
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 228617, RefRangeEnd = 228630, XrefRangeStart = 228617, XrefRangeEnd = 228617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_NormalizedMoistureAmount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002458 RID: 9304
		// (get) Token: 0x06007518 RID: 29976 RVA: 0x0020BD88 File Offset: 0x00209F88
		// (set) Token: 0x06007519 RID: 29977 RVA: 0x0020BDC8 File Offset: 0x00209FC8
		public unsafe SoilDefinition CurrentSoil
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 153845, RefRangeEnd = 153859, XrefRangeStart = 153845, XrefRangeEnd = 153859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_CurrentSoil_Public_get_SoilDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_CurrentSoil_Private_set_Void_SoilDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002459 RID: 9305
		// (get) Token: 0x0600751A RID: 29978 RVA: 0x0020BE0C File Offset: 0x0020A00C
		// (set) Token: 0x0600751B RID: 29979 RVA: 0x0020BE4C File Offset: 0x0020A04C
		public unsafe List<AdditiveDefinition> AppliedAdditives
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_AppliedAdditives_Public_get_List_1_AdditiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AdditiveDefinition>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_AppliedAdditives_Private_set_Void_List_1_AdditiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x0600751C RID: 29980 RVA: 0x0020BE90 File Offset: 0x0020A090
		// (set) Token: 0x0600751D RID: 29981 RVA: 0x0020BED0 File Offset: 0x0020A0D0
		public unsafe virtual NetworkObject NPCUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 228638, RefRangeEnd = 228640, XrefRangeStart = 228630, XrefRangeEnd = 228638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x0600751E RID: 29982 RVA: 0x0020BF14 File Offset: 0x0020A114
		// (set) Token: 0x0600751F RID: 29983 RVA: 0x0020BF54 File Offset: 0x0020A154
		public unsafe virtual NetworkObject PlayerUserObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228640, XrefRangeEnd = 228648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x06007520 RID: 29984 RVA: 0x0020BF98 File Offset: 0x0020A198
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228648, XrefRangeEnd = 228649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x06007521 RID: 29985 RVA: 0x0020BFD0 File Offset: 0x0020A1D0
		// (set) Token: 0x06007522 RID: 29986 RVA: 0x0020C010 File Offset: 0x0020A210
		public unsafe virtual List<ItemSlot> InputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x06007523 RID: 29987 RVA: 0x0020C054 File Offset: 0x0020A254
		// (set) Token: 0x06007524 RID: 29988 RVA: 0x0020C094 File Offset: 0x0020A294
		public unsafe virtual List<ItemSlot> OutputSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x0020C0D8 File Offset: 0x0020A2D8
		public unsafe virtual Transform LinkOrigin
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 228649, RefRangeEnd = 228651, XrefRangeStart = 228649, XrefRangeEnd = 228649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x06007526 RID: 29990 RVA: 0x0020C118 File Offset: 0x0020A318
		public unsafe virtual Il2CppReferenceArray<Transform> AccessPoints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr3) : null;
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x0020C158 File Offset: 0x0020A358
		public unsafe virtual bool Selectable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x06007528 RID: 29992 RVA: 0x0020C194 File Offset: 0x0020A394
		// (set) Token: 0x06007529 RID: 29993 RVA: 0x0020C1D0 File Offset: 0x0020A3D0
		public unsafe virtual bool IsAcceptingItems
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x0020C210 File Offset: 0x0020A410
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 228654, RefRangeEnd = 228659, XrefRangeStart = 228651, XrefRangeEnd = 228654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactionState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x0020C260 File Offset: 0x0020A460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228659, XrefRangeEnd = 228662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, Vector3 labelPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(labelText);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interactionState;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x0020C2C0 File Offset: 0x0020A4C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228668, RefRangeEnd = 228671, XrefRangeStart = 228662, XrefRangeEnd = 228668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x0020C2FC File Offset: 0x0020A4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228732, RefRangeEnd = 228734, XrefRangeStart = 228671, XrefRangeEnd = 228732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x0020C38C File Offset: 0x0020A58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228734, XrefRangeEnd = 228739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HeatmapVisibilityChanged(Property property, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x0020C3DC File Offset: 0x0020A5DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228786, RefRangeEnd = 228788, XrefRangeStart = 228739, XrefRangeEnd = 228786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x0020C418 File Offset: 0x0020A618
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228812, RefRangeEnd = 228814, XrefRangeStart = 228788, XrefRangeEnd = 228812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x0020C468 File Offset: 0x0020A668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228819, RefRangeEnd = 228820, XrefRangeStart = 228814, XrefRangeEnd = 228819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0020C4A4 File Offset: 0x0020A6A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228821, RefRangeEnd = 228822, XrefRangeStart = 228820, XrefRangeEnd = 228821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTimeSkipped(int minsSkipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsSkipped;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0020C4F0 File Offset: 0x0020A6F0
		[CallerCount(0)]
		public unsafe void DrainMoisture(int minutes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minutes;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_DrainMoisture_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0020C530 File Offset: 0x0020A730
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228833, RefRangeEnd = 228834, XrefRangeStart = 228822, XrefRangeEnd = 228833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAverageLightExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x0020C57C File Offset: 0x0020A77C
		[CallerCount(0)]
		public unsafe virtual bool IsPointAboveGrowSurface(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Abstract_Virtual_New_Boolean_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x0020C5D0 File Offset: 0x0020A7D0
		[CallerCount(0)]
		public unsafe virtual void SetGrowableVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_SetGrowableVisible_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x0020C61C File Offset: 0x0020A81C
		[CallerCount(0)]
		public unsafe virtual float GetGrowSurfaceSideLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0020C664 File Offset: 0x0020A864
		[CallerCount(0)]
		public unsafe virtual bool ContainsGrowable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_ContainsGrowable_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x0020C6AC File Offset: 0x0020A8AC
		[CallerCount(0)]
		public unsafe virtual float GetGrowthProgressNormalized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Abstract_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x0020C6F4 File Offset: 0x0020A8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228835, RefRangeEnd = 228836, XrefRangeStart = 228834, XrefRangeEnd = 228835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSoil(SoilDefinition soil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(soil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_SetSoil_Public_Virtual_New_Void_SoilDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x0020C744 File Offset: 0x0020A944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228837, RefRangeEnd = 228838, XrefRangeStart = 228836, XrefRangeEnd = 228837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeSoilAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ChangeSoilAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x0020C784 File Offset: 0x0020A984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228838, RefRangeEnd = 228839, XrefRangeStart = 228838, XrefRangeEnd = 228838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetSoilAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x0020C7C4 File Offset: 0x0020A9C4
		[CallerCount(0)]
		public unsafe void SetRemainingSoilUses(int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetRemainingSoilUses_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x0020C804 File Offset: 0x0020AA04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228869, RefRangeEnd = 228871, XrefRangeStart = 228839, XrefRangeEnd = 228869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncSoilData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SyncSoilData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x0020C838 File Offset: 0x0020AA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228871, XrefRangeEnd = 228884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilData_Server(string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetSoilData_Server_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x0020C898 File Offset: 0x0020AA98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228918, RefRangeEnd = 228921, XrefRangeStart = 228884, XrefRangeEnd = 228918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilData_Client(NetworkConnection conn, string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetSoilData_Client_Private_Void_NetworkConnection_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x0020C908 File Offset: 0x0020AB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228921, XrefRangeEnd = 228933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshSoilVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_RefreshSoilVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x0020C944 File Offset: 0x0020AB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228938, RefRangeEnd = 228939, XrefRangeStart = 228933, XrefRangeEnd = 228938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_ClearSoil_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x0020C980 File Offset: 0x0020AB80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228945, RefRangeEnd = 228946, XrefRangeStart = 228939, XrefRangeEnd = 228945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSoilAllowed(SoilDefinition soil)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(soil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_IsSoilAllowed_Public_Boolean_SoilDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x0020C9D0 File Offset: 0x0020ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228946, XrefRangeEnd = 228950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Material GetSoilMaterial()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_GetSoilMaterial_Protected_Virtual_New_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x0020CA1C File Offset: 0x0020AC1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 228950, RefRangeEnd = 228953, XrefRangeStart = 228950, XrefRangeEnd = 228950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeMoistureAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ChangeMoistureAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x0020CA5C File Offset: 0x0020AC5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228953, RefRangeEnd = 228954, XrefRangeStart = 228953, XrefRangeEnd = 228953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetMoistureAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_SetMoistureAmount_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x0020CAA8 File Offset: 0x0020ACA8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 228964, RefRangeEnd = 228968, XrefRangeStart = 228954, XrefRangeEnd = 228964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncMoistureData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SyncMoistureData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x0020CADC File Offset: 0x0020ACDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228968, XrefRangeEnd = 228978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoistureData_Server(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetMoistureData_Server_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x0020CB1C File Offset: 0x0020AD1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229009, RefRangeEnd = 229012, XrefRangeStart = 228978, XrefRangeEnd = 229009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMoistureData_Client(NetworkConnection conn, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetMoistureData_Client_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x0020CB6C File Offset: 0x0020AD6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229033, RefRangeEnd = 229035, XrefRangeStart = 229012, XrefRangeEnd = 229033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAdditive_Server(string additiveID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Server_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x0020CBB0 File Offset: 0x0020ADB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 229075, RefRangeEnd = 229080, XrefRangeStart = 229035, XrefRangeEnd = 229075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyAdditive_Client(NetworkConnection conn, string additiveID, bool initialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Client_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x0020CC14 File Offset: 0x0020AE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229111, RefRangeEnd = 229113, XrefRangeStart = 229080, XrefRangeEnd = 229111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInitialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_New_AdditiveDefinition_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdditiveDefinition>(intPtr3) : null;
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x0020CC80 File Offset: 0x0020AE80
		[CallerCount(0)]
		public unsafe virtual float GetTemperatureGrowthMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0020CCC8 File Offset: 0x0020AEC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 229132, RefRangeEnd = 229135, XrefRangeStart = 229113, XrefRangeEnd = 229132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAdditiveApplied(string additiveID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_IsAdditiveApplied_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0020CD18 File Offset: 0x0020AF18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229158, RefRangeEnd = 229160, XrefRangeStart = 229135, XrefRangeEnd = 229158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAdditives()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_ClearAdditives_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0020CD4C File Offset: 0x0020AF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229171, RefRangeEnd = 229173, XrefRangeStart = 229160, XrefRangeEnd = 229171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanApplyAdditive(AdditiveDefinition additiveDef, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additiveDef);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_New_Boolean_AdditiveDefinition_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x0020CDC0 File Offset: 0x0020AFC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 229176, RefRangeEnd = 229184, XrefRangeStart = 229173, XrefRangeEnd = 229176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPourTargetActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetPourTargetActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x0020CE00 File Offset: 0x0020B000
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 229191, RefRangeEnd = 229197, XrefRangeStart = 229184, XrefRangeEnd = 229191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizePourTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RandomizePourTargetPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x0020CE34 File Offset: 0x0020B034
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 229198, RefRangeEnd = 229202, XrefRangeStart = 229197, XrefRangeEnd = 229198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetCurrentTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_GetCurrentTargetPosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x0020CE70 File Offset: 0x0020B070
		[CallerCount(0)]
		public unsafe virtual Vector3 GetRandomPourTargetPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Abstract_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x0020CEB8 File Offset: 0x0020B0B8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 229224, RefRangeEnd = 229236, XrefRangeStart = 229202, XrefRangeEnd = 229224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerUser(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x0020CEFC File Offset: 0x0020B0FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229258, RefRangeEnd = 229260, XrefRangeStart = 229236, XrefRangeEnd = 229258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNPCUser(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x0020CF40 File Offset: 0x0020B140
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229268, RefRangeEnd = 229270, XrefRangeStart = 229260, XrefRangeEnd = 229268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(GrowContainerData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_Load_Protected_Void_GrowContainerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x0020CF84 File Offset: 0x0020B184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229297, RefRangeEnd = 229299, XrefRangeStart = 229270, XrefRangeEnd = 229297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x0020CFC0 File Offset: 0x0020B1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229299, XrefRangeEnd = 229300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _InitializeGridItem_b__99_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr__InitializeGridItem_b__99_0_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x0020CFFC File Offset: 0x0020B1FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229392, RefRangeEnd = 229394, XrefRangeStart = 229300, XrefRangeEnd = 229392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x0020D038 File Offset: 0x0020B238
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229395, RefRangeEnd = 229397, XrefRangeStart = 229394, XrefRangeEnd = 229395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x0020D074 File Offset: 0x0020B274
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x0020D0B0 File Offset: 0x0020B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x0020D110 File Offset: 0x0020B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229397, XrefRangeEnd = 229398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSoilData_Server_3104499779(string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x0020D170 File Offset: 0x0020B370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229398, XrefRangeEnd = 229404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSoilData_Server_3104499779(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetSoilData_Server_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x0020D1D4 File Offset: 0x0020B3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229404, XrefRangeEnd = 229417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x0020D244 File Offset: 0x0020B444
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229420, RefRangeEnd = 229422, XrefRangeStart = 229417, XrefRangeEnd = 229420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x0020D2B4 File Offset: 0x0020B4B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229422, XrefRangeEnd = 229428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x0020D304 File Offset: 0x0020B504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229428, XrefRangeEnd = 229441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSoilData_Client_433593356(NetworkConnection conn, string soilID, float amount, int uses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uses;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x0020D374 File Offset: 0x0020B574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229441, XrefRangeEnd = 229448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSoilData_Client_433593356(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Target_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x0020D3C4 File Offset: 0x0020B5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetMoistureData_Server_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetMoistureData_Server_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x0020D404 File Offset: 0x0020B604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229448, XrefRangeEnd = 229449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMoistureData_Server_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetMoistureData_Server_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x0020D444 File Offset: 0x0020B644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229449, XrefRangeEnd = 229452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetMoistureData_Server_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetMoistureData_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x0020D4A8 File Offset: 0x0020B6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229452, XrefRangeEnd = 229462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x0020D4F8 File Offset: 0x0020B6F8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x0020D548 File Offset: 0x0020B748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229462, XrefRangeEnd = 229464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x0020D598 File Offset: 0x0020B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229464, XrefRangeEnd = 229474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetMoistureData_Client_530160725(NetworkConnection conn, float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x0020D5E8 File Offset: 0x0020B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229474, XrefRangeEnd = 229477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetMoistureData_Client_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Target_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x0020D638 File Offset: 0x0020B838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229477, XrefRangeEnd = 229487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ApplyAdditive_Server_3615296227(string additiveID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_ApplyAdditive_Server_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x0020D67C File Offset: 0x0020B87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229487, XrefRangeEnd = 229488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplyAdditive_Server_3615296227(string additiveID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Server_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x0020D6C0 File Offset: 0x0020B8C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229488, XrefRangeEnd = 229492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ApplyAdditive_Server_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Server_ApplyAdditive_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x0020D724 File Offset: 0x0020B924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229492, XrefRangeEnd = 229503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x0020D788 File Offset: 0x0020B988
		[CallerCount(0)]
		public unsafe void RpcLogic___ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x0020D7EC File Offset: 0x0020B9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229503, XrefRangeEnd = 229506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x0020D83C File Offset: 0x0020BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229506, XrefRangeEnd = 229517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ApplyAdditive_Client_619441887(NetworkConnection conn, string additiveID, bool initialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(additiveID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x0020D8A0 File Offset: 0x0020BAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229517, XrefRangeEnd = 229520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ApplyAdditive_Client_619441887(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x0020D8F0 File Offset: 0x0020BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229520, XrefRangeEnd = 229530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x0020D934 File Offset: 0x0020BB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 229554, RefRangeEnd = 229556, XrefRangeStart = 229530, XrefRangeEnd = 229554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x0020D978 File Offset: 0x0020BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229556, XrefRangeEnd = 229560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x0020D9DC File Offset: 0x0020BBDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229560, XrefRangeEnd = 229570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x0020DA20 File Offset: 0x0020BC20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228638, RefRangeEnd = 228640, XrefRangeStart = 228638, XrefRangeEnd = 228640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npcObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x0020DA64 File Offset: 0x0020BC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229570, XrefRangeEnd = 229574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002463 RID: 9315
		// (get) Token: 0x0600757B RID: 30075 RVA: 0x0020DAC8 File Offset: 0x0020BCC8
		// (set) Token: 0x0600757C RID: 30076 RVA: 0x0020DB08 File Offset: 0x0020BD08
		public unsafe NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229574, XrefRangeEnd = 229583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x0020DB58 File Offset: 0x0020BD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229583, XrefRangeEnd = 229584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Growing_GrowContainer(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Growing_GrowContainer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x0600757E RID: 30078 RVA: 0x0020DBCC File Offset: 0x0020BDCC
		// (set) Token: 0x0600757F RID: 30079 RVA: 0x0020DC0C File Offset: 0x0020BE0C
		public unsafe NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229584, XrefRangeEnd = 229593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x0020DC5C File Offset: 0x0020BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229593, XrefRangeEnd = 229599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowContainer.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00037E32 File Offset: 0x00036032
		public GrowContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x06007582 RID: 30082 RVA: 0x0020DC98 File Offset: 0x0020BE98
		// (set) Token: 0x06007583 RID: 30083 RVA: 0x00037E3B File Offset: 0x0003603B
		public unsafe static float DryThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(GrowContainer.NativeFieldInfoPtr_DryThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GrowContainer.NativeFieldInfoPtr_DryThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x06007584 RID: 30084 RVA: 0x0020DCB4 File Offset: 0x0020BEB4
		// (set) Token: 0x06007585 RID: 30085 RVA: 0x00037E49 File Offset: 0x00036049
		public unsafe float _SoilCapacity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SoilCapacity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SoilCapacity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002426 RID: 9254
		// (get) Token: 0x06007586 RID: 30086 RVA: 0x0020DCDC File Offset: 0x0020BEDC
		// (set) Token: 0x06007587 RID: 30087 RVA: 0x00037E64 File Offset: 0x00036064
		public unsafe float _MoistureCapacity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__MoistureCapacity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__MoistureCapacity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002427 RID: 9255
		// (get) Token: 0x06007588 RID: 30088 RVA: 0x0020DD04 File Offset: 0x0020BF04
		// (set) Token: 0x06007589 RID: 30089 RVA: 0x00037E7F File Offset: 0x0003607F
		public unsafe bool _HidePlantDuringPourTasks_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__HidePlantDuringPourTasks_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__HidePlantDuringPourTasks_k__BackingField)) = value;
			}
		}

		// Token: 0x17002428 RID: 9256
		// (get) Token: 0x0600758A RID: 30090 RVA: 0x0020DD2C File Offset: 0x0020BF2C
		// (set) Token: 0x0600758B RID: 30091 RVA: 0x00037E9A File Offset: 0x0003609A
		public unsafe float _moistureDrainPerHour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__moistureDrainPerHour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__moistureDrainPerHour)) = value;
			}
		}

		// Token: 0x17002429 RID: 9257
		// (get) Token: 0x0600758C RID: 30092 RVA: 0x0020DD54 File Offset: 0x0020BF54
		// (set) Token: 0x0600758D RID: 30093 RVA: 0x00037EB5 File Offset: 0x000360B5
		public unsafe Il2CppReferenceArray<SoilDefinition> AllowedSoils
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_AllowedSoils);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SoilDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_AllowedSoils), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242A RID: 9258
		// (get) Token: 0x0600758E RID: 30094 RVA: 0x0020DD84 File Offset: 0x0020BF84
		// (set) Token: 0x0600758F RID: 30095 RVA: 0x00037ED4 File Offset: 0x000360D4
		public unsafe Il2CppReferenceArray<AdditiveDefinition> AllowedAdditives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_AllowedAdditives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AdditiveDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_AllowedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242B RID: 9259
		// (get) Token: 0x06007590 RID: 30096 RVA: 0x0020DDB4 File Offset: 0x0020BFB4
		// (set) Token: 0x06007591 RID: 30097 RVA: 0x00037EF3 File Offset: 0x000360F3
		public unsafe GrowContainerInteraction _interactionHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__interactionHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__interactionHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242C RID: 9260
		// (get) Token: 0x06007592 RID: 30098 RVA: 0x0020DDE4 File Offset: 0x0020BFE4
		// (set) Token: 0x06007593 RID: 30099 RVA: 0x00037F12 File Offset: 0x00036112
		public unsafe Il2CppReferenceArray<MeshRenderer> _soilMeshRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMeshRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMeshRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242D RID: 9261
		// (get) Token: 0x06007594 RID: 30100 RVA: 0x0020DE14 File Offset: 0x0020C014
		// (set) Token: 0x06007595 RID: 30101 RVA: 0x00037F31 File Offset: 0x00036131
		public unsafe Transform _SoilContainer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SoilContainer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SoilContainer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242E RID: 9262
		// (get) Token: 0x06007596 RID: 30102 RVA: 0x0020DE44 File Offset: 0x0020C044
		// (set) Token: 0x06007597 RID: 30103 RVA: 0x00037F50 File Offset: 0x00036150
		public unsafe Transform _soilMinTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMinTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMinTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700242F RID: 9263
		// (get) Token: 0x06007598 RID: 30104 RVA: 0x0020DE74 File Offset: 0x0020C074
		// (set) Token: 0x06007599 RID: 30105 RVA: 0x00037F6F File Offset: 0x0003616F
		public unsafe Transform _soilMaxTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMaxTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilMaxTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002430 RID: 9264
		// (get) Token: 0x0600759A RID: 30106 RVA: 0x0020DEA4 File Offset: 0x0020C0A4
		// (set) Token: 0x0600759B RID: 30107 RVA: 0x00037F8E File Offset: 0x0003618E
		public unsafe MeshRenderer _additiveDisplayTemplate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__additiveDisplayTemplate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__additiveDisplayTemplate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002431 RID: 9265
		// (get) Token: 0x0600759C RID: 30108 RVA: 0x0020DED4 File Offset: 0x0020C0D4
		// (set) Token: 0x0600759D RID: 30109 RVA: 0x00037FAD File Offset: 0x000361AD
		public unsafe Transform _PourableStartPoint_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__PourableStartPoint_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__PourableStartPoint_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002432 RID: 9266
		// (get) Token: 0x0600759E RID: 30110 RVA: 0x0020DF04 File Offset: 0x0020C104
		// (set) Token: 0x0600759F RID: 30111 RVA: 0x00037FCC File Offset: 0x000361CC
		public unsafe GrowContainerSurfaceCover _SurfaceCover_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SurfaceCover_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerSurfaceCover>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__SurfaceCover_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002433 RID: 9267
		// (get) Token: 0x060075A0 RID: 30112 RVA: 0x0020DF34 File Offset: 0x0020C134
		// (set) Token: 0x060075A1 RID: 30113 RVA: 0x00037FEB File Offset: 0x000361EB
		public unsafe GrowContainerCameraHandler _CameraHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__CameraHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrowContainerCameraHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__CameraHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002434 RID: 9268
		// (get) Token: 0x060075A2 RID: 30114 RVA: 0x0020DF64 File Offset: 0x0020C164
		// (set) Token: 0x060075A3 RID: 30115 RVA: 0x0003800A File Offset: 0x0003620A
		public unsafe TemperatureDisplay _TemperatureDisplay_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TemperatureDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__TemperatureDisplay_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002435 RID: 9269
		// (get) Token: 0x060075A4 RID: 30116 RVA: 0x0020DF94 File Offset: 0x0020C194
		// (set) Token: 0x060075A5 RID: 30117 RVA: 0x00038029 File Offset: 0x00036229
		public unsafe Transform _pourTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__pourTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__pourTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002436 RID: 9270
		// (get) Token: 0x060075A6 RID: 30118 RVA: 0x0020DFC4 File Offset: 0x0020C1C4
		// (set) Token: 0x060075A7 RID: 30119 RVA: 0x00038048 File Offset: 0x00036248
		public unsafe Transform _uiPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__uiPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__uiPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002437 RID: 9271
		// (get) Token: 0x060075A8 RID: 30120 RVA: 0x0020DFF4 File Offset: 0x0020C1F4
		// (set) Token: 0x060075A9 RID: 30121 RVA: 0x00038067 File Offset: 0x00036267
		public unsafe Il2CppReferenceArray<Transform> _accessPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__accessPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__accessPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x060075AA RID: 30122 RVA: 0x0020E024 File Offset: 0x0020C224
		// (set) Token: 0x060075AB RID: 30123 RVA: 0x00038086 File Offset: 0x00036286
		public unsafe Il2CppReferenceArray<ParticleSystem> _soilClearedParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilClearedParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilClearedParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x060075AC RID: 30124 RVA: 0x0020E054 File Offset: 0x0020C254
		// (set) Token: 0x060075AD RID: 30125 RVA: 0x000380A5 File Offset: 0x000362A5
		public unsafe AudioSourceController _soilClearedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilClearedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__soilClearedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x060075AE RID: 30126 RVA: 0x0020E084 File Offset: 0x0020C284
		// (set) Token: 0x060075AF RID: 30127 RVA: 0x000380C4 File Offset: 0x000362C4
		public unsafe UsableLightSource _lightSourceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__lightSourceOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsableLightSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__lightSourceOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x060075B0 RID: 30128 RVA: 0x0020E0B4 File Offset: 0x0020C2B4
		// (set) Token: 0x060075B1 RID: 30129 RVA: 0x000380E3 File Offset: 0x000362E3
		public unsafe SoilDefinition _CurrentSoil_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__CurrentSoil_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__CurrentSoil_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x060075B2 RID: 30130 RVA: 0x0020E0E4 File Offset: 0x0020C2E4
		// (set) Token: 0x060075B3 RID: 30131 RVA: 0x00038102 File Offset: 0x00036302
		public unsafe List<AdditiveDefinition> _AppliedAdditives_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__AppliedAdditives_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdditiveDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__AppliedAdditives_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x060075B4 RID: 30132 RVA: 0x0020E114 File Offset: 0x0020C314
		// (set) Token: 0x060075B5 RID: 30133 RVA: 0x00038121 File Offset: 0x00036321
		public unsafe NetworkObject _NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x060075B6 RID: 30134 RVA: 0x0020E144 File Offset: 0x0020C344
		// (set) Token: 0x060075B7 RID: 30135 RVA: 0x00038140 File Offset: 0x00036340
		public unsafe NetworkObject _PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x060075B8 RID: 30136 RVA: 0x0020E174 File Offset: 0x0020C374
		// (set) Token: 0x060075B9 RID: 30137 RVA: 0x0003815F File Offset: 0x0003635F
		public unsafe List<ItemSlot> _InputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__InputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__InputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002440 RID: 9280
		// (get) Token: 0x060075BA RID: 30138 RVA: 0x0020E1A4 File Offset: 0x0020C3A4
		// (set) Token: 0x060075BB RID: 30139 RVA: 0x0003817E File Offset: 0x0003637E
		public unsafe List<ItemSlot> _OutputSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__OutputSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__OutputSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x060075BC RID: 30140 RVA: 0x0020E1D4 File Offset: 0x0020C3D4
		// (set) Token: 0x060075BD RID: 30141 RVA: 0x0003819D File Offset: 0x0003639D
		public unsafe bool _Selectable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__Selectable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__Selectable_k__BackingField)) = value;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x060075BE RID: 30142 RVA: 0x0020E1FC File Offset: 0x0020C3FC
		// (set) Token: 0x060075BF RID: 30143 RVA: 0x000381B8 File Offset: 0x000363B8
		public unsafe bool _IsAcceptingItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__IsAcceptingItems_k__BackingField)) = value;
			}
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x060075C0 RID: 30144 RVA: 0x0020E224 File Offset: 0x0020C424
		// (set) Token: 0x060075C1 RID: 30145 RVA: 0x000381D3 File Offset: 0x000363D3
		public unsafe Action onMinPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_onMinPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_onMinPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x060075C2 RID: 30146 RVA: 0x0020E254 File Offset: 0x0020C454
		// (set) Token: 0x060075C3 RID: 30147 RVA: 0x000381F2 File Offset: 0x000363F2
		public unsafe Action<int> onTimeSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_onTimeSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_onTimeSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x060075C4 RID: 30148 RVA: 0x0020E284 File Offset: 0x0020C484
		// (set) Token: 0x060075C5 RID: 30149 RVA: 0x00038211 File Offset: 0x00036411
		public unsafe float _currentSoilAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__currentSoilAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__currentSoilAmount)) = value;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x060075C6 RID: 30150 RVA: 0x0020E2AC File Offset: 0x0020C4AC
		// (set) Token: 0x060075C7 RID: 30151 RVA: 0x0003822C File Offset: 0x0003642C
		public unsafe float _currentMoistureAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__currentMoistureAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__currentMoistureAmount)) = value;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x060075C8 RID: 30152 RVA: 0x0020E2D4 File Offset: 0x0020C4D4
		// (set) Token: 0x060075C9 RID: 30153 RVA: 0x00038247 File Offset: 0x00036447
		public unsafe int _remainingSoilUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__remainingSoilUses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__remainingSoilUses)) = value;
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x060075CA RID: 30154 RVA: 0x0020E2FC File Offset: 0x0020C4FC
		// (set) Token: 0x060075CB RID: 30155 RVA: 0x00038262 File Offset: 0x00036462
		public unsafe List<MeshRenderer> _activeAdditiveDisplays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__activeAdditiveDisplays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr__activeAdditiveDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x0020E32C File Offset: 0x0020C52C
		// (set) Token: 0x060075CD RID: 30157 RVA: 0x00038281 File Offset: 0x00036481
		public unsafe SyncVar<NetworkObject> syncVar____NPCUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x060075CE RID: 30158 RVA: 0x0020E35C File Offset: 0x0020C55C
		// (set) Token: 0x060075CF RID: 30159 RVA: 0x000382A0 File Offset: 0x000364A0
		public unsafe SyncVar<NetworkObject> syncVar____PlayerUserObject_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<NetworkObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x060075D0 RID: 30160 RVA: 0x0020E38C File Offset: 0x0020C58C
		// (set) Token: 0x060075D1 RID: 30161 RVA: 0x000382BF File Offset: 0x000364BF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700244C RID: 9292
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x0020E3B4 File Offset: 0x0020C5B4
		// (set) Token: 0x060075D3 RID: 30163 RVA: 0x000382DA File Offset: 0x000364DA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004FAD RID: 20397
		private static readonly IntPtr NativeFieldInfoPtr_DryThreshold;

		// Token: 0x04004FAE RID: 20398
		private static readonly IntPtr NativeFieldInfoPtr__SoilCapacity_k__BackingField;

		// Token: 0x04004FAF RID: 20399
		private static readonly IntPtr NativeFieldInfoPtr__MoistureCapacity_k__BackingField;

		// Token: 0x04004FB0 RID: 20400
		private static readonly IntPtr NativeFieldInfoPtr__HidePlantDuringPourTasks_k__BackingField;

		// Token: 0x04004FB1 RID: 20401
		private static readonly IntPtr NativeFieldInfoPtr__moistureDrainPerHour;

		// Token: 0x04004FB2 RID: 20402
		private static readonly IntPtr NativeFieldInfoPtr_AllowedSoils;

		// Token: 0x04004FB3 RID: 20403
		private static readonly IntPtr NativeFieldInfoPtr_AllowedAdditives;

		// Token: 0x04004FB4 RID: 20404
		private static readonly IntPtr NativeFieldInfoPtr__interactionHandler;

		// Token: 0x04004FB5 RID: 20405
		private static readonly IntPtr NativeFieldInfoPtr__soilMeshRenderers;

		// Token: 0x04004FB6 RID: 20406
		private static readonly IntPtr NativeFieldInfoPtr__SoilContainer_k__BackingField;

		// Token: 0x04004FB7 RID: 20407
		private static readonly IntPtr NativeFieldInfoPtr__soilMinTransform;

		// Token: 0x04004FB8 RID: 20408
		private static readonly IntPtr NativeFieldInfoPtr__soilMaxTransform;

		// Token: 0x04004FB9 RID: 20409
		private static readonly IntPtr NativeFieldInfoPtr__additiveDisplayTemplate;

		// Token: 0x04004FBA RID: 20410
		private static readonly IntPtr NativeFieldInfoPtr__PourableStartPoint_k__BackingField;

		// Token: 0x04004FBB RID: 20411
		private static readonly IntPtr NativeFieldInfoPtr__SurfaceCover_k__BackingField;

		// Token: 0x04004FBC RID: 20412
		private static readonly IntPtr NativeFieldInfoPtr__CameraHandler_k__BackingField;

		// Token: 0x04004FBD RID: 20413
		private static readonly IntPtr NativeFieldInfoPtr__TemperatureDisplay_k__BackingField;

		// Token: 0x04004FBE RID: 20414
		private static readonly IntPtr NativeFieldInfoPtr__pourTarget;

		// Token: 0x04004FBF RID: 20415
		private static readonly IntPtr NativeFieldInfoPtr__uiPoint;

		// Token: 0x04004FC0 RID: 20416
		private static readonly IntPtr NativeFieldInfoPtr__accessPoints;

		// Token: 0x04004FC1 RID: 20417
		private static readonly IntPtr NativeFieldInfoPtr__soilClearedParticles;

		// Token: 0x04004FC2 RID: 20418
		private static readonly IntPtr NativeFieldInfoPtr__soilClearedSound;

		// Token: 0x04004FC3 RID: 20419
		private static readonly IntPtr NativeFieldInfoPtr__lightSourceOverride;

		// Token: 0x04004FC4 RID: 20420
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSoil_k__BackingField;

		// Token: 0x04004FC5 RID: 20421
		private static readonly IntPtr NativeFieldInfoPtr__AppliedAdditives_k__BackingField;

		// Token: 0x04004FC6 RID: 20422
		private static readonly IntPtr NativeFieldInfoPtr__NPCUserObject_k__BackingField;

		// Token: 0x04004FC7 RID: 20423
		private static readonly IntPtr NativeFieldInfoPtr__PlayerUserObject_k__BackingField;

		// Token: 0x04004FC8 RID: 20424
		private static readonly IntPtr NativeFieldInfoPtr__InputSlots_k__BackingField;

		// Token: 0x04004FC9 RID: 20425
		private static readonly IntPtr NativeFieldInfoPtr__OutputSlots_k__BackingField;

		// Token: 0x04004FCA RID: 20426
		private static readonly IntPtr NativeFieldInfoPtr__Selectable_k__BackingField;

		// Token: 0x04004FCB RID: 20427
		private static readonly IntPtr NativeFieldInfoPtr__IsAcceptingItems_k__BackingField;

		// Token: 0x04004FCC RID: 20428
		private static readonly IntPtr NativeFieldInfoPtr_onMinPass;

		// Token: 0x04004FCD RID: 20429
		private static readonly IntPtr NativeFieldInfoPtr_onTimeSkip;

		// Token: 0x04004FCE RID: 20430
		private static readonly IntPtr NativeFieldInfoPtr__currentSoilAmount;

		// Token: 0x04004FCF RID: 20431
		private static readonly IntPtr NativeFieldInfoPtr__currentMoistureAmount;

		// Token: 0x04004FD0 RID: 20432
		private static readonly IntPtr NativeFieldInfoPtr__remainingSoilUses;

		// Token: 0x04004FD1 RID: 20433
		private static readonly IntPtr NativeFieldInfoPtr__activeAdditiveDisplays;

		// Token: 0x04004FD2 RID: 20434
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____NPCUserObject_k__BackingField;

		// Token: 0x04004FD3 RID: 20435
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____PlayerUserObject_k__BackingField;

		// Token: 0x04004FD4 RID: 20436
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004FD5 RID: 20437
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004FD6 RID: 20438
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilCapacity_Public_get_Single_0;

		// Token: 0x04004FD7 RID: 20439
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilCapacity_Private_set_Void_Single_0;

		// Token: 0x04004FD8 RID: 20440
		private static readonly IntPtr NativeMethodInfoPtr_get_MoistureCapacity_Public_get_Single_0;

		// Token: 0x04004FD9 RID: 20441
		private static readonly IntPtr NativeMethodInfoPtr_set_MoistureCapacity_Private_set_Void_Single_0;

		// Token: 0x04004FDA RID: 20442
		private static readonly IntPtr NativeMethodInfoPtr_get_HidePlantDuringPourTasks_Public_get_Boolean_0;

		// Token: 0x04004FDB RID: 20443
		private static readonly IntPtr NativeMethodInfoPtr_set_HidePlantDuringPourTasks_Private_set_Void_Boolean_0;

		// Token: 0x04004FDC RID: 20444
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilContainer_Public_get_Transform_0;

		// Token: 0x04004FDD RID: 20445
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilContainer_Private_set_Void_Transform_0;

		// Token: 0x04004FDE RID: 20446
		private static readonly IntPtr NativeMethodInfoPtr_get_PourableStartPoint_Public_get_Transform_0;

		// Token: 0x04004FDF RID: 20447
		private static readonly IntPtr NativeMethodInfoPtr_set_PourableStartPoint_Private_set_Void_Transform_0;

		// Token: 0x04004FE0 RID: 20448
		private static readonly IntPtr NativeMethodInfoPtr_get_SurfaceCover_Public_get_GrowContainerSurfaceCover_0;

		// Token: 0x04004FE1 RID: 20449
		private static readonly IntPtr NativeMethodInfoPtr_set_SurfaceCover_Private_set_Void_GrowContainerSurfaceCover_0;

		// Token: 0x04004FE2 RID: 20450
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraHandler_Public_get_GrowContainerCameraHandler_0;

		// Token: 0x04004FE3 RID: 20451
		private static readonly IntPtr NativeMethodInfoPtr_set_CameraHandler_Private_set_Void_GrowContainerCameraHandler_0;

		// Token: 0x04004FE4 RID: 20452
		private static readonly IntPtr NativeMethodInfoPtr_get_TemperatureDisplay_Public_get_TemperatureDisplay_0;

		// Token: 0x04004FE5 RID: 20453
		private static readonly IntPtr NativeMethodInfoPtr_set_TemperatureDisplay_Private_set_Void_TemperatureDisplay_0;

		// Token: 0x04004FE6 RID: 20454
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedSoilAmount_Public_get_Single_0;

		// Token: 0x04004FE7 RID: 20455
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyFilledWithSoil_Public_get_Boolean_0;

		// Token: 0x04004FE8 RID: 20456
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedMoistureAmount_Public_get_Single_0;

		// Token: 0x04004FE9 RID: 20457
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSoil_Public_get_SoilDefinition_0;

		// Token: 0x04004FEA RID: 20458
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSoil_Private_set_Void_SoilDefinition_0;

		// Token: 0x04004FEB RID: 20459
		private static readonly IntPtr NativeMethodInfoPtr_get_AppliedAdditives_Public_get_List_1_AdditiveDefinition_0;

		// Token: 0x04004FEC RID: 20460
		private static readonly IntPtr NativeMethodInfoPtr_set_AppliedAdditives_Private_set_Void_List_1_AdditiveDefinition_0;

		// Token: 0x04004FED RID: 20461
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004FEE RID: 20462
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004FEF RID: 20463
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerUserObject_Public_Virtual_Final_New_get_NetworkObject_0;

		// Token: 0x04004FF0 RID: 20464
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerUserObject_Public_Virtual_Final_New_set_Void_NetworkObject_0;

		// Token: 0x04004FF1 RID: 20465
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004FF2 RID: 20466
		private static readonly IntPtr NativeMethodInfoPtr_get_InputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04004FF3 RID: 20467
		private static readonly IntPtr NativeMethodInfoPtr_set_InputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04004FF4 RID: 20468
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04004FF5 RID: 20469
		private static readonly IntPtr NativeMethodInfoPtr_set_OutputSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04004FF6 RID: 20470
		private static readonly IntPtr NativeMethodInfoPtr_get_LinkOrigin_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04004FF7 RID: 20471
		private static readonly IntPtr NativeMethodInfoPtr_get_AccessPoints_Public_Virtual_Final_New_get_Il2CppReferenceArray_1_Transform_0;

		// Token: 0x04004FF8 RID: 20472
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectable_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FF9 RID: 20473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAcceptingItems_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FFA RID: 20474
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAcceptingItems_Public_set_Void_Boolean_0;

		// Token: 0x04004FFB RID: 20475
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_0;

		// Token: 0x04004FFC RID: 20476
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureInteraction_Public_Void_String_EInteractableState_Vector3_0;

		// Token: 0x04004FFD RID: 20477
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004FFE RID: 20478
		private static readonly IntPtr NativeMethodInfoPtr_InitializeGridItem_Public_Virtual_Void_ItemInstance_Grid_Vector2_Int32_String_0;

		// Token: 0x04004FFF RID: 20479
		private static readonly IntPtr NativeMethodInfoPtr_HeatmapVisibilityChanged_Private_Void_Property_Boolean_0;

		// Token: 0x04005000 RID: 20480
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1;

		// Token: 0x04005001 RID: 20481
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04005002 RID: 20482
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04005003 RID: 20483
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkipped_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04005004 RID: 20484
		private static readonly IntPtr NativeMethodInfoPtr_DrainMoisture_Private_Void_Int32_0;

		// Token: 0x04005005 RID: 20485
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageLightExposure_Public_Single_byref_Single_0;

		// Token: 0x04005006 RID: 20486
		private static readonly IntPtr NativeMethodInfoPtr_IsPointAboveGrowSurface_Public_Abstract_Virtual_New_Boolean_Vector3_0;

		// Token: 0x04005007 RID: 20487
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowableVisible_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04005008 RID: 20488
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowSurfaceSideLength_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x04005009 RID: 20489
		private static readonly IntPtr NativeMethodInfoPtr_ContainsGrowable_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400500A RID: 20490
		private static readonly IntPtr NativeMethodInfoPtr_GetGrowthProgressNormalized_Public_Abstract_Virtual_New_Single_0;

		// Token: 0x0400500B RID: 20491
		private static readonly IntPtr NativeMethodInfoPtr_SetSoil_Public_Virtual_New_Void_SoilDefinition_0;

		// Token: 0x0400500C RID: 20492
		private static readonly IntPtr NativeMethodInfoPtr_ChangeSoilAmount_Public_Void_Single_0;

		// Token: 0x0400500D RID: 20493
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilAmount_Public_Void_Single_0;

		// Token: 0x0400500E RID: 20494
		private static readonly IntPtr NativeMethodInfoPtr_SetRemainingSoilUses_Public_Void_Int32_0;

		// Token: 0x0400500F RID: 20495
		private static readonly IntPtr NativeMethodInfoPtr_SyncSoilData_Public_Void_0;

		// Token: 0x04005010 RID: 20496
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilData_Server_Private_Void_String_Single_Int32_0;

		// Token: 0x04005011 RID: 20497
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilData_Client_Private_Void_NetworkConnection_String_Single_Int32_0;

		// Token: 0x04005012 RID: 20498
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSoilVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04005013 RID: 20499
		private static readonly IntPtr NativeMethodInfoPtr_ClearSoil_Protected_Virtual_New_Void_0;

		// Token: 0x04005014 RID: 20500
		private static readonly IntPtr NativeMethodInfoPtr_IsSoilAllowed_Public_Boolean_SoilDefinition_0;

		// Token: 0x04005015 RID: 20501
		private static readonly IntPtr NativeMethodInfoPtr_GetSoilMaterial_Protected_Virtual_New_Material_0;

		// Token: 0x04005016 RID: 20502
		private static readonly IntPtr NativeMethodInfoPtr_ChangeMoistureAmount_Public_Void_Single_0;

		// Token: 0x04005017 RID: 20503
		private static readonly IntPtr NativeMethodInfoPtr_SetMoistureAmount_Public_Virtual_New_Void_Single_0;

		// Token: 0x04005018 RID: 20504
		private static readonly IntPtr NativeMethodInfoPtr_SyncMoistureData_Public_Void_0;

		// Token: 0x04005019 RID: 20505
		private static readonly IntPtr NativeMethodInfoPtr_SetMoistureData_Server_Private_Void_Single_0;

		// Token: 0x0400501A RID: 20506
		private static readonly IntPtr NativeMethodInfoPtr_SetMoistureData_Client_Private_Void_NetworkConnection_Single_0;

		// Token: 0x0400501B RID: 20507
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Server_Public_Void_String_0;

		// Token: 0x0400501C RID: 20508
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Client_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x0400501D RID: 20509
		private static readonly IntPtr NativeMethodInfoPtr_ApplyAdditive_Protected_Virtual_New_AdditiveDefinition_String_Boolean_0;

		// Token: 0x0400501E RID: 20510
		private static readonly IntPtr NativeMethodInfoPtr_GetTemperatureGrowthMultiplier_Public_Virtual_New_Single_0;

		// Token: 0x0400501F RID: 20511
		private static readonly IntPtr NativeMethodInfoPtr_IsAdditiveApplied_Public_Boolean_String_0;

		// Token: 0x04005020 RID: 20512
		private static readonly IntPtr NativeMethodInfoPtr_ClearAdditives_Protected_Void_0;

		// Token: 0x04005021 RID: 20513
		private static readonly IntPtr NativeMethodInfoPtr_CanApplyAdditive_Public_Virtual_New_Boolean_AdditiveDefinition_byref_String_0;

		// Token: 0x04005022 RID: 20514
		private static readonly IntPtr NativeMethodInfoPtr_SetPourTargetActive_Public_Void_Boolean_0;

		// Token: 0x04005023 RID: 20515
		private static readonly IntPtr NativeMethodInfoPtr_RandomizePourTargetPosition_Public_Void_0;

		// Token: 0x04005024 RID: 20516
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentTargetPosition_Public_Vector3_0;

		// Token: 0x04005025 RID: 20517
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomPourTargetPosition_Protected_Abstract_Virtual_New_Vector3_0;

		// Token: 0x04005026 RID: 20518
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04005027 RID: 20519
		private static readonly IntPtr NativeMethodInfoPtr_SetNPCUser_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04005028 RID: 20520
		private static readonly IntPtr NativeMethodInfoPtr_Load_Protected_Void_GrowContainerData_0;

		// Token: 0x04005029 RID: 20521
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400502A RID: 20522
		private static readonly IntPtr NativeMethodInfoPtr__InitializeGridItem_b__99_0_Private_Single_0;

		// Token: 0x0400502B RID: 20523
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400502C RID: 20524
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400502D RID: 20525
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400502E RID: 20526
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0;

		// Token: 0x0400502F RID: 20527
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSoilData_Server_3104499779_Private_Void_String_Single_Int32_0;

		// Token: 0x04005030 RID: 20528
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSoilData_Server_3104499779_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005031 RID: 20529
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0;

		// Token: 0x04005032 RID: 20530
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0;

		// Token: 0x04005033 RID: 20531
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005034 RID: 20532
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSoilData_Client_433593356_Private_Void_NetworkConnection_String_Single_Int32_0;

		// Token: 0x04005035 RID: 20533
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSoilData_Client_433593356_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005036 RID: 20534
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetMoistureData_Server_431000436_Private_Void_Single_0;

		// Token: 0x04005037 RID: 20535
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMoistureData_Server_431000436_Private_Void_Single_0;

		// Token: 0x04005038 RID: 20536
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetMoistureData_Server_431000436_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005039 RID: 20537
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x0400503A RID: 20538
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x0400503B RID: 20539
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400503C RID: 20540
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetMoistureData_Client_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x0400503D RID: 20541
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetMoistureData_Client_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400503E RID: 20542
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ApplyAdditive_Server_3615296227_Private_Void_String_0;

		// Token: 0x0400503F RID: 20543
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Server_3615296227_Public_Void_String_0;

		// Token: 0x04005040 RID: 20544
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ApplyAdditive_Server_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005041 RID: 20545
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04005042 RID: 20546
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04005043 RID: 20547
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005044 RID: 20548
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ApplyAdditive_Client_619441887_Private_Void_NetworkConnection_String_Boolean_0;

		// Token: 0x04005045 RID: 20549
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ApplyAdditive_Client_619441887_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005046 RID: 20550
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPlayerUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04005047 RID: 20551
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPlayerUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x04005048 RID: 20552
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPlayerUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005049 RID: 20553
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetNPCUser_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x0400504A RID: 20554
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetNPCUser_3323014238_Public_Virtual_Final_New_Void_NetworkObject_0;

		// Token: 0x0400504B RID: 20555
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetNPCUser_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400504C RID: 20556
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__NPCUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x0400504D RID: 20557
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__NPCUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x0400504E RID: 20558
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Growing_GrowContainer_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x0400504F RID: 20559
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__PlayerUserObject_k__BackingField_Public_get_NetworkObject_0;

		// Token: 0x04005050 RID: 20560
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__PlayerUserObject_k__BackingField_Public_set_Void_NetworkObject_Boolean_0;

		// Token: 0x04005051 RID: 20561
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000BAA RID: 2986
		[ObfuscatedName("ScheduleOne.Growing.GrowContainer+<>c__DisplayClass132_0")]
		public sealed class __c__DisplayClass132_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EAA1 RID: 60065 RVA: 0x0038FCEC File Offset: 0x0038DEEC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass132_0()
			{
				Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrowContainer>.NativeClassPtr, "<>c__DisplayClass132_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr);
				GrowContainer.__c__DisplayClass132_0.NativeFieldInfoPtr_additiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr, "additiveID");
				GrowContainer.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr, 100678464);
				GrowContainer.__c__DisplayClass132_0.NativeMethodInfoPtr__IsAdditiveApplied_b__0_Internal_Boolean_AdditiveDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr, 100678465);
			}

			// Token: 0x0600EAA2 RID: 60066 RVA: 0x0038FD54 File Offset: 0x0038DF54
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass132_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainer.__c__DisplayClass132_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAA3 RID: 60067 RVA: 0x0038FD90 File Offset: 0x0038DF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsAdditiveApplied_b__0(AdditiveDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainer.__c__DisplayClass132_0.NativeMethodInfoPtr__IsAdditiveApplied_b__0_Internal_Boolean_AdditiveDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EAA4 RID: 60068 RVA: 0x0006EB03 File Offset: 0x0006CD03
			public __c__DisplayClass132_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700472B RID: 18219
			// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x0038FDE0 File Offset: 0x0038DFE0
			// (set) Token: 0x0600EAA6 RID: 60070 RVA: 0x0006EB0C File Offset: 0x0006CD0C
			public unsafe string additiveID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.__c__DisplayClass132_0.NativeFieldInfoPtr_additiveID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainer.__c__DisplayClass132_0.NativeFieldInfoPtr_additiveID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009F01 RID: 40705
			private static readonly IntPtr NativeFieldInfoPtr_additiveID;

			// Token: 0x04009F02 RID: 40706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F03 RID: 40707
			private static readonly IntPtr NativeMethodInfoPtr__IsAdditiveApplied_b__0_Internal_Boolean_AdditiveDefinition_0;
		}
	}
}
