using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000377 RID: 887
	public class ProceduralGridItem : BuildableItem
	{
		// Token: 0x06004C3A RID: 19514 RVA: 0x0017FC9C File Offset: 0x0017DE9C
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItem()
		{
			Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ProceduralGridItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr);
			ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "ProceduralTileType");
			ProceduralGridItem.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___Rotation");
			ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "syncVar___footprintTileMatches");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ProceduralGridItemAssembly-CSharp.dll_Excuted");
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673126);
			ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673127);
			ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673128);
			ProceduralGridItem.NativeMethodInfoPtr_SendInitializationToServer_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673129);
			ProceduralGridItem.NativeMethodInfoPtr_SendInitializationToClient_Protected_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673130);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Server_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673131);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Client_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673132);
			ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673133);
			ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673134);
			ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673135);
			ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673136);
			ProceduralGridItem.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673137);
			ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673138);
			ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673139);
			ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673140);
			ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673141);
			ProceduralGridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673142);
			ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673143);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673144);
			ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673145);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673146);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673147);
			ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673148);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673149);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Server_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673150);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673151);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673152);
			ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Client_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673153);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673154);
			ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673155);
			ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673156);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673157);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673158);
			ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673159);
			ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673160);
			ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673161);
			ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, 100673162);
		}

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x06004C3B RID: 19515 RVA: 0x00180050 File Offset: 0x0017E250
		public unsafe int FootprintXSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173398, XrefRangeEnd = 173419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x06004C3C RID: 19516 RVA: 0x0018008C File Offset: 0x0017E28C
		public unsafe int FootprintYSize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173419, XrefRangeEnd = 173440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x001800C8 File Offset: 0x0017E2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173448, RefRangeEnd = 173449, XrefRangeStart = 173440, XrefRangeEnd = 173448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00180104 File Offset: 0x0017E304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173449, XrefRangeEnd = 173464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitializationToServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SendInitializationToServer_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00180140 File Offset: 0x0017E340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173464, XrefRangeEnd = 173465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SendInitializationToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SendInitializationToClient_Protected_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00180190 File Offset: 0x0017E390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173465, XrefRangeEnd = 173479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeProceduralGridItem_Server(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Server_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00180208 File Offset: 0x0017E408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173479, XrefRangeEnd = 173525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem_Client(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Client_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x0018029C File Offset: 0x0017E49C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173542, RefRangeEnd = 173543, XrefRangeStart = 173525, XrefRangeEnd = 173542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x0018031C File Offset: 0x0017E51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173543, XrefRangeEnd = 173575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetProceduralGridData(int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _rotation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00180378 File Offset: 0x0017E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173575, XrefRangeEnd = 173598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x001803AC File Offset: 0x0017E5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173598, XrefRangeEnd = 173608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPositionData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_ClearPositionData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x001803E0 File Offset: 0x0017E5E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173620, RefRangeEnd = 173621, XrefRangeStart = 173608, XrefRangeEnd = 173620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x0018041C File Offset: 0x0017E61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173621, XrefRangeEnd = 173633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Property GetProperty(Transform searchTransform = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(searchTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00180478 File Offset: 0x0017E678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173633, XrefRangeEnd = 173638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalculateFootprintTileIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x001804B4 File Offset: 0x0017E6B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173644, RefRangeEnd = 173647, XrefRangeStart = 173638, XrefRangeEnd = 173644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFootprintTileVisiblity(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x001804F4 File Offset: 0x0017E6F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 173654, RefRangeEnd = 173658, XrefRangeStart = 173647, XrefRangeEnd = 173654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetFootprintTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00180544 File Offset: 0x0017E744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173658, XrefRangeEnd = 173690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr3) : null;
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00180590 File Offset: 0x0017E790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173705, RefRangeEnd = 173706, XrefRangeStart = 173690, XrefRangeEnd = 173705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x001805CC File Offset: 0x0017E7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173706, XrefRangeEnd = 173711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x0018060C File Offset: 0x0017E80C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _SetProceduralGridData_b__15_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x00180648 File Offset: 0x0017E848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173757, RefRangeEnd = 173758, XrefRangeStart = 173711, XrefRangeEnd = 173757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00180684 File Offset: 0x0017E884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173758, RefRangeEnd = 173759, XrefRangeStart = 173758, XrefRangeEnd = 173758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x001806C0 File Offset: 0x0017E8C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x001806FC File Offset: 0x0017E8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00180774 File Offset: 0x0017E974
		[CallerCount(0)]
		public unsafe void RpcLogic___InitializeProceduralGridItem_Server_638911643(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Server_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C54 RID: 19540 RVA: 0x001807EC File Offset: 0x0017E9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173759, XrefRangeEnd = 173765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_InitializeProceduralGridItem_Server_638911643(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00180850 File Offset: 0x0017EA50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173765, XrefRangeEnd = 173779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x001808D8 File Offset: 0x0017EAD8
		[CallerCount(0)]
		public unsafe virtual void RpcLogic___InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Client_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x0018096C File Offset: 0x0017EB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173779, XrefRangeEnd = 173786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x001809BC File Offset: 0x0017EBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173786, XrefRangeEnd = 173800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044(NetworkConnection conn, ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00180A44 File Offset: 0x0017EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173800, XrefRangeEnd = 173807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06004C5A RID: 19546 RVA: 0x00180A94 File Offset: 0x0017EC94
		// (set) Token: 0x06004C5B RID: 19547 RVA: 0x00180AD0 File Offset: 0x0017ECD0
		public unsafe int SyncAccessor_Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173807, XrefRangeEnd = 173815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00180B1C File Offset: 0x0017ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173815, XrefRangeEnd = 173817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x06004C5D RID: 19549 RVA: 0x00180B90 File Offset: 0x0017ED90
		// (set) Token: 0x06004C5E RID: 19550 RVA: 0x00180BD0 File Offset: 0x0017EDD0
		public unsafe List<CoordinateProceduralTilePair> SyncAccessor_footprintTileMatches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173817, XrefRangeEnd = 173826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00180C20 File Offset: 0x0017EE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173826, XrefRangeEnd = 173833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004C60 RID: 19552 RVA: 0x00024A84 File Offset: 0x00022C84
		public ProceduralGridItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x00180C5C File Offset: 0x0017EE5C
		// (set) Token: 0x06004C62 RID: 19554 RVA: 0x00024A8D File Offset: 0x00022C8D
		public unsafe List<CoordinateFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x00180C8C File Offset: 0x0017EE8C
		// (set) Token: 0x06004C64 RID: 19556 RVA: 0x00024AAC File Offset: 0x00022CAC
		public unsafe ProceduralTile.EProceduralTileType ProceduralTileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_ProceduralTileType)) = value;
			}
		}

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x00180CB4 File Offset: 0x0017EEB4
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x00024AC7 File Offset: 0x00022CC7
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x06004C67 RID: 19559 RVA: 0x00180CDC File Offset: 0x0017EEDC
		// (set) Token: 0x06004C68 RID: 19560 RVA: 0x00024AE2 File Offset: 0x00022CE2
		public unsafe List<CoordinateProceduralTilePair> footprintTileMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateProceduralTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x06004C69 RID: 19561 RVA: 0x00180D0C File Offset: 0x0017EF0C
		// (set) Token: 0x06004C6A RID: 19562 RVA: 0x00024B01 File Offset: 0x00022D01
		public unsafe SyncVar<int> syncVar___Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___Rotation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x06004C6B RID: 19563 RVA: 0x00180D3C File Offset: 0x0017EF3C
		// (set) Token: 0x06004C6C RID: 19564 RVA: 0x00024B20 File Offset: 0x00022D20
		public unsafe SyncVar<List<CoordinateProceduralTilePair>> syncVar___footprintTileMatches
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<List<CoordinateProceduralTilePair>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_syncVar___footprintTileMatches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017D2 RID: 6098
		// (get) Token: 0x06004C6D RID: 19565 RVA: 0x00180D6C File Offset: 0x0017EF6C
		// (set) Token: 0x06004C6E RID: 19566 RVA: 0x00024B3F File Offset: 0x00022D3F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x06004C6F RID: 19567 RVA: 0x00180D94 File Offset: 0x0017EF94
		// (set) Token: 0x06004C70 RID: 19568 RVA: 0x00024B5A File Offset: 0x00022D5A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400340D RID: 13325
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x0400340E RID: 13326
		private static readonly IntPtr NativeFieldInfoPtr_ProceduralTileType;

		// Token: 0x0400340F RID: 13327
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04003410 RID: 13328
		private static readonly IntPtr NativeFieldInfoPtr_footprintTileMatches;

		// Token: 0x04003411 RID: 13329
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___Rotation;

		// Token: 0x04003412 RID: 13330
		private static readonly IntPtr NativeFieldInfoPtr_syncVar___footprintTileMatches;

		// Token: 0x04003413 RID: 13331
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003414 RID: 13332
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003415 RID: 13333
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintXSize_Public_get_Int32_0;

		// Token: 0x04003416 RID: 13334
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintYSize_Public_get_Int32_0;

		// Token: 0x04003417 RID: 13335
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeMethodInfoPtr_SendInitializationToServer_Protected_Virtual_Void_1;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeMethodInfoPtr_SendInitializationToClient_Protected_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Server_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Client_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_New_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeMethodInfoPtr_SetProceduralGridData_Protected_Virtual_New_Void_Int32_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_ClearPositionData_Private_Void_0;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_1;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Protected_Virtual_Property_Transform_0;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFootprintTileIntersections_Public_Virtual_New_Void_0;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeMethodInfoPtr_SetFootprintTileVisiblity_Public_Void_Boolean_0;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeMethodInfoPtr_GetFootprintTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr__SetProceduralGridData_b__15_1_Private_Boolean_0;

		// Token: 0x04003429 RID: 13353
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400342A RID: 13354
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400342B RID: 13355
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400342C RID: 13356
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x0400342D RID: 13357
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Server_638911643_Public_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x0400342E RID: 13358
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_InitializeProceduralGridItem_Server_638911643_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400342F RID: 13359
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003430 RID: 13360
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InitializeProceduralGridItem_Client_3164718044_Public_Virtual_New_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003431 RID: 13361
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003432 RID: 13362
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_NetworkConnection_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04003433 RID: 13363
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InitializeProceduralGridItem_Client_3164718044_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003434 RID: 13364
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_Rotation_Public_get_Int32_0;

		// Token: 0x04003435 RID: 13365
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_Rotation_Public_set_Void_Int32_Boolean_0;

		// Token: 0x04003436 RID: 13366
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_EntityFramework_ProceduralGridItem_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04003437 RID: 13367
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value_footprintTileMatches_Public_get_List_1_CoordinateProceduralTilePair_0;

		// Token: 0x04003438 RID: 13368
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value_footprintTileMatches_Public_set_Void_List_1_CoordinateProceduralTilePair_Boolean_0;

		// Token: 0x04003439 RID: 13369
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000A7D RID: 2685
		public class FootprintTileMatch : Il2CppSystem.Object
		{
			// Token: 0x0600E172 RID: 57714 RVA: 0x00375C80 File Offset: 0x00373E80
			// Note: this type is marked as 'beforefieldinit'.
			static FootprintTileMatch()
			{
				Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "FootprintTileMatch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr);
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "footprint");
				ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, "matchedTile");
				ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr, 100673163);
			}

			// Token: 0x0600E173 RID: 57715 RVA: 0x00375CE8 File Offset: 0x00373EE8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FootprintTileMatch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.FootprintTileMatch>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.FootprintTileMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E174 RID: 57716 RVA: 0x0006A3F7 File Offset: 0x000685F7
			public FootprintTileMatch(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700449E RID: 17566
			// (get) Token: 0x0600E175 RID: 57717 RVA: 0x00375D24 File Offset: 0x00373F24
			// (set) Token: 0x0600E176 RID: 57718 RVA: 0x0006A400 File Offset: 0x00068600
			public unsafe FootprintTile footprint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_footprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700449F RID: 17567
			// (get) Token: 0x0600E177 RID: 57719 RVA: 0x00375D54 File Offset: 0x00373F54
			// (set) Token: 0x0600E178 RID: 57720 RVA: 0x0006A41F File Offset: 0x0006861F
			public unsafe ProceduralTile matchedTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.FootprintTileMatch.NativeFieldInfoPtr_matchedTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009975 RID: 39285
			private static readonly IntPtr NativeFieldInfoPtr_footprint;

			// Token: 0x04009976 RID: 39286
			private static readonly IntPtr NativeFieldInfoPtr_matchedTile;

			// Token: 0x04009977 RID: 39287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A7E RID: 2686
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<<SetProceduralGridData>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E179 RID: 57721 RVA: 0x00375D84 File Offset: 0x00373F84
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<<SetProceduralGridData>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673164);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673165);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673166);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673167);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673168);
				ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100673169);
			}

			// Token: 0x0600E17A RID: 57722 RVA: 0x00375E64 File Offset: 0x00374064
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E17B RID: 57723 RVA: 0x00375EAC File Offset: 0x003740AC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E17C RID: 57724 RVA: 0x00375EE0 File Offset: 0x003740E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173381, XrefRangeEnd = 173393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044A3 RID: 17571
			// (get) Token: 0x0600E17D RID: 57725 RVA: 0x00375F1C File Offset: 0x0037411C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E17E RID: 57726 RVA: 0x00375F5C File Offset: 0x0037415C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173393, XrefRangeEnd = 173398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044A4 RID: 17572
			// (get) Token: 0x0600E17F RID: 57727 RVA: 0x00375F90 File Offset: 0x00374190
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E180 RID: 57728 RVA: 0x0006A43E File Offset: 0x0006863E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A0 RID: 17568
			// (get) Token: 0x0600E181 RID: 57729 RVA: 0x00375FD0 File Offset: 0x003741D0
			// (set) Token: 0x0600E182 RID: 57730 RVA: 0x0006A447 File Offset: 0x00068647
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044A1 RID: 17569
			// (get) Token: 0x0600E183 RID: 57731 RVA: 0x00375FF8 File Offset: 0x003741F8
			// (set) Token: 0x0600E184 RID: 57732 RVA: 0x0006A462 File Offset: 0x00068662
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A2 RID: 17570
			// (get) Token: 0x0600E185 RID: 57733 RVA: 0x00376028 File Offset: 0x00374228
			// (set) Token: 0x0600E186 RID: 57734 RVA: 0x0006A481 File Offset: 0x00068681
			public unsafe ProceduralGridItem __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralGridItem.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009978 RID: 39288
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009979 RID: 39289
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400997A RID: 39290
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400997B RID: 39291
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400997C RID: 39292
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400997D RID: 39293
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400997E RID: 39294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400997F RID: 39295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009980 RID: 39296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A7F RID: 2687
		[ObfuscatedName("ScheduleOne.EntityFramework.ProceduralGridItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E187 RID: 57735 RVA: 0x00376058 File Offset: 0x00374258
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProceduralGridItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr);
				ProceduralGridItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__4_0");
				ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, "<>9__6_0");
				ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100673171);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100673172);
				ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr, 100673173);
			}

			// Token: 0x0600E188 RID: 57736 RVA: 0x003760FC File Offset: 0x003742FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E189 RID: 57737 RVA: 0x00376138 File Offset: 0x00374338
			[CallerCount(0)]
			public unsafe int _get_FootprintXSize_b__4_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E18A RID: 57738 RVA: 0x0037618C File Offset: 0x0037438C
			[CallerCount(0)]
			public unsafe int _get_FootprintYSize_b__6_0(CoordinateFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItem.__c.NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E18B RID: 57739 RVA: 0x0006A4A0 File Offset: 0x000686A0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A5 RID: 17573
			// (get) Token: 0x0600E18C RID: 57740 RVA: 0x003761E0 File Offset: 0x003743E0
			// (set) Token: 0x0600E18D RID: 57741 RVA: 0x0006A4A9 File Offset: 0x000686A9
			public unsafe static ProceduralGridItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0600E18E RID: 57742 RVA: 0x00376208 File Offset: 0x00374408
			// (set) Token: 0x0600E18F RID: 57743 RVA: 0x0006A4BB File Offset: 0x000686BB
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0600E190 RID: 57744 RVA: 0x00376230 File Offset: 0x00374430
			// (set) Token: 0x0600E191 RID: 57745 RVA: 0x0006A4CD File Offset: 0x000686CD
			public unsafe static Func<CoordinateFootprintTilePair, int> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ProceduralGridItem.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009981 RID: 39297
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009982 RID: 39298
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04009983 RID: 39299
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04009984 RID: 39300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009985 RID: 39301
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintXSize_b__4_0_Internal_Int32_CoordinateFootprintTilePair_0;

			// Token: 0x04009986 RID: 39302
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintYSize_b__6_0_Internal_Int32_CoordinateFootprintTilePair_0;
		}
	}
}
