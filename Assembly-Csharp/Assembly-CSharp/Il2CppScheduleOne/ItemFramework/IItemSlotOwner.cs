using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x0200034C RID: 844
	public class IItemSlotOwner : Il2CppObjectBase
	{
		// Token: 0x060047DE RID: 18398 RVA: 0x0016F474 File Offset: 0x0016D674
		// Note: this type is marked as 'beforefieldinit'.
		static IItemSlotOwner()
		{
			Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "IItemSlotOwner");
			IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672492);
			IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672493);
			IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672494);
			IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672495);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672496);
			IItemSlotOwner.NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672497);
			IItemSlotOwner.NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672498);
			IItemSlotOwner.NativeMethodInfoPtr_GetQuantitySum_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672499);
			IItemSlotOwner.NativeMethodInfoPtr_GetQuantityOfItem_Public_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672500);
			IItemSlotOwner.NativeMethodInfoPtr_GetNonEmptySlotCount_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672501);
			IItemSlotOwner.NativeMethodInfoPtr_GetFirstSlotContaining_Public_Virtual_New_ItemSlot_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672502);
			IItemSlotOwner.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, 100672503);
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x060047DF RID: 18399 RVA: 0x0016F58C File Offset: 0x0016D78C
		// (set) Token: 0x060047E0 RID: 18400 RVA: 0x0016F5D8 File Offset: 0x0016D7D8
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0016F628 File Offset: 0x0016D828
		[CallerCount(0)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0016F698 File Offset: 0x0016D898
		[CallerCount(0)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0016F6F0 File Offset: 0x0016D8F0
		[CallerCount(0)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0016F780 File Offset: 0x0016D980
		[CallerCount(0)]
		public unsafe virtual void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0016F7F0 File Offset: 0x0016D9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167078, XrefRangeEnd = 167105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendItemSlotDataToClient(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0016F840 File Offset: 0x0016DA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167105, XrefRangeEnd = 167126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetQuantitySum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetQuantitySum_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x0016F888 File Offset: 0x0016DA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167126, XrefRangeEnd = 167149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetQuantityOfItem(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetQuantityOfItem_Public_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0016F8E0 File Offset: 0x0016DAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167149, XrefRangeEnd = 167161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetNonEmptySlotCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetNonEmptySlotCount_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0016F928 File Offset: 0x0016DB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167161, XrefRangeEnd = 167183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemSlot GetFirstSlotContaining(string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IItemSlotOwner.NativeMethodInfoPtr_GetFirstSlotContaining_Public_Virtual_New_ItemSlot_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x0016F984 File Offset: 0x0016DB84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167246, RefRangeEnd = 167247, XrefRangeStart = 167183, XrefRangeEnd = 167246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_NetworkConnection_0(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x000230D3 File Offset: 0x000212D3
		public IItemSlotOwner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030D3 RID: 12499
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Abstract_Virtual_New_get_List_1_ItemSlot_0;

		// Token: 0x040030D4 RID: 12500
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Abstract_Virtual_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x040030D5 RID: 12501
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x040030D6 RID: 12502
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Abstract_Virtual_New_Void_Int32_Int32_0;

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotFilter_Public_Abstract_Virtual_New_Void_NetworkConnection_Int32_SlotFilter_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr_SendItemSlotDataToClient_Public_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr_GetQuantitySum_Public_Virtual_New_Int32_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr_GetQuantityOfItem_Public_Virtual_New_Int32_String_0;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeMethodInfoPtr_GetNonEmptySlotCount_Public_Virtual_New_Int32_0;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstSlotContaining_Public_Virtual_New_ItemSlot_String_0;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_NetworkConnection_0;

		// Token: 0x02000A6B RID: 2667
		[ObfuscatedName("ScheduleOne.ItemFramework.IItemSlotOwner+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E0E6 RID: 57574 RVA: 0x0037421C File Offset: 0x0037241C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IItemSlotOwner>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr);
				IItemSlotOwner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9");
				IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, "<>9__8_0");
				IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100672505);
				IItemSlotOwner.__c.NativeMethodInfoPtr__GetQuantitySum_b__8_0_Internal_Int32_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr, 100672506);
			}

			// Token: 0x0600E0E7 RID: 57575 RVA: 0x00374298 File Offset: 0x00372498
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IItemSlotOwner.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0E8 RID: 57576 RVA: 0x003742D4 File Offset: 0x003724D4
			[CallerCount(0)]
			public unsafe int _GetQuantitySum_b__8_0(ItemSlot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IItemSlotOwner.__c.NativeMethodInfoPtr__GetQuantitySum_b__8_0_Internal_Int32_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E0E9 RID: 57577 RVA: 0x0006A051 File Offset: 0x00068251
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004476 RID: 17526
			// (get) Token: 0x0600E0EA RID: 57578 RVA: 0x00374324 File Offset: 0x00372524
			// (set) Token: 0x0600E0EB RID: 57579 RVA: 0x0006A05A File Offset: 0x0006825A
			public unsafe static IItemSlotOwner.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004477 RID: 17527
			// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x0037434C File Offset: 0x0037254C
			// (set) Token: 0x0600E0ED RID: 57581 RVA: 0x0006A06C File Offset: 0x0006826C
			public unsafe static Func<ItemSlot, int> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ItemSlot, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IItemSlotOwner.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009913 RID: 39187
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009914 RID: 39188
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009915 RID: 39189
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009916 RID: 39190
			private static readonly IntPtr NativeMethodInfoPtr__GetQuantitySum_b__8_0_Internal_Int32_ItemSlot_0;
		}
	}
}
