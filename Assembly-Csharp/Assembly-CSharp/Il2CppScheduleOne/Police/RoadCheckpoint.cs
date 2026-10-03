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
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Police
{
	// Token: 0x02000440 RID: 1088
	public class RoadCheckpoint : NetworkBehaviour
	{
		// Token: 0x06006213 RID: 25107 RVA: 0x001CF108 File Offset: 0x001CD308
		// Note: this type is marked as 'beforefieldinit'.
		static RoadCheckpoint()
		{
			Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Police", "RoadCheckpoint");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr);
			RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MAX_TIME_OPEN");
			RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<ActivationState>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_appliedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "appliedState");
			RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "AssignedNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "MaxStealthLevel");
			RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "OpenForNPCs");
			RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "EnabledOnStart");
			RoadCheckpoint.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "container");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper1");
			RoadCheckpoint.NativeFieldInfoPtr_Stopper2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "Stopper2");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea1");
			RoadCheckpoint.NativeFieldInfoPtr_SearchArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "SearchArea2");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle1");
			RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "VehicleObstacle2");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea1");
			RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NPCVehicleDetectionArea2");
			RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "ImmediateVehicleDetector");
			RoadCheckpoint.NativeFieldInfoPtr_TrafficCones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "TrafficCones");
			RoadCheckpoint.NativeFieldInfoPtr_StandPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "StandPoints");
			RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "trafficConeOriginalTransforms");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate1Open");
			RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "timeSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "vehicleDetectedSinceGate2Open");
			RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "onPlayerWalkThrough");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate1Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "syncVar___<Gate2Open>k__BackingField");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Police.RoadCheckpointAssembly-CSharp.dll_Excuted");
			RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676182);
			RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676183);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676184);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676185);
			RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676186);
			RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676187);
			RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676188);
			RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676189);
			RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676190);
			RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676191);
			RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676192);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676193);
			RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676194);
			RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676195);
			RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676196);
			RoadCheckpoint.NativeMethodInfoPtr_TryGetNearestAssignedNPC_Private_Boolean_byref_NPC_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676197);
			RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676198);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676199);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676200);
			RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676201);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676202);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676203);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676204);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676205);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676206);
			RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676207);
			RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676208);
			RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676209);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676210);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676211);
			RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676212);
			RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676213);
			RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676214);
			RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr, 100676215);
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x06006214 RID: 25108 RVA: 0x001CF64C File Offset: 0x001CD84C
		// (set) Token: 0x06006215 RID: 25109 RVA: 0x001CF688 File Offset: 0x001CD888
		public unsafe RoadCheckpoint.ECheckpointState ActivationState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06006216 RID: 25110 RVA: 0x001CF6C8 File Offset: 0x001CD8C8
		// (set) Token: 0x06006217 RID: 25111 RVA: 0x001CF704 File Offset: 0x001CD904
		public unsafe bool Gate1Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 207449, RefRangeEnd = 207455, XrefRangeStart = 207442, XrefRangeEnd = 207449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06006218 RID: 25112 RVA: 0x001CF744 File Offset: 0x001CD944
		// (set) Token: 0x06006219 RID: 25113 RVA: 0x001CF780 File Offset: 0x001CD980
		public unsafe bool Gate2Open
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 207462, RefRangeEnd = 207466, XrefRangeStart = 207455, XrefRangeEnd = 207462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x001CF7C0 File Offset: 0x001CD9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207466, XrefRangeEnd = 207467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x001CF7FC File Offset: 0x001CD9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207467, XrefRangeEnd = 207499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x001CF838 File Offset: 0x001CDA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207499, XrefRangeEnd = 207502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x001CF874 File Offset: 0x001CDA74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207539, RefRangeEnd = 207543, XrefRangeStart = 207502, XrefRangeEnd = 207539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x001CF8B8 File Offset: 0x001CDAB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207564, RefRangeEnd = 207566, XrefRangeStart = 207543, XrefRangeEnd = 207564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x001CF8EC File Offset: 0x001CDAEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 207449, RefRangeEnd = 207455, XrefRangeStart = 207449, XrefRangeEnd = 207455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate1Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x001CF92C File Offset: 0x001CDB2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207462, RefRangeEnd = 207466, XrefRangeStart = 207462, XrefRangeEnd = 207466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGate2Open(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref o;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x001CF96C File Offset: 0x001CDB6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 207581, RefRangeEnd = 207585, XrefRangeStart = 207566, XrefRangeEnd = 207581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetTrafficCones()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x001CF9A0 File Offset: 0x001CDBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207585, XrefRangeEnd = 207588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerDetected(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x001CF9E4 File Offset: 0x001CDBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207611, RefRangeEnd = 207612, XrefRangeStart = 207588, XrefRangeEnd = 207611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetNearestAssignedNPC(out NPC npc, out float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &distance;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_TryGetNearestAssignedNPC_Private_Boolean_byref_NPC_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			npc = ((intPtr4 == 0) ? null : new NPC(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x001CFA50 File Offset: 0x001CDC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207612, XrefRangeEnd = 207627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoadCheckpoint() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoadCheckpoint>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x001CFA8C File Offset: 0x001CDC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207627, XrefRangeEnd = 207669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x001CFAC8 File Offset: 0x001CDCC8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x001CFB04 File Offset: 0x001CDD04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x001CFB40 File Offset: 0x001CDD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207669, XrefRangeEnd = 207678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x001CFB84 File Offset: 0x001CDD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207678, XrefRangeEnd = 207679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x001CFBC8 File Offset: 0x001CDDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207679, XrefRangeEnd = 207682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x001CFC18 File Offset: 0x001CDE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207682, XrefRangeEnd = 207691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x001CFC5C File Offset: 0x001CDE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207691, XrefRangeEnd = 207694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x001CFCAC File Offset: 0x001CDEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207694, XrefRangeEnd = 207703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x001CFCE0 File Offset: 0x001CDEE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 207716, RefRangeEnd = 207718, XrefRangeStart = 207703, XrefRangeEnd = 207716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x001CFD14 File Offset: 0x001CDF14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207718, XrefRangeEnd = 207721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x06006230 RID: 25136 RVA: 0x001CFD64 File Offset: 0x001CDF64
		// (set) Token: 0x06006231 RID: 25137 RVA: 0x001CFDA0 File Offset: 0x001CDFA0
		public unsafe bool SyncAccessor_<Gate1Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207721, XrefRangeEnd = 207729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x001CFDEC File Offset: 0x001CDFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207729, XrefRangeEnd = 207730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Police_RoadCheckpoint(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x06006233 RID: 25139 RVA: 0x001CFE60 File Offset: 0x001CE060
		// (set) Token: 0x06006234 RID: 25140 RVA: 0x001CFE9C File Offset: 0x001CE09C
		public unsafe bool SyncAccessor_<Gate2Open>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 207730, XrefRangeEnd = 207738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoadCheckpoint.NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x001CFEE8 File Offset: 0x001CE0E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207755, RefRangeEnd = 207756, XrefRangeStart = 207738, XrefRangeEnd = 207755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoadCheckpoint.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x0002E4E7 File Offset: 0x0002C6E7
		public RoadCheckpoint(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06006237 RID: 25143 RVA: 0x001CFF24 File Offset: 0x001CE124
		// (set) Token: 0x06006238 RID: 25144 RVA: 0x0002E4F0 File Offset: 0x0002C6F0
		public unsafe static float MAX_TIME_OPEN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RoadCheckpoint.NativeFieldInfoPtr_MAX_TIME_OPEN, (void*)(&value));
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06006239 RID: 25145 RVA: 0x001CFF40 File Offset: 0x001CE140
		// (set) Token: 0x0600623A RID: 25146 RVA: 0x0002E4FE File Offset: 0x0002C6FE
		public unsafe RoadCheckpoint.ECheckpointState _ActivationState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__ActivationState_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x0600623B RID: 25147 RVA: 0x001CFF68 File Offset: 0x001CE168
		// (set) Token: 0x0600623C RID: 25148 RVA: 0x0002E519 File Offset: 0x0002C719
		public unsafe RoadCheckpoint.ECheckpointState appliedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_appliedState)) = value;
			}
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600623D RID: 25149 RVA: 0x001CFF90 File Offset: 0x001CE190
		// (set) Token: 0x0600623E RID: 25150 RVA: 0x0002E534 File Offset: 0x0002C734
		public unsafe bool _Gate1Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate1Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x0600623F RID: 25151 RVA: 0x001CFFB8 File Offset: 0x001CE1B8
		// (set) Token: 0x06006240 RID: 25152 RVA: 0x0002E54F File Offset: 0x0002C74F
		public unsafe bool _Gate2Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr__Gate2Open_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06006241 RID: 25153 RVA: 0x001CFFE0 File Offset: 0x001CE1E0
		// (set) Token: 0x06006242 RID: 25154 RVA: 0x0002E56A File Offset: 0x0002C76A
		public unsafe List<NPC> AssignedNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_AssignedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06006243 RID: 25155 RVA: 0x001D0010 File Offset: 0x001CE210
		// (set) Token: 0x06006244 RID: 25156 RVA: 0x0002E589 File Offset: 0x0002C789
		public unsafe EStealthLevel MaxStealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_MaxStealthLevel)) = value;
			}
		}

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06006245 RID: 25157 RVA: 0x001D0038 File Offset: 0x001CE238
		// (set) Token: 0x06006246 RID: 25158 RVA: 0x0002E5A4 File Offset: 0x0002C7A4
		public unsafe bool OpenForNPCs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_OpenForNPCs)) = value;
			}
		}

		// Token: 0x17001E26 RID: 7718
		// (get) Token: 0x06006247 RID: 25159 RVA: 0x001D0060 File Offset: 0x001CE260
		// (set) Token: 0x06006248 RID: 25160 RVA: 0x0002E5BF File Offset: 0x0002C7BF
		public unsafe bool EnabledOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_EnabledOnStart)) = value;
			}
		}

		// Token: 0x17001E27 RID: 7719
		// (get) Token: 0x06006249 RID: 25161 RVA: 0x001D0088 File Offset: 0x001CE288
		// (set) Token: 0x0600624A RID: 25162 RVA: 0x0002E5DA File Offset: 0x0002C7DA
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600624B RID: 25163 RVA: 0x001D00B8 File Offset: 0x001CE2B8
		// (set) Token: 0x0600624C RID: 25164 RVA: 0x0002E5F9 File Offset: 0x0002C7F9
		public unsafe CarStopper Stopper1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600624D RID: 25165 RVA: 0x001D00E8 File Offset: 0x001CE2E8
		// (set) Token: 0x0600624E RID: 25166 RVA: 0x0002E618 File Offset: 0x0002C818
		public unsafe CarStopper Stopper2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CarStopper>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_Stopper2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600624F RID: 25167 RVA: 0x001D0118 File Offset: 0x001CE318
		// (set) Token: 0x06006250 RID: 25168 RVA: 0x0002E637 File Offset: 0x0002C837
		public unsafe VehicleDetector SearchArea1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x06006251 RID: 25169 RVA: 0x001D0148 File Offset: 0x001CE348
		// (set) Token: 0x06006252 RID: 25170 RVA: 0x0002E656 File Offset: 0x0002C856
		public unsafe VehicleDetector SearchArea2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_SearchArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x06006253 RID: 25171 RVA: 0x001D0178 File Offset: 0x001CE378
		// (set) Token: 0x06006254 RID: 25172 RVA: 0x0002E675 File Offset: 0x0002C875
		public unsafe VehicleObstacle VehicleObstacle1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x06006255 RID: 25173 RVA: 0x001D01A8 File Offset: 0x001CE3A8
		// (set) Token: 0x06006256 RID: 25174 RVA: 0x0002E694 File Offset: 0x0002C894
		public unsafe VehicleObstacle VehicleObstacle2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_VehicleObstacle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06006257 RID: 25175 RVA: 0x001D01D8 File Offset: 0x001CE3D8
		// (set) Token: 0x06006258 RID: 25176 RVA: 0x0002E6B3 File Offset: 0x0002C8B3
		public unsafe VehicleDetector NPCVehicleDetectionArea1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06006259 RID: 25177 RVA: 0x001D0208 File Offset: 0x001CE408
		// (set) Token: 0x0600625A RID: 25178 RVA: 0x0002E6D2 File Offset: 0x0002C8D2
		public unsafe VehicleDetector NPCVehicleDetectionArea2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_NPCVehicleDetectionArea2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600625B RID: 25179 RVA: 0x001D0238 File Offset: 0x001CE438
		// (set) Token: 0x0600625C RID: 25180 RVA: 0x0002E6F1 File Offset: 0x0002C8F1
		public unsafe VehicleDetector ImmediateVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_ImmediateVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x001D0268 File Offset: 0x001CE468
		// (set) Token: 0x0600625E RID: 25182 RVA: 0x0002E710 File Offset: 0x0002C910
		public unsafe Il2CppReferenceArray<Rigidbody> TrafficCones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Rigidbody>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_TrafficCones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600625F RID: 25183 RVA: 0x001D0298 File Offset: 0x001CE498
		// (set) Token: 0x06006260 RID: 25184 RVA: 0x0002E72F File Offset: 0x0002C92F
		public unsafe Il2CppReferenceArray<Transform> StandPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_StandPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x001D02C8 File Offset: 0x001CE4C8
		// (set) Token: 0x06006262 RID: 25186 RVA: 0x0002E74E File Offset: 0x0002C94E
		public unsafe Dictionary<Rigidbody, Tuple<Vector3, Quaternion>> trafficConeOriginalTransforms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Rigidbody, Tuple<Vector3, Quaternion>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_trafficConeOriginalTransforms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06006263 RID: 25187 RVA: 0x001D02F8 File Offset: 0x001CE4F8
		// (set) Token: 0x06006264 RID: 25188 RVA: 0x0002E76D File Offset: 0x0002C96D
		public unsafe float timeSinceGate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate1Open)) = value;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06006265 RID: 25189 RVA: 0x001D0320 File Offset: 0x001CE520
		// (set) Token: 0x06006266 RID: 25190 RVA: 0x0002E788 File Offset: 0x0002C988
		public unsafe bool vehicleDetectedSinceGate1Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate1Open)) = value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06006267 RID: 25191 RVA: 0x001D0348 File Offset: 0x001CE548
		// (set) Token: 0x06006268 RID: 25192 RVA: 0x0002E7A3 File Offset: 0x0002C9A3
		public unsafe float timeSinceGate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_timeSinceGate2Open)) = value;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x06006269 RID: 25193 RVA: 0x001D0370 File Offset: 0x001CE570
		// (set) Token: 0x0600626A RID: 25194 RVA: 0x0002E7BE File Offset: 0x0002C9BE
		public unsafe bool vehicleDetectedSinceGate2Open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_vehicleDetectedSinceGate2Open)) = value;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600626B RID: 25195 RVA: 0x001D0398 File Offset: 0x001CE598
		// (set) Token: 0x0600626C RID: 25196 RVA: 0x0002E7D9 File Offset: 0x0002C9D9
		public unsafe UnityEvent<Player> onPlayerWalkThrough
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_onPlayerWalkThrough), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x0600626D RID: 25197 RVA: 0x001D03C8 File Offset: 0x001CE5C8
		// (set) Token: 0x0600626E RID: 25198 RVA: 0x0002E7F8 File Offset: 0x0002C9F8
		public unsafe SyncVar<bool> syncVar____Gate1Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x0600626F RID: 25199 RVA: 0x001D03F8 File Offset: 0x001CE5F8
		// (set) Token: 0x06006270 RID: 25200 RVA: 0x0002E817 File Offset: 0x0002CA17
		public unsafe SyncVar<bool> syncVar____Gate2Open_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06006271 RID: 25201 RVA: 0x001D0428 File Offset: 0x001CE628
		// (set) Token: 0x06006272 RID: 25202 RVA: 0x0002E836 File Offset: 0x0002CA36
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06006273 RID: 25203 RVA: 0x001D0450 File Offset: 0x001CE650
		// (set) Token: 0x06006274 RID: 25204 RVA: 0x0002E851 File Offset: 0x0002CA51
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoadCheckpoint.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400439A RID: 17306
		private static readonly IntPtr NativeFieldInfoPtr_MAX_TIME_OPEN;

		// Token: 0x0400439B RID: 17307
		private static readonly IntPtr NativeFieldInfoPtr__ActivationState_k__BackingField;

		// Token: 0x0400439C RID: 17308
		private static readonly IntPtr NativeFieldInfoPtr_appliedState;

		// Token: 0x0400439D RID: 17309
		private static readonly IntPtr NativeFieldInfoPtr__Gate1Open_k__BackingField;

		// Token: 0x0400439E RID: 17310
		private static readonly IntPtr NativeFieldInfoPtr__Gate2Open_k__BackingField;

		// Token: 0x0400439F RID: 17311
		private static readonly IntPtr NativeFieldInfoPtr_AssignedNPCs;

		// Token: 0x040043A0 RID: 17312
		private static readonly IntPtr NativeFieldInfoPtr_MaxStealthLevel;

		// Token: 0x040043A1 RID: 17313
		private static readonly IntPtr NativeFieldInfoPtr_OpenForNPCs;

		// Token: 0x040043A2 RID: 17314
		private static readonly IntPtr NativeFieldInfoPtr_EnabledOnStart;

		// Token: 0x040043A3 RID: 17315
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040043A4 RID: 17316
		private static readonly IntPtr NativeFieldInfoPtr_Stopper1;

		// Token: 0x040043A5 RID: 17317
		private static readonly IntPtr NativeFieldInfoPtr_Stopper2;

		// Token: 0x040043A6 RID: 17318
		private static readonly IntPtr NativeFieldInfoPtr_SearchArea1;

		// Token: 0x040043A7 RID: 17319
		private static readonly IntPtr NativeFieldInfoPtr_SearchArea2;

		// Token: 0x040043A8 RID: 17320
		private static readonly IntPtr NativeFieldInfoPtr_VehicleObstacle1;

		// Token: 0x040043A9 RID: 17321
		private static readonly IntPtr NativeFieldInfoPtr_VehicleObstacle2;

		// Token: 0x040043AA RID: 17322
		private static readonly IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea1;

		// Token: 0x040043AB RID: 17323
		private static readonly IntPtr NativeFieldInfoPtr_NPCVehicleDetectionArea2;

		// Token: 0x040043AC RID: 17324
		private static readonly IntPtr NativeFieldInfoPtr_ImmediateVehicleDetector;

		// Token: 0x040043AD RID: 17325
		private static readonly IntPtr NativeFieldInfoPtr_TrafficCones;

		// Token: 0x040043AE RID: 17326
		private static readonly IntPtr NativeFieldInfoPtr_StandPoints;

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeFieldInfoPtr_trafficConeOriginalTransforms;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceGate1Open;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate1Open;

		// Token: 0x040043B2 RID: 17330
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceGate2Open;

		// Token: 0x040043B3 RID: 17331
		private static readonly IntPtr NativeFieldInfoPtr_vehicleDetectedSinceGate2Open;

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeFieldInfoPtr_onPlayerWalkThrough;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Gate1Open_k__BackingField;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____Gate2Open_k__BackingField;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040043B8 RID: 17336
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040043B9 RID: 17337
		private static readonly IntPtr NativeMethodInfoPtr_get_ActivationState_Public_get_ECheckpointState_0;

		// Token: 0x040043BA RID: 17338
		private static readonly IntPtr NativeMethodInfoPtr_set_ActivationState_Protected_set_Void_ECheckpointState_0;

		// Token: 0x040043BB RID: 17339
		private static readonly IntPtr NativeMethodInfoPtr_get_Gate1Open_Public_get_Boolean_0;

		// Token: 0x040043BC RID: 17340
		private static readonly IntPtr NativeMethodInfoPtr_set_Gate1Open_Protected_set_Void_Boolean_0;

		// Token: 0x040043BD RID: 17341
		private static readonly IntPtr NativeMethodInfoPtr_get_Gate2Open_Public_get_Boolean_0;

		// Token: 0x040043BE RID: 17342
		private static readonly IntPtr NativeMethodInfoPtr_set_Gate2Open_Protected_set_Void_Boolean_0;

		// Token: 0x040043BF RID: 17343
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040043C0 RID: 17344
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_1;

		// Token: 0x040043C1 RID: 17345
		private static readonly IntPtr NativeMethodInfoPtr_ApplyState_Protected_Virtual_New_Void_1;

		// Token: 0x040043C2 RID: 17346
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x040043C3 RID: 17347
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040043C4 RID: 17348
		private static readonly IntPtr NativeMethodInfoPtr_SetGate1Open_Public_Void_Boolean_0;

		// Token: 0x040043C5 RID: 17349
		private static readonly IntPtr NativeMethodInfoPtr_SetGate2Open_Public_Void_Boolean_0;

		// Token: 0x040043C6 RID: 17350
		private static readonly IntPtr NativeMethodInfoPtr_ResetTrafficCones_Private_Void_0;

		// Token: 0x040043C7 RID: 17351
		private static readonly IntPtr NativeMethodInfoPtr_PlayerDetected_Public_Void_Player_0;

		// Token: 0x040043C8 RID: 17352
		private static readonly IntPtr NativeMethodInfoPtr_TryGetNearestAssignedNPC_Private_Boolean_byref_NPC_byref_Single_0;

		// Token: 0x040043C9 RID: 17353
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040043CA RID: 17354
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040043CB RID: 17355
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040043CC RID: 17356
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040043CD RID: 17357
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040043CE RID: 17358
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x040043CF RID: 17359
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043D0 RID: 17360
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040043D1 RID: 17361
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043D2 RID: 17362
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x040043D3 RID: 17363
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x040043D4 RID: 17364
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Gate1Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Gate1Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Police_RoadCheckpoint_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x040043D8 RID: 17368
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__Gate2Open_k__BackingField_Public_get_Boolean_0;

		// Token: 0x040043D9 RID: 17369
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__Gate2Open_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x040043DA RID: 17370
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000B33 RID: 2867
		[OriginalName("Assembly-CSharp.dll", "", "ECheckpointState")]
		public enum ECheckpointState
		{
			// Token: 0x04009C96 RID: 40086
			Disabled,
			// Token: 0x04009C97 RID: 40087
			Enabled
		}
	}
}
