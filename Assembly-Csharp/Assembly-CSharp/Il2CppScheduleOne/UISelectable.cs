using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000B2 RID: 178
	public class UISelectable : UITrigger
	{
		// Token: 0x06000FF8 RID: 4088 RVA: 0x000B0830 File Offset: 0x000AEA30
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable()
		{
			Il2CppClassPointerStore<UISelectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UISelectable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable>.NativeClassPtr);
			UISelectable.NativeFieldInfoPtr_inputDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "inputDescriptors");
			UISelectable.NativeFieldInfoPtr_allowTriggerSubmitWithInputDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "allowTriggerSubmitWithInputDescriptors");
			UISelectable.NativeFieldInfoPtr_selectedImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "selectedImage");
			UISelectable.NativeFieldInfoPtr_addToPanelOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "addToPanelOnAwake");
			UISelectable.NativeFieldInfoPtr_findAnotherSelectableInPanelOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "findAnotherSelectableInPanelOnDisable");
			UISelectable.NativeFieldInfoPtr_blockSelectionOnInteractableFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "blockSelectionOnInteractableFalse");
			UISelectable.NativeFieldInfoPtr_disableSideNavigationWhenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "disableSideNavigationWhenSelected");
			UISelectable.NativeFieldInfoPtr_useFullRectForNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "useFullRectForNavigation");
			UISelectable.NativeFieldInfoPtr_navigationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "navigationOverride");
			UISelectable.NativeFieldInfoPtr_fullRectTransformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "fullRectTransformOverride");
			UISelectable.NativeFieldInfoPtr_navigationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "navigationOrigin");
			UISelectable.NativeFieldInfoPtr_customNavigationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "customNavigationOrigin");
			UISelectable.NativeFieldInfoPtr__label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_label");
			UISelectable.NativeFieldInfoPtr__inputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_inputPrompt");
			UISelectable.NativeFieldInfoPtr__embeddedInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_embeddedInputPrompt");
			UISelectable.NativeFieldInfoPtr__RectTransform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "<RectTransform>k__BackingField");
			UISelectable.NativeFieldInfoPtr__ParentPanel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "<ParentPanel>k__BackingField");
			UISelectable.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "OnSelected");
			UISelectable.NativeFieldInfoPtr_OnDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "OnDeselected");
			UISelectable.NativeFieldInfoPtr__isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_isSelected");
			UISelectable.NativeFieldInfoPtr__ignoreWhenNevigating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_ignoreWhenNevigating");
			UISelectable.NativeFieldInfoPtr__isPromptActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "_isPromptActive");
			UISelectable.NativeFieldInfoPtr_INTERSECTION_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, "INTERSECTION_OFFSET");
			UISelectable.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665327);
			UISelectable.NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665328);
			UISelectable.NativeMethodInfoPtr_get_ParentPanel_Public_get_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665329);
			UISelectable.NativeMethodInfoPtr_set_ParentPanel_Private_set_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665330);
			UISelectable.NativeMethodInfoPtr_get_Label_Public_get_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665331);
			UISelectable.NativeMethodInfoPtr_get_DisableSideNavigationWhenSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665332);
			UISelectable.NativeMethodInfoPtr_set_DisableSideNavigationWhenSelected_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665333);
			UISelectable.NativeMethodInfoPtr_get_UseFullRectForNavigation_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665334);
			UISelectable.NativeMethodInfoPtr_set_UseFullRectForNavigation_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665335);
			UISelectable.NativeMethodInfoPtr_get_IgnoreWhenNavigating_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665336);
			UISelectable.NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665337);
			UISelectable.NativeMethodInfoPtr_get_AllowTriggerSubmitWithInputDescriptors_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665338);
			UISelectable.NativeMethodInfoPtr_get_CanBeSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665339);
			UISelectable.NativeMethodInfoPtr_GetInputDescriptors_Internal_IReadOnlyList_1_InputDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665340);
			UISelectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665341);
			UISelectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665342);
			UISelectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665343);
			UISelectable.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665344);
			UISelectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665345);
			UISelectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665346);
			UISelectable.NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665347);
			UISelectable.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665348);
			UISelectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665349);
			UISelectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665350);
			UISelectable.NativeMethodInfoPtr_OnReset_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665351);
			UISelectable.NativeMethodInfoPtr_SetParentPanel_Internal_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665352);
			UISelectable.NativeMethodInfoPtr_IsSelected_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665353);
			UISelectable.NativeMethodInfoPtr_SetSelectedImageVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665354);
			UISelectable.NativeMethodInfoPtr_SetIgnoreWhenNavigating_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665355);
			UISelectable.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665356);
			UISelectable.NativeMethodInfoPtr_CanBeSelectedInternal_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665357);
			UISelectable.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665358);
			UISelectable.NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665359);
			UISelectable.NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665360);
			UISelectable.NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665361);
			UISelectable.NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665362);
			UISelectable.NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665363);
			UISelectable.NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665364);
			UISelectable.NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665365);
			UISelectable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable>.NativeClassPtr, 100665366);
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x000B0D4C File Offset: 0x000AEF4C
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x000B0D8C File Offset: 0x000AEF8C
		public unsafe virtual RectTransform RectTransform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x000B0DD0 File Offset: 0x000AEFD0
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x000B0E10 File Offset: 0x000AF010
		public unsafe UIPanel ParentPanel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_ParentPanel_Public_get_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38427, RefRangeEnd = 38428, XrefRangeStart = 38427, XrefRangeEnd = 38428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_set_ParentPanel_Private_set_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x000B0E54 File Offset: 0x000AF054
		public unsafe Text Label
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_Label_Public_get_Text_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Text>(intPtr3) : null;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x000B0E94 File Offset: 0x000AF094
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x000B0ED0 File Offset: 0x000AF0D0
		public unsafe bool DisableSideNavigationWhenSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_DisableSideNavigationWhenSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_set_DisableSideNavigationWhenSelected_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x000B0F10 File Offset: 0x000AF110
		// (set) Token: 0x06001001 RID: 4097 RVA: 0x000B0F4C File Offset: 0x000AF14C
		public unsafe bool UseFullRectForNavigation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_UseFullRectForNavigation_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_set_UseFullRectForNavigation_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x000B0F8C File Offset: 0x000AF18C
		public unsafe bool IgnoreWhenNavigating
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_IgnoreWhenNavigating_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x000B0FC8 File Offset: 0x000AF1C8
		public unsafe NavigationOverride<UISelectable> NavigationOverride
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 41637, RefRangeEnd = 41647, XrefRangeStart = 41637, XrefRangeEnd = 41647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationOverride<UISelectable>>(intPtr3) : null;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001004 RID: 4100 RVA: 0x000B1008 File Offset: 0x000AF208
		public unsafe bool AllowTriggerSubmitWithInputDescriptors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_AllowTriggerSubmitWithInputDescriptors_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x000B1044 File Offset: 0x000AF244
		public unsafe bool CanBeSelected
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 84429, RefRangeEnd = 84436, XrefRangeStart = 84429, XrefRangeEnd = 84429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_get_CanBeSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x000B1080 File Offset: 0x000AF280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84440, RefRangeEnd = 84441, XrefRangeStart = 84436, XrefRangeEnd = 84440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<InputDescriptor> GetInputDescriptors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_GetInputDescriptors_Internal_IReadOnlyList_1_InputDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<InputDescriptor>>(intPtr3) : null;
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000B10C0 File Offset: 0x000AF2C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 84515, RefRangeEnd = 84518, XrefRangeStart = 84441, XrefRangeEnd = 84515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000B10FC File Offset: 0x000AF2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84518, XrefRangeEnd = 84521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x000B1138 File Offset: 0x000AF338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84521, XrefRangeEnd = 84527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x000B1174 File Offset: 0x000AF374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84527, XrefRangeEnd = 84532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x000B11A8 File Offset: 0x000AF3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84532, XrefRangeEnd = 84548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPointerEnter(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000B11F8 File Offset: 0x000AF3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84548, XrefRangeEnd = 84565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerExit(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x000B1248 File Offset: 0x000AF448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84565, XrefRangeEnd = 84569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DeselectOnPointerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000B1290 File Offset: 0x000AF490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84569, XrefRangeEnd = 84589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPointerClick(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000B12E0 File Offset: 0x000AF4E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84617, RefRangeEnd = 84619, XrefRangeStart = 84589, XrefRangeEnd = 84617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000B1330 File Offset: 0x000AF530
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84643, RefRangeEnd = 84644, XrefRangeStart = 84619, XrefRangeEnd = 84643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000B1380 File Offset: 0x000AF580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84644, XrefRangeEnd = 84662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_OnReset_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000B13BC File Offset: 0x000AF5BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38427, RefRangeEnd = 38428, XrefRangeStart = 38427, XrefRangeEnd = 38428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentPanel(UIPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_SetParentPanel_Internal_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000B1400 File Offset: 0x000AF600
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 84672, RefRangeEnd = 84677, XrefRangeStart = 84662, XrefRangeEnd = 84672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_IsSelected_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000B143C File Offset: 0x000AF63C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 84682, RefRangeEnd = 84688, XrefRangeStart = 84677, XrefRangeEnd = 84682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedImageVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_SetSelectedImageVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x000B147C File Offset: 0x000AF67C
		[CallerCount(0)]
		public unsafe void SetIgnoreWhenNavigating(bool isIgnored)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isIgnored;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_SetIgnoreWhenNavigating_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000B14BC File Offset: 0x000AF6BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84688, XrefRangeEnd = 84692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform GetRectTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000B14FC File Offset: 0x000AF6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84692, XrefRangeEnd = 84703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeSelectedInternal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_CanBeSelectedInternal_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000B1544 File Offset: 0x000AF744
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeSelectedWhileDraggingItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000B158C File Offset: 0x000AF78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84703, XrefRangeEnd = 84704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNavigationOverride(ScreenDirection dir, out UISelectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selectable = ((intPtr4 == 0) ? null : new UISelectable(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000B15F8 File Offset: 0x000AF7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84704, XrefRangeEnd = 84725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasReciprocalNavigationOverride(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000B1648 File Offset: 0x000AF848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84725, XrefRangeEnd = 84742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNavigationOverrideReciprocated(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000B168C File Offset: 0x000AF88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84742, XrefRangeEnd = 84759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearNavigationOverrideReciprocated(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000B16D0 File Offset: 0x000AF8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84759, XrefRangeEnd = 84763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDirectionMatch(Vector2 dir, Vector2 screenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000B1728 File Offset: 0x000AF928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84763, XrefRangeEnd = 84769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDistance(Vector2 screenPos, Vector2 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x000B1780 File Offset: 0x000AF980
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 84787, RefRangeEnd = 84789, XrefRangeStart = 84769, XrefRangeEnd = 84787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000B17BC File Offset: 0x000AF9BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 84797, RefRangeEnd = 84801, XrefRangeStart = 84789, XrefRangeEnd = 84797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x00009614 File Offset: 0x00007814
		public UISelectable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x000B17F8 File Offset: 0x000AF9F8
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x0000961D File Offset: 0x0000781D
		public unsafe List<InputDescriptor> inputDescriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_inputDescriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_inputDescriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000B1828 File Offset: 0x000AFA28
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x0000963C File Offset: 0x0000783C
		public unsafe bool allowTriggerSubmitWithInputDescriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_allowTriggerSubmitWithInputDescriptors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_allowTriggerSubmitWithInputDescriptors)) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001026 RID: 4134 RVA: 0x000B1850 File Offset: 0x000AFA50
		// (set) Token: 0x06001027 RID: 4135 RVA: 0x00009657 File Offset: 0x00007857
		public unsafe GameObject selectedImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_selectedImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_selectedImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001028 RID: 4136 RVA: 0x000B1880 File Offset: 0x000AFA80
		// (set) Token: 0x06001029 RID: 4137 RVA: 0x00009676 File Offset: 0x00007876
		public unsafe bool addToPanelOnAwake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_addToPanelOnAwake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_addToPanelOnAwake)) = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600102A RID: 4138 RVA: 0x000B18A8 File Offset: 0x000AFAA8
		// (set) Token: 0x0600102B RID: 4139 RVA: 0x00009691 File Offset: 0x00007891
		public unsafe bool findAnotherSelectableInPanelOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_findAnotherSelectableInPanelOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_findAnotherSelectableInPanelOnDisable)) = value;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600102C RID: 4140 RVA: 0x000B18D0 File Offset: 0x000AFAD0
		// (set) Token: 0x0600102D RID: 4141 RVA: 0x000096AC File Offset: 0x000078AC
		public unsafe bool blockSelectionOnInteractableFalse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_blockSelectionOnInteractableFalse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_blockSelectionOnInteractableFalse)) = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600102E RID: 4142 RVA: 0x000B18F8 File Offset: 0x000AFAF8
		// (set) Token: 0x0600102F RID: 4143 RVA: 0x000096C7 File Offset: 0x000078C7
		public unsafe bool disableSideNavigationWhenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_disableSideNavigationWhenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_disableSideNavigationWhenSelected)) = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x000B1920 File Offset: 0x000AFB20
		// (set) Token: 0x06001031 RID: 4145 RVA: 0x000096E2 File Offset: 0x000078E2
		public unsafe bool useFullRectForNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_useFullRectForNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_useFullRectForNavigation)) = value;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001032 RID: 4146 RVA: 0x000B1948 File Offset: 0x000AFB48
		// (set) Token: 0x06001033 RID: 4147 RVA: 0x000096FD File Offset: 0x000078FD
		public unsafe NavigationOverride<UISelectable> navigationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_navigationOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_navigationOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001034 RID: 4148 RVA: 0x000B1978 File Offset: 0x000AFB78
		// (set) Token: 0x06001035 RID: 4149 RVA: 0x0000971C File Offset: 0x0000791C
		public unsafe RectTransform fullRectTransformOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_fullRectTransformOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_fullRectTransformOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x000B19A8 File Offset: 0x000AFBA8
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x0000973B File Offset: 0x0000793B
		public unsafe UIPanel.ENavigationOrigin navigationOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_navigationOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_navigationOrigin)) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x000B19D0 File Offset: 0x000AFBD0
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x00009756 File Offset: 0x00007956
		public unsafe RectTransform customNavigationOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_customNavigationOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_customNavigationOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x000B1A00 File Offset: 0x000AFC00
		// (set) Token: 0x0600103B RID: 4155 RVA: 0x00009775 File Offset: 0x00007975
		public unsafe Text _label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x000B1A30 File Offset: 0x000AFC30
		// (set) Token: 0x0600103D RID: 4157 RVA: 0x00009794 File Offset: 0x00007994
		public unsafe InputPromptsData _inputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__inputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__inputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600103E RID: 4158 RVA: 0x000B1A60 File Offset: 0x000AFC60
		// (set) Token: 0x0600103F RID: 4159 RVA: 0x000097B3 File Offset: 0x000079B3
		public unsafe EmbeddedInputPromptUI _embeddedInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__embeddedInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedInputPromptUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__embeddedInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x000B1A90 File Offset: 0x000AFC90
		// (set) Token: 0x06001041 RID: 4161 RVA: 0x000097D2 File Offset: 0x000079D2
		public unsafe RectTransform _RectTransform_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__RectTransform_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__RectTransform_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x000B1AC0 File Offset: 0x000AFCC0
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x000097F1 File Offset: 0x000079F1
		public unsafe UIPanel _ParentPanel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__ParentPanel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__ParentPanel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000B1AF0 File Offset: 0x000AFCF0
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00009810 File Offset: 0x00007A10
		public unsafe UnityEvent OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x000B1B20 File Offset: 0x000AFD20
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x0000982F File Offset: 0x00007A2F
		public unsafe UnityEvent OnDeselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_OnDeselected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr_OnDeselected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000B1B50 File Offset: 0x000AFD50
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x0000984E File Offset: 0x00007A4E
		public unsafe bool _isSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__isSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__isSelected)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x000B1B78 File Offset: 0x000AFD78
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x00009869 File Offset: 0x00007A69
		public unsafe bool _ignoreWhenNevigating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__ignoreWhenNevigating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__ignoreWhenNevigating)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x000B1BA0 File Offset: 0x000AFDA0
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00009884 File Offset: 0x00007A84
		public unsafe bool _isPromptActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__isPromptActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable.NativeFieldInfoPtr__isPromptActive)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x000B1BC8 File Offset: 0x000AFDC8
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x0000989F File Offset: 0x00007A9F
		public unsafe static float INTERSECTION_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UISelectable.NativeFieldInfoPtr_INTERSECTION_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UISelectable.NativeFieldInfoPtr_INTERSECTION_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeFieldInfoPtr_inputDescriptors;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeFieldInfoPtr_allowTriggerSubmitWithInputDescriptors;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeFieldInfoPtr_selectedImage;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeFieldInfoPtr_addToPanelOnAwake;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_findAnotherSelectableInPanelOnDisable;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_blockSelectionOnInteractableFalse;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeFieldInfoPtr_disableSideNavigationWhenSelected;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeFieldInfoPtr_useFullRectForNavigation;

		// Token: 0x04000B2C RID: 2860
		private static readonly IntPtr NativeFieldInfoPtr_navigationOverride;

		// Token: 0x04000B2D RID: 2861
		private static readonly IntPtr NativeFieldInfoPtr_fullRectTransformOverride;

		// Token: 0x04000B2E RID: 2862
		private static readonly IntPtr NativeFieldInfoPtr_navigationOrigin;

		// Token: 0x04000B2F RID: 2863
		private static readonly IntPtr NativeFieldInfoPtr_customNavigationOrigin;

		// Token: 0x04000B30 RID: 2864
		private static readonly IntPtr NativeFieldInfoPtr__label;

		// Token: 0x04000B31 RID: 2865
		private static readonly IntPtr NativeFieldInfoPtr__inputPrompt;

		// Token: 0x04000B32 RID: 2866
		private static readonly IntPtr NativeFieldInfoPtr__embeddedInputPrompt;

		// Token: 0x04000B33 RID: 2867
		private static readonly IntPtr NativeFieldInfoPtr__RectTransform_k__BackingField;

		// Token: 0x04000B34 RID: 2868
		private static readonly IntPtr NativeFieldInfoPtr__ParentPanel_k__BackingField;

		// Token: 0x04000B35 RID: 2869
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x04000B36 RID: 2870
		private static readonly IntPtr NativeFieldInfoPtr_OnDeselected;

		// Token: 0x04000B37 RID: 2871
		private static readonly IntPtr NativeFieldInfoPtr__isSelected;

		// Token: 0x04000B38 RID: 2872
		private static readonly IntPtr NativeFieldInfoPtr__ignoreWhenNevigating;

		// Token: 0x04000B39 RID: 2873
		private static readonly IntPtr NativeFieldInfoPtr__isPromptActive;

		// Token: 0x04000B3A RID: 2874
		private static readonly IntPtr NativeFieldInfoPtr_INTERSECTION_OFFSET;

		// Token: 0x04000B3B RID: 2875
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x04000B3C RID: 2876
		private static readonly IntPtr NativeMethodInfoPtr_set_RectTransform_Private_set_Void_RectTransform_0;

		// Token: 0x04000B3D RID: 2877
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentPanel_Public_get_UIPanel_0;

		// Token: 0x04000B3E RID: 2878
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentPanel_Private_set_Void_UIPanel_0;

		// Token: 0x04000B3F RID: 2879
		private static readonly IntPtr NativeMethodInfoPtr_get_Label_Public_get_Text_0;

		// Token: 0x04000B40 RID: 2880
		private static readonly IntPtr NativeMethodInfoPtr_get_DisableSideNavigationWhenSelected_Public_get_Boolean_0;

		// Token: 0x04000B41 RID: 2881
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableSideNavigationWhenSelected_Public_set_Void_Boolean_0;

		// Token: 0x04000B42 RID: 2882
		private static readonly IntPtr NativeMethodInfoPtr_get_UseFullRectForNavigation_Public_get_Boolean_0;

		// Token: 0x04000B43 RID: 2883
		private static readonly IntPtr NativeMethodInfoPtr_set_UseFullRectForNavigation_Public_set_Void_Boolean_0;

		// Token: 0x04000B44 RID: 2884
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreWhenNavigating_Public_get_Boolean_0;

		// Token: 0x04000B45 RID: 2885
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UISelectable_0;

		// Token: 0x04000B46 RID: 2886
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowTriggerSubmitWithInputDescriptors_Public_get_Boolean_0;

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeSelected_Public_get_Boolean_0;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_GetInputDescriptors_Internal_IReadOnlyList_1_InputDescriptor_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_New_Void_PointerEventData_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr_DeselectOnPointerExit_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_New_Void_BaseEventData_0;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Internal_Virtual_Void_0;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeMethodInfoPtr_SetParentPanel_Internal_Void_UIPanel_0;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeMethodInfoPtr_IsSelected_Internal_Boolean_0;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedImageVisible_Private_Void_Boolean_0;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreWhenNavigating_Public_Void_Boolean_0;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelectedInternal_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_New_Boolean_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UISelectable_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
