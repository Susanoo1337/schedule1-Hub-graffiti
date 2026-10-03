using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.UI.Items;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200073F RID: 1855
	public class ItemSlotUI : MonoBehaviour
	{
		// Token: 0x0600B365 RID: 45925 RVA: 0x002EAE90 File Offset: 0x002E9090
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotUI()
		{
			Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "ItemSlotUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr);
			ItemSlotUI.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "normalColor");
			ItemSlotUI.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "highlightColor");
			ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<assignedSlot>k__BackingField");
			ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "IsBeingDragged");
			ItemSlotUI.NativeFieldInfoPtr__playBopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "_playBopAnimation");
			ItemSlotUI.NativeFieldInfoPtr__showItemInfoPanelOnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "_showItemInfoPanelOnHover");
			ItemSlotUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Rect");
			ItemSlotUI.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "Background");
			ItemSlotUI.NativeFieldInfoPtr_LockContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "LockContainer");
			ItemSlotUI.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "ItemContainer");
			ItemSlotUI.NativeFieldInfoPtr_FilterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "FilterButton");
			ItemSlotUI.NativeFieldInfoPtr_BopAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "BopAnimation");
			ItemSlotUI.NativeFieldInfoPtr_CmdQuickMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdQuickMove");
			ItemSlotUI.NativeFieldInfoPtr_CmdQuickMoveSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdQuickMoveSingle");
			ItemSlotUI.NativeFieldInfoPtr_CmdGrabAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdGrabAll");
			ItemSlotUI.NativeFieldInfoPtr_CmdQtyAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdQtyAdd");
			ItemSlotUI.NativeFieldInfoPtr_CmdQtySubtract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdQtySubtract");
			ItemSlotUI.NativeFieldInfoPtr_CmdToggleTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "CmdToggleTooltip");
			ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "<ItemUI>k__BackingField");
			ItemSlotUI.NativeFieldInfoPtr_OnControllerSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "OnControllerSelect");
			ItemSlotUI.NativeFieldInfoPtr_OnControllerDeselect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "OnControllerDeselect");
			ItemSlotUI.NativeFieldInfoPtr__lastQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "_lastQuantity");
			ItemSlotUI.NativeFieldInfoPtr__slotBopQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, "_slotBopQueued");
			ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686836);
			ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686837);
			ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686838);
			ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686839);
			ItemSlotUI.NativeMethodInfoPtr_add_OnControllerSelect_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686840);
			ItemSlotUI.NativeMethodInfoPtr_remove_OnControllerSelect_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686841);
			ItemSlotUI.NativeMethodInfoPtr_add_OnControllerDeselect_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686842);
			ItemSlotUI.NativeMethodInfoPtr_remove_OnControllerDeselect_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686843);
			ItemSlotUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686844);
			ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686845);
			ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686846);
			ItemSlotUI.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686847);
			ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686848);
			ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686849);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686850);
			ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686851);
			ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686852);
			ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686853);
			ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686854);
			ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686855);
			ItemSlotUI.NativeMethodInfoPtr_ShowItemInfoPanelWhenHovered_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686856);
			ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686857);
			ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686858);
			ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686859);
			ItemSlotUI.NativeMethodInfoPtr_AssignControllerCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686860);
			ItemSlotUI.NativeMethodInfoPtr_UnassignControllerCommands_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686861);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdQuickMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686862);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdQuickMoveSingle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686863);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdGrabAll_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686864);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdQtyAdd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686865);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdQtySubtract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686866);
			ItemSlotUI.NativeMethodInfoPtr_WrapCmdToggleTooltip_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686867);
			ItemSlotUI.NativeMethodInfoPtr_ControllerSelect_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686868);
			ItemSlotUI.NativeMethodInfoPtr_OnItemSlotDataChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686869);
			ItemSlotUI.NativeMethodInfoPtr_CheckSlotBop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686870);
			ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr, 100686871);
		}

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600B366 RID: 45926 RVA: 0x002EB35C File Offset: 0x002E955C
		// (set) Token: 0x0600B367 RID: 45927 RVA: 0x002EB39C File Offset: 0x002E959C
		public unsafe ItemSlot assignedSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600B368 RID: 45928 RVA: 0x002EB3E0 File Offset: 0x002E95E0
		// (set) Token: 0x0600B369 RID: 45929 RVA: 0x002EB420 File Offset: 0x002E9620
		public unsafe ItemUI ItemUI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x002EB464 File Offset: 0x002E9664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302710, RefRangeEnd = 302711, XrefRangeStart = 302706, XrefRangeEnd = 302710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnControllerSelect(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_add_OnControllerSelect_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x002EB4A8 File Offset: 0x002E96A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302711, XrefRangeEnd = 302715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnControllerSelect(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_remove_OnControllerSelect_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x002EB4EC File Offset: 0x002E96EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302719, RefRangeEnd = 302720, XrefRangeStart = 302715, XrefRangeEnd = 302719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnControllerDeselect(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_add_OnControllerDeselect_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x002EB530 File Offset: 0x002E9730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302720, XrefRangeEnd = 302724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnControllerDeselect(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_remove_OnControllerDeselect_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x002EB574 File Offset: 0x002E9774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302724, XrefRangeEnd = 302725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x002EB5A8 File Offset: 0x002E97A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302725, XrefRangeEnd = 302795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AssignSlot(ItemSlot s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x002EB5F8 File Offset: 0x002E97F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302795, XrefRangeEnd = 302847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x002EB634 File Offset: 0x002E9834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302847, XrefRangeEnd = 302848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x002EB670 File Offset: 0x002E9870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302848, XrefRangeEnd = 302860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x002EB6A4 File Offset: 0x002E98A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302860, XrefRangeEnd = 302884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemSlotUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x002EB6E0 File Offset: 0x002E98E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302885, RefRangeEnd = 302888, XrefRangeStart = 302884, XrefRangeEnd = 302885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlighted(bool h)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x002EB720 File Offset: 0x002E9920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 302889, RefRangeEnd = 302891, XrefRangeStart = 302888, XrefRangeEnd = 302889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNormalColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x002EB760 File Offset: 0x002E9960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302892, RefRangeEnd = 302893, XrefRangeStart = 302891, XrefRangeEnd = 302892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHighlightColor(Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x002EB7A0 File Offset: 0x002E99A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302893, XrefRangeEnd = 302900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Lock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x002EB7D4 File Offset: 0x002E99D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302900, XrefRangeEnd = 302907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Unlock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_Unlock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x002EB808 File Offset: 0x002E9A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302907, XrefRangeEnd = 302910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLockVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x002EB848 File Offset: 0x002E9A48
		[CallerCount(0)]
		public unsafe bool ShowItemInfoPanelWhenHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_ShowItemInfoPanelWhenHovered_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x002EB884 File Offset: 0x002E9A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 302910, XrefRangeEnd = 302914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x002EB8E4 File Offset: 0x002E9AE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 302918, RefRangeEnd = 302921, XrefRangeStart = 302914, XrefRangeEnd = 302918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x002EB924 File Offset: 0x002E9B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302925, RefRangeEnd = 302926, XrefRangeStart = 302921, XrefRangeEnd = 302925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x002EB964 File Offset: 0x002E9B64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 302982, RefRangeEnd = 302983, XrefRangeStart = 302926, XrefRangeEnd = 302982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignControllerCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_AssignControllerCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x002EB998 File Offset: 0x002E9B98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303039, RefRangeEnd = 303040, XrefRangeStart = 302983, XrefRangeEnd = 303039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignControllerCommands()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_UnassignControllerCommands_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x002EB9CC File Offset: 0x002E9BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303040, XrefRangeEnd = 303046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdQuickMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x002EBA00 File Offset: 0x002E9C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303046, XrefRangeEnd = 303052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdQuickMoveSingle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdQuickMoveSingle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x002EBA34 File Offset: 0x002E9C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303052, XrefRangeEnd = 303058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdGrabAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdGrabAll_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x002EBA68 File Offset: 0x002E9C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303058, XrefRangeEnd = 303064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdQtyAdd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdQtyAdd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x002EBA9C File Offset: 0x002E9C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303064, XrefRangeEnd = 303070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdQtySubtract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdQtySubtract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x002EBAD0 File Offset: 0x002E9CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303070, XrefRangeEnd = 303076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WrapCmdToggleTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_WrapCmdToggleTooltip_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x002EBB04 File Offset: 0x002E9D04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 303082, RefRangeEnd = 303084, XrefRangeStart = 303076, XrefRangeEnd = 303082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ControllerSelect(bool isSelected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isSelected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_ControllerSelect_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B387 RID: 45959 RVA: 0x002EBB44 File Offset: 0x002E9D44
		[CallerCount(0)]
		public unsafe void OnItemSlotDataChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_OnItemSlotDataChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x002EBB78 File Offset: 0x002E9D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 303084, XrefRangeEnd = 303085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSlotBop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr_CheckSlotBop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x002EBBAC File Offset: 0x002E9DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x00052C56 File Offset: 0x00050E56
		public ItemSlotUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600B38B RID: 45963 RVA: 0x002EBBE8 File Offset: 0x002E9DE8
		// (set) Token: 0x0600B38C RID: 45964 RVA: 0x00052C5F File Offset: 0x00050E5F
		public unsafe Color32 normalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_normalColor)) = value;
			}
		}

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600B38D RID: 45965 RVA: 0x002EBC10 File Offset: 0x002E9E10
		// (set) Token: 0x0600B38E RID: 45966 RVA: 0x00052C7A File Offset: 0x00050E7A
		public unsafe Color32 highlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_highlightColor)) = value;
			}
		}

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600B38F RID: 45967 RVA: 0x002EBC38 File Offset: 0x002E9E38
		// (set) Token: 0x0600B390 RID: 45968 RVA: 0x00052C95 File Offset: 0x00050E95
		public unsafe ItemSlot _assignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__assignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600B391 RID: 45969 RVA: 0x002EBC68 File Offset: 0x002E9E68
		// (set) Token: 0x0600B392 RID: 45970 RVA: 0x00052CB4 File Offset: 0x00050EB4
		public unsafe bool IsBeingDragged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_IsBeingDragged)) = value;
			}
		}

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600B393 RID: 45971 RVA: 0x002EBC90 File Offset: 0x002E9E90
		// (set) Token: 0x0600B394 RID: 45972 RVA: 0x00052CCF File Offset: 0x00050ECF
		public unsafe bool _playBopAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__playBopAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__playBopAnimation)) = value;
			}
		}

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600B395 RID: 45973 RVA: 0x002EBCB8 File Offset: 0x002E9EB8
		// (set) Token: 0x0600B396 RID: 45974 RVA: 0x00052CEA File Offset: 0x00050EEA
		public unsafe bool _showItemInfoPanelOnHover
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__showItemInfoPanelOnHover);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__showItemInfoPanelOnHover)) = value;
			}
		}

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x002EBCE0 File Offset: 0x002E9EE0
		// (set) Token: 0x0600B398 RID: 45976 RVA: 0x00052D05 File Offset: 0x00050F05
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600B399 RID: 45977 RVA: 0x002EBD10 File Offset: 0x002E9F10
		// (set) Token: 0x0600B39A RID: 45978 RVA: 0x00052D24 File Offset: 0x00050F24
		public unsafe Image Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600B39B RID: 45979 RVA: 0x002EBD40 File Offset: 0x002E9F40
		// (set) Token: 0x0600B39C RID: 45980 RVA: 0x00052D43 File Offset: 0x00050F43
		public unsafe GameObject LockContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_LockContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x002EBD70 File Offset: 0x002E9F70
		// (set) Token: 0x0600B39E RID: 45982 RVA: 0x00052D62 File Offset: 0x00050F62
		public unsafe RectTransform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600B39F RID: 45983 RVA: 0x002EBDA0 File Offset: 0x002E9FA0
		// (set) Token: 0x0600B3A0 RID: 45984 RVA: 0x00052D81 File Offset: 0x00050F81
		public unsafe ItemSlotFilterButton FilterButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_FilterButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotFilterButton>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_FilterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600B3A1 RID: 45985 RVA: 0x002EBDD0 File Offset: 0x002E9FD0
		// (set) Token: 0x0600B3A2 RID: 45986 RVA: 0x00052DA0 File Offset: 0x00050FA0
		public unsafe Animation BopAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_BopAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_BopAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600B3A3 RID: 45987 RVA: 0x002EBE00 File Offset: 0x002EA000
		// (set) Token: 0x0600B3A4 RID: 45988 RVA: 0x00052DBF File Offset: 0x00050FBF
		public unsafe UITrigger CmdQuickMove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQuickMove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQuickMove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600B3A5 RID: 45989 RVA: 0x002EBE30 File Offset: 0x002EA030
		// (set) Token: 0x0600B3A6 RID: 45990 RVA: 0x00052DDE File Offset: 0x00050FDE
		public unsafe UITrigger CmdQuickMoveSingle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQuickMoveSingle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQuickMoveSingle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600B3A7 RID: 45991 RVA: 0x002EBE60 File Offset: 0x002EA060
		// (set) Token: 0x0600B3A8 RID: 45992 RVA: 0x00052DFD File Offset: 0x00050FFD
		public unsafe UITrigger CmdGrabAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdGrabAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdGrabAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600B3A9 RID: 45993 RVA: 0x002EBE90 File Offset: 0x002EA090
		// (set) Token: 0x0600B3AA RID: 45994 RVA: 0x00052E1C File Offset: 0x0005101C
		public unsafe UITrigger CmdQtyAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQtyAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQtyAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600B3AB RID: 45995 RVA: 0x002EBEC0 File Offset: 0x002EA0C0
		// (set) Token: 0x0600B3AC RID: 45996 RVA: 0x00052E3B File Offset: 0x0005103B
		public unsafe UITrigger CmdQtySubtract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQtySubtract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdQtySubtract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600B3AD RID: 45997 RVA: 0x002EBEF0 File Offset: 0x002EA0F0
		// (set) Token: 0x0600B3AE RID: 45998 RVA: 0x00052E5A File Offset: 0x0005105A
		public unsafe UITrigger CmdToggleTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdToggleTooltip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_CmdToggleTooltip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600B3AF RID: 45999 RVA: 0x002EBF20 File Offset: 0x002EA120
		// (set) Token: 0x0600B3B0 RID: 46000 RVA: 0x00052E79 File Offset: 0x00051079
		public unsafe ItemUI _ItemUI_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__ItemUI_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600B3B1 RID: 46001 RVA: 0x002EBF50 File Offset: 0x002EA150
		// (set) Token: 0x0600B3B2 RID: 46002 RVA: 0x00052E98 File Offset: 0x00051098
		public unsafe Action OnControllerSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_OnControllerSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_OnControllerSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600B3B3 RID: 46003 RVA: 0x002EBF80 File Offset: 0x002EA180
		// (set) Token: 0x0600B3B4 RID: 46004 RVA: 0x00052EB7 File Offset: 0x000510B7
		public unsafe Action OnControllerDeselect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_OnControllerDeselect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr_OnControllerDeselect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600B3B5 RID: 46005 RVA: 0x002EBFB0 File Offset: 0x002EA1B0
		// (set) Token: 0x0600B3B6 RID: 46006 RVA: 0x00052ED6 File Offset: 0x000510D6
		public unsafe int _lastQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__lastQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__lastQuantity)) = value;
			}
		}

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600B3B7 RID: 46007 RVA: 0x002EBFD8 File Offset: 0x002EA1D8
		// (set) Token: 0x0600B3B8 RID: 46008 RVA: 0x00052EF1 File Offset: 0x000510F1
		public unsafe bool _slotBopQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__slotBopQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotUI.NativeFieldInfoPtr__slotBopQueued)) = value;
			}
		}

		// Token: 0x04007B76 RID: 31606
		private static readonly IntPtr NativeFieldInfoPtr_normalColor;

		// Token: 0x04007B77 RID: 31607
		private static readonly IntPtr NativeFieldInfoPtr_highlightColor;

		// Token: 0x04007B78 RID: 31608
		private static readonly IntPtr NativeFieldInfoPtr__assignedSlot_k__BackingField;

		// Token: 0x04007B79 RID: 31609
		private static readonly IntPtr NativeFieldInfoPtr_IsBeingDragged;

		// Token: 0x04007B7A RID: 31610
		private static readonly IntPtr NativeFieldInfoPtr__playBopAnimation;

		// Token: 0x04007B7B RID: 31611
		private static readonly IntPtr NativeFieldInfoPtr__showItemInfoPanelOnHover;

		// Token: 0x04007B7C RID: 31612
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007B7D RID: 31613
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x04007B7E RID: 31614
		private static readonly IntPtr NativeFieldInfoPtr_LockContainer;

		// Token: 0x04007B7F RID: 31615
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04007B80 RID: 31616
		private static readonly IntPtr NativeFieldInfoPtr_FilterButton;

		// Token: 0x04007B81 RID: 31617
		private static readonly IntPtr NativeFieldInfoPtr_BopAnimation;

		// Token: 0x04007B82 RID: 31618
		private static readonly IntPtr NativeFieldInfoPtr_CmdQuickMove;

		// Token: 0x04007B83 RID: 31619
		private static readonly IntPtr NativeFieldInfoPtr_CmdQuickMoveSingle;

		// Token: 0x04007B84 RID: 31620
		private static readonly IntPtr NativeFieldInfoPtr_CmdGrabAll;

		// Token: 0x04007B85 RID: 31621
		private static readonly IntPtr NativeFieldInfoPtr_CmdQtyAdd;

		// Token: 0x04007B86 RID: 31622
		private static readonly IntPtr NativeFieldInfoPtr_CmdQtySubtract;

		// Token: 0x04007B87 RID: 31623
		private static readonly IntPtr NativeFieldInfoPtr_CmdToggleTooltip;

		// Token: 0x04007B88 RID: 31624
		private static readonly IntPtr NativeFieldInfoPtr__ItemUI_k__BackingField;

		// Token: 0x04007B89 RID: 31625
		private static readonly IntPtr NativeFieldInfoPtr_OnControllerSelect;

		// Token: 0x04007B8A RID: 31626
		private static readonly IntPtr NativeFieldInfoPtr_OnControllerDeselect;

		// Token: 0x04007B8B RID: 31627
		private static readonly IntPtr NativeFieldInfoPtr__lastQuantity;

		// Token: 0x04007B8C RID: 31628
		private static readonly IntPtr NativeFieldInfoPtr__slotBopQueued;

		// Token: 0x04007B8D RID: 31629
		private static readonly IntPtr NativeMethodInfoPtr_get_assignedSlot_Public_get_ItemSlot_0;

		// Token: 0x04007B8E RID: 31630
		private static readonly IntPtr NativeMethodInfoPtr_set_assignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04007B8F RID: 31631
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemUI_Public_get_ItemUI_0;

		// Token: 0x04007B90 RID: 31632
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemUI_Protected_set_Void_ItemUI_0;

		// Token: 0x04007B91 RID: 31633
		private static readonly IntPtr NativeMethodInfoPtr_add_OnControllerSelect_Public_add_Void_Action_0;

		// Token: 0x04007B92 RID: 31634
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnControllerSelect_Public_rem_Void_Action_0;

		// Token: 0x04007B93 RID: 31635
		private static readonly IntPtr NativeMethodInfoPtr_add_OnControllerDeselect_Public_add_Void_Action_0;

		// Token: 0x04007B94 RID: 31636
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnControllerDeselect_Public_rem_Void_Action_0;

		// Token: 0x04007B95 RID: 31637
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007B96 RID: 31638
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Virtual_New_Void_ItemSlot_0;

		// Token: 0x04007B97 RID: 31639
		private static readonly IntPtr NativeMethodInfoPtr_ClearSlot_Public_Virtual_New_Void_0;

		// Token: 0x04007B98 RID: 31640
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04007B99 RID: 31641
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04007B9A RID: 31642
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04007B9B RID: 31643
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlighted_Public_Void_Boolean_0;

		// Token: 0x04007B9C RID: 31644
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalColor_Public_Void_Color_0;

		// Token: 0x04007B9D RID: 31645
		private static readonly IntPtr NativeMethodInfoPtr_SetHighlightColor_Public_Void_Color_0;

		// Token: 0x04007B9E RID: 31646
		private static readonly IntPtr NativeMethodInfoPtr_Lock_Private_Void_0;

		// Token: 0x04007B9F RID: 31647
		private static readonly IntPtr NativeMethodInfoPtr_Unlock_Private_Void_0;

		// Token: 0x04007BA0 RID: 31648
		private static readonly IntPtr NativeMethodInfoPtr_SetLockVisible_Public_Void_Boolean_0;

		// Token: 0x04007BA1 RID: 31649
		private static readonly IntPtr NativeMethodInfoPtr_ShowItemInfoPanelWhenHovered_Public_Boolean_0;

		// Token: 0x04007BA2 RID: 31650
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_RectTransform_Transform_Int32_0;

		// Token: 0x04007BA3 RID: 31651
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04007BA4 RID: 31652
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDisplayedQuantity_Public_Void_Int32_0;

		// Token: 0x04007BA5 RID: 31653
		private static readonly IntPtr NativeMethodInfoPtr_AssignControllerCommands_Private_Void_0;

		// Token: 0x04007BA6 RID: 31654
		private static readonly IntPtr NativeMethodInfoPtr_UnassignControllerCommands_Private_Void_0;

		// Token: 0x04007BA7 RID: 31655
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdQuickMove_Private_Void_0;

		// Token: 0x04007BA8 RID: 31656
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdQuickMoveSingle_Private_Void_0;

		// Token: 0x04007BA9 RID: 31657
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdGrabAll_Private_Void_0;

		// Token: 0x04007BAA RID: 31658
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdQtyAdd_Private_Void_0;

		// Token: 0x04007BAB RID: 31659
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdQtySubtract_Private_Void_0;

		// Token: 0x04007BAC RID: 31660
		private static readonly IntPtr NativeMethodInfoPtr_WrapCmdToggleTooltip_Private_Void_0;

		// Token: 0x04007BAD RID: 31661
		private static readonly IntPtr NativeMethodInfoPtr_ControllerSelect_Public_Void_Boolean_0;

		// Token: 0x04007BAE RID: 31662
		private static readonly IntPtr NativeMethodInfoPtr_OnItemSlotDataChanged_Private_Void_0;

		// Token: 0x04007BAF RID: 31663
		private static readonly IntPtr NativeMethodInfoPtr_CheckSlotBop_Private_Void_0;

		// Token: 0x04007BB0 RID: 31664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
