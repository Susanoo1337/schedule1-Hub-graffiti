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
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000521 RID: 1313
	public class ShroomColony : NetworkBehaviour
	{
		// Token: 0x0600770C RID: 30476 RVA: 0x00211D5C File Offset: 0x0020FF5C
		// Note: this type is marked as 'beforefieldinit'.
		static ShroomColony()
		{
			Il2CppClassPointerStore<ShroomColony>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "ShroomColony");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr);
			ShroomColony.NativeFieldInfoPtr_MaxTemperatureForGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "MaxTemperatureForGrowth");
			ShroomColony.NativeFieldInfoPtr_MinSoilMoistureForGrowth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "MinSoilMoistureForGrowth");
			ShroomColony.NativeFieldInfoPtr_RandomRotationRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "RandomRotationRange");
			ShroomColony.NativeFieldInfoPtr_RandomVerticalShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "RandomVerticalShift");
			ShroomColony.NativeFieldInfoPtr__BaseShroomYield_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "<BaseShroomYield>k__BackingField");
			ShroomColony.NativeFieldInfoPtr__spawnDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_spawnDefinition");
			ShroomColony.NativeFieldInfoPtr__growTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_growTime");
			ShroomColony.NativeFieldInfoPtr__shroomAlignments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_shroomAlignments");
			ShroomColony.NativeFieldInfoPtr__growingShroomPrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_growingShroomPrefabs");
			ShroomColony.NativeFieldInfoPtr__snipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_snipSound");
			ShroomColony.NativeFieldInfoPtr__fullyGrownParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_fullyGrownParticles");
			ShroomColony.NativeFieldInfoPtr__GrowthProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "<GrowthProgress>k__BackingField");
			ShroomColony.NativeFieldInfoPtr__IsTooHotToGrow_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "<IsTooHotToGrow>k__BackingField");
			ShroomColony.NativeFieldInfoPtr__NormalizedQuality_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "<NormalizedQuality>k__BackingField");
			ShroomColony.NativeFieldInfoPtr_onFullyHarvested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "onFullyHarvested");
			ShroomColony.NativeFieldInfoPtr__growingShrooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_growingShrooms");
			ShroomColony.NativeFieldInfoPtr__growingShroomPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_growingShroomPositions");
			ShroomColony.NativeFieldInfoPtr__takenAlignmentIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_takenAlignmentIndices");
			ShroomColony.NativeFieldInfoPtr__parentBed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_parentBed");
			ShroomColony.NativeFieldInfoPtr__shroomsInitiallySpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "_shroomsInitiallySpawned");
			ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted");
			ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted");
			ShroomColony.NativeMethodInfoPtr_get_BaseShroomYield_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678582);
			ShroomColony.NativeMethodInfoPtr_set_BaseShroomYield_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678583);
			ShroomColony.NativeMethodInfoPtr_get_GrowthProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678584);
			ShroomColony.NativeMethodInfoPtr_set_GrowthProgress_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678585);
			ShroomColony.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678586);
			ShroomColony.NativeMethodInfoPtr_get_IsTooHotToGrow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678587);
			ShroomColony.NativeMethodInfoPtr_set_IsTooHotToGrow_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678588);
			ShroomColony.NativeMethodInfoPtr_get_GrownMushroomCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678589);
			ShroomColony.NativeMethodInfoPtr_get_SnipSound_Public_get_AudioSourceController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678590);
			ShroomColony.NativeMethodInfoPtr_get_NormalizedQuality_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678591);
			ShroomColony.NativeMethodInfoPtr_set_NormalizedQuality_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678592);
			ShroomColony.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678593);
			ShroomColony.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678594);
			ShroomColony.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678595);
			ShroomColony.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678596);
			ShroomColony.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678597);
			ShroomColony.NativeMethodInfoPtr_CheckTemperature_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678598);
			ShroomColony.NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678599);
			ShroomColony.NativeMethodInfoPtr_SetColonyVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678600);
			ShroomColony.NativeMethodInfoPtr_GetCurrentGrowthRate_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678601);
			ShroomColony.NativeMethodInfoPtr_ChangeGrowthPercentage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678602);
			ShroomColony.NativeMethodInfoPtr_SetFullyGrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678603);
			ShroomColony.NativeMethodInfoPtr_SetGrowthPercentage_Local_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678604);
			ShroomColony.NativeMethodInfoPtr_SetGrowthPercentage_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678605);
			ShroomColony.NativeMethodInfoPtr_ChangeQuality_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678606);
			ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678607);
			ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Local_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678608);
			ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678609);
			ShroomColony.NativeMethodInfoPtr_RemoveShroom_Server_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678610);
			ShroomColony.NativeMethodInfoPtr_RemoveRandomShroom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678611);
			ShroomColony.NativeMethodInfoPtr_RemoveShoom_Client_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678612);
			ShroomColony.NativeMethodInfoPtr_RemoveShroom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678613);
			ShroomColony.NativeMethodInfoPtr_RemoveShroom_Private_Void_GrowingMushroom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678614);
			ShroomColony.NativeMethodInfoPtr_SetFullyHarvested_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678615);
			ShroomColony.NativeMethodInfoPtr_GetRandomAvailableAlignmentIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678616);
			ShroomColony.NativeMethodInfoPtr_GetHarvestedShroom_Public_ShroomInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678617);
			ShroomColony.NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678618);
			ShroomColony.NativeMethodInfoPtr_SetColonyState_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678619);
			ShroomColony.NativeMethodInfoPtr_GetSaveData_Public_ShroomColonyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678620);
			ShroomColony.NativeMethodInfoPtr_Load_Public_Void_ShroomColonyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678621);
			ShroomColony.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678622);
			ShroomColony.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678623);
			ShroomColony.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678624);
			ShroomColony.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678625);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_SetFullyGrown_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678626);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___SetFullyGrown_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678627);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Server_SetFullyGrown_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678628);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678629);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678630);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678631);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Target_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678632);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Target_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678633);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_AddShroomAtPosition_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678634);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678635);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Server_AddShroomAtPosition_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678636);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678637);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678638);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678639);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_RemoveShroom_Server_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678640);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___RemoveShroom_Server_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678641);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Server_RemoveShroom_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678642);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_RemoveShoom_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678643);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___RemoveShoom_Client_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678644);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_RemoveShoom_Client_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678645);
			ShroomColony.NativeMethodInfoPtr_RpcWriter___Target_SetColonyState_4288818029_Private_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678646);
			ShroomColony.NativeMethodInfoPtr_RpcLogic___SetColonyState_4288818029_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678647);
			ShroomColony.NativeMethodInfoPtr_RpcReader___Target_SetColonyState_4288818029_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678648);
			ShroomColony.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr, 100678649);
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600770D RID: 30477 RVA: 0x00212494 File Offset: 0x00210694
		// (set) Token: 0x0600770E RID: 30478 RVA: 0x002124D0 File Offset: 0x002106D0
		public unsafe int BaseShroomYield
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_BaseShroomYield_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_set_BaseShroomYield_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600770F RID: 30479 RVA: 0x00212510 File Offset: 0x00210710
		// (set) Token: 0x06007710 RID: 30480 RVA: 0x0021254C File Offset: 0x0021074C
		public unsafe float GrowthProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_GrowthProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_set_GrowthProgress_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x06007711 RID: 30481 RVA: 0x0021258C File Offset: 0x0021078C
		public unsafe bool IsFullyGrown
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 230398, RefRangeEnd = 230401, XrefRangeStart = 230398, XrefRangeEnd = 230398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06007712 RID: 30482 RVA: 0x002125C8 File Offset: 0x002107C8
		// (set) Token: 0x06007713 RID: 30483 RVA: 0x00212604 File Offset: 0x00210804
		public unsafe bool IsTooHotToGrow
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_IsTooHotToGrow_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_set_IsTooHotToGrow_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06007714 RID: 30484 RVA: 0x00212644 File Offset: 0x00210844
		public unsafe int GrownMushroomCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 230402, RefRangeEnd = 230404, XrefRangeStart = 230401, XrefRangeEnd = 230402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_GrownMushroomCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06007715 RID: 30485 RVA: 0x00212680 File Offset: 0x00210880
		public unsafe AudioSourceController SnipSound
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_SnipSound_Public_get_AudioSourceController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr3) : null;
			}
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06007716 RID: 30486 RVA: 0x002126C0 File Offset: 0x002108C0
		// (set) Token: 0x06007717 RID: 30487 RVA: 0x002126FC File Offset: 0x002108FC
		public unsafe float NormalizedQuality
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_get_NormalizedQuality_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_set_NormalizedQuality_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x0021273C File Offset: 0x0021093C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230404, XrefRangeEnd = 230433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x0021278C File Offset: 0x0021098C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230433, XrefRangeEnd = 230499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x002127C8 File Offset: 0x002109C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230499, XrefRangeEnd = 230543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x002127FC File Offset: 0x002109FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230543, XrefRangeEnd = 230551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00212830 File Offset: 0x00210A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230551, XrefRangeEnd = 230552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00212864 File Offset: 0x00210A64
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230556, RefRangeEnd = 230558, XrefRangeStart = 230552, XrefRangeEnd = 230556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTemperature()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_CheckTemperature_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00212898 File Offset: 0x00210A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230558, XrefRangeEnd = 230563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTimeSkipped(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x002128D8 File Offset: 0x00210AD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 230566, RefRangeEnd = 230573, XrefRangeStart = 230563, XrefRangeEnd = 230566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColonyVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetColonyVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00212918 File Offset: 0x00210B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230573, XrefRangeEnd = 230574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCurrentGrowthRate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_GetCurrentGrowthRate_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00212954 File Offset: 0x00210B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230574, XrefRangeEnd = 230575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeGrowthPercentage(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_ChangeGrowthPercentage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00212994 File Offset: 0x00210B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230584, RefRangeEnd = 230585, XrefRangeStart = 230575, XrefRangeEnd = 230584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFullyGrown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetFullyGrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x002129C8 File Offset: 0x00210BC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230627, RefRangeEnd = 230630, XrefRangeStart = 230585, XrefRangeEnd = 230627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowthPercentage_Local(NetworkConnection conn, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetGrowthPercentage_Local_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00212A18 File Offset: 0x00210C18
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 230650, RefRangeEnd = 230661, XrefRangeStart = 230630, XrefRangeEnd = 230650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGrowthPercentage(float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetGrowthPercentage_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00212A58 File Offset: 0x00210C58
		[CallerCount(0)]
		public unsafe void ChangeQuality(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_ChangeQuality_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x00212A98 File Offset: 0x00210C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230661, XrefRangeEnd = 230684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddShroomAtPosition_Server(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00212AD8 File Offset: 0x00210CD8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 230707, RefRangeEnd = 230712, XrefRangeStart = 230684, XrefRangeEnd = 230707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddShroomAtPosition_Local(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Local_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00212B18 File Offset: 0x00210D18
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 230751, RefRangeEnd = 230757, XrefRangeStart = 230712, XrefRangeEnd = 230751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddShroomAtPosition(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_AddShroomAtPosition_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00212B58 File Offset: 0x00210D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230780, RefRangeEnd = 230781, XrefRangeStart = 230757, XrefRangeEnd = 230780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveShroom_Server(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RemoveShroom_Server_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00212B98 File Offset: 0x00210D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230812, RefRangeEnd = 230813, XrefRangeStart = 230781, XrefRangeEnd = 230812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRandomShroom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RemoveRandomShroom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00212BCC File Offset: 0x00210DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230836, RefRangeEnd = 230839, XrefRangeStart = 230813, XrefRangeEnd = 230836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveShoom_Client(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RemoveShoom_Client_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00212C0C File Offset: 0x00210E0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 230889, RefRangeEnd = 230893, XrefRangeStart = 230839, XrefRangeEnd = 230889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveShroom(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RemoveShroom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00212C4C File Offset: 0x00210E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230893, XrefRangeEnd = 230921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveShroom(GrowingMushroom shroom)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shroom);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RemoveShroom_Private_Void_GrowingMushroom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00212C90 File Offset: 0x00210E90
		[CallerCount(0)]
		public unsafe void SetFullyHarvested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetFullyHarvested_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00212CC4 File Offset: 0x00210EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230945, RefRangeEnd = 230947, XrefRangeStart = 230921, XrefRangeEnd = 230945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRandomAvailableAlignmentIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_GetRandomAvailableAlignmentIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00212D00 File Offset: 0x00210F00
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 230954, RefRangeEnd = 230961, XrefRangeStart = 230947, XrefRangeEnd = 230954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomInstance GetHarvestedShroom(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_GetHarvestedShroom_Public_ShroomInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomInstance>(intPtr3) : null;
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x00212D4C File Offset: 0x00210F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230967, RefRangeEnd = 230969, XrefRangeStart = 230961, XrefRangeEnd = 230967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additive);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInitialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00212D9C File Offset: 0x00210F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230969, XrefRangeEnd = 230981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColonyState(NetworkConnection conn, Il2CppStructArray<int> _activeMushroomIndices, float growthProgress, float quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_activeMushroomIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_SetColonyState_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00212E0C File Offset: 0x0021100C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230994, RefRangeEnd = 230995, XrefRangeStart = 230981, XrefRangeEnd = 230994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomColonyData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_GetSaveData_Public_ShroomColonyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShroomColonyData>(intPtr3) : null;
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00212E4C File Offset: 0x0021104C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230995, XrefRangeEnd = 231000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ShroomColonyData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_Load_Public_Void_ShroomColonyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00212E90 File Offset: 0x00211090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231000, XrefRangeEnd = 231022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShroomColony() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShroomColony>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x00212ECC File Offset: 0x002110CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231022, XrefRangeEnd = 231072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00212F08 File Offset: 0x00211108
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00212F44 File Offset: 0x00211144
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00212F80 File Offset: 0x00211180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230584, RefRangeEnd = 230585, XrefRangeStart = 230584, XrefRangeEnd = 230585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetFullyGrown_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_SetFullyGrown_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00212FB4 File Offset: 0x002111B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231072, XrefRangeEnd = 231073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetFullyGrown_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___SetFullyGrown_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00212FE8 File Offset: 0x002111E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231073, XrefRangeEnd = 231075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetFullyGrown_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Server_SetFullyGrown_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x0021304C File Offset: 0x0021124C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231075, XrefRangeEnd = 231085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x0021309C File Offset: 0x0021129C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231085, XrefRangeEnd = 231086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x002130EC File Offset: 0x002112EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231086, XrefRangeEnd = 231090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x0021313C File Offset: 0x0021133C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231090, XrefRangeEnd = 231100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref percent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Target_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x0021318C File Offset: 0x0021138C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231100, XrefRangeEnd = 231104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Target_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x002131DC File Offset: 0x002113DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231104, XrefRangeEnd = 231115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_AddShroomAtPosition_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x0021321C File Offset: 0x0021141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231115, XrefRangeEnd = 231116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddShroomAtPosition_Server_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x0021325C File Offset: 0x0021145C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231116, XrefRangeEnd = 231121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddShroomAtPosition_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Server_AddShroomAtPosition_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x002132C0 File Offset: 0x002114C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231121, XrefRangeEnd = 231132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00213300 File Offset: 0x00211500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231132, XrefRangeEnd = 231133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddShroomAtPosition_Local_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00213340 File Offset: 0x00211540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231133, XrefRangeEnd = 231138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddShroomAtPosition_Local_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00213390 File Offset: 0x00211590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231138, XrefRangeEnd = 231149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveShroom_Server_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Server_RemoveShroom_Server_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x002133D0 File Offset: 0x002115D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 230836, RefRangeEnd = 230839, XrefRangeStart = 230836, XrefRangeEnd = 230839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveShroom_Server_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___RemoveShroom_Server_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00213410 File Offset: 0x00211610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231149, XrefRangeEnd = 231154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveShroom_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Server_RemoveShroom_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00213474 File Offset: 0x00211674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231154, XrefRangeEnd = 231165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RemoveShoom_Client_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Observers_RemoveShoom_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x002134B4 File Offset: 0x002116B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231165, XrefRangeEnd = 231166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveShoom_Client_3316948804(int alignmentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alignmentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___RemoveShoom_Client_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x002134F4 File Offset: 0x002116F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231166, XrefRangeEnd = 231171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RemoveShoom_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Observers_RemoveShoom_Client_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00213544 File Offset: 0x00211744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetColonyState_4288818029(NetworkConnection conn, Il2CppStructArray<int> _activeMushroomIndices, float growthProgress, float quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_activeMushroomIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcWriter___Target_SetColonyState_4288818029_Private_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x002135B4 File Offset: 0x002117B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231171, XrefRangeEnd = 231176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetColonyState_4288818029(NetworkConnection conn, Il2CppStructArray<int> _activeMushroomIndices, float growthProgress, float quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_activeMushroomIndices);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcLogic___SetColonyState_4288818029_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x00213624 File Offset: 0x00211824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231176, XrefRangeEnd = 231184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetColonyState_4288818029(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShroomColony.NativeMethodInfoPtr_RpcReader___Target_SetColonyState_4288818029_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00213674 File Offset: 0x00211874
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShroomColony.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x00038D85 File Offset: 0x00036F85
		public ShroomColony(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x002136B0 File Offset: 0x002118B0
		// (set) Token: 0x06007753 RID: 30547 RVA: 0x00038D8E File Offset: 0x00036F8E
		public unsafe static float MaxTemperatureForGrowth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ShroomColony.NativeFieldInfoPtr_MaxTemperatureForGrowth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomColony.NativeFieldInfoPtr_MaxTemperatureForGrowth, (void*)(&value));
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x002136CC File Offset: 0x002118CC
		// (set) Token: 0x06007755 RID: 30549 RVA: 0x00038D9C File Offset: 0x00036F9C
		public unsafe static float MinSoilMoistureForGrowth
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ShroomColony.NativeFieldInfoPtr_MinSoilMoistureForGrowth, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomColony.NativeFieldInfoPtr_MinSoilMoistureForGrowth, (void*)(&value));
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x002136E8 File Offset: 0x002118E8
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x00038DAA File Offset: 0x00036FAA
		public unsafe static float RandomRotationRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ShroomColony.NativeFieldInfoPtr_RandomRotationRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomColony.NativeFieldInfoPtr_RandomRotationRange, (void*)(&value));
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06007758 RID: 30552 RVA: 0x00213704 File Offset: 0x00211904
		// (set) Token: 0x06007759 RID: 30553 RVA: 0x00038DB8 File Offset: 0x00036FB8
		public unsafe static float RandomVerticalShift
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ShroomColony.NativeFieldInfoPtr_RandomVerticalShift, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShroomColony.NativeFieldInfoPtr_RandomVerticalShift, (void*)(&value));
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x0600775A RID: 30554 RVA: 0x00213720 File Offset: 0x00211920
		// (set) Token: 0x0600775B RID: 30555 RVA: 0x00038DC6 File Offset: 0x00036FC6
		public unsafe int _BaseShroomYield_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__BaseShroomYield_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__BaseShroomYield_k__BackingField)) = value;
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x0600775C RID: 30556 RVA: 0x00213748 File Offset: 0x00211948
		// (set) Token: 0x0600775D RID: 30557 RVA: 0x00038DE1 File Offset: 0x00036FE1
		public unsafe ShroomSpawnDefinition _spawnDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__spawnDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomSpawnDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__spawnDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x0600775E RID: 30558 RVA: 0x00213778 File Offset: 0x00211978
		// (set) Token: 0x0600775F RID: 30559 RVA: 0x00038E00 File Offset: 0x00037000
		public unsafe int _growTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growTime)) = value;
			}
		}

		// Token: 0x170024DA RID: 9434
		// (get) Token: 0x06007760 RID: 30560 RVA: 0x002137A0 File Offset: 0x002119A0
		// (set) Token: 0x06007761 RID: 30561 RVA: 0x00038E1B File Offset: 0x0003701B
		public unsafe Il2CppReferenceArray<Transform> _shroomAlignments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__shroomAlignments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__shroomAlignments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DB RID: 9435
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x002137D0 File Offset: 0x002119D0
		// (set) Token: 0x06007763 RID: 30563 RVA: 0x00038E3A File Offset: 0x0003703A
		public unsafe Il2CppReferenceArray<GrowingMushroom> _growingShroomPrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShroomPrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GrowingMushroom>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShroomPrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DC RID: 9436
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x00213800 File Offset: 0x00211A00
		// (set) Token: 0x06007765 RID: 30565 RVA: 0x00038E59 File Offset: 0x00037059
		public unsafe AudioSourceController _snipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__snipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__snipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x00213830 File Offset: 0x00211A30
		// (set) Token: 0x06007767 RID: 30567 RVA: 0x00038E78 File Offset: 0x00037078
		public unsafe ParticleSystem _fullyGrownParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__fullyGrownParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__fullyGrownParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024DE RID: 9438
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x00213860 File Offset: 0x00211A60
		// (set) Token: 0x06007769 RID: 30569 RVA: 0x00038E97 File Offset: 0x00037097
		public unsafe float _GrowthProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__GrowthProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__GrowthProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170024DF RID: 9439
		// (get) Token: 0x0600776A RID: 30570 RVA: 0x00213888 File Offset: 0x00211A88
		// (set) Token: 0x0600776B RID: 30571 RVA: 0x00038EB2 File Offset: 0x000370B2
		public unsafe bool _IsTooHotToGrow_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__IsTooHotToGrow_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__IsTooHotToGrow_k__BackingField)) = value;
			}
		}

		// Token: 0x170024E0 RID: 9440
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x002138B0 File Offset: 0x00211AB0
		// (set) Token: 0x0600776D RID: 30573 RVA: 0x00038ECD File Offset: 0x000370CD
		public unsafe float _NormalizedQuality_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__NormalizedQuality_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__NormalizedQuality_k__BackingField)) = value;
			}
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x002138D8 File Offset: 0x00211AD8
		// (set) Token: 0x0600776F RID: 30575 RVA: 0x00038EE8 File Offset: 0x000370E8
		public unsafe Action onFullyHarvested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_onFullyHarvested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_onFullyHarvested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x06007770 RID: 30576 RVA: 0x00213908 File Offset: 0x00211B08
		// (set) Token: 0x06007771 RID: 30577 RVA: 0x00038F07 File Offset: 0x00037107
		public unsafe List<GrowingMushroom> _growingShrooms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShrooms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GrowingMushroom>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShrooms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x06007772 RID: 30578 RVA: 0x00213938 File Offset: 0x00211B38
		// (set) Token: 0x06007773 RID: 30579 RVA: 0x00038F26 File Offset: 0x00037126
		public unsafe Dictionary<GrowingMushroom, int> _growingShroomPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShroomPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GrowingMushroom, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__growingShroomPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x06007774 RID: 30580 RVA: 0x00213968 File Offset: 0x00211B68
		// (set) Token: 0x06007775 RID: 30581 RVA: 0x00038F45 File Offset: 0x00037145
		public unsafe List<int> _takenAlignmentIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__takenAlignmentIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__takenAlignmentIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06007776 RID: 30582 RVA: 0x00213998 File Offset: 0x00211B98
		// (set) Token: 0x06007777 RID: 30583 RVA: 0x00038F64 File Offset: 0x00037164
		public unsafe MushroomBed _parentBed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__parentBed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MushroomBed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__parentBed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x06007778 RID: 30584 RVA: 0x002139C8 File Offset: 0x00211BC8
		// (set) Token: 0x06007779 RID: 30585 RVA: 0x00038F83 File Offset: 0x00037183
		public unsafe bool _shroomsInitiallySpawned
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__shroomsInitiallySpawned);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr__shroomsInitiallySpawned)) = value;
			}
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x002139F0 File Offset: 0x00211BF0
		// (set) Token: 0x0600777B RID: 30587 RVA: 0x00038F9E File Offset: 0x0003719E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x0600777C RID: 30588 RVA: 0x00213A18 File Offset: 0x00211C18
		// (set) Token: 0x0600777D RID: 30589 RVA: 0x00038FB9 File Offset: 0x000371B9
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShroomColony.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005110 RID: 20752
		private static readonly IntPtr NativeFieldInfoPtr_MaxTemperatureForGrowth;

		// Token: 0x04005111 RID: 20753
		private static readonly IntPtr NativeFieldInfoPtr_MinSoilMoistureForGrowth;

		// Token: 0x04005112 RID: 20754
		private static readonly IntPtr NativeFieldInfoPtr_RandomRotationRange;

		// Token: 0x04005113 RID: 20755
		private static readonly IntPtr NativeFieldInfoPtr_RandomVerticalShift;

		// Token: 0x04005114 RID: 20756
		private static readonly IntPtr NativeFieldInfoPtr__BaseShroomYield_k__BackingField;

		// Token: 0x04005115 RID: 20757
		private static readonly IntPtr NativeFieldInfoPtr__spawnDefinition;

		// Token: 0x04005116 RID: 20758
		private static readonly IntPtr NativeFieldInfoPtr__growTime;

		// Token: 0x04005117 RID: 20759
		private static readonly IntPtr NativeFieldInfoPtr__shroomAlignments;

		// Token: 0x04005118 RID: 20760
		private static readonly IntPtr NativeFieldInfoPtr__growingShroomPrefabs;

		// Token: 0x04005119 RID: 20761
		private static readonly IntPtr NativeFieldInfoPtr__snipSound;

		// Token: 0x0400511A RID: 20762
		private static readonly IntPtr NativeFieldInfoPtr__fullyGrownParticles;

		// Token: 0x0400511B RID: 20763
		private static readonly IntPtr NativeFieldInfoPtr__GrowthProgress_k__BackingField;

		// Token: 0x0400511C RID: 20764
		private static readonly IntPtr NativeFieldInfoPtr__IsTooHotToGrow_k__BackingField;

		// Token: 0x0400511D RID: 20765
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedQuality_k__BackingField;

		// Token: 0x0400511E RID: 20766
		private static readonly IntPtr NativeFieldInfoPtr_onFullyHarvested;

		// Token: 0x0400511F RID: 20767
		private static readonly IntPtr NativeFieldInfoPtr__growingShrooms;

		// Token: 0x04005120 RID: 20768
		private static readonly IntPtr NativeFieldInfoPtr__growingShroomPositions;

		// Token: 0x04005121 RID: 20769
		private static readonly IntPtr NativeFieldInfoPtr__takenAlignmentIndices;

		// Token: 0x04005122 RID: 20770
		private static readonly IntPtr NativeFieldInfoPtr__parentBed;

		// Token: 0x04005123 RID: 20771
		private static readonly IntPtr NativeFieldInfoPtr__shroomsInitiallySpawned;

		// Token: 0x04005124 RID: 20772
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005125 RID: 20773
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005126 RID: 20774
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseShroomYield_Public_get_Int32_0;

		// Token: 0x04005127 RID: 20775
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseShroomYield_Private_set_Void_Int32_0;

		// Token: 0x04005128 RID: 20776
		private static readonly IntPtr NativeMethodInfoPtr_get_GrowthProgress_Public_get_Single_0;

		// Token: 0x04005129 RID: 20777
		private static readonly IntPtr NativeMethodInfoPtr_set_GrowthProgress_Private_set_Void_Single_0;

		// Token: 0x0400512A RID: 20778
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0;

		// Token: 0x0400512B RID: 20779
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTooHotToGrow_Public_get_Boolean_0;

		// Token: 0x0400512C RID: 20780
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTooHotToGrow_Private_set_Void_Boolean_0;

		// Token: 0x0400512D RID: 20781
		private static readonly IntPtr NativeMethodInfoPtr_get_GrownMushroomCount_Public_get_Int32_0;

		// Token: 0x0400512E RID: 20782
		private static readonly IntPtr NativeMethodInfoPtr_get_SnipSound_Public_get_AudioSourceController_0;

		// Token: 0x0400512F RID: 20783
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedQuality_Public_get_Single_0;

		// Token: 0x04005130 RID: 20784
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedQuality_Private_set_Void_Single_0;

		// Token: 0x04005131 RID: 20785
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04005132 RID: 20786
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x04005133 RID: 20787
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005134 RID: 20788
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04005135 RID: 20789
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x04005136 RID: 20790
		private static readonly IntPtr NativeMethodInfoPtr_CheckTemperature_Private_Void_0;

		// Token: 0x04005137 RID: 20791
		private static readonly IntPtr NativeMethodInfoPtr_OnTimeSkipped_Private_Void_Int32_0;

		// Token: 0x04005138 RID: 20792
		private static readonly IntPtr NativeMethodInfoPtr_SetColonyVisible_Public_Void_Boolean_0;

		// Token: 0x04005139 RID: 20793
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentGrowthRate_Private_Single_0;

		// Token: 0x0400513A RID: 20794
		private static readonly IntPtr NativeMethodInfoPtr_ChangeGrowthPercentage_Private_Void_Single_0;

		// Token: 0x0400513B RID: 20795
		private static readonly IntPtr NativeMethodInfoPtr_SetFullyGrown_Public_Void_0;

		// Token: 0x0400513C RID: 20796
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowthPercentage_Local_Private_Void_NetworkConnection_Single_0;

		// Token: 0x0400513D RID: 20797
		private static readonly IntPtr NativeMethodInfoPtr_SetGrowthPercentage_Private_Void_Single_0;

		// Token: 0x0400513E RID: 20798
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuality_Private_Void_Single_0;

		// Token: 0x0400513F RID: 20799
		private static readonly IntPtr NativeMethodInfoPtr_AddShroomAtPosition_Server_Public_Void_Int32_0;

		// Token: 0x04005140 RID: 20800
		private static readonly IntPtr NativeMethodInfoPtr_AddShroomAtPosition_Local_Private_Void_Int32_0;

		// Token: 0x04005141 RID: 20801
		private static readonly IntPtr NativeMethodInfoPtr_AddShroomAtPosition_Private_Void_Int32_0;

		// Token: 0x04005142 RID: 20802
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShroom_Server_Public_Void_Int32_0;

		// Token: 0x04005143 RID: 20803
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRandomShroom_Public_Void_0;

		// Token: 0x04005144 RID: 20804
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShoom_Client_Private_Void_Int32_0;

		// Token: 0x04005145 RID: 20805
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShroom_Private_Void_Int32_0;

		// Token: 0x04005146 RID: 20806
		private static readonly IntPtr NativeMethodInfoPtr_RemoveShroom_Private_Void_GrowingMushroom_0;

		// Token: 0x04005147 RID: 20807
		private static readonly IntPtr NativeMethodInfoPtr_SetFullyHarvested_Public_Void_0;

		// Token: 0x04005148 RID: 20808
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomAvailableAlignmentIndex_Private_Int32_0;

		// Token: 0x04005149 RID: 20809
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedShroom_Public_ShroomInstance_Int32_0;

		// Token: 0x0400514A RID: 20810
		private static readonly IntPtr NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0;

		// Token: 0x0400514B RID: 20811
		private static readonly IntPtr NativeMethodInfoPtr_SetColonyState_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0;

		// Token: 0x0400514C RID: 20812
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_ShroomColonyData_0;

		// Token: 0x0400514D RID: 20813
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ShroomColonyData_0;

		// Token: 0x0400514E RID: 20814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400514F RID: 20815
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005150 RID: 20816
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005151 RID: 20817
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005152 RID: 20818
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetFullyGrown_2166136261_Private_Void_0;

		// Token: 0x04005153 RID: 20819
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetFullyGrown_2166136261_Public_Void_0;

		// Token: 0x04005154 RID: 20820
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetFullyGrown_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005155 RID: 20821
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x04005156 RID: 20822
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x04005157 RID: 20823
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005158 RID: 20824
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetGrowthPercentage_Local_530160725_Private_Void_NetworkConnection_Single_0;

		// Token: 0x04005159 RID: 20825
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetGrowthPercentage_Local_530160725_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400515A RID: 20826
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddShroomAtPosition_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x0400515B RID: 20827
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x0400515C RID: 20828
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddShroomAtPosition_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400515D RID: 20829
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0;

		// Token: 0x0400515E RID: 20830
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddShroomAtPosition_Local_3316948804_Private_Void_Int32_0;

		// Token: 0x0400515F RID: 20831
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddShroomAtPosition_Local_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005160 RID: 20832
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveShroom_Server_3316948804_Private_Void_Int32_0;

		// Token: 0x04005161 RID: 20833
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveShroom_Server_3316948804_Public_Void_Int32_0;

		// Token: 0x04005162 RID: 20834
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveShroom_Server_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005163 RID: 20835
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RemoveShoom_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x04005164 RID: 20836
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveShoom_Client_3316948804_Private_Void_Int32_0;

		// Token: 0x04005165 RID: 20837
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RemoveShoom_Client_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005166 RID: 20838
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetColonyState_4288818029_Private_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0;

		// Token: 0x04005167 RID: 20839
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetColonyState_4288818029_Public_Void_NetworkConnection_Il2CppStructArray_1_Int32_Single_Single_0;

		// Token: 0x04005168 RID: 20840
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetColonyState_4288818029_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005169 RID: 20841
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
