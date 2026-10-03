using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using Il2CppScheduleOne.Vision;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200068C RID: 1676
	public class VehiclePursuitBehaviour : Behaviour
	{
		// Token: 0x0600A2D0 RID: 41680 RVA: 0x002B4D58 File Offset: 0x002B2F58
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePursuitBehaviour()
		{
			Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePursuitBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr);
			VehiclePursuitBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "RECENT_VISIBILITY_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "EXIT_VEHICLE_MAX_SPEED");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "CLOSE_ENOUGH_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "UPDATE_FREQUENCY");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "STATIONARY_THRESHOLD");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "TIME_STATIONARY_TO_EXIT");
			VehiclePursuitBehaviour.NativeFieldInfoPtr__Target_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "<Target>k__BackingField");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "RepathDistanceThresholdMap");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "vehicle");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "initialContactMade");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "aggressiveDrivingEnabled");
			VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "<IsTargetRecentlyVisible>k__BackingField");
			VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "<IsTargetImmediatelyVisible>k__BackingField");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSinceLastSighting");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_visionEventReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "visionEventReceived");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutiveVehiclePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "consecutiveVehiclePathingFailures");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeStationary");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "currentDriveTarget");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "targetChanges");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "timeSincePursuitStart");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "beginAsSighted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePursuitBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Target_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684826);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684827);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684828);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684829);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684830);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684831);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684832);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684833);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684834);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684835);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684836);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684837);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684838);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684839);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684840);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684841);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684842);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684843);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684844);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684845);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684846);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684847);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684848);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684849);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684850);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684851);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684852);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684853);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684854);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684855);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetVisible_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684856);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684857);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684858);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684859);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684860);
			VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684861);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684862);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684863);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684864);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684865);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684866);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684867);
			VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr, 100684868);
		}

		// Token: 0x17003127 RID: 12583
		// (get) Token: 0x0600A2D1 RID: 41681 RVA: 0x002B52B0 File Offset: 0x002B34B0
		// (set) Token: 0x0600A2D2 RID: 41682 RVA: 0x002B52F0 File Offset: 0x002B34F0
		public unsafe Player Target
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Target_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003128 RID: 12584
		// (get) Token: 0x0600A2D3 RID: 41683 RVA: 0x002B5334 File Offset: 0x002B3534
		// (set) Token: 0x0600A2D4 RID: 41684 RVA: 0x002B5370 File Offset: 0x002B3570
		public unsafe bool IsTargetRecentlyVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003129 RID: 12585
		// (get) Token: 0x0600A2D5 RID: 41685 RVA: 0x002B53B0 File Offset: 0x002B35B0
		// (set) Token: 0x0600A2D6 RID: 41686 RVA: 0x002B53EC File Offset: 0x002B35EC
		public unsafe bool IsTargetImmediatelyVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700312A RID: 12586
		// (get) Token: 0x0600A2D7 RID: 41687 RVA: 0x002B542C File Offset: 0x002B362C
		public unsafe bool isDriving
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 286617, RefRangeEnd = 286622, XrefRangeStart = 286610, XrefRangeEnd = 286617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700312B RID: 12587
		// (get) Token: 0x0600A2D8 RID: 41688 RVA: 0x002B5468 File Offset: 0x002B3668
		public unsafe VehicleAgent Agent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr3) : null;
			}
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x002B54A8 File Offset: 0x002B36A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286622, XrefRangeEnd = 286655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x002B54DC File Offset: 0x002B36DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286655, XrefRangeEnd = 286677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x002B5510 File Offset: 0x002B3710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286677, RefRangeEnd = 286678, XrefRangeStart = 286677, XrefRangeEnd = 286677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginAsSighted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_BeginAsSighted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x002B5544 File Offset: 0x002B3744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286678, XrefRangeEnd = 286686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x002B5580 File Offset: 0x002B3780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286686, XrefRangeEnd = 286688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x002B55BC File Offset: 0x002B37BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286688, XrefRangeEnd = 286699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x002B55F8 File Offset: 0x002B37F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286699, XrefRangeEnd = 286730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x002B5634 File Offset: 0x002B3834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286730, XrefRangeEnd = 286731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignTarget(Player target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x002B5684 File Offset: 0x002B3884
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286774, RefRangeEnd = 286776, XrefRangeStart = 286731, XrefRangeEnd = 286774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPursuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_StartPursuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E2 RID: 41698 RVA: 0x002B56B8 File Offset: 0x002B38B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286776, XrefRangeEnd = 286779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x002B56F4 File Offset: 0x002B38F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286779, XrefRangeEnd = 286806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x002B5730 File Offset: 0x002B3930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286806, XrefRangeEnd = 286807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x002B576C File Offset: 0x002B396C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286852, RefRangeEnd = 286853, XrefRangeStart = 286807, XrefRangeEnd = 286852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_UpdateDestination_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x002B57A0 File Offset: 0x002B39A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286853, XrefRangeEnd = 286858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x002B57DC File Offset: 0x002B39DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286858, XrefRangeEnd = 286865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckExitVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x002B5810 File Offset: 0x002B3A10
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 286873, RefRangeEnd = 286880, XrefRangeStart = 286865, XrefRangeEnd = 286873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlayerChasePoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x002B584C File Offset: 0x002B3A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286882, RefRangeEnd = 286884, XrefRangeStart = 286880, XrefRangeEnd = 286882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAggressiveDriving(bool aggressive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aggressive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x002B588C File Offset: 0x002B3A8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 286893, RefRangeEnd = 286899, XrefRangeStart = 286884, XrefRangeEnd = 286893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveTo(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x002B58CC File Offset: 0x002B3ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286899, XrefRangeEnd = 286902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x002B590C File Offset: 0x002B3B0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286573, RefRangeEnd = 286576, XrefRangeStart = 286573, XrefRangeEnd = 286576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x002B5964 File Offset: 0x002B3B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286917, RefRangeEnd = 286918, XrefRangeStart = 286902, XrefRangeEnd = 286917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTargetVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x002B5998 File Offset: 0x002B3B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286918, XrefRangeEnd = 286922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkPlayerVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x002B59CC File Offset: 0x002B3BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286922, XrefRangeEnd = 286925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTargetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_IsTargetVisible_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x002B5A08 File Offset: 0x002B3C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286925, XrefRangeEnd = 286932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x002B5A4C File Offset: 0x002B3C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286932, XrefRangeEnd = 286936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessThirdPartyVisionEvent(VisionEventReceipt visionEventReceipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visionEventReceipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x002B5A90 File Offset: 0x002B3C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286936, XrefRangeEnd = 286945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TargetSpotted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x002B5ACC File Offset: 0x002B3CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286945, XrefRangeEnd = 286954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyServerTargetSeen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x002B5B00 File Offset: 0x002B3D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286954, XrefRangeEnd = 286957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePursuitBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePursuitBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x002B5B3C File Offset: 0x002B3D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286957, XrefRangeEnd = 286965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x002B5B78 File Offset: 0x002B3D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286965, XrefRangeEnd = 286966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x002B5BB4 File Offset: 0x002B3DB4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x002B5BF0 File Offset: 0x002B3DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_NotifyServerTargetSeen_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x002B5C24 File Offset: 0x002B3E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286966, XrefRangeEnd = 286968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___NotifyServerTargetSeen_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x002B5C58 File Offset: 0x002B3E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286968, XrefRangeEnd = 286971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePursuitBehaviour.NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x002B5CBC File Offset: 0x002B3EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePursuitBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0004AA95 File Offset: 0x00048C95
		public VehiclePursuitBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600A2FD RID: 41725 RVA: 0x002B5CF8 File Offset: 0x002B3EF8
		// (set) Token: 0x0600A2FE RID: 41726 RVA: 0x0004AA9E File Offset: 0x00048C9E
		public unsafe static float RECENT_VISIBILITY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x002B5D14 File Offset: 0x002B3F14
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x0004AAAC File Offset: 0x00048CAC
		public unsafe static float EXIT_VEHICLE_MAX_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600A301 RID: 41729 RVA: 0x002B5D30 File Offset: 0x002B3F30
		// (set) Token: 0x0600A302 RID: 41730 RVA: 0x0004AABA File Offset: 0x00048CBA
		public unsafe static float CLOSE_ENOUGH_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003113 RID: 12563
		// (get) Token: 0x0600A303 RID: 41731 RVA: 0x002B5D4C File Offset: 0x002B3F4C
		// (set) Token: 0x0600A304 RID: 41732 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		public unsafe static float UPDATE_FREQUENCY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_UPDATE_FREQUENCY, (void*)(&value));
			}
		}

		// Token: 0x17003114 RID: 12564
		// (get) Token: 0x0600A305 RID: 41733 RVA: 0x002B5D68 File Offset: 0x002B3F68
		// (set) Token: 0x0600A306 RID: 41734 RVA: 0x0004AAD6 File Offset: 0x00048CD6
		public unsafe static float STATIONARY_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_STATIONARY_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003115 RID: 12565
		// (get) Token: 0x0600A307 RID: 41735 RVA: 0x002B5D84 File Offset: 0x002B3F84
		// (set) Token: 0x0600A308 RID: 41736 RVA: 0x0004AAE4 File Offset: 0x00048CE4
		public unsafe static float TIME_STATIONARY_TO_EXIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePursuitBehaviour.NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT, (void*)(&value));
			}
		}

		// Token: 0x17003116 RID: 12566
		// (get) Token: 0x0600A309 RID: 41737 RVA: 0x002B5DA0 File Offset: 0x002B3FA0
		// (set) Token: 0x0600A30A RID: 41738 RVA: 0x0004AAF2 File Offset: 0x00048CF2
		public unsafe Player _Target_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__Target_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__Target_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003117 RID: 12567
		// (get) Token: 0x0600A30B RID: 41739 RVA: 0x002B5DD0 File Offset: 0x002B3FD0
		// (set) Token: 0x0600A30C RID: 41740 RVA: 0x0004AB11 File Offset: 0x00048D11
		public unsafe AnimationCurve RepathDistanceThresholdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_RepathDistanceThresholdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003118 RID: 12568
		// (get) Token: 0x0600A30D RID: 41741 RVA: 0x002B5E00 File Offset: 0x002B4000
		// (set) Token: 0x0600A30E RID: 41742 RVA: 0x0004AB30 File Offset: 0x00048D30
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003119 RID: 12569
		// (get) Token: 0x0600A30F RID: 41743 RVA: 0x002B5E30 File Offset: 0x002B4030
		// (set) Token: 0x0600A310 RID: 41744 RVA: 0x0004AB4F File Offset: 0x00048D4F
		public unsafe bool initialContactMade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_initialContactMade)) = value;
			}
		}

		// Token: 0x1700311A RID: 12570
		// (get) Token: 0x0600A311 RID: 41745 RVA: 0x002B5E58 File Offset: 0x002B4058
		// (set) Token: 0x0600A312 RID: 41746 RVA: 0x0004AB6A File Offset: 0x00048D6A
		public unsafe bool aggressiveDrivingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled)) = value;
			}
		}

		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x0600A313 RID: 41747 RVA: 0x002B5E80 File Offset: 0x002B4080
		// (set) Token: 0x0600A314 RID: 41748 RVA: 0x0004AB85 File Offset: 0x00048D85
		public unsafe bool _IsTargetRecentlyVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700311C RID: 12572
		// (get) Token: 0x0600A315 RID: 41749 RVA: 0x002B5EA8 File Offset: 0x002B40A8
		// (set) Token: 0x0600A316 RID: 41750 RVA: 0x0004ABA0 File Offset: 0x00048DA0
		public unsafe bool _IsTargetImmediatelyVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700311D RID: 12573
		// (get) Token: 0x0600A317 RID: 41751 RVA: 0x002B5ED0 File Offset: 0x002B40D0
		// (set) Token: 0x0600A318 RID: 41752 RVA: 0x0004ABBB File Offset: 0x00048DBB
		public unsafe float timeSinceLastSighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSinceLastSighting)) = value;
			}
		}

		// Token: 0x1700311E RID: 12574
		// (get) Token: 0x0600A319 RID: 41753 RVA: 0x002B5EF8 File Offset: 0x002B40F8
		// (set) Token: 0x0600A31A RID: 41754 RVA: 0x0004ABD6 File Offset: 0x00048DD6
		public unsafe bool visionEventReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_visionEventReceived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_visionEventReceived)) = value;
			}
		}

		// Token: 0x1700311F RID: 12575
		// (get) Token: 0x0600A31B RID: 41755 RVA: 0x002B5F20 File Offset: 0x002B4120
		// (set) Token: 0x0600A31C RID: 41756 RVA: 0x0004ABF1 File Offset: 0x00048DF1
		public unsafe int consecutiveVehiclePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutiveVehiclePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_consecutiveVehiclePathingFailures)) = value;
			}
		}

		// Token: 0x17003120 RID: 12576
		// (get) Token: 0x0600A31D RID: 41757 RVA: 0x002B5F48 File Offset: 0x002B4148
		// (set) Token: 0x0600A31E RID: 41758 RVA: 0x0004AC0C File Offset: 0x00048E0C
		public unsafe float timeStationary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeStationary)) = value;
			}
		}

		// Token: 0x17003121 RID: 12577
		// (get) Token: 0x0600A31F RID: 41759 RVA: 0x002B5F70 File Offset: 0x002B4170
		// (set) Token: 0x0600A320 RID: 41760 RVA: 0x0004AC27 File Offset: 0x00048E27
		public unsafe Vector3 currentDriveTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_currentDriveTarget)) = value;
			}
		}

		// Token: 0x17003122 RID: 12578
		// (get) Token: 0x0600A321 RID: 41761 RVA: 0x002B5F98 File Offset: 0x002B4198
		// (set) Token: 0x0600A322 RID: 41762 RVA: 0x0004AC42 File Offset: 0x00048E42
		public unsafe int targetChanges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_targetChanges)) = value;
			}
		}

		// Token: 0x17003123 RID: 12579
		// (get) Token: 0x0600A323 RID: 41763 RVA: 0x002B5FC0 File Offset: 0x002B41C0
		// (set) Token: 0x0600A324 RID: 41764 RVA: 0x0004AC5D File Offset: 0x00048E5D
		public unsafe float timeSincePursuitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_timeSincePursuitStart)) = value;
			}
		}

		// Token: 0x17003124 RID: 12580
		// (get) Token: 0x0600A325 RID: 41765 RVA: 0x002B5FE8 File Offset: 0x002B41E8
		// (set) Token: 0x0600A326 RID: 41766 RVA: 0x0004AC78 File Offset: 0x00048E78
		public unsafe bool beginAsSighted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_beginAsSighted)) = value;
			}
		}

		// Token: 0x17003125 RID: 12581
		// (get) Token: 0x0600A327 RID: 41767 RVA: 0x002B6010 File Offset: 0x002B4210
		// (set) Token: 0x0600A328 RID: 41768 RVA: 0x0004AC93 File Offset: 0x00048E93
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003126 RID: 12582
		// (get) Token: 0x0600A329 RID: 41769 RVA: 0x002B6038 File Offset: 0x002B4238
		// (set) Token: 0x0600A32A RID: 41770 RVA: 0x0004ACAE File Offset: 0x00048EAE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePursuitBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007076 RID: 28790
		private static readonly IntPtr NativeFieldInfoPtr_RECENT_VISIBILITY_THRESHOLD;

		// Token: 0x04007077 RID: 28791
		private static readonly IntPtr NativeFieldInfoPtr_EXIT_VEHICLE_MAX_SPEED;

		// Token: 0x04007078 RID: 28792
		private static readonly IntPtr NativeFieldInfoPtr_CLOSE_ENOUGH_THRESHOLD;

		// Token: 0x04007079 RID: 28793
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_FREQUENCY;

		// Token: 0x0400707A RID: 28794
		private static readonly IntPtr NativeFieldInfoPtr_STATIONARY_THRESHOLD;

		// Token: 0x0400707B RID: 28795
		private static readonly IntPtr NativeFieldInfoPtr_TIME_STATIONARY_TO_EXIT;

		// Token: 0x0400707C RID: 28796
		private static readonly IntPtr NativeFieldInfoPtr__Target_k__BackingField;

		// Token: 0x0400707D RID: 28797
		private static readonly IntPtr NativeFieldInfoPtr_RepathDistanceThresholdMap;

		// Token: 0x0400707E RID: 28798
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x0400707F RID: 28799
		private static readonly IntPtr NativeFieldInfoPtr_initialContactMade;

		// Token: 0x04007080 RID: 28800
		private static readonly IntPtr NativeFieldInfoPtr_aggressiveDrivingEnabled;

		// Token: 0x04007081 RID: 28801
		private static readonly IntPtr NativeFieldInfoPtr__IsTargetRecentlyVisible_k__BackingField;

		// Token: 0x04007082 RID: 28802
		private static readonly IntPtr NativeFieldInfoPtr__IsTargetImmediatelyVisible_k__BackingField;

		// Token: 0x04007083 RID: 28803
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceLastSighting;

		// Token: 0x04007084 RID: 28804
		private static readonly IntPtr NativeFieldInfoPtr_visionEventReceived;

		// Token: 0x04007085 RID: 28805
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveVehiclePathingFailures;

		// Token: 0x04007086 RID: 28806
		private static readonly IntPtr NativeFieldInfoPtr_timeStationary;

		// Token: 0x04007087 RID: 28807
		private static readonly IntPtr NativeFieldInfoPtr_currentDriveTarget;

		// Token: 0x04007088 RID: 28808
		private static readonly IntPtr NativeFieldInfoPtr_targetChanges;

		// Token: 0x04007089 RID: 28809
		private static readonly IntPtr NativeFieldInfoPtr_timeSincePursuitStart;

		// Token: 0x0400708A RID: 28810
		private static readonly IntPtr NativeFieldInfoPtr_beginAsSighted;

		// Token: 0x0400708B RID: 28811
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400708C RID: 28812
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400708D RID: 28813
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Player_0;

		// Token: 0x0400708E RID: 28814
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Protected_set_Void_Player_0;

		// Token: 0x0400708F RID: 28815
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTargetRecentlyVisible_Public_get_Boolean_0;

		// Token: 0x04007090 RID: 28816
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTargetRecentlyVisible_Private_set_Void_Boolean_0;

		// Token: 0x04007091 RID: 28817
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTargetImmediatelyVisible_Public_get_Boolean_0;

		// Token: 0x04007092 RID: 28818
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTargetImmediatelyVisible_Private_set_Void_Boolean_0;

		// Token: 0x04007093 RID: 28819
		private static readonly IntPtr NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0;

		// Token: 0x04007094 RID: 28820
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0;

		// Token: 0x04007095 RID: 28821
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04007096 RID: 28822
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007097 RID: 28823
		private static readonly IntPtr NativeMethodInfoPtr_BeginAsSighted_Public_Void_0;

		// Token: 0x04007098 RID: 28824
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04007099 RID: 28825
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x0400709A RID: 28826
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x0400709B RID: 28827
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x0400709C RID: 28828
		private static readonly IntPtr NativeMethodInfoPtr_AssignTarget_Public_Virtual_New_Void_Player_0;

		// Token: 0x0400709D RID: 28829
		private static readonly IntPtr NativeMethodInfoPtr_StartPursuit_Private_Void_0;

		// Token: 0x0400709E RID: 28830
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x0400709F RID: 28831
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x040070A0 RID: 28832
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040070A1 RID: 28833
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDestination_Private_Void_0;

		// Token: 0x040070A2 RID: 28834
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetValid_Private_Boolean_0;

		// Token: 0x040070A3 RID: 28835
		private static readonly IntPtr NativeMethodInfoPtr_CheckExitVehicle_Private_Void_0;

		// Token: 0x040070A4 RID: 28836
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerChasePoint_Private_Vector3_0;

		// Token: 0x040070A5 RID: 28837
		private static readonly IntPtr NativeMethodInfoPtr_SetAggressiveDriving_Private_Void_Boolean_0;

		// Token: 0x040070A6 RID: 28838
		private static readonly IntPtr NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0;

		// Token: 0x040070A7 RID: 28839
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0;

		// Token: 0x040070A8 RID: 28840
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x040070A9 RID: 28841
		private static readonly IntPtr NativeMethodInfoPtr_CheckTargetVisibility_Protected_Void_0;

		// Token: 0x040070AA RID: 28842
		private static readonly IntPtr NativeMethodInfoPtr_MarkPlayerVisible_Public_Void_0;

		// Token: 0x040070AB RID: 28843
		private static readonly IntPtr NativeMethodInfoPtr_IsTargetVisible_Protected_Boolean_0;

		// Token: 0x040070AC RID: 28844
		private static readonly IntPtr NativeMethodInfoPtr_ProcessVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x040070AD RID: 28845
		private static readonly IntPtr NativeMethodInfoPtr_ProcessThirdPartyVisionEvent_Private_Void_VisionEventReceipt_0;

		// Token: 0x040070AE RID: 28846
		private static readonly IntPtr NativeMethodInfoPtr_TargetSpotted_Protected_Virtual_New_Void_0;

		// Token: 0x040070AF RID: 28847
		private static readonly IntPtr NativeMethodInfoPtr_NotifyServerTargetSeen_Public_Void_0;

		// Token: 0x040070B0 RID: 28848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040070B1 RID: 28849
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040070B2 RID: 28850
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040070B3 RID: 28851
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040070B4 RID: 28852
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_NotifyServerTargetSeen_2166136261_Private_Void_0;

		// Token: 0x040070B5 RID: 28853
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___NotifyServerTargetSeen_2166136261_Public_Void_0;

		// Token: 0x040070B6 RID: 28854
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_NotifyServerTargetSeen_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040070B7 RID: 28855
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
