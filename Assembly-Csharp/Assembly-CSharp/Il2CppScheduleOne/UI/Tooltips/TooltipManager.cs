using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Tooltips
{
	// Token: 0x02000779 RID: 1913
	public class TooltipManager : Singleton<TooltipManager>
	{
		// Token: 0x0600BA13 RID: 47635 RVA: 0x002FE6F0 File Offset: 0x002FC8F0
		// Note: this type is marked as 'beforefieldinit'.
		static TooltipManager()
		{
			Il2CppClassPointerStore<TooltipManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Tooltips", "TooltipManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr);
			TooltipManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "Canvas");
			TooltipManager.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "anchor");
			TooltipManager.NativeFieldInfoPtr_tooltipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipLabel");
			TooltipManager.NativeFieldInfoPtr_canvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "canvases");
			TooltipManager.NativeFieldInfoPtr_sortedCanvases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "sortedCanvases");
			TooltipManager.NativeFieldInfoPtr_raycasters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "raycasters");
			TooltipManager.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "eventSystem");
			TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "tooltipShownThisFrame");
			TooltipManager.NativeFieldInfoPtr__manuallyDeactivateTooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "_manuallyDeactivateTooltip");
			TooltipManager.NativeFieldInfoPtr_pointerEventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "pointerEventData");
			TooltipManager.NativeFieldInfoPtr_rayResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "rayResults");
			TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687595);
			TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687596);
			TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687597);
			TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687598);
			TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687599);
			TooltipManager.NativeMethodInfoPtr_HideTooltip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687600);
			TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687601);
			TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, 100687602);
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x002FE89C File Offset: 0x002FCA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310629, XrefRangeEnd = 310712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x002FE8D8 File Offset: 0x002FCAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310712, XrefRangeEnd = 310713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x002FE914 File Offset: 0x002FCB14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310713, XrefRangeEnd = 310715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TooltipManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x002FE950 File Offset: 0x002FCB50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310803, RefRangeEnd = 310804, XrefRangeStart = 310715, XrefRangeEnd = 310803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCanvas(Canvas canvas)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA18 RID: 47640 RVA: 0x002FE994 File Offset: 0x002FCB94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310847, RefRangeEnd = 310848, XrefRangeStart = 310804, XrefRangeEnd = 310847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckForTooltipHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA19 RID: 47641 RVA: 0x002FE9C8 File Offset: 0x002FCBC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310850, RefRangeEnd = 310852, XrefRangeStart = 310848, XrefRangeEnd = 310850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTooltip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_HideTooltip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA1A RID: 47642 RVA: 0x002FE9FC File Offset: 0x002FCBFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310895, RefRangeEnd = 310897, XrefRangeStart = 310852, XrefRangeEnd = 310895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowTooltip(string text, Vector2 position, bool worldspace, bool manuallyDeactivate = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldspace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref manuallyDeactivate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA1B RID: 47643 RVA: 0x002FEA68 File Offset: 0x002FCC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310897, XrefRangeEnd = 310926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TooltipManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA1C RID: 47644 RVA: 0x00056B25 File Offset: 0x00054D25
		public TooltipManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600BA1D RID: 47645 RVA: 0x002FEAA4 File Offset: 0x002FCCA4
		// (set) Token: 0x0600BA1E RID: 47646 RVA: 0x00056B2E File Offset: 0x00054D2E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600BA1F RID: 47647 RVA: 0x002FEAD4 File Offset: 0x002FCCD4
		// (set) Token: 0x0600BA20 RID: 47648 RVA: 0x00056B4D File Offset: 0x00054D4D
		public unsafe RectTransform anchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_anchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600BA21 RID: 47649 RVA: 0x002FEB04 File Offset: 0x002FCD04
		// (set) Token: 0x0600BA22 RID: 47650 RVA: 0x00056B6C File Offset: 0x00054D6C
		public unsafe TextMeshProUGUI tooltipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600BA23 RID: 47651 RVA: 0x002FEB34 File Offset: 0x002FCD34
		// (set) Token: 0x0600BA24 RID: 47652 RVA: 0x00056B8B File Offset: 0x00054D8B
		public unsafe List<Canvas> canvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_canvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600BA25 RID: 47653 RVA: 0x002FEB64 File Offset: 0x002FCD64
		// (set) Token: 0x0600BA26 RID: 47654 RVA: 0x00056BAA File Offset: 0x00054DAA
		public unsafe List<Canvas> sortedCanvases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Canvas>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_sortedCanvases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600BA27 RID: 47655 RVA: 0x002FEB94 File Offset: 0x002FCD94
		// (set) Token: 0x0600BA28 RID: 47656 RVA: 0x00056BC9 File Offset: 0x00054DC9
		public unsafe List<GraphicRaycaster> raycasters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicRaycaster>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_raycasters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600BA29 RID: 47657 RVA: 0x002FEBC4 File Offset: 0x002FCDC4
		// (set) Token: 0x0600BA2A RID: 47658 RVA: 0x00056BE8 File Offset: 0x00054DE8
		public unsafe EventSystem eventSystem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600BA2B RID: 47659 RVA: 0x002FEBF4 File Offset: 0x002FCDF4
		// (set) Token: 0x0600BA2C RID: 47660 RVA: 0x00056C07 File Offset: 0x00054E07
		public unsafe bool tooltipShownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_tooltipShownThisFrame)) = value;
			}
		}

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600BA2D RID: 47661 RVA: 0x002FEC1C File Offset: 0x002FCE1C
		// (set) Token: 0x0600BA2E RID: 47662 RVA: 0x00056C22 File Offset: 0x00054E22
		public unsafe bool _manuallyDeactivateTooltip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr__manuallyDeactivateTooltip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr__manuallyDeactivateTooltip)) = value;
			}
		}

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600BA2F RID: 47663 RVA: 0x002FEC44 File Offset: 0x002FCE44
		// (set) Token: 0x0600BA30 RID: 47664 RVA: 0x00056C3D File Offset: 0x00054E3D
		public unsafe PointerEventData pointerEventData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_pointerEventData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PointerEventData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_pointerEventData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600BA31 RID: 47665 RVA: 0x002FEC74 File Offset: 0x002FCE74
		// (set) Token: 0x0600BA32 RID: 47666 RVA: 0x00056C5C File Offset: 0x00054E5C
		public unsafe List<RaycastResult> rayResults
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_rayResults);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TooltipManager.NativeFieldInfoPtr_rayResults), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F97 RID: 32663
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04007F98 RID: 32664
		private static readonly IntPtr NativeFieldInfoPtr_anchor;

		// Token: 0x04007F99 RID: 32665
		private static readonly IntPtr NativeFieldInfoPtr_tooltipLabel;

		// Token: 0x04007F9A RID: 32666
		private static readonly IntPtr NativeFieldInfoPtr_canvases;

		// Token: 0x04007F9B RID: 32667
		private static readonly IntPtr NativeFieldInfoPtr_sortedCanvases;

		// Token: 0x04007F9C RID: 32668
		private static readonly IntPtr NativeFieldInfoPtr_raycasters;

		// Token: 0x04007F9D RID: 32669
		private static readonly IntPtr NativeFieldInfoPtr_eventSystem;

		// Token: 0x04007F9E RID: 32670
		private static readonly IntPtr NativeFieldInfoPtr_tooltipShownThisFrame;

		// Token: 0x04007F9F RID: 32671
		private static readonly IntPtr NativeFieldInfoPtr__manuallyDeactivateTooltip;

		// Token: 0x04007FA0 RID: 32672
		private static readonly IntPtr NativeFieldInfoPtr_pointerEventData;

		// Token: 0x04007FA1 RID: 32673
		private static readonly IntPtr NativeFieldInfoPtr_rayResults;

		// Token: 0x04007FA2 RID: 32674
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007FA3 RID: 32675
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007FA4 RID: 32676
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04007FA5 RID: 32677
		private static readonly IntPtr NativeMethodInfoPtr_AddCanvas_Public_Void_Canvas_0;

		// Token: 0x04007FA6 RID: 32678
		private static readonly IntPtr NativeMethodInfoPtr_CheckForTooltipHover_Private_Void_0;

		// Token: 0x04007FA7 RID: 32679
		private static readonly IntPtr NativeMethodInfoPtr_HideTooltip_Public_Void_0;

		// Token: 0x04007FA8 RID: 32680
		private static readonly IntPtr NativeMethodInfoPtr_ShowTooltip_Public_Void_String_Vector2_Boolean_Boolean_0;

		// Token: 0x04007FA9 RID: 32681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D03 RID: 3331
		[ObfuscatedName("ScheduleOne.UI.Tooltips.TooltipManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F771 RID: 63345 RVA: 0x003B4F9C File Offset: 0x003B319C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TooltipManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr);
				TooltipManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9");
				TooltipManager.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__11_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__11_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__11_2");
				TooltipManager.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__14_0");
				TooltipManager.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__14_1");
				TooltipManager.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, "<>9__14_2");
				TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687604);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687605);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687606);
				TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687607);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_0_Internal_Boolean_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687608);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_1_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687609);
				TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_2_Internal_Int32_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr, 100687610);
			}

			// Token: 0x0600F772 RID: 63346 RVA: 0x003B50E0 File Offset: 0x003B32E0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F773 RID: 63347 RVA: 0x003B511C File Offset: 0x003B331C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310611, XrefRangeEnd = 310619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__11_0(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F774 RID: 63348 RVA: 0x003B516C File Offset: 0x003B336C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310619, XrefRangeEnd = 310621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__11_1(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F775 RID: 63349 RVA: 0x003B51BC File Offset: 0x003B33BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310621, XrefRangeEnd = 310624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _Awake_b__11_2(Canvas canvas)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvas);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__Awake_b__11_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F776 RID: 63350 RVA: 0x003B520C File Offset: 0x003B340C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310624, XrefRangeEnd = 310629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddCanvas_b__14_0(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_0_Internal_Boolean_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F777 RID: 63351 RVA: 0x003B525C File Offset: 0x003B345C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__14_1(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_1_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F778 RID: 63352 RVA: 0x003B52AC File Offset: 0x003B34AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddCanvas_b__14_2(Canvas c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TooltipManager.__c.NativeMethodInfoPtr__AddCanvas_b__14_2_Internal_Int32_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F779 RID: 63353 RVA: 0x00075040 File Offset: 0x00073240
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B41 RID: 19265
			// (get) Token: 0x0600F77A RID: 63354 RVA: 0x003B52FC File Offset: 0x003B34FC
			// (set) Token: 0x0600F77B RID: 63355 RVA: 0x00075049 File Offset: 0x00073249
			public unsafe static TooltipManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TooltipManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B42 RID: 19266
			// (get) Token: 0x0600F77C RID: 63356 RVA: 0x003B5324 File Offset: 0x003B3524
			// (set) Token: 0x0600F77D RID: 63357 RVA: 0x0007505B File Offset: 0x0007325B
			public unsafe static Func<Canvas, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B43 RID: 19267
			// (get) Token: 0x0600F77E RID: 63358 RVA: 0x003B534C File Offset: 0x003B354C
			// (set) Token: 0x0600F77F RID: 63359 RVA: 0x0007506D File Offset: 0x0007326D
			public unsafe static Func<Canvas, int> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B44 RID: 19268
			// (get) Token: 0x0600F780 RID: 63360 RVA: 0x003B5374 File Offset: 0x003B3574
			// (set) Token: 0x0600F781 RID: 63361 RVA: 0x0007507F File Offset: 0x0007327F
			public unsafe static Func<Canvas, int> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B45 RID: 19269
			// (get) Token: 0x0600F782 RID: 63362 RVA: 0x003B539C File Offset: 0x003B359C
			// (set) Token: 0x0600F783 RID: 63363 RVA: 0x00075091 File Offset: 0x00073291
			public unsafe static Func<Canvas, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B46 RID: 19270
			// (get) Token: 0x0600F784 RID: 63364 RVA: 0x003B53C4 File Offset: 0x003B35C4
			// (set) Token: 0x0600F785 RID: 63365 RVA: 0x000750A3 File Offset: 0x000732A3
			public unsafe static Func<Canvas, int> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B47 RID: 19271
			// (get) Token: 0x0600F786 RID: 63366 RVA: 0x003B53EC File Offset: 0x003B35EC
			// (set) Token: 0x0600F787 RID: 63367 RVA: 0x000750B5 File Offset: 0x000732B5
			public unsafe static Func<Canvas, int> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Canvas, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TooltipManager.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A757 RID: 42839
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A758 RID: 42840
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400A759 RID: 42841
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x0400A75A RID: 42842
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x0400A75B RID: 42843
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400A75C RID: 42844
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400A75D RID: 42845
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x0400A75E RID: 42846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A75F RID: 42847
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400A760 RID: 42848
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_1_Internal_Int32_Canvas_0;

			// Token: 0x0400A761 RID: 42849
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__11_2_Internal_Int32_Canvas_0;

			// Token: 0x0400A762 RID: 42850
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__14_0_Internal_Boolean_Canvas_0;

			// Token: 0x0400A763 RID: 42851
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__14_1_Internal_Int32_Canvas_0;

			// Token: 0x0400A764 RID: 42852
			private static readonly IntPtr NativeMethodInfoPtr__AddCanvas_b__14_2_Internal_Int32_Canvas_0;
		}
	}
}
