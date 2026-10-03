using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082A RID: 2090
	public class ItemSlotFilterButton : MonoBehaviour
	{
		// Token: 0x0600CAFC RID: 51964 RVA: 0x00332450 File Offset: 0x00330650
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotFilterButton()
		{
			Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemSlotFilterButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr);
			ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "<AssignedSlot>k__BackingField");
			ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "ItemSlotUI");
			ItemSlotFilterButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "Button");
			ItemSlotFilterButton.NativeFieldInfoPtr_IconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "IconImage");
			ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "SpotImage");
			ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "FilterItemImages");
			ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, "FilterMoreItemsLabel");
			ItemSlotFilterButton.NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689472);
			ItemSlotFilterButton.NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689473);
			ItemSlotFilterButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689474);
			ItemSlotFilterButton.NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689475);
			ItemSlotFilterButton.NativeMethodInfoPtr_UnassignSlot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689476);
			ItemSlotFilterButton.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689477);
			ItemSlotFilterButton.NativeMethodInfoPtr_RefreshAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689478);
			ItemSlotFilterButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr, 100689479);
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x0600CAFD RID: 51965 RVA: 0x003325AC File Offset: 0x003307AC
		// (set) Token: 0x0600CAFE RID: 51966 RVA: 0x003325EC File Offset: 0x003307EC
		public unsafe ItemSlot AssignedSlot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CAFF RID: 51967 RVA: 0x00332630 File Offset: 0x00330830
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x00332664 File Offset: 0x00330864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333216, RefRangeEnd = 333217, XrefRangeStart = 333158, XrefRangeEnd = 333216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignSlot(ItemSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB01 RID: 51969 RVA: 0x003326A8 File Offset: 0x003308A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333231, RefRangeEnd = 333232, XrefRangeStart = 333217, XrefRangeEnd = 333231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnassignSlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_UnassignSlot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB02 RID: 51970 RVA: 0x003326DC File Offset: 0x003308DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333232, XrefRangeEnd = 333241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB03 RID: 51971 RVA: 0x00332710 File Offset: 0x00330910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333241, XrefRangeEnd = 333258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr_RefreshAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB04 RID: 51972 RVA: 0x00332744 File Offset: 0x00330944
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotFilterButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotFilterButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotFilterButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB05 RID: 51973 RVA: 0x000604A9 File Offset: 0x0005E6A9
		public ItemSlotFilterButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x0600CB06 RID: 51974 RVA: 0x00332780 File Offset: 0x00330980
		// (set) Token: 0x0600CB07 RID: 51975 RVA: 0x000604B2 File Offset: 0x0005E6B2
		public unsafe ItemSlot _AssignedSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr__AssignedSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x0600CB08 RID: 51976 RVA: 0x003327B0 File Offset: 0x003309B0
		// (set) Token: 0x0600CB09 RID: 51977 RVA: 0x000604D1 File Offset: 0x0005E6D1
		public unsafe ItemSlotUI ItemSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_ItemSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x0600CB0A RID: 51978 RVA: 0x003327E0 File Offset: 0x003309E0
		// (set) Token: 0x0600CB0B RID: 51979 RVA: 0x000604F0 File Offset: 0x0005E6F0
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x0600CB0C RID: 51980 RVA: 0x00332810 File Offset: 0x00330A10
		// (set) Token: 0x0600CB0D RID: 51981 RVA: 0x0006050F File Offset: 0x0005E70F
		public unsafe Image IconImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_IconImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_IconImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x0600CB0E RID: 51982 RVA: 0x00332840 File Offset: 0x00330A40
		// (set) Token: 0x0600CB0F RID: 51983 RVA: 0x0006052E File Offset: 0x0005E72E
		public unsafe Image SpotImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_SpotImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x0600CB10 RID: 51984 RVA: 0x00332870 File Offset: 0x00330A70
		// (set) Token: 0x0600CB11 RID: 51985 RVA: 0x0006054D File Offset: 0x0005E74D
		public unsafe Il2CppReferenceArray<Image> FilterItemImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterItemImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x0600CB12 RID: 51986 RVA: 0x003328A0 File Offset: 0x00330AA0
		// (set) Token: 0x0600CB13 RID: 51987 RVA: 0x0006056C File Offset: 0x0005E76C
		public unsafe TextMeshProUGUI FilterMoreItemsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotFilterButton.NativeFieldInfoPtr_FilterMoreItemsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008A30 RID: 35376
		private static readonly IntPtr NativeFieldInfoPtr__AssignedSlot_k__BackingField;

		// Token: 0x04008A31 RID: 35377
		private static readonly IntPtr NativeFieldInfoPtr_ItemSlotUI;

		// Token: 0x04008A32 RID: 35378
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04008A33 RID: 35379
		private static readonly IntPtr NativeFieldInfoPtr_IconImage;

		// Token: 0x04008A34 RID: 35380
		private static readonly IntPtr NativeFieldInfoPtr_SpotImage;

		// Token: 0x04008A35 RID: 35381
		private static readonly IntPtr NativeFieldInfoPtr_FilterItemImages;

		// Token: 0x04008A36 RID: 35382
		private static readonly IntPtr NativeFieldInfoPtr_FilterMoreItemsLabel;

		// Token: 0x04008A37 RID: 35383
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedSlot_Public_get_ItemSlot_0;

		// Token: 0x04008A38 RID: 35384
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedSlot_Protected_set_Void_ItemSlot_0;

		// Token: 0x04008A39 RID: 35385
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008A3A RID: 35386
		private static readonly IntPtr NativeMethodInfoPtr_AssignSlot_Public_Void_ItemSlot_0;

		// Token: 0x04008A3B RID: 35387
		private static readonly IntPtr NativeMethodInfoPtr_UnassignSlot_Public_Void_0;

		// Token: 0x04008A3C RID: 35388
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x04008A3D RID: 35389
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAppearance_Private_Void_0;

		// Token: 0x04008A3E RID: 35390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
