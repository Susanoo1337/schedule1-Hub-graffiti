using System;
using System.Runtime.InteropServices;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.NPCs.Behaviour;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Combat
{
	// Token: 0x02000704 RID: 1796
	public class CombatBehaviour : Il2CppScheduleOne.NPCs.Behaviour.Behaviour
	{
		// Token: 0x0600ACA5 RID: 44197 RVA: 0x002D67D8 File Offset: 0x002D49D8
		// Note: this type is marked as 'beforefieldinit'.
		static CombatBehaviour()
		{
			Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Combat", "CombatBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr);
			CombatBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "RECENT_VISIBILITY_THRESHOLD");
			CombatBehaviour.NativeFieldInfoPtr_REPOSITION_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "REPOSITION_TIME");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MIN");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_RADIUS_MAX");
			CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "SEARCH_SPEED");
			CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "CONSECUTIVE_MISS_ACCURACY_BOOST");
			CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "REACHED_DESTINATION_DISTANCE");
			CombatBehaviour.NativeFieldInfoPtr_DelayBeforeFirstAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DelayBeforeFirstAttack");
			CombatBehaviour.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<Target>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsSearching>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<TimeSinceTargetReacquired>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DEBUG");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpRange");
			CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "GiveUpAfterSuccessfulHits");
			CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "PlayAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultMovementSpeed");
			CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "VirtualPunchWeapon");
			CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DefaultSearchTime");
			CombatBehaviour.NativeFieldInfoPtr_TargetVelocityTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "TargetVelocityTracker");
			CombatBehaviour.NativeFieldInfoPtr_CombatOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "CombatOnStart");
			CombatBehaviour.NativeFieldInfoPtr_DebugTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "DebugTarget");
			CombatBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsTargetRecentlyVisible>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<IsTargetImmediatelyVisible>k__BackingField");
			CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "lastKnownTargetPosition");
			CombatBehaviour.NativeFieldInfoPtr_timeSinceLastReposition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeSinceLastReposition");
			CombatBehaviour.NativeFieldInfoPtr_timeWithinAttackRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "timeWithinAttackRange");
			CombatBehaviour.NativeFieldInfoPtr_visionEventReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "visionEventReceived");
			CombatBehaviour.NativeFieldInfoPtr__timeOnCombatStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "_timeOnCombatStart");
			CombatBehaviour.NativeFieldInfoPtr_currentWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentWeapon");
			CombatBehaviour.NativeFieldInfoPtr_successfulHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "successfulHits");
			CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "consecutiveMissedShots");
			CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "rangedWeaponRoutine");
			CombatBehaviour.NativeFieldInfoPtr_searchRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "searchRoutine");
			CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "currentSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "hasSearchDestination");
			CombatBehaviour.NativeFieldInfoPtr_nextAngryVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "nextAngryVO");
			CombatBehaviour.NativeFieldInfoPtr_onSuccessfulHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "onSuccessfulHit");
			CombatBehaviour.NativeFieldInfoPtr__defaultWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "_defaultWeapon");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted");
			CombatBehaviour.NativeMethodInfoPtr_get_Target_Public_get_ICombatTargetable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686074);
			CombatBehaviour.NativeMethodInfoPtr_set_Target_Protected_set_Void_ICombatTargetable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686075);
			CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686076);
			CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686077);
			CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686078);
			CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686079);
			CombatBehaviour.NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686080);
			CombatBehaviour.NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686081);
			CombatBehaviour.NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686082);
			CombatBehaviour.NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686083);
			CombatBehaviour.NativeMethodInfoPtr_SetDefaultWeapon_Public_Void_AvatarWeapon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686084);
			CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686085);
			CombatBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686086);
			CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686087);
			CombatBehaviour.NativeMethodInfoPtr_SetTargetAndEnable_Server_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686088);
			CombatBehaviour.NativeMethodInfoPtr_SetTarget_Client_Protected_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686089);
			CombatBehaviour.NativeMethodInfoPtr_SetTarget_Protected_Virtual_New_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686090);
			CombatBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686091);
			CombatBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686092);
			CombatBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686093);
			CombatBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686094);
			CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686095);
			CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686096);
			CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686097);
			CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686098);
			CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686099);
			CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686100);
			CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686101);
			CombatBehaviour.NativeMethodInfoPtr_EnsureRangedWeaponRoutineIsRunning_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686102);
			CombatBehaviour.NativeMethodInfoPtr_GetPredictedFutureTargetPosition_Protected_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686103);
			CombatBehaviour.NativeMethodInfoPtr_SetDestination_Protected_Virtual_Void_Vector3_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686104);
			CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686105);
			CombatBehaviour.NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_New_Void_AvatarWeapon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686106);
			CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686107);
			CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686108);
			CombatBehaviour.NativeMethodInfoPtr_IsCurrentWeaponMelee_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686109);
			CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686110);
			CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686111);
			CombatBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686112);
			CombatBehaviour.NativeMethodInfoPtr_RepositionToRangedWeaponRange_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686113);
			CombatBehaviour.NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686114);
			CombatBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686115);
			CombatBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686116);
			CombatBehaviour.NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686117);
			CombatBehaviour.NativeMethodInfoPtr_TargetResighted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686118);
			CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686119);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetVisibleThisFrame_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686120);
			CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Protected_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686121);
			CombatBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686122);
			CombatBehaviour.NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686123);
			CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686124);
			CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686125);
			CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686126);
			CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686127);
			CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686128);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686129);
			CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetMeleeRange_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686130);
			CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Boolean_Vector3_Single_byref_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686131);
			CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686132);
			CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686133);
			CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686134);
			CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686135);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686136);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686137);
			CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686138);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTargetAndEnable_Server_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686139);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetAndEnable_Server_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686140);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTargetAndEnable_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686141);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686142);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_Client_1824087381_Protected_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686143);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686144);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Target_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686145);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Target_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686146);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686147);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686148);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686149);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686150);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686151);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686152);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686153);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686154);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686155);
			CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686156);
			CombatBehaviour.NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686157);
			CombatBehaviour.NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686158);
			CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, 100686159);
		}

		// Token: 0x170033EE RID: 13294
		// (get) Token: 0x0600ACA6 RID: 44198 RVA: 0x002D71F4 File Offset: 0x002D53F4
		// (set) Token: 0x0600ACA7 RID: 44199 RVA: 0x002D7234 File Offset: 0x002D5434
		public unsafe ICombatTargetable Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_Target_Public_get_ICombatTargetable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICombatTargetable>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_Target_Protected_set_Void_ICombatTargetable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033EF RID: 13295
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x002D7278 File Offset: 0x002D5478
		// (set) Token: 0x0600ACA9 RID: 44201 RVA: 0x002D72B4 File Offset: 0x002D54B4
		public unsafe bool IsSearching
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033F0 RID: 13296
		// (get) Token: 0x0600ACAA RID: 44202 RVA: 0x002D72F4 File Offset: 0x002D54F4
		// (set) Token: 0x0600ACAB RID: 44203 RVA: 0x002D7330 File Offset: 0x002D5530
		public unsafe float TimeSinceTargetReacquired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033F1 RID: 13297
		// (get) Token: 0x0600ACAC RID: 44204 RVA: 0x002D7370 File Offset: 0x002D5570
		// (set) Token: 0x0600ACAD RID: 44205 RVA: 0x002D73AC File Offset: 0x002D55AC
		public unsafe bool IsTargetRecentlyVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170033F2 RID: 13298
		// (get) Token: 0x0600ACAE RID: 44206 RVA: 0x002D73EC File Offset: 0x002D55EC
		// (set) Token: 0x0600ACAF RID: 44207 RVA: 0x002D7428 File Offset: 0x002D5628
		public unsafe bool IsTargetImmediatelyVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600ACB0 RID: 44208 RVA: 0x002D7468 File Offset: 0x002D5668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296034, XrefRangeEnd = 296035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultWeapon(AvatarWeapon weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetDefaultWeapon_Public_Void_AvatarWeapon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB1 RID: 44209 RVA: 0x002D74AC File Offset: 0x002D56AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296038, RefRangeEnd = 296039, XrefRangeStart = 296035, XrefRangeEnd = 296038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB2 RID: 44210 RVA: 0x002D74E8 File Offset: 0x002D56E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296039, XrefRangeEnd = 296055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB3 RID: 44211 RVA: 0x002D751C File Offset: 0x002D571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296055, XrefRangeEnd = 296060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB4 RID: 44212 RVA: 0x002D756C File Offset: 0x002D576C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 296083, RefRangeEnd = 296099, XrefRangeStart = 296060, XrefRangeEnd = 296083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetAndEnable_Server(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetTargetAndEnable_Server_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB5 RID: 44213 RVA: 0x002D75B0 File Offset: 0x002D57B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296137, RefRangeEnd = 296141, XrefRangeStart = 296099, XrefRangeEnd = 296137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTarget_Client(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetTarget_Client_Protected_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB6 RID: 44214 RVA: 0x002D7604 File Offset: 0x002D5804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296156, RefRangeEnd = 296157, XrefRangeStart = 296141, XrefRangeEnd = 296156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetTarget(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetTarget_Protected_Virtual_New_Void_NetworkObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB7 RID: 44215 RVA: 0x002D7654 File Offset: 0x002D5854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296164, RefRangeEnd = 296165, XrefRangeStart = 296157, XrefRangeEnd = 296164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB8 RID: 44216 RVA: 0x002D7690 File Offset: 0x002D5890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296166, RefRangeEnd = 296167, XrefRangeStart = 296165, XrefRangeEnd = 296166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACB9 RID: 44217 RVA: 0x002D76CC File Offset: 0x002D58CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296167, XrefRangeEnd = 296168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBA RID: 44218 RVA: 0x002D7708 File Offset: 0x002D5908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296168, XrefRangeEnd = 296169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBB RID: 44219 RVA: 0x002D7744 File Offset: 0x002D5944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296171, RefRangeEnd = 296172, XrefRangeStart = 296169, XrefRangeEnd = 296171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBC RID: 44220 RVA: 0x002D7780 File Offset: 0x002D5980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296172, XrefRangeEnd = 296208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBD RID: 44221 RVA: 0x002D77BC File Offset: 0x002D59BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296233, RefRangeEnd = 296234, XrefRangeStart = 296208, XrefRangeEnd = 296233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndCombat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_EndCombat_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBE RID: 44222 RVA: 0x002D77F8 File Offset: 0x002D59F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296250, RefRangeEnd = 296251, XrefRangeStart = 296234, XrefRangeEnd = 296250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACBF RID: 44223 RVA: 0x002D7834 File Offset: 0x002D5A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296251, XrefRangeEnd = 296253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC0 RID: 44224 RVA: 0x002D7868 File Offset: 0x002D5A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296253, XrefRangeEnd = 296258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLookAt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC1 RID: 44225 RVA: 0x002D78A4 File Offset: 0x002D5AA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296265, RefRangeEnd = 296269, XrefRangeStart = 296258, XrefRangeEnd = 296265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMovementSpeed(float speed, string label = "combat", int priority = 5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speed;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC2 RID: 44226 RVA: 0x002D7904 File Offset: 0x002D5B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296269, XrefRangeEnd = 296276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureRangedWeaponRoutineIsRunning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_EnsureRangedWeaponRoutineIsRunning_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC3 RID: 44227 RVA: 0x002D7938 File Offset: 0x002D5B38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296280, RefRangeEnd = 296281, XrefRangeStart = 296276, XrefRangeEnd = 296280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPredictedFutureTargetPosition(float lead_Min = 0f, float lead_Max = 2f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lead_Min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lead_Max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetPredictedFutureTargetPosition_Protected_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACC4 RID: 44228 RVA: 0x002D7990 File Offset: 0x002D5B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296281, XrefRangeEnd = 296290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetDestination(Vector3 position, bool teleportIfFail = true, float successThreshold = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref teleportIfFail;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref successThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetDestination_Protected_Virtual_Void_Vector3_Boolean_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC5 RID: 44229 RVA: 0x002D79F8 File Offset: 0x002D5BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296290, XrefRangeEnd = 296312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetWeapon(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC6 RID: 44230 RVA: 0x002D7A48 File Offset: 0x002D5C48
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnCurrentWeaponChanged(AvatarWeapon weapon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(weapon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_New_Void_AvatarWeapon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC7 RID: 44231 RVA: 0x002D7A98 File Offset: 0x002D5C98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296333, RefRangeEnd = 296335, XrefRangeStart = 296312, XrefRangeEnd = 296333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearWeapon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ClearWeapon_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACC8 RID: 44232 RVA: 0x002D7ACC File Offset: 0x002D5CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296335, XrefRangeEnd = 296349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ReadyToAttack(bool checkTarget = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref checkTarget;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x002D7B20 File Offset: 0x002D5D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296349, XrefRangeEnd = 296354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentWeaponMelee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsCurrentWeaponMelee_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x002D7B5C File Offset: 0x002D5D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296354, XrefRangeEnd = 296375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Attack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x002D7B98 File Offset: 0x002D5D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296375, XrefRangeEnd = 296376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SucessfulHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SucessfulHit_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACCC RID: 44236 RVA: 0x002D7BCC File Offset: 0x002D5DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296376, XrefRangeEnd = 296381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RangedWeaponRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x002D7C0C File Offset: 0x002D5E0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296386, RefRangeEnd = 296388, XrefRangeStart = 296381, XrefRangeEnd = 296386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RepositionToRangedWeaponRange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RepositionToRangedWeaponRange_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ACCE RID: 44238 RVA: 0x002D7C4C File Offset: 0x002D5E4C
		[CallerCount(0)]
		public unsafe virtual float GetIdealRangedWeaponDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x002D7C94 File Offset: 0x002D5E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296474, RefRangeEnd = 296475, XrefRangeStart = 296388, XrefRangeEnd = 296474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Shoot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_Shoot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x002D7CD0 File Offset: 0x002D5ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296487, RefRangeEnd = 296489, XrefRangeStart = 296475, XrefRangeEnd = 296487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWeaponRaised(bool raised)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref raised;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x002D7D10 File Offset: 0x002D5F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296506, RefRangeEnd = 296508, XrefRangeStart = 296489, XrefRangeEnd = 296506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTargetVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x002D7D44 File Offset: 0x002D5F44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296508, RefRangeEnd = 296509, XrefRangeStart = 296508, XrefRangeEnd = 296508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetResighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_TargetResighted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x002D7D80 File Offset: 0x002D5F80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296515, RefRangeEnd = 296516, XrefRangeStart = 296509, XrefRangeEnd = 296515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x002D7DB4 File Offset: 0x002D5FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetVisibleThisFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetVisibleThisFrame_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x002D7DF0 File Offset: 0x002D5FF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296523, RefRangeEnd = 296524, XrefRangeStart = 296516, XrefRangeEnd = 296523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Protected_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x002D7E34 File Offset: 0x002D6034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296547, RefRangeEnd = 296548, XrefRangeStart = 296524, XrefRangeEnd = 296547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetSpotted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x002D7E70 File Offset: 0x002D6070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296548, XrefRangeEnd = 296557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyServerTargetSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x002D7EA4 File Offset: 0x002D60A4
		[CallerCount(0)]
		public unsafe virtual float GetSearchTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x002D7EEC File Offset: 0x002D60EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296557, XrefRangeEnd = 296573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StartSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x002D7F20 File Offset: 0x002D6120
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296579, RefRangeEnd = 296580, XrefRangeStart = 296573, XrefRangeEnd = 296579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopSearching()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_StopSearching_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDB RID: 44251 RVA: 0x002D7F54 File Offset: 0x002D6154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296580, XrefRangeEnd = 296585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SearchRoutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x002D7F94 File Offset: 0x002D6194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296585, XrefRangeEnd = 296604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetNextSearchLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x002D7FD0 File Offset: 0x002D61D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296604, XrefRangeEnd = 296622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x002D8018 File Offset: 0x002D6218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296622, XrefRangeEnd = 296628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionToTargetMeleeRange(Vector3 origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RepositionToTargetMeleeRange_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x002D8058 File Offset: 0x002D6258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296663, RefRangeEnd = 296665, XrefRangeStart = 296628, XrefRangeEnd = 296663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetRandomReachablePointNear(Vector3 originPoint, float randomRadius, out Vector3 randomPoint, float minDistance = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref originPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref randomRadius;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &randomPoint;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Boolean_Vector3_Single_byref_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x002D80CC File Offset: 0x002D62CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296669, RefRangeEnd = 296671, XrefRangeStart = 296665, XrefRangeEnd = 296669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMinTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x002D8108 File Offset: 0x002D6308
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296675, RefRangeEnd = 296677, XrefRangeStart = 296671, XrefRangeEnd = 296675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetMaxTargetDistance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x002D8144 File Offset: 0x002D6344
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296697, RefRangeEnd = 296700, XrefRangeStart = 296677, XrefRangeEnd = 296697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetInRange(Vector3 origin = default(Vector3))
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x002D8190 File Offset: 0x002D6390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296705, RefRangeEnd = 296706, XrefRangeStart = 296700, XrefRangeEnd = 296705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CombatBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x002D81CC File Offset: 0x002D63CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296772, RefRangeEnd = 296773, XrefRangeStart = 296706, XrefRangeEnd = 296772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x002D8208 File Offset: 0x002D6408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296774, RefRangeEnd = 296775, XrefRangeStart = 296773, XrefRangeEnd = 296774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x002D8244 File Offset: 0x002D6444
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x002D8280 File Offset: 0x002D6480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296775, XrefRangeEnd = 296785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Server_SetTargetAndEnable_Server_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x002D82C4 File Offset: 0x002D64C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296785, XrefRangeEnd = 296787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetTargetAndEnable_Server_3323014238(NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTargetAndEnable_Server_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x002D8308 File Offset: 0x002D6508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296787, XrefRangeEnd = 296792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetTargetAndEnable_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Server_SetTargetAndEnable_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x002D836C File Offset: 0x002D656C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296792, XrefRangeEnd = 296802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x002D83C0 File Offset: 0x002D65C0
		[CallerCount(0)]
		public unsafe void RpcLogic___SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetTarget_Client_1824087381_Protected_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEC RID: 44268 RVA: 0x002D8414 File Offset: 0x002D6614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296802, XrefRangeEnd = 296805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACED RID: 44269 RVA: 0x002D8464 File Offset: 0x002D6664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296805, XrefRangeEnd = 296815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Target_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEE RID: 44270 RVA: 0x002D84B8 File Offset: 0x002D66B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296815, XrefRangeEnd = 296818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Target_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACEF RID: 44271 RVA: 0x002D8508 File Offset: 0x002D6708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296818, XrefRangeEnd = 296828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF0 RID: 44272 RVA: 0x002D854C File Offset: 0x002D674C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296861, RefRangeEnd = 296863, XrefRangeStart = 296828, XrefRangeEnd = 296861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetWeapon_3615296227(string weaponPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(weaponPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF1 RID: 44273 RVA: 0x002D859C File Offset: 0x002D679C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296863, XrefRangeEnd = 296867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF2 RID: 44274 RVA: 0x002D85EC File Offset: 0x002D67EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296867, XrefRangeEnd = 296876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF3 RID: 44275 RVA: 0x002D8620 File Offset: 0x002D6820
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296897, RefRangeEnd = 296899, XrefRangeStart = 296876, XrefRangeEnd = 296897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ClearWeapon_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF4 RID: 44276 RVA: 0x002D8654 File Offset: 0x002D6854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296899, XrefRangeEnd = 296902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF5 RID: 44277 RVA: 0x002D86A4 File Offset: 0x002D68A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296902, XrefRangeEnd = 296911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF6 RID: 44278 RVA: 0x002D86D8 File Offset: 0x002D68D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296915, RefRangeEnd = 296917, XrefRangeStart = 296911, XrefRangeEnd = 296915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___Attack_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF7 RID: 44279 RVA: 0x002D8714 File Offset: 0x002D6914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296917, XrefRangeEnd = 296920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF8 RID: 44280 RVA: 0x002D8764 File Offset: 0x002D6964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACF9 RID: 44281 RVA: 0x002D8798 File Offset: 0x002D6998
		[CallerCount(0)]
		public unsafe void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFA RID: 44282 RVA: 0x002D87CC File Offset: 0x002D69CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296920, XrefRangeEnd = 296921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFB RID: 44283 RVA: 0x002D8830 File Offset: 0x002D6A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296921, XrefRangeEnd = 296924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CombatBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600ACFC RID: 44284 RVA: 0x0004EF17 File Offset: 0x0004D117
		public CombatBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600ACFD RID: 44285 RVA: 0x002D886C File Offset: 0x002D6A6C
		// (set) Token: 0x0600ACFE RID: 44286 RVA: 0x0004EF20 File Offset: 0x0004D120
		public unsafe static float RECENT_VISIBILITY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600ACFF RID: 44287 RVA: 0x002D8888 File Offset: 0x002D6A88
		// (set) Token: 0x0600AD00 RID: 44288 RVA: 0x0004EF2E File Offset: 0x0004D12E
		public unsafe static float REPOSITION_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_REPOSITION_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_REPOSITION_TIME, (void*)(&value));
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600AD01 RID: 44289 RVA: 0x002D88A4 File Offset: 0x002D6AA4
		// (set) Token: 0x0600AD02 RID: 44290 RVA: 0x0004EF3C File Offset: 0x0004D13C
		public unsafe static float SEARCH_RADIUS_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MIN, (void*)(&value));
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600AD03 RID: 44291 RVA: 0x002D88C0 File Offset: 0x002D6AC0
		// (set) Token: 0x0600AD04 RID: 44292 RVA: 0x0004EF4A File Offset: 0x0004D14A
		public unsafe static float SEARCH_RADIUS_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_RADIUS_MAX, (void*)(&value));
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600AD05 RID: 44293 RVA: 0x002D88DC File Offset: 0x002D6ADC
		// (set) Token: 0x0600AD06 RID: 44294 RVA: 0x0004EF58 File Offset: 0x0004D158
		public unsafe static float SEARCH_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_SEARCH_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600AD07 RID: 44295 RVA: 0x002D88F8 File Offset: 0x002D6AF8
		// (set) Token: 0x0600AD08 RID: 44296 RVA: 0x0004EF66 File Offset: 0x0004D166
		public unsafe static float CONSECUTIVE_MISS_ACCURACY_BOOST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST, (void*)(&value));
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x0600AD09 RID: 44297 RVA: 0x002D8914 File Offset: 0x002D6B14
		// (set) Token: 0x0600AD0A RID: 44298 RVA: 0x0004EF74 File Offset: 0x0004D174
		public unsafe static float REACHED_DESTINATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x0600AD0B RID: 44299 RVA: 0x002D8930 File Offset: 0x002D6B30
		// (set) Token: 0x0600AD0C RID: 44300 RVA: 0x0004EF82 File Offset: 0x0004D182
		public unsafe static float DelayBeforeFirstAttack
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CombatBehaviour.NativeFieldInfoPtr_DelayBeforeFirstAttack, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CombatBehaviour.NativeFieldInfoPtr_DelayBeforeFirstAttack, (void*)(&value));
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x0600AD0D RID: 44301 RVA: 0x002D894C File Offset: 0x002D6B4C
		// (set) Token: 0x0600AD0E RID: 44302 RVA: 0x0004EF90 File Offset: 0x0004D190
		public unsafe ICombatTargetable _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICombatTargetable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x0600AD0F RID: 44303 RVA: 0x002D897C File Offset: 0x002D6B7C
		// (set) Token: 0x0600AD10 RID: 44304 RVA: 0x0004EFAF File Offset: 0x0004D1AF
		public unsafe bool _IsSearching_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsSearching_k__BackingField)) = value;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x0600AD11 RID: 44305 RVA: 0x002D89A4 File Offset: 0x002D6BA4
		// (set) Token: 0x0600AD12 RID: 44306 RVA: 0x0004EFCA File Offset: 0x0004D1CA
		public unsafe float _TimeSinceTargetReacquired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField)) = value;
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x0600AD13 RID: 44307 RVA: 0x002D89CC File Offset: 0x002D6BCC
		// (set) Token: 0x0600AD14 RID: 44308 RVA: 0x0004EFE5 File Offset: 0x0004D1E5
		public unsafe bool DEBUG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x0600AD15 RID: 44309 RVA: 0x002D89F4 File Offset: 0x002D6BF4
		// (set) Token: 0x0600AD16 RID: 44310 RVA: 0x0004F000 File Offset: 0x0004D200
		public unsafe float GiveUpRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpRange)) = value;
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600AD17 RID: 44311 RVA: 0x002D8A1C File Offset: 0x002D6C1C
		// (set) Token: 0x0600AD18 RID: 44312 RVA: 0x0004F01B File Offset: 0x0004D21B
		public unsafe int GiveUpAfterSuccessfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_GiveUpAfterSuccessfulHits)) = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600AD19 RID: 44313 RVA: 0x002D8A44 File Offset: 0x002D6C44
		// (set) Token: 0x0600AD1A RID: 44314 RVA: 0x0004F036 File Offset: 0x0004D236
		public unsafe bool PlayAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_PlayAngryVO)) = value;
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600AD1B RID: 44315 RVA: 0x002D8A6C File Offset: 0x002D6C6C
		// (set) Token: 0x0600AD1C RID: 44316 RVA: 0x0004F051 File Offset: 0x0004D251
		public unsafe float DefaultMovementSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultMovementSpeed)) = value;
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600AD1D RID: 44317 RVA: 0x002D8A94 File Offset: 0x002D6C94
		// (set) Token: 0x0600AD1E RID: 44318 RVA: 0x0004F06C File Offset: 0x0004D26C
		public unsafe AvatarMeleeWeapon VirtualPunchWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarMeleeWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_VirtualPunchWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600AD1F RID: 44319 RVA: 0x002D8AC4 File Offset: 0x002D6CC4
		// (set) Token: 0x0600AD20 RID: 44320 RVA: 0x0004F08B File Offset: 0x0004D28B
		public unsafe float DefaultSearchTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DefaultSearchTime)) = value;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600AD21 RID: 44321 RVA: 0x002D8AEC File Offset: 0x002D6CEC
		// (set) Token: 0x0600AD22 RID: 44322 RVA: 0x0004F0A6 File Offset: 0x0004D2A6
		public unsafe SmoothedVelocityCalculator TargetVelocityTracker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_TargetVelocityTracker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_TargetVelocityTracker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600AD23 RID: 44323 RVA: 0x002D8B1C File Offset: 0x002D6D1C
		// (set) Token: 0x0600AD24 RID: 44324 RVA: 0x0004F0C5 File Offset: 0x0004D2C5
		public unsafe bool CombatOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_CombatOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_CombatOnStart)) = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600AD25 RID: 44325 RVA: 0x002D8B44 File Offset: 0x002D6D44
		// (set) Token: 0x0600AD26 RID: 44326 RVA: 0x0004F0E0 File Offset: 0x0004D2E0
		public unsafe NetworkObject DebugTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DebugTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_DebugTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600AD27 RID: 44327 RVA: 0x002D8B74 File Offset: 0x002D6D74
		// (set) Token: 0x0600AD28 RID: 44328 RVA: 0x0004F0FF File Offset: 0x0004D2FF
		public unsafe bool _IsTargetRecentlyVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600AD29 RID: 44329 RVA: 0x002D8B9C File Offset: 0x002D6D9C
		// (set) Token: 0x0600AD2A RID: 44330 RVA: 0x0004F11A File Offset: 0x0004D31A
		public unsafe bool _IsTargetImmediatelyVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600AD2B RID: 44331 RVA: 0x002D8BC4 File Offset: 0x002D6DC4
		// (set) Token: 0x0600AD2C RID: 44332 RVA: 0x0004F135 File Offset: 0x0004D335
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600AD2D RID: 44333 RVA: 0x002D8BEC File Offset: 0x002D6DEC
		// (set) Token: 0x0600AD2E RID: 44334 RVA: 0x0004F150 File Offset: 0x0004D350
		public unsafe Vector3 lastKnownTargetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_lastKnownTargetPosition)) = value;
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600AD2F RID: 44335 RVA: 0x002D8C14 File Offset: 0x002D6E14
		// (set) Token: 0x0600AD30 RID: 44336 RVA: 0x0004F16B File Offset: 0x0004D36B
		public unsafe float timeSinceLastReposition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastReposition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeSinceLastReposition)) = value;
			}
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600AD31 RID: 44337 RVA: 0x002D8C3C File Offset: 0x002D6E3C
		// (set) Token: 0x0600AD32 RID: 44338 RVA: 0x0004F186 File Offset: 0x0004D386
		public unsafe float timeWithinAttackRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeWithinAttackRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_timeWithinAttackRange)) = value;
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600AD33 RID: 44339 RVA: 0x002D8C64 File Offset: 0x002D6E64
		// (set) Token: 0x0600AD34 RID: 44340 RVA: 0x0004F1A1 File Offset: 0x0004D3A1
		public unsafe bool visionEventReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_visionEventReceived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_visionEventReceived)) = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600AD35 RID: 44341 RVA: 0x002D8C8C File Offset: 0x002D6E8C
		// (set) Token: 0x0600AD36 RID: 44342 RVA: 0x0004F1BC File Offset: 0x0004D3BC
		public unsafe float _timeOnCombatStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__timeOnCombatStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__timeOnCombatStart)) = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600AD37 RID: 44343 RVA: 0x002D8CB4 File Offset: 0x002D6EB4
		// (set) Token: 0x0600AD38 RID: 44344 RVA: 0x0004F1D7 File Offset: 0x0004D3D7
		public unsafe AvatarWeapon currentWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E3 RID: 13283
		// (get) Token: 0x0600AD39 RID: 44345 RVA: 0x002D8CE4 File Offset: 0x002D6EE4
		// (set) Token: 0x0600AD3A RID: 44346 RVA: 0x0004F1F6 File Offset: 0x0004D3F6
		public unsafe int successfulHits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_successfulHits)) = value;
			}
		}

		// Token: 0x170033E4 RID: 13284
		// (get) Token: 0x0600AD3B RID: 44347 RVA: 0x002D8D0C File Offset: 0x002D6F0C
		// (set) Token: 0x0600AD3C RID: 44348 RVA: 0x0004F211 File Offset: 0x0004D411
		public unsafe int consecutiveMissedShots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_consecutiveMissedShots)) = value;
			}
		}

		// Token: 0x170033E5 RID: 13285
		// (get) Token: 0x0600AD3D RID: 44349 RVA: 0x002D8D34 File Offset: 0x002D6F34
		// (set) Token: 0x0600AD3E RID: 44350 RVA: 0x0004F22C File Offset: 0x0004D42C
		public unsafe Coroutine rangedWeaponRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_rangedWeaponRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E6 RID: 13286
		// (get) Token: 0x0600AD3F RID: 44351 RVA: 0x002D8D64 File Offset: 0x002D6F64
		// (set) Token: 0x0600AD40 RID: 44352 RVA: 0x0004F24B File Offset: 0x0004D44B
		public unsafe Coroutine searchRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_searchRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033E7 RID: 13287
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x002D8D94 File Offset: 0x002D6F94
		// (set) Token: 0x0600AD42 RID: 44354 RVA: 0x0004F26A File Offset: 0x0004D46A
		public unsafe Vector3 currentSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_currentSearchDestination)) = value;
			}
		}

		// Token: 0x170033E8 RID: 13288
		// (get) Token: 0x0600AD43 RID: 44355 RVA: 0x002D8DBC File Offset: 0x002D6FBC
		// (set) Token: 0x0600AD44 RID: 44356 RVA: 0x0004F285 File Offset: 0x0004D485
		public unsafe bool hasSearchDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_hasSearchDestination)) = value;
			}
		}

		// Token: 0x170033E9 RID: 13289
		// (get) Token: 0x0600AD45 RID: 44357 RVA: 0x002D8DE4 File Offset: 0x002D6FE4
		// (set) Token: 0x0600AD46 RID: 44358 RVA: 0x0004F2A0 File Offset: 0x0004D4A0
		public unsafe float nextAngryVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_nextAngryVO)) = value;
			}
		}

		// Token: 0x170033EA RID: 13290
		// (get) Token: 0x0600AD47 RID: 44359 RVA: 0x002D8E0C File Offset: 0x002D700C
		// (set) Token: 0x0600AD48 RID: 44360 RVA: 0x0004F2BB File Offset: 0x0004D4BB
		public unsafe Action onSuccessfulHit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_onSuccessfulHit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_onSuccessfulHit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EB RID: 13291
		// (get) Token: 0x0600AD49 RID: 44361 RVA: 0x002D8E3C File Offset: 0x002D703C
		// (set) Token: 0x0600AD4A RID: 44362 RVA: 0x0004F2DA File Offset: 0x0004D4DA
		public unsafe AvatarWeapon _defaultWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__defaultWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarWeapon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr__defaultWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033EC RID: 13292
		// (get) Token: 0x0600AD4B RID: 44363 RVA: 0x002D8E6C File Offset: 0x002D706C
		// (set) Token: 0x0600AD4C RID: 44364 RVA: 0x0004F2F9 File Offset: 0x0004D4F9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033ED RID: 13293
		// (get) Token: 0x0600AD4D RID: 44365 RVA: 0x002D8E94 File Offset: 0x002D7094
		// (set) Token: 0x0600AD4E RID: 44366 RVA: 0x0004F314 File Offset: 0x0004D514
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007739 RID: 30521
		private static readonly IntPtr NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD;

		// Token: 0x0400773A RID: 30522
		private static readonly IntPtr NativeFieldInfoPtr_REPOSITION_TIME;

		// Token: 0x0400773B RID: 30523
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MIN;

		// Token: 0x0400773C RID: 30524
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_RADIUS_MAX;

		// Token: 0x0400773D RID: 30525
		private static readonly IntPtr NativeFieldInfoPtr_SEARCH_SPEED;

		// Token: 0x0400773E RID: 30526
		private static readonly IntPtr NativeFieldInfoPtr_CONSECUTIVE_MISS_ACCURACY_BOOST;

		// Token: 0x0400773F RID: 30527
		private static readonly IntPtr NativeFieldInfoPtr_REACHED_DESTINATION_DISTANCE;

		// Token: 0x04007740 RID: 30528
		private static readonly IntPtr NativeFieldInfoPtr_DelayBeforeFirstAttack;

		// Token: 0x04007741 RID: 30529
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x04007742 RID: 30530
		private static readonly IntPtr NativeFieldInfoPtr__IsSearching_k__BackingField;

		// Token: 0x04007743 RID: 30531
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceTargetReacquired_k__BackingField;

		// Token: 0x04007744 RID: 30532
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x04007745 RID: 30533
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpRange;

		// Token: 0x04007746 RID: 30534
		private static readonly IntPtr NativeFieldInfoPtr_GiveUpAfterSuccessfulHits;

		// Token: 0x04007747 RID: 30535
		private static readonly IntPtr NativeFieldInfoPtr_PlayAngryVO;

		// Token: 0x04007748 RID: 30536
		private static readonly IntPtr NativeFieldInfoPtr_DefaultMovementSpeed;

		// Token: 0x04007749 RID: 30537
		private static readonly IntPtr NativeFieldInfoPtr_VirtualPunchWeapon;

		// Token: 0x0400774A RID: 30538
		private static readonly IntPtr NativeFieldInfoPtr_DefaultSearchTime;

		// Token: 0x0400774B RID: 30539
		private static readonly IntPtr NativeFieldInfoPtr_TargetVelocityTracker;

		// Token: 0x0400774C RID: 30540
		private static readonly IntPtr NativeFieldInfoPtr_CombatOnStart;

		// Token: 0x0400774D RID: 30541
		private static readonly IntPtr NativeFieldInfoPtr_DebugTarget;

		// Token: 0x0400774E RID: 30542
		private static readonly IntPtr NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField;

		// Token: 0x0400774F RID: 30543
		private static readonly IntPtr NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField;

		// Token: 0x04007750 RID: 30544
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04007751 RID: 30545
		private static readonly IntPtr NativeFieldInfoPtr_lastKnownTargetPosition;

		// Token: 0x04007752 RID: 30546
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastReposition;

		// Token: 0x04007753 RID: 30547
		private static readonly IntPtr NativeFieldInfoPtr_timeWithinAttackRange;

		// Token: 0x04007754 RID: 30548
		private static readonly IntPtr NativeFieldInfoPtr_visionEventReceived;

		// Token: 0x04007755 RID: 30549
		private static readonly IntPtr NativeFieldInfoPtr__timeOnCombatStart;

		// Token: 0x04007756 RID: 30550
		private static readonly IntPtr NativeFieldInfoPtr_currentWeapon;

		// Token: 0x04007757 RID: 30551
		private static readonly IntPtr NativeFieldInfoPtr_successfulHits;

		// Token: 0x04007758 RID: 30552
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveMissedShots;

		// Token: 0x04007759 RID: 30553
		private static readonly IntPtr NativeFieldInfoPtr_rangedWeaponRoutine;

		// Token: 0x0400775A RID: 30554
		private static readonly IntPtr NativeFieldInfoPtr_searchRoutine;

		// Token: 0x0400775B RID: 30555
		private static readonly IntPtr NativeFieldInfoPtr_currentSearchDestination;

		// Token: 0x0400775C RID: 30556
		private static readonly IntPtr NativeFieldInfoPtr_hasSearchDestination;

		// Token: 0x0400775D RID: 30557
		private static readonly IntPtr NativeFieldInfoPtr_nextAngryVO;

		// Token: 0x0400775E RID: 30558
		private static readonly IntPtr NativeFieldInfoPtr_onSuccessfulHit;

		// Token: 0x0400775F RID: 30559
		private static readonly IntPtr NativeFieldInfoPtr__defaultWeapon;

		// Token: 0x04007760 RID: 30560
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007761 RID: 30561
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007762 RID: 30562
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_ICombatTargetable_0;

		// Token: 0x04007763 RID: 30563
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_ICombatTargetable_0;

		// Token: 0x04007764 RID: 30564
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSearching_Public_get_Boolean_0;

		// Token: 0x04007765 RID: 30565
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSearching_Protected_set_Void_Boolean_0;

		// Token: 0x04007766 RID: 30566
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceTargetReacquired_Public_get_Single_0;

		// Token: 0x04007767 RID: 30567
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceTargetReacquired_Protected_set_Void_Single_0;

		// Token: 0x04007768 RID: 30568
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0;

		// Token: 0x04007769 RID: 30569
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0;

		// Token: 0x0400776A RID: 30570
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0;

		// Token: 0x0400776B RID: 30571
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0;

		// Token: 0x0400776C RID: 30572
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultWeapon_Public_Void_AvatarWeapon_0;

		// Token: 0x0400776D RID: 30573
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400776E RID: 30574
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400776F RID: 30575
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007770 RID: 30576
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetAndEnable_Server_Public_Void_NetworkObject_0;

		// Token: 0x04007771 RID: 30577
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Client_Protected_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x04007772 RID: 30578
		private static readonly IntPtr NativeMethodInfoPtr_SetTarget_Protected_Virtual_New_Void_NetworkObject_0;

		// Token: 0x04007773 RID: 30579
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04007774 RID: 30580
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04007775 RID: 30581
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04007776 RID: 30582
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04007777 RID: 30583
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04007778 RID: 30584
		private static readonly IntPtr NativeMethodInfoPtr_StartCombat_Protected_Virtual_New_Void_0;

		// Token: 0x04007779 RID: 30585
		private static readonly IntPtr NativeMethodInfoPtr_EndCombat_Protected_Virtual_New_Void_0;

		// Token: 0x0400777A RID: 30586
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x0400777B RID: 30587
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeout_Protected_Void_0;

		// Token: 0x0400777C RID: 30588
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLookAt_Protected_Virtual_New_Void_0;

		// Token: 0x0400777D RID: 30589
		private static readonly IntPtr NativeMethodInfoPtr_SetMovementSpeed_Protected_Void_Single_String_Int32_0;

		// Token: 0x0400777E RID: 30590
		private static readonly IntPtr NativeMethodInfoPtr_EnsureRangedWeaponRoutineIsRunning_Private_Void_0;

		// Token: 0x0400777F RID: 30591
		private static readonly IntPtr NativeMethodInfoPtr_GetPredictedFutureTargetPosition_Protected_Vector3_Single_Single_0;

		// Token: 0x04007780 RID: 30592
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Protected_Virtual_Void_Vector3_Boolean_Single_0;

		// Token: 0x04007781 RID: 30593
		private static readonly IntPtr NativeMethodInfoPtr_SetWeapon_Protected_Virtual_New_Void_String_0;

		// Token: 0x04007782 RID: 30594
		private static readonly IntPtr NativeMethodInfoPtr_OnCurrentWeaponChanged_Protected_Virtual_New_Void_AvatarWeapon_0;

		// Token: 0x04007783 RID: 30595
		private static readonly IntPtr NativeMethodInfoPtr_ClearWeapon_Protected_Void_0;

		// Token: 0x04007784 RID: 30596
		private static readonly IntPtr NativeMethodInfoPtr_ReadyToAttack_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04007785 RID: 30597
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentWeaponMelee_Private_Boolean_0;

		// Token: 0x04007786 RID: 30598
		private static readonly IntPtr NativeMethodInfoPtr_Attack_Protected_Virtual_New_Void_0;

		// Token: 0x04007787 RID: 30599
		private static readonly IntPtr NativeMethodInfoPtr_SucessfulHit_Protected_Void_0;

		// Token: 0x04007788 RID: 30600
		private static readonly IntPtr NativeMethodInfoPtr_RangedWeaponRoutine_Private_IEnumerator_0;

		// Token: 0x04007789 RID: 30601
		private static readonly IntPtr NativeMethodInfoPtr_RepositionToRangedWeaponRange_Private_IEnumerator_0;

		// Token: 0x0400778A RID: 30602
		private static readonly IntPtr NativeMethodInfoPtr_GetIdealRangedWeaponDistance_Protected_Virtual_New_Single_0;

		// Token: 0x0400778B RID: 30603
		private static readonly IntPtr NativeMethodInfoPtr_Shoot_Private_Boolean_0;

		// Token: 0x0400778C RID: 30604
		private static readonly IntPtr NativeMethodInfoPtr_SetWeaponRaised_Private_Void_Boolean_0;

		// Token: 0x0400778D RID: 30605
		private static readonly IntPtr NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0;

		// Token: 0x0400778E RID: 30606
		private static readonly IntPtr NativeMethodInfoPtr_TargetResighted_Protected_Virtual_New_Void_0;

		// Token: 0x0400778F RID: 30607
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x04007790 RID: 30608
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetVisibleThisFrame_Protected_Boolean_0;

		// Token: 0x04007791 RID: 30609
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Protected_Void_VisionEventReceipt_0;

		// Token: 0x04007792 RID: 30610
		private static readonly IntPtr NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0;

		// Token: 0x04007793 RID: 30611
		private static readonly IntPtr NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0;

		// Token: 0x04007794 RID: 30612
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchTime_Protected_Virtual_New_Single_0;

		// Token: 0x04007795 RID: 30613
		private static readonly IntPtr NativeMethodInfoPtr_StartSearching_Private_Void_0;

		// Token: 0x04007796 RID: 30614
		private static readonly IntPtr NativeMethodInfoPtr_StopSearching_Private_Void_0;

		// Token: 0x04007797 RID: 30615
		private static readonly IntPtr NativeMethodInfoPtr_SearchRoutine_Private_IEnumerator_0;

		// Token: 0x04007798 RID: 30616
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSearchLocation_Private_Vector3_0;

		// Token: 0x04007799 RID: 30617
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Protected_Virtual_New_Boolean_0;

		// Token: 0x0400779A RID: 30618
		private static readonly IntPtr NativeMethodInfoPtr_RepositionToTargetMeleeRange_Private_Void_Vector3_0;

		// Token: 0x0400779B RID: 30619
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomReachablePointNear_Private_Boolean_Vector3_Single_byref_Vector3_Single_0;

		// Token: 0x0400779C RID: 30620
		private static readonly IntPtr NativeMethodInfoPtr_GetMinTargetDistance_Protected_Single_0;

		// Token: 0x0400779D RID: 30621
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxTargetDistance_Protected_Single_0;

		// Token: 0x0400779E RID: 30622
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetInRange_Protected_Boolean_Vector3_0;

		// Token: 0x0400779F RID: 30623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040077A0 RID: 30624
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040077A1 RID: 30625
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040077A2 RID: 30626
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040077A3 RID: 30627
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetTargetAndEnable_Server_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x040077A4 RID: 30628
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTargetAndEnable_Server_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x040077A5 RID: 30629
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetTargetAndEnable_Server_3323014238_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077A6 RID: 30630
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040077A7 RID: 30631
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetTarget_Client_1824087381_Protected_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040077A8 RID: 30632
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077A9 RID: 30633
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetTarget_Client_1824087381_Private_Void_NetworkConnection_NetworkObject_0;

		// Token: 0x040077AA RID: 30634
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetTarget_Client_1824087381_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077AB RID: 30635
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetWeapon_3615296227_Private_Void_String_0;

		// Token: 0x040077AC RID: 30636
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetWeapon_3615296227_Protected_Virtual_New_Void_String_0;

		// Token: 0x040077AD RID: 30637
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetWeapon_3615296227_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077AE RID: 30638
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ClearWeapon_2166136261_Private_Void_0;

		// Token: 0x040077AF RID: 30639
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ClearWeapon_2166136261_Protected_Void_0;

		// Token: 0x040077B0 RID: 30640
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ClearWeapon_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077B1 RID: 30641
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Attack_2166136261_Private_Void_0;

		// Token: 0x040077B2 RID: 30642
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Attack_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040077B3 RID: 30643
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Attack_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040077B4 RID: 30644
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0;

		// Token: 0x040077B5 RID: 30645
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0;

		// Token: 0x040077B6 RID: 30646
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040077B7 RID: 30647
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000CAA RID: 3242
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F349 RID: 62281 RVA: 0x003A9294 File Offset: 0x003A7494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr);
				CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, "<>4__this");
				CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr_rangedWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, "rangedWeapon");
				CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, "<>9__1");
				CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, 100686160);
				CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr__RangedWeaponRoutine_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, 100686161);
				CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr_Method_Internal_Boolean_byref___c__DisplayClass82_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr, 100686162);
			}

			// Token: 0x0600F34A RID: 62282 RVA: 0x003A9338 File Offset: 0x003A7538
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F34B RID: 62283 RVA: 0x003A9374 File Offset: 0x003A7574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295862, XrefRangeEnd = 295863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RangedWeaponRoutine_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr__RangedWeaponRoutine_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F34C RID: 62284 RVA: 0x003A93B0 File Offset: 0x003A75B0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 295872, RefRangeEnd = 295874, XrefRangeStart = 295863, XrefRangeEnd = 295872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_byref___c__DisplayClass82_1_0(ref CombatBehaviour.__c__DisplayClass82_1 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = &A_1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour.__c__DisplayClass82_0.NativeMethodInfoPtr_Method_Internal_Boolean_byref___c__DisplayClass82_1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F34D RID: 62285 RVA: 0x00072D4A File Offset: 0x00070F4A
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049D3 RID: 18899
			// (get) Token: 0x0600F34E RID: 62286 RVA: 0x003A93FC File Offset: 0x003A75FC
			// (set) Token: 0x0600F34F RID: 62287 RVA: 0x00072D53 File Offset: 0x00070F53
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D4 RID: 18900
			// (get) Token: 0x0600F350 RID: 62288 RVA: 0x003A942C File Offset: 0x003A762C
			// (set) Token: 0x0600F351 RID: 62289 RVA: 0x00072D72 File Offset: 0x00070F72
			public unsafe AvatarRangedWeapon rangedWeapon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr_rangedWeapon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarRangedWeapon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr_rangedWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D5 RID: 18901
			// (get) Token: 0x0600F352 RID: 62290 RVA: 0x003A945C File Offset: 0x003A765C
			// (set) Token: 0x0600F353 RID: 62291 RVA: 0x00072D91 File Offset: 0x00070F91
			public unsafe Func<bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour.__c__DisplayClass82_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4CC RID: 42188
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4CD RID: 42189
			private static readonly IntPtr NativeFieldInfoPtr_rangedWeapon;

			// Token: 0x0400A4CE RID: 42190
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x0400A4CF RID: 42191
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A4D0 RID: 42192
			private static readonly IntPtr NativeMethodInfoPtr__RangedWeaponRoutine_b__1_Internal_Boolean_0;

			// Token: 0x0400A4D1 RID: 42193
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_byref___c__DisplayClass82_1_0;
		}

		// Token: 0x02000CAB RID: 3243
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<>c__DisplayClass82_1")]
		[StructLayout(2)]
		public struct __c__DisplayClass82_1
		{
			// Token: 0x0600F354 RID: 62292 RVA: 0x003A948C File Offset: 0x003A768C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_1()
			{
				Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<>c__DisplayClass82_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_1>.NativeClassPtr);
				CombatBehaviour.__c__DisplayClass82_1.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_1>.NativeClassPtr, "action");
				CombatBehaviour.__c__DisplayClass82_1.NativeFieldInfoPtr_shots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_1>.NativeClassPtr, "shots");
			}

			// Token: 0x0600F355 RID: 62293 RVA: 0x00072DB0 File Offset: 0x00070FB0
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CombatBehaviour.__c__DisplayClass82_1>.NativeClassPtr, ref this));
			}

			// Token: 0x0400A4D2 RID: 42194
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x0400A4D3 RID: 42195
			private static readonly IntPtr NativeFieldInfoPtr_shots;

			// Token: 0x0400A4D4 RID: 42196
			[FieldOffset(0)]
			public ERangedWeaponAction action;

			// Token: 0x0400A4D5 RID: 42197
			[FieldOffset(4)]
			public int shots;
		}

		// Token: 0x02000CAC RID: 3244
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<RangedWeaponRoutine>d__82")]
		public sealed class _RangedWeaponRoutine_d__82 : Il2CppSystem.Object
		{
			// Token: 0x0600F356 RID: 62294 RVA: 0x003A94E0 File Offset: 0x003A76E0
			// Note: this type is marked as 'beforefieldinit'.
			static _RangedWeaponRoutine_d__82()
			{
				Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<RangedWeaponRoutine>d__82");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<>1__state");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<>2__current");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<>4__this");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<>8__1");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<>8__2");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr__forceReposition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, "<forceReposition>5__2");
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686163);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686164);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686165);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686166);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686167);
				CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr, 100686168);
			}

			// Token: 0x0600F357 RID: 62295 RVA: 0x003A95FC File Offset: 0x003A77FC
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RangedWeaponRoutine_d__82(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._RangedWeaponRoutine_d__82>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F358 RID: 62296 RVA: 0x003A9644 File Offset: 0x003A7844
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F359 RID: 62297 RVA: 0x003A9678 File Offset: 0x003A7878
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295874, XrefRangeEnd = 295978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049DC RID: 18908
			// (get) Token: 0x0600F35A RID: 62298 RVA: 0x003A96B4 File Offset: 0x003A78B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F35B RID: 62299 RVA: 0x003A96F4 File Offset: 0x003A78F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295978, XrefRangeEnd = 295983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049DD RID: 18909
			// (get) Token: 0x0600F35C RID: 62300 RVA: 0x003A9728 File Offset: 0x003A7928
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RangedWeaponRoutine_d__82.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F35D RID: 62301 RVA: 0x00072DC2 File Offset: 0x00070FC2
			public _RangedWeaponRoutine_d__82(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049D6 RID: 18902
			// (get) Token: 0x0600F35E RID: 62302 RVA: 0x003A9768 File Offset: 0x003A7968
			// (set) Token: 0x0600F35F RID: 62303 RVA: 0x00072DCB File Offset: 0x00070FCB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049D7 RID: 18903
			// (get) Token: 0x0600F360 RID: 62304 RVA: 0x003A9790 File Offset: 0x003A7990
			// (set) Token: 0x0600F361 RID: 62305 RVA: 0x00072DE6 File Offset: 0x00070FE6
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D8 RID: 18904
			// (get) Token: 0x0600F362 RID: 62306 RVA: 0x003A97C0 File Offset: 0x003A79C0
			// (set) Token: 0x0600F363 RID: 62307 RVA: 0x00072E05 File Offset: 0x00071005
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049D9 RID: 18905
			// (get) Token: 0x0600F364 RID: 62308 RVA: 0x003A97F0 File Offset: 0x003A79F0
			// (set) Token: 0x0600F365 RID: 62309 RVA: 0x00072E24 File Offset: 0x00071024
			public unsafe CombatBehaviour.__c__DisplayClass82_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour.__c__DisplayClass82_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049DA RID: 18906
			// (get) Token: 0x0600F366 RID: 62310 RVA: 0x003A9820 File Offset: 0x003A7A20
			// (set) Token: 0x0600F367 RID: 62311 RVA: 0x00072E43 File Offset: 0x00071043
			public unsafe CombatBehaviour.__c__DisplayClass82_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr___8__2)) = value;
				}
			}

			// Token: 0x170049DB RID: 18907
			// (get) Token: 0x0600F368 RID: 62312 RVA: 0x003A9848 File Offset: 0x003A7A48
			// (set) Token: 0x0600F369 RID: 62313 RVA: 0x00072E5E File Offset: 0x0007105E
			public unsafe bool _forceReposition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr__forceReposition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RangedWeaponRoutine_d__82.NativeFieldInfoPtr__forceReposition_5__2)) = value;
				}
			}

			// Token: 0x0400A4D6 RID: 42198
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4D7 RID: 42199
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4D8 RID: 42200
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4D9 RID: 42201
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400A4DA RID: 42202
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x0400A4DB RID: 42203
			private static readonly IntPtr NativeFieldInfoPtr__forceReposition_5__2;

			// Token: 0x0400A4DC RID: 42204
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4DD RID: 42205
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4DE RID: 42206
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A4DF RID: 42207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A4E0 RID: 42208
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4E1 RID: 42209
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CAD RID: 3245
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<RepositionToRangedWeaponRange>d__83")]
		public sealed class _RepositionToRangedWeaponRange_d__83 : Il2CppSystem.Object
		{
			// Token: 0x0600F36A RID: 62314 RVA: 0x003A9870 File Offset: 0x003A7A70
			// Note: this type is marked as 'beforefieldinit'.
			static _RepositionToRangedWeaponRange_d__83()
			{
				Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<RepositionToRangedWeaponRange>d__83");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, "<>1__state");
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, "<>2__current");
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, "<>4__this");
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686169);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686170);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686171);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686172);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686173);
				CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr, 100686174);
			}

			// Token: 0x0600F36B RID: 62315 RVA: 0x003A9950 File Offset: 0x003A7B50
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RepositionToRangedWeaponRange_d__83(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._RepositionToRangedWeaponRange_d__83>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F36C RID: 62316 RVA: 0x003A9998 File Offset: 0x003A7B98
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F36D RID: 62317 RVA: 0x003A99CC File Offset: 0x003A7BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295983, XrefRangeEnd = 296023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049E1 RID: 18913
			// (get) Token: 0x0600F36E RID: 62318 RVA: 0x003A9A08 File Offset: 0x003A7C08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F36F RID: 62319 RVA: 0x003A9A48 File Offset: 0x003A7C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296023, XrefRangeEnd = 296028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049E2 RID: 18914
			// (get) Token: 0x0600F370 RID: 62320 RVA: 0x003A9A7C File Offset: 0x003A7C7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F371 RID: 62321 RVA: 0x00072E79 File Offset: 0x00071079
			public _RepositionToRangedWeaponRange_d__83(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049DE RID: 18910
			// (get) Token: 0x0600F372 RID: 62322 RVA: 0x003A9ABC File Offset: 0x003A7CBC
			// (set) Token: 0x0600F373 RID: 62323 RVA: 0x00072E82 File Offset: 0x00071082
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049DF RID: 18911
			// (get) Token: 0x0600F374 RID: 62324 RVA: 0x003A9AE4 File Offset: 0x003A7CE4
			// (set) Token: 0x0600F375 RID: 62325 RVA: 0x00072E9D File Offset: 0x0007109D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E0 RID: 18912
			// (get) Token: 0x0600F376 RID: 62326 RVA: 0x003A9B14 File Offset: 0x003A7D14
			// (set) Token: 0x0600F377 RID: 62327 RVA: 0x00072EBC File Offset: 0x000710BC
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._RepositionToRangedWeaponRange_d__83.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4E2 RID: 42210
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4E3 RID: 42211
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4E4 RID: 42212
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4E5 RID: 42213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4E6 RID: 42214
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4E7 RID: 42215
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A4E8 RID: 42216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A4E9 RID: 42217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4EA RID: 42218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000CAE RID: 3246
		[ObfuscatedName("ScheduleOne.Combat.CombatBehaviour+<SearchRoutine>d__97")]
		public sealed class _SearchRoutine_d__97 : Il2CppSystem.Object
		{
			// Token: 0x0600F378 RID: 62328 RVA: 0x003A9B44 File Offset: 0x003A7D44
			// Note: this type is marked as 'beforefieldinit'.
			static _SearchRoutine_d__97()
			{
				Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatBehaviour>.NativeClassPtr, "<SearchRoutine>d__97");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr);
				CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, "<>1__state");
				CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, "<>2__current");
				CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, "<>4__this");
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686175);
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686176);
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686177);
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686178);
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686179);
				CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr, 100686180);
			}

			// Token: 0x0600F379 RID: 62329 RVA: 0x003A9C24 File Offset: 0x003A7E24
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SearchRoutine_d__97(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatBehaviour._SearchRoutine_d__97>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F37A RID: 62330 RVA: 0x003A9C6C File Offset: 0x003A7E6C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F37B RID: 62331 RVA: 0x003A9CA0 File Offset: 0x003A7EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296028, XrefRangeEnd = 296029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170049E6 RID: 18918
			// (get) Token: 0x0600F37C RID: 62332 RVA: 0x003A9CDC File Offset: 0x003A7EDC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F37D RID: 62333 RVA: 0x003A9D1C File Offset: 0x003A7F1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296029, XrefRangeEnd = 296034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170049E7 RID: 18919
			// (get) Token: 0x0600F37E RID: 62334 RVA: 0x003A9D50 File Offset: 0x003A7F50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CombatBehaviour._SearchRoutine_d__97.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F37F RID: 62335 RVA: 0x00072EDB File Offset: 0x000710DB
			public _SearchRoutine_d__97(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049E3 RID: 18915
			// (get) Token: 0x0600F380 RID: 62336 RVA: 0x003A9D90 File Offset: 0x003A7F90
			// (set) Token: 0x0600F381 RID: 62337 RVA: 0x00072EE4 File Offset: 0x000710E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170049E4 RID: 18916
			// (get) Token: 0x0600F382 RID: 62338 RVA: 0x003A9DB8 File Offset: 0x003A7FB8
			// (set) Token: 0x0600F383 RID: 62339 RVA: 0x00072EFF File Offset: 0x000710FF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049E5 RID: 18917
			// (get) Token: 0x0600F384 RID: 62340 RVA: 0x003A9DE8 File Offset: 0x003A7FE8
			// (set) Token: 0x0600F385 RID: 62341 RVA: 0x00072F1E File Offset: 0x0007111E
			public unsafe CombatBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CombatBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CombatBehaviour._SearchRoutine_d__97.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A4EB RID: 42219
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A4EC RID: 42220
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A4ED RID: 42221
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A4EE RID: 42222
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A4EF RID: 42223
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4F0 RID: 42224
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A4F1 RID: 42225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A4F2 RID: 42226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A4F3 RID: 42227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
