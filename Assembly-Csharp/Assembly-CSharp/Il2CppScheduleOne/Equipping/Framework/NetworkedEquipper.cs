using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Equipping.Framework;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Equipping.Framework
{
	// Token: 0x02000594 RID: 1428
	public class NetworkedEquipper : NetworkBehaviour
	{
		// Token: 0x060081A1 RID: 33185 RVA: 0x0023802C File Offset: 0x0023622C
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkedEquipper()
		{
			Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping.Framework", "NetworkedEquipper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr);
			NetworkedEquipper.NativeFieldInfoPtr__networkEquippedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, "_networkEquippedItems");
			NetworkedEquipper.NativeFieldInfoPtr__allEquippedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, "_allEquippedItems");
			NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Equipping.Framework.NetworkedEquipperAssembly-CSharp.dll_Excuted");
			NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Equipping.Framework.NetworkedEquipperAssembly-CSharp.dll_Excuted");
			NetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Abstract_Virtual_New_IEquippableUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679946);
			NetworkedEquipper.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679947);
			NetworkedEquipper.NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_EquippableData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679948);
			NetworkedEquipper.NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_BaseItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679949);
			NetworkedEquipper.NativeMethodInfoPtr_Unequip_Public_Void_IEquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679950);
			NetworkedEquipper.NativeMethodInfoPtr_AddEquippedItem_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679951);
			NetworkedEquipper.NativeMethodInfoPtr_RemoveEquippedItem_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679952);
			NetworkedEquipper.NativeMethodInfoPtr_Unequip_Server_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679953);
			NetworkedEquipper.NativeMethodInfoPtr_Unequip_Client_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679954);
			NetworkedEquipper.NativeMethodInfoPtr_AddNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679955);
			NetworkedEquipper.NativeMethodInfoPtr_RemoveNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679956);
			NetworkedEquipper.NativeMethodInfoPtr_CreateHandlerForEquippable_Private_IEquippedItemHandler_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679957);
			NetworkedEquipper.NativeMethodInfoPtr_NetworkEquippedItems_OnChange_Private_Void_SyncListOperation_Int32_EquippedItemHandler_EquippedItemHandler_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679958);
			NetworkedEquipper.NativeMethodInfoPtr_UnequipAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679959);
			NetworkedEquipper.NativeMethodInfoPtr_CanEquip_Private_Boolean_EquippableData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679960);
			NetworkedEquipper.NativeMethodInfoPtr_IsRightHandOccupied_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679961);
			NetworkedEquipper.NativeMethodInfoPtr_IsLeftHandOccupied_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679962);
			NetworkedEquipper.NativeMethodInfoPtr_IsItemEquipped_Private_Boolean_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679963);
			NetworkedEquipper.NativeMethodInfoPtr_PrintLists_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679964);
			NetworkedEquipper.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679965);
			NetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679966);
			NetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679967);
			NetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679968);
			NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_Unequip_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679969);
			NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___Unequip_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679970);
			NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_Unequip_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679971);
			NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Observers_Unequip_Client_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679972);
			NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___Unequip_Client_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679973);
			NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Observers_Unequip_Client_897730888_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679974);
			NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679975);
			NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679976);
			NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679977);
			NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679978);
			NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679979);
			NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679980);
			NetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, 100679981);
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x0023837C File Offset: 0x0023657C
		[CallerCount(0)]
		public unsafe virtual IEquippableUser GetUser()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_GetUser_Protected_Abstract_Virtual_New_IEquippableUser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippableUser>(intPtr3) : null;
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x002383C8 File Offset: 0x002365C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245355, XrefRangeEnd = 245366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00238404 File Offset: 0x00236604
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 245381, RefRangeEnd = 245385, XrefRangeStart = 245366, XrefRangeEnd = 245381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEquippedItemHandler Equip(EquippableData equippable, bool networked = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref networked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_EquippableData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x00238464 File Offset: 0x00236664
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 245410, RefRangeEnd = 245414, XrefRangeStart = 245385, XrefRangeEnd = 245410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEquippedItemHandler Equip(BaseItemInstance item, bool networked = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref networked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_BaseItemInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x002384C4 File Offset: 0x002366C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245493, RefRangeEnd = 245496, XrefRangeStart = 245414, XrefRangeEnd = 245493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip(IEquippedItemHandler equippedItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippedItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_Unequip_Public_Void_IEquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x00238508 File Offset: 0x00236708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245501, RefRangeEnd = 245503, XrefRangeStart = 245496, XrefRangeEnd = 245501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEquippedItem(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_AddEquippedItem_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x0023854C File Offset: 0x0023674C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245503, XrefRangeEnd = 245508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveEquippedItem(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RemoveEquippedItem_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x00238590 File Offset: 0x00236790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245508, XrefRangeEnd = 245530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip_Server(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_Unequip_Server_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x002385D4 File Offset: 0x002367D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245550, RefRangeEnd = 245555, XrefRangeStart = 245530, XrefRangeEnd = 245550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unequip_Client(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_Unequip_Client_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x00238618 File Offset: 0x00236818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245555, XrefRangeEnd = 245577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNetworkedEquippedItem_Server(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_AddNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x0023865C File Offset: 0x0023685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245577, XrefRangeEnd = 245599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNetworkedEquippedItem_Server(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RemoveNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x002386A0 File Offset: 0x002368A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245623, RefRangeEnd = 245625, XrefRangeStart = 245599, XrefRangeEnd = 245623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEquippedItemHandler CreateHandlerForEquippable(EquippableData equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_CreateHandlerForEquippable_Private_IEquippedItemHandler_EquippableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEquippedItemHandler>(intPtr3) : null;
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x002386F0 File Offset: 0x002368F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245625, XrefRangeEnd = 245630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NetworkEquippedItems_OnChange(SyncListOperation op, int index, EquippedItemHandler oldItem, EquippedItemHandler newItem, bool asServer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref op;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldItem);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_NetworkEquippedItems_OnChange_Private_Void_SyncListOperation_Int32_EquippedItemHandler_EquippedItemHandler_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x00238770 File Offset: 0x00236970
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245643, RefRangeEnd = 245646, XrefRangeStart = 245630, XrefRangeEnd = 245643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnequipAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_UnequipAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x002387A4 File Offset: 0x002369A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245652, RefRangeEnd = 245654, XrefRangeStart = 245646, XrefRangeEnd = 245652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanEquip(EquippableData equippable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(equippable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_CanEquip_Private_Boolean_EquippableData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x002387F4 File Offset: 0x002369F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245664, RefRangeEnd = 245665, XrefRangeStart = 245654, XrefRangeEnd = 245664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsRightHandOccupied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_IsRightHandOccupied_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x00238830 File Offset: 0x00236A30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245675, RefRangeEnd = 245676, XrefRangeStart = 245665, XrefRangeEnd = 245675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLeftHandOccupied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_IsLeftHandOccupied_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x0023886C File Offset: 0x00236A6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245686, RefRangeEnd = 245691, XrefRangeStart = 245676, XrefRangeEnd = 245686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsItemEquipped(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_IsItemEquipped_Private_Boolean_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x002388BC File Offset: 0x00236ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245691, XrefRangeEnd = 245722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrintLists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_PrintLists_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x002388F0 File Offset: 0x00236AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245737, RefRangeEnd = 245739, XrefRangeStart = 245722, XrefRangeEnd = 245737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkedEquipper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x0023892C File Offset: 0x00236B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245766, RefRangeEnd = 245768, XrefRangeStart = 245739, XrefRangeEnd = 245766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x00238968 File Offset: 0x00236B68
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x002389A4 File Offset: 0x00236BA4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x002389E0 File Offset: 0x00236BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245768, XrefRangeEnd = 245778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Unequip_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_Unequip_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00238A24 File Offset: 0x00236C24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 245550, RefRangeEnd = 245555, XrefRangeStart = 245550, XrefRangeEnd = 245555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Unequip_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___Unequip_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x00238A68 File Offset: 0x00236C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245778, XrefRangeEnd = 245782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Unequip_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_Unequip_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00238ACC File Offset: 0x00236CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245782, XrefRangeEnd = 245792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Unequip_Client_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Observers_Unequip_Client_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x00238B10 File Offset: 0x00236D10
		[CallerCount(0)]
		public unsafe void RpcLogic___Unequip_Client_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___Unequip_Client_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x00238B54 File Offset: 0x00236D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245792, XrefRangeEnd = 245795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Unequip_Client_897730888(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Observers_Unequip_Client_897730888_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x00238BA4 File Offset: 0x00236DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245795, XrefRangeEnd = 245805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00238BE8 File Offset: 0x00236DE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245811, RefRangeEnd = 245813, XrefRangeStart = 245805, XrefRangeEnd = 245811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00238C2C File Offset: 0x00236E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245813, XrefRangeEnd = 245817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_AddNetworkedEquippedItem_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00238C90 File Offset: 0x00236E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245817, XrefRangeEnd = 245827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x00238CD4 File Offset: 0x00236ED4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245833, RefRangeEnd = 245836, XrefRangeStart = 245827, XrefRangeEnd = 245833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___RemoveNetworkedEquippedItem_Server_897730888(EquippedItemHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcLogic___RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x00238D18 File Offset: 0x00236F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245836, XrefRangeEnd = 245840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.NativeMethodInfoPtr_RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x00238D7C File Offset: 0x00236F7C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkedEquipper.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x0003DA6E File Offset: 0x0003BC6E
		public NetworkedEquipper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x060081C7 RID: 33223 RVA: 0x00238DB8 File Offset: 0x00236FB8
		// (set) Token: 0x060081C8 RID: 33224 RVA: 0x0003DA77 File Offset: 0x0003BC77
		public unsafe SyncList<EquippedItemHandler> _networkEquippedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr__networkEquippedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncList<EquippedItemHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr__networkEquippedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x060081C9 RID: 33225 RVA: 0x00238DE8 File Offset: 0x00236FE8
		// (set) Token: 0x060081CA RID: 33226 RVA: 0x0003DA96 File Offset: 0x0003BC96
		public unsafe List<EquippedItemHandler> _allEquippedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr__allEquippedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EquippedItemHandler>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr__allEquippedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x060081CB RID: 33227 RVA: 0x00238E18 File Offset: 0x00237018
		// (set) Token: 0x060081CC RID: 33228 RVA: 0x0003DAB5 File Offset: 0x0003BCB5
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x060081CD RID: 33229 RVA: 0x00238E40 File Offset: 0x00237040
		// (set) Token: 0x060081CE RID: 33230 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NetworkedEquipper.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005855 RID: 22613
		private static readonly IntPtr NativeFieldInfoPtr__networkEquippedItems;

		// Token: 0x04005856 RID: 22614
		private static readonly IntPtr NativeFieldInfoPtr__allEquippedItems;

		// Token: 0x04005857 RID: 22615
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005858 RID: 22616
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005859 RID: 22617
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Protected_Abstract_Virtual_New_IEquippableUser_0;

		// Token: 0x0400585A RID: 22618
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400585B RID: 22619
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_EquippableData_Boolean_0;

		// Token: 0x0400585C RID: 22620
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_IEquippedItemHandler_BaseItemInstance_Boolean_0;

		// Token: 0x0400585D RID: 22621
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Void_IEquippedItemHandler_0;

		// Token: 0x0400585E RID: 22622
		private static readonly IntPtr NativeMethodInfoPtr_AddEquippedItem_Private_Void_EquippedItemHandler_0;

		// Token: 0x0400585F RID: 22623
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEquippedItem_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005860 RID: 22624
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Server_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005861 RID: 22625
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Client_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005862 RID: 22626
		private static readonly IntPtr NativeMethodInfoPtr_AddNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005863 RID: 22627
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNetworkedEquippedItem_Server_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005864 RID: 22628
		private static readonly IntPtr NativeMethodInfoPtr_CreateHandlerForEquippable_Private_IEquippedItemHandler_EquippableData_0;

		// Token: 0x04005865 RID: 22629
		private static readonly IntPtr NativeMethodInfoPtr_NetworkEquippedItems_OnChange_Private_Void_SyncListOperation_Int32_EquippedItemHandler_EquippedItemHandler_Boolean_0;

		// Token: 0x04005866 RID: 22630
		private static readonly IntPtr NativeMethodInfoPtr_UnequipAll_Public_Void_0;

		// Token: 0x04005867 RID: 22631
		private static readonly IntPtr NativeMethodInfoPtr_CanEquip_Private_Boolean_EquippableData_0;

		// Token: 0x04005868 RID: 22632
		private static readonly IntPtr NativeMethodInfoPtr_IsRightHandOccupied_Private_Boolean_0;

		// Token: 0x04005869 RID: 22633
		private static readonly IntPtr NativeMethodInfoPtr_IsLeftHandOccupied_Private_Boolean_0;

		// Token: 0x0400586A RID: 22634
		private static readonly IntPtr NativeMethodInfoPtr_IsItemEquipped_Private_Boolean_EquippedItemHandler_0;

		// Token: 0x0400586B RID: 22635
		private static readonly IntPtr NativeMethodInfoPtr_PrintLists_Public_Void_0;

		// Token: 0x0400586C RID: 22636
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400586D RID: 22637
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400586E RID: 22638
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400586F RID: 22639
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005870 RID: 22640
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Unequip_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005871 RID: 22641
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Unequip_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005872 RID: 22642
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Unequip_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005873 RID: 22643
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Unequip_Client_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005874 RID: 22644
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Unequip_Client_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005875 RID: 22645
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Unequip_Client_897730888_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005876 RID: 22646
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005877 RID: 22647
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x04005878 RID: 22648
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_AddNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04005879 RID: 22649
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x0400587A RID: 22650
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___RemoveNetworkedEquippedItem_Server_897730888_Private_Void_EquippedItemHandler_0;

		// Token: 0x0400587B RID: 22651
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_RemoveNetworkedEquippedItem_Server_897730888_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400587C RID: 22652
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BEF RID: 3055
		[ObfuscatedName("ScheduleOne.Equipping.Framework.NetworkedEquipper+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600ECE1 RID: 60641 RVA: 0x003964D4 File Offset: 0x003946D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetworkedEquipper>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr);
				NetworkedEquipper.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr, "<>9");
				NetworkedEquipper.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr, "<>9__20_0");
				NetworkedEquipper.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr, 100679983);
				NetworkedEquipper.__c.NativeMethodInfoPtr__PrintLists_b__20_0_Internal_String_EquippedItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr, 100679984);
			}

			// Token: 0x0600ECE2 RID: 60642 RVA: 0x00396550 File Offset: 0x00394750
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedEquipper.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600ECE3 RID: 60643 RVA: 0x0039658C File Offset: 0x0039478C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245346, XrefRangeEnd = 245355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _PrintLists_b__20_0(EquippedItemHandler i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkedEquipper.__c.NativeMethodInfoPtr__PrintLists_b__20_0_Internal_String_EquippedItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600ECE4 RID: 60644 RVA: 0x0006FC0E File Offset: 0x0006DE0E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D1 RID: 18385
			// (get) Token: 0x0600ECE5 RID: 60645 RVA: 0x003965D4 File Offset: 0x003947D4
			// (set) Token: 0x0600ECE6 RID: 60646 RVA: 0x0006FC17 File Offset: 0x0006DE17
			public unsafe static NetworkedEquipper.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NetworkedEquipper.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkedEquipper.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetworkedEquipper.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D2 RID: 18386
			// (get) Token: 0x0600ECE7 RID: 60647 RVA: 0x003965FC File Offset: 0x003947FC
			// (set) Token: 0x0600ECE8 RID: 60648 RVA: 0x0006FC29 File Offset: 0x0006DE29
			public unsafe static Func<EquippedItemHandler, string> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NetworkedEquipper.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EquippedItemHandler, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NetworkedEquipper.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A057 RID: 41047
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A058 RID: 41048
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x0400A059 RID: 41049
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A05A RID: 41050
			private static readonly IntPtr NativeMethodInfoPtr__PrintLists_b__20_0_Internal_String_EquippedItemHandler_0;
		}
	}
}
