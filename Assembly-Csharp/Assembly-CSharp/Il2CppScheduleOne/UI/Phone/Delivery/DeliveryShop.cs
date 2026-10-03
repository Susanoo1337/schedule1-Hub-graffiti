using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.UI.Shop;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Delivery
{
	// Token: 0x020007B3 RID: 1971
	public class DeliveryShop : MonoBehaviour
	{
		// Token: 0x0600C012 RID: 49170 RVA: 0x00311354 File Offset: 0x0030F554
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryShop()
		{
			Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Delivery", "DeliveryShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr);
			DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<MatchingShop>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<IsOpen>k__BackingField");
			DeliveryShop.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "BackButton");
			DeliveryShop.NativeFieldInfoPtr_ListingContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingContainer");
			DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryFeeLabel");
			DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ItemTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderTotalLabel");
			DeliveryShop.NativeFieldInfoPtr_DeliveryTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DeliveryTimeLabel");
			DeliveryShop.NativeFieldInfoPtr_OrderButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButton");
			DeliveryShop.NativeFieldInfoPtr_OrderButtonNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "OrderButtonNote");
			DeliveryShop.NativeFieldInfoPtr_DestinationDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "DestinationDropdown");
			DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "LoadingDockDropdown");
			DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "MatchingShopInterfaceName");
			DeliveryShop.NativeFieldInfoPtr_ShopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ShopColor");
			DeliveryShop.NativeFieldInfoPtr_AvailableByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "AvailableByDefault");
			DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "ListingEntryPrefab");
			DeliveryShop.NativeFieldInfoPtr__panels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "_panels");
			DeliveryShop.NativeFieldInfoPtr__entriesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "_entriesPanel");
			DeliveryShop.NativeFieldInfoPtr_listingEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "listingEntries");
			DeliveryShop.NativeFieldInfoPtr_destinationProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "destinationProperty");
			DeliveryShop.NativeFieldInfoPtr_loadingDockIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "loadingDockIndex");
			DeliveryShop.NativeFieldInfoPtr__onSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "_onSelect");
			DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688336);
			DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688337);
			DeliveryShop.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688338);
			DeliveryShop.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688339);
			DeliveryShop.NativeMethodInfoPtr_get_OnSelect_Public_get_Action_1_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688340);
			DeliveryShop.NativeMethodInfoPtr_set_OnSelect_Public_set_Void_Action_1_DeliveryShop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688341);
			DeliveryShop.NativeMethodInfoPtr_get_Panels_Public_get_List_1_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688342);
			DeliveryShop.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688343);
			DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688344);
			DeliveryShop.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688345);
			DeliveryShop.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688346);
			DeliveryShop.NativeMethodInfoPtr_SubmitOrder_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688347);
			DeliveryShop.NativeMethodInfoPtr_GetDeliveryTime_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688348);
			DeliveryShop.NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688349);
			DeliveryShop.NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688350);
			DeliveryShop.NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688351);
			DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688352);
			DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688353);
			DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688354);
			DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688355);
			DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688356);
			DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688357);
			DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688358);
			DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688359);
			DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688360);
			DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688361);
			DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688362);
			DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688363);
			DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688364);
			DeliveryShop.NativeMethodInfoPtr_GetDeliveryFee_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688365);
			DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688366);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688367);
			DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688368);
			DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688369);
			DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_0_Private_Boolean_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688370);
			DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688371);
			DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, 100688372);
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600C013 RID: 49171 RVA: 0x00311820 File Offset: 0x0030FA20
		// (set) Token: 0x0600C014 RID: 49172 RVA: 0x00311860 File Offset: 0x0030FA60
		public unsafe ShopInterface MatchingShop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0600C015 RID: 49173 RVA: 0x003118A4 File Offset: 0x0030FAA4
		// (set) Token: 0x0600C016 RID: 49174 RVA: 0x003118E0 File Offset: 0x0030FAE0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0600C017 RID: 49175 RVA: 0x00311920 File Offset: 0x0030FB20
		// (set) Token: 0x0600C018 RID: 49176 RVA: 0x00311960 File Offset: 0x0030FB60
		public unsafe Action<DeliveryShop> OnSelect
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_OnSelect_Public_get_Action_1_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<DeliveryShop>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_set_OnSelect_Public_set_Void_Action_1_DeliveryShop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0600C019 RID: 49177 RVA: 0x003119A4 File Offset: 0x0030FBA4
		public unsafe List<UIPanel> Panels
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_get_Panels_Public_get_List_1_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<UIPanel>>(intPtr3) : null;
			}
		}

		// Token: 0x0600C01A RID: 49178 RVA: 0x003119E4 File Offset: 0x0030FBE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319312, RefRangeEnd = 319313, XrefRangeStart = 319223, XrefRangeEnd = 319312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C01B RID: 49179 RVA: 0x00311A18 File Offset: 0x0030FC18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319313, XrefRangeEnd = 319319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C01C RID: 49180 RVA: 0x00311A4C File Offset: 0x0030FC4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319319, RefRangeEnd = 319320, XrefRangeStart = 319319, XrefRangeEnd = 319319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C01D RID: 49181 RVA: 0x00311A80 File Offset: 0x0030FC80
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 33100, RefRangeEnd = 33113, XrefRangeStart = 33100, XrefRangeEnd = 33113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C01E RID: 49182 RVA: 0x00311AB4 File Offset: 0x0030FCB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319419, RefRangeEnd = 319421, XrefRangeStart = 319320, XrefRangeEnd = 319419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubmitOrder(string originalDeliveryID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(originalDeliveryID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_SubmitOrder_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C01F RID: 49183 RVA: 0x00311AF8 File Offset: 0x0030FCF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319435, RefRangeEnd = 319437, XrefRangeStart = 319421, XrefRangeEnd = 319435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetDeliveryTime(int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetDeliveryTime_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C020 RID: 49184 RVA: 0x00311B44 File Offset: 0x0030FD44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319466, RefRangeEnd = 319467, XrefRangeStart = 319437, XrefRangeEnd = 319466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reorder(DeliveryReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C021 RID: 49185 RVA: 0x00311B88 File Offset: 0x0030FD88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319486, RefRangeEnd = 319487, XrefRangeStart = 319467, XrefRangeEnd = 319486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanReorder(DeliveryReceipt receipt, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C022 RID: 49186 RVA: 0x00311BF0 File Offset: 0x0030FDF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319508, RefRangeEnd = 319510, XrefRangeStart = 319487, XrefRangeEnd = 319508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDeliveryCost(DeliveryReceipt receipt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C023 RID: 49187 RVA: 0x00311C40 File Offset: 0x0030FE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319528, RefRangeEnd = 319529, XrefRangeStart = 319510, XrefRangeEnd = 319528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshShop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshShop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C024 RID: 49188 RVA: 0x00311C74 File Offset: 0x0030FE74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319548, RefRangeEnd = 319549, XrefRangeStart = 319529, XrefRangeEnd = 319548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_ResetCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C025 RID: 49189 RVA: 0x00311CA8 File Offset: 0x0030FEA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319563, RefRangeEnd = 319565, XrefRangeStart = 319549, XrefRangeEnd = 319563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshCart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C026 RID: 49190 RVA: 0x00311CDC File Offset: 0x0030FEDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319568, RefRangeEnd = 319571, XrefRangeStart = 319565, XrefRangeEnd = 319568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshOrderButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x00311D10 File Offset: 0x0030FF10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319601, RefRangeEnd = 319603, XrefRangeStart = 319571, XrefRangeEnd = 319601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanOrder(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x00311D68 File Offset: 0x0030FF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319603, XrefRangeEnd = 319608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasActiveDelivery()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C029 RID: 49193 RVA: 0x00311DA4 File Offset: 0x0030FFA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319622, RefRangeEnd = 319623, XrefRangeStart = 319608, XrefRangeEnd = 319622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WillCartFitInVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x00311DE0 File Offset: 0x0030FFE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319676, RefRangeEnd = 319677, XrefRangeStart = 319623, XrefRangeEnd = 319676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDestinationUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C02B RID: 49195 RVA: 0x00311E14 File Offset: 0x00310014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319677, XrefRangeEnd = 319689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C02C RID: 49196 RVA: 0x00311E54 File Offset: 0x00310054
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 319717, RefRangeEnd = 319722, XrefRangeStart = 319689, XrefRangeEnd = 319717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetPotentialDestinations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x0600C02D RID: 49197 RVA: 0x00311E94 File Offset: 0x00310094
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319758, RefRangeEnd = 319761, XrefRangeStart = 319722, XrefRangeEnd = 319758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLoadingDockUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C02E RID: 49198 RVA: 0x00311EC8 File Offset: 0x003100C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45659, RefRangeEnd = 45661, XrefRangeStart = 45659, XrefRangeEnd = 45661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadingDockDropdownSelected(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C02F RID: 49199 RVA: 0x00311F08 File Offset: 0x00310108
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 319776, RefRangeEnd = 319779, XrefRangeStart = 319761, XrefRangeEnd = 319776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCartCost()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetCartCost_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C030 RID: 49200 RVA: 0x00311F44 File Offset: 0x00310144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 319789, RefRangeEnd = 319793, XrefRangeStart = 319779, XrefRangeEnd = 319789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetDeliveryFee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetDeliveryFee_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C031 RID: 49201 RVA: 0x00311F80 File Offset: 0x00310180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 319807, RefRangeEnd = 319809, XrefRangeStart = 319793, XrefRangeEnd = 319807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetOrderItemCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C032 RID: 49202 RVA: 0x00311FBC File Offset: 0x003101BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319850, RefRangeEnd = 319851, XrefRangeStart = 319809, XrefRangeEnd = 319850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntryOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C033 RID: 49203 RVA: 0x00311FF0 File Offset: 0x003101F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 319871, RefRangeEnd = 319872, XrefRangeStart = 319851, XrefRangeEnd = 319871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshEntriesLocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C034 RID: 49204 RVA: 0x00312024 File Offset: 0x00310224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319872, XrefRangeEnd = 319884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C035 RID: 49205 RVA: 0x00312060 File Offset: 0x00310260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319884, XrefRangeEnd = 319886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Initialize_b__33_0(ShopInterface x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_0_Private_Boolean_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600C036 RID: 49206 RVA: 0x003120B0 File Offset: 0x003102B0
		[CallerCount(0)]
		public unsafe void _Initialize_b__33_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C037 RID: 49207 RVA: 0x003120E4 File Offset: 0x003102E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319886, XrefRangeEnd = 319889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__33_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.NativeMethodInfoPtr__Initialize_b__33_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C038 RID: 49208 RVA: 0x00059EBD File Offset: 0x000580BD
		public DeliveryShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A19 RID: 14873
		// (get) Token: 0x0600C039 RID: 49209 RVA: 0x00312118 File Offset: 0x00310318
		// (set) Token: 0x0600C03A RID: 49210 RVA: 0x00059EC6 File Offset: 0x000580C6
		public unsafe ShopInterface _MatchingShop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__MatchingShop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A1A RID: 14874
		// (get) Token: 0x0600C03B RID: 49211 RVA: 0x00312148 File Offset: 0x00310348
		// (set) Token: 0x0600C03C RID: 49212 RVA: 0x00059EE5 File Offset: 0x000580E5
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003A1B RID: 14875
		// (get) Token: 0x0600C03D RID: 49213 RVA: 0x00312170 File Offset: 0x00310370
		// (set) Token: 0x0600C03E RID: 49214 RVA: 0x00059F00 File Offset: 0x00058100
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A1C RID: 14876
		// (get) Token: 0x0600C03F RID: 49215 RVA: 0x003121A0 File Offset: 0x003103A0
		// (set) Token: 0x0600C040 RID: 49216 RVA: 0x00059F1F File Offset: 0x0005811F
		public unsafe RectTransform ListingContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A1D RID: 14877
		// (get) Token: 0x0600C041 RID: 49217 RVA: 0x003121D0 File Offset: 0x003103D0
		// (set) Token: 0x0600C042 RID: 49218 RVA: 0x00059F3E File Offset: 0x0005813E
		public unsafe Text DeliveryFeeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryFeeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A1E RID: 14878
		// (get) Token: 0x0600C043 RID: 49219 RVA: 0x00312200 File Offset: 0x00310400
		// (set) Token: 0x0600C044 RID: 49220 RVA: 0x00059F5D File Offset: 0x0005815D
		public unsafe Text ItemTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ItemTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A1F RID: 14879
		// (get) Token: 0x0600C045 RID: 49221 RVA: 0x00312230 File Offset: 0x00310430
		// (set) Token: 0x0600C046 RID: 49222 RVA: 0x00059F7C File Offset: 0x0005817C
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x0600C047 RID: 49223 RVA: 0x00312260 File Offset: 0x00310460
		// (set) Token: 0x0600C048 RID: 49224 RVA: 0x00059F9B File Offset: 0x0005819B
		public unsafe Text DeliveryTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DeliveryTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x0600C049 RID: 49225 RVA: 0x00312290 File Offset: 0x00310490
		// (set) Token: 0x0600C04A RID: 49226 RVA: 0x00059FBA File Offset: 0x000581BA
		public unsafe Button OrderButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600C04B RID: 49227 RVA: 0x003122C0 File Offset: 0x003104C0
		// (set) Token: 0x0600C04C RID: 49228 RVA: 0x00059FD9 File Offset: 0x000581D9
		public unsafe Text OrderButtonNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_OrderButtonNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600C04D RID: 49229 RVA: 0x003122F0 File Offset: 0x003104F0
		// (set) Token: 0x0600C04E RID: 49230 RVA: 0x00059FF8 File Offset: 0x000581F8
		public unsafe Dropdown DestinationDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_DestinationDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600C04F RID: 49231 RVA: 0x00312320 File Offset: 0x00310520
		// (set) Token: 0x0600C050 RID: 49232 RVA: 0x0005A017 File Offset: 0x00058217
		public unsafe Dropdown LoadingDockDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_LoadingDockDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600C051 RID: 49233 RVA: 0x00312350 File Offset: 0x00310550
		// (set) Token: 0x0600C052 RID: 49234 RVA: 0x0005A036 File Offset: 0x00058236
		public unsafe string MatchingShopInterfaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_MatchingShopInterfaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600C053 RID: 49235 RVA: 0x00312378 File Offset: 0x00310578
		// (set) Token: 0x0600C054 RID: 49236 RVA: 0x0005A055 File Offset: 0x00058255
		public unsafe Color ShopColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ShopColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ShopColor)) = value;
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x0600C055 RID: 49237 RVA: 0x003123A0 File Offset: 0x003105A0
		// (set) Token: 0x0600C056 RID: 49238 RVA: 0x0005A070 File Offset: 0x00058270
		public unsafe bool AvailableByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_AvailableByDefault)) = value;
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x0600C057 RID: 49239 RVA: 0x003123C8 File Offset: 0x003105C8
		// (set) Token: 0x0600C058 RID: 49240 RVA: 0x0005A08B File Offset: 0x0005828B
		public unsafe ListingEntry ListingEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_ListingEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0600C059 RID: 49241 RVA: 0x003123F8 File Offset: 0x003105F8
		// (set) Token: 0x0600C05A RID: 49242 RVA: 0x0005A0AA File Offset: 0x000582AA
		public unsafe List<UIPanel> _panels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__panels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIPanel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__panels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0600C05B RID: 49243 RVA: 0x00312428 File Offset: 0x00310628
		// (set) Token: 0x0600C05C RID: 49244 RVA: 0x0005A0C9 File Offset: 0x000582C9
		public unsafe UIPanel _entriesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__entriesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__entriesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0600C05D RID: 49245 RVA: 0x00312458 File Offset: 0x00310658
		// (set) Token: 0x0600C05E RID: 49246 RVA: 0x0005A0E8 File Offset: 0x000582E8
		public unsafe List<ListingEntry> listingEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ListingEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_listingEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0600C05F RID: 49247 RVA: 0x00312488 File Offset: 0x00310688
		// (set) Token: 0x0600C060 RID: 49248 RVA: 0x0005A107 File Offset: 0x00058307
		public unsafe Property destinationProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_destinationProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0600C061 RID: 49249 RVA: 0x003124B8 File Offset: 0x003106B8
		// (set) Token: 0x0600C062 RID: 49250 RVA: 0x0005A126 File Offset: 0x00058326
		public unsafe int loadingDockIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr_loadingDockIndex)) = value;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0600C063 RID: 49251 RVA: 0x003124E0 File Offset: 0x003106E0
		// (set) Token: 0x0600C064 RID: 49252 RVA: 0x0005A141 File Offset: 0x00058341
		public unsafe Action<DeliveryShop> _onSelect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__onSelect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DeliveryShop>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.NativeFieldInfoPtr__onSelect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008371 RID: 33649
		private static readonly IntPtr NativeFieldInfoPtr__MatchingShop_k__BackingField;

		// Token: 0x04008372 RID: 33650
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008373 RID: 33651
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04008374 RID: 33652
		private static readonly IntPtr NativeFieldInfoPtr_ListingContainer;

		// Token: 0x04008375 RID: 33653
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryFeeLabel;

		// Token: 0x04008376 RID: 33654
		private static readonly IntPtr NativeFieldInfoPtr_ItemTotalLabel;

		// Token: 0x04008377 RID: 33655
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x04008378 RID: 33656
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryTimeLabel;

		// Token: 0x04008379 RID: 33657
		private static readonly IntPtr NativeFieldInfoPtr_OrderButton;

		// Token: 0x0400837A RID: 33658
		private static readonly IntPtr NativeFieldInfoPtr_OrderButtonNote;

		// Token: 0x0400837B RID: 33659
		private static readonly IntPtr NativeFieldInfoPtr_DestinationDropdown;

		// Token: 0x0400837C RID: 33660
		private static readonly IntPtr NativeFieldInfoPtr_LoadingDockDropdown;

		// Token: 0x0400837D RID: 33661
		private static readonly IntPtr NativeFieldInfoPtr_MatchingShopInterfaceName;

		// Token: 0x0400837E RID: 33662
		private static readonly IntPtr NativeFieldInfoPtr_ShopColor;

		// Token: 0x0400837F RID: 33663
		private static readonly IntPtr NativeFieldInfoPtr_AvailableByDefault;

		// Token: 0x04008380 RID: 33664
		private static readonly IntPtr NativeFieldInfoPtr_ListingEntryPrefab;

		// Token: 0x04008381 RID: 33665
		private static readonly IntPtr NativeFieldInfoPtr__panels;

		// Token: 0x04008382 RID: 33666
		private static readonly IntPtr NativeFieldInfoPtr__entriesPanel;

		// Token: 0x04008383 RID: 33667
		private static readonly IntPtr NativeFieldInfoPtr_listingEntries;

		// Token: 0x04008384 RID: 33668
		private static readonly IntPtr NativeFieldInfoPtr_destinationProperty;

		// Token: 0x04008385 RID: 33669
		private static readonly IntPtr NativeFieldInfoPtr_loadingDockIndex;

		// Token: 0x04008386 RID: 33670
		private static readonly IntPtr NativeFieldInfoPtr__onSelect;

		// Token: 0x04008387 RID: 33671
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchingShop_Public_get_ShopInterface_0;

		// Token: 0x04008388 RID: 33672
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchingShop_Private_set_Void_ShopInterface_0;

		// Token: 0x04008389 RID: 33673
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400838A RID: 33674
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400838B RID: 33675
		private static readonly IntPtr NativeMethodInfoPtr_get_OnSelect_Public_get_Action_1_DeliveryShop_0;

		// Token: 0x0400838C RID: 33676
		private static readonly IntPtr NativeMethodInfoPtr_set_OnSelect_Public_set_Void_Action_1_DeliveryShop_0;

		// Token: 0x0400838D RID: 33677
		private static readonly IntPtr NativeMethodInfoPtr_get_Panels_Public_get_List_1_UIPanel_0;

		// Token: 0x0400838E RID: 33678
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400838F RID: 33679
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04008390 RID: 33680
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04008391 RID: 33681
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04008392 RID: 33682
		private static readonly IntPtr NativeMethodInfoPtr_SubmitOrder_Public_Void_String_0;

		// Token: 0x04008393 RID: 33683
		private static readonly IntPtr NativeMethodInfoPtr_GetDeliveryTime_Private_Int32_Int32_0;

		// Token: 0x04008394 RID: 33684
		private static readonly IntPtr NativeMethodInfoPtr_Reorder_Public_Void_DeliveryReceipt_0;

		// Token: 0x04008395 RID: 33685
		private static readonly IntPtr NativeMethodInfoPtr_CanReorder_Public_Boolean_DeliveryReceipt_byref_String_0;

		// Token: 0x04008396 RID: 33686
		private static readonly IntPtr NativeMethodInfoPtr_GetDeliveryCost_Public_Single_DeliveryReceipt_0;

		// Token: 0x04008397 RID: 33687
		private static readonly IntPtr NativeMethodInfoPtr_RefreshShop_Public_Void_0;

		// Token: 0x04008398 RID: 33688
		private static readonly IntPtr NativeMethodInfoPtr_ResetCart_Public_Void_0;

		// Token: 0x04008399 RID: 33689
		private static readonly IntPtr NativeMethodInfoPtr_RefreshCart_Private_Void_0;

		// Token: 0x0400839A RID: 33690
		private static readonly IntPtr NativeMethodInfoPtr_RefreshOrderButton_Private_Void_0;

		// Token: 0x0400839B RID: 33691
		private static readonly IntPtr NativeMethodInfoPtr_CanOrder_Public_Boolean_byref_String_0;

		// Token: 0x0400839C RID: 33692
		private static readonly IntPtr NativeMethodInfoPtr_HasActiveDelivery_Public_Boolean_0;

		// Token: 0x0400839D RID: 33693
		private static readonly IntPtr NativeMethodInfoPtr_WillCartFitInVehicle_Public_Boolean_0;

		// Token: 0x0400839E RID: 33694
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDestinationUI_Public_Void_0;

		// Token: 0x0400839F RID: 33695
		private static readonly IntPtr NativeMethodInfoPtr_DestinationDropdownSelected_Private_Void_Int32_0;

		// Token: 0x040083A0 RID: 33696
		private static readonly IntPtr NativeMethodInfoPtr_GetPotentialDestinations_Private_List_1_Property_0;

		// Token: 0x040083A1 RID: 33697
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLoadingDockUI_Public_Void_0;

		// Token: 0x040083A2 RID: 33698
		private static readonly IntPtr NativeMethodInfoPtr_LoadingDockDropdownSelected_Private_Void_Int32_0;

		// Token: 0x040083A3 RID: 33699
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCost_Private_Single_0;

		// Token: 0x040083A4 RID: 33700
		private static readonly IntPtr NativeMethodInfoPtr_GetDeliveryFee_Private_Single_0;

		// Token: 0x040083A5 RID: 33701
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderItemCount_Private_Int32_0;

		// Token: 0x040083A6 RID: 33702
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntryOrder_Private_Void_0;

		// Token: 0x040083A7 RID: 33703
		private static readonly IntPtr NativeMethodInfoPtr_RefreshEntriesLocked_Private_Void_0;

		// Token: 0x040083A8 RID: 33704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040083A9 RID: 33705
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_0_Private_Boolean_ShopInterface_0;

		// Token: 0x040083AA RID: 33706
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_1_Private_Void_0;

		// Token: 0x040083AB RID: 33707
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__33_2_Private_Void_0;

		// Token: 0x02000D38 RID: 3384
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryShop+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F970 RID: 63856 RVA: 0x003BAB78 File Offset: 0x003B8D78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr);
				DeliveryShop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr, "<>9");
				DeliveryShop.__c.NativeFieldInfoPtr___9__51_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr, "<>9__51_0");
				DeliveryShop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr, 100688374);
				DeliveryShop.__c.NativeMethodInfoPtr__GetPotentialDestinations_b__51_0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr, 100688375);
			}

			// Token: 0x0600F971 RID: 63857 RVA: 0x003BABF4 File Offset: 0x003B8DF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F972 RID: 63858 RVA: 0x003BAC30 File Offset: 0x003B8E30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319192, XrefRangeEnd = 319193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetPotentialDestinations_b__51_0(Property x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c.NativeMethodInfoPtr__GetPotentialDestinations_b__51_0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F973 RID: 63859 RVA: 0x00075FD7 File Offset: 0x000741D7
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BD7 RID: 19415
			// (get) Token: 0x0600F974 RID: 63860 RVA: 0x003BAC80 File Offset: 0x003B8E80
			// (set) Token: 0x0600F975 RID: 63861 RVA: 0x00075FE0 File Offset: 0x000741E0
			public unsafe static DeliveryShop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryShop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryShop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryShop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BD8 RID: 19416
			// (get) Token: 0x0600F976 RID: 63862 RVA: 0x003BACA8 File Offset: 0x003B8EA8
			// (set) Token: 0x0600F977 RID: 63863 RVA: 0x00075FF2 File Offset: 0x000741F2
			public unsafe static Func<Property, bool> __9__51_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeliveryShop.__c.NativeFieldInfoPtr___9__51_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Property, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeliveryShop.__c.NativeFieldInfoPtr___9__51_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A879 RID: 43129
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A87A RID: 43130
			private static readonly IntPtr NativeFieldInfoPtr___9__51_0;

			// Token: 0x0400A87B RID: 43131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A87C RID: 43132
			private static readonly IntPtr NativeMethodInfoPtr__GetPotentialDestinations_b__51_0_Internal_Boolean_Property_0;
		}

		// Token: 0x02000D39 RID: 3385
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryShop+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F978 RID: 63864 RVA: 0x003BACD0 File Offset: 0x003B8ED0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr);
				DeliveryShop.__c__DisplayClass39_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr, "item");
				DeliveryShop.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr, 100688376);
				DeliveryShop.__c__DisplayClass39_0.NativeMethodInfoPtr__Reorder_b__0_Internal_Boolean_ListingEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr, 100688377);
			}

			// Token: 0x0600F979 RID: 63865 RVA: 0x003BAD38 File Offset: 0x003B8F38
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F97A RID: 63866 RVA: 0x003BAD74 File Offset: 0x003B8F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319193, XrefRangeEnd = 319223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Reorder_b__0(ListingEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c__DisplayClass39_0.NativeMethodInfoPtr__Reorder_b__0_Internal_Boolean_ListingEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F97B RID: 63867 RVA: 0x00076004 File Offset: 0x00074204
			public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BD9 RID: 19417
			// (get) Token: 0x0600F97C RID: 63868 RVA: 0x003BADC4 File Offset: 0x003B8FC4
			// (set) Token: 0x0600F97D RID: 63869 RVA: 0x0007600D File Offset: 0x0007420D
			public unsafe StringIntPair item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.__c__DisplayClass39_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.__c__DisplayClass39_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A87D RID: 43133
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400A87E RID: 43134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A87F RID: 43135
			private static readonly IntPtr NativeMethodInfoPtr__Reorder_b__0_Internal_Boolean_ListingEntry_0;
		}

		// Token: 0x02000D3A RID: 3386
		[ObfuscatedName("ScheduleOne.UI.Phone.Delivery.DeliveryShop+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F97E RID: 63870 RVA: 0x003BADF4 File Offset: 0x003B8FF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeliveryShop>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr);
				DeliveryShop.__c__DisplayClass41_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr, "item");
				DeliveryShop.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr, 100688378);
				DeliveryShop.__c__DisplayClass41_0.NativeMethodInfoPtr__GetDeliveryCost_b__0_Internal_Boolean_ListingEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr, 100688379);
			}

			// Token: 0x0600F97F RID: 63871 RVA: 0x003BAE5C File Offset: 0x003B905C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryShop.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F980 RID: 63872 RVA: 0x003BAE98 File Offset: 0x003B9098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetDeliveryCost_b__0(ListingEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryShop.__c__DisplayClass41_0.NativeMethodInfoPtr__GetDeliveryCost_b__0_Internal_Boolean_ListingEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F981 RID: 63873 RVA: 0x0007602C File Offset: 0x0007422C
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BDA RID: 19418
			// (get) Token: 0x0600F982 RID: 63874 RVA: 0x003BAEE8 File Offset: 0x003B90E8
			// (set) Token: 0x0600F983 RID: 63875 RVA: 0x00076035 File Offset: 0x00074235
			public unsafe StringIntPair item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.__c__DisplayClass41_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringIntPair>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryShop.__c__DisplayClass41_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A880 RID: 43136
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400A881 RID: 43137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A882 RID: 43138
			private static readonly IntPtr NativeMethodInfoPtr__GetDeliveryCost_b__0_Internal_Boolean_ListingEntry_0;
		}
	}
}
