using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002C9 RID: 713
	public class SewerMushrooms : NetworkBehaviour
	{
		// Token: 0x060037D2 RID: 14290 RVA: 0x00134EA4 File Offset: 0x001330A4
		// Note: this type is marked as 'beforefieldinit'.
		static SewerMushrooms()
		{
			Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "SewerMushrooms");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr);
			SewerMushrooms.NativeFieldInfoPtr_MushroomObjectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "MushroomObjectPrefab");
			SewerMushrooms.NativeFieldInfoPtr_MushroomSpawnSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "MushroomSpawnSettings");
			SewerMushrooms.NativeFieldInfoPtr_MushroomAreas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "MushroomAreas");
			SewerMushrooms.NativeFieldInfoPtr_MushroomLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "MushroomLocations");
			SewerMushrooms.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_debugMode");
			SewerMushrooms.NativeFieldInfoPtr__activeMushroomLocationIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_activeMushroomLocationIndices");
			SewerMushrooms.NativeFieldInfoPtr__spawnedMushroomItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_spawnedMushroomItems");
			SewerMushrooms.NativeFieldInfoPtr__availableMushroomSpawnLocationIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_availableMushroomSpawnLocationIndices");
			SewerMushrooms.NativeFieldInfoPtr__mushroomSpawnLocationAmountPerArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_mushroomSpawnLocationAmountPerArea");
			SewerMushrooms.NativeFieldInfoPtr__lastMushroomSpanwnLocationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "_lastMushroomSpanwnLocationIndex");
			SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted");
			SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted");
			SewerMushrooms.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670353);
			SewerMushrooms.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670354);
			SewerMushrooms.NativeMethodInfoPtr_SetupEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670355);
			SewerMushrooms.NativeMethodInfoPtr_MushroomIndicesChanged_Private_Void_SyncListOperation_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670356);
			SewerMushrooms.NativeMethodInfoPtr_SpawnMushroom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670357);
			SewerMushrooms.NativeMethodInfoPtr_DespawnMushroom_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670358);
			SewerMushrooms.NativeMethodInfoPtr_SetMushroomSpawnLocationAvailable_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670359);
			SewerMushrooms.NativeMethodInfoPtr_RegenerateMushrooms_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670360);
			SewerMushrooms.NativeMethodInfoPtr_Load_Public_Void_SewerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670361);
			SewerMushrooms.NativeMethodInfoPtr_GetActiveMushroomLocationIndices_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670362);
			SewerMushrooms.NativeMethodInfoPtr_GetNextSpawnLocation_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670363);
			SewerMushrooms.NativeMethodInfoPtr_AreLocationsInSameArea_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670364);
			SewerMushrooms.NativeMethodInfoPtr_CanSpawnMushroom_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670365);
			SewerMushrooms.NativeMethodInfoPtr_GetLocationIndex_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670366);
			SewerMushrooms.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670367);
			SewerMushrooms.NativeMethodInfoPtr__Load_b__19_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670368);
			SewerMushrooms.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670369);
			SewerMushrooms.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670370);
			SewerMushrooms.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670371);
			SewerMushrooms.NativeMethodInfoPtr_RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670372);
			SewerMushrooms.NativeMethodInfoPtr_RpcLogic___SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670373);
			SewerMushrooms.NativeMethodInfoPtr_RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670374);
			SewerMushrooms.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, 100670375);
		}

		// Token: 0x060037D3 RID: 14291 RVA: 0x00135190 File Offset: 0x00133390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143883, XrefRangeEnd = 143903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerMushrooms.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x001351CC File Offset: 0x001333CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143903, XrefRangeEnd = 143922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerMushrooms.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x00135208 File Offset: 0x00133408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143922, XrefRangeEnd = 143940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_SetupEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0013523C File Offset: 0x0013343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143940, XrefRangeEnd = 143952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MushroomIndicesChanged(SyncListOperation op, int index, int oldItem, int newItem, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref op;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldItem;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newItem;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_MushroomIndicesChanged_Private_Void_SyncListOperation_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x001352B4 File Offset: 0x001334B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144005, RefRangeEnd = 144006, XrefRangeStart = 143952, XrefRangeEnd = 144005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnMushroom(int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_SpawnMushroom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x001352F4 File Offset: 0x001334F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144006, XrefRangeEnd = 144019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DespawnMushroom(int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_DespawnMushroom_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037D9 RID: 14297 RVA: 0x00135334 File Offset: 0x00133534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144019, XrefRangeEnd = 144020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMushroomSpawnLocationAvailable(int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_SetMushroomSpawnLocationAvailable_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DA RID: 14298 RVA: 0x00135374 File Offset: 0x00133574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144020, XrefRangeEnd = 144041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateMushrooms()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_RegenerateMushrooms_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DB RID: 14299 RVA: 0x001353A8 File Offset: 0x001335A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144102, RefRangeEnd = 144103, XrefRangeStart = 144041, XrefRangeEnd = 144102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(SewerData sewerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sewerData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_Load_Public_Void_SewerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037DC RID: 14300 RVA: 0x001353EC File Offset: 0x001335EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 144109, RefRangeEnd = 144110, XrefRangeStart = 144103, XrefRangeEnd = 144109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetActiveMushroomLocationIndices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_GetActiveMushroomLocationIndices_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x060037DD RID: 14301 RVA: 0x0013542C File Offset: 0x0013362C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144137, RefRangeEnd = 144139, XrefRangeStart = 144110, XrefRangeEnd = 144137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextSpawnLocation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_GetNextSpawnLocation_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037DE RID: 14302 RVA: 0x00135468 File Offset: 0x00133668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144139, XrefRangeEnd = 144141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreLocationsInSameArea(int locationIndexA, int locationIndexB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndexA;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locationIndexB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_AreLocationsInSameArea_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037DF RID: 14303 RVA: 0x001354C0 File Offset: 0x001336C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144141, XrefRangeEnd = 144145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSpawnMushroom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_CanSpawnMushroom_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x001354FC File Offset: 0x001336FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 144152, RefRangeEnd = 144156, XrefRangeStart = 144145, XrefRangeEnd = 144152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLocationIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_GetLocationIndex_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x00135548 File Offset: 0x00133748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144156, XrefRangeEnd = 144195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SewerMushrooms() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x00135584 File Offset: 0x00133784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144195, XrefRangeEnd = 144199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Load_b__19_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr__Load_b__19_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E3 RID: 14307 RVA: 0x001355C4 File Offset: 0x001337C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144199, XrefRangeEnd = 144207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerMushrooms.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E4 RID: 14308 RVA: 0x00135600 File Offset: 0x00133800
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerMushrooms.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E5 RID: 14309 RVA: 0x0013563C File Offset: 0x0013383C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SewerMushrooms.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00135678 File Offset: 0x00133878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 144220, RefRangeEnd = 144222, XrefRangeStart = 144207, XrefRangeEnd = 144220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x001356B8 File Offset: 0x001338B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144222, XrefRangeEnd = 144236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetMushroomSpawnLocationAvailable_3316948804(int locationIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locationIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_RpcLogic___SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x001356F8 File Offset: 0x001338F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144236, XrefRangeEnd = 144254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x0013575C File Offset: 0x0013395C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 144254, XrefRangeEnd = 144274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x0001C501 File Offset: 0x0001A701
		public SewerMushrooms(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x00135790 File Offset: 0x00133990
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x0001C50A File Offset: 0x0001A70A
		public unsafe ItemPickup MushroomObjectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomObjectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemPickup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomObjectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x001357C0 File Offset: 0x001339C0
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x0001C529 File Offset: 0x0001A729
		public unsafe SewerMushrooms.SewerMushroomSpawnSettings MushroomSpawnSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomSpawnSettings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerMushrooms.SewerMushroomSpawnSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomSpawnSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x001357F0 File Offset: 0x001339F0
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x0001C548 File Offset: 0x0001A748
		public unsafe List<Transform> MushroomAreas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomAreas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomAreas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x00135820 File Offset: 0x00133A20
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x0001C567 File Offset: 0x0001A767
		public unsafe List<Transform> MushroomLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_MushroomLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x00135850 File Offset: 0x00133A50
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x0001C586 File Offset: 0x0001A786
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x00135878 File Offset: 0x00133A78
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x0001C5A1 File Offset: 0x0001A7A1
		public unsafe SyncList<int> _activeMushroomLocationIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__activeMushroomLocationIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__activeMushroomLocationIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x001358A8 File Offset: 0x00133AA8
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		public unsafe Dictionary<int, ItemPickup> _spawnedMushroomItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__spawnedMushroomItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ItemPickup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__spawnedMushroomItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x001358D8 File Offset: 0x00133AD8
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x0001C5DF File Offset: 0x0001A7DF
		public unsafe List<int> _availableMushroomSpawnLocationIndices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__availableMushroomSpawnLocationIndices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__availableMushroomSpawnLocationIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x00135908 File Offset: 0x00133B08
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x0001C5FE File Offset: 0x0001A7FE
		public unsafe List<int> _mushroomSpawnLocationAmountPerArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__mushroomSpawnLocationAmountPerArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__mushroomSpawnLocationAmountPerArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x00135938 File Offset: 0x00133B38
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x0001C61D File Offset: 0x0001A81D
		public unsafe int _lastMushroomSpanwnLocationIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__lastMushroomSpanwnLocationIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr__lastMushroomSpanwnLocationIndex)) = value;
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x00135960 File Offset: 0x00133B60
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x0001C638 File Offset: 0x0001A838
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x00135988 File Offset: 0x00133B88
		// (set) Token: 0x06003802 RID: 14338 RVA: 0x0001C653 File Offset: 0x0001A853
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002565 RID: 9573
		private static readonly IntPtr NativeFieldInfoPtr_MushroomObjectPrefab;

		// Token: 0x04002566 RID: 9574
		private static readonly IntPtr NativeFieldInfoPtr_MushroomSpawnSettings;

		// Token: 0x04002567 RID: 9575
		private static readonly IntPtr NativeFieldInfoPtr_MushroomAreas;

		// Token: 0x04002568 RID: 9576
		private static readonly IntPtr NativeFieldInfoPtr_MushroomLocations;

		// Token: 0x04002569 RID: 9577
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x0400256A RID: 9578
		private static readonly IntPtr NativeFieldInfoPtr__activeMushroomLocationIndices;

		// Token: 0x0400256B RID: 9579
		private static readonly IntPtr NativeFieldInfoPtr__spawnedMushroomItems;

		// Token: 0x0400256C RID: 9580
		private static readonly IntPtr NativeFieldInfoPtr__availableMushroomSpawnLocationIndices;

		// Token: 0x0400256D RID: 9581
		private static readonly IntPtr NativeFieldInfoPtr__mushroomSpawnLocationAmountPerArea;

		// Token: 0x0400256E RID: 9582
		private static readonly IntPtr NativeFieldInfoPtr__lastMushroomSpanwnLocationIndex;

		// Token: 0x0400256F RID: 9583
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002570 RID: 9584
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002571 RID: 9585
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002572 RID: 9586
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04002573 RID: 9587
		private static readonly IntPtr NativeMethodInfoPtr_SetupEvents_Private_Void_0;

		// Token: 0x04002574 RID: 9588
		private static readonly IntPtr NativeMethodInfoPtr_MushroomIndicesChanged_Private_Void_SyncListOperation_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04002575 RID: 9589
		private static readonly IntPtr NativeMethodInfoPtr_SpawnMushroom_Private_Void_Int32_0;

		// Token: 0x04002576 RID: 9590
		private static readonly IntPtr NativeMethodInfoPtr_DespawnMushroom_Private_Void_Int32_0;

		// Token: 0x04002577 RID: 9591
		private static readonly IntPtr NativeMethodInfoPtr_SetMushroomSpawnLocationAvailable_Private_Void_Int32_0;

		// Token: 0x04002578 RID: 9592
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateMushrooms_Private_Void_0;

		// Token: 0x04002579 RID: 9593
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_SewerData_0;

		// Token: 0x0400257A RID: 9594
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveMushroomLocationIndices_Public_List_1_Int32_0;

		// Token: 0x0400257B RID: 9595
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSpawnLocation_Private_Int32_0;

		// Token: 0x0400257C RID: 9596
		private static readonly IntPtr NativeMethodInfoPtr_AreLocationsInSameArea_Private_Boolean_Int32_Int32_0;

		// Token: 0x0400257D RID: 9597
		private static readonly IntPtr NativeMethodInfoPtr_CanSpawnMushroom_Private_Boolean_0;

		// Token: 0x0400257E RID: 9598
		private static readonly IntPtr NativeMethodInfoPtr_GetLocationIndex_Private_Int32_Int32_0;

		// Token: 0x0400257F RID: 9599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002580 RID: 9600
		private static readonly IntPtr NativeMethodInfoPtr__Load_b__19_0_Private_Void_Int32_0;

		// Token: 0x04002581 RID: 9601
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002582 RID: 9602
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002583 RID: 9603
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002584 RID: 9604
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0;

		// Token: 0x04002585 RID: 9605
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetMushroomSpawnLocationAvailable_3316948804_Private_Void_Int32_0;

		// Token: 0x04002586 RID: 9606
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04002587 RID: 9607
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000A1E RID: 2590
		[Serializable]
		public class SewerMushroomSpawnSettings : Il2CppSystem.Object
		{
			// Token: 0x0600DE6F RID: 56943 RVA: 0x0036D870 File Offset: 0x0036BA70
			// Note: this type is marked as 'beforefieldinit'.
			static SewerMushroomSpawnSettings()
			{
				Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "SewerMushroomSpawnSettings");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr);
				SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_MaxSpawnAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr, "MaxSpawnAmount");
				SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_RespawnAmountPerdayAsPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr, "RespawnAmountPerdayAsPercentage");
				SewerMushrooms.SewerMushroomSpawnSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr, 100670376);
			}

			// Token: 0x0600DE70 RID: 56944 RVA: 0x0036D8D8 File Offset: 0x0036BAD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143872, XrefRangeEnd = 143873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SewerMushroomSpawnSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerMushrooms.SewerMushroomSpawnSettings>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.SewerMushroomSpawnSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE71 RID: 56945 RVA: 0x00068B6F File Offset: 0x00066D6F
			public SewerMushroomSpawnSettings(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B8 RID: 17336
			// (get) Token: 0x0600DE72 RID: 56946 RVA: 0x0036D914 File Offset: 0x0036BB14
			// (set) Token: 0x0600DE73 RID: 56947 RVA: 0x00068B78 File Offset: 0x00066D78
			public unsafe int MaxSpawnAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_MaxSpawnAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_MaxSpawnAmount)) = value;
				}
			}

			// Token: 0x170043B9 RID: 17337
			// (get) Token: 0x0600DE74 RID: 56948 RVA: 0x0036D93C File Offset: 0x0036BB3C
			// (set) Token: 0x0600DE75 RID: 56949 RVA: 0x00068B93 File Offset: 0x00066D93
			public unsafe float RespawnAmountPerdayAsPercentage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_RespawnAmountPerdayAsPercentage);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.SewerMushroomSpawnSettings.NativeFieldInfoPtr_RespawnAmountPerdayAsPercentage)) = value;
				}
			}

			// Token: 0x04009790 RID: 38800
			private static readonly IntPtr NativeFieldInfoPtr_MaxSpawnAmount;

			// Token: 0x04009791 RID: 38801
			private static readonly IntPtr NativeFieldInfoPtr_RespawnAmountPerdayAsPercentage;

			// Token: 0x04009792 RID: 38802
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A1F RID: 2591
		[ObfuscatedName("ScheduleOne.Map.SewerMushrooms+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE76 RID: 56950 RVA: 0x0036D964 File Offset: 0x0036BB64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SewerMushrooms>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr);
				SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr_locationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr, "locationIndex");
				SewerMushrooms.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr, 100670377);
				SewerMushrooms.__c__DisplayClass15_0.NativeMethodInfoPtr__SpawnMushroom_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr, 100670378);
			}

			// Token: 0x0600DE77 RID: 56951 RVA: 0x0036D9E0 File Offset: 0x0036BBE0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SewerMushrooms.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE78 RID: 56952 RVA: 0x0036DA1C File Offset: 0x0036BC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143873, XrefRangeEnd = 143883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SpawnMushroom_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SewerMushrooms.__c__DisplayClass15_0.NativeMethodInfoPtr__SpawnMushroom_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE79 RID: 56953 RVA: 0x00068BAE File Offset: 0x00066DAE
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BA RID: 17338
			// (get) Token: 0x0600DE7A RID: 56954 RVA: 0x0036DA50 File Offset: 0x0036BC50
			// (set) Token: 0x0600DE7B RID: 56955 RVA: 0x00068BB7 File Offset: 0x00066DB7
			public unsafe SewerMushrooms __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SewerMushrooms>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043BB RID: 17339
			// (get) Token: 0x0600DE7C RID: 56956 RVA: 0x0036DA80 File Offset: 0x0036BC80
			// (set) Token: 0x0600DE7D RID: 56957 RVA: 0x00068BD6 File Offset: 0x00066DD6
			public unsafe int locationIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr_locationIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SewerMushrooms.__c__DisplayClass15_0.NativeFieldInfoPtr_locationIndex)) = value;
				}
			}

			// Token: 0x04009793 RID: 38803
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009794 RID: 38804
			private static readonly IntPtr NativeFieldInfoPtr_locationIndex;

			// Token: 0x04009795 RID: 38805
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009796 RID: 38806
			private static readonly IntPtr NativeMethodInfoPtr__SpawnMushroom_b__0_Internal_Void_0;
		}
	}
}
