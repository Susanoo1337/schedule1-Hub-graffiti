using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000AF RID: 175
	public class UIScreen : MonoBehaviour
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x000AEDFC File Offset: 0x000ACFFC
		// Note: this type is marked as 'beforefieldinit'.
		static UIScreen()
		{
			Il2CppClassPointerStore<UIScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIScreen>.NativeClassPtr);
			UIScreen.NativeFieldInfoPtr_panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "panels");
			UIScreen.NativeFieldInfoPtr_inputDescriptors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "inputDescriptors");
			UIScreen.NativeFieldInfoPtr_activeScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "activeScrollRect");
			UIScreen.NativeFieldInfoPtr_addScreenOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "addScreenOnStart");
			UIScreen.NativeFieldInfoPtr_addScreenOnEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "addScreenOnEnable");
			UIScreen.NativeFieldInfoPtr_removeScreenOnDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "removeScreenOnDisable");
			UIScreen.NativeFieldInfoPtr_autoAttachToInventory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "autoAttachToInventory");
			UIScreen.NativeFieldInfoPtr__debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "_debugMode");
			UIScreen.NativeFieldInfoPtr_currentSelectedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "currentSelectedPanel");
			UIScreen.NativeFieldInfoPtr_isSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "isSelected");
			UIScreen.NativeFieldInfoPtr_wasNavPressedLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "wasNavPressedLastFrame");
			UIScreen.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "_canvas");
			UIScreen.NativeFieldInfoPtr__lastSelectedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "_lastSelectedPanel");
			UIScreen.NativeFieldInfoPtr__onPanelChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "_onPanelChange");
			UIScreen.NativeFieldInfoPtr__screenSelectedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, "_screenSelectedThisFrame");
			UIScreen.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665261);
			UIScreen.NativeMethodInfoPtr_set_IsSelected_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665262);
			UIScreen.NativeMethodInfoPtr_get_CurrentSelectedPanel_Public_get_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665263);
			UIScreen.NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665264);
			UIScreen.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665265);
			UIScreen.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665266);
			UIScreen.NativeMethodInfoPtr_OnAwake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665267);
			UIScreen.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665268);
			UIScreen.NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665269);
			UIScreen.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665270);
			UIScreen.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665271);
			UIScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665272);
			UIScreen.NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665273);
			UIScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665274);
			UIScreen.NativeMethodInfoPtr_InitScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665275);
			UIScreen.NativeMethodInfoPtr_AddPanel_Public_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665276);
			UIScreen.NativeMethodInfoPtr_RemovePanel_Public_Void_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665277);
			UIScreen.NativeMethodInfoPtr_ClearPanels_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665278);
			UIScreen.NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UISelectable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665279);
			UIScreen.NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UIPanel_UISelectable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665280);
			UIScreen.NativeMethodInfoPtr_SetToPreviousSelectedPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665281);
			UIScreen.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665282);
			UIScreen.NativeMethodInfoPtr_DetectInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665283);
			UIScreen.NativeMethodInfoPtr_DetectScreenInputDescriptors_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665284);
			UIScreen.NativeMethodInfoPtr_ForceNavigate_Internal_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665285);
			UIScreen.NativeMethodInfoPtr_Navigate_Private_Boolean_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665286);
			UIScreen.NativeMethodInfoPtr_NavigateToPanel_Private_Boolean_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665287);
			UIScreen.NativeMethodInfoPtr_ChangeActiveScrollRect_Public_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665288);
			UIScreen.NativeMethodInfoPtr_SubscribeToPanelChange_Public_Void_PanelChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665289);
			UIScreen.NativeMethodInfoPtr_UnsubscribeFromPanelChange_Public_Void_PanelChangeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665290);
			UIScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665291);
			UIScreen.NativeMethodInfoPtr__Navigate_b__44_0_Private_Boolean_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIScreen>.NativeClassPtr, 100665292);
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x000AF1D8 File Offset: 0x000AD3D8
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x000AF214 File Offset: 0x000AD414
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 83433, RefRangeEnd = 83440, XrefRangeStart = 83391, XrefRangeEnd = 83433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_set_IsSelected_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x000AF254 File Offset: 0x000AD454
		public unsafe UIPanel CurrentSelectedPanel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30474, RefRangeEnd = 30475, XrefRangeStart = 30474, XrefRangeEnd = 30475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_get_CurrentSelectedPanel_Public_get_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr3) : null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x000AF294 File Offset: 0x000AD494
		public unsafe IReadOnlyList<UIPanel> Panels
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 83444, RefRangeEnd = 83451, XrefRangeStart = 83440, XrefRangeEnd = 83444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<UIPanel>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x000AF2D4 File Offset: 0x000AD4D4
		public unsafe Canvas Canvas
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr3) : null;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000AF314 File Offset: 0x000AD514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83451, XrefRangeEnd = 83495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000AF348 File Offset: 0x000AD548
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreen.NativeMethodInfoPtr_OnAwake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000AF384 File Offset: 0x000AD584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83495, XrefRangeEnd = 83516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000AF3B8 File Offset: 0x000AD5B8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreen.NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000AF3F4 File Offset: 0x000AD5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83516, XrefRangeEnd = 83517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000AF428 File Offset: 0x000AD628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83517, XrefRangeEnd = 83522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000AF45C File Offset: 0x000AD65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83522, XrefRangeEnd = 83527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000AF490 File Offset: 0x000AD690
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreen.NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000AF4CC File Offset: 0x000AD6CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83555, RefRangeEnd = 83556, XrefRangeStart = 83527, XrefRangeEnd = 83555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000AF508 File Offset: 0x000AD708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83577, RefRangeEnd = 83579, XrefRangeStart = 83556, XrefRangeEnd = 83577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_InitScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000AF53C File Offset: 0x000AD73C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 83592, RefRangeEnd = 83600, XrefRangeStart = 83579, XrefRangeEnd = 83592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPanel(UIPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_AddPanel_Public_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000AF580 File Offset: 0x000AD780
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 83620, RefRangeEnd = 83628, XrefRangeStart = 83600, XrefRangeEnd = 83620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePanel(UIPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_RemovePanel_Public_Void_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000AF5C4 File Offset: 0x000AD7C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83628, XrefRangeEnd = 83652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPanels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_ClearPanels_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000AF5F8 File Offset: 0x000AD7F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83683, RefRangeEnd = 83685, XrefRangeStart = 83652, XrefRangeEnd = 83683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentSelectedPanel(UISelectable overrideSelectable = null, bool scrollToChild = true, bool allowReselect = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(overrideSelectable);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToChild;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowReselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UISelectable_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000AF658 File Offset: 0x000AD858
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 83711, RefRangeEnd = 83760, XrefRangeStart = 83685, XrefRangeEnd = 83711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCurrentSelectedPanel(UIPanel panel, UISelectable overrideSelectable = null, bool scrollToChild = true, bool allowReselect = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(overrideSelectable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollToChild;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowReselect;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UIPanel_UISelectable_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000AF6C8 File Offset: 0x000AD8C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83765, RefRangeEnd = 83766, XrefRangeStart = 83760, XrefRangeEnd = 83765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetToPreviousSelectedPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_SetToPreviousSelectedPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000AF6FC File Offset: 0x000AD8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83766, XrefRangeEnd = 83783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollbar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000AF730 File Offset: 0x000AD930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83811, RefRangeEnd = 83812, XrefRangeStart = 83783, XrefRangeEnd = 83811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_DetectInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000AF764 File Offset: 0x000AD964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83827, RefRangeEnd = 83828, XrefRangeStart = 83812, XrefRangeEnd = 83827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetectScreenInputDescriptors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_DetectScreenInputDescriptors_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000AF798 File Offset: 0x000AD998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83829, RefRangeEnd = 83830, XrefRangeStart = 83828, XrefRangeEnd = 83829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ForceNavigate(Vector2 navDir, Vector2 fromPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_ForceNavigate_Internal_Boolean_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000AF7F0 File Offset: 0x000AD9F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 83864, RefRangeEnd = 83866, XrefRangeStart = 83830, XrefRangeEnd = 83864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Navigate(Vector2 navDir, Vector2 fromPosScreen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref navDir;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromPosScreen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_Navigate_Private_Boolean_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000AF848 File Offset: 0x000ADA48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83877, RefRangeEnd = 83878, XrefRangeStart = 83866, XrefRangeEnd = 83877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NavigateToPanel(UIPanel panel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(panel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_NavigateToPanel_Private_Boolean_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000AF898 File Offset: 0x000ADA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeActiveScrollRect(ScrollRect newScrollRect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newScrollRect);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_ChangeActiveScrollRect_Public_Void_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000AF8DC File Offset: 0x000ADADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 83886, RefRangeEnd = 83887, XrefRangeStart = 83878, XrefRangeEnd = 83886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToPanelChange(PanelChangeEvent callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_SubscribeToPanelChange_Public_Void_PanelChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000AF920 File Offset: 0x000ADB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83887, XrefRangeEnd = 83895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromPanelChange(PanelChangeEvent callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr_UnsubscribeFromPanelChange_Public_Void_PanelChangeEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000AF964 File Offset: 0x000ADB64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83910, RefRangeEnd = 83913, XrefRangeStart = 83895, XrefRangeEnd = 83910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000AF9A0 File Offset: 0x000ADBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83913, XrefRangeEnd = 83918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Navigate_b__44_0(UIPanel p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIScreen.NativeMethodInfoPtr__Navigate_b__44_0_Private_Boolean_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00009322 File Offset: 0x00007522
		public UIScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x000AF9F0 File Offset: 0x000ADBF0
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0000932B File Offset: 0x0000752B
		public unsafe List<UIPanel> panels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_panels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_panels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x000AFA20 File Offset: 0x000ADC20
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0000934A File Offset: 0x0000754A
		public unsafe List<InputDescriptor> inputDescriptors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_inputDescriptors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputDescriptor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_inputDescriptors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x000AFA50 File Offset: 0x000ADC50
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00009369 File Offset: 0x00007569
		public unsafe ScrollRect activeScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_activeScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_activeScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x000AFA80 File Offset: 0x000ADC80
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00009388 File Offset: 0x00007588
		public unsafe bool addScreenOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_addScreenOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_addScreenOnStart)) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x000AFAA8 File Offset: 0x000ADCA8
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x000093A3 File Offset: 0x000075A3
		public unsafe bool addScreenOnEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_addScreenOnEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_addScreenOnEnable)) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000AFAD0 File Offset: 0x000ADCD0
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x000093BE File Offset: 0x000075BE
		public unsafe bool removeScreenOnDisable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_removeScreenOnDisable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_removeScreenOnDisable)) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x000AFAF8 File Offset: 0x000ADCF8
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x000093D9 File Offset: 0x000075D9
		public unsafe bool autoAttachToInventory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_autoAttachToInventory);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_autoAttachToInventory)) = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x000AFB20 File Offset: 0x000ADD20
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x000093F4 File Offset: 0x000075F4
		public unsafe bool _debugMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__debugMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__debugMode)) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000AFB48 File Offset: 0x000ADD48
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0000940F File Offset: 0x0000760F
		public unsafe UIPanel currentSelectedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_currentSelectedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_currentSelectedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x000AFB78 File Offset: 0x000ADD78
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x0000942E File Offset: 0x0000762E
		public unsafe bool isSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_isSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_isSelected)) = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x000AFBA0 File Offset: 0x000ADDA0
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00009449 File Offset: 0x00007649
		public unsafe bool wasNavPressedLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_wasNavPressedLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr_wasNavPressedLastFrame)) = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x000AFBC8 File Offset: 0x000ADDC8
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00009464 File Offset: 0x00007664
		public unsafe Canvas _canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x000AFBF8 File Offset: 0x000ADDF8
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00009483 File Offset: 0x00007683
		public unsafe UIPanel _lastSelectedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__lastSelectedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__lastSelectedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x000AFC28 File Offset: 0x000ADE28
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x000094A2 File Offset: 0x000076A2
		public unsafe PanelChangeEvent _onPanelChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__onPanelChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PanelChangeEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__onPanelChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x000AFC58 File Offset: 0x000ADE58
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x000094C1 File Offset: 0x000076C1
		public unsafe bool _screenSelectedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__screenSelectedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIScreen.NativeFieldInfoPtr__screenSelectedThisFrame)) = value;
			}
		}

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeFieldInfoPtr_panels;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeFieldInfoPtr_inputDescriptors;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeFieldInfoPtr_activeScrollRect;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeFieldInfoPtr_addScreenOnStart;

		// Token: 0x04000ACD RID: 2765
		private static readonly IntPtr NativeFieldInfoPtr_addScreenOnEnable;

		// Token: 0x04000ACE RID: 2766
		private static readonly IntPtr NativeFieldInfoPtr_removeScreenOnDisable;

		// Token: 0x04000ACF RID: 2767
		private static readonly IntPtr NativeFieldInfoPtr_autoAttachToInventory;

		// Token: 0x04000AD0 RID: 2768
		private static readonly IntPtr NativeFieldInfoPtr__debugMode;

		// Token: 0x04000AD1 RID: 2769
		private static readonly IntPtr NativeFieldInfoPtr_currentSelectedPanel;

		// Token: 0x04000AD2 RID: 2770
		private static readonly IntPtr NativeFieldInfoPtr_isSelected;

		// Token: 0x04000AD3 RID: 2771
		private static readonly IntPtr NativeFieldInfoPtr_wasNavPressedLastFrame;

		// Token: 0x04000AD4 RID: 2772
		private static readonly IntPtr NativeFieldInfoPtr__canvas;

		// Token: 0x04000AD5 RID: 2773
		private static readonly IntPtr NativeFieldInfoPtr__lastSelectedPanel;

		// Token: 0x04000AD6 RID: 2774
		private static readonly IntPtr NativeFieldInfoPtr__onPanelChange;

		// Token: 0x04000AD7 RID: 2775
		private static readonly IntPtr NativeFieldInfoPtr__screenSelectedThisFrame;

		// Token: 0x04000AD8 RID: 2776
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x04000AD9 RID: 2777
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Public_set_Void_Boolean_0;

		// Token: 0x04000ADA RID: 2778
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedPanel_Public_get_UIPanel_0;

		// Token: 0x04000ADB RID: 2779
		private static readonly IntPtr NativeMethodInfoPtr_get_Panels_Public_get_IReadOnlyList_1_UIPanel_0;

		// Token: 0x04000ADC RID: 2780
		private static readonly IntPtr NativeMethodInfoPtr_get_Canvas_Public_get_Canvas_0;

		// Token: 0x04000ADD RID: 2781
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000ADE RID: 2782
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_New_Void_0;

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Protected_Virtual_New_Void_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_New_Void_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_InitScreen_Private_Void_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_AddPanel_Public_Void_UIPanel_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_RemovePanel_Public_Void_UIPanel_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_ClearPanels_Public_Void_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UISelectable_Boolean_Boolean_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentSelectedPanel_Public_Void_UIPanel_UISelectable_Boolean_Boolean_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_SetToPreviousSelectedPanel_Public_Void_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScrollbar_Private_Void_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_DetectInput_Private_Void_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_DetectScreenInputDescriptors_Private_Void_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_ForceNavigate_Internal_Boolean_Vector2_Vector2_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Boolean_Vector2_Vector2_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_NavigateToPanel_Private_Boolean_UIPanel_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_ChangeActiveScrollRect_Public_Void_ScrollRect_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToPanelChange_Public_Void_PanelChangeEvent_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromPanelChange_Public_Void_PanelChangeEvent_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr__Navigate_b__44_0_Private_Boolean_UIPanel_0;
	}
}
