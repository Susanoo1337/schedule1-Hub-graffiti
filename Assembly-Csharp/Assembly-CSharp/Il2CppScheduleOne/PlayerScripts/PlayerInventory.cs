using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000329 RID: 809
	public class PlayerInventory : PlayerSingleton<PlayerInventory>
	{
		// Token: 0x06004378 RID: 17272 RVA: 0x00161B2C File Offset: 0x0015FD2C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerInventory()
		{
			Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerInventory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr);
			PlayerInventory.NativeFieldInfoPtr_InventorySlotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "InventorySlotCount");
			PlayerInventory.NativeFieldInfoPtr_LabelDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LabelDisplayTime");
			PlayerInventory.NativeFieldInfoPtr_LabelFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "LabelFadeTime");
			PlayerInventory.NativeFieldInfoPtr_DiscardDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "DiscardDuration");
			PlayerInventory.NativeFieldInfoPtr_giveStartupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "giveStartupItems");
			PlayerInventory.NativeFieldInfoPtr_startupItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "startupItems");
			PlayerInventory.NativeFieldInfoPtr_equipContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "equipContainer");
			PlayerInventory.NativeFieldInfoPtr_hotbarSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "hotbarSlots");
			PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashSlot>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<cashInstance>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_clipboardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "clipboardSlot");
			PlayerInventory.NativeFieldInfoPtr_slotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "slotUIs");
			PlayerInventory.NativeFieldInfoPtr_equippableSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "equippableSlots");
			PlayerInventory.NativeFieldInfoPtr_discardSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "discardSlot");
			PlayerInventory.NativeFieldInfoPtr__holsterAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "_holsterAction");
			PlayerInventory.NativeFieldInfoPtr_ItemVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariables");
			PlayerInventory.NativeFieldInfoPtr__equippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "_equippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<HotbarEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<EquippingEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__HolsterEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<HolsterEnabled>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__Equippable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<Equippable>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__CurrentEquipTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<CurrentEquipTime>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr__AttachedScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<AttachedScreen>k__BackingField");
			PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onInventoryStateChanged");
			PlayerInventory.NativeFieldInfoPtr_onEquippedSlotChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onEquippedSlotChanged");
			PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onPreItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_onItemEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "onItemEquipped");
			PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PriorEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "PreviousEquippedSlotIndex");
			PlayerInventory.NativeFieldInfoPtr__managementSlotEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "_managementSlotEnabled");
			PlayerInventory.NativeFieldInfoPtr__currentDiscardTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "_currentDiscardTime");
			PlayerInventory.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "uiPanel");
			PlayerInventory.NativeFieldInfoPtr_originalSelectedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "originalSelectedPanel");
			PlayerInventory.NativeMethodInfoPtr_get_EquippableSlotCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672046);
			PlayerInventory.NativeMethodInfoPtr_get_EquipContainer_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672047);
			PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672048);
			PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672049);
			PlayerInventory.NativeMethodInfoPtr_get_SlotUIs_Public_get_List_1_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672050);
			PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672051);
			PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672052);
			PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672053);
			PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672054);
			PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672055);
			PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672056);
			PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672057);
			PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672058);
			PlayerInventory.NativeMethodInfoPtr_get_HolsterEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672059);
			PlayerInventory.NativeMethodInfoPtr_set_HolsterEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672060);
			PlayerInventory.NativeMethodInfoPtr_get_Equippable_Public_get_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672061);
			PlayerInventory.NativeMethodInfoPtr_set_Equippable_Protected_set_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672062);
			PlayerInventory.NativeMethodInfoPtr_get_CurrentEquipTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672063);
			PlayerInventory.NativeMethodInfoPtr_set_CurrentEquipTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672064);
			PlayerInventory.NativeMethodInfoPtr_get_AttachedScreen_Public_get_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672065);
			PlayerInventory.NativeMethodInfoPtr_set_AttachedScreen_Private_set_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672066);
			PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672067);
			PlayerInventory.NativeMethodInfoPtr_get_EquippedItem_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672068);
			PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672069);
			PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672070);
			PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672071);
			PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672072);
			PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672073);
			PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672074);
			PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672075);
			PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672076);
			PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672077);
			PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672078);
			PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672079);
			PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672080);
			PlayerInventory.NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672081);
			PlayerInventory.NativeMethodInfoPtr_DetachFromScreen_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672082);
			PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672083);
			PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672084);
			PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672085);
			PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672086);
			PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672087);
			PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672088);
			PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672089);
			PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672090);
			PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672091);
			PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672092);
			PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672093);
			PlayerInventory.NativeMethodInfoPtr_EquippedSlotChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672094);
			PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672095);
			PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672096);
			PlayerInventory.NativeMethodInfoPtr_HotbarSlotSelected_Private_Void_HotbarSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672097);
			PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672098);
			PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672099);
			PlayerInventory.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672100);
			PlayerInventory.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672101);
			PlayerInventory.NativeMethodInfoPtr__Start_b__78_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, 100672102);
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06004379 RID: 17273 RVA: 0x00162264 File Offset: 0x00160464
		public unsafe int EquippableSlotCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippableSlotCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x001622A0 File Offset: 0x001604A0
		public unsafe virtual Transform EquipContainer
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquipContainer_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x0600437B RID: 17275 RVA: 0x001622E0 File Offset: 0x001604E0
		// (set) Token: 0x0600437C RID: 17276 RVA: 0x00162320 File Offset: 0x00160520
		public unsafe CashSlot cashSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x0600437D RID: 17277 RVA: 0x00162364 File Offset: 0x00160564
		public unsafe List<ItemSlotUI> SlotUIs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_SlotUIs_Public_get_List_1_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr3) : null;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x001623A4 File Offset: 0x001605A4
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x001623E4 File Offset: 0x001605E4
		public unsafe CashInstance cashInstance
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x00162428 File Offset: 0x00160628
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x00162464 File Offset: 0x00160664
		public unsafe int EquippedSlotIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 161948, RefRangeEnd = 161951, XrefRangeStart = 161942, XrefRangeEnd = 161948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippedSlotIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x001624A4 File Offset: 0x001606A4
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x001624E0 File Offset: 0x001606E0
		public unsafe bool HotbarEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x00162520 File Offset: 0x00160720
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x0016255C File Offset: 0x0016075C
		public unsafe bool EquippingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x0016259C File Offset: 0x0016079C
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x001625D8 File Offset: 0x001607D8
		public unsafe bool HolsterEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_HolsterEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_HolsterEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x00162618 File Offset: 0x00160818
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x00162658 File Offset: 0x00160858
		public unsafe Equippable Equippable
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_Equippable_Public_get_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 142409, RefRangeEnd = 142410, XrefRangeStart = 142409, XrefRangeEnd = 142410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_Equippable_Protected_set_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x0016269C File Offset: 0x0016089C
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x001626D8 File Offset: 0x001608D8
		public unsafe float CurrentEquipTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_CurrentEquipTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_CurrentEquipTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x00162718 File Offset: 0x00160918
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x00162758 File Offset: 0x00160958
		public unsafe UIScreen AttachedScreen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_AttachedScreen_Public_get_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161951, XrefRangeEnd = 161952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_set_AttachedScreen_Private_set_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x0016279C File Offset: 0x0016099C
		public unsafe HotbarSlot equippedSlot
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 161953, RefRangeEnd = 161965, XrefRangeStart = 161952, XrefRangeEnd = 161953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x0600438F RID: 17295 RVA: 0x001627DC File Offset: 0x001609DC
		public unsafe ItemInstance EquippedItem
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 161967, RefRangeEnd = 161969, XrefRangeStart = 161965, XrefRangeEnd = 161967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_EquippedItem_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x0016281C File Offset: 0x00160A1C
		public unsafe bool isAnythingEquipped
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 161971, RefRangeEnd = 161986, XrefRangeStart = 161969, XrefRangeEnd = 161971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00162858 File Offset: 0x00160A58
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 161988, RefRangeEnd = 162004, XrefRangeStart = 161986, XrefRangeEnd = 161988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HotbarSlot IndexAllSlots(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr3) : null;
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x001628A4 File Offset: 0x00160AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162004, XrefRangeEnd = 162029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x001628E0 File Offset: 0x00160AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162210, RefRangeEnd = 162211, XrefRangeStart = 162029, XrefRangeEnd = 162210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupInventoryUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00162914 File Offset: 0x00160B14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162291, RefRangeEnd = 162294, XrefRangeStart = 162211, XrefRangeEnd = 162291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RepositionUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00162948 File Offset: 0x00160B48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162294, XrefRangeEnd = 162358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00162984 File Offset: 0x00160B84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162381, RefRangeEnd = 162382, XrefRangeStart = 162358, XrefRangeEnd = 162381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveStartupItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GiveStartupItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x001629B8 File Offset: 0x00160BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162382, XrefRangeEnd = 162425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerInventory.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x001629F4 File Offset: 0x00160BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162481, RefRangeEnd = 162482, XrefRangeStart = 162425, XrefRangeEnd = 162481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHotbarSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00162A28 File Offset: 0x00160C28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162493, RefRangeEnd = 162496, XrefRangeStart = 162482, XrefRangeEnd = 162493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Equip(HotbarSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00162A6C File Offset: 0x00160C6C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162503, RefRangeEnd = 162507, XrefRangeStart = 162496, XrefRangeEnd = 162503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInventoryEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00162AAC File Offset: 0x00160CAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162533, RefRangeEnd = 162537, XrefRangeStart = 162507, XrefRangeEnd = 162533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00162AEC File Offset: 0x00160CEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162559, RefRangeEnd = 162562, XrefRangeStart = 162537, XrefRangeEnd = 162559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachToScreen(UIScreen screen, bool alsoSelectInventoryPanel = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alsoSelectInventoryPanel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00162B3C File Offset: 0x00160D3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162574, RefRangeEnd = 162578, XrefRangeStart = 162562, XrefRangeEnd = 162574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachFromScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_DetachFromScreen_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00162B70 File Offset: 0x00160D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162578, XrefRangeEnd = 162592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClipboardAcquiredVarChange(bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00162BB0 File Offset: 0x00160DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetManagementClipboardEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00162BF0 File Offset: 0x00160DF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162612, RefRangeEnd = 162614, XrefRangeStart = 162592, XrefRangeEnd = 162612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetViewmodelVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00162C30 File Offset: 0x00160E30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 162626, RefRangeEnd = 162631, XrefRangeStart = 162614, XrefRangeEnd = 162626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanItemFitInInventory(ItemInstance item, int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00162C8C File Offset: 0x00160E8C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162664, RefRangeEnd = 162680, XrefRangeStart = 162631, XrefRangeEnd = 162664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItemToInventory(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00162CD0 File Offset: 0x00160ED0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162694, RefRangeEnd = 162696, XrefRangeStart = 162680, XrefRangeEnd = 162694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetAmountOfItem(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00162D20 File Offset: 0x00160F20
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 162727, RefRangeEnd = 162738, XrefRangeStart = 162696, XrefRangeEnd = 162727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAmountOfItem(string ID, uint amount = 1U)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00162D70 File Offset: 0x00160F70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162745, RefRangeEnd = 162746, XrefRangeStart = 162738, XrefRangeEnd = 162745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_ClearInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00162DA4 File Offset: 0x00160FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162746, XrefRangeEnd = 162766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveProductFromInventory(EStealthLevel maxStealth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref maxStealth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00162DE4 File Offset: 0x00160FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162766, XrefRangeEnd = 162778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveRandomItemsFromInventory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00162E18 File Offset: 0x00161018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162784, RefRangeEnd = 162787, XrefRangeStart = 162778, XrefRangeEnd = 162784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEquippable(Equippable eq)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eq);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00162E5C File Offset: 0x0016105C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 162787, RefRangeEnd = 162792, XrefRangeStart = 162787, XrefRangeEnd = 162787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EquippedSlotChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_EquippedSlotChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00162E90 File Offset: 0x00161090
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 162794, RefRangeEnd = 162797, XrefRangeStart = 162792, XrefRangeEnd = 162794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Reequip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00162EC4 File Offset: 0x001610C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 162815, RefRangeEnd = 162822, XrefRangeStart = 162797, XrefRangeEnd = 162815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAllInventorySlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00162F04 File Offset: 0x00161104
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HotbarSlotSelected(HotbarSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_HotbarSlotSelected_Private_Void_HotbarSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00162F48 File Offset: 0x00161148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 162914, RefRangeEnd = 162916, XrefRangeStart = 162822, XrefRangeEnd = 162914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInventoryVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00162F7C File Offset: 0x0016117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162916, XrefRangeEnd = 162952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerInventory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00162FB8 File Offset: 0x001611B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162952, XrefRangeEnd = 162961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_ItemSlotUI_PDM_0(ItemSlotUI s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00162FFC File Offset: 0x001611FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162961, XrefRangeEnd = 162970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_ItemSlotUI_PDM_1(ItemSlotUI s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00163040 File Offset: 0x00161240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162970, XrefRangeEnd = 162977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__78_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.NativeMethodInfoPtr__Start_b__78_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00020DC3 File Offset: 0x0001EFC3
		public PlayerInventory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x00163074 File Offset: 0x00161274
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x00020DCC File Offset: 0x0001EFCC
		public unsafe static int InventorySlotCount
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_InventorySlotCount, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_InventorySlotCount, (void*)(&value));
			}
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x060043B5 RID: 17333 RVA: 0x00163090 File Offset: 0x00161290
		// (set) Token: 0x060043B6 RID: 17334 RVA: 0x00020DDA File Offset: 0x0001EFDA
		public unsafe static float LabelDisplayTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LabelDisplayTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LabelDisplayTime, (void*)(&value));
			}
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060043B7 RID: 17335 RVA: 0x001630AC File Offset: 0x001612AC
		// (set) Token: 0x060043B8 RID: 17336 RVA: 0x00020DE8 File Offset: 0x0001EFE8
		public unsafe static float LabelFadeTime
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_LabelFadeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_LabelFadeTime, (void*)(&value));
			}
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060043B9 RID: 17337 RVA: 0x001630C8 File Offset: 0x001612C8
		// (set) Token: 0x060043BA RID: 17338 RVA: 0x00020DF6 File Offset: 0x0001EFF6
		public unsafe static float DiscardDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerInventory.NativeFieldInfoPtr_DiscardDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerInventory.NativeFieldInfoPtr_DiscardDuration, (void*)(&value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060043BB RID: 17339 RVA: 0x001630E4 File Offset: 0x001612E4
		// (set) Token: 0x060043BC RID: 17340 RVA: 0x00020E04 File Offset: 0x0001F004
		public unsafe bool giveStartupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_giveStartupItems)) = value;
			}
		}

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x060043BD RID: 17341 RVA: 0x0016310C File Offset: 0x0016130C
		// (set) Token: 0x060043BE RID: 17342 RVA: 0x00020E1F File Offset: 0x0001F01F
		public unsafe List<PlayerInventory.ItemAmount> startupItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemAmount>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_startupItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x060043BF RID: 17343 RVA: 0x0016313C File Offset: 0x0016133C
		// (set) Token: 0x060043C0 RID: 17344 RVA: 0x00020E3E File Offset: 0x0001F03E
		public unsafe Transform equipContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equipContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x0016316C File Offset: 0x0016136C
		// (set) Token: 0x060043C2 RID: 17346 RVA: 0x00020E5D File Offset: 0x0001F05D
		public unsafe List<HotbarSlot> hotbarSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HotbarSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_hotbarSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x0016319C File Offset: 0x0016139C
		// (set) Token: 0x060043C4 RID: 17348 RVA: 0x00020E7C File Offset: 0x0001F07C
		public unsafe CashSlot _cashSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x060043C5 RID: 17349 RVA: 0x001631CC File Offset: 0x001613CC
		// (set) Token: 0x060043C6 RID: 17350 RVA: 0x00020E9B File Offset: 0x0001F09B
		public unsafe CashInstance _cashInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__cashInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x060043C7 RID: 17351 RVA: 0x001631FC File Offset: 0x001613FC
		// (set) Token: 0x060043C8 RID: 17352 RVA: 0x00020EBA File Offset: 0x0001F0BA
		public unsafe ClipboardSlot clipboardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClipboardSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_clipboardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x0016322C File Offset: 0x0016142C
		// (set) Token: 0x060043CA RID: 17354 RVA: 0x00020ED9 File Offset: 0x0001F0D9
		public unsafe List<ItemSlotUI> slotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_slotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x060043CB RID: 17355 RVA: 0x0016325C File Offset: 0x0016145C
		// (set) Token: 0x060043CC RID: 17356 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		public unsafe List<HotbarSlot> equippableSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equippableSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HotbarSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_equippableSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x060043CD RID: 17357 RVA: 0x0016328C File Offset: 0x0016148C
		// (set) Token: 0x060043CE RID: 17358 RVA: 0x00020F17 File Offset: 0x0001F117
		public unsafe ItemSlot discardSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_discardSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x001632BC File Offset: 0x001614BC
		// (set) Token: 0x060043D0 RID: 17360 RVA: 0x00020F36 File Offset: 0x0001F136
		public unsafe InputActionReference _holsterAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__holsterAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__holsterAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060043D1 RID: 17361 RVA: 0x001632EC File Offset: 0x001614EC
		// (set) Token: 0x060043D2 RID: 17362 RVA: 0x00020F55 File Offset: 0x0001F155
		public unsafe List<PlayerInventory.ItemVariable> ItemVariables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerInventory.ItemVariable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_ItemVariables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060043D3 RID: 17363 RVA: 0x0016331C File Offset: 0x0016151C
		// (set) Token: 0x060043D4 RID: 17364 RVA: 0x00020F74 File Offset: 0x0001F174
		public unsafe int _equippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__equippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060043D5 RID: 17365 RVA: 0x00163344 File Offset: 0x00161544
		// (set) Token: 0x060043D6 RID: 17366 RVA: 0x00020F8F File Offset: 0x0001F18F
		public unsafe bool _HotbarEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HotbarEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060043D7 RID: 17367 RVA: 0x0016336C File Offset: 0x0016156C
		// (set) Token: 0x060043D8 RID: 17368 RVA: 0x00020FAA File Offset: 0x0001F1AA
		public unsafe bool _EquippingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__EquippingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x060043D9 RID: 17369 RVA: 0x00163394 File Offset: 0x00161594
		// (set) Token: 0x060043DA RID: 17370 RVA: 0x00020FC5 File Offset: 0x0001F1C5
		public unsafe bool _HolsterEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HolsterEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__HolsterEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060043DB RID: 17371 RVA: 0x001633BC File Offset: 0x001615BC
		// (set) Token: 0x060043DC RID: 17372 RVA: 0x00020FE0 File Offset: 0x0001F1E0
		public unsafe Equippable _Equippable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__Equippable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__Equippable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x060043DD RID: 17373 RVA: 0x001633EC File Offset: 0x001615EC
		// (set) Token: 0x060043DE RID: 17374 RVA: 0x00020FFF File Offset: 0x0001F1FF
		public unsafe float _CurrentEquipTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__CurrentEquipTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__CurrentEquipTime_k__BackingField)) = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x060043DF RID: 17375 RVA: 0x00163414 File Offset: 0x00161614
		// (set) Token: 0x060043E0 RID: 17376 RVA: 0x0002101A File Offset: 0x0001F21A
		public unsafe UIScreen _AttachedScreen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__AttachedScreen_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__AttachedScreen_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00163444 File Offset: 0x00161644
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x00021039 File Offset: 0x0001F239
		public unsafe Action<bool> onInventoryStateChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onInventoryStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00163474 File Offset: 0x00161674
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x00021058 File Offset: 0x0001F258
		public unsafe Action<int> onEquippedSlotChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onEquippedSlotChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onEquippedSlotChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x001634A4 File Offset: 0x001616A4
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x00021077 File Offset: 0x0001F277
		public unsafe UnityEvent onPreItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onPreItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x001634D4 File Offset: 0x001616D4
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x00021096 File Offset: 0x0001F296
		public unsafe UnityEvent onItemEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_onItemEquipped), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x00163504 File Offset: 0x00161704
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x000210B5 File Offset: 0x0001F2B5
		public unsafe int PriorEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PriorEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x0016352C File Offset: 0x0016172C
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x000210D0 File Offset: 0x0001F2D0
		public unsafe int PreviousEquippedSlotIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_PreviousEquippedSlotIndex)) = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x00163554 File Offset: 0x00161754
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x000210EB File Offset: 0x0001F2EB
		public unsafe bool _managementSlotEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__managementSlotEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__managementSlotEnabled)) = value;
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x0016357C File Offset: 0x0016177C
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x00021106 File Offset: 0x0001F306
		public unsafe float _currentDiscardTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__currentDiscardTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr__currentDiscardTime)) = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x001635A4 File Offset: 0x001617A4
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x00021121 File Offset: 0x0001F321
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x060043F3 RID: 17395 RVA: 0x001635D4 File Offset: 0x001617D4
		// (set) Token: 0x060043F4 RID: 17396 RVA: 0x00021140 File Offset: 0x0001F340
		public unsafe UIPanel originalSelectedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_originalSelectedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.NativeFieldInfoPtr_originalSelectedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeFieldInfoPtr_InventorySlotCount;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeFieldInfoPtr_LabelDisplayTime;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeFieldInfoPtr_LabelFadeTime;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeFieldInfoPtr_DiscardDuration;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeFieldInfoPtr_giveStartupItems;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeFieldInfoPtr_startupItems;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeFieldInfoPtr_equipContainer;

		// Token: 0x04002E00 RID: 11776
		private static readonly IntPtr NativeFieldInfoPtr_hotbarSlots;

		// Token: 0x04002E01 RID: 11777
		private static readonly IntPtr NativeFieldInfoPtr__cashSlot_k__BackingField;

		// Token: 0x04002E02 RID: 11778
		private static readonly IntPtr NativeFieldInfoPtr__cashInstance_k__BackingField;

		// Token: 0x04002E03 RID: 11779
		private static readonly IntPtr NativeFieldInfoPtr_clipboardSlot;

		// Token: 0x04002E04 RID: 11780
		private static readonly IntPtr NativeFieldInfoPtr_slotUIs;

		// Token: 0x04002E05 RID: 11781
		private static readonly IntPtr NativeFieldInfoPtr_equippableSlots;

		// Token: 0x04002E06 RID: 11782
		private static readonly IntPtr NativeFieldInfoPtr_discardSlot;

		// Token: 0x04002E07 RID: 11783
		private static readonly IntPtr NativeFieldInfoPtr__holsterAction;

		// Token: 0x04002E08 RID: 11784
		private static readonly IntPtr NativeFieldInfoPtr_ItemVariables;

		// Token: 0x04002E09 RID: 11785
		private static readonly IntPtr NativeFieldInfoPtr__equippedSlotIndex;

		// Token: 0x04002E0A RID: 11786
		private static readonly IntPtr NativeFieldInfoPtr__HotbarEnabled_k__BackingField;

		// Token: 0x04002E0B RID: 11787
		private static readonly IntPtr NativeFieldInfoPtr__EquippingEnabled_k__BackingField;

		// Token: 0x04002E0C RID: 11788
		private static readonly IntPtr NativeFieldInfoPtr__HolsterEnabled_k__BackingField;

		// Token: 0x04002E0D RID: 11789
		private static readonly IntPtr NativeFieldInfoPtr__Equippable_k__BackingField;

		// Token: 0x04002E0E RID: 11790
		private static readonly IntPtr NativeFieldInfoPtr__CurrentEquipTime_k__BackingField;

		// Token: 0x04002E0F RID: 11791
		private static readonly IntPtr NativeFieldInfoPtr__AttachedScreen_k__BackingField;

		// Token: 0x04002E10 RID: 11792
		private static readonly IntPtr NativeFieldInfoPtr_onInventoryStateChanged;

		// Token: 0x04002E11 RID: 11793
		private static readonly IntPtr NativeFieldInfoPtr_onEquippedSlotChanged;

		// Token: 0x04002E12 RID: 11794
		private static readonly IntPtr NativeFieldInfoPtr_onPreItemEquipped;

		// Token: 0x04002E13 RID: 11795
		private static readonly IntPtr NativeFieldInfoPtr_onItemEquipped;

		// Token: 0x04002E14 RID: 11796
		private static readonly IntPtr NativeFieldInfoPtr_PriorEquippedSlotIndex;

		// Token: 0x04002E15 RID: 11797
		private static readonly IntPtr NativeFieldInfoPtr_PreviousEquippedSlotIndex;

		// Token: 0x04002E16 RID: 11798
		private static readonly IntPtr NativeFieldInfoPtr__managementSlotEnabled;

		// Token: 0x04002E17 RID: 11799
		private static readonly IntPtr NativeFieldInfoPtr__currentDiscardTime;

		// Token: 0x04002E18 RID: 11800
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04002E19 RID: 11801
		private static readonly IntPtr NativeFieldInfoPtr_originalSelectedPanel;

		// Token: 0x04002E1A RID: 11802
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippableSlotCount_Private_get_Int32_0;

		// Token: 0x04002E1B RID: 11803
		private static readonly IntPtr NativeMethodInfoPtr_get_EquipContainer_Public_Virtual_Final_New_get_Transform_0;

		// Token: 0x04002E1C RID: 11804
		private static readonly IntPtr NativeMethodInfoPtr_get_cashSlot_Public_get_CashSlot_0;

		// Token: 0x04002E1D RID: 11805
		private static readonly IntPtr NativeMethodInfoPtr_set_cashSlot_Private_set_Void_CashSlot_0;

		// Token: 0x04002E1E RID: 11806
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotUIs_Public_get_List_1_ItemSlotUI_0;

		// Token: 0x04002E1F RID: 11807
		private static readonly IntPtr NativeMethodInfoPtr_get_cashInstance_Public_get_CashInstance_0;

		// Token: 0x04002E20 RID: 11808
		private static readonly IntPtr NativeMethodInfoPtr_set_cashInstance_Protected_set_Void_CashInstance_0;

		// Token: 0x04002E21 RID: 11809
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedSlotIndex_Public_get_Int32_0;

		// Token: 0x04002E22 RID: 11810
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippedSlotIndex_Public_set_Void_Int32_0;

		// Token: 0x04002E23 RID: 11811
		private static readonly IntPtr NativeMethodInfoPtr_get_HotbarEnabled_Public_get_Boolean_0;

		// Token: 0x04002E24 RID: 11812
		private static readonly IntPtr NativeMethodInfoPtr_set_HotbarEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002E25 RID: 11813
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippingEnabled_Public_get_Boolean_0;

		// Token: 0x04002E26 RID: 11814
		private static readonly IntPtr NativeMethodInfoPtr_set_EquippingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04002E27 RID: 11815
		private static readonly IntPtr NativeMethodInfoPtr_get_HolsterEnabled_Public_get_Boolean_0;

		// Token: 0x04002E28 RID: 11816
		private static readonly IntPtr NativeMethodInfoPtr_set_HolsterEnabled_Public_set_Void_Boolean_0;

		// Token: 0x04002E29 RID: 11817
		private static readonly IntPtr NativeMethodInfoPtr_get_Equippable_Public_get_Equippable_0;

		// Token: 0x04002E2A RID: 11818
		private static readonly IntPtr NativeMethodInfoPtr_set_Equippable_Protected_set_Void_Equippable_0;

		// Token: 0x04002E2B RID: 11819
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentEquipTime_Public_get_Single_0;

		// Token: 0x04002E2C RID: 11820
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentEquipTime_Private_set_Void_Single_0;

		// Token: 0x04002E2D RID: 11821
		private static readonly IntPtr NativeMethodInfoPtr_get_AttachedScreen_Public_get_UIScreen_0;

		// Token: 0x04002E2E RID: 11822
		private static readonly IntPtr NativeMethodInfoPtr_set_AttachedScreen_Private_set_Void_UIScreen_0;

		// Token: 0x04002E2F RID: 11823
		private static readonly IntPtr NativeMethodInfoPtr_get_equippedSlot_Public_get_HotbarSlot_0;

		// Token: 0x04002E30 RID: 11824
		private static readonly IntPtr NativeMethodInfoPtr_get_EquippedItem_Public_get_ItemInstance_0;

		// Token: 0x04002E31 RID: 11825
		private static readonly IntPtr NativeMethodInfoPtr_get_isAnythingEquipped_Public_get_Boolean_0;

		// Token: 0x04002E32 RID: 11826
		private static readonly IntPtr NativeMethodInfoPtr_IndexAllSlots_Public_HotbarSlot_Int32_0;

		// Token: 0x04002E33 RID: 11827
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002E34 RID: 11828
		private static readonly IntPtr NativeMethodInfoPtr_SetupInventoryUI_Private_Void_0;

		// Token: 0x04002E35 RID: 11829
		private static readonly IntPtr NativeMethodInfoPtr_RepositionUI_Private_Void_0;

		// Token: 0x04002E36 RID: 11830
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002E37 RID: 11831
		private static readonly IntPtr NativeMethodInfoPtr_GiveStartupItems_Private_Void_0;

		// Token: 0x04002E38 RID: 11832
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04002E39 RID: 11833
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHotbarSelection_Private_Void_0;

		// Token: 0x04002E3A RID: 11834
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Void_HotbarSlot_0;

		// Token: 0x04002E3B RID: 11835
		private static readonly IntPtr NativeMethodInfoPtr_SetInventoryEnabled_Public_Void_Boolean_0;

		// Token: 0x04002E3C RID: 11836
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippingEnabled_Public_Void_Boolean_0;

		// Token: 0x04002E3D RID: 11837
		private static readonly IntPtr NativeMethodInfoPtr_AttachToScreen_Public_Void_UIScreen_Boolean_0;

		// Token: 0x04002E3E RID: 11838
		private static readonly IntPtr NativeMethodInfoPtr_DetachFromScreen_Public_Void_0;

		// Token: 0x04002E3F RID: 11839
		private static readonly IntPtr NativeMethodInfoPtr_ClipboardAcquiredVarChange_Private_Void_Boolean_0;

		// Token: 0x04002E40 RID: 11840
		private static readonly IntPtr NativeMethodInfoPtr_SetManagementClipboardEnabled_Public_Void_Boolean_0;

		// Token: 0x04002E41 RID: 11841
		private static readonly IntPtr NativeMethodInfoPtr_SetViewmodelVisible_Public_Void_Boolean_0;

		// Token: 0x04002E42 RID: 11842
		private static readonly IntPtr NativeMethodInfoPtr_CanItemFitInInventory_Public_Boolean_ItemInstance_Int32_0;

		// Token: 0x04002E43 RID: 11843
		private static readonly IntPtr NativeMethodInfoPtr_AddItemToInventory_Public_Void_ItemInstance_0;

		// Token: 0x04002E44 RID: 11844
		private static readonly IntPtr NativeMethodInfoPtr_GetAmountOfItem_Public_UInt32_String_0;

		// Token: 0x04002E45 RID: 11845
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAmountOfItem_Public_Void_String_UInt32_0;

		// Token: 0x04002E46 RID: 11846
		private static readonly IntPtr NativeMethodInfoPtr_ClearInventory_Public_Void_0;

		// Token: 0x04002E47 RID: 11847
		private static readonly IntPtr NativeMethodInfoPtr_RemoveProductFromInventory_Public_Void_EStealthLevel_0;

		// Token: 0x04002E48 RID: 11848
		private static readonly IntPtr NativeMethodInfoPtr_RemoveRandomItemsFromInventory_Public_Void_0;

		// Token: 0x04002E49 RID: 11849
		private static readonly IntPtr NativeMethodInfoPtr_SetEquippable_Public_Void_Equippable_0;

		// Token: 0x04002E4A RID: 11850
		private static readonly IntPtr NativeMethodInfoPtr_EquippedSlotChanged_Public_Void_0;

		// Token: 0x04002E4B RID: 11851
		private static readonly IntPtr NativeMethodInfoPtr_Reequip_Public_Void_0;

		// Token: 0x04002E4C RID: 11852
		private static readonly IntPtr NativeMethodInfoPtr_GetAllInventorySlots_Public_List_1_ItemSlot_0;

		// Token: 0x04002E4D RID: 11853
		private static readonly IntPtr NativeMethodInfoPtr_HotbarSlotSelected_Private_Void_HotbarSlot_0;

		// Token: 0x04002E4E RID: 11854
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInventoryVariables_Private_Void_0;

		// Token: 0x04002E4F RID: 11855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E50 RID: 11856
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_0;

		// Token: 0x04002E51 RID: 11857
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_ItemSlotUI_PDM_1;

		// Token: 0x04002E52 RID: 11858
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__78_1_Private_Void_0;

		// Token: 0x02000A55 RID: 2645
		[Serializable]
		public class ItemVariable : Il2CppSystem.Object
		{
			// Token: 0x0600E045 RID: 57413 RVA: 0x00372790 File Offset: 0x00370990
			// Note: this type is marked as 'beforefieldinit'.
			static ItemVariable()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemVariable");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr);
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "Definition");
				PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, "VariableName");
				PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr, 100672103);
			}

			// Token: 0x0600E046 RID: 57414 RVA: 0x003727F8 File Offset: 0x003709F8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemVariable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemVariable>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E047 RID: 57415 RVA: 0x00069ABE File Offset: 0x00067CBE
			public ItemVariable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004447 RID: 17479
			// (get) Token: 0x0600E048 RID: 57416 RVA: 0x00372834 File Offset: 0x00370A34
			// (set) Token: 0x0600E049 RID: 57417 RVA: 0x00069AC7 File Offset: 0x00067CC7
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004448 RID: 17480
			// (get) Token: 0x0600E04A RID: 57418 RVA: 0x00372864 File Offset: 0x00370A64
			// (set) Token: 0x0600E04B RID: 57419 RVA: 0x00069AE6 File Offset: 0x00067CE6
			public unsafe string VariableName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemVariable.NativeFieldInfoPtr_VariableName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040098B3 RID: 39091
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040098B4 RID: 39092
			private static readonly IntPtr NativeFieldInfoPtr_VariableName;

			// Token: 0x040098B5 RID: 39093
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A56 RID: 2646
		[Serializable]
		public class ItemAmount : Il2CppSystem.Object
		{
			// Token: 0x0600E04C RID: 57420 RVA: 0x0037288C File Offset: 0x00370A8C
			// Note: this type is marked as 'beforefieldinit'.
			static ItemAmount()
			{
				Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "ItemAmount");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr);
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Definition");
				PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, "Amount");
				PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr, 100672104);
			}

			// Token: 0x0600E04D RID: 57421 RVA: 0x003728F4 File Offset: 0x00370AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161916, XrefRangeEnd = 161917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemAmount() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.ItemAmount>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.ItemAmount.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E04E RID: 57422 RVA: 0x00069B05 File Offset: 0x00067D05
			public ItemAmount(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004449 RID: 17481
			// (get) Token: 0x0600E04F RID: 57423 RVA: 0x00372930 File Offset: 0x00370B30
			// (set) Token: 0x0600E050 RID: 57424 RVA: 0x00069B0E File Offset: 0x00067D0E
			public unsafe ItemDefinition Definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444A RID: 17482
			// (get) Token: 0x0600E051 RID: 57425 RVA: 0x00372960 File Offset: 0x00370B60
			// (set) Token: 0x0600E052 RID: 57426 RVA: 0x00069B2D File Offset: 0x00067D2D
			public unsafe int Amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.ItemAmount.NativeFieldInfoPtr_Amount)) = value;
				}
			}

			// Token: 0x040098B6 RID: 39094
			private static readonly IntPtr NativeFieldInfoPtr_Definition;

			// Token: 0x040098B7 RID: 39095
			private static readonly IntPtr NativeFieldInfoPtr_Amount;

			// Token: 0x040098B8 RID: 39096
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A57 RID: 2647
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerInventory+<>c__DisplayClass76_0")]
		public sealed class __c__DisplayClass76_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E053 RID: 57427 RVA: 0x00372988 File Offset: 0x00370B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass76_0()
			{
				Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<>c__DisplayClass76_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr);
				PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr, "slot");
				PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr, "<>4__this");
				PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr, 100672105);
				PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__SetupInventoryUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr, 100672106);
				PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__SetupInventoryUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr, 100672107);
			}

			// Token: 0x0600E054 RID: 57428 RVA: 0x00372A18 File Offset: 0x00370C18
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass76_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass76_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E055 RID: 57429 RVA: 0x00372A54 File Offset: 0x00370C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161917, XrefRangeEnd = 161926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupInventoryUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__SetupInventoryUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E056 RID: 57430 RVA: 0x00372A88 File Offset: 0x00370C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161926, XrefRangeEnd = 161935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupInventoryUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass76_0.NativeMethodInfoPtr__SetupInventoryUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E057 RID: 57431 RVA: 0x00069B48 File Offset: 0x00067D48
			public __c__DisplayClass76_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444B RID: 17483
			// (get) Token: 0x0600E058 RID: 57432 RVA: 0x00372ABC File Offset: 0x00370CBC
			// (set) Token: 0x0600E059 RID: 57433 RVA: 0x00069B51 File Offset: 0x00067D51
			public unsafe ItemSlotUI slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444C RID: 17484
			// (get) Token: 0x0600E05A RID: 57434 RVA: 0x00372AEC File Offset: 0x00370CEC
			// (set) Token: 0x0600E05B RID: 57435 RVA: 0x00069B70 File Offset: 0x00067D70
			public unsafe PlayerInventory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInventory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass76_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098B9 RID: 39097
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x040098BA RID: 39098
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098BB RID: 39099
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098BC RID: 39100
			private static readonly IntPtr NativeMethodInfoPtr__SetupInventoryUI_b__0_Internal_Void_0;

			// Token: 0x040098BD RID: 39101
			private static readonly IntPtr NativeMethodInfoPtr__SetupInventoryUI_b__1_Internal_Void_0;
		}

		// Token: 0x02000A58 RID: 2648
		[ObfuscatedName("ScheduleOne.PlayerScripts.PlayerInventory+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E05C RID: 57436 RVA: 0x00372B1C File Offset: 0x00370D1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerInventory>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr);
				PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr, "index");
				PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr, "slot");
				PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr, "<>4__this");
				PlayerInventory.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr, 100672108);
				PlayerInventory.__c__DisplayClass78_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr, 100672109);
			}

			// Token: 0x0600E05D RID: 57437 RVA: 0x00372BAC File Offset: 0x00370DAC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerInventory.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E05E RID: 57438 RVA: 0x00372BE8 File Offset: 0x00370DE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161935, XrefRangeEnd = 161942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerInventory.__c__DisplayClass78_0.NativeMethodInfoPtr__Start_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E05F RID: 57439 RVA: 0x00069B8F File Offset: 0x00067D8F
			public __c__DisplayClass78_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444D RID: 17485
			// (get) Token: 0x0600E060 RID: 57440 RVA: 0x00372C1C File Offset: 0x00370E1C
			// (set) Token: 0x0600E061 RID: 57441 RVA: 0x00069B98 File Offset: 0x00067D98
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x1700444E RID: 17486
			// (get) Token: 0x0600E062 RID: 57442 RVA: 0x00372C44 File Offset: 0x00370E44
			// (set) Token: 0x0600E063 RID: 57443 RVA: 0x00069BB3 File Offset: 0x00067DB3
			public unsafe HotbarSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HotbarSlot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444F RID: 17487
			// (get) Token: 0x0600E064 RID: 57444 RVA: 0x00372C74 File Offset: 0x00370E74
			// (set) Token: 0x0600E065 RID: 57445 RVA: 0x00069BD2 File Offset: 0x00067DD2
			public unsafe PlayerInventory __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInventory>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerInventory.__c__DisplayClass78_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098BE RID: 39102
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x040098BF RID: 39103
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x040098C0 RID: 39104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098C1 RID: 39105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098C2 RID: 39106
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__0_Internal_Void_0;
		}
	}
}
