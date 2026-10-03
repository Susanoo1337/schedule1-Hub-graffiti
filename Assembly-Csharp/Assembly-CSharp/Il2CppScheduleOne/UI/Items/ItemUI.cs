using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200082B RID: 2091
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x0600CB14 RID: 51988 RVA: 0x003328D0 File Offset: 0x00330AD0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI()
		{
			Il2CppClassPointerStore<ItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI>.NativeClassPtr);
			ItemUI.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "itemInstance");
			ItemUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Rect");
			ItemUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "IconImg");
			ItemUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "QuantityLabel");
			ItemUI.NativeFieldInfoPtr_DisplayedQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "DisplayedQuantity");
			ItemUI.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Destroyed");
			ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689480);
			ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689481);
			ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689482);
			ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689483);
			ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689484);
			ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689485);
			ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100689486);
		}

		// Token: 0x0600CB15 RID: 51989 RVA: 0x00332A04 File Offset: 0x00330C04
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 333275, RefRangeEnd = 333280, XrefRangeStart = 333258, XrefRangeEnd = 333275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB16 RID: 51990 RVA: 0x00332A54 File Offset: 0x00330C54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333280, XrefRangeEnd = 333292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB17 RID: 51991 RVA: 0x00332A90 File Offset: 0x00330C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333292, XrefRangeEnd = 333305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600CB18 RID: 51992 RVA: 0x00332AFC File Offset: 0x00330CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB19 RID: 51993 RVA: 0x00332B48 File Offset: 0x00330D48
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 333306, RefRangeEnd = 333312, XrefRangeStart = 333305, XrefRangeEnd = 333306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB1A RID: 51994 RVA: 0x00332B84 File Offset: 0x00330D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333312, XrefRangeEnd = 333315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB1B RID: 51995 RVA: 0x00332BD0 File Offset: 0x00330DD0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CB1C RID: 51996 RVA: 0x0006058B File Offset: 0x0005E78B
		public ItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x0600CB1D RID: 51997 RVA: 0x00332C0C File Offset: 0x00330E0C
		// (set) Token: 0x0600CB1E RID: 51998 RVA: 0x00060594 File Offset: 0x0005E794
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x0600CB1F RID: 51999 RVA: 0x00332C3C File Offset: 0x00330E3C
		// (set) Token: 0x0600CB20 RID: 52000 RVA: 0x000605B3 File Offset: 0x0005E7B3
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600CB21 RID: 52001 RVA: 0x00332C6C File Offset: 0x00330E6C
		// (set) Token: 0x0600CB22 RID: 52002 RVA: 0x000605D2 File Offset: 0x0005E7D2
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x00332C9C File Offset: 0x00330E9C
		// (set) Token: 0x0600CB24 RID: 52004 RVA: 0x000605F1 File Offset: 0x0005E7F1
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x00332CCC File Offset: 0x00330ECC
		// (set) Token: 0x0600CB26 RID: 52006 RVA: 0x00060610 File Offset: 0x0005E810
		public unsafe int DisplayedQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity)) = value;
			}
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600CB27 RID: 52007 RVA: 0x00332CF4 File Offset: 0x00330EF4
		// (set) Token: 0x0600CB28 RID: 52008 RVA: 0x0006062B File Offset: 0x0005E82B
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x04008A3F RID: 35391
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04008A40 RID: 35392
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04008A41 RID: 35393
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04008A42 RID: 35394
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04008A43 RID: 35395
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedQuantity;

		// Token: 0x04008A44 RID: 35396
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x04008A45 RID: 35397
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04008A46 RID: 35398
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04008A47 RID: 35399
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0;

		// Token: 0x04008A48 RID: 35400
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04008A49 RID: 35401
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04008A4A RID: 35402
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04008A4B RID: 35403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
