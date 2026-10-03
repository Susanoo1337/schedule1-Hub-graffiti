using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GamepadInput;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200083A RID: 2106
	public class ListingUI : MonoBehaviour
	{
		// Token: 0x0600CC73 RID: 52339 RVA: 0x003375C4 File Offset: 0x003357C4
		// Note: this type is marked as 'beforefieldinit'.
		static ListingUI()
		{
			Il2CppClassPointerStore<ListingUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ListingUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListingUI>.NativeClassPtr);
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_Normal");
			ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabelColor_NoStock");
			ListingUI.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "<Listing>k__BackingField");
			ListingUI.NativeFieldInfoPtr_StockLabelDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelDefault");
			ListingUI.NativeFieldInfoPtr_StockLabelNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabelNone");
			ListingUI.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Icon");
			ListingUI.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "NameLabel");
			ListingUI.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "PriceLabel");
			ListingUI.NativeFieldInfoPtr_StockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "StockLabel");
			ListingUI.NativeFieldInfoPtr_LockedContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "LockedContainer");
			ListingUI.NativeFieldInfoPtr_BuyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "BuyButton");
			ListingUI.NativeFieldInfoPtr_DropdownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownButton");
			ListingUI.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Trigger");
			ListingUI.NativeFieldInfoPtr_DetailPanelAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DetailPanelAnchor");
			ListingUI.NativeFieldInfoPtr_DropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "DropdownAnchor");
			ListingUI.NativeFieldInfoPtr_TopDropdownAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "TopDropdownAnchor");
			ListingUI.NativeFieldInfoPtr_AddItemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "AddItemButton");
			ListingUI.NativeFieldInfoPtr_RemoveItemButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "RemoveItemButton");
			ListingUI.NativeFieldInfoPtr_ItemAmountInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "ItemAmountInput");
			ListingUI.NativeFieldInfoPtr_Selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "Selectable");
			ListingUI.NativeFieldInfoPtr__inputValueRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "_inputValueRamp");
			ListingUI.NativeFieldInfoPtr_hoverStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverStart");
			ListingUI.NativeFieldInfoPtr_hoverEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "hoverEnd");
			ListingUI.NativeFieldInfoPtr_onClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onClicked");
			ListingUI.NativeFieldInfoPtr_onDropdownClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onDropdownClicked");
			ListingUI.NativeFieldInfoPtr_onSetAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onSetAmount");
			ListingUI.NativeFieldInfoPtr_onAdjustAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onAdjustAmount");
			ListingUI.NativeFieldInfoPtr_onAddItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onAddItem");
			ListingUI.NativeFieldInfoPtr_onRemoveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, "onRemoveItem");
			ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689650);
			ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689651);
			ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689652);
			ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689653);
			ListingUI.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689654);
			ListingUI.NativeMethodInfoPtr_AddItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689655);
			ListingUI.NativeMethodInfoPtr_RemoveItem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689656);
			ListingUI.NativeMethodInfoPtr_SetAmount_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689657);
			ListingUI.NativeMethodInfoPtr_AdjustAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689658);
			ListingUI.NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689659);
			ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689660);
			ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689661);
			ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689662);
			ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689663);
			ListingUI.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689664);
			ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689665);
			ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689666);
			ListingUI.NativeMethodInfoPtr_UpdateQuantityInCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689667);
			ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689668);
			ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689669);
			ListingUI.NativeMethodInfoPtr_CanRemoveFromCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689670);
			ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689671);
			ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689672);
			ListingUI.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689674);
			ListingUI.NativeMethodInfoPtr__Initialize_b__32_1_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689675);
			ListingUI.NativeMethodInfoPtr__Initialize_b__32_2_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689676);
			ListingUI.NativeMethodInfoPtr__Initialize_b__32_3_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689677);
			ListingUI.NativeMethodInfoPtr__Initialize_b__32_4_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListingUI>.NativeClassPtr, 100689678);
		}

		// Token: 0x17003E31 RID: 15921
		// (get) Token: 0x0600CC74 RID: 52340 RVA: 0x00337A68 File Offset: 0x00335C68
		// (set) Token: 0x0600CC75 RID: 52341 RVA: 0x00337AA8 File Offset: 0x00335CA8
		public unsafe ShopListing Listing
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CC76 RID: 52342 RVA: 0x00337AEC File Offset: 0x00335CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335383, XrefRangeEnd = 335510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC77 RID: 52343 RVA: 0x00337B3C File Offset: 0x00335D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335510, XrefRangeEnd = 335521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform GetIconCopy(RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ListingUI.NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600CC78 RID: 52344 RVA: 0x00337B98 File Offset: 0x00335D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335521, XrefRangeEnd = 335525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC79 RID: 52345 RVA: 0x00337BCC File Offset: 0x00335DCC
		[CallerCount(0)]
		public unsafe void AddItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_AddItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7A RID: 52346 RVA: 0x00337C00 File Offset: 0x00335E00
		[CallerCount(0)]
		public unsafe void RemoveItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_RemoveItem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7B RID: 52347 RVA: 0x00337C34 File Offset: 0x00335E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335525, XrefRangeEnd = 335526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAmount(string amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(amount);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_SetAmount_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7C RID: 52348 RVA: 0x00337C78 File Offset: 0x00335E78
		[CallerCount(0)]
		public unsafe void AdjustAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_AdjustAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7D RID: 52349 RVA: 0x00337CB8 File Offset: 0x00335EB8
		[CallerCount(0)]
		public unsafe void SetAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7E RID: 52350 RVA: 0x00337CF8 File Offset: 0x00335EF8
		[CallerCount(0)]
		public unsafe void DropdownClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_DropdownClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC7F RID: 52351 RVA: 0x00337D2C File Offset: 0x00335F2C
		[CallerCount(0)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC80 RID: 52352 RVA: 0x00337D60 File Offset: 0x00335F60
		[CallerCount(0)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_HoverEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC81 RID: 52353 RVA: 0x00337D94 File Offset: 0x00335F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335526, XrefRangeEnd = 335531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StockChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_StockChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC82 RID: 52354 RVA: 0x00337DC8 File Offset: 0x00335FC8
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC83 RID: 52355 RVA: 0x00337DFC File Offset: 0x00335FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335540, RefRangeEnd = 335542, XrefRangeStart = 335531, XrefRangeEnd = 335540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC84 RID: 52356 RVA: 0x00337E30 File Offset: 0x00336030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335559, RefRangeEnd = 335561, XrefRangeStart = 335542, XrefRangeEnd = 335559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateStock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateStock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC85 RID: 52357 RVA: 0x00337E64 File Offset: 0x00336064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335561, XrefRangeEnd = 335563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateQuantityInCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateQuantityInCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC86 RID: 52358 RVA: 0x00337E98 File Offset: 0x00336098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 335569, RefRangeEnd = 335571, XrefRangeStart = 335563, XrefRangeEnd = 335569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC87 RID: 52359 RVA: 0x00337ECC File Offset: 0x003360CC
		[CallerCount(0)]
		public unsafe bool CanAddToCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CC88 RID: 52360 RVA: 0x00337F08 File Offset: 0x00336108
		[CallerCount(0)]
		public unsafe bool CanRemoveFromCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_CanRemoveFromCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CC89 RID: 52361 RVA: 0x00337F44 File Offset: 0x00336144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335571, XrefRangeEnd = 335575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8A RID: 52362 RVA: 0x00337F78 File Offset: 0x00336178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335575, XrefRangeEnd = 335576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ListingUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ListingUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8B RID: 52363 RVA: 0x00337FB4 File Offset: 0x003361B4
		[CallerCount(0)]
		public unsafe void _Initialize_b__32_0(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8C RID: 52364 RVA: 0x00337FF8 File Offset: 0x003361F8
		[CallerCount(0)]
		public unsafe void _Initialize_b__32_1(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__32_1_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8D RID: 52365 RVA: 0x0033803C File Offset: 0x0033623C
		[CallerCount(0)]
		public unsafe void _Initialize_b__32_2(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__32_2_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8E RID: 52366 RVA: 0x00338080 File Offset: 0x00336280
		[CallerCount(0)]
		public unsafe void _Initialize_b__32_3(BaseEventData <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__32_3_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC8F RID: 52367 RVA: 0x003380C4 File Offset: 0x003362C4
		[CallerCount(0)]
		public unsafe void _Initialize_b__32_4(float x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListingUI.NativeMethodInfoPtr__Initialize_b__32_4_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC90 RID: 52368 RVA: 0x00060FAC File Offset: 0x0005F1AC
		public ListingUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600CC91 RID: 52369 RVA: 0x00338104 File Offset: 0x00336304
		// (set) Token: 0x0600CC92 RID: 52370 RVA: 0x00060FB5 File Offset: 0x0005F1B5
		public unsafe static Color32 PriceLabelColor_Normal
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_Normal, (void*)(&value));
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600CC93 RID: 52371 RVA: 0x00338120 File Offset: 0x00336320
		// (set) Token: 0x0600CC94 RID: 52372 RVA: 0x00060FC3 File Offset: 0x0005F1C3
		public unsafe static Color32 PriceLabelColor_NoStock
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ListingUI.NativeFieldInfoPtr_PriceLabelColor_NoStock, (void*)(&value));
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600CC95 RID: 52373 RVA: 0x0033813C File Offset: 0x0033633C
		// (set) Token: 0x0600CC96 RID: 52374 RVA: 0x00060FD1 File Offset: 0x0005F1D1
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600CC97 RID: 52375 RVA: 0x0033816C File Offset: 0x0033636C
		// (set) Token: 0x0600CC98 RID: 52376 RVA: 0x00060FF0 File Offset: 0x0005F1F0
		public unsafe Color32 StockLabelDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelDefault)) = value;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600CC99 RID: 52377 RVA: 0x00338194 File Offset: 0x00336394
		// (set) Token: 0x0600CC9A RID: 52378 RVA: 0x0006100B File Offset: 0x0005F20B
		public unsafe Color32 StockLabelNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabelNone)) = value;
			}
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600CC9B RID: 52379 RVA: 0x003381BC File Offset: 0x003363BC
		// (set) Token: 0x0600CC9C RID: 52380 RVA: 0x00061026 File Offset: 0x0005F226
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600CC9D RID: 52381 RVA: 0x003381EC File Offset: 0x003363EC
		// (set) Token: 0x0600CC9E RID: 52382 RVA: 0x00061045 File Offset: 0x0005F245
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x0033821C File Offset: 0x0033641C
		// (set) Token: 0x0600CCA0 RID: 52384 RVA: 0x00061064 File Offset: 0x0005F264
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600CCA1 RID: 52385 RVA: 0x0033824C File Offset: 0x0033644C
		// (set) Token: 0x0600CCA2 RID: 52386 RVA: 0x00061083 File Offset: 0x0005F283
		public unsafe TextMeshProUGUI StockLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_StockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x0033827C File Offset: 0x0033647C
		// (set) Token: 0x0600CCA4 RID: 52388 RVA: 0x000610A2 File Offset: 0x0005F2A2
		public unsafe GameObject LockedContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_LockedContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x003382AC File Offset: 0x003364AC
		// (set) Token: 0x0600CCA6 RID: 52390 RVA: 0x000610C1 File Offset: 0x0005F2C1
		public unsafe Button BuyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_BuyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600CCA7 RID: 52391 RVA: 0x003382DC File Offset: 0x003364DC
		// (set) Token: 0x0600CCA8 RID: 52392 RVA: 0x000610E0 File Offset: 0x0005F2E0
		public unsafe Button DropdownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E20 RID: 15904
		// (get) Token: 0x0600CCA9 RID: 52393 RVA: 0x0033830C File Offset: 0x0033650C
		// (set) Token: 0x0600CCAA RID: 52394 RVA: 0x000610FF File Offset: 0x0005F2FF
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E21 RID: 15905
		// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x0033833C File Offset: 0x0033653C
		// (set) Token: 0x0600CCAC RID: 52396 RVA: 0x0006111E File Offset: 0x0005F31E
		public unsafe RectTransform DetailPanelAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DetailPanelAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E22 RID: 15906
		// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x0033836C File Offset: 0x0033656C
		// (set) Token: 0x0600CCAE RID: 52398 RVA: 0x0006113D File Offset: 0x0005F33D
		public unsafe RectTransform DropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_DropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E23 RID: 15907
		// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x0033839C File Offset: 0x0033659C
		// (set) Token: 0x0600CCB0 RID: 52400 RVA: 0x0006115C File Offset: 0x0005F35C
		public unsafe RectTransform TopDropdownAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_TopDropdownAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E24 RID: 15908
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x003383CC File Offset: 0x003365CC
		// (set) Token: 0x0600CCB2 RID: 52402 RVA: 0x0006117B File Offset: 0x0005F37B
		public unsafe Button AddItemButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_AddItemButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_AddItemButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E25 RID: 15909
		// (get) Token: 0x0600CCB3 RID: 52403 RVA: 0x003383FC File Offset: 0x003365FC
		// (set) Token: 0x0600CCB4 RID: 52404 RVA: 0x0006119A File Offset: 0x0005F39A
		public unsafe Button RemoveItemButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_RemoveItemButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_RemoveItemButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E26 RID: 15910
		// (get) Token: 0x0600CCB5 RID: 52405 RVA: 0x0033842C File Offset: 0x0033662C
		// (set) Token: 0x0600CCB6 RID: 52406 RVA: 0x000611B9 File Offset: 0x0005F3B9
		public unsafe TMP_InputField ItemAmountInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_ItemAmountInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_ItemAmountInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E27 RID: 15911
		// (get) Token: 0x0600CCB7 RID: 52407 RVA: 0x0033845C File Offset: 0x0033665C
		// (set) Token: 0x0600CCB8 RID: 52408 RVA: 0x000611D8 File Offset: 0x0005F3D8
		public unsafe UISelectable Selectable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Selectable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UISelectable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_Selectable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E28 RID: 15912
		// (get) Token: 0x0600CCB9 RID: 52409 RVA: 0x0033848C File Offset: 0x0033668C
		// (set) Token: 0x0600CCBA RID: 52410 RVA: 0x000611F7 File Offset: 0x0005F3F7
		public unsafe InputValueRamp _inputValueRamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__inputValueRamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr__inputValueRamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E29 RID: 15913
		// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x003384BC File Offset: 0x003366BC
		// (set) Token: 0x0600CCBC RID: 52412 RVA: 0x00061216 File Offset: 0x0005F416
		public unsafe Action hoverStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2A RID: 15914
		// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x003384EC File Offset: 0x003366EC
		// (set) Token: 0x0600CCBE RID: 52414 RVA: 0x00061235 File Offset: 0x0005F435
		public unsafe Action hoverEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_hoverEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2B RID: 15915
		// (get) Token: 0x0600CCBF RID: 52415 RVA: 0x0033851C File Offset: 0x0033671C
		// (set) Token: 0x0600CCC0 RID: 52416 RVA: 0x00061254 File Offset: 0x0005F454
		public unsafe Action onClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2C RID: 15916
		// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x0033854C File Offset: 0x0033674C
		// (set) Token: 0x0600CCC2 RID: 52418 RVA: 0x00061273 File Offset: 0x0005F473
		public unsafe Action onDropdownClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onDropdownClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2D RID: 15917
		// (get) Token: 0x0600CCC3 RID: 52419 RVA: 0x0033857C File Offset: 0x0033677C
		// (set) Token: 0x0600CCC4 RID: 52420 RVA: 0x00061292 File Offset: 0x0005F492
		public unsafe Action<int> onSetAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onSetAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onSetAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2E RID: 15918
		// (get) Token: 0x0600CCC5 RID: 52421 RVA: 0x003385AC File Offset: 0x003367AC
		// (set) Token: 0x0600CCC6 RID: 52422 RVA: 0x000612B1 File Offset: 0x0005F4B1
		public unsafe Action<int> onAdjustAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onAdjustAmount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onAdjustAmount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E2F RID: 15919
		// (get) Token: 0x0600CCC7 RID: 52423 RVA: 0x003385DC File Offset: 0x003367DC
		// (set) Token: 0x0600CCC8 RID: 52424 RVA: 0x000612D0 File Offset: 0x0005F4D0
		public unsafe Action onAddItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onAddItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onAddItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E30 RID: 15920
		// (get) Token: 0x0600CCC9 RID: 52425 RVA: 0x0033860C File Offset: 0x0033680C
		// (set) Token: 0x0600CCCA RID: 52426 RVA: 0x000612EF File Offset: 0x0005F4EF
		public unsafe Action onRemoveItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onRemoveItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ListingUI.NativeFieldInfoPtr_onRemoveItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008B42 RID: 35650
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_Normal;

		// Token: 0x04008B43 RID: 35651
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabelColor_NoStock;

		// Token: 0x04008B44 RID: 35652
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04008B45 RID: 35653
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelDefault;

		// Token: 0x04008B46 RID: 35654
		private static readonly IntPtr NativeFieldInfoPtr_StockLabelNone;

		// Token: 0x04008B47 RID: 35655
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04008B48 RID: 35656
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04008B49 RID: 35657
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04008B4A RID: 35658
		private static readonly IntPtr NativeFieldInfoPtr_StockLabel;

		// Token: 0x04008B4B RID: 35659
		private static readonly IntPtr NativeFieldInfoPtr_LockedContainer;

		// Token: 0x04008B4C RID: 35660
		private static readonly IntPtr NativeFieldInfoPtr_BuyButton;

		// Token: 0x04008B4D RID: 35661
		private static readonly IntPtr NativeFieldInfoPtr_DropdownButton;

		// Token: 0x04008B4E RID: 35662
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04008B4F RID: 35663
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanelAnchor;

		// Token: 0x04008B50 RID: 35664
		private static readonly IntPtr NativeFieldInfoPtr_DropdownAnchor;

		// Token: 0x04008B51 RID: 35665
		private static readonly IntPtr NativeFieldInfoPtr_TopDropdownAnchor;

		// Token: 0x04008B52 RID: 35666
		private static readonly IntPtr NativeFieldInfoPtr_AddItemButton;

		// Token: 0x04008B53 RID: 35667
		private static readonly IntPtr NativeFieldInfoPtr_RemoveItemButton;

		// Token: 0x04008B54 RID: 35668
		private static readonly IntPtr NativeFieldInfoPtr_ItemAmountInput;

		// Token: 0x04008B55 RID: 35669
		private static readonly IntPtr NativeFieldInfoPtr_Selectable;

		// Token: 0x04008B56 RID: 35670
		private static readonly IntPtr NativeFieldInfoPtr__inputValueRamp;

		// Token: 0x04008B57 RID: 35671
		private static readonly IntPtr NativeFieldInfoPtr_hoverStart;

		// Token: 0x04008B58 RID: 35672
		private static readonly IntPtr NativeFieldInfoPtr_hoverEnd;

		// Token: 0x04008B59 RID: 35673
		private static readonly IntPtr NativeFieldInfoPtr_onClicked;

		// Token: 0x04008B5A RID: 35674
		private static readonly IntPtr NativeFieldInfoPtr_onDropdownClicked;

		// Token: 0x04008B5B RID: 35675
		private static readonly IntPtr NativeFieldInfoPtr_onSetAmount;

		// Token: 0x04008B5C RID: 35676
		private static readonly IntPtr NativeFieldInfoPtr_onAdjustAmount;

		// Token: 0x04008B5D RID: 35677
		private static readonly IntPtr NativeFieldInfoPtr_onAddItem;

		// Token: 0x04008B5E RID: 35678
		private static readonly IntPtr NativeFieldInfoPtr_onRemoveItem;

		// Token: 0x04008B5F RID: 35679
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04008B60 RID: 35680
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04008B61 RID: 35681
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_ShopListing_0;

		// Token: 0x04008B62 RID: 35682
		private static readonly IntPtr NativeMethodInfoPtr_GetIconCopy_Public_Virtual_New_RectTransform_RectTransform_0;

		// Token: 0x04008B63 RID: 35683
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04008B64 RID: 35684
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_Void_0;

		// Token: 0x04008B65 RID: 35685
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Private_Void_0;

		// Token: 0x04008B66 RID: 35686
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Private_Void_String_0;

		// Token: 0x04008B67 RID: 35687
		private static readonly IntPtr NativeMethodInfoPtr_AdjustAmount_Private_Void_Int32_0;

		// Token: 0x04008B68 RID: 35688
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0;

		// Token: 0x04008B69 RID: 35689
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_0;

		// Token: 0x04008B6A RID: 35690
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Private_Void_0;

		// Token: 0x04008B6B RID: 35691
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Private_Void_0;

		// Token: 0x04008B6C RID: 35692
		private static readonly IntPtr NativeMethodInfoPtr_StockChanged_Private_Void_0;

		// Token: 0x04008B6D RID: 35693
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04008B6E RID: 35694
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04008B6F RID: 35695
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStock_Private_Void_0;

		// Token: 0x04008B70 RID: 35696
		private static readonly IntPtr NativeMethodInfoPtr_UpdateQuantityInCart_Public_Void_0;

		// Token: 0x04008B71 RID: 35697
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04008B72 RID: 35698
		private static readonly IntPtr NativeMethodInfoPtr_CanAddToCart_Public_Boolean_0;

		// Token: 0x04008B73 RID: 35699
		private static readonly IntPtr NativeMethodInfoPtr_CanRemoveFromCart_Public_Boolean_0;

		// Token: 0x04008B74 RID: 35700
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLockStatus_Public_Void_0;

		// Token: 0x04008B75 RID: 35701
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008B76 RID: 35702
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_0_Private_Void_BaseEventData_0;

		// Token: 0x04008B77 RID: 35703
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_1_Private_Void_BaseEventData_0;

		// Token: 0x04008B78 RID: 35704
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_2_Private_Void_BaseEventData_0;

		// Token: 0x04008B79 RID: 35705
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_3_Private_Void_BaseEventData_0;

		// Token: 0x04008B7A RID: 35706
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__32_4_Private_Void_Single_0;
	}
}
