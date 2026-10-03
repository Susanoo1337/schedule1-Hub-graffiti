using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A6 RID: 166
	public class UIPanel : MonoBehaviour
	{
		// Token: 0x06000E26 RID: 3622 RVA: 0x000AA5A8 File Offset: 0x000A87A8
		// Note: this type is marked as 'beforefieldinit'.
		static UIPanel()
		{
			Il2CppClassPointerStore<UIPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPanel>.NativeClassPtr);
			UIPanel.NativeFieldInfoPtr_selectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "selectables");
			UIPanel.NativeFieldInfoPtr_defaultSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "defaultSelectable");
			UIPanel.NativeFieldInfoPtr_selectionModeOnEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "selectionModeOnEnter");
			UIPanel.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "scrollRect");
			UIPanel.NativeFieldInfoPtr_scrollMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "scrollMargin");
			UIPanel.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "priority");
			UIPanel.NativeFieldInfoPtr_inputDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "inputDescriptors");
			UIPanel.NativeFieldInfoPtr_selectPanelOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "selectPanelOnStart");
			UIPanel.NativeFieldInfoPtr_selectPanelOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "selectPanelOnEnable");
			UIPanel.NativeFieldInfoPtr_deselectPanelOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "deselectPanelOnDisable");
			UIPanel.NativeFieldInfoPtr_preventSideNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "preventSideNavigation");
			UIPanel.NativeFieldInfoPtr_allowDiagonalNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "allowDiagonalNavigation");
			UIPanel.NativeFieldInfoPtr_useFullRectForNavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "useFullRectForNavigation");
			UIPanel.NativeFieldInfoPtr_fullRectTransformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "fullRectTransformOverride");
			UIPanel.NativeFieldInfoPtr_navigationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "navigationOrigin");
			UIPanel.NativeFieldInfoPtr_customNavigationOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "customNavigationOrigin");
			UIPanel.NativeFieldInfoPtr_panelExitMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "panelExitMode");
			UIPanel.NativeFieldInfoPtr_navigationOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "navigationOverride");
			UIPanel.NativeFieldInfoPtr_OnPanelSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "OnPanelSelected");
			UIPanel.NativeFieldInfoPtr_OnPanelDeselected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "OnPanelDeselected");
			UIPanel.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "_debugMode");
			UIPanel.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "_rectTransform");
			UIPanel.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "<IsSelected>k__BackingField");
			UIPanel.NativeFieldInfoPtr__IsLocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "<IsLocked>k__BackingField");
			UIPanel.NativeFieldInfoPtr__ParentScreen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "<ParentScreen>k__BackingField");
			UIPanel.NativeFieldInfoPtr_currentSelectedSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "currentSelectedSelectable");
			UIPanel.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "currentIndex");
			UIPanel.NativeFieldInfoPtr_navTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "navTimer");
			UIPanel.NativeFieldInfoPtr_wasNavPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "wasNavPressedLastFrame");
			UIPanel.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "scrollSpeed");
			UIPanel.NativeFieldInfoPtr_scrollCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "scrollCoroutine");
			UIPanel.NativeFieldInfoPtr_isDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "isDisabled");
			UIPanel.NativeFieldInfoPtr_isQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "isQuitting");
			UIPanel.NativeFieldInfoPtr_lockInputThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "lockInputThisFrame");
			UIPanel.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "_canvas");
			UIPanel.NativeFieldInfoPtr__lastSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "_lastSelected");
			UIPanel.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665083);
			UIPanel.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665084);
			UIPanel.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665085);
			UIPanel.NativeMethodInfoPtr_set_IsSelected_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665086);
			UIPanel.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665087);
			UIPanel.NativeMethodInfoPtr_set_IsLocked_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665088);
			UIPanel.NativeMethodInfoPtr_get_ParentScreen_Public_get_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665089);
			UIPanel.NativeMethodInfoPtr_set_ParentScreen_Private_set_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665090);
			UIPanel.NativeMethodInfoPtr_get_CurrentSelectedSelectable_Public_get_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665091);
			UIPanel.NativeMethodInfoPtr_set_CurrentSelectedSelectable_Public_set_Void_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665092);
			UIPanel.NativeMethodInfoPtr_get_CurrentSelectableIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665093);
			UIPanel.NativeMethodInfoPtr_get_Selectables_Public_get_IReadOnlyList_1_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665094);
			UIPanel.NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665095);
			UIPanel.NativeMethodInfoPtr_get_IsNavigablePanel_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665096);
			UIPanel.NativeMethodInfoPtr_get_PanelExitMode_Public_get_EPanelExitMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665097);
			UIPanel.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665098);
			UIPanel.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665099);
			UIPanel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665100);
			UIPanel.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665101);
			UIPanel.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665102);
			UIPanel.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665103);
			UIPanel.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665104);
			UIPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665105);
			UIPanel.NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665106);
			UIPanel.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_New_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665107);
			UIPanel.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665108);
			UIPanel.NativeMethodInfoPtr_DetectScreenInputDescriptors_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665109);
			UIPanel.NativeMethodInfoPtr_DetectSelectableInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665110);
			UIPanel.NativeMethodInfoPtr_SendClickEventToCurrentSelectedSelectable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665111);
			UIPanel.NativeMethodInfoPtr_SetParentScreen_Public_Void_UIScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665112);
			UIPanel.NativeMethodInfoPtr_IsPanelVisible_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665113);
			UIPanel.NativeMethodInfoPtr_IsAnySelectablesActive_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665114);
			UIPanel.NativeMethodInfoPtr_GetNearestSelectableToWorldPosition_Public_UISelectable_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665115);
			UIPanel.NativeMethodInfoPtr_GetAValidCurrentSelectedSelectable_Public_UISelectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665116);
			UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_UISelectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665117);
			UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665118);
			UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665119);
			UIPanel.NativeMethodInfoPtr_AddSelectable_Public_Boolean_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665120);
			UIPanel.NativeMethodInfoPtr_RemoveSelectable_Public_Void_UISelectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665121);
			UIPanel.NativeMethodInfoPtr_DeselectSelectable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665122);
			UIPanel.NativeMethodInfoPtr_ClearAllSelectables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665123);
			UIPanel.NativeMethodInfoPtr_GetFallbackSelectable_Private_UISelectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665124);
			UIPanel.NativeMethodInfoPtr_Select_Internal_UISelectable_UISelectable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665125);
			UIPanel.NativeMethodInfoPtr_GetEntrySelectable_Private_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665126);
			UIPanel.NativeMethodInfoPtr_Deselect_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665127);
			UIPanel.NativeMethodInfoPtr_OnReset_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665128);
			UIPanel.NativeMethodInfoPtr_ResetCurrentSelectedSelectable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665129);
			UIPanel.NativeMethodInfoPtr_GetNearestToNavigationOrigin_Private_UISelectable_ENavigationOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665130);
			UIPanel.NativeMethodInfoPtr_ScrollToCurrentSelectedSelectable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665131);
			UIPanel.NativeMethodInfoPtr_ScrollToChild_Protected_Void_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665132);
			UIPanel.NativeMethodInfoPtr_SmoothScrollContent_Private_IEnumerator_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665133);
			UIPanel.NativeMethodInfoPtr_EnableSideNavigation_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665134);
			UIPanel.NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665135);
			UIPanel.NativeMethodInfoPtr_ResetNavigationData_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665136);
			UIPanel.NativeMethodInfoPtr_LockNavigationTemporarily_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665137);
			UIPanel.NativeMethodInfoPtr_NavigateUsingCyclePanel_Protected_Virtual_New_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665138);
			UIPanel.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665139);
			UIPanel.NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665140);
			UIPanel.NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665141);
			UIPanel.NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665142);
			UIPanel.NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665143);
			UIPanel.NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665144);
			UIPanel.NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665145);
			UIPanel.NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665146);
			UIPanel.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, 100665147);
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000AADBC File Offset: 0x000A8FBC
		public unsafe int Priority
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 38121, RefRangeEnd = 38127, XrefRangeStart = 38121, XrefRangeEnd = 38127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_Priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x000AADF8 File Offset: 0x000A8FF8
		public unsafe virtual RectTransform RectTransform
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 81049, RefRangeEnd = 81060, XrefRangeStart = 81041, XrefRangeEnd = 81049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000AAE38 File Offset: 0x000A9038
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x000AAE74 File Offset: 0x000A9074
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_set_IsSelected_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x000AAEB4 File Offset: 0x000A90B4
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x000AAEF0 File Offset: 0x000A90F0
		public unsafe bool IsLocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_set_IsLocked_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x000AAF30 File Offset: 0x000A9130
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x000AAF70 File Offset: 0x000A9170
		public unsafe UIScreen ParentScreen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_ParentScreen_Public_get_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 38417, RefRangeEnd = 38421, XrefRangeStart = 38417, XrefRangeEnd = 38421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_set_ParentScreen_Private_set_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x000AAFB4 File Offset: 0x000A91B4
		// (set) Token: 0x06000E30 RID: 3632 RVA: 0x000AAFF4 File Offset: 0x000A91F4
		public unsafe UISelectable CurrentSelectedSelectable
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 38421, RefRangeEnd = 38424, XrefRangeStart = 38421, XrefRangeEnd = 38424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_CurrentSelectedSelectable_Public_get_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 81081, RefRangeEnd = 81090, XrefRangeStart = 81060, XrefRangeEnd = 81081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_set_CurrentSelectedSelectable_Public_set_Void_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x000AB038 File Offset: 0x000A9238
		public unsafe int CurrentSelectableIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_CurrentSelectableIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x000AB074 File Offset: 0x000A9274
		public unsafe IReadOnlyList<UISelectable> Selectables
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 81094, RefRangeEnd = 81103, XrefRangeStart = 81090, XrefRangeEnd = 81094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_Selectables_Public_get_IReadOnlyList_1_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<UISelectable>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000AB0B4 File Offset: 0x000A92B4
		public unsafe NavigationOverride<UIPanel> NavigationOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NavigationOverride<UIPanel>>(intPtr3) : null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x000AB0F4 File Offset: 0x000A92F4
		public unsafe bool IsNavigablePanel
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 81106, RefRangeEnd = 81108, XrefRangeStart = 81103, XrefRangeEnd = 81106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_IsNavigablePanel_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x000AB130 File Offset: 0x000A9330
		public unsafe UIPanel.EPanelExitMode PanelExitMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_PanelExitMode_Public_get_EPanelExitMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x000AB16C File Offset: 0x000A936C
		public unsafe Canvas Canvas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x000AB1AC File Offset: 0x000A93AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81108, XrefRangeEnd = 81163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000AB1E8 File Offset: 0x000A93E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81208, RefRangeEnd = 81210, XrefRangeStart = 81163, XrefRangeEnd = 81208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x000AB224 File Offset: 0x000A9424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81210, XrefRangeEnd = 81231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x000AB260 File Offset: 0x000A9460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81231, XrefRangeEnd = 81243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000AB29C File Offset: 0x000A949C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81243, XrefRangeEnd = 81249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000AB2D8 File Offset: 0x000A94D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81249, XrefRangeEnd = 81301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000AB314 File Offset: 0x000A9514
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000AB348 File Offset: 0x000A9548
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EarlyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x000AB384 File Offset: 0x000A9584
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_New_Void_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x000AB3D0 File Offset: 0x000A95D0
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DetectInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000AB40C File Offset: 0x000A960C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81315, RefRangeEnd = 81317, XrefRangeStart = 81301, XrefRangeEnd = 81315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectScreenInputDescriptors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_DetectScreenInputDescriptors_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000AB440 File Offset: 0x000A9640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81333, RefRangeEnd = 81334, XrefRangeStart = 81317, XrefRangeEnd = 81333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectSelectableInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_DetectSelectableInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000AB474 File Offset: 0x000A9674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81354, RefRangeEnd = 81356, XrefRangeStart = 81334, XrefRangeEnd = 81354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendClickEventToCurrentSelectedSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SendClickEventToCurrentSelectedSelectable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x000AB4A8 File Offset: 0x000A96A8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 38417, RefRangeEnd = 38421, XrefRangeStart = 38417, XrefRangeEnd = 38421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetParentScreen(UIScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(screen);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SetParentScreen_Public_Void_UIScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000AB4EC File Offset: 0x000A96EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81371, RefRangeEnd = 81374, XrefRangeStart = 81356, XrefRangeEnd = 81371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPanelVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_IsPanelVisible_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000AB528 File Offset: 0x000A9728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81420, RefRangeEnd = 81421, XrefRangeStart = 81374, XrefRangeEnd = 81420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAnySelectablesActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_IsAnySelectablesActive_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000AB564 File Offset: 0x000A9764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81421, XrefRangeEnd = 81438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetNearestSelectableToWorldPosition(Vector3 worldPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetNearestSelectableToWorldPosition_Public_UISelectable_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000AB5B0 File Offset: 0x000A97B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81438, XrefRangeEnd = 81443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetAValidCurrentSelectedSelectable(bool returnFirstFound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnFirstFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetAValidCurrentSelectedSelectable_Public_UISelectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000AB5FC File Offset: 0x000A97FC
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 81466, RefRangeEnd = 81493, XrefRangeStart = 81443, XrefRangeEnd = 81466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectSelectable(UISelectable selectable, bool scrollToSelectable = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_UISelectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000AB64C File Offset: 0x000A984C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 81508, RefRangeEnd = 81513, XrefRangeStart = 81493, XrefRangeEnd = 81508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectSelectable(int index, bool scrollToSelectable = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000AB698 File Offset: 0x000A9898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81526, RefRangeEnd = 81528, XrefRangeStart = 81513, XrefRangeEnd = 81526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectSelectable(bool returnFirstFound, bool scrollToSelectable = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnFirstFound;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToSelectable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SelectSelectable_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000AB6E4 File Offset: 0x000A98E4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 81534, RefRangeEnd = 81558, XrefRangeStart = 81528, XrefRangeEnd = 81534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddSelectable(UISelectable selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_AddSelectable_Public_Boolean_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000AB734 File Offset: 0x000A9934
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 81574, RefRangeEnd = 81581, XrefRangeStart = 81558, XrefRangeEnd = 81574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSelectable(UISelectable selectable, bool autoFallback = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoFallback;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_RemoveSelectable_Public_Void_UISelectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000AB784 File Offset: 0x000A9984
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81582, RefRangeEnd = 81585, XrefRangeStart = 81581, XrefRangeEnd = 81582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_DeselectSelectable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000AB7B8 File Offset: 0x000A99B8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 81598, RefRangeEnd = 81607, XrefRangeStart = 81585, XrefRangeEnd = 81598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAllSelectables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ClearAllSelectables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000AB7EC File Offset: 0x000A99EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 81621, RefRangeEnd = 81625, XrefRangeStart = 81607, XrefRangeEnd = 81621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetFallbackSelectable(bool returnFirstFound = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnFirstFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetFallbackSelectable_Private_UISelectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000AB838 File Offset: 0x000A9A38
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 81688, RefRangeEnd = 81701, XrefRangeStart = 81625, XrefRangeEnd = 81688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable Select(UISelectable overrideSelectable = null, bool scrollToChild = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(overrideSelectable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToChild;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_Select_Internal_UISelectable_UISelectable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000AB898 File Offset: 0x000A9A98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81709, RefRangeEnd = 81711, XrefRangeStart = 81701, XrefRangeEnd = 81709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetEntrySelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetEntrySelectable_Private_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000AB8D8 File Offset: 0x000A9AD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 81724, RefRangeEnd = 81730, XrefRangeStart = 81711, XrefRangeEnd = 81724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_Deselect_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000AB90C File Offset: 0x000A9B0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81762, RefRangeEnd = 81764, XrefRangeStart = 81730, XrefRangeEnd = 81762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_OnReset_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x000AB940 File Offset: 0x000A9B40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81768, RefRangeEnd = 81770, XrefRangeStart = 81764, XrefRangeEnd = 81768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCurrentSelectedSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ResetCurrentSelectedSelectable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x000AB974 File Offset: 0x000A9B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81807, RefRangeEnd = 81809, XrefRangeStart = 81770, XrefRangeEnd = 81807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetNearestToNavigationOrigin(UIPanel.ENavigationOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetNearestToNavigationOrigin_Private_UISelectable_ENavigationOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x000AB9C0 File Offset: 0x000A9BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81817, RefRangeEnd = 81818, XrefRangeStart = 81809, XrefRangeEnd = 81817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollToCurrentSelectedSelectable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ScrollToCurrentSelectedSelectable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000AB9F4 File Offset: 0x000A9BF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 81845, RefRangeEnd = 81851, XrefRangeStart = 81818, XrefRangeEnd = 81845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScrollToChild(RectTransform child, float duration = 0.15f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ScrollToChild_Protected_Void_RectTransform_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000ABA44 File Offset: 0x000A9C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81851, XrefRangeEnd = 81856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SmoothScrollContent(Vector3 targetLocalPosition, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref targetLocalPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SmoothScrollContent_Private_IEnumerator_Vector3_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000ABAA0 File Offset: 0x000A9CA0
		[CallerCount(0)]
		public unsafe void EnableSideNavigation(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_EnableSideNavigation_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x000ABAE0 File Offset: 0x000A9CE0
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Navigate(Vector2 navDir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000ABB34 File Offset: 0x000A9D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81856, XrefRangeEnd = 81858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetNavigationData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ResetNavigationData_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000ABB68 File Offset: 0x000A9D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81858, RefRangeEnd = 81859, XrefRangeStart = 81858, XrefRangeEnd = 81858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LockNavigationTemporarily()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_LockNavigationTemporarily_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x000ABB9C File Offset: 0x000A9D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81859, XrefRangeEnd = 81871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool NavigateUsingCyclePanel(Vector2 dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPanel.NativeMethodInfoPtr_NavigateUsingCyclePanel_Protected_Virtual_New_Boolean_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000ABBF0 File Offset: 0x000A9DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81871, XrefRangeEnd = 81875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform GetRectTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000ABC30 File Offset: 0x000A9E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81884, RefRangeEnd = 81885, XrefRangeStart = 81875, XrefRangeEnd = 81884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasNavigationOverride(ScreenDirection dir, out UIPanel selectable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selectable = ((intPtr4 == 0) ? null : new UIPanel(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000ABC9C File Offset: 0x000A9E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81885, XrefRangeEnd = 81906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasReciprocalNavigationOverride(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x000ABCEC File Offset: 0x000A9EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81906, XrefRangeEnd = 81923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNavigationOverrideReciprocated(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x000ABD30 File Offset: 0x000A9F30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81923, XrefRangeEnd = 81940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearNavigationOverrideReciprocated(string dir)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x000ABD74 File Offset: 0x000A9F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81940, XrefRangeEnd = 81953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDirectionMatch(Vector2 dir, Vector2 screenPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref screenPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000ABDCC File Offset: 0x000A9FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81953, XrefRangeEnd = 81966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual float GetDistance(Vector2 screenPos, Vector2 direction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x000ABE24 File Offset: 0x000AA024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81966, XrefRangeEnd = 81968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetOrigin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x000ABE60 File Offset: 0x000AA060
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 81983, RefRangeEnd = 81986, XrefRangeStart = 81968, XrefRangeEnd = 81983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000087CA File Offset: 0x000069CA
		public UIPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x000ABE9C File Offset: 0x000AA09C
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x000087D3 File Offset: 0x000069D3
		public unsafe List<UISelectable> selectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x000ABECC File Offset: 0x000AA0CC
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x000087F2 File Offset: 0x000069F2
		public unsafe UISelectable defaultSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_defaultSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_defaultSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000ABEFC File Offset: 0x000AA0FC
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00008811 File Offset: 0x00006A11
		public unsafe UIPanel.EPanelSelectionMode selectionModeOnEnter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectionModeOnEnter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectionModeOnEnter)) = value;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x000ABF24 File Offset: 0x000AA124
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x0000882C File Offset: 0x00006A2C
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000ABF54 File Offset: 0x000AA154
		// (set) Token: 0x06000E72 RID: 3698 RVA: 0x0000884B File Offset: 0x00006A4B
		public unsafe Vector2 scrollMargin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollMargin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollMargin)) = value;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x000ABF7C File Offset: 0x000AA17C
		// (set) Token: 0x06000E74 RID: 3700 RVA: 0x00008866 File Offset: 0x00006A66
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000ABFA4 File Offset: 0x000AA1A4
		// (set) Token: 0x06000E76 RID: 3702 RVA: 0x00008881 File Offset: 0x00006A81
		public unsafe List<InputDescriptor> inputDescriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_inputDescriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_inputDescriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000ABFD4 File Offset: 0x000AA1D4
		// (set) Token: 0x06000E78 RID: 3704 RVA: 0x000088A0 File Offset: 0x00006AA0
		public unsafe bool selectPanelOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectPanelOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectPanelOnStart)) = value;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x000ABFFC File Offset: 0x000AA1FC
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x000088BB File Offset: 0x00006ABB
		public unsafe bool selectPanelOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectPanelOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_selectPanelOnEnable)) = value;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x000AC024 File Offset: 0x000AA224
		// (set) Token: 0x06000E7C RID: 3708 RVA: 0x000088D6 File Offset: 0x00006AD6
		public unsafe bool deselectPanelOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_deselectPanelOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_deselectPanelOnDisable)) = value;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000AC04C File Offset: 0x000AA24C
		// (set) Token: 0x06000E7E RID: 3710 RVA: 0x000088F1 File Offset: 0x00006AF1
		public unsafe bool preventSideNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_preventSideNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_preventSideNavigation)) = value;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000AC074 File Offset: 0x000AA274
		// (set) Token: 0x06000E80 RID: 3712 RVA: 0x0000890C File Offset: 0x00006B0C
		public unsafe bool allowDiagonalNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_allowDiagonalNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_allowDiagonalNavigation)) = value;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000AC09C File Offset: 0x000AA29C
		// (set) Token: 0x06000E82 RID: 3714 RVA: 0x00008927 File Offset: 0x00006B27
		public unsafe bool useFullRectForNavigation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_useFullRectForNavigation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_useFullRectForNavigation)) = value;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000AC0C4 File Offset: 0x000AA2C4
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x00008942 File Offset: 0x00006B42
		public unsafe RectTransform fullRectTransformOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_fullRectTransformOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_fullRectTransformOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000AC0F4 File Offset: 0x000AA2F4
		// (set) Token: 0x06000E86 RID: 3718 RVA: 0x00008961 File Offset: 0x00006B61
		public unsafe UIPanel.ENavigationOrigin navigationOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navigationOrigin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navigationOrigin)) = value;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x000AC11C File Offset: 0x000AA31C
		// (set) Token: 0x06000E88 RID: 3720 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe RectTransform customNavigationOrigin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_customNavigationOrigin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_customNavigationOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000AC14C File Offset: 0x000AA34C
		// (set) Token: 0x06000E8A RID: 3722 RVA: 0x0000899B File Offset: 0x00006B9B
		public unsafe UIPanel.EPanelExitMode panelExitMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_panelExitMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_panelExitMode)) = value;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000AC174 File Offset: 0x000AA374
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000089B6 File Offset: 0x00006BB6
		public unsafe NavigationOverride<UIPanel> navigationOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navigationOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationOverride<UIPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navigationOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000AC1A4 File Offset: 0x000AA3A4
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x000089D5 File Offset: 0x00006BD5
		public unsafe UnityEvent OnPanelSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_OnPanelSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_OnPanelSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000AC1D4 File Offset: 0x000AA3D4
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x000089F4 File Offset: 0x00006BF4
		public unsafe UnityEvent OnPanelDeselected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_OnPanelDeselected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_OnPanelDeselected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000AC204 File Offset: 0x000AA404
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x00008A13 File Offset: 0x00006C13
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000AC22C File Offset: 0x000AA42C
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00008A2E File Offset: 0x00006C2E
		public unsafe RectTransform _rectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__rectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000AC25C File Offset: 0x000AA45C
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00008A4D File Offset: 0x00006C4D
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000AC284 File Offset: 0x000AA484
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00008A68 File Offset: 0x00006C68
		public unsafe bool _IsLocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__IsLocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__IsLocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000AC2AC File Offset: 0x000AA4AC
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00008A83 File Offset: 0x00006C83
		public unsafe UIScreen _ParentScreen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__ParentScreen_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__ParentScreen_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000AC2DC File Offset: 0x000AA4DC
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00008AA2 File Offset: 0x00006CA2
		public unsafe UISelectable currentSelectedSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_currentSelectedSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_currentSelectedSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x000AC30C File Offset: 0x000AA50C
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x00008AC1 File Offset: 0x00006CC1
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x000AC334 File Offset: 0x000AA534
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x00008ADC File Offset: 0x00006CDC
		public unsafe float navTimer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navTimer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_navTimer)) = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x000AC35C File Offset: 0x000AA55C
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x00008AF7 File Offset: 0x00006CF7
		public unsafe bool wasNavPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_wasNavPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_wasNavPressedLastFrame)) = value;
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x000AC384 File Offset: 0x000AA584
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00008B12 File Offset: 0x00006D12
		public unsafe float scrollSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollSpeed)) = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x000AC3AC File Offset: 0x000AA5AC
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x00008B2D File Offset: 0x00006D2D
		public unsafe Coroutine scrollCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_scrollCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x00008B4C File Offset: 0x00006D4C
		public unsafe bool isDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_isDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_isDisabled)) = value;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x000AC404 File Offset: 0x000AA604
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x00008B67 File Offset: 0x00006D67
		public unsafe bool isQuitting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_isQuitting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_isQuitting)) = value;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000AC42C File Offset: 0x000AA62C
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x00008B82 File Offset: 0x00006D82
		public unsafe bool lockInputThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_lockInputThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr_lockInputThisFrame)) = value;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x000AC454 File Offset: 0x000AA654
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x00008B9D File Offset: 0x00006D9D
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x000AC484 File Offset: 0x000AA684
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00008BBC File Offset: 0x00006DBC
		public unsafe UISelectable _lastSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__lastSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel.NativeFieldInfoPtr__lastSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009E3 RID: 2531
		private static readonly IntPtr NativeFieldInfoPtr_selectables;

		// Token: 0x040009E4 RID: 2532
		private static readonly IntPtr NativeFieldInfoPtr_defaultSelectable;

		// Token: 0x040009E5 RID: 2533
		private static readonly IntPtr NativeFieldInfoPtr_selectionModeOnEnter;

		// Token: 0x040009E6 RID: 2534
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x040009E7 RID: 2535
		private static readonly IntPtr NativeFieldInfoPtr_scrollMargin;

		// Token: 0x040009E8 RID: 2536
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x040009E9 RID: 2537
		private static readonly IntPtr NativeFieldInfoPtr_inputDescriptors;

		// Token: 0x040009EA RID: 2538
		private static readonly IntPtr NativeFieldInfoPtr_selectPanelOnStart;

		// Token: 0x040009EB RID: 2539
		private static readonly IntPtr NativeFieldInfoPtr_selectPanelOnEnable;

		// Token: 0x040009EC RID: 2540
		private static readonly IntPtr NativeFieldInfoPtr_deselectPanelOnDisable;

		// Token: 0x040009ED RID: 2541
		private static readonly IntPtr NativeFieldInfoPtr_preventSideNavigation;

		// Token: 0x040009EE RID: 2542
		private static readonly IntPtr NativeFieldInfoPtr_allowDiagonalNavigation;

		// Token: 0x040009EF RID: 2543
		private static readonly IntPtr NativeFieldInfoPtr_useFullRectForNavigation;

		// Token: 0x040009F0 RID: 2544
		private static readonly IntPtr NativeFieldInfoPtr_fullRectTransformOverride;

		// Token: 0x040009F1 RID: 2545
		private static readonly IntPtr NativeFieldInfoPtr_navigationOrigin;

		// Token: 0x040009F2 RID: 2546
		private static readonly IntPtr NativeFieldInfoPtr_customNavigationOrigin;

		// Token: 0x040009F3 RID: 2547
		private static readonly IntPtr NativeFieldInfoPtr_panelExitMode;

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeFieldInfoPtr_navigationOverride;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeFieldInfoPtr_OnPanelSelected;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeFieldInfoPtr_OnPanelDeselected;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

		// Token: 0x040009F9 RID: 2553
		private static readonly IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x040009FA RID: 2554
		private static readonly IntPtr NativeFieldInfoPtr__IsLocked_k__BackingField;

		// Token: 0x040009FB RID: 2555
		private static readonly IntPtr NativeFieldInfoPtr__ParentScreen_k__BackingField;

		// Token: 0x040009FC RID: 2556
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectedSelectable;

		// Token: 0x040009FD RID: 2557
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x040009FE RID: 2558
		private static readonly IntPtr NativeFieldInfoPtr_navTimer;

		// Token: 0x040009FF RID: 2559
		private static readonly IntPtr NativeFieldInfoPtr_wasNavPressedLastFrame;

		// Token: 0x04000A00 RID: 2560
		private static readonly IntPtr NativeFieldInfoPtr_scrollSpeed;

		// Token: 0x04000A01 RID: 2561
		private static readonly IntPtr NativeFieldInfoPtr_scrollCoroutine;

		// Token: 0x04000A02 RID: 2562
		private static readonly IntPtr NativeFieldInfoPtr_isDisabled;

		// Token: 0x04000A03 RID: 2563
		private static readonly IntPtr NativeFieldInfoPtr_isQuitting;

		// Token: 0x04000A04 RID: 2564
		private static readonly IntPtr NativeFieldInfoPtr_lockInputThisFrame;

		// Token: 0x04000A05 RID: 2565
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04000A06 RID: 2566
		private static readonly IntPtr NativeFieldInfoPtr__lastSelected;

		// Token: 0x04000A07 RID: 2567
		private static readonly IntPtr NativeMethodInfoPtr_get_Priority_Public_get_Int32_0;

		// Token: 0x04000A08 RID: 2568
		private static readonly IntPtr NativeMethodInfoPtr_get_RectTransform_Public_Virtual_Final_New_get_RectTransform_0;

		// Token: 0x04000A09 RID: 2569
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x04000A0A RID: 2570
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Private_set_Void_Boolean_0;

		// Token: 0x04000A0B RID: 2571
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocked_Public_get_Boolean_0;

		// Token: 0x04000A0C RID: 2572
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocked_Public_set_Void_Boolean_0;

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentScreen_Public_get_UIScreen_0;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentScreen_Private_set_Void_UIScreen_0;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedSelectable_Public_get_UISelectable_0;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedSelectable_Public_set_Void_UISelectable_0;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectableIndex_Public_get_Int32_0;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeMethodInfoPtr_get_Selectables_Public_get_IReadOnlyList_1_UISelectable_0;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeMethodInfoPtr_get_NavigationOverride_Public_get_NavigationOverride_1_UIPanel_0;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNavigablePanel_Public_get_Boolean_0;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelExitMode_Public_get_EPanelExitMode_0;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_EarlyUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_New_Void_InputDeviceType_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_DetectInput_Protected_Virtual_New_Void_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_DetectScreenInputDescriptors_Protected_Void_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_DetectSelectableInput_Private_Void_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_SendClickEventToCurrentSelectedSelectable_Protected_Void_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_SetParentScreen_Public_Void_UIScreen_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_IsPanelVisible_Internal_Boolean_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_IsAnySelectablesActive_Internal_Boolean_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestSelectableToWorldPosition_Public_UISelectable_Vector3_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_GetAValidCurrentSelectedSelectable_Public_UISelectable_Boolean_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_SelectSelectable_Public_Void_UISelectable_Boolean_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_SelectSelectable_Public_Void_Int32_Boolean_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_SelectSelectable_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_AddSelectable_Public_Boolean_UISelectable_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSelectable_Public_Void_UISelectable_Boolean_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_DeselectSelectable_Public_Void_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_ClearAllSelectables_Public_Void_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_GetFallbackSelectable_Private_UISelectable_Boolean_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_Select_Internal_UISelectable_UISelectable_Boolean_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_GetEntrySelectable_Private_UISelectable_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Internal_Void_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_OnReset_Internal_Void_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_ResetCurrentSelectedSelectable_Private_Void_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_GetNearestToNavigationOrigin_Private_UISelectable_ENavigationOrigin_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToCurrentSelectedSelectable_Public_Void_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_ScrollToChild_Protected_Void_RectTransform_Single_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_SmoothScrollContent_Private_IEnumerator_Vector3_Single_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_EnableSideNavigation_Public_Void_Boolean_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Protected_Virtual_New_Boolean_Vector2_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_ResetNavigationData_Public_Void_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_LockNavigationTemporarily_Internal_Void_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr_NavigateUsingCyclePanel_Protected_Virtual_New_Boolean_Vector2_0;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeMethodInfoPtr_GetRectTransform_Public_RectTransform_0;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeMethodInfoPtr_HasNavigationOverride_Public_Boolean_ScreenDirection_byref_UIPanel_0;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeMethodInfoPtr_HasReciprocalNavigationOverride_Public_Boolean_String_0;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeMethodInfoPtr_SetNavigationOverrideReciprocated_Public_Void_String_0;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeMethodInfoPtr_ClearNavigationOverrideReciprocated_Public_Void_String_0;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectionMatch_Public_Virtual_Final_New_Single_Vector2_Vector2_0;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeMethodInfoPtr_GetDistance_Public_Virtual_Final_New_Single_Vector2_Vector2_0;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeMethodInfoPtr_GetOrigin_Public_Virtual_Final_New_Vector3_0;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020008B6 RID: 2230
		[OriginalName("Assembly-CSharp.dll", "", "UINavigationType")]
		public enum UINavigationType
		{
			// Token: 0x0400908F RID: 37007
			ImmediateDirection,
			// Token: 0x04009090 RID: 37008
			NearestDirectionAndDistance
		}

		// Token: 0x020008B7 RID: 2231
		[OriginalName("Assembly-CSharp.dll", "", "EPanelSelectionMode")]
		public enum EPanelSelectionMode
		{
			// Token: 0x04009092 RID: 37010
			KeepLastSelection,
			// Token: 0x04009093 RID: 37011
			NearestToPreviousSelection,
			// Token: 0x04009094 RID: 37012
			NearestToNavigationOrigin
		}

		// Token: 0x020008B8 RID: 2232
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationOrigin")]
		public enum ENavigationOrigin
		{
			// Token: 0x04009096 RID: 37014
			TopLeft,
			// Token: 0x04009097 RID: 37015
			TopRight,
			// Token: 0x04009098 RID: 37016
			BottomLeft,
			// Token: 0x04009099 RID: 37017
			BottomRight,
			// Token: 0x0400909A RID: 37018
			Center,
			// Token: 0x0400909B RID: 37019
			Custom
		}

		// Token: 0x020008B9 RID: 2233
		[OriginalName("Assembly-CSharp.dll", "", "EPanelExitMode")]
		[Serializable]
		public enum EPanelExitMode
		{
			// Token: 0x0400909D RID: 37021
			BestMatch,
			// Token: 0x0400909E RID: 37022
			LastSelected
		}

		// Token: 0x020008BA RID: 2234
		[ObfuscatedName("ScheduleOne.UIPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D44F RID: 54351 RVA: 0x0034E2C8 File Offset: 0x0034C4C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr);
				UIPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, "<>9");
				UIPanel.__c.NativeFieldInfoPtr___9__81_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, "<>9__81_0");
				UIPanel.__c.NativeFieldInfoPtr___9__81_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, "<>9__81_1");
				UIPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, 100665149);
				UIPanel.__c.NativeMethodInfoPtr__IsAnySelectablesActive_b__81_0_Internal_Boolean_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, 100665150);
				UIPanel.__c.NativeMethodInfoPtr__IsAnySelectablesActive_b__81_1_Internal_Boolean_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr, 100665151);
			}

			// Token: 0x0600D450 RID: 54352 RVA: 0x0034E36C File Offset: 0x0034C56C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D451 RID: 54353 RVA: 0x0034E3A8 File Offset: 0x0034C5A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81022, XrefRangeEnd = 81026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsAnySelectablesActive_b__81_0(UISelectable s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.__c.NativeMethodInfoPtr__IsAnySelectablesActive_b__81_0_Internal_Boolean_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D452 RID: 54354 RVA: 0x0034E3F8 File Offset: 0x0034C5F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81026, XrefRangeEnd = 81028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsAnySelectablesActive_b__81_1(UISelectable s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel.__c.NativeMethodInfoPtr__IsAnySelectablesActive_b__81_1_Internal_Boolean_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D453 RID: 54355 RVA: 0x00064678 File Offset: 0x00062878
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0600D454 RID: 54356 RVA: 0x0034E448 File Offset: 0x0034C648
			// (set) Token: 0x0600D455 RID: 54357 RVA: 0x00064681 File Offset: 0x00062881
			public unsafe static UIPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A1 RID: 16545
			// (get) Token: 0x0600D456 RID: 54358 RVA: 0x0034E470 File Offset: 0x0034C670
			// (set) Token: 0x0600D457 RID: 54359 RVA: 0x00064693 File Offset: 0x00062893
			public unsafe static Predicate<UISelectable> __9__81_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIPanel.__c.NativeFieldInfoPtr___9__81_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<UISelectable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIPanel.__c.NativeFieldInfoPtr___9__81_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A2 RID: 16546
			// (get) Token: 0x0600D458 RID: 54360 RVA: 0x0034E498 File Offset: 0x0034C698
			// (set) Token: 0x0600D459 RID: 54361 RVA: 0x000646A5 File Offset: 0x000628A5
			public unsafe static Predicate<UISelectable> __9__81_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UIPanel.__c.NativeFieldInfoPtr___9__81_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<UISelectable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UIPanel.__c.NativeFieldInfoPtr___9__81_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400909F RID: 37023
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040090A0 RID: 37024
			private static readonly IntPtr NativeFieldInfoPtr___9__81_0;

			// Token: 0x040090A1 RID: 37025
			private static readonly IntPtr NativeFieldInfoPtr___9__81_1;

			// Token: 0x040090A2 RID: 37026
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090A3 RID: 37027
			private static readonly IntPtr NativeMethodInfoPtr__IsAnySelectablesActive_b__81_0_Internal_Boolean_UISelectable_0;

			// Token: 0x040090A4 RID: 37028
			private static readonly IntPtr NativeMethodInfoPtr__IsAnySelectablesActive_b__81_1_Internal_Boolean_UISelectable_0;
		}

		// Token: 0x020008BB RID: 2235
		[ObfuscatedName("ScheduleOne.UIPanel+<SmoothScrollContent>d__100")]
		public sealed class _SmoothScrollContent_d__100 : Il2CppSystem.Object
		{
			// Token: 0x0600D45A RID: 54362 RVA: 0x0034E4C0 File Offset: 0x0034C6C0
			// Note: this type is marked as 'beforefieldinit'.
			static _SmoothScrollContent_d__100()
			{
				Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPanel>.NativeClassPtr, "<SmoothScrollContent>d__100");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr);
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<>1__state");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<>2__current");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<>4__this");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "duration");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_targetLocalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "targetLocalPosition");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__content_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<content>5__2");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<startPos>5__3");
				UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__time_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, "<time>5__4");
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665152);
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665153);
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665154);
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665155);
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665156);
				UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr, 100665157);
			}

			// Token: 0x0600D45B RID: 54363 RVA: 0x0034E604 File Offset: 0x0034C804
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SmoothScrollContent_d__100(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPanel._SmoothScrollContent_d__100>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D45C RID: 54364 RVA: 0x0034E64C File Offset: 0x0034C84C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D45D RID: 54365 RVA: 0x0034E680 File Offset: 0x0034C880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81028, XrefRangeEnd = 81036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170040AB RID: 16555
			// (get) Token: 0x0600D45E RID: 54366 RVA: 0x0034E6BC File Offset: 0x0034C8BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D45F RID: 54367 RVA: 0x0034E6FC File Offset: 0x0034C8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81036, XrefRangeEnd = 81041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170040AC RID: 16556
			// (get) Token: 0x0600D460 RID: 54368 RVA: 0x0034E730 File Offset: 0x0034C930
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPanel._SmoothScrollContent_d__100.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D461 RID: 54369 RVA: 0x000646B7 File Offset: 0x000628B7
			public _SmoothScrollContent_d__100(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A3 RID: 16547
			// (get) Token: 0x0600D462 RID: 54370 RVA: 0x0034E770 File Offset: 0x0034C970
			// (set) Token: 0x0600D463 RID: 54371 RVA: 0x000646C0 File Offset: 0x000628C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040A4 RID: 16548
			// (get) Token: 0x0600D464 RID: 54372 RVA: 0x0034E798 File Offset: 0x0034C998
			// (set) Token: 0x0600D465 RID: 54373 RVA: 0x000646DB File Offset: 0x000628DB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A5 RID: 16549
			// (get) Token: 0x0600D466 RID: 54374 RVA: 0x0034E7C8 File Offset: 0x0034C9C8
			// (set) Token: 0x0600D467 RID: 54375 RVA: 0x000646FA File Offset: 0x000628FA
			public unsafe UIPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A6 RID: 16550
			// (get) Token: 0x0600D468 RID: 54376 RVA: 0x0034E7F8 File Offset: 0x0034C9F8
			// (set) Token: 0x0600D469 RID: 54377 RVA: 0x00064719 File Offset: 0x00062919
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170040A7 RID: 16551
			// (get) Token: 0x0600D46A RID: 54378 RVA: 0x0034E820 File Offset: 0x0034CA20
			// (set) Token: 0x0600D46B RID: 54379 RVA: 0x00064734 File Offset: 0x00062934
			public unsafe Vector3 targetLocalPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_targetLocalPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr_targetLocalPosition)) = value;
				}
			}

			// Token: 0x170040A8 RID: 16552
			// (get) Token: 0x0600D46C RID: 54380 RVA: 0x0034E848 File Offset: 0x0034CA48
			// (set) Token: 0x0600D46D RID: 54381 RVA: 0x0006474F File Offset: 0x0006294F
			public unsafe RectTransform _content_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__content_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__content_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A9 RID: 16553
			// (get) Token: 0x0600D46E RID: 54382 RVA: 0x0034E878 File Offset: 0x0034CA78
			// (set) Token: 0x0600D46F RID: 54383 RVA: 0x0006476E File Offset: 0x0006296E
			public unsafe Vector3 _startPos_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__startPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__startPos_5__3)) = value;
				}
			}

			// Token: 0x170040AA RID: 16554
			// (get) Token: 0x0600D470 RID: 54384 RVA: 0x0034E8A0 File Offset: 0x0034CAA0
			// (set) Token: 0x0600D471 RID: 54385 RVA: 0x00064789 File Offset: 0x00062989
			public unsafe float _time_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__time_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPanel._SmoothScrollContent_d__100.NativeFieldInfoPtr__time_5__4)) = value;
				}
			}

			// Token: 0x040090A5 RID: 37029
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090A6 RID: 37030
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090A7 RID: 37031
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090A8 RID: 37032
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x040090A9 RID: 37033
			private static readonly IntPtr NativeFieldInfoPtr_targetLocalPosition;

			// Token: 0x040090AA RID: 37034
			private static readonly IntPtr NativeFieldInfoPtr__content_5__2;

			// Token: 0x040090AB RID: 37035
			private static readonly IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x040090AC RID: 37036
			private static readonly IntPtr NativeFieldInfoPtr__time_5__4;

			// Token: 0x040090AD RID: 37037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090AE RID: 37038
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090AF RID: 37039
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090B0 RID: 37040
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090B1 RID: 37041
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090B2 RID: 37042
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
