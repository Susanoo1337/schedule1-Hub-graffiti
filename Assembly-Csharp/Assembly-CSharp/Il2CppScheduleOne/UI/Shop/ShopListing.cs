using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Variables;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x0200083F RID: 2111
	[Serializable]
	public class ShopListing : Il2CppSystem.Object
	{
		// Token: 0x0600CDAD RID: 52653 RVA: 0x0033B308 File Offset: 0x00339508
		// Note: this type is marked as 'beforefieldinit'.
		static ShopListing()
		{
			Il2CppClassPointerStore<ShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing>.NativeClassPtr);
			ShopListing.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "name");
			ShopListing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "Item");
			ShopListing.NativeFieldInfoPtr_OverridePrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverridePrice");
			ShopListing.NativeFieldInfoPtr_OverriddenPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "OverriddenPrice");
			ShopListing.NativeFieldInfoPtr_LimitedStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "LimitedStock");
			ShopListing.NativeFieldInfoPtr_DefaultStock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "DefaultStock");
			ShopListing.NativeFieldInfoPtr_RestockRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "RestockRate");
			ShopListing.NativeFieldInfoPtr_TieStockToNumberVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "TieStockToNumberVariable");
			ShopListing.NativeFieldInfoPtr_StockVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "StockVariableName");
			ShopListing.NativeFieldInfoPtr_TrackPurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "TrackPurchases");
			ShopListing.NativeFieldInfoPtr_PurchasedQuantityVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "PurchasedQuantityVariableName");
			ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "EnforceMinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "MinimumGameCreationVersion");
			ShopListing.NativeFieldInfoPtr_CanBeDelivered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CanBeDelivered");
			ShopListing.NativeFieldInfoPtr_UseIconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "UseIconTint");
			ShopListing.NativeFieldInfoPtr_IconTint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "IconTint");
			ShopListing.NativeFieldInfoPtr_ConditionalVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "ConditionalVisibility");
			ShopListing.NativeFieldInfoPtr_ConditionalVisibilityVariableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "ConditionalVisibilityVariableName");
			ShopListing.NativeFieldInfoPtr__Shop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<Shop>k__BackingField");
			ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<CurrentStock>k__BackingField");
			ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<QuantityInCart>k__BackingField");
			ShopListing.NativeFieldInfoPtr_onStockChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "onStockChanged");
			ShopListing.NativeFieldInfoPtr_stockVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "stockVariable");
			ShopListing.NativeFieldInfoPtr_purchasedQuantityVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "purchasedQuantityVariable");
			ShopListing.NativeFieldInfoPtr_conditionalVisibilityVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "conditionalVisibilityVariable");
			ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689799);
			ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689800);
			ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689801);
			ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689802);
			ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689803);
			ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689804);
			ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689805);
			ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689806);
			ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689807);
			ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689808);
			ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689809);
			ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689810);
			ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689811);
			ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689812);
			ShopListing.NativeMethodInfoPtr_PullStockFromVariable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689813);
			ShopListing.NativeMethodInfoPtr_StockVariableChanged_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689814);
			ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689815);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689816);
			ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689817);
			ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689818);
			ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, 100689819);
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0600CDAE RID: 52654 RVA: 0x0033B6D0 File Offset: 0x003398D0
		public unsafe bool IsInStock
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0600CDAF RID: 52655 RVA: 0x0033B70C File Offset: 0x0033990C
		public unsafe float Price
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 336982, RefRangeEnd = 336987, XrefRangeStart = 336982, XrefRangeEnd = 336982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0600CDB0 RID: 52656 RVA: 0x0033B748 File Offset: 0x00339948
		public unsafe bool IsUnlimitedStock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x0600CDB1 RID: 52657 RVA: 0x0033B784 File Offset: 0x00339984
		// (set) Token: 0x0600CDB2 RID: 52658 RVA: 0x0033B7C4 File Offset: 0x003399C4
		public unsafe ShopInterface Shop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 41608, RefRangeEnd = 41609, XrefRangeStart = 41608, XrefRangeEnd = 41609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x0600CDB3 RID: 52659 RVA: 0x0033B808 File Offset: 0x00339A08
		// (set) Token: 0x0600CDB4 RID: 52660 RVA: 0x0033B844 File Offset: 0x00339A44
		public unsafe int CurrentStock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x0600CDB5 RID: 52661 RVA: 0x0033B884 File Offset: 0x00339A84
		// (set) Token: 0x0600CDB6 RID: 52662 RVA: 0x0033B8C0 File Offset: 0x00339AC0
		public unsafe int QuantityInCart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x0600CDB7 RID: 52663 RVA: 0x0033B900 File Offset: 0x00339B00
		public unsafe int CurrentStockMinusCart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600CDB8 RID: 52664 RVA: 0x0033B93C File Offset: 0x00339B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337048, RefRangeEnd = 337049, XrefRangeStart = 336987, XrefRangeEnd = 337048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ShopInterface shop)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(shop);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDB9 RID: 52665 RVA: 0x0033B980 File Offset: 0x00339B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337049, XrefRangeEnd = 337050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Restock(bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_Restock_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDBA RID: 52666 RVA: 0x0033B9C0 File Offset: 0x00339BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337055, RefRangeEnd = 337056, XrefRangeStart = 337050, XrefRangeEnd = 337055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveStock(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x0033BA00 File Offset: 0x00339C00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 337091, RefRangeEnd = 337097, XrefRangeStart = 337056, XrefRangeEnd = 337091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStock(int quantity, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x0033BA4C File Offset: 0x00339C4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337104, RefRangeEnd = 337105, XrefRangeStart = 337097, XrefRangeEnd = 337104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PullStockFromVariable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_PullStockFromVariable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDBD RID: 52669 RVA: 0x0033BA80 File Offset: 0x00339C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337105, XrefRangeEnd = 337110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StockVariableChanged(float newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_StockVariableChanged_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDBE RID: 52670 RVA: 0x0033BAC0 File Offset: 0x00339CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337110, XrefRangeEnd = 337115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldShow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CDBF RID: 52671 RVA: 0x0033BB08 File Offset: 0x00339D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337115, XrefRangeEnd = 337122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchCategoryFilter(EShopCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x0033BB5C File Offset: 0x00339D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337122, XrefRangeEnd = 337126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesListingMatchSearchTerm(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopListing.NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x0033BBB4 File Offset: 0x00339DB4
		[CallerCount(0)]
		public unsafe void SetQuantityInCart(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x0033BBF4 File Offset: 0x00339DF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335382, RefRangeEnd = 335383, XrefRangeStart = 335382, XrefRangeEnd = 335383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x00061AED File Offset: 0x0005FCED
		public ShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E80 RID: 16000
		// (get) Token: 0x0600CDC4 RID: 52676 RVA: 0x0033BC30 File Offset: 0x00339E30
		// (set) Token: 0x0600CDC5 RID: 52677 RVA: 0x00061AF6 File Offset: 0x0005FCF6
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0600CDC6 RID: 52678 RVA: 0x0033BC58 File Offset: 0x00339E58
		// (set) Token: 0x0600CDC7 RID: 52679 RVA: 0x00061B15 File Offset: 0x0005FD15
		public unsafe StorableItemDefinition Item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E82 RID: 16002
		// (get) Token: 0x0600CDC8 RID: 52680 RVA: 0x0033BC88 File Offset: 0x00339E88
		// (set) Token: 0x0600CDC9 RID: 52681 RVA: 0x00061B34 File Offset: 0x0005FD34
		public unsafe bool OverridePrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverridePrice)) = value;
			}
		}

		// Token: 0x17003E83 RID: 16003
		// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x0033BCB0 File Offset: 0x00339EB0
		// (set) Token: 0x0600CDCB RID: 52683 RVA: 0x00061B4F File Offset: 0x0005FD4F
		public unsafe float OverriddenPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_OverriddenPrice)) = value;
			}
		}

		// Token: 0x17003E84 RID: 16004
		// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x0033BCD8 File Offset: 0x00339ED8
		// (set) Token: 0x0600CDCD RID: 52685 RVA: 0x00061B6A File Offset: 0x0005FD6A
		public unsafe bool LimitedStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_LimitedStock)) = value;
			}
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x0033BD00 File Offset: 0x00339F00
		// (set) Token: 0x0600CDCF RID: 52687 RVA: 0x00061B85 File Offset: 0x0005FD85
		public unsafe int DefaultStock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_DefaultStock)) = value;
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x0033BD28 File Offset: 0x00339F28
		// (set) Token: 0x0600CDD1 RID: 52689 RVA: 0x00061BA0 File Offset: 0x0005FDA0
		public unsafe ShopListing.ERestockRate RestockRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_RestockRate)) = value;
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x0600CDD2 RID: 52690 RVA: 0x0033BD50 File Offset: 0x00339F50
		// (set) Token: 0x0600CDD3 RID: 52691 RVA: 0x00061BBB File Offset: 0x0005FDBB
		public unsafe bool TieStockToNumberVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_TieStockToNumberVariable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_TieStockToNumberVariable)) = value;
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x0033BD78 File Offset: 0x00339F78
		// (set) Token: 0x0600CDD5 RID: 52693 RVA: 0x00061BD6 File Offset: 0x0005FDD6
		public unsafe string StockVariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_StockVariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_StockVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x0033BDA0 File Offset: 0x00339FA0
		// (set) Token: 0x0600CDD7 RID: 52695 RVA: 0x00061BF5 File Offset: 0x0005FDF5
		public unsafe bool TrackPurchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_TrackPurchases);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_TrackPurchases)) = value;
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x0033BDC8 File Offset: 0x00339FC8
		// (set) Token: 0x0600CDD9 RID: 52697 RVA: 0x00061C10 File Offset: 0x0005FE10
		public unsafe string PurchasedQuantityVariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_PurchasedQuantityVariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_PurchasedQuantityVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x0033BDF0 File Offset: 0x00339FF0
		// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x00061C2F File Offset: 0x0005FE2F
		public unsafe bool EnforceMinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_EnforceMinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x0600CDDC RID: 52700 RVA: 0x0033BE18 File Offset: 0x0033A018
		// (set) Token: 0x0600CDDD RID: 52701 RVA: 0x00061C4A File Offset: 0x0005FE4A
		public unsafe float MinimumGameCreationVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_MinimumGameCreationVersion)) = value;
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x0600CDDE RID: 52702 RVA: 0x0033BE40 File Offset: 0x0033A040
		// (set) Token: 0x0600CDDF RID: 52703 RVA: 0x00061C65 File Offset: 0x0005FE65
		public unsafe bool CanBeDelivered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_CanBeDelivered)) = value;
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x0600CDE0 RID: 52704 RVA: 0x0033BE68 File Offset: 0x0033A068
		// (set) Token: 0x0600CDE1 RID: 52705 RVA: 0x00061C80 File Offset: 0x0005FE80
		public unsafe bool UseIconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_UseIconTint)) = value;
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x0600CDE2 RID: 52706 RVA: 0x0033BE90 File Offset: 0x0033A090
		// (set) Token: 0x0600CDE3 RID: 52707 RVA: 0x00061C9B File Offset: 0x0005FE9B
		public unsafe Color IconTint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_IconTint)) = value;
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x0600CDE4 RID: 52708 RVA: 0x0033BEB8 File Offset: 0x0033A0B8
		// (set) Token: 0x0600CDE5 RID: 52709 RVA: 0x00061CB6 File Offset: 0x0005FEB6
		public unsafe bool ConditionalVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_ConditionalVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_ConditionalVisibility)) = value;
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0600CDE6 RID: 52710 RVA: 0x0033BEE0 File Offset: 0x0033A0E0
		// (set) Token: 0x0600CDE7 RID: 52711 RVA: 0x00061CD1 File Offset: 0x0005FED1
		public unsafe string ConditionalVisibilityVariableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_ConditionalVisibilityVariableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_ConditionalVisibilityVariableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0600CDE8 RID: 52712 RVA: 0x0033BF08 File Offset: 0x0033A108
		// (set) Token: 0x0600CDE9 RID: 52713 RVA: 0x00061CF0 File Offset: 0x0005FEF0
		public unsafe ShopInterface _Shop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__Shop_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0600CDEA RID: 52714 RVA: 0x0033BF38 File Offset: 0x0033A138
		// (set) Token: 0x0600CDEB RID: 52715 RVA: 0x00061D0F File Offset: 0x0005FF0F
		public unsafe int _CurrentStock_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__CurrentStock_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x0600CDEC RID: 52716 RVA: 0x0033BF60 File Offset: 0x0033A160
		// (set) Token: 0x0600CDED RID: 52717 RVA: 0x00061D2A File Offset: 0x0005FF2A
		public unsafe int _QuantityInCart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr__QuantityInCart_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x0033BF88 File Offset: 0x0033A188
		// (set) Token: 0x0600CDEF RID: 52719 RVA: 0x00061D45 File Offset: 0x0005FF45
		public unsafe Action onStockChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_onStockChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x0600CDF0 RID: 52720 RVA: 0x0033BFB8 File Offset: 0x0033A1B8
		// (set) Token: 0x0600CDF1 RID: 52721 RVA: 0x00061D64 File Offset: 0x0005FF64
		public unsafe NumberVariable stockVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_stockVariable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberVariable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_stockVariable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x0033BFE8 File Offset: 0x0033A1E8
		// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x00061D83 File Offset: 0x0005FF83
		public unsafe NumberVariable purchasedQuantityVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_purchasedQuantityVariable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberVariable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_purchasedQuantityVariable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x0033C018 File Offset: 0x0033A218
		// (set) Token: 0x0600CDF5 RID: 52725 RVA: 0x00061DA2 File Offset: 0x0005FFA2
		public unsafe BoolVariable conditionalVisibilityVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_conditionalVisibilityVariable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolVariable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.NativeFieldInfoPtr_conditionalVisibilityVariable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008C12 RID: 35858
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04008C13 RID: 35859
		private static readonly IntPtr NativeFieldInfoPtr_Item;

		// Token: 0x04008C14 RID: 35860
		private static readonly IntPtr NativeFieldInfoPtr_OverridePrice;

		// Token: 0x04008C15 RID: 35861
		private static readonly IntPtr NativeFieldInfoPtr_OverriddenPrice;

		// Token: 0x04008C16 RID: 35862
		private static readonly IntPtr NativeFieldInfoPtr_LimitedStock;

		// Token: 0x04008C17 RID: 35863
		private static readonly IntPtr NativeFieldInfoPtr_DefaultStock;

		// Token: 0x04008C18 RID: 35864
		private static readonly IntPtr NativeFieldInfoPtr_RestockRate;

		// Token: 0x04008C19 RID: 35865
		private static readonly IntPtr NativeFieldInfoPtr_TieStockToNumberVariable;

		// Token: 0x04008C1A RID: 35866
		private static readonly IntPtr NativeFieldInfoPtr_StockVariableName;

		// Token: 0x04008C1B RID: 35867
		private static readonly IntPtr NativeFieldInfoPtr_TrackPurchases;

		// Token: 0x04008C1C RID: 35868
		private static readonly IntPtr NativeFieldInfoPtr_PurchasedQuantityVariableName;

		// Token: 0x04008C1D RID: 35869
		private static readonly IntPtr NativeFieldInfoPtr_EnforceMinimumGameCreationVersion;

		// Token: 0x04008C1E RID: 35870
		private static readonly IntPtr NativeFieldInfoPtr_MinimumGameCreationVersion;

		// Token: 0x04008C1F RID: 35871
		private static readonly IntPtr NativeFieldInfoPtr_CanBeDelivered;

		// Token: 0x04008C20 RID: 35872
		private static readonly IntPtr NativeFieldInfoPtr_UseIconTint;

		// Token: 0x04008C21 RID: 35873
		private static readonly IntPtr NativeFieldInfoPtr_IconTint;

		// Token: 0x04008C22 RID: 35874
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalVisibility;

		// Token: 0x04008C23 RID: 35875
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalVisibilityVariableName;

		// Token: 0x04008C24 RID: 35876
		private static readonly IntPtr NativeFieldInfoPtr__Shop_k__BackingField;

		// Token: 0x04008C25 RID: 35877
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStock_k__BackingField;

		// Token: 0x04008C26 RID: 35878
		private static readonly IntPtr NativeFieldInfoPtr__QuantityInCart_k__BackingField;

		// Token: 0x04008C27 RID: 35879
		private static readonly IntPtr NativeFieldInfoPtr_onStockChanged;

		// Token: 0x04008C28 RID: 35880
		private static readonly IntPtr NativeFieldInfoPtr_stockVariable;

		// Token: 0x04008C29 RID: 35881
		private static readonly IntPtr NativeFieldInfoPtr_purchasedQuantityVariable;

		// Token: 0x04008C2A RID: 35882
		private static readonly IntPtr NativeFieldInfoPtr_conditionalVisibilityVariable;

		// Token: 0x04008C2B RID: 35883
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInStock_Public_get_Boolean_0;

		// Token: 0x04008C2C RID: 35884
		private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

		// Token: 0x04008C2D RID: 35885
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnlimitedStock_Public_get_Boolean_0;

		// Token: 0x04008C2E RID: 35886
		private static readonly IntPtr NativeMethodInfoPtr_get_Shop_Public_get_ShopInterface_0;

		// Token: 0x04008C2F RID: 35887
		private static readonly IntPtr NativeMethodInfoPtr_set_Shop_Private_set_Void_ShopInterface_0;

		// Token: 0x04008C30 RID: 35888
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStock_Public_get_Int32_0;

		// Token: 0x04008C31 RID: 35889
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStock_Protected_set_Void_Int32_0;

		// Token: 0x04008C32 RID: 35890
		private static readonly IntPtr NativeMethodInfoPtr_get_QuantityInCart_Public_get_Int32_0;

		// Token: 0x04008C33 RID: 35891
		private static readonly IntPtr NativeMethodInfoPtr_set_QuantityInCart_Private_set_Void_Int32_0;

		// Token: 0x04008C34 RID: 35892
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStockMinusCart_Public_get_Int32_0;

		// Token: 0x04008C35 RID: 35893
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ShopInterface_0;

		// Token: 0x04008C36 RID: 35894
		private static readonly IntPtr NativeMethodInfoPtr_Restock_Public_Void_Boolean_0;

		// Token: 0x04008C37 RID: 35895
		private static readonly IntPtr NativeMethodInfoPtr_RemoveStock_Public_Void_Int32_0;

		// Token: 0x04008C38 RID: 35896
		private static readonly IntPtr NativeMethodInfoPtr_SetStock_Public_Void_Int32_Boolean_0;

		// Token: 0x04008C39 RID: 35897
		private static readonly IntPtr NativeMethodInfoPtr_PullStockFromVariable_Public_Void_0;

		// Token: 0x04008C3A RID: 35898
		private static readonly IntPtr NativeMethodInfoPtr_StockVariableChanged_Private_Void_Single_0;

		// Token: 0x04008C3B RID: 35899
		private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Virtual_New_Boolean_0;

		// Token: 0x04008C3C RID: 35900
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchCategoryFilter_Public_Virtual_New_Boolean_EShopCategory_0;

		// Token: 0x04008C3D RID: 35901
		private static readonly IntPtr NativeMethodInfoPtr_DoesListingMatchSearchTerm_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04008C3E RID: 35902
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantityInCart_Public_Void_Int32_0;

		// Token: 0x04008C3F RID: 35903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D94 RID: 3476
		[Serializable]
		public class CategoryInstance : Il2CppSystem.Object
		{
			// Token: 0x0600FCA7 RID: 64679 RVA: 0x003C3FFC File Offset: 0x003C21FC
			// Note: this type is marked as 'beforefieldinit'.
			static CategoryInstance()
			{
				Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "CategoryInstance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr);
				ShopListing.CategoryInstance.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, "Category");
				ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr, 100689820);
			}

			// Token: 0x0600FCA8 RID: 64680 RVA: 0x003C4050 File Offset: 0x003C2250
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CategoryInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.CategoryInstance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.CategoryInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FCA9 RID: 64681 RVA: 0x0007795B File Offset: 0x00075B5B
			public CategoryInstance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CC0 RID: 19648
			// (get) Token: 0x0600FCAA RID: 64682 RVA: 0x003C408C File Offset: 0x003C228C
			// (set) Token: 0x0600FCAB RID: 64683 RVA: 0x00077964 File Offset: 0x00075B64
			public unsafe EShopCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.CategoryInstance.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x0400AA5B RID: 43611
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x0400AA5C RID: 43612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D95 RID: 3477
		[OriginalName("Assembly-CSharp.dll", "", "ERestockRate")]
		public enum ERestockRate
		{
			// Token: 0x0400AA5E RID: 43614
			Daily,
			// Token: 0x0400AA5F RID: 43615
			Weekly,
			// Token: 0x0400AA60 RID: 43616
			Never
		}

		// Token: 0x02000D96 RID: 3478
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopListing+<>c__DisplayClass51_0")]
		public sealed class __c__DisplayClass51_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FCAC RID: 64684 RVA: 0x003C40B4 File Offset: 0x003C22B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass51_0()
			{
				Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopListing>.NativeClassPtr, "<>c__DisplayClass51_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr);
				ShopListing.__c__DisplayClass51_0.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr, "category");
				ShopListing.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr, 100689821);
				ShopListing.__c__DisplayClass51_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr, 100689822);
			}

			// Token: 0x0600FCAD RID: 64685 RVA: 0x003C411C File Offset: 0x003C231C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass51_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopListing.__c__DisplayClass51_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FCAE RID: 64686 RVA: 0x003C4158 File Offset: 0x003C2358
			[CallerCount(0)]
			public unsafe bool _DoesListingMatchCategoryFilter_b__0(ShopListing.CategoryInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopListing.__c__DisplayClass51_0.NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FCAF RID: 64687 RVA: 0x0007797F File Offset: 0x00075B7F
			public __c__DisplayClass51_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CC1 RID: 19649
			// (get) Token: 0x0600FCB0 RID: 64688 RVA: 0x003C41A8 File Offset: 0x003C23A8
			// (set) Token: 0x0600FCB1 RID: 64689 RVA: 0x00077988 File Offset: 0x00075B88
			public unsafe EShopCategory category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass51_0.NativeFieldInfoPtr_category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopListing.__c__DisplayClass51_0.NativeFieldInfoPtr_category)) = value;
				}
			}

			// Token: 0x0400AA61 RID: 43617
			private static readonly IntPtr NativeFieldInfoPtr_category;

			// Token: 0x0400AA62 RID: 43618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA63 RID: 43619
			private static readonly IntPtr NativeMethodInfoPtr__DoesListingMatchCategoryFilter_b__0_Internal_Boolean_CategoryInstance_0;
		}
	}
}
