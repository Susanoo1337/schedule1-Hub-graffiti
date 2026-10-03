using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007BD RID: 1981
	public class WindowSelectorButton : MonoBehaviour
	{
		// Token: 0x0600C212 RID: 49682 RVA: 0x00317184 File Offset: 0x00315384
		// Note: this type is marked as 'beforefieldinit'.
		static WindowSelectorButton()
		{
			Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "WindowSelectorButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr);
			WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "SELECTION_INDICATOR_SCALE");
			WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "INDICATOR_LERP_TIME");
			WindowSelectorButton.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "OnSelected");
			WindowSelectorButton.NativeFieldInfoPtr_WindowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "WindowType");
			WindowSelectorButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "Button");
			WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "InactiveOverlay");
			WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "HoverIndicator");
			WindowSelectorButton.NativeFieldInfoPtr_uiSelectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "uiSelectable");
			WindowSelectorButton.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "trigger");
			WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "hoverRoutine");
			WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688539);
			WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688540);
			WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688541);
			WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688542);
			WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688543);
			WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688544);
			WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688545);
			WindowSelectorButton.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688546);
			WindowSelectorButton.NativeMethodInfoPtr__Awake_b__10_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100688547);
		}

		// Token: 0x0600C213 RID: 49683 RVA: 0x00317330 File Offset: 0x00315530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321669, XrefRangeEnd = 321713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C214 RID: 49684 RVA: 0x00317364 File Offset: 0x00315564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321713, XrefRangeEnd = 321716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C215 RID: 49685 RVA: 0x003173A4 File Offset: 0x003155A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321716, XrefRangeEnd = 321717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C216 RID: 49686 RVA: 0x003173D8 File Offset: 0x003155D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321717, XrefRangeEnd = 321718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x0031740C File Offset: 0x0031560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x00317440 File Offset: 0x00315640
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 321739, RefRangeEnd = 321749, XrefRangeStart = 321718, XrefRangeEnd = 321739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverIndicator(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x00317480 File Offset: 0x00315680
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowSelectorButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x003174BC File Offset: 0x003156BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr__Awake_b__10_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C21B RID: 49691 RVA: 0x00317500 File Offset: 0x00315700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__10_1(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr__Awake_b__10_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x0005B303 File Offset: 0x00059503
		public WindowSelectorButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003AD6 RID: 15062
		// (get) Token: 0x0600C21D RID: 49693 RVA: 0x00317544 File Offset: 0x00315744
		// (set) Token: 0x0600C21E RID: 49694 RVA: 0x0005B30C File Offset: 0x0005950C
		public unsafe static float SELECTION_INDICATOR_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600C21F RID: 49695 RVA: 0x00317560 File Offset: 0x00315760
		// (set) Token: 0x0600C220 RID: 49696 RVA: 0x0005B31A File Offset: 0x0005951A
		public unsafe static float INDICATOR_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600C221 RID: 49697 RVA: 0x0031757C File Offset: 0x0031577C
		// (set) Token: 0x0600C222 RID: 49698 RVA: 0x0005B328 File Offset: 0x00059528
		public unsafe UnityEvent OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600C223 RID: 49699 RVA: 0x003175AC File Offset: 0x003157AC
		// (set) Token: 0x0600C224 RID: 49700 RVA: 0x0005B347 File Offset: 0x00059547
		public unsafe EDealWindow WindowType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType)) = value;
			}
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600C225 RID: 49701 RVA: 0x003175D4 File Offset: 0x003157D4
		// (set) Token: 0x0600C226 RID: 49702 RVA: 0x0005B362 File Offset: 0x00059562
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ADB RID: 15067
		// (get) Token: 0x0600C227 RID: 49703 RVA: 0x00317604 File Offset: 0x00315804
		// (set) Token: 0x0600C228 RID: 49704 RVA: 0x0005B381 File Offset: 0x00059581
		public unsafe GameObject InactiveOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ADC RID: 15068
		// (get) Token: 0x0600C229 RID: 49705 RVA: 0x00317634 File Offset: 0x00315834
		// (set) Token: 0x0600C22A RID: 49706 RVA: 0x0005B3A0 File Offset: 0x000595A0
		public unsafe RectTransform HoverIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ADD RID: 15069
		// (get) Token: 0x0600C22B RID: 49707 RVA: 0x00317664 File Offset: 0x00315864
		// (set) Token: 0x0600C22C RID: 49708 RVA: 0x0005B3BF File Offset: 0x000595BF
		public unsafe UISelectable uiSelectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_uiSelectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_uiSelectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ADE RID: 15070
		// (get) Token: 0x0600C22D RID: 49709 RVA: 0x00317694 File Offset: 0x00315894
		// (set) Token: 0x0600C22E RID: 49710 RVA: 0x0005B3DE File Offset: 0x000595DE
		public unsafe EventTrigger trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003ADF RID: 15071
		// (get) Token: 0x0600C22F RID: 49711 RVA: 0x003176C4 File Offset: 0x003158C4
		// (set) Token: 0x0600C230 RID: 49712 RVA: 0x0005B3FD File Offset: 0x000595FD
		public unsafe Coroutine hoverRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040084B1 RID: 33969
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE;

		// Token: 0x040084B2 RID: 33970
		private static readonly IntPtr NativeFieldInfoPtr_INDICATOR_LERP_TIME;

		// Token: 0x040084B3 RID: 33971
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x040084B4 RID: 33972
		private static readonly IntPtr NativeFieldInfoPtr_WindowType;

		// Token: 0x040084B5 RID: 33973
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040084B6 RID: 33974
		private static readonly IntPtr NativeFieldInfoPtr_InactiveOverlay;

		// Token: 0x040084B7 RID: 33975
		private static readonly IntPtr NativeFieldInfoPtr_HoverIndicator;

		// Token: 0x040084B8 RID: 33976
		private static readonly IntPtr NativeFieldInfoPtr_uiSelectable;

		// Token: 0x040084B9 RID: 33977
		private static readonly IntPtr NativeFieldInfoPtr_trigger;

		// Token: 0x040084BA RID: 33978
		private static readonly IntPtr NativeFieldInfoPtr_hoverRoutine;

		// Token: 0x040084BB RID: 33979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040084BC RID: 33980
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040084BD RID: 33981
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Public_Void_0;

		// Token: 0x040084BE RID: 33982
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Public_Void_0;

		// Token: 0x040084BF RID: 33983
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040084C0 RID: 33984
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0;

		// Token: 0x040084C1 RID: 33985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040084C2 RID: 33986
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_0_Private_Void_BaseEventData_0;

		// Token: 0x040084C3 RID: 33987
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__10_1_Private_Void_BaseEventData_0;

		// Token: 0x02000D4C RID: 3404
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FA12 RID: 64018 RVA: 0x003BC8A4 File Offset: 0x003BAAA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr);
				WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr_shown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr, "shown");
				WindowSelectorButton.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr, 100688548);
				WindowSelectorButton.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr, 100688549);
			}

			// Token: 0x0600FA13 RID: 64019 RVA: 0x003BC920 File Offset: 0x003BAB20
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FA14 RID: 64020 RVA: 0x003BC95C File Offset: 0x003BAB5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321664, XrefRangeEnd = 321669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600FA15 RID: 64021 RVA: 0x00076495 File Offset: 0x00074695
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C06 RID: 19462
			// (get) Token: 0x0600FA16 RID: 64022 RVA: 0x003BC99C File Offset: 0x003BAB9C
			// (set) Token: 0x0600FA17 RID: 64023 RVA: 0x0007649E File Offset: 0x0007469E
			public unsafe WindowSelectorButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C07 RID: 19463
			// (get) Token: 0x0600FA18 RID: 64024 RVA: 0x003BC9CC File Offset: 0x003BABCC
			// (set) Token: 0x0600FA19 RID: 64025 RVA: 0x000764BD File Offset: 0x000746BD
			public unsafe bool shown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr_shown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.NativeFieldInfoPtr_shown)) = value;
				}
			}

			// Token: 0x0400A8DD RID: 43229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A8DE RID: 43230
			private static readonly IntPtr NativeFieldInfoPtr_shown;

			// Token: 0x0400A8DF RID: 43231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A8E0 RID: 43232
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000E16 RID: 3606
			[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass15_0+<<SetHoverIndicator>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x060103E1 RID: 66529 RVA: 0x003D9268 File Offset: 0x003D7468
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0>.NativeClassPtr, "<<SetHoverIndicator>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startScale>5__2");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<targetScale>5__3");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688550);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688551);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688552);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688553);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688554);
					WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100688555);
				}

				// Token: 0x060103E2 RID: 66530 RVA: 0x003D9384 File Offset: 0x003D7584
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103E3 RID: 66531 RVA: 0x003D93CC File Offset: 0x003D75CC
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060103E4 RID: 66532 RVA: 0x003D9400 File Offset: 0x003D7600
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321637, XrefRangeEnd = 321659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004F79 RID: 20345
				// (get) Token: 0x060103E5 RID: 66533 RVA: 0x003D943C File Offset: 0x003D763C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103E6 RID: 66534 RVA: 0x003D947C File Offset: 0x003D767C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321659, XrefRangeEnd = 321664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004F7A RID: 20346
				// (get) Token: 0x060103E7 RID: 66535 RVA: 0x003D94B0 File Offset: 0x003D76B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060103E8 RID: 66536 RVA: 0x0007B4C6 File Offset: 0x000796C6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004F73 RID: 20339
				// (get) Token: 0x060103E9 RID: 66537 RVA: 0x003D94F0 File Offset: 0x003D76F0
				// (set) Token: 0x060103EA RID: 66538 RVA: 0x0007B4CF File Offset: 0x000796CF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004F74 RID: 20340
				// (get) Token: 0x060103EB RID: 66539 RVA: 0x003D9518 File Offset: 0x003D7718
				// (set) Token: 0x060103EC RID: 66540 RVA: 0x0007B4EA File Offset: 0x000796EA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F75 RID: 20341
				// (get) Token: 0x060103ED RID: 66541 RVA: 0x003D9548 File Offset: 0x003D7748
				// (set) Token: 0x060103EE RID: 66542 RVA: 0x0007B509 File Offset: 0x00079709
				public unsafe WindowSelectorButton.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004F76 RID: 20342
				// (get) Token: 0x060103EF RID: 66543 RVA: 0x003D9578 File Offset: 0x003D7778
				// (set) Token: 0x060103F0 RID: 66544 RVA: 0x0007B528 File Offset: 0x00079728
				public unsafe float _startScale_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
					}
				}

				// Token: 0x17004F77 RID: 20343
				// (get) Token: 0x060103F1 RID: 66545 RVA: 0x003D95A0 File Offset: 0x003D77A0
				// (set) Token: 0x060103F2 RID: 66546 RVA: 0x0007B543 File Offset: 0x00079743
				public unsafe float _targetScale_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3)) = value;
					}
				}

				// Token: 0x17004F78 RID: 20344
				// (get) Token: 0x060103F3 RID: 66547 RVA: 0x003D95C8 File Offset: 0x003D77C8
				// (set) Token: 0x060103F4 RID: 66548 RVA: 0x0007B55E File Offset: 0x0007975E
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x0400AEDA RID: 44762
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AEDB RID: 44763
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AEDC RID: 44764
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AEDD RID: 44765
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

				// Token: 0x0400AEDE RID: 44766
				private static readonly IntPtr NativeFieldInfoPtr__targetScale_5__3;

				// Token: 0x0400AEDF RID: 44767
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x0400AEE0 RID: 44768
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AEE1 RID: 44769
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEE2 RID: 44770
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AEE3 RID: 44771
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AEE4 RID: 44772
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AEE5 RID: 44773
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
