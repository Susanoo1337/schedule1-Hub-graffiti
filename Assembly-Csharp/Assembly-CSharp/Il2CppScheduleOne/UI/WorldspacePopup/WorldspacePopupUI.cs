using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.WorldspacePopup
{
	// Token: 0x02000776 RID: 1910
	public class WorldspacePopupUI : MonoBehaviour
	{
		// Token: 0x0600B9F1 RID: 47601 RVA: 0x002FE0FC File Offset: 0x002FC2FC
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspacePopupUI()
		{
			Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.WorldspacePopup", "WorldspacePopupUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr);
			WorldspacePopupUI.NativeFieldInfoPtr_Popup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Popup");
			WorldspacePopupUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "Rect");
			WorldspacePopupUI.NativeFieldInfoPtr_FillImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "FillImage");
			WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, "onDestroyed");
			WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100687585);
			WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100687586);
			WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr, 100687587);
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x002FE1B8 File Offset: 0x002FC3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310558, XrefRangeEnd = 310560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFill(float fill)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fill;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_SetFill_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x002FE1F8 File Offset: 0x002FC3F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310566, RefRangeEnd = 310569, XrefRangeStart = 310560, XrefRangeEnd = 310566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x002FE22C File Offset: 0x002FC42C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspacePopupUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspacePopupUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspacePopupUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x000569FB File Offset: 0x00054BFB
		public WorldspacePopupUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600B9F6 RID: 47606 RVA: 0x002FE268 File Offset: 0x002FC468
		// (set) Token: 0x0600B9F7 RID: 47607 RVA: 0x00056A04 File Offset: 0x00054C04
		public unsafe WorldspacePopup Popup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspacePopup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Popup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600B9F8 RID: 47608 RVA: 0x002FE298 File Offset: 0x002FC498
		// (set) Token: 0x0600B9F9 RID: 47609 RVA: 0x00056A23 File Offset: 0x00054C23
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600B9FA RID: 47610 RVA: 0x002FE2C8 File Offset: 0x002FC4C8
		// (set) Token: 0x0600B9FB RID: 47611 RVA: 0x00056A42 File Offset: 0x00054C42
		public unsafe Image FillImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_FillImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600B9FC RID: 47612 RVA: 0x002FE2F8 File Offset: 0x002FC4F8
		// (set) Token: 0x0600B9FD RID: 47613 RVA: 0x00056A61 File Offset: 0x00054C61
		public unsafe UnityEvent onDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspacePopupUI.NativeFieldInfoPtr_onDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007F84 RID: 32644
		private static readonly IntPtr NativeFieldInfoPtr_Popup;

		// Token: 0x04007F85 RID: 32645
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04007F86 RID: 32646
		private static readonly IntPtr NativeFieldInfoPtr_FillImage;

		// Token: 0x04007F87 RID: 32647
		private static readonly IntPtr NativeFieldInfoPtr_onDestroyed;

		// Token: 0x04007F88 RID: 32648
		private static readonly IntPtr NativeMethodInfoPtr_SetFill_Public_Void_Single_0;

		// Token: 0x04007F89 RID: 32649
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04007F8A RID: 32650
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
