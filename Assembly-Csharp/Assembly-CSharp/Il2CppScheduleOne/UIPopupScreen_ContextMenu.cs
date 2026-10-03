using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne
{
	// Token: 0x020000AB RID: 171
	public class UIPopupScreen_ContextMenu : UIPopupScreen
	{
		// Token: 0x06000EDF RID: 3807 RVA: 0x000ACE74 File Offset: 0x000AB074
		// Note: this type is marked as 'beforefieldinit'.
		static UIPopupScreen_ContextMenu()
		{
			Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIPopupScreen_ContextMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr);
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "selectablePrefab");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_contentParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "contentParent");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchorRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "anchorRectTransform");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "canvas");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_screenBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "screenBlocker");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "anchor");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "options");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "selectablePool");
			UIPopupScreen_ContextMenu.NativeFieldInfoPtr_activeSelectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "activeSelectables");
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_get_Anchor_Public_get_AnchorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665184);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_set_Anchor_Public_set_Void_AnchorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665185);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665186);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665187);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665188);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665189);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_AddOption_Public_Void_Int32_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665190);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665191);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Open_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665192);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665193);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Clear_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665194);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_SelectPanel_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665195);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_GetSelectableFromPool_Private_UISelectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665196);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr_SetPosition_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665197);
			UIPopupScreen_ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, 100665198);
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000EE0 RID: 3808 RVA: 0x000AD084 File Offset: 0x000AB284
		// (set) Token: 0x06000EE1 RID: 3809 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
		public unsafe UIPopupScreen_ContextMenu.AnchorType Anchor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 68998, RefRangeEnd = 68999, XrefRangeStart = 68998, XrefRangeEnd = 68999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_get_Anchor_Public_get_AnchorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82163, XrefRangeEnd = 82164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_set_Anchor_Public_set_Void_AnchorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000AD100 File Offset: 0x000AB300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82164, XrefRangeEnd = 82168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAwake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000AD13C File Offset: 0x000AB33C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82168, XrefRangeEnd = 82190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000AD178 File Offset: 0x000AB378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82190, XrefRangeEnd = 82212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ContextMenu.NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000AD1B4 File Offset: 0x000AB3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82212, XrefRangeEnd = 82214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000AD1F4 File Offset: 0x000AB3F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82271, RefRangeEnd = 82272, XrefRangeStart = 82214, XrefRangeEnd = 82271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOption(int id, string name, Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_AddOption_Public_Void_Int32_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000AD258 File Offset: 0x000AB458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82272, XrefRangeEnd = 82280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000AD294 File Offset: 0x000AB494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82280, XrefRangeEnd = 82291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Open_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82291, XrefRangeEnd = 82355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open([Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000AD324 File Offset: 0x000AB524
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82381, RefRangeEnd = 82382, XrefRangeStart = 82355, XrefRangeEnd = 82381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_Clear_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000AD358 File Offset: 0x000AB558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82382, XrefRangeEnd = 82396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectPanel(int selectedIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref selectedIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_SelectPanel_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000AD398 File Offset: 0x000AB598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82396, XrefRangeEnd = 82416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable GetSelectableFromPool()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_GetSelectableFromPool_Private_UISelectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr3) : null;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x000AD3D8 File Offset: 0x000AB5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82416, XrefRangeEnd = 82426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(Vector2 pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr_SetPosition_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x000AD418 File Offset: 0x000AB618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82426, XrefRangeEnd = 82448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIPopupScreen_ContextMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00008D51 File Offset: 0x00006F51
		public override void Open(params Il2CppSystem.Object[] args)
		{
			this.Open(new Il2CppReferenceArray<Il2CppSystem.Object>(args));
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00008D5F File Offset: 0x00006F5F
		public UIPopupScreen_ContextMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x000AD454 File Offset: 0x000AB654
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00008D68 File Offset: 0x00006F68
		public unsafe UISelectable selectablePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06000EF3 RID: 3827 RVA: 0x000AD484 File Offset: 0x000AB684
		// (set) Token: 0x06000EF4 RID: 3828 RVA: 0x00008D87 File Offset: 0x00006F87
		public unsafe Transform contentParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_contentParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_contentParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x000AD4B4 File Offset: 0x000AB6B4
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x00008DA6 File Offset: 0x00006FA6
		public unsafe RectTransform anchorRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchorRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchorRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x000AD4E4 File Offset: 0x000AB6E4
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00008DC5 File Offset: 0x00006FC5
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000AD514 File Offset: 0x000AB714
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x00008DE4 File Offset: 0x00006FE4
		public unsafe GameObject screenBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_screenBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_screenBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000AD544 File Offset: 0x000AB744
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00008E03 File Offset: 0x00007003
		public unsafe UIPopupScreen_ContextMenu.AnchorType anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_anchor)) = value;
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000AD56C File Offset: 0x000AB76C
		// (set) Token: 0x06000EFE RID: 3838 RVA: 0x00008E1E File Offset: 0x0000701E
		public unsafe List<UIPopupScreen_ContextMenu.ContextMenuOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIPopupScreen_ContextMenu.ContextMenuOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000AD59C File Offset: 0x000AB79C
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x00008E3D File Offset: 0x0000703D
		public unsafe Queue<UISelectable> selectablePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_selectablePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000AD5CC File Offset: 0x000AB7CC
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x00008E5C File Offset: 0x0000705C
		public unsafe Dictionary<int, UISelectable> activeSelectables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_activeSelectables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, UISelectable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.NativeFieldInfoPtr_activeSelectables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_selectablePrefab;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_contentParent;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_anchorRectTransform;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_screenBlocker;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_selectablePool;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_activeSelectables;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_get_Anchor_Public_get_AnchorType_0;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_set_Anchor_Public_set_Void_AnchorType_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_OnAwake_Protected_Virtual_Void_0;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeMethodInfoPtr_OnStarted_Protected_Virtual_Void_0;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Private_Void_InputDeviceType_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_AddOption_Public_Void_Int32_String_Action_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Void_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Private_Void_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr_SelectPanel_Private_Void_Int32_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr_GetSelectableFromPool_Private_UISelectable_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Private_Void_Vector2_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008BF RID: 2239
		public class ContextMenuOption : Il2CppSystem.Object
		{
			// Token: 0x0600D49A RID: 54426 RVA: 0x0034F064 File Offset: 0x0034D264
			// Note: this type is marked as 'beforefieldinit'.
			static ContextMenuOption()
			{
				Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "ContextMenuOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr);
				UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr, "optionID");
				UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr, "optionName");
				UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr, "optionAction");
				UIPopupScreen_ContextMenu.ContextMenuOption.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr, 100665199);
			}

			// Token: 0x0600D49B RID: 54427 RVA: 0x0034F0E0 File Offset: 0x0034D2E0
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 82141, RefRangeEnd = 82163, XrefRangeStart = 82138, XrefRangeEnd = 82141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContextMenuOption(int id, string name, Action action) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.ContextMenuOption>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.ContextMenuOption.NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D49C RID: 54428 RVA: 0x00064908 File Offset: 0x00062B08
			public ContextMenuOption(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BB RID: 16571
			// (get) Token: 0x0600D49D RID: 54429 RVA: 0x0034F14C File Offset: 0x0034D34C
			// (set) Token: 0x0600D49E RID: 54430 RVA: 0x00064911 File Offset: 0x00062B11
			public unsafe int optionID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionID)) = value;
				}
			}

			// Token: 0x170040BC RID: 16572
			// (get) Token: 0x0600D49F RID: 54431 RVA: 0x0034F174 File Offset: 0x0034D374
			// (set) Token: 0x0600D4A0 RID: 54432 RVA: 0x0006492C File Offset: 0x00062B2C
			public unsafe string optionName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170040BD RID: 16573
			// (get) Token: 0x0600D4A1 RID: 54433 RVA: 0x0034F19C File Offset: 0x0034D39C
			// (set) Token: 0x0600D4A2 RID: 54434 RVA: 0x0006494B File Offset: 0x00062B4B
			public unsafe Action optionAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.ContextMenuOption.NativeFieldInfoPtr_optionAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090C9 RID: 37065
			private static readonly IntPtr NativeFieldInfoPtr_optionID;

			// Token: 0x040090CA RID: 37066
			private static readonly IntPtr NativeFieldInfoPtr_optionName;

			// Token: 0x040090CB RID: 37067
			private static readonly IntPtr NativeFieldInfoPtr_optionAction;

			// Token: 0x040090CC RID: 37068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_String_Action_0;
		}

		// Token: 0x020008C0 RID: 2240
		[OriginalName("Assembly-CSharp.dll", "", "AnchorType")]
		public enum AnchorType
		{
			// Token: 0x040090CE RID: 37070
			TopLeft,
			// Token: 0x040090CF RID: 37071
			BottomLeft,
			// Token: 0x040090D0 RID: 37072
			Center
		}

		// Token: 0x020008C1 RID: 2241
		[ObfuscatedName("ScheduleOne.UIPopupScreen_ContextMenu+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D4A3 RID: 54435 RVA: 0x0034F1CC File Offset: 0x0034D3CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPopupScreen_ContextMenu>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr);
				UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr, "action");
				UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr, 100665200);
				UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOption_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr, 100665201);
			}

			// Token: 0x0600D4A4 RID: 54436 RVA: 0x0034F248 File Offset: 0x0034D448
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPopupScreen_ContextMenu.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4A5 RID: 54437 RVA: 0x0034F284 File Offset: 0x0034D484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddOption_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOption_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4A6 RID: 54438 RVA: 0x0006496A File Offset: 0x00062B6A
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040BE RID: 16574
			// (get) Token: 0x0600D4A7 RID: 54439 RVA: 0x0034F2B8 File Offset: 0x0034D4B8
			// (set) Token: 0x0600D4A8 RID: 54440 RVA: 0x00064973 File Offset: 0x00062B73
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040BF RID: 16575
			// (get) Token: 0x0600D4A9 RID: 54441 RVA: 0x0034F2E8 File Offset: 0x0034D4E8
			// (set) Token: 0x0600D4AA RID: 54442 RVA: 0x00064992 File Offset: 0x00062B92
			public unsafe UIPopupScreen_ContextMenu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPopupScreen_ContextMenu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIPopupScreen_ContextMenu.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040090D1 RID: 37073
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x040090D2 RID: 37074
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090D3 RID: 37075
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040090D4 RID: 37076
			private static readonly IntPtr NativeMethodInfoPtr__AddOption_b__0_Internal_Void_0;
		}
	}
}
