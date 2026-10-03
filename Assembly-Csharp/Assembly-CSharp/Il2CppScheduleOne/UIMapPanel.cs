using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne
{
	// Token: 0x020000A3 RID: 163
	public class UIMapPanel : UIPanel
	{
		// Token: 0x06000DE2 RID: 3554 RVA: 0x000A992C File Offset: 0x000A7B2C
		// Note: this type is marked as 'beforefieldinit'.
		static UIMapPanel()
		{
			Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "UIMapPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr);
			UIMapPanel.NativeFieldInfoPtr_rightStickDeadzone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "rightStickDeadzone");
			UIMapPanel.NativeFieldInfoPtr_mapScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "mapScrollRect");
			UIMapPanel.NativeFieldInfoPtr_scrollSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "scrollSensitivity");
			UIMapPanel.NativeFieldInfoPtr_rightStickSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "rightStickSensitivity");
			UIMapPanel.NativeFieldInfoPtr_minZoomScrollSpeedMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "minZoomScrollSpeedMult");
			UIMapPanel.NativeFieldInfoPtr_maxZoomScrollSpeedMult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "maxZoomScrollSpeedMult");
			UIMapPanel.NativeFieldInfoPtr_zoomSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "zoomSensitivity");
			UIMapPanel.NativeFieldInfoPtr_centerPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "centerPoint");
			UIMapPanel.NativeFieldInfoPtr_initialHoldThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "initialHoldThreshold");
			UIMapPanel.NativeFieldInfoPtr_repeatInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "repeatInterval");
			UIMapPanel.NativeFieldInfoPtr_mapItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "mapItems");
			UIMapPanel.NativeFieldInfoPtr_snappedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "snappedItem");
			UIMapPanel.NativeFieldInfoPtr_lockMapInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, "lockMapInput");
			UIMapPanel.NativeMethodInfoPtr_get_LockMapInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665059);
			UIMapPanel.NativeMethodInfoPtr_set_LockMapInput_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665060);
			UIMapPanel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665061);
			UIMapPanel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665062);
			UIMapPanel.NativeMethodInfoPtr_Navigate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665063);
			UIMapPanel.NativeMethodInfoPtr_Zoom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665064);
			UIMapPanel.NativeMethodInfoPtr_RegisterMapItem_Public_Void_UIMapItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665065);
			UIMapPanel.NativeMethodInfoPtr_DeregisterMapItem_Public_Void_UIMapItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665066);
			UIMapPanel.NativeMethodInfoPtr_SetSnappedItem_Public_Void_UIMapItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665067);
			UIMapPanel.NativeMethodInfoPtr_ResetSnappedItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665068);
			UIMapPanel.NativeMethodInfoPtr_SnapToNearestMapItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665069);
			UIMapPanel.NativeMethodInfoPtr_SnapMapToItem_Private_Void_UIMapItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665070);
			UIMapPanel.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665071);
			UIMapPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr, 100665072);
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000A9B78 File Offset: 0x000A7D78
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x000A9BB4 File Offset: 0x000A7DB4
		public unsafe bool LockMapInput
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_get_LockMapInput_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 80794, RefRangeEnd = 80795, XrefRangeStart = 80786, XrefRangeEnd = 80794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_set_LockMapInput_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x000A9BF4 File Offset: 0x000A7DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80795, XrefRangeEnd = 80803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIMapPanel.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x000A9C30 File Offset: 0x000A7E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80803, XrefRangeEnd = 80819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIMapPanel.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000A9C6C File Offset: 0x000A7E6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80851, RefRangeEnd = 80852, XrefRangeStart = 80819, XrefRangeEnd = 80851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Navigate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_Navigate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000A9CA0 File Offset: 0x000A7EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80852, XrefRangeEnd = 80861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Zoom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_Zoom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x000A9CD4 File Offset: 0x000A7ED4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80867, RefRangeEnd = 80869, XrefRangeStart = 80861, XrefRangeEnd = 80867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterMapItem(UIMapItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_RegisterMapItem_Public_Void_UIMapItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000A9D18 File Offset: 0x000A7F18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80875, RefRangeEnd = 80876, XrefRangeStart = 80869, XrefRangeEnd = 80875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterMapItem(UIMapItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_DeregisterMapItem_Public_Void_UIMapItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x000A9D5C File Offset: 0x000A7F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80876, XrefRangeEnd = 80882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSnappedItem(UIMapItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_SetSnappedItem_Public_Void_UIMapItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000A9DA0 File Offset: 0x000A7FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80888, RefRangeEnd = 80890, XrefRangeStart = 80882, XrefRangeEnd = 80888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetSnappedItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_ResetSnappedItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000A9DD4 File Offset: 0x000A7FD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80964, RefRangeEnd = 80965, XrefRangeStart = 80890, XrefRangeEnd = 80964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapToNearestMapItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_SnapToNearestMapItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x000A9E08 File Offset: 0x000A8008
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SnapMapToItem(UIMapItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr_SnapMapToItem_Private_Void_UIMapItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x000A9E4C File Offset: 0x000A804C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80965, XrefRangeEnd = 80968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleInputDeviceChanged(GameInput.InputDeviceType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIMapPanel.NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x000A9E98 File Offset: 0x000A8098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80968, XrefRangeEnd = 80976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIMapPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIMapPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIMapPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000085AB File Offset: 0x000067AB
		public UIMapPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x000A9ED4 File Offset: 0x000A80D4
		// (set) Token: 0x06000DF3 RID: 3571 RVA: 0x000085B4 File Offset: 0x000067B4
		public unsafe static float rightStickDeadzone
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIMapPanel.NativeFieldInfoPtr_rightStickDeadzone, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIMapPanel.NativeFieldInfoPtr_rightStickDeadzone, (void*)(&value));
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x000A9EF0 File Offset: 0x000A80F0
		// (set) Token: 0x06000DF5 RID: 3573 RVA: 0x000085C2 File Offset: 0x000067C2
		public unsafe PinchableScrollRect mapScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_mapScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PinchableScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_mapScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000DF6 RID: 3574 RVA: 0x000A9F20 File Offset: 0x000A8120
		// (set) Token: 0x06000DF7 RID: 3575 RVA: 0x000085E1 File Offset: 0x000067E1
		public unsafe float scrollSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_scrollSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_scrollSensitivity)) = value;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x000A9F48 File Offset: 0x000A8148
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x000085FC File Offset: 0x000067FC
		public unsafe float rightStickSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_rightStickSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_rightStickSensitivity)) = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x000A9F70 File Offset: 0x000A8170
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00008617 File Offset: 0x00006817
		public unsafe float minZoomScrollSpeedMult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_minZoomScrollSpeedMult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_minZoomScrollSpeedMult)) = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x000A9F98 File Offset: 0x000A8198
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00008632 File Offset: 0x00006832
		public unsafe float maxZoomScrollSpeedMult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_maxZoomScrollSpeedMult);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_maxZoomScrollSpeedMult)) = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000A9FC0 File Offset: 0x000A81C0
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x0000864D File Offset: 0x0000684D
		public unsafe float zoomSensitivity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_zoomSensitivity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_zoomSensitivity)) = value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x000A9FE8 File Offset: 0x000A81E8
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00008668 File Offset: 0x00006868
		public unsafe RectTransform centerPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_centerPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_centerPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000E02 RID: 3586 RVA: 0x000AA018 File Offset: 0x000A8218
		// (set) Token: 0x06000E03 RID: 3587 RVA: 0x00008687 File Offset: 0x00006887
		public unsafe static float initialHoldThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIMapPanel.NativeFieldInfoPtr_initialHoldThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIMapPanel.NativeFieldInfoPtr_initialHoldThreshold, (void*)(&value));
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000E04 RID: 3588 RVA: 0x000AA034 File Offset: 0x000A8234
		// (set) Token: 0x06000E05 RID: 3589 RVA: 0x00008695 File Offset: 0x00006895
		public unsafe static float repeatInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UIMapPanel.NativeFieldInfoPtr_repeatInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIMapPanel.NativeFieldInfoPtr_repeatInterval, (void*)(&value));
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000E06 RID: 3590 RVA: 0x000AA050 File Offset: 0x000A8250
		// (set) Token: 0x06000E07 RID: 3591 RVA: 0x000086A3 File Offset: 0x000068A3
		public unsafe List<UIMapItem> mapItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_mapItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIMapItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_mapItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x000AA080 File Offset: 0x000A8280
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000086C2 File Offset: 0x000068C2
		public unsafe UIMapItem snappedItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_snappedItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIMapItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_snappedItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x000AA0B0 File Offset: 0x000A82B0
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x000086E1 File Offset: 0x000068E1
		public unsafe bool lockMapInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_lockMapInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIMapPanel.NativeFieldInfoPtr_lockMapInput)) = value;
			}
		}

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeFieldInfoPtr_rightStickDeadzone;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeFieldInfoPtr_mapScrollRect;

		// Token: 0x040009BA RID: 2490
		private static readonly IntPtr NativeFieldInfoPtr_scrollSensitivity;

		// Token: 0x040009BB RID: 2491
		private static readonly IntPtr NativeFieldInfoPtr_rightStickSensitivity;

		// Token: 0x040009BC RID: 2492
		private static readonly IntPtr NativeFieldInfoPtr_minZoomScrollSpeedMult;

		// Token: 0x040009BD RID: 2493
		private static readonly IntPtr NativeFieldInfoPtr_maxZoomScrollSpeedMult;

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_zoomSensitivity;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeFieldInfoPtr_centerPoint;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeFieldInfoPtr_initialHoldThreshold;

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_repeatInterval;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_mapItems;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_snappedItem;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_lockMapInput;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeMethodInfoPtr_get_LockMapInput_Public_get_Boolean_0;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeMethodInfoPtr_set_LockMapInput_Public_set_Void_Boolean_0;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_Navigate_Private_Void_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_Zoom_Private_Void_0;

		// Token: 0x040009CB RID: 2507
		private static readonly IntPtr NativeMethodInfoPtr_RegisterMapItem_Public_Void_UIMapItem_0;

		// Token: 0x040009CC RID: 2508
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterMapItem_Public_Void_UIMapItem_0;

		// Token: 0x040009CD RID: 2509
		private static readonly IntPtr NativeMethodInfoPtr_SetSnappedItem_Public_Void_UIMapItem_0;

		// Token: 0x040009CE RID: 2510
		private static readonly IntPtr NativeMethodInfoPtr_ResetSnappedItem_Public_Void_0;

		// Token: 0x040009CF RID: 2511
		private static readonly IntPtr NativeMethodInfoPtr_SnapToNearestMapItem_Private_Void_0;

		// Token: 0x040009D0 RID: 2512
		private static readonly IntPtr NativeMethodInfoPtr_SnapMapToItem_Private_Void_UIMapItem_0;

		// Token: 0x040009D1 RID: 2513
		private static readonly IntPtr NativeMethodInfoPtr_HandleInputDeviceChanged_Protected_Virtual_Void_InputDeviceType_0;

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
