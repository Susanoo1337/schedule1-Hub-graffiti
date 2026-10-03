using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A7 RID: 1959
	public class PhoneShopInterface : MonoBehaviour
	{
		// Token: 0x0600BDD5 RID: 48597 RVA: 0x0030A3E8 File Offset: 0x003085E8
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneShopInterface()
		{
			Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "PhoneShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr);
			PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryPrefab");
			PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ValidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "InvalidAmountColor");
			PhoneShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Container");
			PhoneShopInterface.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "TitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "SubtitleLabel");
			PhoneShopInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "EntryContainer");
			PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderTotalLabel");
			PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "OrderLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr_DebtLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "DebtLabel");
			PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ConfirmButton");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitContainer");
			PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "ItemLimitLabel");
			PhoneShopInterface.NativeFieldInfoPtr_uiScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "uiScreen");
			PhoneShopInterface.NativeFieldInfoPtr_uiPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "uiPanel");
			PhoneShopInterface.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_entries");
			PhoneShopInterface.NativeFieldInfoPtr__items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_items");
			PhoneShopInterface.NativeFieldInfoPtr__cart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "_cart");
			PhoneShopInterface.NativeFieldInfoPtr_orderLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderLimit");
			PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "orderConfirmedCallback");
			PhoneShopInterface.NativeFieldInfoPtr_conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "conversation");
			PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688048);
			PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688049);
			PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688050);
			PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688051);
			PhoneShopInterface.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688052);
			PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688053);
			PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688054);
			PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688055);
			PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688056);
			PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688057);
			PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688058);
			PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688059);
			PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688060);
			PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, 100688061);
		}

		// Token: 0x17003965 RID: 14693
		// (get) Token: 0x0600BDD6 RID: 48598 RVA: 0x0030A6E8 File Offset: 0x003088E8
		// (set) Token: 0x0600BDD7 RID: 48599 RVA: 0x0030A724 File Offset: 0x00308924
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BDD8 RID: 48600 RVA: 0x0030A764 File Offset: 0x00308964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316174, XrefRangeEnd = 316195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDD9 RID: 48601 RVA: 0x0030A798 File Offset: 0x00308998
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316352, RefRangeEnd = 316353, XrefRangeStart = 316195, XrefRangeEnd = 316352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string subtitle, MSGConversation _conversation, List<PhoneShopInterface.Listing> listings, float _orderLimit, float debt, Action<List<PhoneShopInterface.CartEntry>, float> _orderConfirmedCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subtitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_conversation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _orderLimit;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref debt;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_orderConfirmedCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x0030A840 File Offset: 0x00308A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316353, XrefRangeEnd = 316358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x0030A880 File Offset: 0x00308A80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 316401, RefRangeEnd = 316404, XrefRangeStart = 316358, XrefRangeEnd = 316401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x0030A8B4 File Offset: 0x00308AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316404, XrefRangeEnd = 316409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x0030A8F8 File Offset: 0x00308AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316450, RefRangeEnd = 316452, XrefRangeStart = 316409, XrefRangeEnd = 316450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeListingQuantity(PhoneShopInterface.Listing listing, int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x0030A948 File Offset: 0x00308B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316469, RefRangeEnd = 316471, XrefRangeStart = 316452, XrefRangeEnd = 316469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CartChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x0030A97C File Offset: 0x00308B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316471, XrefRangeEnd = 316474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfirmOrderPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x0030A9B0 File Offset: 0x00308BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316474, XrefRangeEnd = 316475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConfirmOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x0030A9EC File Offset: 0x00308BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316475, XrefRangeEnd = 316487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOrderTotal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x0030AA20 File Offset: 0x00308C20
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 316501, RefRangeEnd = 316506, XrefRangeStart = 316487, XrefRangeEnd = 316501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetOrderTotal(out int itemCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &itemCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BDE3 RID: 48611 RVA: 0x0030AA6C File Offset: 0x00308C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316506, XrefRangeEnd = 316528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x00058968 File Offset: 0x00056B68
		public PhoneShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x0600BDE5 RID: 48613 RVA: 0x0030AAA8 File Offset: 0x00308CA8
		// (set) Token: 0x0600BDE6 RID: 48614 RVA: 0x00058971 File Offset: 0x00056B71
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x0600BDE7 RID: 48615 RVA: 0x0030AAD0 File Offset: 0x00308CD0
		// (set) Token: 0x0600BDE8 RID: 48616 RVA: 0x0005898C File Offset: 0x00056B8C
		public unsafe RectTransform EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x0600BDE9 RID: 48617 RVA: 0x0030AB00 File Offset: 0x00308D00
		// (set) Token: 0x0600BDEA RID: 48618 RVA: 0x000589AB File Offset: 0x00056BAB
		public unsafe Color ValidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ValidAmountColor)) = value;
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x0600BDEB RID: 48619 RVA: 0x0030AB28 File Offset: 0x00308D28
		// (set) Token: 0x0600BDEC RID: 48620 RVA: 0x000589C6 File Offset: 0x00056BC6
		public unsafe Color InvalidAmountColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_InvalidAmountColor)) = value;
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x0600BDED RID: 48621 RVA: 0x0030AB50 File Offset: 0x00308D50
		// (set) Token: 0x0600BDEE RID: 48622 RVA: 0x000589E1 File Offset: 0x00056BE1
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x0600BDEF RID: 48623 RVA: 0x0030AB80 File Offset: 0x00308D80
		// (set) Token: 0x0600BDF0 RID: 48624 RVA: 0x00058A00 File Offset: 0x00056C00
		public unsafe Text TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003955 RID: 14677
		// (get) Token: 0x0600BDF1 RID: 48625 RVA: 0x0030ABB0 File Offset: 0x00308DB0
		// (set) Token: 0x0600BDF2 RID: 48626 RVA: 0x00058A1F File Offset: 0x00056C1F
		public unsafe Text SubtitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_SubtitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003956 RID: 14678
		// (get) Token: 0x0600BDF3 RID: 48627 RVA: 0x0030ABE0 File Offset: 0x00308DE0
		// (set) Token: 0x0600BDF4 RID: 48628 RVA: 0x00058A3E File Offset: 0x00056C3E
		public unsafe RectTransform EntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003957 RID: 14679
		// (get) Token: 0x0600BDF5 RID: 48629 RVA: 0x0030AC10 File Offset: 0x00308E10
		// (set) Token: 0x0600BDF6 RID: 48630 RVA: 0x00058A5D File Offset: 0x00056C5D
		public unsafe Text OrderTotalLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderTotalLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003958 RID: 14680
		// (get) Token: 0x0600BDF7 RID: 48631 RVA: 0x0030AC40 File Offset: 0x00308E40
		// (set) Token: 0x0600BDF8 RID: 48632 RVA: 0x00058A7C File Offset: 0x00056C7C
		public unsafe Text OrderLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_OrderLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003959 RID: 14681
		// (get) Token: 0x0600BDF9 RID: 48633 RVA: 0x0030AC70 File Offset: 0x00308E70
		// (set) Token: 0x0600BDFA RID: 48634 RVA: 0x00058A9B File Offset: 0x00056C9B
		public unsafe Text DebtLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_DebtLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395A RID: 14682
		// (get) Token: 0x0600BDFB RID: 48635 RVA: 0x0030ACA0 File Offset: 0x00308EA0
		// (set) Token: 0x0600BDFC RID: 48636 RVA: 0x00058ABA File Offset: 0x00056CBA
		public unsafe Button ConfirmButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ConfirmButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x0600BDFD RID: 48637 RVA: 0x0030ACD0 File Offset: 0x00308ED0
		// (set) Token: 0x0600BDFE RID: 48638 RVA: 0x00058AD9 File Offset: 0x00056CD9
		public unsafe GameObject ItemLimitContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x0600BDFF RID: 48639 RVA: 0x0030AD00 File Offset: 0x00308F00
		// (set) Token: 0x0600BE00 RID: 48640 RVA: 0x00058AF8 File Offset: 0x00056CF8
		public unsafe Text ItemLimitLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_ItemLimitLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x0030AD30 File Offset: 0x00308F30
		// (set) Token: 0x0600BE02 RID: 48642 RVA: 0x00058B17 File Offset: 0x00056D17
		public unsafe UIScreen uiScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_uiScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_uiScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0600BE03 RID: 48643 RVA: 0x0030AD60 File Offset: 0x00308F60
		// (set) Token: 0x0600BE04 RID: 48644 RVA: 0x00058B36 File Offset: 0x00056D36
		public unsafe UIPanel uiPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_uiPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_uiPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700395F RID: 14687
		// (get) Token: 0x0600BE05 RID: 48645 RVA: 0x0030AD90 File Offset: 0x00308F90
		// (set) Token: 0x0600BE06 RID: 48646 RVA: 0x00058B55 File Offset: 0x00056D55
		public unsafe List<RectTransform> _entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003960 RID: 14688
		// (get) Token: 0x0600BE07 RID: 48647 RVA: 0x0030ADC0 File Offset: 0x00308FC0
		// (set) Token: 0x0600BE08 RID: 48648 RVA: 0x00058B74 File Offset: 0x00056D74
		public unsafe List<PhoneShopInterface.Listing> _items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.Listing>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003961 RID: 14689
		// (get) Token: 0x0600BE09 RID: 48649 RVA: 0x0030ADF0 File Offset: 0x00308FF0
		// (set) Token: 0x0600BE0A RID: 48650 RVA: 0x00058B93 File Offset: 0x00056D93
		public unsafe List<PhoneShopInterface.CartEntry> _cart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PhoneShopInterface.CartEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr__cart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003962 RID: 14690
		// (get) Token: 0x0600BE0B RID: 48651 RVA: 0x0030AE20 File Offset: 0x00309020
		// (set) Token: 0x0600BE0C RID: 48652 RVA: 0x00058BB2 File Offset: 0x00056DB2
		public unsafe float orderLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderLimit)) = value;
			}
		}

		// Token: 0x17003963 RID: 14691
		// (get) Token: 0x0600BE0D RID: 48653 RVA: 0x0030AE48 File Offset: 0x00309048
		// (set) Token: 0x0600BE0E RID: 48654 RVA: 0x00058BCD File Offset: 0x00056DCD
		public unsafe Action<List<PhoneShopInterface.CartEntry>, float> orderConfirmedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<List<PhoneShopInterface.CartEntry>, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_orderConfirmedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003964 RID: 14692
		// (get) Token: 0x0600BE0F RID: 48655 RVA: 0x0030AE78 File Offset: 0x00309078
		// (set) Token: 0x0600BE10 RID: 48656 RVA: 0x00058BEC File Offset: 0x00056DEC
		public unsafe MSGConversation conversation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.NativeFieldInfoPtr_conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008200 RID: 33280
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04008201 RID: 33281
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x04008202 RID: 33282
		private static readonly IntPtr NativeFieldInfoPtr_ValidAmountColor;

		// Token: 0x04008203 RID: 33283
		private static readonly IntPtr NativeFieldInfoPtr_InvalidAmountColor;

		// Token: 0x04008204 RID: 33284
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04008205 RID: 33285
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04008206 RID: 33286
		private static readonly IntPtr NativeFieldInfoPtr_SubtitleLabel;

		// Token: 0x04008207 RID: 33287
		private static readonly IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04008208 RID: 33288
		private static readonly IntPtr NativeFieldInfoPtr_OrderTotalLabel;

		// Token: 0x04008209 RID: 33289
		private static readonly IntPtr NativeFieldInfoPtr_OrderLimitLabel;

		// Token: 0x0400820A RID: 33290
		private static readonly IntPtr NativeFieldInfoPtr_DebtLabel;

		// Token: 0x0400820B RID: 33291
		private static readonly IntPtr NativeFieldInfoPtr_ConfirmButton;

		// Token: 0x0400820C RID: 33292
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitContainer;

		// Token: 0x0400820D RID: 33293
		private static readonly IntPtr NativeFieldInfoPtr_ItemLimitLabel;

		// Token: 0x0400820E RID: 33294
		private static readonly IntPtr NativeFieldInfoPtr_uiScreen;

		// Token: 0x0400820F RID: 33295
		private static readonly IntPtr NativeFieldInfoPtr_uiPanel;

		// Token: 0x04008210 RID: 33296
		private static readonly IntPtr NativeFieldInfoPtr__entries;

		// Token: 0x04008211 RID: 33297
		private static readonly IntPtr NativeFieldInfoPtr__items;

		// Token: 0x04008212 RID: 33298
		private static readonly IntPtr NativeFieldInfoPtr__cart;

		// Token: 0x04008213 RID: 33299
		private static readonly IntPtr NativeFieldInfoPtr_orderLimit;

		// Token: 0x04008214 RID: 33300
		private static readonly IntPtr NativeFieldInfoPtr_orderConfirmedCallback;

		// Token: 0x04008215 RID: 33301
		private static readonly IntPtr NativeFieldInfoPtr_conversation;

		// Token: 0x04008216 RID: 33302
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04008217 RID: 33303
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04008218 RID: 33304
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008219 RID: 33305
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_MSGConversation_List_1_Listing_Single_Single_Action_2_List_1_CartEntry_Single_0;

		// Token: 0x0400821A RID: 33306
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectPanel_Private_IEnumerator_0;

		// Token: 0x0400821B RID: 33307
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400821C RID: 33308
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x0400821D RID: 33309
		private static readonly IntPtr NativeMethodInfoPtr_ChangeListingQuantity_Private_Void_Listing_Int32_0;

		// Token: 0x0400821E RID: 33310
		private static readonly IntPtr NativeMethodInfoPtr_CartChanged_Private_Void_0;

		// Token: 0x0400821F RID: 33311
		private static readonly IntPtr NativeMethodInfoPtr_ConfirmOrderPressed_Private_Void_0;

		// Token: 0x04008220 RID: 33312
		private static readonly IntPtr NativeMethodInfoPtr_CanConfirmOrder_Private_Boolean_0;

		// Token: 0x04008221 RID: 33313
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOrderTotal_Private_Void_0;

		// Token: 0x04008222 RID: 33314
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderTotal_Private_Single_byref_Int32_0;

		// Token: 0x04008223 RID: 33315
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D1D RID: 3357
		[Serializable]
		public class Listing : Il2CppSystem.Object
		{
			// Token: 0x0600F84B RID: 63563 RVA: 0x003B7750 File Offset: 0x003B5950
			// Note: this type is marked as 'beforefieldinit'.
			static Listing()
			{
				Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "Listing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr);
				PhoneShopInterface.Listing.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, "Item");
				PhoneShopInterface.Listing.NativeMethodInfoPtr_get_Price_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, 100688062);
				PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr, 100688063);
			}

			// Token: 0x17004B7A RID: 19322
			// (get) Token: 0x0600F84C RID: 63564 RVA: 0x003B77B8 File Offset: 0x003B59B8
			public unsafe float Price
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.Listing.NativeMethodInfoPtr_get_Price_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600F84D RID: 63565 RVA: 0x003B77F4 File Offset: 0x003B59F4
			[CallerCount(203)]
			[CachedScanResults(RefRangeStart = 19776, RefRangeEnd = 19979, XrefRangeStart = 19776, XrefRangeEnd = 19979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Listing(StorableItemDefinition item) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.Listing>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.Listing.NativeMethodInfoPtr__ctor_Public_Void_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F84E RID: 63566 RVA: 0x0007564F File Offset: 0x0007384F
			public Listing(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B79 RID: 19321
			// (get) Token: 0x0600F84F RID: 63567 RVA: 0x003B7840 File Offset: 0x003B5A40
			// (set) Token: 0x0600F850 RID: 63568 RVA: 0x00075658 File Offset: 0x00073858
			public unsafe StorableItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.Listing.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7D5 RID: 42965
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x0400A7D6 RID: 42966
			private static readonly IntPtr NativeMethodInfoPtr_get_Price_Public_get_Single_0;

			// Token: 0x0400A7D7 RID: 42967
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StorableItemDefinition_0;
		}

		// Token: 0x02000D1E RID: 3358
		[Serializable]
		public class CartEntry : Il2CppSystem.Object
		{
			// Token: 0x0600F851 RID: 63569 RVA: 0x003B7870 File Offset: 0x003B5A70
			// Note: this type is marked as 'beforefieldinit'.
			static CartEntry()
			{
				Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "CartEntry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr);
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Listing");
				PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, "Quantity");
				PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr, 100688064);
			}

			// Token: 0x0600F852 RID: 63570 RVA: 0x003B78D8 File Offset: 0x003B5AD8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123667, RefRangeEnd = 123677, XrefRangeStart = 123667, XrefRangeEnd = 123677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CartEntry(PhoneShopInterface.Listing listing, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.CartEntry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listing);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.CartEntry.NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F853 RID: 63571 RVA: 0x00075677 File Offset: 0x00073877
			public CartEntry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B7B RID: 19323
			// (get) Token: 0x0600F854 RID: 63572 RVA: 0x003B7934 File Offset: 0x003B5B34
			// (set) Token: 0x0600F855 RID: 63573 RVA: 0x00075680 File Offset: 0x00073880
			public unsafe PhoneShopInterface.Listing Listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B7C RID: 19324
			// (get) Token: 0x0600F856 RID: 63574 RVA: 0x003B7964 File Offset: 0x003B5B64
			// (set) Token: 0x0600F857 RID: 63575 RVA: 0x0007569F File Offset: 0x0007389F
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.CartEntry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x0400A7D8 RID: 42968
			private static readonly IntPtr NativeFieldInfoPtr_Listing;

			// Token: 0x0400A7D9 RID: 42969
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x0400A7DA RID: 42970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Listing_Int32_0;
		}

		// Token: 0x02000D1F RID: 3359
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass28_0")]
		public sealed class __c__DisplayClass28_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F858 RID: 63576 RVA: 0x003B798C File Offset: 0x003B5B8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass28_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass28_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr, "entry");
				PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr, "<>4__this");
				PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr, 100688065);
				PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr, 100688066);
				PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr, 100688067);
			}

			// Token: 0x0600F859 RID: 63577 RVA: 0x003B7A1C File Offset: 0x003B5C1C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass28_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass28_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F85A RID: 63578 RVA: 0x003B7A58 File Offset: 0x003B5C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316160, XrefRangeEnd = 316162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__Open_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F85B RID: 63579 RVA: 0x003B7A8C File Offset: 0x003B5C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316162, XrefRangeEnd = 316164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Open_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass28_0.NativeMethodInfoPtr__Open_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F85C RID: 63580 RVA: 0x000756BA File Offset: 0x000738BA
			public __c__DisplayClass28_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B7D RID: 19325
			// (get) Token: 0x0600F85D RID: 63581 RVA: 0x003B7AC0 File Offset: 0x003B5CC0
			// (set) Token: 0x0600F85E RID: 63582 RVA: 0x000756C3 File Offset: 0x000738C3
			public unsafe PhoneShopInterface.Listing entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B7E RID: 19326
			// (get) Token: 0x0600F85F RID: 63583 RVA: 0x003B7AF0 File Offset: 0x003B5CF0
			// (set) Token: 0x0600F860 RID: 63584 RVA: 0x000756E2 File Offset: 0x000738E2
			public unsafe PhoneShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass28_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7DB RID: 42971
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x0400A7DC RID: 42972
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7DD RID: 42973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7DE RID: 42974
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__0_Internal_Void_0;

			// Token: 0x0400A7DF RID: 42975
			private static readonly IntPtr NativeMethodInfoPtr__Open_b__1_Internal_Void_0;
		}

		// Token: 0x02000D20 RID: 3360
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F861 RID: 63585 RVA: 0x003B7B20 File Offset: 0x003B5D20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr);
				PhoneShopInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr, "listing");
				PhoneShopInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr, 100688068);
				PhoneShopInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr, 100688069);
			}

			// Token: 0x0600F862 RID: 63586 RVA: 0x003B7B88 File Offset: 0x003B5D88
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F863 RID: 63587 RVA: 0x003B7BC4 File Offset: 0x003B5DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316164, XrefRangeEnd = 316166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChangeListingQuantity_b__0(PhoneShopInterface.CartEntry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F864 RID: 63588 RVA: 0x00075701 File Offset: 0x00073901
			public __c__DisplayClass32_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B7F RID: 19327
			// (get) Token: 0x0600F865 RID: 63589 RVA: 0x003B7C14 File Offset: 0x003B5E14
			// (set) Token: 0x0600F866 RID: 63590 RVA: 0x0007570A File Offset: 0x0007390A
			public unsafe PhoneShopInterface.Listing listing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_listing);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface.Listing>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7E0 RID: 42976
			private static readonly IntPtr NativeFieldInfoPtr_listing;

			// Token: 0x0400A7E1 RID: 42977
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7E2 RID: 42978
			private static readonly IntPtr NativeMethodInfoPtr__ChangeListingQuantity_b__0_Internal_Boolean_CartEntry_0;
		}

		// Token: 0x02000D21 RID: 3361
		[ObfuscatedName("ScheduleOne.UI.Phone.PhoneShopInterface+<DelaySelectPanel>d__29")]
		public sealed class _DelaySelectPanel_d__29 : Il2CppSystem.Object
		{
			// Token: 0x0600F867 RID: 63591 RVA: 0x003B7C44 File Offset: 0x003B5E44
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectPanel_d__29()
			{
				Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneShopInterface>.NativeClassPtr, "<DelaySelectPanel>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, "<>1__state");
				PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, "<>2__current");
				PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, "<>4__this");
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688070);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688071);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688072);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688073);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688074);
				PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr, 100688075);
			}

			// Token: 0x0600F868 RID: 63592 RVA: 0x003B7D24 File Offset: 0x003B5F24
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectPanel_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneShopInterface._DelaySelectPanel_d__29>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F869 RID: 63593 RVA: 0x003B7D6C File Offset: 0x003B5F6C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F86A RID: 63594 RVA: 0x003B7DA0 File Offset: 0x003B5FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316166, XrefRangeEnd = 316169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B83 RID: 19331
			// (get) Token: 0x0600F86B RID: 63595 RVA: 0x003B7DDC File Offset: 0x003B5FDC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F86C RID: 63596 RVA: 0x003B7E1C File Offset: 0x003B601C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316169, XrefRangeEnd = 316174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B84 RID: 19332
			// (get) Token: 0x0600F86D RID: 63597 RVA: 0x003B7E50 File Offset: 0x003B6050
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneShopInterface._DelaySelectPanel_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F86E RID: 63598 RVA: 0x00075729 File Offset: 0x00073929
			public _DelaySelectPanel_d__29(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B80 RID: 19328
			// (get) Token: 0x0600F86F RID: 63599 RVA: 0x003B7E90 File Offset: 0x003B6090
			// (set) Token: 0x0600F870 RID: 63600 RVA: 0x00075732 File Offset: 0x00073932
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B81 RID: 19329
			// (get) Token: 0x0600F871 RID: 63601 RVA: 0x003B7EB8 File Offset: 0x003B60B8
			// (set) Token: 0x0600F872 RID: 63602 RVA: 0x0007574D File Offset: 0x0007394D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B82 RID: 19330
			// (get) Token: 0x0600F873 RID: 63603 RVA: 0x003B7EE8 File Offset: 0x003B60E8
			// (set) Token: 0x0600F874 RID: 63604 RVA: 0x0007576C File Offset: 0x0007396C
			public unsafe PhoneShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneShopInterface._DelaySelectPanel_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7E3 RID: 42979
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A7E4 RID: 42980
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A7E5 RID: 42981
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7E6 RID: 42982
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A7E7 RID: 42983
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7E8 RID: 42984
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A7E9 RID: 42985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A7EA RID: 42986
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7EB RID: 42987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
