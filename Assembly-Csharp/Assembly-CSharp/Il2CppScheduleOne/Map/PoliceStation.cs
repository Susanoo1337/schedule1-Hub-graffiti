using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002CC RID: 716
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x00135E3C File Offset: 0x0013403C
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceStation()
		{
			Il2CppClassPointerStore<PoliceStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "PoliceStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr);
			PoliceStation.NativeFieldInfoPtr_PoliceStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceStations");
			PoliceStation.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "SpawnPoint");
			PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PossessedVehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PoliceVehicleParkingLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceVehicleParkingLot");
			PoliceStation.NativeFieldInfoPtr_PoliceVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceVehicles");
			PoliceStation.NativeFieldInfoPtr__OfficerPool_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<OfficerPool>k__BackingField");
			PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<TimeSinceLastDispatch>k__BackingField");
			PoliceStation.NativeFieldInfoPtr_deployedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "deployedVehicles");
			PoliceStation.NativeMethodInfoPtr_get_OfficerPool_Public_get_List_1_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670399);
			PoliceStation.NativeMethodInfoPtr_set_OfficerPool_Private_set_Void_List_1_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670400);
			PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670401);
			PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670402);
			PoliceStation.NativeMethodInfoPtr_get_AvailableVehicleCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670403);
			PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670404);
			PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670405);
			PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670406);
			PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670407);
			PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670408);
			PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670409);
			PoliceStation.NativeMethodInfoPtr_DeployVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670410);
			PoliceStation.NativeMethodInfoPtr_TryDeployVehicle_Public_Boolean_byref_LandVehicle_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670411);
			PoliceStation.NativeMethodInfoPtr_ReturnVehicle_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670412);
			PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670413);
			PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670414);
			PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670415);
			PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670416);
			PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670418);
			PoliceStation.NativeMethodInfoPtr__TryDeployVehicle_b__26_0_Private_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100670419);
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600381C RID: 14364 RVA: 0x001360B0 File Offset: 0x001342B0
		// (set) Token: 0x0600381D RID: 14365 RVA: 0x001360F0 File Offset: 0x001342F0
		public unsafe List<PoliceOfficer> OfficerPool
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_OfficerPool_Public_get_List_1_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_set_OfficerPool_Private_set_Void_List_1_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600381E RID: 14366 RVA: 0x00136134 File Offset: 0x00134334
		// (set) Token: 0x0600381F RID: 14367 RVA: 0x00136170 File Offset: 0x00134370
		public unsafe float TimeSinceLastDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06003820 RID: 14368 RVA: 0x001361B0 File Offset: 0x001343B0
		public unsafe int AvailableVehicleCount
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 144405, RefRangeEnd = 144409, XrefRangeStart = 144384, XrefRangeEnd = 144405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_AvailableVehicleCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x001361EC File Offset: 0x001343EC
		public unsafe int deployedVehicleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144409, XrefRangeEnd = 144430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003822 RID: 14370 RVA: 0x00136228 File Offset: 0x00134428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144430, XrefRangeEnd = 144444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003823 RID: 14371 RVA: 0x00136264 File Offset: 0x00134464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144444, XrefRangeEnd = 144457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003824 RID: 14372 RVA: 0x00136298 File Offset: 0x00134498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144457, XrefRangeEnd = 144458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x001362CC File Offset: 0x001344CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144526, RefRangeEnd = 144528, XrefRangeStart = 144458, XrefRangeEnd = 144526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedOfficerCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00136338 File Offset: 0x00134538
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 144537, RefRangeEnd = 144541, XrefRangeStart = 144528, XrefRangeEnd = 144537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer PullOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00136378 File Offset: 0x00134578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144564, RefRangeEnd = 144566, XrefRangeStart = 144541, XrefRangeEnd = 144564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle DeployVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_DeployVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06003828 RID: 14376 RVA: 0x001363B8 File Offset: 0x001345B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144589, RefRangeEnd = 144590, XrefRangeStart = 144566, XrefRangeEnd = 144589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryDeployVehicle(out LandVehicle vehicle, Transform spawnPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(spawnPoint);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_TryDeployVehicle_Public_Boolean_byref_LandVehicle_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			vehicle = ((intPtr4 == 0) ? null : new LandVehicle(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00136428 File Offset: 0x00134628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144590, XrefRangeEnd = 144601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnVehicle(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_ReturnVehicle_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382A RID: 14378 RVA: 0x0013646C File Offset: 0x0013466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144601, XrefRangeEnd = 144612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCEnteredBuilding(NPC npc, StaticDoor door)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(door);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_StaticDoor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x001364CC File Offset: 0x001346CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144612, XrefRangeEnd = 144618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCExitedBuilding(NPC npc, StaticDoor door)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(door);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_StaticDoor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x0013652C File Offset: 0x0013472C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 144626, RefRangeEnd = 144636, XrefRangeStart = 144618, XrefRangeEnd = 144626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x0013656C File Offset: 0x0013476C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144636, XrefRangeEnd = 144651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x001365A8 File Offset: 0x001347A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144651, XrefRangeEnd = 144667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Transform_PDM_0(Transform spawnPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spawnPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x001365EC File Offset: 0x001347EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144667, XrefRangeEnd = 144670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TryDeployVehicle_b__26_0(LandVehicle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr__TryDeployVehicle_b__26_0_Private_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003830 RID: 14384 RVA: 0x0001C72E File Offset: 0x0001A92E
		public PoliceStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0013663C File Offset: 0x0013483C
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x0001C737 File Offset: 0x0001A937
		public unsafe static List<PoliceStation> PoliceStations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceStation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x00136664 File Offset: 0x00134864
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x0001C749 File Offset: 0x0001A949
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x00136694 File Offset: 0x00134894
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x0001C768 File Offset: 0x0001A968
		public unsafe Il2CppReferenceArray<Transform> VehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x001366C4 File Offset: 0x001348C4
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x0001C787 File Offset: 0x0001A987
		public unsafe Il2CppReferenceArray<Transform> PossessedVehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x001366F4 File Offset: 0x001348F4
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x0001C7A6 File Offset: 0x0001A9A6
		public unsafe ParkingLot PoliceVehicleParkingLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehicleParkingLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehicleParkingLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x00136724 File Offset: 0x00134924
		// (set) Token: 0x0600383C RID: 14396 RVA: 0x0001C7C5 File Offset: 0x0001A9C5
		public unsafe Il2CppReferenceArray<LandVehicle> PoliceVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x00136754 File Offset: 0x00134954
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
		public unsafe List<PoliceOfficer> _OfficerPool_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__OfficerPool_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__OfficerPool_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x00136784 File Offset: 0x00134984
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x0001C803 File Offset: 0x0001AA03
		public unsafe float _TimeSinceLastDispatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField)) = value;
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x001367AC File Offset: 0x001349AC
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x0001C81E File Offset: 0x0001AA1E
		public unsafe List<LandVehicle> deployedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002596 RID: 9622
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStations;

		// Token: 0x04002597 RID: 9623
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04002598 RID: 9624
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSpawnPoints;

		// Token: 0x04002599 RID: 9625
		private static readonly IntPtr NativeFieldInfoPtr_PossessedVehicleSpawnPoints;

		// Token: 0x0400259A RID: 9626
		private static readonly IntPtr NativeFieldInfoPtr_PoliceVehicleParkingLot;

		// Token: 0x0400259B RID: 9627
		private static readonly IntPtr NativeFieldInfoPtr_PoliceVehicles;

		// Token: 0x0400259C RID: 9628
		private static readonly IntPtr NativeFieldInfoPtr__OfficerPool_k__BackingField;

		// Token: 0x0400259D RID: 9629
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField;

		// Token: 0x0400259E RID: 9630
		private static readonly IntPtr NativeFieldInfoPtr_deployedVehicles;

		// Token: 0x0400259F RID: 9631
		private static readonly IntPtr NativeMethodInfoPtr_get_OfficerPool_Public_get_List_1_PoliceOfficer_0;

		// Token: 0x040025A0 RID: 9632
		private static readonly IntPtr NativeMethodInfoPtr_set_OfficerPool_Private_set_Void_List_1_PoliceOfficer_0;

		// Token: 0x040025A1 RID: 9633
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0;

		// Token: 0x040025A2 RID: 9634
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0;

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr_get_AvailableVehicleCount_Public_get_Int32_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0;

		// Token: 0x040025A5 RID: 9637
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040025A6 RID: 9638
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040025A7 RID: 9639
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040025A8 RID: 9640
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0;

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_DeployVehicle_Public_LandVehicle_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_TryDeployVehicle_Public_Boolean_byref_LandVehicle_Transform_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_ReturnVehicle_Public_Void_LandVehicle_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_StaticDoor_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_StaticDoor_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr__TryDeployVehicle_b__26_0_Private_Boolean_LandVehicle_0;

		// Token: 0x02000A22 RID: 2594
		[OriginalName("Assembly-CSharp.dll", "", "EDispatchType")]
		public enum EDispatchType
		{
			// Token: 0x040097AC RID: 38828
			Auto,
			// Token: 0x040097AD RID: 38829
			UseVehicle,
			// Token: 0x040097AE RID: 38830
			OnFoot
		}

		// Token: 0x02000A23 RID: 2595
		[ObfuscatedName("ScheduleOne.Map.PoliceStation+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE9E RID: 56990 RVA: 0x0036E0D0 File Offset: 0x0036C2D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr);
				PoliceStation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9");
				PoliceStation.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9__19_0");
				PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100670421);
				PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__19_0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100670422);
			}

			// Token: 0x0600DE9F RID: 56991 RVA: 0x0036E14C File Offset: 0x0036C34C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA0 RID: 56992 RVA: 0x0036E188 File Offset: 0x0036C388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144380, XrefRangeEnd = 144384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_deployedVehicleCount_b__19_0(LandVehicle v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__19_0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DEA1 RID: 56993 RVA: 0x00068CEF File Offset: 0x00066EEF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043C8 RID: 17352
			// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x0036E1D8 File Offset: 0x0036C3D8
			// (set) Token: 0x0600DEA3 RID: 56995 RVA: 0x00068CF8 File Offset: 0x00066EF8
			public unsafe static PoliceStation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043C9 RID: 17353
			// (get) Token: 0x0600DEA4 RID: 56996 RVA: 0x0036E200 File Offset: 0x0036C400
			// (set) Token: 0x0600DEA5 RID: 56997 RVA: 0x00068D0A File Offset: 0x00066F0A
			public unsafe static Func<LandVehicle, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LandVehicle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097AF RID: 38831
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040097B0 RID: 38832
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x040097B1 RID: 38833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040097B2 RID: 38834
			private static readonly IntPtr NativeMethodInfoPtr__get_deployedVehicleCount_b__19_0_Internal_Boolean_LandVehicle_0;
		}
	}
}
