using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Law;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Police;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000328 RID: 808
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x060042F8 RID: 17144 RVA: 0x0015FF84 File Offset: 0x0015E184
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerCrimeData()
		{
			Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerCrimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr);
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_INVESTIGATING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SEARCH_TIME_LETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_ARRESTING");
			PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "ESCALATION_TIME_NONLETHAL");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MIN");
			PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "SHOT_COOLDOWN_MAX");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIFETIME");
			PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VEHICLE_COLLISION_LIMIT");
			PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NearestOfficer");
			PlayerCrimeData.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Player");
			PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "onPursuitEscapedSound");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_Pursuers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Pursuers");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentArrestProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<CurrentBodySearchProgress>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__MinsSinceLastArrested_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<MinsSinceLastArrested>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSincePursuitStart");
			PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "CurrentPursuitLevelDuration");
			PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "TimeSinceSighted");
			PlayerCrimeData.NativeFieldInfoPtr_Crimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Crimes");
			PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "BodySearchPending");
			PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<TimeSinceLastBodySearch>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "<EvadedArrest>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_onPursuitLevelChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "onPursuitLevelChange");
			PlayerCrimeData.NativeFieldInfoPtr_Collisions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "Collisions");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<CurrentPursuitLevel>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "syncVar___<LastKnownPosition>k__BackingField");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted");
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671983);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671984);
			PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671985);
			PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671986);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671987);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671988);
			PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671989);
			PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671990);
			PlayerCrimeData.NativeMethodInfoPtr_get_MinsSinceLastArrested_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671991);
			PlayerCrimeData.NativeMethodInfoPtr_set_MinsSinceLastArrested_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671992);
			PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671993);
			PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671994);
			PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671995);
			PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671996);
			PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671997);
			PlayerCrimeData.NativeMethodInfoPtr_OnPlayerFreed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671998);
			PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100671999);
			PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672000);
			PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672001);
			PlayerCrimeData.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672002);
			PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672003);
			PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672004);
			PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Server_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672005);
			PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672006);
			PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672007);
			PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672008);
			PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672009);
			PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672010);
			PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672011);
			PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672012);
			PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672013);
			PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672014);
			PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672015);
			PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672016);
			PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672017);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672018);
			PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672019);
			PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672020);
			PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672021);
			PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672022);
			PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672023);
			PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672024);
			PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672025);
			PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__78_0_Private_Single_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672026);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672027);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672028);
			PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672029);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672030);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672031);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672032);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672033);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672034);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_SetPursuitLevel_Server_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672035);
			PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672036);
			PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672037);
			PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672038);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672039);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672040);
			PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672041);
			PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672042);
			PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672043);
			PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, 100672044);
		}

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x060042F9 RID: 17145 RVA: 0x0016070C File Offset: 0x0015E90C
		// (set) Token: 0x060042FA RID: 17146 RVA: 0x00160748 File Offset: 0x0015E948
		public unsafe PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 56794, RefRangeEnd = 56832, XrefRangeStart = 56794, XrefRangeEnd = 56832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161176, XrefRangeEnd = 161183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x060042FB RID: 17147 RVA: 0x00160788 File Offset: 0x0015E988
		// (set) Token: 0x060042FC RID: 17148 RVA: 0x001607C4 File Offset: 0x0015E9C4
		public unsafe Vector3 LastKnownPosition
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 161183, RefRangeEnd = 161192, XrefRangeStart = 161183, XrefRangeEnd = 161183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161192, XrefRangeEnd = 161200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x060042FD RID: 17149 RVA: 0x00160804 File Offset: 0x0015EA04
		// (set) Token: 0x060042FE RID: 17150 RVA: 0x00160840 File Offset: 0x0015EA40
		public unsafe float CurrentArrestProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x060042FF RID: 17151 RVA: 0x00160880 File Offset: 0x0015EA80
		// (set) Token: 0x06004300 RID: 17152 RVA: 0x001608BC File Offset: 0x0015EABC
		public unsafe float CurrentBodySearchProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x06004301 RID: 17153 RVA: 0x001608FC File Offset: 0x0015EAFC
		// (set) Token: 0x06004302 RID: 17154 RVA: 0x00160938 File Offset: 0x0015EB38
		public unsafe int MinsSinceLastArrested
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_MinsSinceLastArrested_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_MinsSinceLastArrested_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x06004303 RID: 17155 RVA: 0x00160978 File Offset: 0x0015EB78
		// (set) Token: 0x06004304 RID: 17156 RVA: 0x001609B4 File Offset: 0x0015EBB4
		public unsafe float TimeSinceLastBodySearch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x06004305 RID: 17157 RVA: 0x001609F4 File Offset: 0x0015EBF4
		// (set) Token: 0x06004306 RID: 17158 RVA: 0x00160A30 File Offset: 0x0015EC30
		public unsafe bool EvadedArrest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x00160A70 File Offset: 0x0015EC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161200, XrefRangeEnd = 161218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00160AAC File Offset: 0x0015ECAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161218, XrefRangeEnd = 161223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPlayerFreed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnPlayerFreed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x00160AE0 File Offset: 0x0015ECE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161223, XrefRangeEnd = 161274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x00160B14 File Offset: 0x0015ED14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161274, XrefRangeEnd = 161292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x00160B48 File Offset: 0x0015ED48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161292, XrefRangeEnd = 161370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x00160B84 File Offset: 0x0015ED84
		[CallerCount(0)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x00160BB8 File Offset: 0x0015EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161370, XrefRangeEnd = 161389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00160BF4 File Offset: 0x0015EDF4
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 161423, RefRangeEnd = 161454, XrefRangeStart = 161389, XrefRangeEnd = 161423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x00160C34 File Offset: 0x0015EE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161454, XrefRangeEnd = 161476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPursuitLevel_Server(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetPursuitLevel_Server_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x00160C74 File Offset: 0x0015EE74
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 161494, RefRangeEnd = 161505, XrefRangeStart = 161476, XrefRangeEnd = 161494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Escalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Escalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x00160CA8 File Offset: 0x0015EEA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161509, RefRangeEnd = 161510, XrefRangeStart = 161505, XrefRangeEnd = 161509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deescalate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Deescalate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x00160CDC File Offset: 0x0015EEDC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161532, RefRangeEnd = 161537, XrefRangeStart = 161510, XrefRangeEnd = 161532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x00160D1C File Offset: 0x0015EF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161539, RefRangeEnd = 161540, XrefRangeStart = 161537, XrefRangeEnd = 161539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetArrestProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x00160D5C File Offset: 0x0015EF5C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161540, RefRangeEnd = 161543, XrefRangeStart = 161540, XrefRangeEnd = 161540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetBodysearchCooldown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x00160D90 File Offset: 0x0015EF90
		[CallerCount(0)]
		public unsafe void SetBodySearchProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x00160DD0 File Offset: 0x0015EFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161543, XrefRangeEnd = 161545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDie()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnDie_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004317 RID: 17175 RVA: 0x00160E04 File Offset: 0x0015F004
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 161572, RefRangeEnd = 161589, XrefRangeStart = 161545, XrefRangeEnd = 161572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCrime(Crime crime, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x00160E54 File Offset: 0x0015F054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161592, RefRangeEnd = 161594, XrefRangeStart = 161589, XrefRangeEnd = 161592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCrimes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_ClearCrimes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x00160E88 File Offset: 0x0015F088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161606, RefRangeEnd = 161608, XrefRangeStart = 161594, XrefRangeEnd = 161606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCrimeOnRecord(Type crime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(crime);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x00160ED8 File Offset: 0x0015F0D8
		[CallerCount(0)]
		public unsafe void SetEvaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_SetEvaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x00160F0C File Offset: 0x0015F10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161608, XrefRangeEnd = 161612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_OnSleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x00160F40 File Offset: 0x0015F140
		[CallerCount(0)]
		public unsafe void UpdateEscalation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateEscalation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x00160F74 File Offset: 0x0015F174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161612, XrefRangeEnd = 161631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_UpdateTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x00160FA8 File Offset: 0x0015F1A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161631, XrefRangeEnd = 161645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeoutPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_TimeoutPursuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600431F RID: 17183 RVA: 0x00160FDC File Offset: 0x0015F1DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161645, RefRangeEnd = 161647, XrefRangeStart = 161645, XrefRangeEnd = 161645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetSearchTime_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x00161018 File Offset: 0x0015F218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161647, XrefRangeEnd = 161683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetShotAccuracyMultiplier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x00161054 File Offset: 0x0015F254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161694, RefRangeEnd = 161695, XrefRangeStart = 161683, XrefRangeEnd = 161694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RecordVehicleCollision(NPC victim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x00161098 File Offset: 0x0015F298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161695, XrefRangeEnd = 161716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckNearestOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x001610CC File Offset: 0x0015F2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161716, XrefRangeEnd = 161740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerCrimeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x00161108 File Offset: 0x0015F308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161740, XrefRangeEnd = 161745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _CheckNearestOfficer_b__78_0(PoliceOfficer x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr__CheckNearestOfficer_b__78_0_Private_Single_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x00161158 File Offset: 0x0015F358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161745, XrefRangeEnd = 161790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x00161194 File Offset: 0x0015F394
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x001611D0 File Offset: 0x0015F3D0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0016120C File Offset: 0x0015F40C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161804, RefRangeEnd = 161806, XrefRangeStart = 161790, XrefRangeEnd = 161804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x0016124C File Offset: 0x0015F44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161813, RefRangeEnd = 161814, XrefRangeStart = 161806, XrefRangeEnd = 161813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x0016128C File Offset: 0x0015F48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161814, XrefRangeEnd = 161821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x001612F0 File Offset: 0x0015F4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161821, XrefRangeEnd = 161831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetPursuitLevel_Server_2979171596(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Server_SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x00161330 File Offset: 0x0015F530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161849, RefRangeEnd = 161852, XrefRangeStart = 161831, XrefRangeEnd = 161849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetPursuitLevel_Server_2979171596(PlayerCrimeData.EPursuitLevel level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x00161370 File Offset: 0x0015F570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161852, XrefRangeEnd = 161856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetPursuitLevel_Server_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Server_SetPursuitLevel_Server_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x001613D4 File Offset: 0x0015F5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161856, XrefRangeEnd = 161866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x00161414 File Offset: 0x0015F614
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 161875, RefRangeEnd = 161878, XrefRangeStart = 161866, XrefRangeEnd = 161875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref resetTimeSinceSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x00161454 File Offset: 0x0015F654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161878, XrefRangeEnd = 161881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x06004331 RID: 17201 RVA: 0x001614A4 File Offset: 0x0015F6A4
		// (set) Token: 0x06004332 RID: 17202 RVA: 0x001614E0 File Offset: 0x0015F6E0
		public unsafe PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 56794, RefRangeEnd = 56832, XrefRangeStart = 56794, XrefRangeEnd = 56832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161881, XrefRangeEnd = 161889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0016152C File Offset: 0x0015F72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161889, XrefRangeEnd = 161891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerCrimeData.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x001615A0 File Offset: 0x0015F7A0
		// (set) Token: 0x06004335 RID: 17205 RVA: 0x001615DC File Offset: 0x0015F7DC
		public unsafe Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 161183, RefRangeEnd = 161192, XrefRangeStart = 161183, XrefRangeEnd = 161192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161891, XrefRangeEnd = 161899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x00161628 File Offset: 0x0015F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161899, XrefRangeEnd = 161916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004337 RID: 17207 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		public PlayerCrimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x0016165C File Offset: 0x0015F85C
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x00020AC1 File Offset: 0x0001ECC1
		public unsafe static float SEARCH_TIME_INVESTIGATING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING, (void*)(&value));
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x00161678 File Offset: 0x0015F878
		// (set) Token: 0x0600433B RID: 17211 RVA: 0x00020ACF File Offset: 0x0001ECCF
		public unsafe static float SEARCH_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x00161694 File Offset: 0x0015F894
		// (set) Token: 0x0600433D RID: 17213 RVA: 0x00020ADD File Offset: 0x0001ECDD
		public unsafe static float SEARCH_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x001616B0 File Offset: 0x0015F8B0
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x00020AEB File Offset: 0x0001ECEB
		public unsafe static float SEARCH_TIME_LETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SEARCH_TIME_LETHAL, (void*)(&value));
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x001616CC File Offset: 0x0015F8CC
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x00020AF9 File Offset: 0x0001ECF9
		public unsafe static float ESCALATION_TIME_ARRESTING
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING, (void*)(&value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x001616E8 File Offset: 0x0015F8E8
		// (set) Token: 0x06004343 RID: 17219 RVA: 0x00020B07 File Offset: 0x0001ED07
		public unsafe static float ESCALATION_TIME_NONLETHAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL, (void*)(&value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x00161704 File Offset: 0x0015F904
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x00020B15 File Offset: 0x0001ED15
		public unsafe static float SHOT_COOLDOWN_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MIN, (void*)(&value));
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00161720 File Offset: 0x0015F920
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x00020B23 File Offset: 0x0001ED23
		public unsafe static float SHOT_COOLDOWN_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_SHOT_COOLDOWN_MAX, (void*)(&value));
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x0016173C File Offset: 0x0015F93C
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x00020B31 File Offset: 0x0001ED31
		public unsafe static float VEHICLE_COLLISION_LIFETIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME, (void*)(&value));
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x00161758 File Offset: 0x0015F958
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x00020B3F File Offset: 0x0001ED3F
		public unsafe static float VEHICLE_COLLISION_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerCrimeData.NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x00161774 File Offset: 0x0015F974
		// (set) Token: 0x0600434D RID: 17229 RVA: 0x00020B4D File Offset: 0x0001ED4D
		public unsafe PoliceOfficer NearestOfficer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_NearestOfficer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x001617A4 File Offset: 0x0015F9A4
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x00020B6C File Offset: 0x0001ED6C
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x001617D4 File Offset: 0x0015F9D4
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x00020B8B File Offset: 0x0001ED8B
		public unsafe AudioSourceController onPursuitEscapedSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitEscapedSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x00161804 File Offset: 0x0015FA04
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x00020BAA File Offset: 0x0001EDAA
		public unsafe PlayerCrimeData.EPursuitLevel _CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0016182C File Offset: 0x0015FA2C
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x00020BC5 File Offset: 0x0001EDC5
		public unsafe Vector3 _LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__LastKnownPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x00161854 File Offset: 0x0015FA54
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		public unsafe List<PoliceOfficer> Pursuers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Pursuers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x00161884 File Offset: 0x0015FA84
		// (set) Token: 0x06004359 RID: 17241 RVA: 0x00020BFF File Offset: 0x0001EDFF
		public unsafe float _CurrentArrestProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x001618AC File Offset: 0x0015FAAC
		// (set) Token: 0x0600435B RID: 17243 RVA: 0x00020C1A File Offset: 0x0001EE1A
		public unsafe float _CurrentBodySearchProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x001618D4 File Offset: 0x0015FAD4
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x00020C35 File Offset: 0x0001EE35
		public unsafe int _MinsSinceLastArrested_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__MinsSinceLastArrested_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__MinsSinceLastArrested_k__BackingField)) = value;
			}
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x001618FC File Offset: 0x0015FAFC
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x00020C50 File Offset: 0x0001EE50
		public unsafe float TimeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSincePursuitStart)) = value;
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x00161924 File Offset: 0x0015FB24
		// (set) Token: 0x06004361 RID: 17249 RVA: 0x00020C6B File Offset: 0x0001EE6B
		public unsafe float CurrentPursuitLevelDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_CurrentPursuitLevelDuration)) = value;
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x0016194C File Offset: 0x0015FB4C
		// (set) Token: 0x06004363 RID: 17251 RVA: 0x00020C86 File Offset: 0x0001EE86
		public unsafe float TimeSinceSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_TimeSinceSighted)) = value;
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x00161974 File Offset: 0x0015FB74
		// (set) Token: 0x06004365 RID: 17253 RVA: 0x00020CA1 File Offset: 0x0001EEA1
		public unsafe Dictionary<Crime, int> Crimes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Crime, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Crimes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x001619A4 File Offset: 0x0015FBA4
		// (set) Token: 0x06004367 RID: 17255 RVA: 0x00020CC0 File Offset: 0x0001EEC0
		public unsafe bool BodySearchPending
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_BodySearchPending)) = value;
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x001619CC File Offset: 0x0015FBCC
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x00020CDB File Offset: 0x0001EEDB
		public unsafe float _TimeSinceLastBodySearch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField)) = value;
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x001619F4 File Offset: 0x0015FBF4
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x00020CF6 File Offset: 0x0001EEF6
		public unsafe bool _EvadedArrest_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr__EvadedArrest_k__BackingField)) = value;
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x00161A1C File Offset: 0x0015FC1C
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x00020D11 File Offset: 0x0001EF11
		public unsafe Action<PlayerCrimeData.EPursuitLevel, PlayerCrimeData.EPursuitLevel> onPursuitLevelChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitLevelChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlayerCrimeData.EPursuitLevel, PlayerCrimeData.EPursuitLevel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_onPursuitLevelChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x00161A4C File Offset: 0x0015FC4C
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x00020D30 File Offset: 0x0001EF30
		public unsafe List<PlayerCrimeData.VehicleCollisionInstance> Collisions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerCrimeData.VehicleCollisionInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_Collisions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x00161A7C File Offset: 0x0015FC7C
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x00020D4F File Offset: 0x0001EF4F
		public unsafe SyncVar<PlayerCrimeData.EPursuitLevel> syncVar____CurrentPursuitLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<PlayerCrimeData.EPursuitLevel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x00161AAC File Offset: 0x0015FCAC
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x00020D6E File Offset: 0x0001EF6E
		public unsafe SyncVar<Vector3> syncVar____LastKnownPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x00161ADC File Offset: 0x0015FCDC
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x00020D8D File Offset: 0x0001EF8D
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x00161B04 File Offset: 0x0015FD04
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D9B RID: 11675
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_INVESTIGATING;

		// Token: 0x04002D9C RID: 11676
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_ARRESTING;

		// Token: 0x04002D9D RID: 11677
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_NONLETHAL;

		// Token: 0x04002D9E RID: 11678
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_TIME_LETHAL;

		// Token: 0x04002D9F RID: 11679
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_ARRESTING;

		// Token: 0x04002DA0 RID: 11680
		private static readonly IntPtr NativeFieldInfoPtr_ESCALATION_TIME_NONLETHAL;

		// Token: 0x04002DA1 RID: 11681
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MIN;

		// Token: 0x04002DA2 RID: 11682
		private static readonly IntPtr NativeFieldInfoPtr_SHOT_COOLDOWN_MAX;

		// Token: 0x04002DA3 RID: 11683
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIFETIME;

		// Token: 0x04002DA4 RID: 11684
		private static readonly IntPtr NativeFieldInfoPtr_VEHICLE_COLLISION_LIMIT;

		// Token: 0x04002DA5 RID: 11685
		private static readonly IntPtr NativeFieldInfoPtr_NearestOfficer;

		// Token: 0x04002DA6 RID: 11686
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x04002DA7 RID: 11687
		private static readonly IntPtr NativeFieldInfoPtr_onPursuitEscapedSound;

		// Token: 0x04002DA8 RID: 11688
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPursuitLevel_k__BackingField;

		// Token: 0x04002DA9 RID: 11689
		private static readonly IntPtr NativeFieldInfoPtr__LastKnownPosition_k__BackingField;

		// Token: 0x04002DAA RID: 11690
		private static readonly IntPtr NativeFieldInfoPtr_Pursuers;

		// Token: 0x04002DAB RID: 11691
		private static readonly IntPtr NativeFieldInfoPtr__CurrentArrestProgress_k__BackingField;

		// Token: 0x04002DAC RID: 11692
		private static readonly IntPtr NativeFieldInfoPtr__CurrentBodySearchProgress_k__BackingField;

		// Token: 0x04002DAD RID: 11693
		private static readonly IntPtr NativeFieldInfoPtr__MinsSinceLastArrested_k__BackingField;

		// Token: 0x04002DAE RID: 11694
		private static readonly IntPtr NativeFieldInfoPtr_TimeSincePursuitStart;

		// Token: 0x04002DAF RID: 11695
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPursuitLevelDuration;

		// Token: 0x04002DB0 RID: 11696
		private static readonly IntPtr NativeFieldInfoPtr_TimeSinceSighted;

		// Token: 0x04002DB1 RID: 11697
		private static readonly IntPtr NativeFieldInfoPtr_Crimes;

		// Token: 0x04002DB2 RID: 11698
		private static readonly IntPtr NativeFieldInfoPtr_BodySearchPending;

		// Token: 0x04002DB3 RID: 11699
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastBodySearch_k__BackingField;

		// Token: 0x04002DB4 RID: 11700
		private static readonly IntPtr NativeFieldInfoPtr__EvadedArrest_k__BackingField;

		// Token: 0x04002DB5 RID: 11701
		private static readonly IntPtr NativeFieldInfoPtr_onPursuitLevelChange;

		// Token: 0x04002DB6 RID: 11702
		private static readonly IntPtr NativeFieldInfoPtr_Collisions;

		// Token: 0x04002DB7 RID: 11703
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____CurrentPursuitLevel_k__BackingField;

		// Token: 0x04002DB8 RID: 11704
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____LastKnownPosition_k__BackingField;

		// Token: 0x04002DB9 RID: 11705
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002DBA RID: 11706
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002DBB RID: 11707
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPursuitLevel_Public_get_EPursuitLevel_0;

		// Token: 0x04002DBC RID: 11708
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPursuitLevel_Protected_set_Void_EPursuitLevel_0;

		// Token: 0x04002DBD RID: 11709
		private static readonly IntPtr NativeMethodInfoPtr_get_LastKnownPosition_Public_get_Vector3_0;

		// Token: 0x04002DBE RID: 11710
		private static readonly IntPtr NativeMethodInfoPtr_set_LastKnownPosition_Protected_set_Void_Vector3_0;

		// Token: 0x04002DBF RID: 11711
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentArrestProgress_Public_get_Single_0;

		// Token: 0x04002DC0 RID: 11712
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentArrestProgress_Protected_set_Void_Single_0;

		// Token: 0x04002DC1 RID: 11713
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentBodySearchProgress_Public_get_Single_0;

		// Token: 0x04002DC2 RID: 11714
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentBodySearchProgress_Protected_set_Void_Single_0;

		// Token: 0x04002DC3 RID: 11715
		private static readonly IntPtr NativeMethodInfoPtr_get_MinsSinceLastArrested_Public_get_Int32_0;

		// Token: 0x04002DC4 RID: 11716
		private static readonly IntPtr NativeMethodInfoPtr_set_MinsSinceLastArrested_Public_set_Void_Int32_0;

		// Token: 0x04002DC5 RID: 11717
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastBodySearch_Public_get_Single_0;

		// Token: 0x04002DC6 RID: 11718
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastBodySearch_Public_set_Void_Single_0;

		// Token: 0x04002DC7 RID: 11719
		private static readonly IntPtr NativeMethodInfoPtr_get_EvadedArrest_Public_get_Boolean_0;

		// Token: 0x04002DC8 RID: 11720
		private static readonly IntPtr NativeMethodInfoPtr_set_EvadedArrest_Protected_set_Void_Boolean_0;

		// Token: 0x04002DC9 RID: 11721
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002DCA RID: 11722
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerFreed_Private_Void_0;

		// Token: 0x04002DCB RID: 11723
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04002DCC RID: 11724
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002DCD RID: 11725
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002DCE RID: 11726
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04002DCF RID: 11727
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04002DD0 RID: 11728
		private static readonly IntPtr NativeMethodInfoPtr_SetPursuitLevel_Public_Void_EPursuitLevel_0;

		// Token: 0x04002DD1 RID: 11729
		private static readonly IntPtr NativeMethodInfoPtr_SetPursuitLevel_Server_Private_Void_EPursuitLevel_0;

		// Token: 0x04002DD2 RID: 11730
		private static readonly IntPtr NativeMethodInfoPtr_Escalate_Public_Void_0;

		// Token: 0x04002DD3 RID: 11731
		private static readonly IntPtr NativeMethodInfoPtr_Deescalate_Public_Void_0;

		// Token: 0x04002DD4 RID: 11732
		private static readonly IntPtr NativeMethodInfoPtr_RecordLastKnownPosition_Public_Void_Boolean_0;

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_SetArrestProgress_Public_Void_Single_0;

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeMethodInfoPtr_ResetBodysearchCooldown_Public_Void_0;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeMethodInfoPtr_SetBodySearchProgress_Public_Void_Single_0;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeMethodInfoPtr_OnDie_Private_Void_0;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeMethodInfoPtr_AddCrime_Public_Void_Crime_Int32_0;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeMethodInfoPtr_ClearCrimes_Public_Void_0;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeMethodInfoPtr_IsCrimeOnRecord_Public_Boolean_Type_0;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeMethodInfoPtr_SetEvaded_Public_Void_0;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeMethodInfoPtr_OnSleepStart_Private_Void_0;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEscalation_Private_Void_0;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Private_Void_0;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutPursuit_Private_Void_0;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Public_Single_0;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeMethodInfoPtr_GetShotAccuracyMultiplier_Public_Single_0;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeMethodInfoPtr_RecordVehicleCollision_Public_Void_NPC_0;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeMethodInfoPtr_CheckNearestOfficer_Private_Void_0;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr__CheckNearestOfficer_b__78_0_Private_Single_PoliceOfficer_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_LastKnownPosition_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_LastKnownPosition_4276783012_Protected_Void_Vector3_0;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_LastKnownPosition_4276783012_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPursuitLevel_Server_2979171596_Private_Void_EPursuitLevel_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetPursuitLevel_Server_2979171596_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_RecordLastKnownPosition_1140765316_Private_Void_Boolean_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RecordLastKnownPosition_1140765316_Public_Void_Boolean_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_RecordLastKnownPosition_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__CurrentPursuitLevel_k__BackingField_Public_get_EPursuitLevel_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__CurrentPursuitLevel_k__BackingField_Public_set_Void_EPursuitLevel_Boolean_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_PlayerScripts_PlayerCrimeData_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__LastKnownPosition_k__BackingField_Public_get_Vector3_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__LastKnownPosition_k__BackingField_Public_set_Void_Vector3_Boolean_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A53 RID: 2643
		public class VehicleCollisionInstance : Il2CppSystem.Object
		{
			// Token: 0x0600E03E RID: 57406 RVA: 0x00372674 File Offset: 0x00370874
			// Note: this type is marked as 'beforefieldinit'.
			static VehicleCollisionInstance()
			{
				Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerCrimeData>.NativeClassPtr, "VehicleCollisionInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr);
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "Victim");
				PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, "TimeSince");
				PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr, 100672045);
			}

			// Token: 0x0600E03F RID: 57407 RVA: 0x003726DC File Offset: 0x003708DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161174, XrefRangeEnd = 161176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VehicleCollisionInstance(NPC victim, float timeSince) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerCrimeData.VehicleCollisionInstance>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(victim);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeSince;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerCrimeData.VehicleCollisionInstance.NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E040 RID: 57408 RVA: 0x00069A7B File Offset: 0x00067C7B
			public VehicleCollisionInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004445 RID: 17477
			// (get) Token: 0x0600E041 RID: 57409 RVA: 0x00372738 File Offset: 0x00370938
			// (set) Token: 0x0600E042 RID: 57410 RVA: 0x00069A84 File Offset: 0x00067C84
			public unsafe NPC Victim
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_Victim), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004446 RID: 17478
			// (get) Token: 0x0600E043 RID: 57411 RVA: 0x00372768 File Offset: 0x00370968
			// (set) Token: 0x0600E044 RID: 57412 RVA: 0x00069AA3 File Offset: 0x00067CA3
			public unsafe float TimeSince
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerCrimeData.VehicleCollisionInstance.NativeFieldInfoPtr_TimeSince)) = value;
				}
			}

			// Token: 0x040098AA RID: 39082
			private static readonly IntPtr NativeFieldInfoPtr_Victim;

			// Token: 0x040098AB RID: 39083
			private static readonly IntPtr NativeFieldInfoPtr_TimeSince;

			// Token: 0x040098AC RID: 39084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_Single_0;
		}

		// Token: 0x02000A54 RID: 2644
		[OriginalName("Assembly-CSharp.dll", "", "EPursuitLevel")]
		public enum EPursuitLevel
		{
			// Token: 0x040098AE RID: 39086
			None,
			// Token: 0x040098AF RID: 39087
			Investigating,
			// Token: 0x040098B0 RID: 39088
			Arresting,
			// Token: 0x040098B1 RID: 39089
			NonLethal,
			// Token: 0x040098B2 RID: 39090
			Lethal
		}
	}
}
