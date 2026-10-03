using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Combat;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x0200044D RID: 1101
	public class CartelGoon : NPC
	{
		// Token: 0x060063D3 RID: 25555 RVA: 0x001D5204 File Offset: 0x001D3404
		// Note: this type is marked as 'beforefieldinit'.
		static CartelGoon()
		{
			Il2CppClassPointerStore<CartelGoon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelGoon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr);
			CartelGoon.NativeFieldInfoPtr__IsGoonSpawned_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "<IsGoonSpawned>k__BackingField");
			CartelGoon.NativeFieldInfoPtr_goonMates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "goonMates");
			CartelGoon.NativeFieldInfoPtr_appearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "appearance");
			CartelGoon.NativeFieldInfoPtr_onDespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "onDespawn");
			CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted");
			CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted");
			CartelGoon.NativeMethodInfoPtr_get_IsGoonSpawned_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676413);
			CartelGoon.NativeMethodInfoPtr_set_IsGoonSpawned_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676414);
			CartelGoon.NativeMethodInfoPtr_get_GoonPool_Public_get_GoonPool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676415);
			CartelGoon.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676416);
			CartelGoon.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676417);
			CartelGoon.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676418);
			CartelGoon.NativeMethodInfoPtr_Spawn_Public_Void_GoonPool_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676419);
			CartelGoon.NativeMethodInfoPtr_Spawn_Client_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676420);
			CartelGoon.NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676421);
			CartelGoon.NativeMethodInfoPtr_Despawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676422);
			CartelGoon.NativeMethodInfoPtr_Despawn_Client_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676423);
			CartelGoon.NativeMethodInfoPtr_AttackEntity_Public_Void_ICombatTargetable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676424);
			CartelGoon.NativeMethodInfoPtr_AddGoonMate_Public_Void_CartelGoon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676425);
			CartelGoon.NativeMethodInfoPtr_RemoveGoonMate_Public_Void_CartelGoon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676426);
			CartelGoon.NativeMethodInfoPtr_IsMatesWith_Public_Boolean_CartelGoon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676427);
			CartelGoon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676428);
			CartelGoon.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676429);
			CartelGoon.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676430);
			CartelGoon.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676431);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_Spawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676432);
			CartelGoon.NativeMethodInfoPtr_RpcLogic___Spawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676433);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676434);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_Spawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676435);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Target_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676436);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676437);
			CartelGoon.NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676438);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676439);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676440);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676441);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_Despawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676442);
			CartelGoon.NativeMethodInfoPtr_RpcLogic___Despawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676443);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676444);
			CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_Despawn_Client_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676445);
			CartelGoon.NativeMethodInfoPtr_RpcReader___Target_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676446);
			CartelGoon.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr, 100676447);
		}

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x001D5568 File Offset: 0x001D3768
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x001D55A4 File Offset: 0x001D37A4
		public unsafe bool IsGoonSpawned
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 183607, RefRangeEnd = 183609, XrefRangeStart = 183607, XrefRangeEnd = 183609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_get_IsGoonSpawned_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_set_IsGoonSpawned_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x001D55E4 File Offset: 0x001D37E4
		public unsafe GoonPool GoonPool
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 209893, RefRangeEnd = 209903, XrefRangeStart = 209889, XrefRangeEnd = 209893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_get_GoonPool_Public_get_GoonPool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GoonPool>(intPtr3) : null;
			}
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x001D5624 File Offset: 0x001D3824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209903, XrefRangeEnd = 209912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x001D5660 File Offset: 0x001D3860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209912, XrefRangeEnd = 209914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x001D569C File Offset: 0x001D389C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209914, XrefRangeEnd = 209920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x001D56EC File Offset: 0x001D38EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209946, RefRangeEnd = 209947, XrefRangeStart = 209920, XrefRangeEnd = 209946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawn(GoonPool pool, Vector3 spawnPoint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pool);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spawnPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_Spawn_Public_Void_GoonPool_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x001D573C File Offset: 0x001D393C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 209984, RefRangeEnd = 209986, XrefRangeStart = 209947, XrefRangeEnd = 209984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spawn_Client(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_Spawn_Client_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x001D5780 File Offset: 0x001D3980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 210027, RefRangeEnd = 210029, XrefRangeStart = 209986, XrefRangeEnd = 210027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x001D57E4 File Offset: 0x001D39E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210055, RefRangeEnd = 210056, XrefRangeStart = 210029, XrefRangeEnd = 210055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Despawn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_Despawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x001D5818 File Offset: 0x001D3A18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210093, RefRangeEnd = 210096, XrefRangeStart = 210056, XrefRangeEnd = 210093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Despawn_Client(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_Despawn_Client_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x001D585C File Offset: 0x001D3A5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 210124, RefRangeEnd = 210130, XrefRangeStart = 210096, XrefRangeEnd = 210124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttackEntity(ICombatTargetable target, bool includeGoonMates = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeGoonMates;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_AttackEntity_Public_Void_ICombatTargetable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x001D58AC File Offset: 0x001D3AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210144, RefRangeEnd = 210145, XrefRangeStart = 210130, XrefRangeEnd = 210144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGoonMate(CartelGoon goonMate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(goonMate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_AddGoonMate_Public_Void_CartelGoon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x001D58F0 File Offset: 0x001D3AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210145, XrefRangeEnd = 210159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGoonMate(CartelGoon goonMate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(goonMate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RemoveGoonMate_Public_Void_CartelGoon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x001D5934 File Offset: 0x001D3B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210159, XrefRangeEnd = 210163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatesWith(CartelGoon otherGoon)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherGoon);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_IsMatesWith_Public_Boolean_CartelGoon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x001D5984 File Offset: 0x001D3B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210163, XrefRangeEnd = 210171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelGoon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelGoon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x001D59C0 File Offset: 0x001D3BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210171, XrefRangeEnd = 210209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x001D59FC File Offset: 0x001D3BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210209, XrefRangeEnd = 210210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x001D5A38 File Offset: 0x001D3C38
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x001D5A74 File Offset: 0x001D3C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210210, XrefRangeEnd = 210219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Spawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_Spawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x001D5AB8 File Offset: 0x001D3CB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210223, RefRangeEnd = 210226, XrefRangeStart = 210219, XrefRangeEnd = 210223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Spawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcLogic___Spawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x001D5AFC File Offset: 0x001D3CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210226, XrefRangeEnd = 210229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x001D5B4C File Offset: 0x001D3D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210229, XrefRangeEnd = 210238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Spawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_Spawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x001D5B90 File Offset: 0x001D3D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210238, XrefRangeEnd = 210241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Target_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x001D5BE0 File Offset: 0x001D3DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210241, XrefRangeEnd = 210252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x001D5C44 File Offset: 0x001D3E44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210266, RefRangeEnd = 210269, XrefRangeStart = 210252, XrefRangeEnd = 210266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x001D5CA8 File Offset: 0x001D3EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210269, XrefRangeEnd = 210274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x001D5CF8 File Offset: 0x001D3EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210274, XrefRangeEnd = 210285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appearance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x001D5D5C File Offset: 0x001D3F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210285, XrefRangeEnd = 210290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x001D5DAC File Offset: 0x001D3FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210290, XrefRangeEnd = 210299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Despawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Observers_Despawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x001D5DF0 File Offset: 0x001D3FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 210303, RefRangeEnd = 210306, XrefRangeStart = 210299, XrefRangeEnd = 210303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Despawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcLogic___Despawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x001D5E34 File Offset: 0x001D4034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210306, XrefRangeEnd = 210309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Despawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Observers_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x001D5E84 File Offset: 0x001D4084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210309, XrefRangeEnd = 210318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Despawn_Client_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcWriter___Target_Despawn_Client_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x001D5EC8 File Offset: 0x001D40C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210318, XrefRangeEnd = 210321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Despawn_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelGoon.NativeMethodInfoPtr_RpcReader___Target_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x001D5F18 File Offset: 0x001D4118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210321, XrefRangeEnd = 210322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelGoon.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0002F112 File Offset: 0x0002D312
		public CartelGoon(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x060063F8 RID: 25592 RVA: 0x001D5F54 File Offset: 0x001D4154
		// (set) Token: 0x060063F9 RID: 25593 RVA: 0x0002F11B File Offset: 0x0002D31B
		public unsafe bool _IsGoonSpawned_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr__IsGoonSpawned_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr__IsGoonSpawned_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x060063FA RID: 25594 RVA: 0x001D5F7C File Offset: 0x001D417C
		// (set) Token: 0x060063FB RID: 25595 RVA: 0x0002F136 File Offset: 0x0002D336
		public unsafe List<CartelGoon> goonMates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_goonMates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelGoon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_goonMates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x060063FC RID: 25596 RVA: 0x001D5FAC File Offset: 0x001D41AC
		// (set) Token: 0x060063FD RID: 25597 RVA: 0x0002F155 File Offset: 0x0002D355
		public unsafe CartelGoonAppearance appearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_appearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelGoonAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_appearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x060063FE RID: 25598 RVA: 0x001D5FDC File Offset: 0x001D41DC
		// (set) Token: 0x060063FF RID: 25599 RVA: 0x0002F174 File Offset: 0x0002D374
		public unsafe Action onDespawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_onDespawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_onDespawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x06006400 RID: 25600 RVA: 0x001D600C File Offset: 0x001D420C
		// (set) Token: 0x06006401 RID: 25601 RVA: 0x0002F193 File Offset: 0x0002D393
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x001D6034 File Offset: 0x001D4234
		// (set) Token: 0x06006403 RID: 25603 RVA: 0x0002F1AE File Offset: 0x0002D3AE
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelGoon.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040044D0 RID: 17616
		private static readonly IntPtr NativeFieldInfoPtr__IsGoonSpawned_k__BackingField;

		// Token: 0x040044D1 RID: 17617
		private static readonly IntPtr NativeFieldInfoPtr_goonMates;

		// Token: 0x040044D2 RID: 17618
		private static readonly IntPtr NativeFieldInfoPtr_appearance;

		// Token: 0x040044D3 RID: 17619
		private static readonly IntPtr NativeFieldInfoPtr_onDespawn;

		// Token: 0x040044D4 RID: 17620
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040044D5 RID: 17621
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040044D6 RID: 17622
		private static readonly IntPtr NativeMethodInfoPtr_get_IsGoonSpawned_Public_get_Boolean_0;

		// Token: 0x040044D7 RID: 17623
		private static readonly IntPtr NativeMethodInfoPtr_set_IsGoonSpawned_Private_set_Void_Boolean_0;

		// Token: 0x040044D8 RID: 17624
		private static readonly IntPtr NativeMethodInfoPtr_get_GoonPool_Public_get_GoonPool_0;

		// Token: 0x040044D9 RID: 17625
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040044DA RID: 17626
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x040044DB RID: 17627
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040044DC RID: 17628
		private static readonly IntPtr NativeMethodInfoPtr_Spawn_Public_Void_GoonPool_Vector3_0;

		// Token: 0x040044DD RID: 17629
		private static readonly IntPtr NativeMethodInfoPtr_Spawn_Client_Private_Void_NetworkConnection_0;

		// Token: 0x040044DE RID: 17630
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureGoonSettings_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x040044DF RID: 17631
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Public_Void_0;

		// Token: 0x040044E0 RID: 17632
		private static readonly IntPtr NativeMethodInfoPtr_Despawn_Client_Private_Void_NetworkConnection_0;

		// Token: 0x040044E1 RID: 17633
		private static readonly IntPtr NativeMethodInfoPtr_AttackEntity_Public_Void_ICombatTargetable_Boolean_0;

		// Token: 0x040044E2 RID: 17634
		private static readonly IntPtr NativeMethodInfoPtr_AddGoonMate_Public_Void_CartelGoon_0;

		// Token: 0x040044E3 RID: 17635
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGoonMate_Public_Void_CartelGoon_0;

		// Token: 0x040044E4 RID: 17636
		private static readonly IntPtr NativeMethodInfoPtr_IsMatesWith_Public_Boolean_CartelGoon_0;

		// Token: 0x040044E5 RID: 17637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044E6 RID: 17638
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040044E7 RID: 17639
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040044E8 RID: 17640
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040044E9 RID: 17641
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Spawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044EA RID: 17642
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Spawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044EB RID: 17643
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044EC RID: 17644
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Spawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044ED RID: 17645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Spawn_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044EE RID: 17646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x040044EF RID: 17647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x040044F0 RID: 17648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044F1 RID: 17649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ConfigureGoonSettings_3427656873_Private_Void_NetworkConnection_CartelGoonAppearance_Single_0;

		// Token: 0x040044F2 RID: 17650
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ConfigureGoonSettings_3427656873_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044F3 RID: 17651
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Despawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044F4 RID: 17652
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Despawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044F5 RID: 17653
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044F6 RID: 17654
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Despawn_Client_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040044F7 RID: 17655
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Despawn_Client_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040044F8 RID: 17656
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
