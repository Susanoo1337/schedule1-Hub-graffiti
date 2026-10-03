using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.UI.Input;
using UnityEngine.EventSystems;

namespace Il2CppScheduleOne.CustomUI
{
	// Token: 0x02000842 RID: 2114
	public class UISelectable_ItemSlot : UISelectable
	{
		// Token: 0x0600CE05 RID: 52741 RVA: 0x0033C290 File Offset: 0x0033A490
		// Note: this type is marked as 'beforefieldinit'.
		static UISelectable_ItemSlot()
		{
			Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.CustomUI", "UISelectable_ItemSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr);
			UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, "_itemSlotUI");
			UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotInputPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, "_itemSlotInputPrompts");
			UISelectable_ItemSlot.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689826);
			UISelectable_ItemSlot.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689827);
			UISelectable_ItemSlot.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689828);
			UISelectable_ItemSlot.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689829);
			UISelectable_ItemSlot.NativeMethodInfoPtr_CanInteractWithSlot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689830);
			UISelectable_ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689831);
			UISelectable_ItemSlot.NativeMethodInfoPtr__Awake_b__2_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689832);
			UISelectable_ItemSlot.NativeMethodInfoPtr__Awake_b__2_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr, 100689833);
		}

		// Token: 0x0600CE06 RID: 52742 RVA: 0x0033C388 File Offset: 0x0033A588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337126, XrefRangeEnd = 337145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_ItemSlot.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE07 RID: 52743 RVA: 0x0033C3C4 File Offset: 0x0033A5C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337146, RefRangeEnd = 337147, XrefRangeStart = 337145, XrefRangeEnd = 337146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeSelectedWhileDraggingItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_ItemSlot.NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CE08 RID: 52744 RVA: 0x0033C40C File Offset: 0x0033A60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337147, XrefRangeEnd = 337165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSelect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_ItemSlot.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE09 RID: 52745 RVA: 0x0033C45C File Offset: 0x0033A65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337165, XrefRangeEnd = 337178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDeselect(BaseEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UISelectable_ItemSlot.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE0A RID: 52746 RVA: 0x0033C4AC File Offset: 0x0033A6AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337178, XrefRangeEnd = 337183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteractWithSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ItemSlot.NativeMethodInfoPtr_CanInteractWithSlot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CE0B RID: 52747 RVA: 0x0033C4E8 File Offset: 0x0033A6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 84806, RefRangeEnd = 84807, XrefRangeStart = 84806, XrefRangeEnd = 84807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISelectable_ItemSlot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISelectable_ItemSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ItemSlot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE0C RID: 52748 RVA: 0x0033C524 File Offset: 0x0033A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337183, XrefRangeEnd = 337185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__2_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ItemSlot.NativeMethodInfoPtr__Awake_b__2_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE0D RID: 52749 RVA: 0x0033C558 File Offset: 0x0033A758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337185, XrefRangeEnd = 337187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__2_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISelectable_ItemSlot.NativeMethodInfoPtr__Awake_b__2_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CE0E RID: 52750 RVA: 0x00061E4B File Offset: 0x0006004B
		public UISelectable_ItemSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x0600CE0F RID: 52751 RVA: 0x0033C58C File Offset: 0x0033A78C
		// (set) Token: 0x0600CE10 RID: 52752 RVA: 0x00061E54 File Offset: 0x00060054
		public unsafe ItemSlotUI _itemSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600CE11 RID: 52753 RVA: 0x0033C5BC File Offset: 0x0033A7BC
		// (set) Token: 0x0600CE12 RID: 52754 RVA: 0x00061E73 File Offset: 0x00060073
		public unsafe InputPromptsData _itemSlotInputPrompts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotInputPrompts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISelectable_ItemSlot.NativeFieldInfoPtr__itemSlotInputPrompts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008C47 RID: 35911
		private static readonly IntPtr NativeFieldInfoPtr__itemSlotUI;

		// Token: 0x04008C48 RID: 35912
		private static readonly IntPtr NativeFieldInfoPtr__itemSlotInputPrompts;

		// Token: 0x04008C49 RID: 35913
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04008C4A RID: 35914
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelectedWhileDraggingItem_Protected_Virtual_Boolean_0;

		// Token: 0x04008C4B RID: 35915
		private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04008C4C RID: 35916
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;

		// Token: 0x04008C4D RID: 35917
		private static readonly IntPtr NativeMethodInfoPtr_CanInteractWithSlot_Private_Boolean_0;

		// Token: 0x04008C4E RID: 35918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008C4F RID: 35919
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_0_Private_Void_0;

		// Token: 0x04008C50 RID: 35920
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__2_1_Private_Void_0;
	}
}
