using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000775 RID: 1909
	public class WorldspacePopupCanvas : MonoBehaviour
	{
		// Token: 0x0600B9D5 RID: 47573 RVA: 0x002FDBE8 File Offset: 0x002FBDE8
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupCanvas()
		{
			Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr);
			WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WORLDSPACE_ICON_SCALE_MULTIPLIER");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMaxOpacityAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HUDIconMaxOpacityAngle");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMinOpacityAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HUDIconMinOpacityAngle");
			WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "WorldspaceContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudContainer");
			WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "HudIconContainerPrefab");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeWorldspaceUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "activeHUDUIs");
			WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, "popupsWithUI");
			WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687577);
			WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687578);
			WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687579);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687580);
			WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687581);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687582);
			WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687583);
			WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr, 100687584);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x002FDD6C File Offset: 0x002FBF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310228, XrefRangeEnd = 310340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9D7 RID: 47575 RVA: 0x002FDDA0 File Offset: 0x002FBFA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310340, XrefRangeEnd = 310437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x002FDDD4 File Offset: 0x002FBFD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310450, RefRangeEnd = 310452, XrefRangeStart = 310437, XrefRangeEnd = 310450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldCreateUI(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x002FDE24 File Offset: 0x002FC024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310452, XrefRangeEnd = 310464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI CreateWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WorldspacePopupUI>(intPtr3) : null;
		}

		// Token: 0x0600B9DA RID: 47578 RVA: 0x002FDE74 File Offset: 0x002FC074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310490, RefRangeEnd = 310491, XrefRangeStart = 310464, XrefRangeEnd = 310490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectTransform CreateHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600B9DB RID: 47579 RVA: 0x002FDEC4 File Offset: 0x002FC0C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310491, XrefRangeEnd = 310509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyWorldspaceIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x002FDF08 File Offset: 0x002FC108
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310535, RefRangeEnd = 310536, XrefRangeStart = 310509, XrefRangeEnd = 310535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyHUDIcon(WorldspacePopup popup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(popup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9DD RID: 47581 RVA: 0x002FDF4C File Offset: 0x002FC14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310536, XrefRangeEnd = 310558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9DE RID: 47582 RVA: 0x0005690E File Offset: 0x00054B0E
		public WorldspacePopupCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002FDF88 File Offset: 0x002FC188
		// (set) Token: 0x0600B9E0 RID: 47584 RVA: 0x00056917 File Offset: 0x00054B17
		public unsafe static float WORLDSPACE_ICON_SCALE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002FDFA4 File Offset: 0x002FC1A4
		// (set) Token: 0x0600B9E2 RID: 47586 RVA: 0x00056925 File Offset: 0x00054B25
		public unsafe static float HUDIconMaxOpacityAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMaxOpacityAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMaxOpacityAngle, (void*)(&value));
			}
		}

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600B9E3 RID: 47587 RVA: 0x002FDFC0 File Offset: 0x002FC1C0
		// (set) Token: 0x0600B9E4 RID: 47588 RVA: 0x00056933 File Offset: 0x00054B33
		public unsafe static float HUDIconMinOpacityAngle
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMinOpacityAngle, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspacePopupCanvas.NativeFieldInfoPtr_HUDIconMinOpacityAngle, (void*)(&value));
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600B9E5 RID: 47589 RVA: 0x002FDFDC File Offset: 0x002FC1DC
		// (set) Token: 0x0600B9E6 RID: 47590 RVA: 0x00056941 File Offset: 0x00054B41
		public unsafe RectTransform WorldspaceContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_WorldspaceContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x002FE00C File Offset: 0x002FC20C
		// (set) Token: 0x0600B9E8 RID: 47592 RVA: 0x00056960 File Offset: 0x00054B60
		public unsafe RectTransform HudContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600B9E9 RID: 47593 RVA: 0x002FE03C File Offset: 0x002FC23C
		// (set) Token: 0x0600B9EA RID: 47594 RVA: 0x0005697F File Offset: 0x00054B7F
		public unsafe GameObject HudIconContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_HudIconContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x002FE06C File Offset: 0x002FC26C
		// (set) Token: 0x0600B9EC RID: 47596 RVA: 0x0005699E File Offset: 0x00054B9E
		public unsafe List<WorldspacePopupUI> activeWorldspaceUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopupUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeWorldspaceUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x002FE09C File Offset: 0x002FC29C
		// (set) Token: 0x0600B9EE RID: 47598 RVA: 0x000569BD File Offset: 0x00054BBD
		public unsafe List<RectTransform> activeHUDUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_activeHUDUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x002FE0CC File Offset: 0x002FC2CC
		// (set) Token: 0x0600B9F0 RID: 47600 RVA: 0x000569DC File Offset: 0x00054BDC
		public unsafe List<WorldspacePopup> popupsWithUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldspacePopup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupCanvas.NativeFieldInfoPtr_popupsWithUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F73 RID: 32627
		private static readonly IntPtr NativeFieldInfoPtr_WORLDSPACE_ICON_SCALE_MULTIPLIER;

		// Token: 0x04007F74 RID: 32628
		private static readonly IntPtr NativeFieldInfoPtr_HUDIconMaxOpacityAngle;

		// Token: 0x04007F75 RID: 32629
		private static readonly IntPtr NativeFieldInfoPtr_HUDIconMinOpacityAngle;

		// Token: 0x04007F76 RID: 32630
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceContainer;

		// Token: 0x04007F77 RID: 32631
		private static readonly IntPtr NativeFieldInfoPtr_HudContainer;

		// Token: 0x04007F78 RID: 32632
		private static readonly IntPtr NativeFieldInfoPtr_HudIconContainerPrefab;

		// Token: 0x04007F79 RID: 32633
		private static readonly IntPtr NativeFieldInfoPtr_activeWorldspaceUIs;

		// Token: 0x04007F7A RID: 32634
		private static readonly IntPtr NativeFieldInfoPtr_activeHUDUIs;

		// Token: 0x04007F7B RID: 32635
		private static readonly IntPtr NativeFieldInfoPtr_popupsWithUI;

		// Token: 0x04007F7C RID: 32636
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007F7D RID: 32637
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007F7E RID: 32638
		private static readonly IntPtr NativeMethodInfoPtr_ShouldCreateUI_Private_Boolean_WorldspacePopup_0;

		// Token: 0x04007F7F RID: 32639
		private static readonly IntPtr NativeMethodInfoPtr_CreateWorldspaceIcon_Private_WorldspacePopupUI_WorldspacePopup_0;

		// Token: 0x04007F80 RID: 32640
		private static readonly IntPtr NativeMethodInfoPtr_CreateHUDIcon_Private_RectTransform_WorldspacePopup_0;

		// Token: 0x04007F81 RID: 32641
		private static readonly IntPtr NativeMethodInfoPtr_DestroyWorldspaceIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x04007F82 RID: 32642
		private static readonly IntPtr NativeMethodInfoPtr_DestroyHUDIcon_Private_Void_WorldspacePopup_0;

		// Token: 0x04007F83 RID: 32643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
