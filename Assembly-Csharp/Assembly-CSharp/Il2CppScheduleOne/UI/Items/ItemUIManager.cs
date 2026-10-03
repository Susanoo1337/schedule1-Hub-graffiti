using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082C RID: 2092
	public class ItemUIManager : Singleton<ItemUIManager>
	{
		// Token: 0x0600CB29 RID: 52009 RVA: 0x00332D1C File Offset: 0x00330F1C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUIManager()
		{
			Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUIManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr);
			ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_AMOUNTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CASH_DRAG_AMOUNTS");
			ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_THRESHOLDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CASH_DRAG_THRESHOLDS");
			ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<DraggingEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<HoveredSlot>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<QuickMoveEnabled>k__BackingField");
			ItemUIManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "Canvas");
			ItemUIManager.NativeFieldInfoPtr_InfoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "InfoPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemQuantityPrompt");
			ItemUIManager.NativeFieldInfoPtr_CashQuantityPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "CashQuantityPrompt");
			ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "FilterConfigPanel");
			ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "ItemSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "DefaultItemUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "HotbarSlotUIPrefab");
			ItemUIManager.NativeFieldInfoPtr_draggedSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedSlot");
			ItemUIManager.NativeFieldInfoPtr_mouseOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "mouseOffset");
			ItemUIManager.NativeFieldInfoPtr_draggedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedAmount");
			ItemUIManager.NativeFieldInfoPtr_tempIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "tempIcon");
			ItemUIManager.NativeFieldInfoPtr__raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "_raycasters");
			ItemUIManager.NativeFieldInfoPtr_isDraggingCash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "isDraggingCash");
			ItemUIManager.NativeFieldInfoPtr_draggedCashAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "draggedCashAmount");
			ItemUIManager.NativeFieldInfoPtr_PrimarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "PrimarySlots");
			ItemUIManager.NativeFieldInfoPtr_SecondarySlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "SecondarySlots");
			ItemUIManager.NativeFieldInfoPtr_customDragAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "customDragAmount");
			ItemUIManager.NativeFieldInfoPtr_canControllerQuickMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "canControllerQuickMove");
			ItemUIManager.NativeFieldInfoPtr_isInfoPanelToggledOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "isInfoPanelToggledOn");
			ItemUIManager.NativeFieldInfoPtr_controllerQuickMoveSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "controllerQuickMoveSingle");
			ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "quantityChangePopRoutine");
			ItemUIManager.NativeFieldInfoPtr_OnDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "OnDragStart");
			ItemUIManager.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onDragStart");
			ItemUIManager.NativeFieldInfoPtr_onItemMoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "onItemMoved");
			ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689487);
			ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689488);
			ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689489);
			ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689490);
			ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689491);
			ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689492);
			ItemUIManager.NativeMethodInfoPtr_get_IsCurrentlyDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689493);
			ItemUIManager.NativeMethodInfoPtr_get_IsHoveringSlot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689494);
			ItemUIManager.NativeMethodInfoPtr_get_IsDraggingCash_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689495);
			ItemUIManager.NativeMethodInfoPtr_add_OnDragStart_Public_add_Void_Action_1_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689496);
			ItemUIManager.NativeMethodInfoPtr_remove_OnDragStart_Public_rem_Void_Action_1_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689497);
			ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689498);
			ItemUIManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689499);
			ItemUIManager.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689500);
			ItemUIManager.NativeMethodInfoPtr_ControllerHighlightSlot_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689501);
			ItemUIManager.NativeMethodInfoPtr_ControllerStopHighlightSlot_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689502);
			ItemUIManager.NativeMethodInfoPtr_ControllerToggleTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689503);
			ItemUIManager.NativeMethodInfoPtr_ControllerGrabAllSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689504);
			ItemUIManager.NativeMethodInfoPtr_ControllerQuickMoveSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689505);
			ItemUIManager.NativeMethodInfoPtr_ControllerQuickMoveSlotSingle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689506);
			ItemUIManager.NativeMethodInfoPtr_ControllerDragAddQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689507);
			ItemUIManager.NativeMethodInfoPtr_ControllerDragSubtractQuantity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689508);
			ItemUIManager.NativeMethodInfoPtr_ControllerDiscardSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689509);
			ItemUIManager.NativeMethodInfoPtr_TryOpenInfoPanel_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689510);
			ItemUIManager.NativeMethodInfoPtr_TryCloseInfoPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689511);
			ItemUIManager.NativeMethodInfoPtr_UpdateControllerTooltip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689512);
			ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689513);
			ItemUIManager.NativeMethodInfoPtr_AddRaycaster_Public_Void_GraphicRaycaster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689514);
			ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689515);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689516);
			ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689517);
			ItemUIManager.NativeMethodInfoPtr_AddCashAmount_Private_Void_CashInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689518);
			ItemUIManager.NativeMethodInfoPtr_SubtractCashAmount_Private_Void_CashInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689519);
			ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689520);
			ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689521);
			ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689522);
			ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689523);
			ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689524);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689525);
			ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689526);
			ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689527);
			ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689528);
			ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689529);
			ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689530);
			ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689531);
			ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689532);
			ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689533);
			ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, 100689534);
		}

		// Token: 0x17003DD3 RID: 15827
		// (get) Token: 0x0600CB2A RID: 52010 RVA: 0x00333364 File Offset: 0x00331564
		// (set) Token: 0x0600CB2B RID: 52011 RVA: 0x003333A0 File Offset: 0x003315A0
		public unsafe bool DraggingEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003DD4 RID: 15828
		// (get) Token: 0x0600CB2C RID: 52012 RVA: 0x003333E0 File Offset: 0x003315E0
		// (set) Token: 0x0600CB2D RID: 52013 RVA: 0x00333420 File Offset: 0x00331620
		public unsafe ItemSlotUI HoveredSlot
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003DD5 RID: 15829
		// (get) Token: 0x0600CB2E RID: 52014 RVA: 0x00333464 File Offset: 0x00331664
		// (set) Token: 0x0600CB2F RID: 52015 RVA: 0x003334A0 File Offset: 0x003316A0
		public unsafe bool QuickMoveEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003DD6 RID: 15830
		// (get) Token: 0x0600CB30 RID: 52016 RVA: 0x003334E0 File Offset: 0x003316E0
		public unsafe bool IsCurrentlyDragging
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333346, RefRangeEnd = 333347, XrefRangeStart = 333342, XrefRangeEnd = 333346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_IsCurrentlyDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003DD7 RID: 15831
		// (get) Token: 0x0600CB31 RID: 52017 RVA: 0x0033351C File Offset: 0x0033171C
		public unsafe bool IsHoveringSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333351, RefRangeEnd = 333352, XrefRangeStart = 333347, XrefRangeEnd = 333351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_IsHoveringSlot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003DD8 RID: 15832
		// (get) Token: 0x0600CB32 RID: 52018 RVA: 0x00333558 File Offset: 0x00331758
		public unsafe bool IsDraggingCash
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_get_IsDraggingCash_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x00333594 File Offset: 0x00331794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333357, RefRangeEnd = 333358, XrefRangeStart = 333352, XrefRangeEnd = 333357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnDragStart(Action<ItemSlotUI> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_add_OnDragStart_Public_add_Void_Action_1_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x003335D8 File Offset: 0x003317D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333363, RefRangeEnd = 333365, XrefRangeStart = 333358, XrefRangeEnd = 333363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnDragStart(Action<ItemSlotUI> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_remove_OnDragStart_Public_rem_Void_Action_1_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB35 RID: 52021 RVA: 0x0033361C File Offset: 0x0033181C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333365, XrefRangeEnd = 333393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB36 RID: 52022 RVA: 0x00333658 File Offset: 0x00331858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333393, XrefRangeEnd = 333418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB37 RID: 52023 RVA: 0x00333694 File Offset: 0x00331894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333418, XrefRangeEnd = 333426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB38 RID: 52024 RVA: 0x003336D4 File Offset: 0x003318D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333426, XrefRangeEnd = 333433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerHighlightSlot(ItemSlotUI itemSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerHighlightSlot_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB39 RID: 52025 RVA: 0x00333718 File Offset: 0x00331918
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333439, RefRangeEnd = 333440, XrefRangeStart = 333433, XrefRangeEnd = 333439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerStopHighlightSlot(ItemSlotUI itemSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerStopHighlightSlot_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3A RID: 52026 RVA: 0x0033375C File Offset: 0x0033195C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333449, RefRangeEnd = 333450, XrefRangeStart = 333440, XrefRangeEnd = 333449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerToggleTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerToggleTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3B RID: 52027 RVA: 0x00333790 File Offset: 0x00331990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333459, RefRangeEnd = 333460, XrefRangeStart = 333450, XrefRangeEnd = 333459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerGrabAllSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerGrabAllSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3C RID: 52028 RVA: 0x003337C4 File Offset: 0x003319C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333469, RefRangeEnd = 333470, XrefRangeStart = 333460, XrefRangeEnd = 333469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerQuickMoveSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerQuickMoveSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3D RID: 52029 RVA: 0x003337F8 File Offset: 0x003319F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333479, RefRangeEnd = 333480, XrefRangeStart = 333470, XrefRangeEnd = 333479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerQuickMoveSlotSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerQuickMoveSlotSingle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3E RID: 52030 RVA: 0x0033382C File Offset: 0x00331A2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333490, RefRangeEnd = 333491, XrefRangeStart = 333480, XrefRangeEnd = 333490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerDragAddQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerDragAddQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB3F RID: 52031 RVA: 0x00333860 File Offset: 0x00331A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333501, RefRangeEnd = 333502, XrefRangeStart = 333491, XrefRangeEnd = 333501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerDragSubtractQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerDragSubtractQuantity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB40 RID: 52032 RVA: 0x00333894 File Offset: 0x00331A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333502, XrefRangeEnd = 333514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerDiscardSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_ControllerDiscardSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB41 RID: 52033 RVA: 0x003338C8 File Offset: 0x00331AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333514, XrefRangeEnd = 333516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenInfoPanel(ItemSlotUI itemSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_TryOpenInfoPanel_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB42 RID: 52034 RVA: 0x0033390C File Offset: 0x00331B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333516, XrefRangeEnd = 333517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryCloseInfoPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_TryCloseInfoPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x00333940 File Offset: 0x00331B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333517, XrefRangeEnd = 333522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateControllerTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateControllerTooltip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB44 RID: 52036 RVA: 0x00333974 File Offset: 0x00331B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333522, XrefRangeEnd = 333595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x003339B0 File Offset: 0x00331BB0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 333605, RefRangeEnd = 333612, XrefRangeStart = 333595, XrefRangeEnd = 333605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRaycaster(GraphicRaycaster raycaster)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(raycaster);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_AddRaycaster_Public_Void_GraphicRaycaster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x003339F4 File Offset: 0x00331BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333612, XrefRangeEnd = 333638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUIManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB47 RID: 52039 RVA: 0x00333A30 File Offset: 0x00331C30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333662, RefRangeEnd = 333663, XrefRangeStart = 333638, XrefRangeEnd = 333662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragSelectorUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x00333A64 File Offset: 0x00331C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333663, XrefRangeEnd = 333672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashDragAmount(CashInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB49 RID: 52041 RVA: 0x00333AA8 File Offset: 0x00331CA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333682, RefRangeEnd = 333683, XrefRangeStart = 333672, XrefRangeEnd = 333682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCashAmount(CashInstance instance, bool wrapAround = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapAround;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_AddCashAmount_Private_Void_CashInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB4A RID: 52042 RVA: 0x00333AF8 File Offset: 0x00331CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333693, RefRangeEnd = 333694, XrefRangeStart = 333683, XrefRangeEnd = 333693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubtractCashAmount(CashInstance instance, bool wrapAround = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wrapAround;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SubtractCashAmount_Private_Void_CashInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB4B RID: 52043 RVA: 0x00333B48 File Offset: 0x00331D48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333708, RefRangeEnd = 333709, XrefRangeStart = 333694, XrefRangeEnd = 333708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggingEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB4C RID: 52044 RVA: 0x00333B88 File Offset: 0x00331D88
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333732, RefRangeEnd = 333735, XrefRangeStart = 333709, XrefRangeEnd = 333732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableQuickMove(List<ItemSlot> secondarySlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(secondarySlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB4D RID: 52045 RVA: 0x00333BCC File Offset: 0x00331DCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333753, RefRangeEnd = 333755, XrefRangeStart = 333735, XrefRangeEnd = 333753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableQuickMove(List<ItemSlot> primarySlots, List<ItemSlot> secondarySlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(primarySlots);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(secondarySlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB4E RID: 52046 RVA: 0x00333C20 File Offset: 0x00331E20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333784, RefRangeEnd = 333786, XrefRangeStart = 333755, XrefRangeEnd = 333784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetQuickMoveSlots(ItemSlot sourceSlot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceSlot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600CB4F RID: 52047 RVA: 0x00333C70 File Offset: 0x00331E70
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 166322, RefRangeEnd = 166327, XrefRangeStart = 166322, XrefRangeEnd = 166327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_DisableQuickMove_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB50 RID: 52048 RVA: 0x00333CA4 File Offset: 0x00331EA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333841, RefRangeEnd = 333842, XrefRangeStart = 333786, XrefRangeEnd = 333841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI GetHoveredItemSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr3) : null;
		}

		// Token: 0x0600CB51 RID: 52049 RVA: 0x00333CE4 File Offset: 0x00331EE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333885, RefRangeEnd = 333886, XrefRangeStart = 333842, XrefRangeEnd = 333885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemDefinitionInfoHoverable GetHoveredItemInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinitionInfoHoverable>(intPtr3) : null;
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x00333D24 File Offset: 0x00331F24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 333934, RefRangeEnd = 333938, XrefRangeStart = 333886, XrefRangeEnd = 333934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlotClicked(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x00333D68 File Offset: 0x00331F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333938, XrefRangeEnd = 333985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_StartDragCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB54 RID: 52052 RVA: 0x00333D9C File Offset: 0x00331F9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334029, RefRangeEnd = 334034, XrefRangeStart = 333985, XrefRangeEnd = 334029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x00333DD0 File Offset: 0x00331FD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334075, RefRangeEnd = 334078, XrefRangeStart = 334034, XrefRangeEnd = 334075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDraggedAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x00333E10 File Offset: 0x00332010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334149, RefRangeEnd = 334150, XrefRangeStart = 334078, XrefRangeEnd = 334149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCashDrag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_EndCashDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB57 RID: 52055 RVA: 0x00333E44 File Offset: 0x00332044
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334155, RefRangeEnd = 334157, XrefRangeStart = 334150, XrefRangeEnd = 334155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanDragFromSlot(ItemSlotUI slotUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slotUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CB58 RID: 52056 RVA: 0x00333E94 File Offset: 0x00332094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334157, XrefRangeEnd = 334163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCashBeDraggedIntoSlot(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CB59 RID: 52057 RVA: 0x00333EE4 File Offset: 0x003320E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334163, XrefRangeEnd = 334187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUIManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x00060646 File Offset: 0x0005E846
		public ItemUIManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600CB5B RID: 52059 RVA: 0x00333F20 File Offset: 0x00332120
		// (set) Token: 0x0600CB5C RID: 52060 RVA: 0x0006064F File Offset: 0x0005E84F
		public unsafe static Il2CppStructArray<float> CASH_DRAG_AMOUNTS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_AMOUNTS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_AMOUNTS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600CB5D RID: 52061 RVA: 0x00333F48 File Offset: 0x00332148
		// (set) Token: 0x0600CB5E RID: 52062 RVA: 0x00060661 File Offset: 0x0005E861
		public unsafe static Il2CppStructArray<float> CASH_DRAG_THRESHOLDS
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_THRESHOLDS, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemUIManager.NativeFieldInfoPtr_CASH_DRAG_THRESHOLDS, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600CB5F RID: 52063 RVA: 0x00333F70 File Offset: 0x00332170
		// (set) Token: 0x0600CB60 RID: 52064 RVA: 0x00060673 File Offset: 0x0005E873
		public unsafe bool _DraggingEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__DraggingEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600CB61 RID: 52065 RVA: 0x00333F98 File Offset: 0x00332198
		// (set) Token: 0x0600CB62 RID: 52066 RVA: 0x0006068E File Offset: 0x0005E88E
		public unsafe ItemSlotUI _HoveredSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__HoveredSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB9 RID: 15801
		// (get) Token: 0x0600CB63 RID: 52067 RVA: 0x00333FC8 File Offset: 0x003321C8
		// (set) Token: 0x0600CB64 RID: 52068 RVA: 0x000606AD File Offset: 0x0005E8AD
		public unsafe bool _QuickMoveEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17003DBA RID: 15802
		// (get) Token: 0x0600CB65 RID: 52069 RVA: 0x00333FF0 File Offset: 0x003321F0
		// (set) Token: 0x0600CB66 RID: 52070 RVA: 0x000606C8 File Offset: 0x0005E8C8
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DBB RID: 15803
		// (get) Token: 0x0600CB67 RID: 52071 RVA: 0x00334020 File Offset: 0x00332220
		// (set) Token: 0x0600CB68 RID: 52072 RVA: 0x000606E7 File Offset: 0x0005E8E7
		public unsafe ItemInfoPanel InfoPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInfoPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_InfoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DBC RID: 15804
		// (get) Token: 0x0600CB69 RID: 52073 RVA: 0x00334050 File Offset: 0x00332250
		// (set) Token: 0x0600CB6A RID: 52074 RVA: 0x00060706 File Offset: 0x0005E906
		public unsafe RectTransform ItemQuantityPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemQuantityPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DBD RID: 15805
		// (get) Token: 0x0600CB6B RID: 52075 RVA: 0x00334080 File Offset: 0x00332280
		// (set) Token: 0x0600CB6C RID: 52076 RVA: 0x00060725 File Offset: 0x0005E925
		public unsafe RectTransform CashQuantityPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashQuantityPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_CashQuantityPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DBE RID: 15806
		// (get) Token: 0x0600CB6D RID: 52077 RVA: 0x003340B0 File Offset: 0x003322B0
		// (set) Token: 0x0600CB6E RID: 52078 RVA: 0x00060744 File Offset: 0x0005E944
		public unsafe FilterConfigPanel FilterConfigPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_FilterConfigPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DBF RID: 15807
		// (get) Token: 0x0600CB6F RID: 52079 RVA: 0x003340E0 File Offset: 0x003322E0
		// (set) Token: 0x0600CB70 RID: 52080 RVA: 0x00060763 File Offset: 0x0005E963
		public unsafe ItemSlotUI ItemSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_ItemSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC0 RID: 15808
		// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x00334110 File Offset: 0x00332310
		// (set) Token: 0x0600CB72 RID: 52082 RVA: 0x00060782 File Offset: 0x0005E982
		public unsafe ItemUI DefaultItemUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_DefaultItemUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC1 RID: 15809
		// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x00334140 File Offset: 0x00332340
		// (set) Token: 0x0600CB74 RID: 52084 RVA: 0x000607A1 File Offset: 0x0005E9A1
		public unsafe ItemSlotUI HotbarSlotUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_HotbarSlotUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC2 RID: 15810
		// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x00334170 File Offset: 0x00332370
		// (set) Token: 0x0600CB76 RID: 52086 RVA: 0x000607C0 File Offset: 0x0005E9C0
		public unsafe ItemSlotUI draggedSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC3 RID: 15811
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x003341A0 File Offset: 0x003323A0
		// (set) Token: 0x0600CB78 RID: 52088 RVA: 0x000607DF File Offset: 0x0005E9DF
		public unsafe Vector2 mouseOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_mouseOffset)) = value;
			}
		}

		// Token: 0x17003DC4 RID: 15812
		// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x003341C8 File Offset: 0x003323C8
		// (set) Token: 0x0600CB7A RID: 52090 RVA: 0x000607FA File Offset: 0x0005E9FA
		public unsafe int draggedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedAmount)) = value;
			}
		}

		// Token: 0x17003DC5 RID: 15813
		// (get) Token: 0x0600CB7B RID: 52091 RVA: 0x003341F0 File Offset: 0x003323F0
		// (set) Token: 0x0600CB7C RID: 52092 RVA: 0x00060815 File Offset: 0x0005EA15
		public unsafe RectTransform tempIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_tempIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC6 RID: 15814
		// (get) Token: 0x0600CB7D RID: 52093 RVA: 0x00334220 File Offset: 0x00332420
		// (set) Token: 0x0600CB7E RID: 52094 RVA: 0x00060834 File Offset: 0x0005EA34
		public unsafe List<GraphicRaycaster> _raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr__raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DC7 RID: 15815
		// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x00334250 File Offset: 0x00332450
		// (set) Token: 0x0600CB80 RID: 52096 RVA: 0x00060853 File Offset: 0x0005EA53
		public unsafe bool isDraggingCash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isDraggingCash)) = value;
			}
		}

		// Token: 0x17003DC8 RID: 15816
		// (get) Token: 0x0600CB81 RID: 52097 RVA: 0x00334278 File Offset: 0x00332478
		// (set) Token: 0x0600CB82 RID: 52098 RVA: 0x0006086E File Offset: 0x0005EA6E
		public unsafe float draggedCashAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_draggedCashAmount)) = value;
			}
		}

		// Token: 0x17003DC9 RID: 15817
		// (get) Token: 0x0600CB83 RID: 52099 RVA: 0x003342A0 File Offset: 0x003324A0
		// (set) Token: 0x0600CB84 RID: 52100 RVA: 0x00060889 File Offset: 0x0005EA89
		public unsafe List<ItemSlot> PrimarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_PrimarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DCA RID: 15818
		// (get) Token: 0x0600CB85 RID: 52101 RVA: 0x003342D0 File Offset: 0x003324D0
		// (set) Token: 0x0600CB86 RID: 52102 RVA: 0x000608A8 File Offset: 0x0005EAA8
		public unsafe List<ItemSlot> SecondarySlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_SecondarySlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DCB RID: 15819
		// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x00334300 File Offset: 0x00332500
		// (set) Token: 0x0600CB88 RID: 52104 RVA: 0x000608C7 File Offset: 0x0005EAC7
		public unsafe bool customDragAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_customDragAmount)) = value;
			}
		}

		// Token: 0x17003DCC RID: 15820
		// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x00334328 File Offset: 0x00332528
		// (set) Token: 0x0600CB8A RID: 52106 RVA: 0x000608E2 File Offset: 0x0005EAE2
		public unsafe bool canControllerQuickMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_canControllerQuickMove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_canControllerQuickMove)) = value;
			}
		}

		// Token: 0x17003DCD RID: 15821
		// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x00334350 File Offset: 0x00332550
		// (set) Token: 0x0600CB8C RID: 52108 RVA: 0x000608FD File Offset: 0x0005EAFD
		public unsafe bool isInfoPanelToggledOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isInfoPanelToggledOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_isInfoPanelToggledOn)) = value;
			}
		}

		// Token: 0x17003DCE RID: 15822
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x00334378 File Offset: 0x00332578
		// (set) Token: 0x0600CB8E RID: 52110 RVA: 0x00060918 File Offset: 0x0005EB18
		public unsafe bool controllerQuickMoveSingle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_controllerQuickMoveSingle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_controllerQuickMoveSingle)) = value;
			}
		}

		// Token: 0x17003DCF RID: 15823
		// (get) Token: 0x0600CB8F RID: 52111 RVA: 0x003343A0 File Offset: 0x003325A0
		// (set) Token: 0x0600CB90 RID: 52112 RVA: 0x00060933 File Offset: 0x0005EB33
		public unsafe Coroutine quantityChangePopRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_quantityChangePopRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DD0 RID: 15824
		// (get) Token: 0x0600CB91 RID: 52113 RVA: 0x003343D0 File Offset: 0x003325D0
		// (set) Token: 0x0600CB92 RID: 52114 RVA: 0x00060952 File Offset: 0x0005EB52
		public unsafe Action<ItemSlotUI> OnDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_OnDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_OnDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DD1 RID: 15825
		// (get) Token: 0x0600CB93 RID: 52115 RVA: 0x00334400 File Offset: 0x00332600
		// (set) Token: 0x0600CB94 RID: 52116 RVA: 0x00060971 File Offset: 0x0005EB71
		public unsafe UnityEvent onDragStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DD2 RID: 15826
		// (get) Token: 0x0600CB95 RID: 52117 RVA: 0x00334430 File Offset: 0x00332630
		// (set) Token: 0x0600CB96 RID: 52118 RVA: 0x00060990 File Offset: 0x0005EB90
		public unsafe UnityEvent onItemMoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.NativeFieldInfoPtr_onItemMoved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A4C RID: 35404
		private static readonly IntPtr NativeFieldInfoPtr_CASH_DRAG_AMOUNTS;

		// Token: 0x04008A4D RID: 35405
		private static readonly IntPtr NativeFieldInfoPtr_CASH_DRAG_THRESHOLDS;

		// Token: 0x04008A4E RID: 35406
		private static readonly IntPtr NativeFieldInfoPtr__DraggingEnabled_k__BackingField;

		// Token: 0x04008A4F RID: 35407
		private static readonly IntPtr NativeFieldInfoPtr__HoveredSlot_k__BackingField;

		// Token: 0x04008A50 RID: 35408
		private static readonly IntPtr NativeFieldInfoPtr__QuickMoveEnabled_k__BackingField;

		// Token: 0x04008A51 RID: 35409
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04008A52 RID: 35410
		private static readonly IntPtr NativeFieldInfoPtr_InfoPanel;

		// Token: 0x04008A53 RID: 35411
		private static readonly IntPtr NativeFieldInfoPtr_ItemQuantityPrompt;

		// Token: 0x04008A54 RID: 35412
		private static readonly IntPtr NativeFieldInfoPtr_CashQuantityPrompt;

		// Token: 0x04008A55 RID: 35413
		private static readonly IntPtr NativeFieldInfoPtr_FilterConfigPanel;

		// Token: 0x04008A56 RID: 35414
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotUIPrefab;

		// Token: 0x04008A57 RID: 35415
		private static readonly IntPtr NativeFieldInfoPtr_DefaultItemUIPrefab;

		// Token: 0x04008A58 RID: 35416
		private static readonly IntPtr NativeFieldInfoPtr_HotbarSlotUIPrefab;

		// Token: 0x04008A59 RID: 35417
		private static readonly IntPtr NativeFieldInfoPtr_draggedSlot;

		// Token: 0x04008A5A RID: 35418
		private static readonly IntPtr NativeFieldInfoPtr_mouseOffset;

		// Token: 0x04008A5B RID: 35419
		private static readonly IntPtr NativeFieldInfoPtr_draggedAmount;

		// Token: 0x04008A5C RID: 35420
		private static readonly IntPtr NativeFieldInfoPtr_tempIcon;

		// Token: 0x04008A5D RID: 35421
		private static readonly IntPtr NativeFieldInfoPtr__raycasters;

		// Token: 0x04008A5E RID: 35422
		private static readonly IntPtr NativeFieldInfoPtr_isDraggingCash;

		// Token: 0x04008A5F RID: 35423
		private static readonly IntPtr NativeFieldInfoPtr_draggedCashAmount;

		// Token: 0x04008A60 RID: 35424
		private static readonly IntPtr NativeFieldInfoPtr_PrimarySlots;

		// Token: 0x04008A61 RID: 35425
		private static readonly IntPtr NativeFieldInfoPtr_SecondarySlots;

		// Token: 0x04008A62 RID: 35426
		private static readonly IntPtr NativeFieldInfoPtr_customDragAmount;

		// Token: 0x04008A63 RID: 35427
		private static readonly IntPtr NativeFieldInfoPtr_canControllerQuickMove;

		// Token: 0x04008A64 RID: 35428
		private static readonly IntPtr NativeFieldInfoPtr_isInfoPanelToggledOn;

		// Token: 0x04008A65 RID: 35429
		private static readonly IntPtr NativeFieldInfoPtr_controllerQuickMoveSingle;

		// Token: 0x04008A66 RID: 35430
		private static readonly IntPtr NativeFieldInfoPtr_quantityChangePopRoutine;

		// Token: 0x04008A67 RID: 35431
		private static readonly IntPtr NativeFieldInfoPtr_OnDragStart;

		// Token: 0x04008A68 RID: 35432
		private static readonly IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x04008A69 RID: 35433
		private static readonly IntPtr NativeFieldInfoPtr_onItemMoved;

		// Token: 0x04008A6A RID: 35434
		private static readonly IntPtr NativeMethodInfoPtr_get_DraggingEnabled_Public_get_Boolean_0;

		// Token: 0x04008A6B RID: 35435
		private static readonly IntPtr NativeMethodInfoPtr_set_DraggingEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04008A6C RID: 35436
		private static readonly IntPtr NativeMethodInfoPtr_get_HoveredSlot_Public_get_ItemSlotUI_0;

		// Token: 0x04008A6D RID: 35437
		private static readonly IntPtr NativeMethodInfoPtr_set_HoveredSlot_Protected_set_Void_ItemSlotUI_0;

		// Token: 0x04008A6E RID: 35438
		private static readonly IntPtr NativeMethodInfoPtr_get_QuickMoveEnabled_Public_get_Boolean_0;

		// Token: 0x04008A6F RID: 35439
		private static readonly IntPtr NativeMethodInfoPtr_set_QuickMoveEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04008A70 RID: 35440
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyDragging_Public_get_Boolean_0;

		// Token: 0x04008A71 RID: 35441
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHoveringSlot_Public_get_Boolean_0;

		// Token: 0x04008A72 RID: 35442
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDraggingCash_Public_get_Boolean_0;

		// Token: 0x04008A73 RID: 35443
		private static readonly IntPtr NativeMethodInfoPtr_add_OnDragStart_Public_add_Void_Action_1_ItemSlotUI_0;

		// Token: 0x04008A74 RID: 35444
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnDragStart_Public_rem_Void_Action_1_ItemSlotUI_0;

		// Token: 0x04008A75 RID: 35445
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008A76 RID: 35446
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04008A77 RID: 35447
		private static readonly IntPtr NativeMethodInfoPtr_OnInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04008A78 RID: 35448
		private static readonly IntPtr NativeMethodInfoPtr_ControllerHighlightSlot_Public_Void_ItemSlotUI_0;

		// Token: 0x04008A79 RID: 35449
		private static readonly IntPtr NativeMethodInfoPtr_ControllerStopHighlightSlot_Public_Void_ItemSlotUI_0;

		// Token: 0x04008A7A RID: 35450
		private static readonly IntPtr NativeMethodInfoPtr_ControllerToggleTooltip_Public_Void_0;

		// Token: 0x04008A7B RID: 35451
		private static readonly IntPtr NativeMethodInfoPtr_ControllerGrabAllSlot_Public_Void_0;

		// Token: 0x04008A7C RID: 35452
		private static readonly IntPtr NativeMethodInfoPtr_ControllerQuickMoveSlot_Public_Void_0;

		// Token: 0x04008A7D RID: 35453
		private static readonly IntPtr NativeMethodInfoPtr_ControllerQuickMoveSlotSingle_Public_Void_0;

		// Token: 0x04008A7E RID: 35454
		private static readonly IntPtr NativeMethodInfoPtr_ControllerDragAddQuantity_Public_Void_0;

		// Token: 0x04008A7F RID: 35455
		private static readonly IntPtr NativeMethodInfoPtr_ControllerDragSubtractQuantity_Public_Void_0;

		// Token: 0x04008A80 RID: 35456
		private static readonly IntPtr NativeMethodInfoPtr_ControllerDiscardSlot_Public_Void_0;

		// Token: 0x04008A81 RID: 35457
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenInfoPanel_Private_Void_ItemSlotUI_0;

		// Token: 0x04008A82 RID: 35458
		private static readonly IntPtr NativeMethodInfoPtr_TryCloseInfoPanel_Private_Void_0;

		// Token: 0x04008A83 RID: 35459
		private static readonly IntPtr NativeMethodInfoPtr_UpdateControllerTooltip_Private_Void_0;

		// Token: 0x04008A84 RID: 35460
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008A85 RID: 35461
		private static readonly IntPtr NativeMethodInfoPtr_AddRaycaster_Public_Void_GraphicRaycaster_0;

		// Token: 0x04008A86 RID: 35462
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04008A87 RID: 35463
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragSelectorUI_Private_Void_0;

		// Token: 0x04008A88 RID: 35464
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashDragAmount_Private_Void_CashInstance_0;

		// Token: 0x04008A89 RID: 35465
		private static readonly IntPtr NativeMethodInfoPtr_AddCashAmount_Private_Void_CashInstance_Boolean_0;

		// Token: 0x04008A8A RID: 35466
		private static readonly IntPtr NativeMethodInfoPtr_SubtractCashAmount_Private_Void_CashInstance_Boolean_0;

		// Token: 0x04008A8B RID: 35467
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggingEnabled_Public_Void_Boolean_0;

		// Token: 0x04008A8C RID: 35468
		private static readonly IntPtr NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04008A8D RID: 35469
		private static readonly IntPtr NativeMethodInfoPtr_EnableQuickMove_Public_Void_List_1_ItemSlot_List_1_ItemSlot_0;

		// Token: 0x04008A8E RID: 35470
		private static readonly IntPtr NativeMethodInfoPtr_GetQuickMoveSlots_Private_List_1_ItemSlot_ItemSlot_0;

		// Token: 0x04008A8F RID: 35471
		private static readonly IntPtr NativeMethodInfoPtr_DisableQuickMove_Public_Void_0;

		// Token: 0x04008A90 RID: 35472
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemSlot_Private_ItemSlotUI_0;

		// Token: 0x04008A91 RID: 35473
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredItemInfo_Private_ItemDefinitionInfoHoverable_0;

		// Token: 0x04008A92 RID: 35474
		private static readonly IntPtr NativeMethodInfoPtr_SlotClicked_Private_Void_ItemSlotUI_0;

		// Token: 0x04008A93 RID: 35475
		private static readonly IntPtr NativeMethodInfoPtr_StartDragCash_Private_Void_0;

		// Token: 0x04008A94 RID: 35476
		private static readonly IntPtr NativeMethodInfoPtr_EndDrag_Private_Void_0;

		// Token: 0x04008A95 RID: 35477
		private static readonly IntPtr NativeMethodInfoPtr_SetDraggedAmount_Private_Void_Int32_0;

		// Token: 0x04008A96 RID: 35478
		private static readonly IntPtr NativeMethodInfoPtr_EndCashDrag_Private_Void_0;

		// Token: 0x04008A97 RID: 35479
		private static readonly IntPtr NativeMethodInfoPtr_CanDragFromSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04008A98 RID: 35480
		private static readonly IntPtr NativeMethodInfoPtr_CanCashBeDraggedIntoSlot_Public_Boolean_ItemSlotUI_0;

		// Token: 0x04008A99 RID: 35481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D88 RID: 3464
		[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC3B RID: 64571 RVA: 0x003C2B18 File Offset: 0x003C0D18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr);
				ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr_quantityText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr, "quantityText");
				ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				ItemUIManager.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr, 100689536);
				ItemUIManager.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr, 100689537);
			}

			// Token: 0x0600FC3C RID: 64572 RVA: 0x003C2B94 File Offset: 0x003C0D94
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC3D RID: 64573 RVA: 0x003C2BD0 File Offset: 0x003C0DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333337, XrefRangeEnd = 333342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FC3E RID: 64574 RVA: 0x0007768D File Offset: 0x0007588D
			public __c__DisplayClass79_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CA5 RID: 19621
			// (get) Token: 0x0600FC3F RID: 64575 RVA: 0x003C2C10 File Offset: 0x003C0E10
			// (set) Token: 0x0600FC40 RID: 64576 RVA: 0x00077696 File Offset: 0x00075896
			public unsafe TextMeshProUGUI quantityText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr_quantityText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr_quantityText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA6 RID: 19622
			// (get) Token: 0x0600FC41 RID: 64577 RVA: 0x003C2C40 File Offset: 0x003C0E40
			// (set) Token: 0x0600FC42 RID: 64578 RVA: 0x000776B5 File Offset: 0x000758B5
			public unsafe ItemUIManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA17 RID: 43543
			private static readonly IntPtr NativeFieldInfoPtr_quantityText;

			// Token: 0x0400AA18 RID: 43544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA19 RID: 43545
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA1A RID: 43546
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E1D RID: 3613
			[ObfuscatedName("ScheduleOne.UI.Items.ItemUIManager+<>c__DisplayClass79_0+<<SetDraggedAmount>g__LerpQuantityTextSize|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601045C RID: 66652 RVA: 0x003DA824 File Offset: 0x003D8A24
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique()
				{
					Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0>.NativeClassPtr, "<<SetDraggedAmount>g__LerpQuantityTextSize|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>1__state");
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>2__current");
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<>4__this");
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, "<quantityTransform>5__2");
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689538);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689539);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689540);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689541);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689542);
					ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr, 100689543);
				}

				// Token: 0x0601045D RID: 66653 RVA: 0x003DA918 File Offset: 0x003D8B18
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601045E RID: 66654 RVA: 0x003DA960 File Offset: 0x003D8B60
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601045F RID: 66655 RVA: 0x003DA994 File Offset: 0x003D8B94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333315, XrefRangeEnd = 333332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004FA7 RID: 20391
				// (get) Token: 0x06010460 RID: 66656 RVA: 0x003DA9D0 File Offset: 0x003D8BD0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010461 RID: 66657 RVA: 0x003DAA10 File Offset: 0x003D8C10
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333332, XrefRangeEnd = 333337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004FA8 RID: 20392
				// (get) Token: 0x06010462 RID: 66658 RVA: 0x003DAA44 File Offset: 0x003D8C44
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06010463 RID: 66659 RVA: 0x0007B909 File Offset: 0x00079B09
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004FA3 RID: 20387
				// (get) Token: 0x06010464 RID: 66660 RVA: 0x003DAA84 File Offset: 0x003D8C84
				// (set) Token: 0x06010465 RID: 66661 RVA: 0x0007B912 File Offset: 0x00079B12
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004FA4 RID: 20388
				// (get) Token: 0x06010466 RID: 66662 RVA: 0x003DAAAC File Offset: 0x003D8CAC
				// (set) Token: 0x06010467 RID: 66663 RVA: 0x0007B92D File Offset: 0x00079B2D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004FA5 RID: 20389
				// (get) Token: 0x06010468 RID: 66664 RVA: 0x003DAADC File Offset: 0x003D8CDC
				// (set) Token: 0x06010469 RID: 66665 RVA: 0x0007B94C File Offset: 0x00079B4C
				public unsafe ItemUIManager.__c__DisplayClass79_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUIManager.__c__DisplayClass79_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004FA6 RID: 20390
				// (get) Token: 0x0601046A RID: 66666 RVA: 0x003DAB0C File Offset: 0x003D8D0C
				// (set) Token: 0x0601046B RID: 66667 RVA: 0x0007B96B File Offset: 0x00079B6B
				public unsafe RectTransform _quantityTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUIManager.__c__DisplayClass79_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObReObObUnique.NativeFieldInfoPtr__quantityTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF23 RID: 44835
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AF24 RID: 44836
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AF25 RID: 44837
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AF26 RID: 44838
				private static readonly IntPtr NativeFieldInfoPtr__quantityTransform_5__2;

				// Token: 0x0400AF27 RID: 44839
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AF28 RID: 44840
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF29 RID: 44841
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AF2A RID: 44842
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AF2B RID: 44843
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AF2C RID: 44844
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
