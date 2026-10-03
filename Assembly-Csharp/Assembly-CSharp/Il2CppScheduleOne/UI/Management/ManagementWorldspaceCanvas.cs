using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020007DC RID: 2012
	public class ManagementWorldspaceCanvas : Singleton<ManagementWorldspaceCanvas>
	{
		// Token: 0x0600C488 RID: 50312 RVA: 0x0031E5DC File Offset: 0x0031C7DC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementWorldspaceCanvas()
		{
			Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ManagementWorldspaceCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr);
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "VISIBILITY_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "PROPERTY_CANVAS_RANGE");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<IsOpen>k__BackingField");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__CurrentProperty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<CurrentProperty>k__BackingField");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "Canvas");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ScaleCurve");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "TransitRouteVisualsPrefab");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_InteractInputPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "InteractInputPrompt");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ObjectSelectionLayerMask");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedOutlineColor");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "ShownConfigurables");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "HoveredConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "OutlinedConfigurable");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__isPromptActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "_isPromptActive");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr__currentPromptMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "_currentPromptMessage");
			ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "SelectedConfigurables");
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688791);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688792);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688793);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688794);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688795);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688796);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688797);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688798);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688799);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688800);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688801);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688802);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688803);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688804);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688805);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688806);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688807);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688808);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_SetCrosshairPromptMessage_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688809);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688810);
			ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, 100688811);
		}

		// Token: 0x17003BB5 RID: 15285
		// (get) Token: 0x0600C489 RID: 50313 RVA: 0x0031E904 File Offset: 0x0031CB04
		// (set) Token: 0x0600C48A RID: 50314 RVA: 0x0031E940 File Offset: 0x0031CB40
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003BB6 RID: 15286
		// (get) Token: 0x0600C48B RID: 50315 RVA: 0x0031E980 File Offset: 0x0031CB80
		// (set) Token: 0x0600C48C RID: 50316 RVA: 0x0031E9C0 File Offset: 0x0031CBC0
		public unsafe Property CurrentProperty
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C48D RID: 50317 RVA: 0x0031EA04 File Offset: 0x0031CC04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325432, RefRangeEnd = 325434, XrefRangeStart = 325415, XrefRangeEnd = 325432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C48E RID: 50318 RVA: 0x0031EA38 File Offset: 0x0031CC38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325449, RefRangeEnd = 325451, XrefRangeStart = 325434, XrefRangeEnd = 325449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool preserveSelection = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref preserveSelection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C48F RID: 50319 RVA: 0x0031EA78 File Offset: 0x0031CC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325451, XrefRangeEnd = 325501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C490 RID: 50320 RVA: 0x0031EAAC File Offset: 0x0031CCAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325550, RefRangeEnd = 325552, XrefRangeStart = 325501, XrefRangeEnd = 325550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x0031EAE0 File Offset: 0x0031CCE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325637, RefRangeEnd = 325638, XrefRangeStart = 325552, XrefRangeEnd = 325637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUIs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateUIs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C492 RID: 50322 RVA: 0x0031EB14 File Offset: 0x0031CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325638, XrefRangeEnd = 325702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C493 RID: 50323 RVA: 0x0031EB48 File Offset: 0x0031CD48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325778, RefRangeEnd = 325779, XrefRangeStart = 325702, XrefRangeEnd = 325778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_UpdateSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C494 RID: 50324 RVA: 0x0031EB7C File Offset: 0x0031CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325779, XrefRangeEnd = 325790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C495 RID: 50325 RVA: 0x0031EBC0 File Offset: 0x0031CDC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325805, RefRangeEnd = 325807, XrefRangeStart = 325790, XrefRangeEnd = 325805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFromSelection(IConfigurable config)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(config);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C496 RID: 50326 RVA: 0x0031EC04 File Offset: 0x0031CE04
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 325812, RefRangeEnd = 325815, XrefRangeStart = 325807, XrefRangeEnd = 325812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ClearSelection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C497 RID: 50327 RVA: 0x0031EC38 File Offset: 0x0031CE38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 325827, RefRangeEnd = 325829, XrefRangeStart = 325815, XrefRangeEnd = 325827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveNullConfigurables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C498 RID: 50328 RVA: 0x0031EC6C File Offset: 0x0031CE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325829, XrefRangeEnd = 325838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IConfigurable GetHoveredConfigurable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
		}

		// Token: 0x0600C499 RID: 50329 RVA: 0x0031ECAC File Offset: 0x0031CEAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325893, RefRangeEnd = 325894, XrefRangeStart = 325838, XrefRangeEnd = 325893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<IConfigurable> GetConfigurablesToShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr3) : null;
		}

		// Token: 0x0600C49A RID: 50330 RVA: 0x0031ECEC File Offset: 0x0031CEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325894, XrefRangeEnd = 325900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowCrosshairPrompt(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C49B RID: 50331 RVA: 0x0031ED30 File Offset: 0x0031CF30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325900, XrefRangeEnd = 325907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCrosshairPromptMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_SetCrosshairPromptMessage_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C49C RID: 50332 RVA: 0x0031ED74 File Offset: 0x0031CF74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 325916, RefRangeEnd = 325917, XrefRangeStart = 325907, XrefRangeEnd = 325916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideCrosshairPrompt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C49D RID: 50333 RVA: 0x0031EDA8 File Offset: 0x0031CFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325917, XrefRangeEnd = 325936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementWorldspaceCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C49E RID: 50334 RVA: 0x0005CB16 File Offset: 0x0005AD16
		public ManagementWorldspaceCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003BA4 RID: 15268
		// (get) Token: 0x0600C49F RID: 50335 RVA: 0x0031EDE4 File Offset: 0x0031CFE4
		// (set) Token: 0x0600C4A0 RID: 50336 RVA: 0x0005CB1F File Offset: 0x0005AD1F
		public unsafe static float VISIBILITY_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_VISIBILITY_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003BA5 RID: 15269
		// (get) Token: 0x0600C4A1 RID: 50337 RVA: 0x0031EE00 File Offset: 0x0031D000
		// (set) Token: 0x0600C4A2 RID: 50338 RVA: 0x0005CB2D File Offset: 0x0005AD2D
		public unsafe static float PROPERTY_CANVAS_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17003BA6 RID: 15270
		// (get) Token: 0x0600C4A3 RID: 50339 RVA: 0x0031EE1C File Offset: 0x0031D01C
		// (set) Token: 0x0600C4A4 RID: 50340 RVA: 0x0005CB3B File Offset: 0x0005AD3B
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003BA7 RID: 15271
		// (get) Token: 0x0600C4A5 RID: 50341 RVA: 0x0031EE44 File Offset: 0x0031D044
		// (set) Token: 0x0600C4A6 RID: 50342 RVA: 0x0005CB56 File Offset: 0x0005AD56
		public unsafe Property _CurrentProperty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__CurrentProperty_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__CurrentProperty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BA8 RID: 15272
		// (get) Token: 0x0600C4A7 RID: 50343 RVA: 0x0031EE74 File Offset: 0x0031D074
		// (set) Token: 0x0600C4A8 RID: 50344 RVA: 0x0005CB75 File Offset: 0x0005AD75
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BA9 RID: 15273
		// (get) Token: 0x0600C4A9 RID: 50345 RVA: 0x0031EEA4 File Offset: 0x0031D0A4
		// (set) Token: 0x0600C4AA RID: 50346 RVA: 0x0005CB94 File Offset: 0x0005AD94
		public unsafe AnimationCurve ScaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ScaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BAA RID: 15274
		// (get) Token: 0x0600C4AB RID: 50347 RVA: 0x0031EED4 File Offset: 0x0031D0D4
		// (set) Token: 0x0600C4AC RID: 50348 RVA: 0x0005CBB3 File Offset: 0x0005ADB3
		public unsafe TransitLineVisuals TransitRouteVisualsPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_TransitRouteVisualsPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BAB RID: 15275
		// (get) Token: 0x0600C4AD RID: 50349 RVA: 0x0031EF04 File Offset: 0x0031D104
		// (set) Token: 0x0600C4AE RID: 50350 RVA: 0x0005CBD2 File Offset: 0x0005ADD2
		public unsafe InputPromptsData InteractInputPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_InteractInputPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_InteractInputPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BAC RID: 15276
		// (get) Token: 0x0600C4AF RID: 50351 RVA: 0x0031EF34 File Offset: 0x0031D134
		// (set) Token: 0x0600C4B0 RID: 50352 RVA: 0x0005CBF1 File Offset: 0x0005ADF1
		public unsafe LayerMask ObjectSelectionLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ObjectSelectionLayerMask)) = value;
			}
		}

		// Token: 0x17003BAD RID: 15277
		// (get) Token: 0x0600C4B1 RID: 50353 RVA: 0x0031EF5C File Offset: 0x0031D15C
		// (set) Token: 0x0600C4B2 RID: 50354 RVA: 0x0005CC0C File Offset: 0x0005AE0C
		public unsafe Color HoveredOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredOutlineColor)) = value;
			}
		}

		// Token: 0x17003BAE RID: 15278
		// (get) Token: 0x0600C4B3 RID: 50355 RVA: 0x0031EF84 File Offset: 0x0031D184
		// (set) Token: 0x0600C4B4 RID: 50356 RVA: 0x0005CC27 File Offset: 0x0005AE27
		public unsafe Color SelectedOutlineColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedOutlineColor)) = value;
			}
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600C4B5 RID: 50357 RVA: 0x0031EFAC File Offset: 0x0031D1AC
		// (set) Token: 0x0600C4B6 RID: 50358 RVA: 0x0005CC42 File Offset: 0x0005AE42
		public unsafe List<IConfigurable> ShownConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_ShownConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BB0 RID: 15280
		// (get) Token: 0x0600C4B7 RID: 50359 RVA: 0x0031EFDC File Offset: 0x0031D1DC
		// (set) Token: 0x0600C4B8 RID: 50360 RVA: 0x0005CC61 File Offset: 0x0005AE61
		public unsafe IConfigurable HoveredConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_HoveredConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BB1 RID: 15281
		// (get) Token: 0x0600C4B9 RID: 50361 RVA: 0x0031F00C File Offset: 0x0031D20C
		// (set) Token: 0x0600C4BA RID: 50362 RVA: 0x0005CC80 File Offset: 0x0005AE80
		public unsafe IConfigurable OutlinedConfigurable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_OutlinedConfigurable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0600C4BB RID: 50363 RVA: 0x0031F03C File Offset: 0x0031D23C
		// (set) Token: 0x0600C4BC RID: 50364 RVA: 0x0005CC9F File Offset: 0x0005AE9F
		public unsafe bool _isPromptActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__isPromptActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__isPromptActive)) = value;
			}
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0600C4BD RID: 50365 RVA: 0x0031F064 File Offset: 0x0031D264
		// (set) Token: 0x0600C4BE RID: 50366 RVA: 0x0005CCBA File Offset: 0x0005AEBA
		public unsafe string _currentPromptMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__currentPromptMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr__currentPromptMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003BB4 RID: 15284
		// (get) Token: 0x0600C4BF RID: 50367 RVA: 0x0031F08C File Offset: 0x0031D28C
		// (set) Token: 0x0600C4C0 RID: 50368 RVA: 0x0005CCD9 File Offset: 0x0005AED9
		public unsafe List<IConfigurable> SelectedConfigurables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IConfigurable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.NativeFieldInfoPtr_SelectedConfigurables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008628 RID: 34344
		private static readonly IntPtr NativeFieldInfoPtr_VISIBILITY_RANGE;

		// Token: 0x04008629 RID: 34345
		private static readonly IntPtr NativeFieldInfoPtr_PROPERTY_CANVAS_RANGE;

		// Token: 0x0400862A RID: 34346
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x0400862B RID: 34347
		private static readonly IntPtr NativeFieldInfoPtr__CurrentProperty_k__BackingField;

		// Token: 0x0400862C RID: 34348
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400862D RID: 34349
		private static readonly IntPtr NativeFieldInfoPtr_ScaleCurve;

		// Token: 0x0400862E RID: 34350
		private static readonly IntPtr NativeFieldInfoPtr_TransitRouteVisualsPrefab;

		// Token: 0x0400862F RID: 34351
		private static readonly IntPtr NativeFieldInfoPtr_InteractInputPrompt;

		// Token: 0x04008630 RID: 34352
		private static readonly IntPtr NativeFieldInfoPtr_ObjectSelectionLayerMask;

		// Token: 0x04008631 RID: 34353
		private static readonly IntPtr NativeFieldInfoPtr_HoveredOutlineColor;

		// Token: 0x04008632 RID: 34354
		private static readonly IntPtr NativeFieldInfoPtr_SelectedOutlineColor;

		// Token: 0x04008633 RID: 34355
		private static readonly IntPtr NativeFieldInfoPtr_ShownConfigurables;

		// Token: 0x04008634 RID: 34356
		private static readonly IntPtr NativeFieldInfoPtr_HoveredConfigurable;

		// Token: 0x04008635 RID: 34357
		private static readonly IntPtr NativeFieldInfoPtr_OutlinedConfigurable;

		// Token: 0x04008636 RID: 34358
		private static readonly IntPtr NativeFieldInfoPtr__isPromptActive;

		// Token: 0x04008637 RID: 34359
		private static readonly IntPtr NativeFieldInfoPtr__currentPromptMessage;

		// Token: 0x04008638 RID: 34360
		private static readonly IntPtr NativeFieldInfoPtr_SelectedConfigurables;

		// Token: 0x04008639 RID: 34361
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400863A RID: 34362
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400863B RID: 34363
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentProperty_Public_get_Property_0;

		// Token: 0x0400863C RID: 34364
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentProperty_Private_set_Void_Property_0;

		// Token: 0x0400863D RID: 34365
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400863E RID: 34366
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x0400863F RID: 34367
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04008640 RID: 34368
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputPrompt_Private_Void_0;

		// Token: 0x04008641 RID: 34369
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUIs_Private_Void_0;

		// Token: 0x04008642 RID: 34370
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04008643 RID: 34371
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSelection_Private_Void_0;

		// Token: 0x04008644 RID: 34372
		private static readonly IntPtr NativeMethodInfoPtr_AddToSelection_Private_Void_IConfigurable_0;

		// Token: 0x04008645 RID: 34373
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFromSelection_Private_Void_IConfigurable_0;

		// Token: 0x04008646 RID: 34374
		private static readonly IntPtr NativeMethodInfoPtr_ClearSelection_Private_Void_0;

		// Token: 0x04008647 RID: 34375
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNullConfigurables_Private_Void_0;

		// Token: 0x04008648 RID: 34376
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredConfigurable_Private_IConfigurable_0;

		// Token: 0x04008649 RID: 34377
		private static readonly IntPtr NativeMethodInfoPtr_GetConfigurablesToShow_Private_List_1_IConfigurable_0;

		// Token: 0x0400864A RID: 34378
		private static readonly IntPtr NativeMethodInfoPtr_ShowCrosshairPrompt_Public_Void_String_0;

		// Token: 0x0400864B RID: 34379
		private static readonly IntPtr NativeMethodInfoPtr_SetCrosshairPromptMessage_Private_Void_String_0;

		// Token: 0x0400864C RID: 34380
		private static readonly IntPtr NativeMethodInfoPtr_HideCrosshairPrompt_Public_Void_0;

		// Token: 0x0400864D RID: 34381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D5F RID: 3423
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FAC3 RID: 64195 RVA: 0x003BE728 File Offset: 0x003BC928
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9");
				ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, "<>9__28_0");
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100688813);
				ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__28_0_Internal_Int32_IConfigurable_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr, 100688814);
			}

			// Token: 0x0600FAC4 RID: 64196 RVA: 0x003BE7A4 File Offset: 0x003BC9A4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FAC5 RID: 64197 RVA: 0x003BE7E0 File Offset: 0x003BC9E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325382, XrefRangeEnd = 325411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _LateUpdate_b__28_0(IConfigurable a, IConfigurable b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c.NativeMethodInfoPtr__LateUpdate_b__28_0_Internal_Int32_IConfigurable_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FAC6 RID: 64198 RVA: 0x00076A41 File Offset: 0x00074C41
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C36 RID: 19510
			// (get) Token: 0x0600FAC7 RID: 64199 RVA: 0x003BE840 File Offset: 0x003BCA40
			// (set) Token: 0x0600FAC8 RID: 64200 RVA: 0x00076A4A File Offset: 0x00074C4A
			public unsafe static ManagementWorldspaceCanvas.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C37 RID: 19511
			// (get) Token: 0x0600FAC9 RID: 64201 RVA: 0x003BE868 File Offset: 0x003BCA68
			// (set) Token: 0x0600FACA RID: 64202 RVA: 0x00076A5C File Offset: 0x00074C5C
			public unsafe static Comparison<IConfigurable> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<IConfigurable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ManagementWorldspaceCanvas.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A93B RID: 43323
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A93C RID: 43324
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400A93D RID: 43325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A93E RID: 43326
			private static readonly IntPtr NativeMethodInfoPtr__LateUpdate_b__28_0_Internal_Int32_IConfigurable_IConfigurable_0;
		}

		// Token: 0x02000D60 RID: 3424
		[ObfuscatedName("ScheduleOne.UI.Management.ManagementWorldspaceCanvas+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FACB RID: 64203 RVA: 0x003BE890 File Offset: 0x003BCA90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagementWorldspaceCanvas>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr);
				ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr_config = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr, "config");
				ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr, 100688815);
				ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr, 100688816);
			}

			// Token: 0x0600FACC RID: 64204 RVA: 0x003BE90C File Offset: 0x003BCB0C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementWorldspaceCanvas.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FACD RID: 64205 RVA: 0x003BE948 File Offset: 0x003BCB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 325411, XrefRangeEnd = 325415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateUIs_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FACE RID: 64206 RVA: 0x00076A6E File Offset: 0x00074C6E
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C38 RID: 19512
			// (get) Token: 0x0600FACF RID: 64207 RVA: 0x003BE97C File Offset: 0x003BCB7C
			// (set) Token: 0x0600FAD0 RID: 64208 RVA: 0x00076A77 File Offset: 0x00074C77
			public unsafe IConfigurable config
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr_config);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr_config), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C39 RID: 19513
			// (get) Token: 0x0600FAD1 RID: 64209 RVA: 0x003BE9AC File Offset: 0x003BCBAC
			// (set) Token: 0x0600FAD2 RID: 64210 RVA: 0x00076A96 File Offset: 0x00074C96
			public unsafe ManagementWorldspaceCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementWorldspaceCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementWorldspaceCanvas.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A93F RID: 43327
			private static readonly IntPtr NativeFieldInfoPtr_config;

			// Token: 0x0400A940 RID: 43328
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A941 RID: 43329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A942 RID: 43330
			private static readonly IntPtr NativeMethodInfoPtr__UpdateUIs_b__0_Internal_Void_0;
		}
	}
}
