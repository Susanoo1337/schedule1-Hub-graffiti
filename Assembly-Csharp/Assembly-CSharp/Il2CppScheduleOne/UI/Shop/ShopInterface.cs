using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.State;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.UI.Input;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200083D RID: 2109
	public class ShopInterface : MonoBehaviour
	{
		// Token: 0x0600CCFA RID: 52474 RVA: 0x00338F50 File Offset: 0x00337150
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterface()
		{
			Il2CppClassPointerStore<ShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr);
			ShopInterface.NativeFieldInfoPtr_AllShops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AllShops");
			ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "MAX_ITEM_QUANTITY");
			ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			ShopInterface.NativeFieldInfoPtr_ShopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopName");
			ShopInterface.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopCode");
			ShopInterface.NativeFieldInfoPtr_ShopDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShopDescription");
			ShopInterface.NativeFieldInfoPtr_PaymentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "PaymentType");
			ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ShowCurrencyHint");
			ShopInterface.NativeFieldInfoPtr_Listings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Listings");
			ShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Canvas");
			ShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Container");
			ShopInterface.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingContainer");
			ShopInterface.NativeFieldInfoPtr_StoreNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "StoreNameLabel");
			ShopInterface.NativeFieldInfoPtr_Cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "Cart");
			ShopInterface.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryBays");
			ShopInterface.NativeFieldInfoPtr_LoadingBayDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "LoadingBayDetector");
			ShopInterface.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DetailPanel");
			ShopInterface.NativeFieldInfoPtr_ListingScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingScrollRect");
			ShopInterface.NativeFieldInfoPtr_AmountSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AmountSelector");
			ShopInterface.NativeFieldInfoPtr_DeliveryVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "DeliveryVehicle");
			ShopInterface.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "State");
			ShopInterface.NativeFieldInfoPtr_AddItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "AddItemSound");
			ShopInterface.NativeFieldInfoPtr_RemoveItemSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "RemoveItemSound");
			ShopInterface.NativeFieldInfoPtr_CheckoutSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "CheckoutSound");
			ShopInterface.NativeFieldInfoPtr_ListingUIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "ListingUIPrefab");
			ShopInterface.NativeFieldInfoPtr_onOrderCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "onOrderCompleted");
			ShopInterface.NativeFieldInfoPtr_onOrderCompletedWithSpend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "onOrderCompletedWithSpend");
			ShopInterface.NativeFieldInfoPtr_shopScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "shopScreen");
			ShopInterface.NativeFieldInfoPtr_listingPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "listingPanel");
			ShopInterface.NativeFieldInfoPtr_defaultAddToCartAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "defaultAddToCartAmount");
			ShopInterface.NativeFieldInfoPtr_minAddToCartAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "minAddToCartAmount");
			ShopInterface.NativeFieldInfoPtr_addToCartTier1Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "addToCartTier1Amount");
			ShopInterface.NativeFieldInfoPtr_addToCartTier2Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "addToCartTier2Amount");
			ShopInterface.NativeFieldInfoPtr_addToCartTier3Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "addToCartTier3Amount");
			ShopInterface.NativeFieldInfoPtr_minModifyAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "minModifyAmount");
			ShopInterface.NativeFieldInfoPtr_modifyTier1Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "modifyTier1Amount");
			ShopInterface.NativeFieldInfoPtr_modifyTier2Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "modifyTier2Amount");
			ShopInterface.NativeFieldInfoPtr_modifyTier3Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "modifyTier3Amount");
			ShopInterface.NativeFieldInfoPtr__embeddedInputPromptUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "_embeddedInputPromptUI");
			ShopInterface.NativeFieldInfoPtr_categoryButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryButtons");
			ShopInterface.NativeFieldInfoPtr_categoryFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "categoryFilter");
			ShopInterface.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "searchTerm");
			ShopInterface.NativeFieldInfoPtr_listingUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "listingUI");
			ShopInterface.NativeFieldInfoPtr_selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "selectedListing");
			ShopInterface.NativeFieldInfoPtr_amountSelectorMouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "amountSelectorMouseUp");
			ShopInterface.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "loader");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<HasChanged>k__BackingField");
			ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689700);
			ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689701);
			ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689702);
			ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689703);
			ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689704);
			ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689705);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689706);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689707);
			ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689708);
			ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689709);
			ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689710);
			ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689711);
			ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689712);
			ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689713);
			ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689714);
			ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689715);
			ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689716);
			ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689717);
			ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689718);
			ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689719);
			ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689720);
			ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689721);
			ShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689722);
			ShopInterface.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689723);
			ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689724);
			ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689725);
			ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689726);
			ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689727);
			ShopInterface.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689728);
			ShopInterface.NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689729);
			ShopInterface.NativeMethodInfoPtr_AdjustAmount_Public_Void_ListingUI_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689730);
			ShopInterface.NativeMethodInfoPtr_SetAmount_Public_Virtual_New_Void_ListingUI_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689731);
			ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689732);
			ShopInterface.NativeMethodInfoPtr_PullStockVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689733);
			ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689734);
			ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689735);
			ShopInterface.NativeMethodInfoPtr_RefreshShownItemsNextFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689736);
			ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689737);
			ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689738);
			ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689739);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689740);
			ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689741);
			ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689742);
			ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689743);
			ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689744);
			ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689745);
			ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689746);
			ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689747);
			ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689748);
			ShopInterface.NativeMethodInfoPtr_QuantitySelectedNew_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689749);
			ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689750);
			ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689751);
			ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689752);
			ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689753);
			ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689754);
			ShopInterface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689755);
			ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689756);
			ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689757);
			ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__92_0_Private_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689759);
			ShopInterface.NativeMethodInfoPtr__DropdownClicked_b__106_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, 100689760);
		}

		// Token: 0x17003E73 RID: 15987
		// (get) Token: 0x0600CCFB RID: 52475 RVA: 0x00339804 File Offset: 0x00337A04
		// (set) Token: 0x0600CCFC RID: 52476 RVA: 0x00339840 File Offset: 0x00337A40
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30482, RefRangeEnd = 30484, XrefRangeStart = 30482, XrefRangeEnd = 30484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E74 RID: 15988
		// (get) Token: 0x0600CCFD RID: 52477 RVA: 0x00339880 File Offset: 0x00337A80
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335796, XrefRangeEnd = 335797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x0600CCFE RID: 52478 RVA: 0x003398B8 File Offset: 0x00337AB8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600CCFF RID: 52479 RVA: 0x003398F0 File Offset: 0x00337AF0
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600CD00 RID: 52480 RVA: 0x00339930 File Offset: 0x00337B30
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(170)]
			[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x0600CD01 RID: 52481 RVA: 0x0033996C File Offset: 0x00337B6C
		// (set) Token: 0x0600CD02 RID: 52482 RVA: 0x003399AC File Offset: 0x00337BAC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E79 RID: 15993
		// (get) Token: 0x0600CD03 RID: 52483 RVA: 0x003399F0 File Offset: 0x00337BF0
		// (set) Token: 0x0600CD04 RID: 52484 RVA: 0x00339A30 File Offset: 0x00337C30
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E7A RID: 15994
		// (get) Token: 0x0600CD05 RID: 52485 RVA: 0x00339A74 File Offset: 0x00337C74
		// (set) Token: 0x0600CD06 RID: 52486 RVA: 0x00339AB0 File Offset: 0x00337CB0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CD07 RID: 52487 RVA: 0x00339AF0 File Offset: 0x00337CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335797, XrefRangeEnd = 335881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x00339B2C File Offset: 0x00337D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335973, RefRangeEnd = 335974, XrefRangeStart = 335881, XrefRangeEnd = 335973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD09 RID: 52489 RVA: 0x00339B68 File Offset: 0x00337D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335974, XrefRangeEnd = 335980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x00339BA4 File Offset: 0x00337DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335980, XrefRangeEnd = 335988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0B RID: 52491 RVA: 0x00339BD8 File Offset: 0x00337DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335988, XrefRangeEnd = 336052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x00339C0C File Offset: 0x00337E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336052, XrefRangeEnd = 336056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x00339C48 File Offset: 0x00337E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336056, XrefRangeEnd = 336067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnDayPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x00339C7C File Offset: 0x00337E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336067, XrefRangeEnd = 336078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWeekPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnWeekPass_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x00339CB0 File Offset: 0x00337EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336078, XrefRangeEnd = 336081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x00339CF0 File Offset: 0x00337EF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336146, RefRangeEnd = 336148, XrefRangeStart = 336081, XrefRangeEnd = 336146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x00339D24 File Offset: 0x00337F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336148, XrefRangeEnd = 336150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x00339D58 File Offset: 0x00337F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336150, XrefRangeEnd = 336165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x00339D8C File Offset: 0x00337F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336165, XrefRangeEnd = 336172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Hint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x00339DC0 File Offset: 0x00337FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336172, XrefRangeEnd = 336175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x00339E10 File Offset: 0x00338010
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336280, RefRangeEnd = 336281, XrefRangeStart = 336175, XrefRangeEnd = 336280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateListingUI(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x00339E54 File Offset: 0x00338054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336281, XrefRangeEnd = 336310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectCategory(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x00339E94 File Offset: 0x00338094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336310, XrefRangeEnd = 336315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddItem(ListingUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x00339EE4 File Offset: 0x003380E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336315, XrefRangeEnd = 336319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveItem(ListingUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x00339F34 File Offset: 0x00338134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336319, XrefRangeEnd = 336324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustAmount(ListingUI ui, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_AdjustAmount_Public_Void_ListingUI_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1A RID: 52506 RVA: 0x00339F84 File Offset: 0x00338184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336324, XrefRangeEnd = 336326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetAmount(ListingUI ui, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_SetAmount_Public_Virtual_New_Void_ListingUI_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x00339FE0 File Offset: 0x003381E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336368, RefRangeEnd = 336372, XrefRangeStart = 336326, XrefRangeEnd = 336368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CategorySelected(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x0033A020 File Offset: 0x00338220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336380, RefRangeEnd = 336382, XrefRangeStart = 336372, XrefRangeEnd = 336380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PullStockVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_PullStockVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x0033A054 File Offset: 0x00338254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336382, XrefRangeEnd = 336393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeselectCurrentCategory()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x0033A088 File Offset: 0x00338288
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 336484, RefRangeEnd = 336487, XrefRangeStart = 336393, XrefRangeEnd = 336484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShownItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshShownItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x0033A0BC File Offset: 0x003382BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336487, XrefRangeEnd = 336492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RefreshShownItemsNextFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshShownItemsNextFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x0033A0FC File Offset: 0x003382FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336492, XrefRangeEnd = 336500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUnlockStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD21 RID: 52513 RVA: 0x0033A130 File Offset: 0x00338330
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336515, RefRangeEnd = 336516, XrefRangeStart = 336500, XrefRangeEnd = 336515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestockAllListings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_RestockAllListings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x0033A164 File Offset: 0x00338364
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCartFitItem(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x0033A1B4 File Offset: 0x003383B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336516, XrefRangeEnd = 336528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD24 RID: 52516 RVA: 0x0033A1F0 File Offset: 0x003383F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 336565, RefRangeEnd = 336568, XrefRangeStart = 336528, XrefRangeEnd = 336565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFit(List<ItemSlot> availableSlots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(availableSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD25 RID: 52517 RVA: 0x0033A240 File Offset: 0x00338440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336568, XrefRangeEnd = 336611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD26 RID: 52518 RVA: 0x0033A288 File Offset: 0x00338488
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 336633, RefRangeEnd = 336637, XrefRangeStart = 336611, XrefRangeEnd = 336633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemSlot> GetAvailableSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
		}

		// Token: 0x0600CD27 RID: 52519 RVA: 0x0033A2C8 File Offset: 0x003384C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 336644, RefRangeEnd = 336649, XrefRangeStart = 336637, XrefRangeEnd = 336644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle GetLoadingBayVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600CD28 RID: 52520 RVA: 0x0033A308 File Offset: 0x00338508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336649, XrefRangeEnd = 336658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaceItemInDeliveryBay(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x0033A34C File Offset: 0x0033854C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336658, XrefRangeEnd = 336669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuantitySelected(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x0033A38C File Offset: 0x0033858C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336669, XrefRangeEnd = 336681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenAmountSelector(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x0033A3D0 File Offset: 0x003385D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336681, XrefRangeEnd = 336748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DropdownClicked(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x0033A414 File Offset: 0x00338614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336748, XrefRangeEnd = 336757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QuantitySelectedNew(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_QuantitySelectedNew_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x0033A454 File Offset: 0x00338654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336757, XrefRangeEnd = 336759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryHovered(ListingUI listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x0033A498 File Offset: 0x00338698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336759, XrefRangeEnd = 336763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryUnhovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_EntryUnhovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x0033A4CC File Offset: 0x003386CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336793, RefRangeEnd = 336794, XrefRangeStart = 336763, XrefRangeEnd = 336793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ShopData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_Load_Public_Void_ShopData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x0033A510 File Offset: 0x00338710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336810, RefRangeEnd = 336811, XrefRangeStart = 336794, XrefRangeEnd = 336810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x0033A54C File Offset: 0x0033874C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336811, XrefRangeEnd = 336826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing GetListing(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x0033A59C File Offset: 0x0033879C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336826, XrefRangeEnd = 336860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ShopData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopInterface.NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopData>(intPtr3) : null;
		}

		// Token: 0x0600CD33 RID: 52531 RVA: 0x0033A5E8 File Offset: 0x003387E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336860, XrefRangeEnd = 336861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x0033A620 File Offset: 0x00338820
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336915, RefRangeEnd = 336916, XrefRangeStart = 336861, XrefRangeEnd = 336915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x0033A65C File Offset: 0x0033885C
		[CallerCount(0)]
		public unsafe bool _DeselectCurrentCategory_b__92_0(CategoryButton x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__DeselectCurrentCategory_b__92_0_Private_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x0033A6AC File Offset: 0x003388AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336916, XrefRangeEnd = 336924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _DropdownClicked_b__106_0(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.NativeMethodInfoPtr__DropdownClicked_b__106_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x000614AB File Offset: 0x0005F6AB
		public ShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E42 RID: 15938
		// (get) Token: 0x0600CD38 RID: 52536 RVA: 0x0033A6EC File Offset: 0x003388EC
		// (set) Token: 0x0600CD39 RID: 52537 RVA: 0x000614B4 File Offset: 0x0005F6B4
		public unsafe static List<ShopInterface> AllShops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_AllShops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopInterface>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_AllShops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E43 RID: 15939
		// (get) Token: 0x0600CD3A RID: 52538 RVA: 0x0033A714 File Offset: 0x00338914
		// (set) Token: 0x0600CD3B RID: 52539 RVA: 0x000614C6 File Offset: 0x0005F6C6
		public unsafe static int MAX_ITEM_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShopInterface.NativeFieldInfoPtr_MAX_ITEM_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x17003E44 RID: 15940
		// (get) Token: 0x0600CD3C RID: 52540 RVA: 0x0033A730 File Offset: 0x00338930
		// (set) Token: 0x0600CD3D RID: 52541 RVA: 0x000614D4 File Offset: 0x0005F6D4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E45 RID: 15941
		// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x0033A758 File Offset: 0x00338958
		// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x000614EF File Offset: 0x0005F6EF
		public unsafe string ShopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E46 RID: 15942
		// (get) Token: 0x0600CD40 RID: 52544 RVA: 0x0033A780 File Offset: 0x00338980
		// (set) Token: 0x0600CD41 RID: 52545 RVA: 0x0006150E File Offset: 0x0005F70E
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E47 RID: 15943
		// (get) Token: 0x0600CD42 RID: 52546 RVA: 0x0033A7A8 File Offset: 0x003389A8
		// (set) Token: 0x0600CD43 RID: 52547 RVA: 0x0006152D File Offset: 0x0005F72D
		public unsafe string ShopDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShopDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E48 RID: 15944
		// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x0033A7D0 File Offset: 0x003389D0
		// (set) Token: 0x0600CD45 RID: 52549 RVA: 0x0006154C File Offset: 0x0005F74C
		public unsafe ShopInterface.EPaymentType PaymentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_PaymentType)) = value;
			}
		}

		// Token: 0x17003E49 RID: 15945
		// (get) Token: 0x0600CD46 RID: 52550 RVA: 0x0033A7F8 File Offset: 0x003389F8
		// (set) Token: 0x0600CD47 RID: 52551 RVA: 0x00061567 File Offset: 0x0005F767
		public unsafe bool ShowCurrencyHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ShowCurrencyHint)) = value;
			}
		}

		// Token: 0x17003E4A RID: 15946
		// (get) Token: 0x0600CD48 RID: 52552 RVA: 0x0033A820 File Offset: 0x00338A20
		// (set) Token: 0x0600CD49 RID: 52553 RVA: 0x00061582 File Offset: 0x0005F782
		public unsafe List<ShopListing> Listings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ShopListing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Listings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600CD4A RID: 52554 RVA: 0x0033A850 File Offset: 0x00338A50
		// (set) Token: 0x0600CD4B RID: 52555 RVA: 0x000615A1 File Offset: 0x0005F7A1
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E4C RID: 15948
		// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x0033A880 File Offset: 0x00338A80
		// (set) Token: 0x0600CD4D RID: 52557 RVA: 0x000615C0 File Offset: 0x0005F7C0
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E4D RID: 15949
		// (get) Token: 0x0600CD4E RID: 52558 RVA: 0x0033A8B0 File Offset: 0x00338AB0
		// (set) Token: 0x0600CD4F RID: 52559 RVA: 0x000615DF File Offset: 0x0005F7DF
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E4E RID: 15950
		// (get) Token: 0x0600CD50 RID: 52560 RVA: 0x0033A8E0 File Offset: 0x00338AE0
		// (set) Token: 0x0600CD51 RID: 52561 RVA: 0x000615FE File Offset: 0x0005F7FE
		public unsafe TextMeshProUGUI StoreNameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_StoreNameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E4F RID: 15951
		// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x0033A910 File Offset: 0x00338B10
		// (set) Token: 0x0600CD53 RID: 52563 RVA: 0x0006161D File Offset: 0x0005F81D
		public unsafe Cart Cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_Cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E50 RID: 15952
		// (get) Token: 0x0600CD54 RID: 52564 RVA: 0x0033A940 File Offset: 0x00338B40
		// (set) Token: 0x0600CD55 RID: 52565 RVA: 0x0006163C File Offset: 0x0005F83C
		public unsafe Il2CppReferenceArray<StorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E51 RID: 15953
		// (get) Token: 0x0600CD56 RID: 52566 RVA: 0x0033A970 File Offset: 0x00338B70
		// (set) Token: 0x0600CD57 RID: 52567 RVA: 0x0006165B File Offset: 0x0005F85B
		public unsafe VehicleDetector LoadingBayDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_LoadingBayDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E52 RID: 15954
		// (get) Token: 0x0600CD58 RID: 52568 RVA: 0x0033A9A0 File Offset: 0x00338BA0
		// (set) Token: 0x0600CD59 RID: 52569 RVA: 0x0006167A File Offset: 0x0005F87A
		public unsafe ShopInterfaceDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E53 RID: 15955
		// (get) Token: 0x0600CD5A RID: 52570 RVA: 0x0033A9D0 File Offset: 0x00338BD0
		// (set) Token: 0x0600CD5B RID: 52571 RVA: 0x00061699 File Offset: 0x0005F899
		public unsafe ScrollRect ListingScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E54 RID: 15956
		// (get) Token: 0x0600CD5C RID: 52572 RVA: 0x0033AA00 File Offset: 0x00338C00
		// (set) Token: 0x0600CD5D RID: 52573 RVA: 0x000616B8 File Offset: 0x0005F8B8
		public unsafe ShopAmountSelector AmountSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopAmountSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AmountSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E55 RID: 15957
		// (get) Token: 0x0600CD5E RID: 52574 RVA: 0x0033AA30 File Offset: 0x00338C30
		// (set) Token: 0x0600CD5F RID: 52575 RVA: 0x000616D7 File Offset: 0x0005F8D7
		public unsafe DeliveryVehicle DeliveryVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_DeliveryVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E56 RID: 15958
		// (get) Token: 0x0600CD60 RID: 52576 RVA: 0x0033AA60 File Offset: 0x00338C60
		// (set) Token: 0x0600CD61 RID: 52577 RVA: 0x000616F6 File Offset: 0x0005F8F6
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E57 RID: 15959
		// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x0033AA90 File Offset: 0x00338C90
		// (set) Token: 0x0600CD63 RID: 52579 RVA: 0x00061715 File Offset: 0x0005F915
		public unsafe AudioSourceController AddItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_AddItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E58 RID: 15960
		// (get) Token: 0x0600CD64 RID: 52580 RVA: 0x0033AAC0 File Offset: 0x00338CC0
		// (set) Token: 0x0600CD65 RID: 52581 RVA: 0x00061734 File Offset: 0x0005F934
		public unsafe AudioSourceController RemoveItemSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_RemoveItemSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E59 RID: 15961
		// (get) Token: 0x0600CD66 RID: 52582 RVA: 0x0033AAF0 File Offset: 0x00338CF0
		// (set) Token: 0x0600CD67 RID: 52583 RVA: 0x00061753 File Offset: 0x0005F953
		public unsafe AudioSourceController CheckoutSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_CheckoutSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5A RID: 15962
		// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x0033AB20 File Offset: 0x00338D20
		// (set) Token: 0x0600CD69 RID: 52585 RVA: 0x00061772 File Offset: 0x0005F972
		public unsafe ListingUI ListingUIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_ListingUIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5B RID: 15963
		// (get) Token: 0x0600CD6A RID: 52586 RVA: 0x0033AB50 File Offset: 0x00338D50
		// (set) Token: 0x0600CD6B RID: 52587 RVA: 0x00061791 File Offset: 0x0005F991
		public unsafe UnityEvent onOrderCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5C RID: 15964
		// (get) Token: 0x0600CD6C RID: 52588 RVA: 0x0033AB80 File Offset: 0x00338D80
		// (set) Token: 0x0600CD6D RID: 52589 RVA: 0x000617B0 File Offset: 0x0005F9B0
		public unsafe Action<float> onOrderCompletedWithSpend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompletedWithSpend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_onOrderCompletedWithSpend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5D RID: 15965
		// (get) Token: 0x0600CD6E RID: 52590 RVA: 0x0033ABB0 File Offset: 0x00338DB0
		// (set) Token: 0x0600CD6F RID: 52591 RVA: 0x000617CF File Offset: 0x0005F9CF
		public unsafe UIScreen shopScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_shopScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_shopScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5E RID: 15966
		// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x0033ABE0 File Offset: 0x00338DE0
		// (set) Token: 0x0600CD71 RID: 52593 RVA: 0x000617EE File Offset: 0x0005F9EE
		public unsafe UIPanel listingPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E5F RID: 15967
		// (get) Token: 0x0600CD72 RID: 52594 RVA: 0x0033AC10 File Offset: 0x00338E10
		// (set) Token: 0x0600CD73 RID: 52595 RVA: 0x0006180D File Offset: 0x0005FA0D
		public unsafe int defaultAddToCartAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_defaultAddToCartAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_defaultAddToCartAmount)) = value;
			}
		}

		// Token: 0x17003E60 RID: 15968
		// (get) Token: 0x0600CD74 RID: 52596 RVA: 0x0033AC38 File Offset: 0x00338E38
		// (set) Token: 0x0600CD75 RID: 52597 RVA: 0x00061828 File Offset: 0x0005FA28
		public unsafe int minAddToCartAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_minAddToCartAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_minAddToCartAmount)) = value;
			}
		}

		// Token: 0x17003E61 RID: 15969
		// (get) Token: 0x0600CD76 RID: 52598 RVA: 0x0033AC60 File Offset: 0x00338E60
		// (set) Token: 0x0600CD77 RID: 52599 RVA: 0x00061843 File Offset: 0x0005FA43
		public unsafe int addToCartTier1Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier1Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier1Amount)) = value;
			}
		}

		// Token: 0x17003E62 RID: 15970
		// (get) Token: 0x0600CD78 RID: 52600 RVA: 0x0033AC88 File Offset: 0x00338E88
		// (set) Token: 0x0600CD79 RID: 52601 RVA: 0x0006185E File Offset: 0x0005FA5E
		public unsafe int addToCartTier2Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier2Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier2Amount)) = value;
			}
		}

		// Token: 0x17003E63 RID: 15971
		// (get) Token: 0x0600CD7A RID: 52602 RVA: 0x0033ACB0 File Offset: 0x00338EB0
		// (set) Token: 0x0600CD7B RID: 52603 RVA: 0x00061879 File Offset: 0x0005FA79
		public unsafe int addToCartTier3Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier3Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_addToCartTier3Amount)) = value;
			}
		}

		// Token: 0x17003E64 RID: 15972
		// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x0033ACD8 File Offset: 0x00338ED8
		// (set) Token: 0x0600CD7D RID: 52605 RVA: 0x00061894 File Offset: 0x0005FA94
		public unsafe int minModifyAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_minModifyAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_minModifyAmount)) = value;
			}
		}

		// Token: 0x17003E65 RID: 15973
		// (get) Token: 0x0600CD7E RID: 52606 RVA: 0x0033AD00 File Offset: 0x00338F00
		// (set) Token: 0x0600CD7F RID: 52607 RVA: 0x000618AF File Offset: 0x0005FAAF
		public unsafe int modifyTier1Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier1Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier1Amount)) = value;
			}
		}

		// Token: 0x17003E66 RID: 15974
		// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x0033AD28 File Offset: 0x00338F28
		// (set) Token: 0x0600CD81 RID: 52609 RVA: 0x000618CA File Offset: 0x0005FACA
		public unsafe int modifyTier2Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier2Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier2Amount)) = value;
			}
		}

		// Token: 0x17003E67 RID: 15975
		// (get) Token: 0x0600CD82 RID: 52610 RVA: 0x0033AD50 File Offset: 0x00338F50
		// (set) Token: 0x0600CD83 RID: 52611 RVA: 0x000618E5 File Offset: 0x0005FAE5
		public unsafe int modifyTier3Amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier3Amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_modifyTier3Amount)) = value;
			}
		}

		// Token: 0x17003E68 RID: 15976
		// (get) Token: 0x0600CD84 RID: 52612 RVA: 0x0033AD78 File Offset: 0x00338F78
		// (set) Token: 0x0600CD85 RID: 52613 RVA: 0x00061900 File Offset: 0x0005FB00
		public unsafe EmbeddedInputPromptUI _embeddedInputPromptUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__embeddedInputPromptUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmbeddedInputPromptUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__embeddedInputPromptUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E69 RID: 15977
		// (get) Token: 0x0600CD86 RID: 52614 RVA: 0x0033ADA8 File Offset: 0x00338FA8
		// (set) Token: 0x0600CD87 RID: 52615 RVA: 0x0006191F File Offset: 0x0005FB1F
		public unsafe List<CategoryButton> categoryButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CategoryButton>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x0600CD88 RID: 52616 RVA: 0x0033ADD8 File Offset: 0x00338FD8
		// (set) Token: 0x0600CD89 RID: 52617 RVA: 0x0006193E File Offset: 0x0005FB3E
		public unsafe EShopCategory categoryFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_categoryFilter)) = value;
			}
		}

		// Token: 0x17003E6B RID: 15979
		// (get) Token: 0x0600CD8A RID: 52618 RVA: 0x0033AE00 File Offset: 0x00339000
		// (set) Token: 0x0600CD8B RID: 52619 RVA: 0x00061959 File Offset: 0x0005FB59
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E6C RID: 15980
		// (get) Token: 0x0600CD8C RID: 52620 RVA: 0x0033AE28 File Offset: 0x00339028
		// (set) Token: 0x0600CD8D RID: 52621 RVA: 0x00061978 File Offset: 0x0005FB78
		public unsafe List<ListingUI> listingUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_listingUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E6D RID: 15981
		// (get) Token: 0x0600CD8E RID: 52622 RVA: 0x0033AE58 File Offset: 0x00339058
		// (set) Token: 0x0600CD8F RID: 52623 RVA: 0x00061997 File Offset: 0x0005FB97
		public unsafe ListingUI selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E6E RID: 15982
		// (get) Token: 0x0600CD90 RID: 52624 RVA: 0x0033AE88 File Offset: 0x00339088
		// (set) Token: 0x0600CD91 RID: 52625 RVA: 0x000619B6 File Offset: 0x0005FBB6
		public unsafe bool amountSelectorMouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_amountSelectorMouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_amountSelectorMouseUp)) = value;
			}
		}

		// Token: 0x17003E6F RID: 15983
		// (get) Token: 0x0600CD92 RID: 52626 RVA: 0x0033AEB0 File Offset: 0x003390B0
		// (set) Token: 0x0600CD93 RID: 52627 RVA: 0x000619D1 File Offset: 0x0005FBD1
		public unsafe ShopLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E70 RID: 15984
		// (get) Token: 0x0600CD94 RID: 52628 RVA: 0x0033AEE0 File Offset: 0x003390E0
		// (set) Token: 0x0600CD95 RID: 52629 RVA: 0x000619F0 File Offset: 0x0005FBF0
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E71 RID: 15985
		// (get) Token: 0x0600CD96 RID: 52630 RVA: 0x0033AF10 File Offset: 0x00339110
		// (set) Token: 0x0600CD97 RID: 52631 RVA: 0x00061A0F File Offset: 0x0005FC0F
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E72 RID: 15986
		// (get) Token: 0x0600CD98 RID: 52632 RVA: 0x0033AF40 File Offset: 0x00339140
		// (set) Token: 0x0600CD99 RID: 52633 RVA: 0x00061A2E File Offset: 0x0005FC2E
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04008B99 RID: 35737
		private static readonly IntPtr NativeFieldInfoPtr_AllShops;

		// Token: 0x04008B9A RID: 35738
		private static readonly IntPtr NativeFieldInfoPtr_MAX_ITEM_QUANTITY;

		// Token: 0x04008B9B RID: 35739
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008B9C RID: 35740
		private static readonly IntPtr NativeFieldInfoPtr_ShopName;

		// Token: 0x04008B9D RID: 35741
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x04008B9E RID: 35742
		private static readonly IntPtr NativeFieldInfoPtr_ShopDescription;

		// Token: 0x04008B9F RID: 35743
		private static readonly IntPtr NativeFieldInfoPtr_PaymentType;

		// Token: 0x04008BA0 RID: 35744
		private static readonly IntPtr NativeFieldInfoPtr_ShowCurrencyHint;

		// Token: 0x04008BA1 RID: 35745
		private static readonly IntPtr NativeFieldInfoPtr_Listings;

		// Token: 0x04008BA2 RID: 35746
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04008BA3 RID: 35747
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008BA4 RID: 35748
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x04008BA5 RID: 35749
		private static readonly IntPtr NativeFieldInfoPtr_StoreNameLabel;

		// Token: 0x04008BA6 RID: 35750
		private static readonly IntPtr NativeFieldInfoPtr_Cart;

		// Token: 0x04008BA7 RID: 35751
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x04008BA8 RID: 35752
		private static readonly IntPtr NativeFieldInfoPtr_LoadingBayDetector;

		// Token: 0x04008BA9 RID: 35753
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x04008BAA RID: 35754
		private static readonly IntPtr NativeFieldInfoPtr_ListingScrollRect;

		// Token: 0x04008BAB RID: 35755
		private static readonly IntPtr NativeFieldInfoPtr_AmountSelector;

		// Token: 0x04008BAC RID: 35756
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryVehicle;

		// Token: 0x04008BAD RID: 35757
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x04008BAE RID: 35758
		private static readonly IntPtr NativeFieldInfoPtr_AddItemSound;

		// Token: 0x04008BAF RID: 35759
		private static readonly IntPtr NativeFieldInfoPtr_RemoveItemSound;

		// Token: 0x04008BB0 RID: 35760
		private static readonly IntPtr NativeFieldInfoPtr_CheckoutSound;

		// Token: 0x04008BB1 RID: 35761
		private static readonly IntPtr NativeFieldInfoPtr_ListingUIPrefab;

		// Token: 0x04008BB2 RID: 35762
		private static readonly IntPtr NativeFieldInfoPtr_onOrderCompleted;

		// Token: 0x04008BB3 RID: 35763
		private static readonly IntPtr NativeFieldInfoPtr_onOrderCompletedWithSpend;

		// Token: 0x04008BB4 RID: 35764
		private static readonly IntPtr NativeFieldInfoPtr_shopScreen;

		// Token: 0x04008BB5 RID: 35765
		private static readonly IntPtr NativeFieldInfoPtr_listingPanel;

		// Token: 0x04008BB6 RID: 35766
		private static readonly IntPtr NativeFieldInfoPtr_defaultAddToCartAmount;

		// Token: 0x04008BB7 RID: 35767
		private static readonly IntPtr NativeFieldInfoPtr_minAddToCartAmount;

		// Token: 0x04008BB8 RID: 35768
		private static readonly IntPtr NativeFieldInfoPtr_addToCartTier1Amount;

		// Token: 0x04008BB9 RID: 35769
		private static readonly IntPtr NativeFieldInfoPtr_addToCartTier2Amount;

		// Token: 0x04008BBA RID: 35770
		private static readonly IntPtr NativeFieldInfoPtr_addToCartTier3Amount;

		// Token: 0x04008BBB RID: 35771
		private static readonly IntPtr NativeFieldInfoPtr_minModifyAmount;

		// Token: 0x04008BBC RID: 35772
		private static readonly IntPtr NativeFieldInfoPtr_modifyTier1Amount;

		// Token: 0x04008BBD RID: 35773
		private static readonly IntPtr NativeFieldInfoPtr_modifyTier2Amount;

		// Token: 0x04008BBE RID: 35774
		private static readonly IntPtr NativeFieldInfoPtr_modifyTier3Amount;

		// Token: 0x04008BBF RID: 35775
		private static readonly IntPtr NativeFieldInfoPtr__embeddedInputPromptUI;

		// Token: 0x04008BC0 RID: 35776
		private static readonly IntPtr NativeFieldInfoPtr_categoryButtons;

		// Token: 0x04008BC1 RID: 35777
		private static readonly IntPtr NativeFieldInfoPtr_categoryFilter;

		// Token: 0x04008BC2 RID: 35778
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x04008BC3 RID: 35779
		private static readonly IntPtr NativeFieldInfoPtr_listingUI;

		// Token: 0x04008BC4 RID: 35780
		private static readonly IntPtr NativeFieldInfoPtr_selectedListing;

		// Token: 0x04008BC5 RID: 35781
		private static readonly IntPtr NativeFieldInfoPtr_amountSelectorMouseUp;

		// Token: 0x04008BC6 RID: 35782
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04008BC7 RID: 35783
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04008BC8 RID: 35784
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04008BC9 RID: 35785
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04008BCA RID: 35786
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008BCB RID: 35787
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04008BCC RID: 35788
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04008BCD RID: 35789
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04008BCE RID: 35790
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04008BCF RID: 35791
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04008BD0 RID: 35792
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04008BD1 RID: 35793
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04008BD2 RID: 35794
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04008BD3 RID: 35795
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04008BD4 RID: 35796
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04008BD5 RID: 35797
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04008BD6 RID: 35798
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04008BD7 RID: 35799
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04008BD8 RID: 35800
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04008BD9 RID: 35801
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04008BDA RID: 35802
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04008BDB RID: 35803
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008BDC RID: 35804
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Protected_Void_0;

		// Token: 0x04008BDD RID: 35805
		private static readonly IntPtr NativeMethodInfoPtr_OnWeekPass_Protected_Void_0;

		// Token: 0x04008BDE RID: 35806
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x04008BDF RID: 35807
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008BE0 RID: 35808
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008BE1 RID: 35809
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x04008BE2 RID: 35810
		private static readonly IntPtr NativeMethodInfoPtr_Hint_Private_Void_0;

		// Token: 0x04008BE3 RID: 35811
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04008BE4 RID: 35812
		private static readonly IntPtr NativeMethodInfoPtr_CreateListingUI_Private_Void_ShopListing_0;

		// Token: 0x04008BE5 RID: 35813
		private static readonly IntPtr NativeMethodInfoPtr_SelectCategory_Public_Void_EShopCategory_0;

		// Token: 0x04008BE6 RID: 35814
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Virtual_New_Void_ListingUI_0;

		// Token: 0x04008BE7 RID: 35815
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Virtual_New_Void_ListingUI_0;

		// Token: 0x04008BE8 RID: 35816
		private static readonly IntPtr NativeMethodInfoPtr_AdjustAmount_Public_Void_ListingUI_Int32_0;

		// Token: 0x04008BE9 RID: 35817
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Public_Virtual_New_Void_ListingUI_Int32_0;

		// Token: 0x04008BEA RID: 35818
		private static readonly IntPtr NativeMethodInfoPtr_CategorySelected_Public_Void_EShopCategory_0;

		// Token: 0x04008BEB RID: 35819
		private static readonly IntPtr NativeMethodInfoPtr_PullStockVariables_Private_Void_0;

		// Token: 0x04008BEC RID: 35820
		private static readonly IntPtr NativeMethodInfoPtr_DeselectCurrentCategory_Private_Void_0;

		// Token: 0x04008BED RID: 35821
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownItems_Private_Void_0;

		// Token: 0x04008BEE RID: 35822
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShownItemsNextFrame_Private_IEnumerator_0;

		// Token: 0x04008BEF RID: 35823
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUnlockStatus_Private_Void_0;

		// Token: 0x04008BF0 RID: 35824
		private static readonly IntPtr NativeMethodInfoPtr_RestockAllListings_Private_Void_0;

		// Token: 0x04008BF1 RID: 35825
		private static readonly IntPtr NativeMethodInfoPtr_CanCartFitItem_Public_Boolean_ShopListing_0;

		// Token: 0x04008BF2 RID: 35826
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_0;

		// Token: 0x04008BF3 RID: 35827
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFit_Public_Boolean_List_1_ItemSlot_0;

		// Token: 0x04008BF4 RID: 35828
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_New_Boolean_0;

		// Token: 0x04008BF5 RID: 35829
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableSlots_Public_List_1_ItemSlot_0;

		// Token: 0x04008BF6 RID: 35830
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadingBayVehicle_Public_LandVehicle_0;

		// Token: 0x04008BF7 RID: 35831
		private static readonly IntPtr NativeMethodInfoPtr_PlaceItemInDeliveryBay_Public_Void_ItemInstance_0;

		// Token: 0x04008BF8 RID: 35832
		private static readonly IntPtr NativeMethodInfoPtr_QuantitySelected_Public_Void_Int32_0;

		// Token: 0x04008BF9 RID: 35833
		private static readonly IntPtr NativeMethodInfoPtr_OpenAmountSelector_Public_Void_ListingUI_0;

		// Token: 0x04008BFA RID: 35834
		private static readonly IntPtr NativeMethodInfoPtr_DropdownClicked_Private_Void_ListingUI_0;

		// Token: 0x04008BFB RID: 35835
		private static readonly IntPtr NativeMethodInfoPtr_QuantitySelectedNew_Private_Void_Int32_0;

		// Token: 0x04008BFC RID: 35836
		private static readonly IntPtr NativeMethodInfoPtr_EntryHovered_Private_Void_ListingUI_0;

		// Token: 0x04008BFD RID: 35837
		private static readonly IntPtr NativeMethodInfoPtr_EntryUnhovered_Private_Void_0;

		// Token: 0x04008BFE RID: 35838
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ShopData_0;

		// Token: 0x04008BFF RID: 35839
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04008C00 RID: 35840
		private static readonly IntPtr NativeMethodInfoPtr_GetListing_Public_ShopListing_String_0;

		// Token: 0x04008C01 RID: 35841
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_Virtual_New_ShopData_0;

		// Token: 0x04008C02 RID: 35842
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_Final_New_String_0;

		// Token: 0x04008C03 RID: 35843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008C04 RID: 35844
		private static readonly IntPtr NativeMethodInfoPtr__DeselectCurrentCategory_b__92_0_Private_Boolean_CategoryButton_0;

		// Token: 0x04008C05 RID: 35845
		private static readonly IntPtr NativeMethodInfoPtr__DropdownClicked_b__106_0_Private_Void_Single_0;

		// Token: 0x02000D8C RID: 3468
		[OriginalName("Assembly-CSharp.dll", "", "EPaymentType")]
		public enum EPaymentType
		{
			// Token: 0x0400AA28 RID: 43560
			Cash,
			// Token: 0x0400AA29 RID: 43561
			Online,
			// Token: 0x0400AA2A RID: 43562
			PreferCash,
			// Token: 0x0400AA2B RID: 43563
			PreferOnline
		}

		// Token: 0x02000D8D RID: 3469
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FC59 RID: 64601 RVA: 0x003C3094 File Offset: 0x003C1294
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr);
				ShopInterface.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9");
				ShopInterface.__c.NativeFieldInfoPtr___9__70_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__70_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__90_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__90_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__93_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__93_0");
				ShopInterface.__c.NativeFieldInfoPtr___9__93_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__93_1");
				ShopInterface.__c.NativeFieldInfoPtr___9__93_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, "<>9__93_2");
				ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689762);
				ShopInterface.__c.NativeMethodInfoPtr__Awake_b__70_0_Internal_String_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689763);
				ShopInterface.__c.NativeMethodInfoPtr__CategorySelected_b__90_0_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689764);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_0_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689765);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_1_Internal_Int32_ListingUI_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689766);
				ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_2_Internal_Boolean_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr, 100689767);
			}

			// Token: 0x0600FC5A RID: 64602 RVA: 0x003C31B0 File Offset: 0x003C13B0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC5B RID: 64603 RVA: 0x003C31EC File Offset: 0x003C13EC
			[CallerCount(0)]
			public unsafe string _Awake_b__70_0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__Awake_b__70_0_Internal_String_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600FC5C RID: 64604 RVA: 0x003C3234 File Offset: 0x003C1434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CategorySelected_b__90_0(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__CategorySelected_b__90_0_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC5D RID: 64605 RVA: 0x003C3284 File Offset: 0x003C1484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335773, XrefRangeEnd = 335774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshShownItems_b__93_0(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_0_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC5E RID: 64606 RVA: 0x003C32D4 File Offset: 0x003C14D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335774, XrefRangeEnd = 335776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RefreshShownItems_b__93_1(ListingUI x, ListingUI y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_1_Internal_Int32_ListingUI_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC5F RID: 64607 RVA: 0x003C3334 File Offset: 0x003C1534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshShownItems_b__93_2(ListingUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c.NativeMethodInfoPtr__RefreshShownItems_b__93_2_Internal_Boolean_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC60 RID: 64608 RVA: 0x00077767 File Offset: 0x00075967
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CAB RID: 19627
			// (get) Token: 0x0600FC61 RID: 64609 RVA: 0x003C3384 File Offset: 0x003C1584
			// (set) Token: 0x0600FC62 RID: 64610 RVA: 0x00077770 File Offset: 0x00075970
			public unsafe static ShopInterface.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAC RID: 19628
			// (get) Token: 0x0600FC63 RID: 64611 RVA: 0x003C33AC File Offset: 0x003C15AC
			// (set) Token: 0x0600FC64 RID: 64612 RVA: 0x00077782 File Offset: 0x00075982
			public unsafe static Func<ShopListing, string> __9__70_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__70_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ShopListing, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__70_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAD RID: 19629
			// (get) Token: 0x0600FC65 RID: 64613 RVA: 0x003C33D4 File Offset: 0x003C15D4
			// (set) Token: 0x0600FC66 RID: 64614 RVA: 0x00077794 File Offset: 0x00075994
			public unsafe static Predicate<ListingUI> __9__90_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__90_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__90_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAE RID: 19630
			// (get) Token: 0x0600FC67 RID: 64615 RVA: 0x003C33FC File Offset: 0x003C15FC
			// (set) Token: 0x0600FC68 RID: 64616 RVA: 0x000777A6 File Offset: 0x000759A6
			public unsafe static Predicate<ListingUI> __9__93_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAF RID: 19631
			// (get) Token: 0x0600FC69 RID: 64617 RVA: 0x003C3424 File Offset: 0x003C1624
			// (set) Token: 0x0600FC6A RID: 64618 RVA: 0x000777B8 File Offset: 0x000759B8
			public unsafe static Comparison<ListingUI> __9__93_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB0 RID: 19632
			// (get) Token: 0x0600FC6B RID: 64619 RVA: 0x003C344C File Offset: 0x003C164C
			// (set) Token: 0x0600FC6C RID: 64620 RVA: 0x000777CA File Offset: 0x000759CA
			public unsafe static Predicate<ListingUI> __9__93_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ListingUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShopInterface.__c.NativeFieldInfoPtr___9__93_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA2C RID: 43564
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA2D RID: 43565
			private static readonly IntPtr NativeFieldInfoPtr___9__70_0;

			// Token: 0x0400AA2E RID: 43566
			private static readonly IntPtr NativeFieldInfoPtr___9__90_0;

			// Token: 0x0400AA2F RID: 43567
			private static readonly IntPtr NativeFieldInfoPtr___9__93_0;

			// Token: 0x0400AA30 RID: 43568
			private static readonly IntPtr NativeFieldInfoPtr___9__93_1;

			// Token: 0x0400AA31 RID: 43569
			private static readonly IntPtr NativeFieldInfoPtr___9__93_2;

			// Token: 0x0400AA32 RID: 43570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA33 RID: 43571
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__70_0_Internal_String_ShopListing_0;

			// Token: 0x0400AA34 RID: 43572
			private static readonly IntPtr NativeMethodInfoPtr__CategorySelected_b__90_0_Internal_Boolean_ListingUI_0;

			// Token: 0x0400AA35 RID: 43573
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__93_0_Internal_Boolean_ListingUI_0;

			// Token: 0x0400AA36 RID: 43574
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__93_1_Internal_Int32_ListingUI_ListingUI_0;

			// Token: 0x0400AA37 RID: 43575
			private static readonly IntPtr NativeMethodInfoPtr__RefreshShownItems_b__93_2_Internal_Boolean_ListingUI_0;
		}

		// Token: 0x02000D8E RID: 3470
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass110_0")]
		public sealed class __c__DisplayClass110_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC6D RID: 64621 RVA: 0x003C3474 File Offset: 0x003C1674
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass110_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass110_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass110_0.NativeFieldInfoPtr_stockQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr, "stockQuantity");
				ShopInterface.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr, 100689768);
				ShopInterface.__c__DisplayClass110_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr, 100689769);
			}

			// Token: 0x0600FC6E RID: 64622 RVA: 0x003C34DC File Offset: 0x003C16DC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass110_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass110_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC6F RID: 64623 RVA: 0x003C3518 File Offset: 0x003C1718
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335776, XrefRangeEnd = 335778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Load_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass110_0.NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC70 RID: 64624 RVA: 0x000777DC File Offset: 0x000759DC
			public __c__DisplayClass110_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CB1 RID: 19633
			// (get) Token: 0x0600FC71 RID: 64625 RVA: 0x003C3568 File Offset: 0x003C1768
			// (set) Token: 0x0600FC72 RID: 64626 RVA: 0x000777E5 File Offset: 0x000759E5
			public unsafe StringIntPair stockQuantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass110_0.NativeFieldInfoPtr_stockQuantity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass110_0.NativeFieldInfoPtr_stockQuantity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA38 RID: 43576
			private static readonly IntPtr NativeFieldInfoPtr_stockQuantity;

			// Token: 0x0400AA39 RID: 43577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA3A RID: 43578
			private static readonly IntPtr NativeMethodInfoPtr__Load_b__0_Internal_Boolean_ShopListing_0;
		}

		// Token: 0x02000D8F RID: 3471
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass112_0")]
		public sealed class __c__DisplayClass112_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC73 RID: 64627 RVA: 0x003C3598 File Offset: 0x003C1798
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass112_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass112_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass112_0.NativeFieldInfoPtr_itemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr, "itemID");
				ShopInterface.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr, 100689770);
				ShopInterface.__c__DisplayClass112_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr, 100689771);
			}

			// Token: 0x0600FC74 RID: 64628 RVA: 0x003C3600 File Offset: 0x003C1800
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass112_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass112_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass112_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC75 RID: 64629 RVA: 0x003C363C File Offset: 0x003C183C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335778, XrefRangeEnd = 335780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetListing_b__0(ShopListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass112_0.NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC76 RID: 64630 RVA: 0x00077804 File Offset: 0x00075A04
			public __c__DisplayClass112_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CB2 RID: 19634
			// (get) Token: 0x0600FC77 RID: 64631 RVA: 0x003C368C File Offset: 0x003C188C
			// (set) Token: 0x0600FC78 RID: 64632 RVA: 0x0007780D File Offset: 0x00075A0D
			public unsafe string itemID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass112_0.NativeFieldInfoPtr_itemID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass112_0.NativeFieldInfoPtr_itemID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400AA3B RID: 43579
			private static readonly IntPtr NativeFieldInfoPtr_itemID;

			// Token: 0x0400AA3C RID: 43580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA3D RID: 43581
			private static readonly IntPtr NativeMethodInfoPtr__GetListing_b__0_Internal_Boolean_ShopListing_0;
		}

		// Token: 0x02000D90 RID: 3472
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass84_0")]
		public sealed class __c__DisplayClass84_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC79 RID: 64633 RVA: 0x003C36B4 File Offset: 0x003C18B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass84_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass84_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, "<>4__this");
				ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr_ui = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, "ui");
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689772);
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689773);
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689774);
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689775);
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__3_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689776);
				ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr, 100689777);
			}

			// Token: 0x0600FC7A RID: 64634 RVA: 0x003C3780 File Offset: 0x003C1980
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass84_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass84_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC7B RID: 64635 RVA: 0x003C37BC File Offset: 0x003C19BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335780, XrefRangeEnd = 335781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC7C RID: 64636 RVA: 0x003C37F0 File Offset: 0x003C19F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335781, XrefRangeEnd = 335782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC7D RID: 64637 RVA: 0x003C3824 File Offset: 0x003C1A24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335782, XrefRangeEnd = 335783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__2(int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC7E RID: 64638 RVA: 0x003C3864 File Offset: 0x003C1A64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335783, XrefRangeEnd = 335788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__3(int amount)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__3_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC7F RID: 64639 RVA: 0x003C38A4 File Offset: 0x003C1AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335788, XrefRangeEnd = 335790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateListingUI_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass84_0.NativeMethodInfoPtr__CreateListingUI_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC80 RID: 64640 RVA: 0x0007782C File Offset: 0x00075A2C
			public __c__DisplayClass84_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CB3 RID: 19635
			// (get) Token: 0x0600FC81 RID: 64641 RVA: 0x003C38D8 File Offset: 0x003C1AD8
			// (set) Token: 0x0600FC82 RID: 64642 RVA: 0x00077835 File Offset: 0x00075A35
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB4 RID: 19636
			// (get) Token: 0x0600FC83 RID: 64643 RVA: 0x003C3908 File Offset: 0x003C1B08
			// (set) Token: 0x0600FC84 RID: 64644 RVA: 0x00077854 File Offset: 0x00075A54
			public unsafe ListingUI ui
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr_ui);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass84_0.NativeFieldInfoPtr_ui), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA3E RID: 43582
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA3F RID: 43583
			private static readonly IntPtr NativeFieldInfoPtr_ui;

			// Token: 0x0400AA40 RID: 43584
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA41 RID: 43585
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__0_Internal_Void_0;

			// Token: 0x0400AA42 RID: 43586
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__1_Internal_Void_0;

			// Token: 0x0400AA43 RID: 43587
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__2_Internal_Void_Int32_0;

			// Token: 0x0400AA44 RID: 43588
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__3_Internal_Void_Int32_0;

			// Token: 0x0400AA45 RID: 43589
			private static readonly IntPtr NativeMethodInfoPtr__CreateListingUI_b__4_Internal_Void_0;
		}

		// Token: 0x02000D91 RID: 3473
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<>c__DisplayClass85_0")]
		public sealed class __c__DisplayClass85_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC85 RID: 64645 RVA: 0x003C3938 File Offset: 0x003C1B38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass85_0()
			{
				Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<>c__DisplayClass85_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr);
				ShopInterface.__c__DisplayClass85_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr, "category");
				ShopInterface.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr, 100689778);
				ShopInterface.__c__DisplayClass85_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr, 100689779);
			}

			// Token: 0x0600FC86 RID: 64646 RVA: 0x003C39A0 File Offset: 0x003C1BA0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass85_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface.__c__DisplayClass85_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass85_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC87 RID: 64647 RVA: 0x003C39DC File Offset: 0x003C1BDC
			[CallerCount(0)]
			public unsafe bool _SelectCategory_b__0(CategoryButton x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface.__c__DisplayClass85_0.NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC88 RID: 64648 RVA: 0x00077873 File Offset: 0x00075A73
			public __c__DisplayClass85_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CB5 RID: 19637
			// (get) Token: 0x0600FC89 RID: 64649 RVA: 0x003C3A2C File Offset: 0x003C1C2C
			// (set) Token: 0x0600FC8A RID: 64650 RVA: 0x0007787C File Offset: 0x00075A7C
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass85_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface.__c__DisplayClass85_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x0400AA46 RID: 43590
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400AA47 RID: 43591
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA48 RID: 43592
			private static readonly IntPtr NativeMethodInfoPtr__SelectCategory_b__0_Internal_Boolean_CategoryButton_0;
		}

		// Token: 0x02000D92 RID: 3474
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterface+<RefreshShownItemsNextFrame>d__94")]
		public sealed class _RefreshShownItemsNextFrame_d__94 : Il2CppSystem.Object
		{
			// Token: 0x0600FC8B RID: 64651 RVA: 0x003C3A54 File Offset: 0x003C1C54
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshShownItemsNextFrame_d__94()
			{
				Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterface>.NativeClassPtr, "<RefreshShownItemsNextFrame>d__94");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, "<>1__state");
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, "<>2__current");
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, "<>4__this");
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689780);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689781);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689782);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689783);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689784);
				ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr, 100689785);
			}

			// Token: 0x0600FC8C RID: 64652 RVA: 0x003C3B34 File Offset: 0x003C1D34
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshShownItemsNextFrame_d__94(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterface._RefreshShownItemsNextFrame_d__94>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC8D RID: 64653 RVA: 0x003C3B7C File Offset: 0x003C1D7C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC8E RID: 64654 RVA: 0x003C3BB0 File Offset: 0x003C1DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335790, XrefRangeEnd = 335791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004CB9 RID: 19641
			// (get) Token: 0x0600FC8F RID: 64655 RVA: 0x003C3BEC File Offset: 0x003C1DEC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FC90 RID: 64656 RVA: 0x003C3C2C File Offset: 0x003C1E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335791, XrefRangeEnd = 335796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004CBA RID: 19642
			// (get) Token: 0x0600FC91 RID: 64657 RVA: 0x003C3C60 File Offset: 0x003C1E60
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FC92 RID: 64658 RVA: 0x00077897 File Offset: 0x00075A97
			public _RefreshShownItemsNextFrame_d__94(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CB6 RID: 19638
			// (get) Token: 0x0600FC93 RID: 64659 RVA: 0x003C3CA0 File Offset: 0x003C1EA0
			// (set) Token: 0x0600FC94 RID: 64660 RVA: 0x000778A0 File Offset: 0x00075AA0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004CB7 RID: 19639
			// (get) Token: 0x0600FC95 RID: 64661 RVA: 0x003C3CC8 File Offset: 0x003C1EC8
			// (set) Token: 0x0600FC96 RID: 64662 RVA: 0x000778BB File Offset: 0x00075ABB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB8 RID: 19640
			// (get) Token: 0x0600FC97 RID: 64663 RVA: 0x003C3CF8 File Offset: 0x003C1EF8
			// (set) Token: 0x0600FC98 RID: 64664 RVA: 0x000778DA File Offset: 0x00075ADA
			public unsafe ShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterface._RefreshShownItemsNextFrame_d__94.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA49 RID: 43593
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AA4A RID: 43594
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AA4B RID: 43595
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA4C RID: 43596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AA4D RID: 43597
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AA4E RID: 43598
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AA4F RID: 43599
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AA50 RID: 43600
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AA51 RID: 43601
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
