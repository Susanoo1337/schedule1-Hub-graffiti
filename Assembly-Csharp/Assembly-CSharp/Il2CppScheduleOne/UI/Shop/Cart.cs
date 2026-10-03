using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000833 RID: 2099
	public class Cart : MonoBehaviour
	{
		// Token: 0x0600CBEE RID: 52206 RVA: 0x00335950 File Offset: 0x00333B50
		// Note: this type is marked as 'beforefieldinit'.
		static Cart()
		{
			Il2CppClassPointerStore<Cart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "Cart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart>.NativeClassPtr);
			Cart.NativeFieldInfoPtr_Shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "Shop");
			Cart.NativeFieldInfoPtr_CartEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartEntryContainer");
			Cart.NativeFieldInfoPtr_ProblemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "ProblemText");
			Cart.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "WarningText");
			Cart.NativeFieldInfoPtr_CartContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartContainer");
			Cart.NativeFieldInfoPtr_CartArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "CartArea");
			Cart.NativeFieldInfoPtr_TotalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "TotalText");
			Cart.NativeFieldInfoPtr_LoadVehicleToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "LoadVehicleToggle");
			Cart.NativeFieldInfoPtr_buyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "buyButton");
			Cart.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "EntryPrefab");
			Cart.NativeFieldInfoPtr_cartDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartDictionary");
			Cart.NativeFieldInfoPtr_cartEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartEntries");
			Cart.NativeFieldInfoPtr_cartPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "cartPanel");
			Cart.NativeFieldInfoPtr_buyTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "buyTrigger");
			Cart.NativeFieldInfoPtr__onRemoveListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart>.NativeClassPtr, "_onRemoveListing");
			Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689589);
			Cart.NativeMethodInfoPtr_SetItemQuantity_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689590);
			Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689591);
			Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689592);
			Cart.NativeMethodInfoPtr_RemoveListing_Private_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689593);
			Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689594);
			Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689595);
			Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689596);
			Cart.NativeMethodInfoPtr_Buy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689597);
			Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689598);
			Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689599);
			Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689600);
			Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689601);
			Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689602);
			Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689603);
			Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689604);
			Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689605);
			Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689606);
			Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689607);
			Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689608);
			Cart.NativeMethodInfoPtr_SubscribeToOnRemoveListing_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689609);
			Cart.NativeMethodInfoPtr_UnsubscribeFromOnRemoveListing_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689610);
			Cart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart>.NativeClassPtr, 100689611);
		}

		// Token: 0x0600CBEF RID: 52207 RVA: 0x00335C78 File Offset: 0x00333E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334605, XrefRangeEnd = 334615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cart.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF0 RID: 52208 RVA: 0x00335CB4 File Offset: 0x00333EB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334628, RefRangeEnd = 334633, XrefRangeStart = 334615, XrefRangeEnd = 334628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemQuantity(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_SetItemQuantity_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF1 RID: 52209 RVA: 0x00335D04 File Offset: 0x00333F04
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 334668, RefRangeEnd = 334675, XrefRangeStart = 334633, XrefRangeEnd = 334668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF2 RID: 52210 RVA: 0x00335D54 File Offset: 0x00333F54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334696, RefRangeEnd = 334700, XrefRangeStart = 334675, XrefRangeEnd = 334696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF3 RID: 52211 RVA: 0x00335DA4 File Offset: 0x00333FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334700, XrefRangeEnd = 334706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListing(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_RemoveListing_Private_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF4 RID: 52212 RVA: 0x00335DE8 File Offset: 0x00333FE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334726, RefRangeEnd = 334727, XrefRangeStart = 334706, XrefRangeEnd = 334726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_ClearCart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF5 RID: 52213 RVA: 0x00335E1C File Offset: 0x0033401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334727, XrefRangeEnd = 334731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCartCount(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CBF6 RID: 52214 RVA: 0x00335E6C File Offset: 0x0033406C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334731, XrefRangeEnd = 334733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPlayerAffordCart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CBF7 RID: 52215 RVA: 0x00335EA8 File Offset: 0x003340A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334733, XrefRangeEnd = 334785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Buy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_Buy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF8 RID: 52216 RVA: 0x00335EDC File Offset: 0x003340DC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334866, RefRangeEnd = 334872, XrefRangeStart = 334785, XrefRangeEnd = 334866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBF9 RID: 52217 RVA: 0x00335F10 File Offset: 0x00334110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334899, RefRangeEnd = 334903, XrefRangeStart = 334872, XrefRangeEnd = 334899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBFA RID: 52218 RVA: 0x00335F44 File Offset: 0x00334144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334915, RefRangeEnd = 334918, XrefRangeStart = 334903, XrefRangeEnd = 334915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateProblem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateProblem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBFB RID: 52219 RVA: 0x00335F78 File Offset: 0x00334178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334935, RefRangeEnd = 334937, XrefRangeStart = 334918, XrefRangeEnd = 334935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCheckout(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600CBFC RID: 52220 RVA: 0x00335FD0 File Offset: 0x003341D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334955, RefRangeEnd = 334956, XrefRangeStart = 334937, XrefRangeEnd = 334955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetWarning(out string warning)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			warning = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600CBFD RID: 52221 RVA: 0x00336028 File Offset: 0x00334228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334956, XrefRangeEnd = 334964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLoadVehicleToggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CBFE RID: 52222 RVA: 0x0033605C File Offset: 0x0033425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334964, XrefRangeEnd = 334978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetItemSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetItemSum_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CBFF RID: 52223 RVA: 0x00336098 File Offset: 0x00334298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 334995, RefRangeEnd = 334999, XrefRangeStart = 334978, XrefRangeEnd = 334995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPriceSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetPriceSum_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CC00 RID: 52224 RVA: 0x003360D4 File Offset: 0x003342D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334999, XrefRangeEnd = 335014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry GetEntry(ShopListing listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr3) : null;
		}

		// Token: 0x0600CC01 RID: 52225 RVA: 0x00336124 File Offset: 0x00334324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335014, XrefRangeEnd = 335024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverMenuArea()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CC02 RID: 52226 RVA: 0x00336160 File Offset: 0x00334360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335024, XrefRangeEnd = 335038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSlotRequirement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CC03 RID: 52227 RVA: 0x0033619C File Offset: 0x0033439C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335038, XrefRangeEnd = 335046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SubscribeToOnRemoveListing(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_SubscribeToOnRemoveListing_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC04 RID: 52228 RVA: 0x003361E0 File Offset: 0x003343E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335046, XrefRangeEnd = 335054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsubscribeFromOnRemoveListing(Action callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr_UnsubscribeFromOnRemoveListing_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC05 RID: 52229 RVA: 0x00336224 File Offset: 0x00334424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335054, XrefRangeEnd = 335069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC06 RID: 52230 RVA: 0x00060BC5 File Offset: 0x0005EDC5
		public Cart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003DF1 RID: 15857
		// (get) Token: 0x0600CC07 RID: 52231 RVA: 0x00336260 File Offset: 0x00334460
		// (set) Token: 0x0600CC08 RID: 52232 RVA: 0x00060BCE File Offset: 0x0005EDCE
		public unsafe ShopInterface Shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_Shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF2 RID: 15858
		// (get) Token: 0x0600CC09 RID: 52233 RVA: 0x00336290 File Offset: 0x00334490
		// (set) Token: 0x0600CC0A RID: 52234 RVA: 0x00060BED File Offset: 0x0005EDED
		public unsafe RectTransform CartEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF3 RID: 15859
		// (get) Token: 0x0600CC0B RID: 52235 RVA: 0x003362C0 File Offset: 0x003344C0
		// (set) Token: 0x0600CC0C RID: 52236 RVA: 0x00060C0C File Offset: 0x0005EE0C
		public unsafe TextMeshProUGUI ProblemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_ProblemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF4 RID: 15860
		// (get) Token: 0x0600CC0D RID: 52237 RVA: 0x003362F0 File Offset: 0x003344F0
		// (set) Token: 0x0600CC0E RID: 52238 RVA: 0x00060C2B File Offset: 0x0005EE2B
		public unsafe TextMeshProUGUI WarningText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_WarningText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF5 RID: 15861
		// (get) Token: 0x0600CC0F RID: 52239 RVA: 0x00336320 File Offset: 0x00334520
		// (set) Token: 0x0600CC10 RID: 52240 RVA: 0x00060C4A File Offset: 0x0005EE4A
		public unsafe RectTransform CartContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF6 RID: 15862
		// (get) Token: 0x0600CC11 RID: 52241 RVA: 0x00336350 File Offset: 0x00334550
		// (set) Token: 0x0600CC12 RID: 52242 RVA: 0x00060C69 File Offset: 0x0005EE69
		public unsafe Image CartArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_CartArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF7 RID: 15863
		// (get) Token: 0x0600CC13 RID: 52243 RVA: 0x00336380 File Offset: 0x00334580
		// (set) Token: 0x0600CC14 RID: 52244 RVA: 0x00060C88 File Offset: 0x0005EE88
		public unsafe TextMeshProUGUI TotalText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_TotalText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF8 RID: 15864
		// (get) Token: 0x0600CC15 RID: 52245 RVA: 0x003363B0 File Offset: 0x003345B0
		// (set) Token: 0x0600CC16 RID: 52246 RVA: 0x00060CA7 File Offset: 0x0005EEA7
		public unsafe Toggle LoadVehicleToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_LoadVehicleToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DF9 RID: 15865
		// (get) Token: 0x0600CC17 RID: 52247 RVA: 0x003363E0 File Offset: 0x003345E0
		// (set) Token: 0x0600CC18 RID: 52248 RVA: 0x00060CC6 File Offset: 0x0005EEC6
		public unsafe Button buyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_buyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_buyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFA RID: 15866
		// (get) Token: 0x0600CC19 RID: 52249 RVA: 0x00336410 File Offset: 0x00334610
		// (set) Token: 0x0600CC1A RID: 52250 RVA: 0x00060CE5 File Offset: 0x0005EEE5
		public unsafe CartEntry EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFB RID: 15867
		// (get) Token: 0x0600CC1B RID: 52251 RVA: 0x00336440 File Offset: 0x00334640
		// (set) Token: 0x0600CC1C RID: 52252 RVA: 0x00060D04 File Offset: 0x0005EF04
		public unsafe Dictionary<ShopListing, int> cartDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ShopListing, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFC RID: 15868
		// (get) Token: 0x0600CC1D RID: 52253 RVA: 0x00336470 File Offset: 0x00334670
		// (set) Token: 0x0600CC1E RID: 52254 RVA: 0x00060D23 File Offset: 0x0005EF23
		public unsafe List<CartEntry> cartEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFD RID: 15869
		// (get) Token: 0x0600CC1F RID: 52255 RVA: 0x003364A0 File Offset: 0x003346A0
		// (set) Token: 0x0600CC20 RID: 52256 RVA: 0x00060D42 File Offset: 0x0005EF42
		public unsafe UIContentPanel cartPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIContentPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_cartPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFE RID: 15870
		// (get) Token: 0x0600CC21 RID: 52257 RVA: 0x003364D0 File Offset: 0x003346D0
		// (set) Token: 0x0600CC22 RID: 52258 RVA: 0x00060D61 File Offset: 0x0005EF61
		public unsafe UITrigger buyTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_buyTrigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr_buyTrigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003DFF RID: 15871
		// (get) Token: 0x0600CC23 RID: 52259 RVA: 0x00336500 File Offset: 0x00334700
		// (set) Token: 0x0600CC24 RID: 52260 RVA: 0x00060D80 File Offset: 0x0005EF80
		public unsafe Action _onRemoveListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr__onRemoveListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.NativeFieldInfoPtr__onRemoveListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008AD5 RID: 35541
		private static readonly IntPtr NativeFieldInfoPtr_Shop;

		// Token: 0x04008AD6 RID: 35542
		private static readonly IntPtr NativeFieldInfoPtr_CartEntryContainer;

		// Token: 0x04008AD7 RID: 35543
		private static readonly IntPtr NativeFieldInfoPtr_ProblemText;

		// Token: 0x04008AD8 RID: 35544
		private static readonly IntPtr NativeFieldInfoPtr_WarningText;

		// Token: 0x04008AD9 RID: 35545
		private static readonly IntPtr NativeFieldInfoPtr_CartContainer;

		// Token: 0x04008ADA RID: 35546
		private static readonly IntPtr NativeFieldInfoPtr_CartArea;

		// Token: 0x04008ADB RID: 35547
		private static readonly IntPtr NativeFieldInfoPtr_TotalText;

		// Token: 0x04008ADC RID: 35548
		private static readonly IntPtr NativeFieldInfoPtr_LoadVehicleToggle;

		// Token: 0x04008ADD RID: 35549
		private static readonly IntPtr NativeFieldInfoPtr_buyButton;

		// Token: 0x04008ADE RID: 35550
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04008ADF RID: 35551
		private static readonly IntPtr NativeFieldInfoPtr_cartDictionary;

		// Token: 0x04008AE0 RID: 35552
		private static readonly IntPtr NativeFieldInfoPtr_cartEntries;

		// Token: 0x04008AE1 RID: 35553
		private static readonly IntPtr NativeFieldInfoPtr_cartPanel;

		// Token: 0x04008AE2 RID: 35554
		private static readonly IntPtr NativeFieldInfoPtr_buyTrigger;

		// Token: 0x04008AE3 RID: 35555
		private static readonly IntPtr NativeFieldInfoPtr__onRemoveListing;

		// Token: 0x04008AE4 RID: 35556
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04008AE5 RID: 35557
		private static readonly IntPtr NativeMethodInfoPtr_SetItemQuantity_Public_Void_ShopListing_Int32_0;

		// Token: 0x04008AE6 RID: 35558
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04008AE7 RID: 35559
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_ShopListing_Int32_0;

		// Token: 0x04008AE8 RID: 35560
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListing_Private_Void_ShopListing_0;

		// Token: 0x04008AE9 RID: 35561
		private static readonly IntPtr NativeMethodInfoPtr_ClearCart_Public_Void_0;

		// Token: 0x04008AEA RID: 35562
		private static readonly IntPtr NativeMethodInfoPtr_GetCartCount_Public_Int32_ShopListing_0;

		// Token: 0x04008AEB RID: 35563
		private static readonly IntPtr NativeMethodInfoPtr_CanPlayerAffordCart_Public_Boolean_0;

		// Token: 0x04008AEC RID: 35564
		private static readonly IntPtr NativeMethodInfoPtr_Buy_Public_Void_0;

		// Token: 0x04008AED RID: 35565
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEntries_Private_Void_0;

		// Token: 0x04008AEE RID: 35566
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTotal_Private_Void_0;

		// Token: 0x04008AEF RID: 35567
		private static readonly IntPtr NativeMethodInfoPtr_UpdateProblem_Private_Void_0;

		// Token: 0x04008AF0 RID: 35568
		private static readonly IntPtr NativeMethodInfoPtr_CanCheckout_Private_Boolean_byref_String_0;

		// Token: 0x04008AF1 RID: 35569
		private static readonly IntPtr NativeMethodInfoPtr_GetWarning_Private_Boolean_byref_String_0;

		// Token: 0x04008AF2 RID: 35570
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLoadVehicleToggle_Private_Void_0;

		// Token: 0x04008AF3 RID: 35571
		private static readonly IntPtr NativeMethodInfoPtr_GetItemSum_Private_Int32_0;

		// Token: 0x04008AF4 RID: 35572
		private static readonly IntPtr NativeMethodInfoPtr_GetPriceSum_Private_Single_0;

		// Token: 0x04008AF5 RID: 35573
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Private_CartEntry_ShopListing_0;

		// Token: 0x04008AF6 RID: 35574
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverMenuArea_Private_Boolean_0;

		// Token: 0x04008AF7 RID: 35575
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSlotRequirement_Public_Int32_0;

		// Token: 0x04008AF8 RID: 35576
		private static readonly IntPtr NativeMethodInfoPtr_SubscribeToOnRemoveListing_Public_Void_Action_0;

		// Token: 0x04008AF9 RID: 35577
		private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeFromOnRemoveListing_Public_Void_Action_0;

		// Token: 0x04008AFA RID: 35578
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D8A RID: 3466
		[ObfuscatedName("ScheduleOne.UI.Shop.Cart+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC49 RID: 64585 RVA: 0x003C2D8C File Offset: 0x003C0F8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Cart>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr);
				Cart.__c__DisplayClass32_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr, "listing");
				Cart.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr, 100689612);
				Cart.__c__DisplayClass32_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr, 100689613);
			}

			// Token: 0x0600FC4A RID: 64586 RVA: 0x003C2DF4 File Offset: 0x003C0FF4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cart.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC4B RID: 64587 RVA: 0x003C2E30 File Offset: 0x003C1030
			[CallerCount(0)]
			public unsafe bool _GetEntry_b__0(CartEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cart.__c__DisplayClass32_0.NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC4C RID: 64588 RVA: 0x000776FC File Offset: 0x000758FC
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CA8 RID: 19624
			// (get) Token: 0x0600FC4D RID: 64589 RVA: 0x003C2E80 File Offset: 0x003C1080
			// (set) Token: 0x0600FC4E RID: 64590 RVA: 0x00077705 File Offset: 0x00075905
			public unsafe ShopListing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass32_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cart.__c__DisplayClass32_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA1E RID: 43550
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x0400AA1F RID: 43551
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA20 RID: 43552
			private static readonly IntPtr NativeMethodInfoPtr__GetEntry_b__0_Internal_Boolean_CartEntry_0;
		}
	}
}
