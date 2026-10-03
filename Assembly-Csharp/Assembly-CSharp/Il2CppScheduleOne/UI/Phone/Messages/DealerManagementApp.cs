using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020007B6 RID: 1974
	public class DealerManagementApp : App<DealerManagementApp>
	{
		// Token: 0x0600C0BA RID: 49338 RVA: 0x0031344C File Offset: 0x0031164C
		// Note: this type is marked as 'beforefieldinit'.
		static DealerManagementApp()
		{
			Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "DealerManagementApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr);
			DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<SelectedDealer>k__BackingField");
			DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NoDealersLabel");
			DealerManagementApp.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "Content");
			DealerManagementApp.NativeFieldInfoPtr_CustomerSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerSelector");
			DealerManagementApp.NativeFieldInfoPtr_SelectorImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorImage");
			DealerManagementApp.NativeFieldInfoPtr_SelectorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "SelectorTitle");
			DealerManagementApp.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "BackButton");
			DealerManagementApp.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "NextButton");
			DealerManagementApp.NativeFieldInfoPtr__dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_dropdown");
			DealerManagementApp.NativeFieldInfoPtr__dropdownBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_dropdownBackground");
			DealerManagementApp.NativeFieldInfoPtr__dropdownCaptionImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_dropdownCaptionImage");
			DealerManagementApp.NativeFieldInfoPtr__dropDownCaptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_dropDownCaptionText");
			DealerManagementApp.NativeFieldInfoPtr_CashLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CashLabel");
			DealerManagementApp.NativeFieldInfoPtr_CutLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CutLabel");
			DealerManagementApp.NativeFieldInfoPtr_HomeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "HomeLabel");
			DealerManagementApp.NativeFieldInfoPtr__inventoryTextLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_inventoryTextLabel");
			DealerManagementApp.NativeFieldInfoPtr__inventoryEntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_inventoryEntryContainer");
			DealerManagementApp.NativeFieldInfoPtr_InventoryEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "InventoryEntries");
			DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerTitleLabel");
			DealerManagementApp.NativeFieldInfoPtr_CustomerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "CustomerEntries");
			DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "AssignCustomerButton");
			DealerManagementApp.NativeFieldInfoPtr__uiGeneralSpriteFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_uiGeneralSpriteFont");
			DealerManagementApp.NativeFieldInfoPtr__productColorFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_productColorFont");
			DealerManagementApp.NativeFieldInfoPtr_dealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "dealers");
			DealerManagementApp.NativeFieldInfoPtr__isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "_isOpen");
			DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688403);
			DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688404);
			DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688405);
			DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688406);
			DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688407);
			DealerManagementApp.NativeMethodInfoPtr_Refresh_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688408);
			DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688409);
			DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688410);
			DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688411);
			DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688412);
			DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688413);
			DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688414);
			DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688415);
			DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688416);
			DealerManagementApp.NativeMethodInfoPtr_RefreshDropdown_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688417);
			DealerManagementApp.NativeMethodInfoPtr_OnDropdownValueChanged_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688418);
			DealerManagementApp.NativeMethodInfoPtr_OnDropdownOpen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688419);
			DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, 100688420);
		}

		// Token: 0x17003A6D RID: 14957
		// (get) Token: 0x0600C0BB RID: 49339 RVA: 0x003137D8 File Offset: 0x003119D8
		// (set) Token: 0x0600C0BC RID: 49340 RVA: 0x00313818 File Offset: 0x00311A18
		public unsafe Dealer SelectedDealer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22015, RefRangeEnd = 22016, XrefRangeStart = 22015, XrefRangeEnd = 22016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x0031385C File Offset: 0x00311A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320055, XrefRangeEnd = 320146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x00313898 File Offset: 0x00311A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320146, XrefRangeEnd = 320159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x003138D4 File Offset: 0x00311AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320159, XrefRangeEnd = 320184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x00313910 File Offset: 0x00311B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320184, XrefRangeEnd = 320198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_Refresh_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x00313944 File Offset: 0x00311B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320198, XrefRangeEnd = 320217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealerManagementApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C2 RID: 49346 RVA: 0x00313990 File Offset: 0x00311B90
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 320517, RefRangeEnd = 320526, XrefRangeStart = 320217, XrefRangeEnd = 320517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C3 RID: 49347 RVA: 0x003139D4 File Offset: 0x00311BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320557, RefRangeEnd = 320558, XrefRangeStart = 320526, XrefRangeEnd = 320557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealer(Dealer dealer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dealer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x00313A18 File Offset: 0x00311C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320558, XrefRangeEnd = 320568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x00313A5C File Offset: 0x00311C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320568, XrefRangeEnd = 320572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C6 RID: 49350 RVA: 0x00313AA0 File Offset: 0x00311CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320572, XrefRangeEnd = 320579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_BackPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x00313AD4 File Offset: 0x00311CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320579, XrefRangeEnd = 320587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_NextPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C8 RID: 49352 RVA: 0x00313B08 File Offset: 0x00311D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320587, XrefRangeEnd = 320589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignCustomer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_AssignCustomer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x00313B3C File Offset: 0x00311D3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 320642, RefRangeEnd = 320644, XrefRangeStart = 320589, XrefRangeEnd = 320642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_RefreshDropdown_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0CA RID: 49354 RVA: 0x00313B70 File Offset: 0x00311D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320644, XrefRangeEnd = 320654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDropdownValueChanged(int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_OnDropdownValueChanged_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x00313BB0 File Offset: 0x00311DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320654, XrefRangeEnd = 320659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDropdownOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr_OnDropdownOpen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x00313BE4 File Offset: 0x00311DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320659, XrefRangeEnd = 320672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealerManagementApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600C0CD RID: 49357 RVA: 0x0005A4E1 File Offset: 0x000586E1
		public DealerManagementApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003A54 RID: 14932
		// (get) Token: 0x0600C0CE RID: 49358 RVA: 0x00313C20 File Offset: 0x00311E20
		// (set) Token: 0x0600C0CF RID: 49359 RVA: 0x0005A4EA File Offset: 0x000586EA
		public unsafe Dealer _SelectedDealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__SelectedDealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A55 RID: 14933
		// (get) Token: 0x0600C0D0 RID: 49360 RVA: 0x00313C50 File Offset: 0x00311E50
		// (set) Token: 0x0600C0D1 RID: 49361 RVA: 0x0005A509 File Offset: 0x00058709
		public unsafe Text NoDealersLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NoDealersLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A56 RID: 14934
		// (get) Token: 0x0600C0D2 RID: 49362 RVA: 0x00313C80 File Offset: 0x00311E80
		// (set) Token: 0x0600C0D3 RID: 49363 RVA: 0x0005A528 File Offset: 0x00058728
		public unsafe RectTransform Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A57 RID: 14935
		// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x00313CB0 File Offset: 0x00311EB0
		// (set) Token: 0x0600C0D5 RID: 49365 RVA: 0x0005A547 File Offset: 0x00058747
		public unsafe CustomerSelector CustomerSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A58 RID: 14936
		// (get) Token: 0x0600C0D6 RID: 49366 RVA: 0x00313CE0 File Offset: 0x00311EE0
		// (set) Token: 0x0600C0D7 RID: 49367 RVA: 0x0005A566 File Offset: 0x00058766
		public unsafe Image SelectorImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A59 RID: 14937
		// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x00313D10 File Offset: 0x00311F10
		// (set) Token: 0x0600C0D9 RID: 49369 RVA: 0x0005A585 File Offset: 0x00058785
		public unsafe Text SelectorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_SelectorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5A RID: 14938
		// (get) Token: 0x0600C0DA RID: 49370 RVA: 0x00313D40 File Offset: 0x00311F40
		// (set) Token: 0x0600C0DB RID: 49371 RVA: 0x0005A5A4 File Offset: 0x000587A4
		public unsafe Button BackButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5B RID: 14939
		// (get) Token: 0x0600C0DC RID: 49372 RVA: 0x00313D70 File Offset: 0x00311F70
		// (set) Token: 0x0600C0DD RID: 49373 RVA: 0x0005A5C3 File Offset: 0x000587C3
		public unsafe Button NextButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5C RID: 14940
		// (get) Token: 0x0600C0DE RID: 49374 RVA: 0x00313DA0 File Offset: 0x00311FA0
		// (set) Token: 0x0600C0DF RID: 49375 RVA: 0x0005A5E2 File Offset: 0x000587E2
		public unsafe DropdownUI _dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DropdownUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5D RID: 14941
		// (get) Token: 0x0600C0E0 RID: 49376 RVA: 0x00313DD0 File Offset: 0x00311FD0
		// (set) Token: 0x0600C0E1 RID: 49377 RVA: 0x0005A601 File Offset: 0x00058801
		public unsafe Image _dropdownBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdownBackground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdownBackground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600C0E2 RID: 49378 RVA: 0x00313E00 File Offset: 0x00312000
		// (set) Token: 0x0600C0E3 RID: 49379 RVA: 0x0005A620 File Offset: 0x00058820
		public unsafe Image _dropdownCaptionImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdownCaptionImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropdownCaptionImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600C0E4 RID: 49380 RVA: 0x00313E30 File Offset: 0x00312030
		// (set) Token: 0x0600C0E5 RID: 49381 RVA: 0x0005A63F File Offset: 0x0005883F
		public unsafe Text _dropDownCaptionText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropDownCaptionText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__dropDownCaptionText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600C0E6 RID: 49382 RVA: 0x00313E60 File Offset: 0x00312060
		// (set) Token: 0x0600C0E7 RID: 49383 RVA: 0x0005A65E File Offset: 0x0005885E
		public unsafe Text CashLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CashLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600C0E8 RID: 49384 RVA: 0x00313E90 File Offset: 0x00312090
		// (set) Token: 0x0600C0E9 RID: 49385 RVA: 0x0005A67D File Offset: 0x0005887D
		public unsafe Text CutLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CutLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600C0EA RID: 49386 RVA: 0x00313EC0 File Offset: 0x003120C0
		// (set) Token: 0x0600C0EB RID: 49387 RVA: 0x0005A69C File Offset: 0x0005889C
		public unsafe Text HomeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_HomeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A63 RID: 14947
		// (get) Token: 0x0600C0EC RID: 49388 RVA: 0x00313EF0 File Offset: 0x003120F0
		// (set) Token: 0x0600C0ED RID: 49389 RVA: 0x0005A6BB File Offset: 0x000588BB
		public unsafe Text _inventoryTextLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__inventoryTextLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__inventoryTextLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A64 RID: 14948
		// (get) Token: 0x0600C0EE RID: 49390 RVA: 0x00313F20 File Offset: 0x00312120
		// (set) Token: 0x0600C0EF RID: 49391 RVA: 0x0005A6DA File Offset: 0x000588DA
		public unsafe RectTransform _inventoryEntryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__inventoryEntryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__inventoryEntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A65 RID: 14949
		// (get) Token: 0x0600C0F0 RID: 49392 RVA: 0x00313F50 File Offset: 0x00312150
		// (set) Token: 0x0600C0F1 RID: 49393 RVA: 0x0005A6F9 File Offset: 0x000588F9
		public unsafe Il2CppReferenceArray<RectTransform> InventoryEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_InventoryEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A66 RID: 14950
		// (get) Token: 0x0600C0F2 RID: 49394 RVA: 0x00313F80 File Offset: 0x00312180
		// (set) Token: 0x0600C0F3 RID: 49395 RVA: 0x0005A718 File Offset: 0x00058918
		public unsafe Text CustomerTitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerTitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600C0F4 RID: 49396 RVA: 0x00313FB0 File Offset: 0x003121B0
		// (set) Token: 0x0600C0F5 RID: 49397 RVA: 0x0005A737 File Offset: 0x00058937
		public unsafe Il2CppReferenceArray<RectTransform> CustomerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_CustomerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600C0F6 RID: 49398 RVA: 0x00313FE0 File Offset: 0x003121E0
		// (set) Token: 0x0600C0F7 RID: 49399 RVA: 0x0005A756 File Offset: 0x00058956
		public unsafe Button AssignCustomerButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_AssignCustomerButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A69 RID: 14953
		// (get) Token: 0x0600C0F8 RID: 49400 RVA: 0x00314010 File Offset: 0x00312210
		// (set) Token: 0x0600C0F9 RID: 49401 RVA: 0x0005A775 File Offset: 0x00058975
		public unsafe SpriteFont _uiGeneralSpriteFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__uiGeneralSpriteFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__uiGeneralSpriteFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A6A RID: 14954
		// (get) Token: 0x0600C0FA RID: 49402 RVA: 0x00314040 File Offset: 0x00312240
		// (set) Token: 0x0600C0FB RID: 49403 RVA: 0x0005A794 File Offset: 0x00058994
		public unsafe ColorFont _productColorFont
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__productColorFont);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorFont>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__productColorFont), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A6B RID: 14955
		// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x00314070 File Offset: 0x00312270
		// (set) Token: 0x0600C0FD RID: 49405 RVA: 0x0005A7B3 File Offset: 0x000589B3
		public unsafe List<Dealer> dealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Dealer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr_dealers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003A6C RID: 14956
		// (get) Token: 0x0600C0FE RID: 49406 RVA: 0x003140A0 File Offset: 0x003122A0
		// (set) Token: 0x0600C0FF RID: 49407 RVA: 0x0005A7D2 File Offset: 0x000589D2
		public unsafe bool _isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.NativeFieldInfoPtr__isOpen)) = value;
			}
		}

		// Token: 0x040083E0 RID: 33760
		private static readonly IntPtr NativeFieldInfoPtr__SelectedDealer_k__BackingField;

		// Token: 0x040083E1 RID: 33761
		private static readonly IntPtr NativeFieldInfoPtr_NoDealersLabel;

		// Token: 0x040083E2 RID: 33762
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x040083E3 RID: 33763
		private static readonly IntPtr NativeFieldInfoPtr_CustomerSelector;

		// Token: 0x040083E4 RID: 33764
		private static readonly IntPtr NativeFieldInfoPtr_SelectorImage;

		// Token: 0x040083E5 RID: 33765
		private static readonly IntPtr NativeFieldInfoPtr_SelectorTitle;

		// Token: 0x040083E6 RID: 33766
		private static readonly IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x040083E7 RID: 33767
		private static readonly IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x040083E8 RID: 33768
		private static readonly IntPtr NativeFieldInfoPtr__dropdown;

		// Token: 0x040083E9 RID: 33769
		private static readonly IntPtr NativeFieldInfoPtr__dropdownBackground;

		// Token: 0x040083EA RID: 33770
		private static readonly IntPtr NativeFieldInfoPtr__dropdownCaptionImage;

		// Token: 0x040083EB RID: 33771
		private static readonly IntPtr NativeFieldInfoPtr__dropDownCaptionText;

		// Token: 0x040083EC RID: 33772
		private static readonly IntPtr NativeFieldInfoPtr_CashLabel;

		// Token: 0x040083ED RID: 33773
		private static readonly IntPtr NativeFieldInfoPtr_CutLabel;

		// Token: 0x040083EE RID: 33774
		private static readonly IntPtr NativeFieldInfoPtr_HomeLabel;

		// Token: 0x040083EF RID: 33775
		private static readonly IntPtr NativeFieldInfoPtr__inventoryTextLabel;

		// Token: 0x040083F0 RID: 33776
		private static readonly IntPtr NativeFieldInfoPtr__inventoryEntryContainer;

		// Token: 0x040083F1 RID: 33777
		private static readonly IntPtr NativeFieldInfoPtr_InventoryEntries;

		// Token: 0x040083F2 RID: 33778
		private static readonly IntPtr NativeFieldInfoPtr_CustomerTitleLabel;

		// Token: 0x040083F3 RID: 33779
		private static readonly IntPtr NativeFieldInfoPtr_CustomerEntries;

		// Token: 0x040083F4 RID: 33780
		private static readonly IntPtr NativeFieldInfoPtr_AssignCustomerButton;

		// Token: 0x040083F5 RID: 33781
		private static readonly IntPtr NativeFieldInfoPtr__uiGeneralSpriteFont;

		// Token: 0x040083F6 RID: 33782
		private static readonly IntPtr NativeFieldInfoPtr__productColorFont;

		// Token: 0x040083F7 RID: 33783
		private static readonly IntPtr NativeFieldInfoPtr_dealers;

		// Token: 0x040083F8 RID: 33784
		private static readonly IntPtr NativeFieldInfoPtr__isOpen;

		// Token: 0x040083F9 RID: 33785
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedDealer_Public_get_Dealer_0;

		// Token: 0x040083FA RID: 33786
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedDealer_Private_set_Void_Dealer_0;

		// Token: 0x040083FB RID: 33787
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040083FC RID: 33788
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040083FD RID: 33789
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040083FE RID: 33790
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Void_0;

		// Token: 0x040083FF RID: 33791
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04008400 RID: 33792
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedDealer_Public_Void_Dealer_0;

		// Token: 0x04008401 RID: 33793
		private static readonly IntPtr NativeMethodInfoPtr_AddDealer_Private_Void_Dealer_0;

		// Token: 0x04008402 RID: 33794
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Private_Void_Customer_0;

		// Token: 0x04008403 RID: 33795
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Private_Void_Customer_0;

		// Token: 0x04008404 RID: 33796
		private static readonly IntPtr NativeMethodInfoPtr_BackPressed_Private_Void_0;

		// Token: 0x04008405 RID: 33797
		private static readonly IntPtr NativeMethodInfoPtr_NextPressed_Private_Void_0;

		// Token: 0x04008406 RID: 33798
		private static readonly IntPtr NativeMethodInfoPtr_AssignCustomer_Public_Void_0;

		// Token: 0x04008407 RID: 33799
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDropdown_Private_Void_0;

		// Token: 0x04008408 RID: 33800
		private static readonly IntPtr NativeMethodInfoPtr_OnDropdownValueChanged_Private_Void_Int32_0;

		// Token: 0x04008409 RID: 33801
		private static readonly IntPtr NativeMethodInfoPtr_OnDropdownOpen_Private_Void_0;

		// Token: 0x0400840A RID: 33802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D3B RID: 3387
		public class InventoryItem : Il2CppSystem.Object
		{
			// Token: 0x0600F984 RID: 63876 RVA: 0x003BAF18 File Offset: 0x003B9118
			// Note: this type is marked as 'beforefieldinit'.
			static InventoryItem()
			{
				Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "InventoryItem");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr);
				DealerManagementApp.InventoryItem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr, "ID");
				DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr, "Quantity");
				DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr, "Quality");
				DealerManagementApp.InventoryItem.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr, 100688421);
			}

			// Token: 0x0600F985 RID: 63877 RVA: 0x003BAF94 File Offset: 0x003B9194
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 237335, RefRangeEnd = 237341, XrefRangeStart = 237335, XrefRangeEnd = 237341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InventoryItem(string id, int quantity, int quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.InventoryItem>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.InventoryItem.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F986 RID: 63878 RVA: 0x00076054 File Offset: 0x00074254
			public InventoryItem(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BDB RID: 19419
			// (get) Token: 0x0600F987 RID: 63879 RVA: 0x003BAFFC File Offset: 0x003B91FC
			// (set) Token: 0x0600F988 RID: 63880 RVA: 0x0007605D File Offset: 0x0007425D
			public unsafe string ID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_ID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BDC RID: 19420
			// (get) Token: 0x0600F989 RID: 63881 RVA: 0x003BB024 File Offset: 0x003B9224
			// (set) Token: 0x0600F98A RID: 63882 RVA: 0x0007607C File Offset: 0x0007427C
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x17004BDD RID: 19421
			// (get) Token: 0x0600F98B RID: 63883 RVA: 0x003BB04C File Offset: 0x003B924C
			// (set) Token: 0x0600F98C RID: 63884 RVA: 0x00076097 File Offset: 0x00074297
			public unsafe int Quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.InventoryItem.NativeFieldInfoPtr_Quality)) = value;
				}
			}

			// Token: 0x0400A883 RID: 43139
			private static readonly IntPtr NativeFieldInfoPtr_ID;

			// Token: 0x0400A884 RID: 43140
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x0400A885 RID: 43141
			private static readonly IntPtr NativeFieldInfoPtr_Quality;

			// Token: 0x0400A886 RID: 43142
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000D3C RID: 3388
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F98D RID: 63885 RVA: 0x003BB074 File Offset: 0x003B9274
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr);
				DealerManagementApp.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__33_1");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__33_2");
				DealerManagementApp.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, "<>9__34_0");
				DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100688423);
				DealerManagementApp.__c.NativeMethodInfoPtr__SetDisplayedDealer_b__33_1_Internal_Boolean_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100688424);
				DealerManagementApp.__c.NativeMethodInfoPtr__SetDisplayedDealer_b__33_2_Internal_Boolean_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100688425);
				DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__34_0_Internal_EMapRegion_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr, 100688426);
			}

			// Token: 0x0600F98E RID: 63886 RVA: 0x003BB140 File Offset: 0x003B9340
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F98F RID: 63887 RVA: 0x003BB17C File Offset: 0x003B937C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320037, XrefRangeEnd = 320043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetDisplayedDealer_b__33_1(Image img)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__SetDisplayedDealer_b__33_1_Internal_Boolean_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F990 RID: 63888 RVA: 0x003BB1CC File Offset: 0x003B93CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320043, XrefRangeEnd = 320049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetDisplayedDealer_b__33_2(Image img)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(img);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__SetDisplayedDealer_b__33_2_Internal_Boolean_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F991 RID: 63889 RVA: 0x003BB21C File Offset: 0x003B941C
			[CallerCount(0)]
			public unsafe EMapRegion _AddDealer_b__34_0(Dealer d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c.NativeMethodInfoPtr__AddDealer_b__34_0_Internal_EMapRegion_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F992 RID: 63890 RVA: 0x000760B2 File Offset: 0x000742B2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BDE RID: 19422
			// (get) Token: 0x0600F993 RID: 63891 RVA: 0x003BB26C File Offset: 0x003B946C
			// (set) Token: 0x0600F994 RID: 63892 RVA: 0x000760BB File Offset: 0x000742BB
			public unsafe static DealerManagementApp.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BDF RID: 19423
			// (get) Token: 0x0600F995 RID: 63893 RVA: 0x003BB294 File Offset: 0x003B9494
			// (set) Token: 0x0600F996 RID: 63894 RVA: 0x000760CD File Offset: 0x000742CD
			public unsafe static Predicate<Image> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE0 RID: 19424
			// (get) Token: 0x0600F997 RID: 63895 RVA: 0x003BB2BC File Offset: 0x003B94BC
			// (set) Token: 0x0600F998 RID: 63896 RVA: 0x000760DF File Offset: 0x000742DF
			public unsafe static Predicate<Image> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE1 RID: 19425
			// (get) Token: 0x0600F999 RID: 63897 RVA: 0x003BB2E4 File Offset: 0x003B94E4
			// (set) Token: 0x0600F99A RID: 63898 RVA: 0x000760F1 File Offset: 0x000742F1
			public unsafe static Func<Dealer, EMapRegion> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dealer, EMapRegion>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DealerManagementApp.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A887 RID: 43143
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A888 RID: 43144
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x0400A889 RID: 43145
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x0400A88A RID: 43146
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x0400A88B RID: 43147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A88C RID: 43148
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__33_1_Internal_Boolean_Image_0;

			// Token: 0x0400A88D RID: 43149
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__33_2_Internal_Boolean_Image_0;

			// Token: 0x0400A88E RID: 43150
			private static readonly IntPtr NativeMethodInfoPtr__AddDealer_b__34_0_Internal_EMapRegion_Dealer_0;
		}

		// Token: 0x02000D3D RID: 3389
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F99B RID: 63899 RVA: 0x003BB30C File Offset: 0x003B950C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr);
				DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr, "slot");
				DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr, "quality");
				DealerManagementApp.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr, 100688427);
				DealerManagementApp.__c__DisplayClass33_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Boolean_InventoryItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr, 100688428);
			}

			// Token: 0x0600F99C RID: 63900 RVA: 0x003BB388 File Offset: 0x003B9588
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F99D RID: 63901 RVA: 0x003BB3C4 File Offset: 0x003B95C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320049, XrefRangeEnd = 320051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetDisplayedDealer_b__0(DealerManagementApp.InventoryItem i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(i);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass33_0.NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Boolean_InventoryItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F99E RID: 63902 RVA: 0x00076103 File Offset: 0x00074303
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BE2 RID: 19426
			// (get) Token: 0x0600F99F RID: 63903 RVA: 0x003BB414 File Offset: 0x003B9614
			// (set) Token: 0x0600F9A0 RID: 63904 RVA: 0x0007610C File Offset: 0x0007430C
			public unsafe ItemSlot slot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_slot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_slot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE3 RID: 19427
			// (get) Token: 0x0600F9A1 RID: 63905 RVA: 0x003BB444 File Offset: 0x003B9644
			// (set) Token: 0x0600F9A2 RID: 63906 RVA: 0x0007612B File Offset: 0x0007432B
			public unsafe int quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_0.NativeFieldInfoPtr_quality)) = value;
				}
			}

			// Token: 0x0400A88F RID: 43151
			private static readonly IntPtr NativeFieldInfoPtr_slot;

			// Token: 0x0400A890 RID: 43152
			private static readonly IntPtr NativeFieldInfoPtr_quality;

			// Token: 0x0400A891 RID: 43153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A892 RID: 43154
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__0_Internal_Boolean_InventoryItem_0;
		}

		// Token: 0x02000D3E RID: 3390
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.DealerManagementApp+<>c__DisplayClass33_1")]
		public sealed class __c__DisplayClass33_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F9A3 RID: 63907 RVA: 0x003BB46C File Offset: 0x003B966C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_1()
			{
				Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealerManagementApp>.NativeClassPtr, "<>c__DisplayClass33_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr);
				DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr, "customer");
				DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr, "<>4__this");
				DealerManagementApp.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr, 100688429);
				DealerManagementApp.__c__DisplayClass33_1.NativeMethodInfoPtr__SetDisplayedDealer_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr, 100688430);
			}

			// Token: 0x0600F9A4 RID: 63908 RVA: 0x003BB4E8 File Offset: 0x003B96E8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealerManagementApp.__c__DisplayClass33_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass33_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9A5 RID: 63909 RVA: 0x003BB524 File Offset: 0x003B9724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 320051, XrefRangeEnd = 320055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetDisplayedDealer_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealerManagementApp.__c__DisplayClass33_1.NativeMethodInfoPtr__SetDisplayedDealer_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F9A6 RID: 63910 RVA: 0x00076146 File Offset: 0x00074346
			public __c__DisplayClass33_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BE4 RID: 19428
			// (get) Token: 0x0600F9A7 RID: 63911 RVA: 0x003BB558 File Offset: 0x003B9758
			// (set) Token: 0x0600F9A8 RID: 63912 RVA: 0x0007614F File Offset: 0x0007434F
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE5 RID: 19429
			// (get) Token: 0x0600F9A9 RID: 63913 RVA: 0x003BB588 File Offset: 0x003B9788
			// (set) Token: 0x0600F9AA RID: 63914 RVA: 0x0007616E File Offset: 0x0007436E
			public unsafe DealerManagementApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealerManagementApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealerManagementApp.__c__DisplayClass33_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A893 RID: 43155
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x0400A894 RID: 43156
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A895 RID: 43157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A896 RID: 43158
			private static readonly IntPtr NativeMethodInfoPtr__SetDisplayedDealer_b__3_Internal_Void_0;
		}
	}
}
