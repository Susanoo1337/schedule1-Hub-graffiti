using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000357 RID: 855
	[Serializable]
	public class ItemSlot : Object
	{
		// Token: 0x0600485E RID: 18526 RVA: 0x00171054 File Offset: 0x0016F254
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlot()
		{
			Il2CppClassPointerStore<ItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr);
			ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ItemInstance>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SlotOwner>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onItemDataChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemDataChanged");
			ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onItemInstanceChanged");
			ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<ActiveLock>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onLocked");
			ItemSlot.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onUnlocked");
			ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsRemovalLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<IsAddLocked>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<HardFilters>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<CanPlayerSetFilter>k__BackingField");
			ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<PlayerFilter>k__BackingField");
			ItemSlot.NativeFieldInfoPtr_onFilterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "onFilterChange");
			ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, "<SiblingSet>k__BackingField");
			ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672559);
			ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672560);
			ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672561);
			ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672562);
			ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672563);
			ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672564);
			ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672565);
			ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672566);
			ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672567);
			ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672568);
			ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672569);
			ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672570);
			ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672571);
			ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672572);
			ItemSlot.NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672573);
			ItemSlot.NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672574);
			ItemSlot.NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672575);
			ItemSlot.NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672576);
			ItemSlot.NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672577);
			ItemSlot.NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672578);
			ItemSlot.NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672579);
			ItemSlot.NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672580);
			ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672581);
			ItemSlot.NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672582);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672583);
			ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672584);
			ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672585);
			ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672586);
			ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672587);
			ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672588);
			ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672589);
			ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672590);
			ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672591);
			ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672592);
			ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672593);
			ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672594);
			ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672595);
			ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672596);
			ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672597);
			ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672598);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672599);
			ItemSlot.NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672600);
			ItemSlot.NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672601);
			ItemSlot.NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672602);
			ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672603);
			ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672604);
			ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr, 100672605);
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x0600485F RID: 18527 RVA: 0x00171548 File Offset: 0x0016F748
		// (set) Token: 0x06004860 RID: 18528 RVA: 0x00171588 File Offset: 0x0016F788
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06004861 RID: 18529 RVA: 0x001715CC File Offset: 0x0016F7CC
		// (set) Token: 0x06004862 RID: 18530 RVA: 0x0017160C File Offset: 0x0016F80C
		public unsafe IItemSlotOwner SlotOwner
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016BC RID: 5820
		// (get) Token: 0x06004863 RID: 18531 RVA: 0x00171650 File Offset: 0x0016F850
		public unsafe int SlotIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167832, XrefRangeEnd = 167839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x0017168C File Offset: 0x0016F88C
		public unsafe int Quantity
		{
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 167839, RefRangeEnd = 167933, XrefRangeStart = 167839, XrefRangeEnd = 167839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x001716C8 File Offset: 0x0016F8C8
		public unsafe bool IsAtCapacity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x00171704 File Offset: 0x0016F904
		public unsafe bool IsLocked
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 167933, RefRangeEnd = 167958, XrefRangeStart = 167933, XrefRangeEnd = 167933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x00171740 File Offset: 0x0016F940
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x00171780 File Offset: 0x0016F980
		public unsafe ItemSlotLock ActiveLock
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x001717C4 File Offset: 0x0016F9C4
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x00171800 File Offset: 0x0016FA00
		public unsafe bool IsRemovalLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x00171840 File Offset: 0x0016FA40
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x0017187C File Offset: 0x0016FA7C
		public unsafe bool IsAddLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 46699, RefRangeEnd = 46708, XrefRangeStart = 46699, XrefRangeEnd = 46708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x001718BC File Offset: 0x0016FABC
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x001718FC File Offset: 0x0016FAFC
		public unsafe List<ItemFilter> HardFilters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x0600486F RID: 18543 RVA: 0x00171940 File Offset: 0x0016FB40
		// (set) Token: 0x06004870 RID: 18544 RVA: 0x0017197C File Offset: 0x0016FB7C
		public unsafe bool CanPlayerSetFilter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x06004871 RID: 18545 RVA: 0x001719BC File Offset: 0x0016FBBC
		// (set) Token: 0x06004872 RID: 18546 RVA: 0x001719FC File Offset: 0x0016FBFC
		public unsafe SlotFilter PlayerFilter
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06004873 RID: 18547 RVA: 0x00171A40 File Offset: 0x0016FC40
		// (set) Token: 0x06004874 RID: 18548 RVA: 0x00171A80 File Offset: 0x0016FC80
		public unsafe ItemSlotSiblingSet SiblingSet
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotSiblingSet>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004875 RID: 18549 RVA: 0x00171AC4 File Offset: 0x0016FCC4
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 167968, RefRangeEnd = 167994, XrefRangeStart = 167958, XrefRangeEnd = 167968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotOwner(IItemSlotOwner owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004876 RID: 18550 RVA: 0x00171B08 File Offset: 0x0016FD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167994, XrefRangeEnd = 168001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSiblingSet(ItemSlotSiblingSet set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004877 RID: 18551 RVA: 0x00171B4C File Offset: 0x0016FD4C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 168023, RefRangeEnd = 168039, XrefRangeStart = 168001, XrefRangeEnd = 168023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004878 RID: 18552 RVA: 0x00171B88 File Offset: 0x0016FD88
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 168061, RefRangeEnd = 168074, XrefRangeStart = 168039, XrefRangeEnd = 168061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlot(bool canPlayerSetFilter = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref canPlayerSetFilter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004879 RID: 18553 RVA: 0x00171BD0 File Offset: 0x0016FDD0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 168083, RefRangeEnd = 168088, XrefRangeStart = 168074, XrefRangeEnd = 168083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStoredInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487A RID: 18554 RVA: 0x00171C04 File Offset: 0x0016FE04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168109, RefRangeEnd = 168110, XrefRangeStart = 168088, XrefRangeEnd = 168109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredItem(ItemInstance instance, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487B RID: 18555 RVA: 0x00171C60 File Offset: 0x0016FE60
		[CallerCount(0)]
		public unsafe virtual void InsertItem(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487C RID: 18556 RVA: 0x00171CB0 File Offset: 0x0016FEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168110, XrefRangeEnd = 168118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(ItemInstance item, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487D RID: 18557 RVA: 0x00171D0C File Offset: 0x0016FF0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168130, RefRangeEnd = 168131, XrefRangeStart = 168118, XrefRangeEnd = 168130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearStoredInstance(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487E RID: 18558 RVA: 0x00171D58 File Offset: 0x0016FF58
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 168153, RefRangeEnd = 168177, XrefRangeStart = 168131, XrefRangeEnd = 168153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int amount, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600487F RID: 18559 RVA: 0x00171DA4 File Offset: 0x0016FFA4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 168199, RefRangeEnd = 168238, XrefRangeStart = 168177, XrefRangeEnd = 168199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeQuantity(int change, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004880 RID: 18560 RVA: 0x00171DF0 File Offset: 0x0016FFF0
		[CallerCount(0)]
		public unsafe virtual void ItemDataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004881 RID: 18561 RVA: 0x00171E2C File Offset: 0x0017002C
		[CallerCount(0)]
		public unsafe virtual void ClearItemInstanceRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004882 RID: 18562 RVA: 0x00171E68 File Offset: 0x00170068
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 168251, RefRangeEnd = 168267, XrefRangeStart = 168238, XrefRangeEnd = 168251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFilter(ItemFilter filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004883 RID: 18563 RVA: 0x00171EAC File Offset: 0x001700AC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 168277, RefRangeEnd = 168290, XrefRangeStart = 168267, XrefRangeEnd = 168277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLock(NetworkObject lockOwner, string lockReason, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004884 RID: 18564 RVA: 0x00171F10 File Offset: 0x00170110
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 168301, RefRangeEnd = 168314, XrefRangeStart = 168290, XrefRangeEnd = 168301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveLock(bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004885 RID: 18565 RVA: 0x00171F50 File Offset: 0x00170150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsRemovalLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004886 RID: 18566 RVA: 0x00171F90 File Offset: 0x00170190
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 46699, RefRangeEnd = 46708, XrefRangeStart = 46699, XrefRangeEnd = 46708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsAddLocked(bool locked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref locked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004887 RID: 18567 RVA: 0x00171FD0 File Offset: 0x001701D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168314, XrefRangeEnd = 168325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchHardFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004888 RID: 18568 RVA: 0x00172028 File Offset: 0x00170228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168325, XrefRangeEnd = 168337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchPlayerFilters(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004889 RID: 18569 RVA: 0x00172080 File Offset: 0x00170280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168342, RefRangeEnd = 168343, XrefRangeStart = 168337, XrefRangeEnd = 168342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFilterable(bool filterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref filterable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488A RID: 18570 RVA: 0x001720C0 File Offset: 0x001702C0
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 168352, RefRangeEnd = 168389, XrefRangeStart = 168343, XrefRangeEnd = 168352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerFilter(SlotFilter filter, bool _internal = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _internal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00172110 File Offset: 0x00170310
		[CallerCount(0)]
		public unsafe virtual int GetCapacityForItem(ItemInstance item, bool checkPlayerFilters = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkPlayerFilters;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00172178 File Offset: 0x00170378
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanSlotAcceptCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlot.NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488D RID: 18573 RVA: 0x001721C0 File Offset: 0x001703C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168414, RefRangeEnd = 168416, XrefRangeStart = 168389, XrefRangeEnd = 168414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryInsertItemIntoSet(List<ItemSlot> ItemSlots, ItemInstance item)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ItemSlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlot.NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600488E RID: 18574 RVA: 0x000233AC File Offset: 0x000215AC
		public ItemSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x00172214 File Offset: 0x00170414
		// (set) Token: 0x06004890 RID: 18576 RVA: 0x000233B5 File Offset: 0x000215B5
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x00172244 File Offset: 0x00170444
		// (set) Token: 0x06004892 RID: 18578 RVA: 0x000233D4 File Offset: 0x000215D4
		public unsafe IItemSlotOwner _SlotOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IItemSlotOwner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SlotOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x00172274 File Offset: 0x00170474
		// (set) Token: 0x06004894 RID: 18580 RVA: 0x000233F3 File Offset: 0x000215F3
		public unsafe Action onItemDataChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemDataChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06004895 RID: 18581 RVA: 0x001722A4 File Offset: 0x001704A4
		// (set) Token: 0x06004896 RID: 18582 RVA: 0x00023412 File Offset: 0x00021612
		public unsafe Action onItemInstanceChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onItemInstanceChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06004897 RID: 18583 RVA: 0x001722D4 File Offset: 0x001704D4
		// (set) Token: 0x06004898 RID: 18584 RVA: 0x00023431 File Offset: 0x00021631
		public unsafe ItemSlotLock _ActiveLock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__ActiveLock_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06004899 RID: 18585 RVA: 0x00172304 File Offset: 0x00170504
		// (set) Token: 0x0600489A RID: 18586 RVA: 0x00023450 File Offset: 0x00021650
		public unsafe Action onLocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onLocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x0600489B RID: 18587 RVA: 0x00172334 File Offset: 0x00170534
		// (set) Token: 0x0600489C RID: 18588 RVA: 0x0002346F File Offset: 0x0002166F
		public unsafe Action onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x0600489D RID: 18589 RVA: 0x00172364 File Offset: 0x00170564
		// (set) Token: 0x0600489E RID: 18590 RVA: 0x0002348E File Offset: 0x0002168E
		public unsafe bool _IsRemovalLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsRemovalLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x0600489F RID: 18591 RVA: 0x0017238C File Offset: 0x0017058C
		// (set) Token: 0x060048A0 RID: 18592 RVA: 0x000234A9 File Offset: 0x000216A9
		public unsafe bool _IsAddLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__IsAddLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x060048A1 RID: 18593 RVA: 0x001723B4 File Offset: 0x001705B4
		// (set) Token: 0x060048A2 RID: 18594 RVA: 0x000234C4 File Offset: 0x000216C4
		public unsafe List<ItemFilter> _HardFilters_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__HardFilters_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x060048A3 RID: 18595 RVA: 0x001723E4 File Offset: 0x001705E4
		// (set) Token: 0x060048A4 RID: 18596 RVA: 0x000234E3 File Offset: 0x000216E3
		public unsafe bool _CanPlayerSetFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField)) = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x0017240C File Offset: 0x0017060C
		// (set) Token: 0x060048A6 RID: 18598 RVA: 0x000234FE File Offset: 0x000216FE
		public unsafe SlotFilter _PlayerFilter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__PlayerFilter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x060048A7 RID: 18599 RVA: 0x0017243C File Offset: 0x0017063C
		// (set) Token: 0x060048A8 RID: 18600 RVA: 0x0002351D File Offset: 0x0002171D
		public unsafe Action onFilterChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onFilterChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr_onFilterChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x060048A9 RID: 18601 RVA: 0x0017246C File Offset: 0x0017066C
		// (set) Token: 0x060048AA RID: 18602 RVA: 0x0002353C File Offset: 0x0002173C
		public unsafe ItemSlotSiblingSet _SiblingSet_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotSiblingSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlot.NativeFieldInfoPtr__SiblingSet_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeFieldInfoPtr__SlotOwner_k__BackingField;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeFieldInfoPtr_onItemDataChanged;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeFieldInfoPtr_onItemInstanceChanged;

		// Token: 0x0400312E RID: 12590
		private static readonly IntPtr NativeFieldInfoPtr__ActiveLock_k__BackingField;

		// Token: 0x0400312F RID: 12591
		private static readonly IntPtr NativeFieldInfoPtr_onLocked;

		// Token: 0x04003130 RID: 12592
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x04003131 RID: 12593
		private static readonly IntPtr NativeFieldInfoPtr__IsRemovalLocked_k__BackingField;

		// Token: 0x04003132 RID: 12594
		private static readonly IntPtr NativeFieldInfoPtr__IsAddLocked_k__BackingField;

		// Token: 0x04003133 RID: 12595
		private static readonly IntPtr NativeFieldInfoPtr__HardFilters_k__BackingField;

		// Token: 0x04003134 RID: 12596
		private static readonly IntPtr NativeFieldInfoPtr__CanPlayerSetFilter_k__BackingField;

		// Token: 0x04003135 RID: 12597
		private static readonly IntPtr NativeFieldInfoPtr__PlayerFilter_k__BackingField;

		// Token: 0x04003136 RID: 12598
		private static readonly IntPtr NativeFieldInfoPtr_onFilterChange;

		// Token: 0x04003137 RID: 12599
		private static readonly IntPtr NativeFieldInfoPtr__SiblingSet_k__BackingField;

		// Token: 0x04003138 RID: 12600
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x04003139 RID: 12601
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Protected_set_Void_ItemInstance_0;

		// Token: 0x0400313A RID: 12602
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotOwner_Public_get_IItemSlotOwner_0;

		// Token: 0x0400313B RID: 12603
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotOwner_Protected_set_Void_IItemSlotOwner_0;

		// Token: 0x0400313C RID: 12604
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotIndex_Private_get_Int32_0;

		// Token: 0x0400313D RID: 12605
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x0400313E RID: 12606
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAtCapacity_Public_get_Boolean_0;

		// Token: 0x0400313F RID: 12607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0;

		// Token: 0x04003140 RID: 12608
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveLock_Public_get_ItemSlotLock_0;

		// Token: 0x04003141 RID: 12609
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveLock_Protected_set_Void_ItemSlotLock_0;

		// Token: 0x04003142 RID: 12610
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRemovalLocked_Public_get_Boolean_0;

		// Token: 0x04003143 RID: 12611
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRemovalLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04003144 RID: 12612
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAddLocked_Public_get_Boolean_0;

		// Token: 0x04003145 RID: 12613
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAddLocked_Protected_set_Void_Boolean_0;

		// Token: 0x04003146 RID: 12614
		private static readonly IntPtr NativeMethodInfoPtr_get_HardFilters_Protected_get_List_1_ItemFilter_0;

		// Token: 0x04003147 RID: 12615
		private static readonly IntPtr NativeMethodInfoPtr_set_HardFilters_Protected_set_Void_List_1_ItemFilter_0;

		// Token: 0x04003148 RID: 12616
		private static readonly IntPtr NativeMethodInfoPtr_get_CanPlayerSetFilter_Public_get_Boolean_0;

		// Token: 0x04003149 RID: 12617
		private static readonly IntPtr NativeMethodInfoPtr_set_CanPlayerSetFilter_Public_set_Void_Boolean_0;

		// Token: 0x0400314A RID: 12618
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerFilter_Public_get_SlotFilter_0;

		// Token: 0x0400314B RID: 12619
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerFilter_Public_set_Void_SlotFilter_0;

		// Token: 0x0400314C RID: 12620
		private static readonly IntPtr NativeMethodInfoPtr_get_SiblingSet_Public_get_ItemSlotSiblingSet_0;

		// Token: 0x0400314D RID: 12621
		private static readonly IntPtr NativeMethodInfoPtr_set_SiblingSet_Public_set_Void_ItemSlotSiblingSet_0;

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotOwner_Public_Void_IItemSlotOwner_0;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr_SetSiblingSet_Public_Void_ItemSlotSiblingSet_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003151 RID: 12625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04003152 RID: 12626
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateStoredInstance_Public_Void_0;

		// Token: 0x04003153 RID: 12627
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04003154 RID: 12628
		private static readonly IntPtr NativeMethodInfoPtr_InsertItem_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04003155 RID: 12629
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ItemInstance_Boolean_0;

		// Token: 0x04003156 RID: 12630
		private static readonly IntPtr NativeMethodInfoPtr_ClearStoredInstance_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04003157 RID: 12631
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeMethodInfoPtr_ChangeQuantity_Public_Void_Int32_Boolean_0;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeMethodInfoPtr_ItemDataChanged_Protected_Virtual_New_Void_0;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeMethodInfoPtr_ClearItemInstanceRequested_Protected_Virtual_New_Void_0;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeMethodInfoPtr_AddFilter_Public_Void_ItemFilter_0;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLock_Public_Void_NetworkObject_String_Boolean_0;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLock_Public_Void_Boolean_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr_SetIsRemovalLocked_Public_Void_Boolean_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_SetIsAddLocked_Public_Void_Boolean_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchHardFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchPlayerFilters_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_SetFilterable_Public_Void_Boolean_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerFilter_Public_Void_SlotFilter_Boolean_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacityForItem_Public_Virtual_New_Int32_ItemInstance_Boolean_0;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_CanSlotAcceptCash_Public_Virtual_New_Boolean_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr_TryInsertItemIntoSet_Public_Static_Boolean_List_1_ItemSlot_ItemInstance_0;
	}
}
