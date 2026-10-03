using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000774 RID: 1908
	public class WorldspacePopup : MonoBehaviour
	{
		// Token: 0x0600B9B0 RID: 47536 RVA: 0x002FD610 File Offset: 0x002FB810
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopup()
		{
			Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr);
			WorldspacePopup.NativeFieldInfoPtr_ActivePopups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ActivePopups");
			WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "CurrentFillLevel");
			WorldspacePopup.NativeFieldInfoPtr_UIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIPrefab");
			WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "DisplayOnHUD");
			WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "ScaleWithDistance");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceOffset");
			WorldspacePopup.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "Range");
			WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "SizeMultiplier");
			WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "WorldspaceUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUI");
			WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUIIcon");
			WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "HUDUICanvasGroup");
			WorldspacePopup.NativeFieldInfoPtr_UIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "UIs");
			WorldspacePopup.NativeFieldInfoPtr_popupCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "popupCoroutine");
			WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687561);
			WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687562);
			WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687563);
			WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687564);
			WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687565);
			WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687566);
			WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, 100687568);
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x002FD7E4 File Offset: 0x002FB9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310134, XrefRangeEnd = 310151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x002FD818 File Offset: 0x002FBA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310151, XrefRangeEnd = 310162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x002FD84C File Offset: 0x002FBA4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310188, RefRangeEnd = 310191, XrefRangeStart = 310162, XrefRangeEnd = 310188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateUI(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x002FD89C File Offset: 0x002FBA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310191, XrefRangeEnd = 310206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x002FD8D0 File Offset: 0x002FBAD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310214, RefRangeEnd = 310215, XrefRangeStart = 310206, XrefRangeEnd = 310214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Popup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Popup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x002FD904 File Offset: 0x002FBB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310215, XrefRangeEnd = 310223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x002FD940 File Offset: 0x002FBB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310223, XrefRangeEnd = 310228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x00056778 File Offset: 0x00054978
		public WorldspacePopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600B9B9 RID: 47545 RVA: 0x002FD980 File Offset: 0x002FBB80
		// (set) Token: 0x0600B9BA RID: 47546 RVA: 0x00056781 File Offset: 0x00054981
		public unsafe static List<WorldspacePopup> ActivePopups
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopup.NativeFieldInfoPtr_ActivePopups, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600B9BB RID: 47547 RVA: 0x002FD9A8 File Offset: 0x002FBBA8
		// (set) Token: 0x0600B9BC RID: 47548 RVA: 0x00056793 File Offset: 0x00054993
		public unsafe float CurrentFillLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_CurrentFillLevel)) = value;
			}
		}

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600B9BD RID: 47549 RVA: 0x002FD9D0 File Offset: 0x002FBBD0
		// (set) Token: 0x0600B9BE RID: 47550 RVA: 0x000567AE File Offset: 0x000549AE
		public unsafe WorldspacePopupUI UIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600B9BF RID: 47551 RVA: 0x002FDA00 File Offset: 0x002FBC00
		// (set) Token: 0x0600B9C0 RID: 47552 RVA: 0x000567CD File Offset: 0x000549CD
		public unsafe bool DisplayOnHUD
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_DisplayOnHUD)) = value;
			}
		}

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600B9C1 RID: 47553 RVA: 0x002FDA28 File Offset: 0x002FBC28
		// (set) Token: 0x0600B9C2 RID: 47554 RVA: 0x000567E8 File Offset: 0x000549E8
		public unsafe bool ScaleWithDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_ScaleWithDistance)) = value;
			}
		}

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600B9C3 RID: 47555 RVA: 0x002FDA50 File Offset: 0x002FBC50
		// (set) Token: 0x0600B9C4 RID: 47556 RVA: 0x00056803 File Offset: 0x00054A03
		public unsafe Vector3 WorldspaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceOffset)) = value;
			}
		}

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600B9C5 RID: 47557 RVA: 0x002FDA78 File Offset: 0x002FBC78
		// (set) Token: 0x0600B9C6 RID: 47558 RVA: 0x0005681E File Offset: 0x00054A1E
		public unsafe float Range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_Range)) = value;
			}
		}

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600B9C7 RID: 47559 RVA: 0x002FDAA0 File Offset: 0x002FBCA0
		// (set) Token: 0x0600B9C8 RID: 47560 RVA: 0x00056839 File Offset: 0x00054A39
		public unsafe float SizeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_SizeMultiplier)) = value;
			}
		}

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600B9C9 RID: 47561 RVA: 0x002FDAC8 File Offset: 0x002FBCC8
		// (set) Token: 0x0600B9CA RID: 47562 RVA: 0x00056854 File Offset: 0x00054A54
		public unsafe WorldspacePopupUI WorldspaceUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_WorldspaceUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600B9CB RID: 47563 RVA: 0x002FDAF8 File Offset: 0x002FBCF8
		// (set) Token: 0x0600B9CC RID: 47564 RVA: 0x00056873 File Offset: 0x00054A73
		public unsafe RectTransform HUDUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600B9CD RID: 47565 RVA: 0x002FDB28 File Offset: 0x002FBD28
		// (set) Token: 0x0600B9CE RID: 47566 RVA: 0x00056892 File Offset: 0x00054A92
		public unsafe WorldspacePopupUI HUDUIIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUIIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600B9CF RID: 47567 RVA: 0x002FDB58 File Offset: 0x002FBD58
		// (set) Token: 0x0600B9D0 RID: 47568 RVA: 0x000568B1 File Offset: 0x00054AB1
		public unsafe CanvasGroup HUDUICanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_HUDUICanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600B9D1 RID: 47569 RVA: 0x002FDB88 File Offset: 0x002FBD88
		// (set) Token: 0x0600B9D2 RID: 47570 RVA: 0x000568D0 File Offset: 0x00054AD0
		public unsafe List<WorldspacePopupUI> UIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_UIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600B9D3 RID: 47571 RVA: 0x002FDBB8 File Offset: 0x002FBDB8
		// (set) Token: 0x0600B9D4 RID: 47572 RVA: 0x000568EF File Offset: 0x00054AEF
		public unsafe Coroutine popupCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.NativeFieldInfoPtr_popupCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F5E RID: 32606
		private static readonly IntPtr NativeFieldInfoPtr_ActivePopups;

		// Token: 0x04007F5F RID: 32607
		private static readonly IntPtr NativeFieldInfoPtr_CurrentFillLevel;

		// Token: 0x04007F60 RID: 32608
		private static readonly IntPtr NativeFieldInfoPtr_UIPrefab;

		// Token: 0x04007F61 RID: 32609
		private static readonly IntPtr NativeFieldInfoPtr_DisplayOnHUD;

		// Token: 0x04007F62 RID: 32610
		private static readonly IntPtr NativeFieldInfoPtr_ScaleWithDistance;

		// Token: 0x04007F63 RID: 32611
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceOffset;

		// Token: 0x04007F64 RID: 32612
		private static readonly IntPtr NativeFieldInfoPtr_Range;

		// Token: 0x04007F65 RID: 32613
		private static readonly IntPtr NativeFieldInfoPtr_SizeMultiplier;

		// Token: 0x04007F66 RID: 32614
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceUI;

		// Token: 0x04007F67 RID: 32615
		private static readonly IntPtr NativeFieldInfoPtr_HUDUI;

		// Token: 0x04007F68 RID: 32616
		private static readonly IntPtr NativeFieldInfoPtr_HUDUIIcon;

		// Token: 0x04007F69 RID: 32617
		private static readonly IntPtr NativeFieldInfoPtr_HUDUICanvasGroup;

		// Token: 0x04007F6A RID: 32618
		private static readonly IntPtr NativeFieldInfoPtr_UIs;

		// Token: 0x04007F6B RID: 32619
		private static readonly IntPtr NativeFieldInfoPtr_popupCoroutine;

		// Token: 0x04007F6C RID: 32620
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007F6D RID: 32621
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04007F6E RID: 32622
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Public_WorldspacePopupUI_RectTransform_0;

		// Token: 0x04007F6F RID: 32623
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007F70 RID: 32624
		private static readonly IntPtr NativeMethodInfoPtr_Popup_Public_Void_0;

		// Token: 0x04007F71 RID: 32625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007F72 RID: 32626
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000D01 RID: 3329
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<<Popup>g__PopupCoroutine|18_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F757 RID: 63319 RVA: 0x003B4B04 File Offset: 0x003B2D04
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique()
			{
				Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<<Popup>g__PopupCoroutine|18_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687569);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687570);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687571);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687572);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687573);
				WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr, 100687574);
			}

			// Token: 0x0600F758 RID: 63320 RVA: 0x003B4C0C File Offset: 0x003B2E0C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F759 RID: 63321 RVA: 0x003B4C54 File Offset: 0x003B2E54
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F75A RID: 63322 RVA: 0x003B4C88 File Offset: 0x003B2E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310121, XrefRangeEnd = 310125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B3D RID: 19261
			// (get) Token: 0x0600F75B RID: 63323 RVA: 0x003B4CC4 File Offset: 0x003B2EC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F75C RID: 63324 RVA: 0x003B4D04 File Offset: 0x003B2F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310125, XrefRangeEnd = 310130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B3E RID: 19262
			// (get) Token: 0x0600F75D RID: 63325 RVA: 0x003B4D38 File Offset: 0x003B2F38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F75E RID: 63326 RVA: 0x00074F61 File Offset: 0x00073161
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B38 RID: 19256
			// (get) Token: 0x0600F75F RID: 63327 RVA: 0x003B4D78 File Offset: 0x003B2F78
			// (set) Token: 0x0600F760 RID: 63328 RVA: 0x00074F6A File Offset: 0x0007316A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B39 RID: 19257
			// (get) Token: 0x0600F761 RID: 63329 RVA: 0x003B4DA0 File Offset: 0x003B2FA0
			// (set) Token: 0x0600F762 RID: 63330 RVA: 0x00074F85 File Offset: 0x00073185
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B3A RID: 19258
			// (get) Token: 0x0600F763 RID: 63331 RVA: 0x003B4DD0 File Offset: 0x003B2FD0
			// (set) Token: 0x0600F764 RID: 63332 RVA: 0x00074FA4 File Offset: 0x000731A4
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B3B RID: 19259
			// (get) Token: 0x0600F765 RID: 63333 RVA: 0x003B4E00 File Offset: 0x003B3000
			// (set) Token: 0x0600F766 RID: 63334 RVA: 0x00074FC3 File Offset: 0x000731C3
			public unsafe float _lerpTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x17004B3C RID: 19260
			// (get) Token: 0x0600F767 RID: 63335 RVA: 0x003B4E28 File Offset: 0x003B3028
			// (set) Token: 0x0600F768 RID: 63336 RVA: 0x00074FDE File Offset: 0x000731DE
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400A748 RID: 42824
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A749 RID: 42825
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A74A RID: 42826
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A74B RID: 42827
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x0400A74C RID: 42828
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400A74D RID: 42829
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A74E RID: 42830
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A74F RID: 42831
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A750 RID: 42832
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A751 RID: 42833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A752 RID: 42834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D02 RID: 3330
		[ObfuscatedName("ScheduleOne.UI.WorldspacePopup.WorldspacePopup+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F769 RID: 63337 RVA: 0x003B4E50 File Offset: 0x003B3050
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspacePopup>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr);
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, "newUI");
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100687575);
				WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr, 100687576);
			}

			// Token: 0x0600F76A RID: 63338 RVA: 0x003B4ECC File Offset: 0x003B30CC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopup.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F76B RID: 63339 RVA: 0x003B4F08 File Offset: 0x003B3108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310130, XrefRangeEnd = 310134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopup.__c__DisplayClass16_0.NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F76C RID: 63340 RVA: 0x00074FF9 File Offset: 0x000731F9
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B3F RID: 19263
			// (get) Token: 0x0600F76D RID: 63341 RVA: 0x003B4F3C File Offset: 0x003B313C
			// (set) Token: 0x0600F76E RID: 63342 RVA: 0x00075002 File Offset: 0x00073202
			public unsafe WorldspacePopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B40 RID: 19264
			// (get) Token: 0x0600F76F RID: 63343 RVA: 0x003B4F6C File Offset: 0x003B316C
			// (set) Token: 0x0600F770 RID: 63344 RVA: 0x00075021 File Offset: 0x00073221
			public unsafe WorldspacePopupUI newUI
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopup.__c__DisplayClass16_0.NativeFieldInfoPtr_newUI), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A753 RID: 42835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A754 RID: 42836
			private static readonly IntPtr NativeFieldInfoPtr_newUI;

			// Token: 0x0400A755 RID: 42837
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A756 RID: 42838
			private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__0_Internal_Void_0;
		}
	}
}
