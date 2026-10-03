using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DB RID: 219
	public class VehicleManager : NetworkSingleton<VehicleManager>
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x000C199C File Offset: 0x000BFB9C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleManager()
		{
			Il2CppClassPointerStore<VehicleManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr);
			VehicleManager.NativeFieldInfoPtr_AllVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "AllVehicles");
			VehicleManager.NativeFieldInfoPtr_VehiclePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "VehiclePrefabs");
			VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "PlayerOwnedVehicles");
			VehicleManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "loader");
			VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			VehicleManager.NativeFieldInfoPtr__LoadOrder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<LoadOrder>k__BackingField");
			VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted");
			VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleManagerAssembly-CSharp.dll_Excuted");
			VehicleManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666278);
			VehicleManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666279);
			VehicleManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666280);
			VehicleManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666281);
			VehicleManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666282);
			VehicleManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666283);
			VehicleManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666284);
			VehicleManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666285);
			VehicleManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666286);
			VehicleManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666287);
			VehicleManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666288);
			VehicleManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666289);
			VehicleManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666290);
			VehicleManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666291);
			VehicleManager.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666292);
			VehicleManager.NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666293);
			VehicleManager.NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666294);
			VehicleManager.NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666295);
			VehicleManager.NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666296);
			VehicleManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666297);
			VehicleManager.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666298);
			VehicleManager.NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666299);
			VehicleManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666300);
			VehicleManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666301);
			VehicleManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666302);
			VehicleManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666303);
			VehicleManager.NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666304);
			VehicleManager.NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666305);
			VehicleManager.NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666306);
			VehicleManager.NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666307);
			VehicleManager.NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666308);
			VehicleManager.NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666309);
			VehicleManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, 100666310);
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000C1D28 File Offset: 0x000BFF28
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94579, XrefRangeEnd = 94581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000C1D60 File Offset: 0x000BFF60
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94581, XrefRangeEnd = 94583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000C1D98 File Offset: 0x000BFF98
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000C1DD8 File Offset: 0x000BFFD8
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000C1E14 File Offset: 0x000C0014
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x000C1E54 File Offset: 0x000C0054
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94583, XrefRangeEnd = 94584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000C1E98 File Offset: 0x000C0098
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x000C1ED8 File Offset: 0x000C00D8
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94584, XrefRangeEnd = 94584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94585, XrefRangeEnd = 94586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x000C1F1C File Offset: 0x000C011C
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x000C1F58 File Offset: 0x000C0158
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x000C1F98 File Offset: 0x000C0198
		public unsafe virtual int LoadOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000C1FD4 File Offset: 0x000C01D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94586, XrefRangeEnd = 94589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000C2010 File Offset: 0x000C0210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94589, XrefRangeEnd = 94593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000C204C File Offset: 0x000C024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94593, XrefRangeEnd = 94599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000C2088 File Offset: 0x000C0288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94600, RefRangeEnd = 94601, XrefRangeStart = 94599, XrefRangeEnd = 94600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000C20F4 File Offset: 0x000C02F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 94645, RefRangeEnd = 94650, XrefRangeStart = 94601, XrefRangeEnd = 94645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle SpawnAndReturnVehicle(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000C2170 File Offset: 0x000C0370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 94665, RefRangeEnd = 94668, XrefRangeStart = 94650, XrefRangeEnd = 94665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetVehiclePrefab(string vehicleCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000C21C0 File Offset: 0x000C03C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94669, RefRangeEnd = 94671, XrefRangeStart = 94668, XrefRangeEnd = 94669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle SpawnAndLoadVehicle(VehicleData data, string path, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000C2230 File Offset: 0x000C0430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94684, RefRangeEnd = 94686, XrefRangeStart = 94671, XrefRangeEnd = 94684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadVehicle(VehicleData data, string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000C2284 File Offset: 0x000C0484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94686, XrefRangeEnd = 94711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000C22C8 File Offset: 0x000C04C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 94740, RefRangeEnd = 94742, XrefRangeStart = 94711, XrefRangeEnd = 94740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpawnLoanSharkVehicle(Vector3 position, Quaternion rot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000C2314 File Offset: 0x000C0514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94742, XrefRangeEnd = 94764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableLoanSharkVisuals(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000C2358 File Offset: 0x000C0558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94764, XrefRangeEnd = 94801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000C2394 File Offset: 0x000C0594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94801, XrefRangeEnd = 94818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000C23D0 File Offset: 0x000C05D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94818, XrefRangeEnd = 94821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000C240C File Offset: 0x000C060C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000C2448 File Offset: 0x000C0648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94857, RefRangeEnd = 94858, XrefRangeStart = 94821, XrefRangeEnd = 94857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000C24B4 File Offset: 0x000C06B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94858, XrefRangeEnd = 94859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SpawnVehicle_3323115898(string vehicleCode, Vector3 position, Quaternion rotation, bool playerOwned)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(vehicleCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOwned;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000C2520 File Offset: 0x000C0720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94859, XrefRangeEnd = 94867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SpawnVehicle_3323115898(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000C2584 File Offset: 0x000C0784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94867, XrefRangeEnd = 94877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x000C25C8 File Offset: 0x000C07C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 94893, RefRangeEnd = 94896, XrefRangeStart = 94877, XrefRangeEnd = 94893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EnableLoanSharkVisuals_3323014238(NetworkObject veh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(veh);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x000C260C File Offset: 0x000C080C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94896, XrefRangeEnd = 94900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableLoanSharkVisuals_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x000C265C File Offset: 0x000C085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94900, XrefRangeEnd = 94903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0000B8B1 File Offset: 0x00009AB1
		public VehicleManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x000C2698 File Offset: 0x000C0898
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000B8BA File Offset: 0x00009ABA
		public unsafe List<LandVehicle> AllVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_AllVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_AllVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000C26C8 File Offset: 0x000C08C8
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000B8D9 File Offset: 0x00009AD9
		public unsafe List<LandVehicle> VehiclePrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_VehiclePrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_VehiclePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000C26F8 File Offset: 0x000C08F8
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		public unsafe List<LandVehicle> PlayerOwnedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_PlayerOwnedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x000C2728 File Offset: 0x000C0928
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x0000B917 File Offset: 0x00009B17
		public unsafe VehiclesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000C2758 File Offset: 0x000C0958
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000B936 File Offset: 0x00009B36
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x000C2788 File Offset: 0x000C0988
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000B955 File Offset: 0x00009B55
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x000C27B8 File Offset: 0x000C09B8
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000B974 File Offset: 0x00009B74
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x000C27E0 File Offset: 0x000C09E0
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x0000B98F File Offset: 0x00009B8F
		public unsafe int _LoadOrder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LoadOrder_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr__LoadOrder_k__BackingField)) = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x000C2808 File Offset: 0x000C0A08
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x0000B9AA File Offset: 0x00009BAA
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000C2830 File Offset: 0x000C0A30
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x0000B9C5 File Offset: 0x00009BC5
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeFieldInfoPtr_AllVehicles;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeFieldInfoPtr_VehiclePrefabs;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeFieldInfoPtr_PlayerOwnedVehicles;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04000ECA RID: 3786
		private static readonly IntPtr NativeFieldInfoPtr__LoadOrder_k__BackingField;

		// Token: 0x04000ECB RID: 3787
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04000ECC RID: 3788
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04000ECD RID: 3789
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000ECE RID: 3790
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000ECF RID: 3791
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04000ED0 RID: 3792
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000ED1 RID: 3793
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04000ED2 RID: 3794
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04000ED3 RID: 3795
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04000ED4 RID: 3796
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04000ED5 RID: 3797
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000ED6 RID: 3798
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04000ED7 RID: 3799
		private static readonly IntPtr NativeMethodInfoPtr_get_LoadOrder_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000ED8 RID: 3800
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04000ED9 RID: 3801
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04000EDA RID: 3802
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04000EDB RID: 3803
		private static readonly IntPtr NativeMethodInfoPtr_SpawnVehicle_Public_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04000EDC RID: 3804
		private static readonly IntPtr NativeMethodInfoPtr_SpawnAndReturnVehicle_Public_LandVehicle_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04000EDD RID: 3805
		private static readonly IntPtr NativeMethodInfoPtr_GetVehiclePrefab_Public_LandVehicle_String_0;

		// Token: 0x04000EDE RID: 3806
		private static readonly IntPtr NativeMethodInfoPtr_SpawnAndLoadVehicle_Public_LandVehicle_VehicleData_String_Boolean_0;

		// Token: 0x04000EDF RID: 3807
		private static readonly IntPtr NativeMethodInfoPtr_LoadVehicle_Public_Void_VehicleData_String_0;

		// Token: 0x04000EE0 RID: 3808
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04000EE1 RID: 3809
		private static readonly IntPtr NativeMethodInfoPtr_SpawnLoanSharkVehicle_Public_Void_Vector3_Quaternion_0;

		// Token: 0x04000EE2 RID: 3810
		private static readonly IntPtr NativeMethodInfoPtr_EnableLoanSharkVisuals_Private_Void_NetworkObject_0;

		// Token: 0x04000EE3 RID: 3811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EE4 RID: 3812
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04000EE5 RID: 3813
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04000EE6 RID: 3814
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04000EE7 RID: 3815
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SpawnVehicle_3323115898_Private_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04000EE8 RID: 3816
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SpawnVehicle_3323115898_Public_Void_String_Vector3_Quaternion_Boolean_0;

		// Token: 0x04000EE9 RID: 3817
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SpawnVehicle_3323115898_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableLoanSharkVisuals_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableLoanSharkVisuals_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200091F RID: 2335
		[ObfuscatedName("ScheduleOne.Vehicles.VehicleManager+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D744 RID: 55108 RVA: 0x0035942C File Offset: 0x0035762C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleManager>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr);
				VehicleManager.__c__DisplayClass32_0.NativeFieldInfoPtr_vehicleCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr, "vehicleCode");
				VehicleManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr, 100666311);
				VehicleManager.__c__DisplayClass32_0.NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr, 100666312);
			}

			// Token: 0x0600D745 RID: 55109 RVA: 0x00359494 File Offset: 0x00357694
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleManager.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D746 RID: 55110 RVA: 0x003594D0 File Offset: 0x003576D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94554, XrefRangeEnd = 94579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetVehiclePrefab_b__0(LandVehicle x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleManager.__c__DisplayClass32_0.NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D747 RID: 55111 RVA: 0x00065243 File Offset: 0x00063443
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041BE RID: 16830
			// (get) Token: 0x0600D748 RID: 55112 RVA: 0x00359520 File Offset: 0x00357720
			// (set) Token: 0x0600D749 RID: 55113 RVA: 0x0006524C File Offset: 0x0006344C
			public unsafe string vehicleCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.__c__DisplayClass32_0.NativeFieldInfoPtr_vehicleCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleManager.__c__DisplayClass32_0.NativeFieldInfoPtr_vehicleCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040092BE RID: 37566
			private static readonly IntPtr NativeFieldInfoPtr_vehicleCode;

			// Token: 0x040092BF RID: 37567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092C0 RID: 37568
			private static readonly IntPtr NativeMethodInfoPtr__GetVehiclePrefab_b__0_Internal_Boolean_LandVehicle_0;
		}
	}
}
