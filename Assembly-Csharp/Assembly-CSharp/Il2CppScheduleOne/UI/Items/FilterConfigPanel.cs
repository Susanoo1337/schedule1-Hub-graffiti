using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.State;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000824 RID: 2084
	public class FilterConfigPanel : MonoBehaviour
	{
		// Token: 0x0600CA52 RID: 51794 RVA: 0x00330394 File Offset: 0x0032E594
		// Note: this type is marked as 'beforefieldinit'.
		static FilterConfigPanel()
		{
			Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "FilterConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr);
			FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<IsOpen>k__BackingField");
			FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<OpenSlot>k__BackingField");
			FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ItemEntryPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CategoryPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchItemPrefab");
			FilterConfigPanel.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Rect");
			FilterConfigPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Container");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_None");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_Whitelist");
			FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeButton_Blacklist");
			FilterConfigPanel.NativeFieldInfoPtr_TypeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "TypeLabel");
			FilterConfigPanel.NativeFieldInfoPtr_ListLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListLabel");
			FilterConfigPanel.NativeFieldInfoPtr_ListContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListContainer");
			FilterConfigPanel.NativeFieldInfoPtr_ListBlocker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListBlocker");
			FilterConfigPanel.NativeFieldInfoPtr_QualityButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "QualityButtons");
			FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ListScrollRect");
			FilterConfigPanel.NativeFieldInfoPtr_Dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "Dropdown");
			FilterConfigPanel.NativeFieldInfoPtr_CopyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CopyButton");
			FilterConfigPanel.NativeFieldInfoPtr_PasteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "PasteButton");
			FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ApplyToSiblingsButton");
			FilterConfigPanel.NativeFieldInfoPtr_ClearButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "ClearButton");
			FilterConfigPanel.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "State");
			FilterConfigPanel.NativeFieldInfoPtr_SearchContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchContainer");
			FilterConfigPanel.NativeFieldInfoPtr_SearchInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchInput");
			FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "CategoryContainer");
			FilterConfigPanel.NativeFieldInfoPtr__uiScreenData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "_uiScreenData");
			FilterConfigPanel.NativeFieldInfoPtr_mouseUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "mouseUp");
			FilterConfigPanel.NativeFieldInfoPtr_searchCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "searchCategories");
			FilterConfigPanel.NativeFieldInfoPtr_itemEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "itemEntries");
			FilterConfigPanel.NativeFieldInfoPtr_copiedFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "copiedFilter");
			FilterConfigPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689394);
			FilterConfigPanel.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689395);
			FilterConfigPanel.NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689396);
			FilterConfigPanel.NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689397);
			FilterConfigPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689398);
			FilterConfigPanel.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689399);
			FilterConfigPanel.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689400);
			FilterConfigPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689401);
			FilterConfigPanel.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689402);
			FilterConfigPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689403);
			FilterConfigPanel.NativeMethodInfoPtr_OnClose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689404);
			FilterConfigPanel.NativeMethodInfoPtr_UpdateSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689405);
			FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689406);
			FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689407);
			FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689408);
			FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689409);
			FilterConfigPanel.NativeMethodInfoPtr_AddClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689410);
			FilterConfigPanel.NativeMethodInfoPtr_CopyClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689411);
			FilterConfigPanel.NativeMethodInfoPtr_PasteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689412);
			FilterConfigPanel.NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689413);
			FilterConfigPanel.NativeMethodInfoPtr_ClearClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689414);
			FilterConfigPanel.NativeMethodInfoPtr_ToggleDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689415);
			FilterConfigPanel.NativeMethodInfoPtr_OpenDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689416);
			FilterConfigPanel.NativeMethodInfoPtr_CloseDropdown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689417);
			FilterConfigPanel.NativeMethodInfoPtr_ItemClicked_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689418);
			FilterConfigPanel.NativeMethodInfoPtr_AddItem_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689419);
			FilterConfigPanel.NativeMethodInfoPtr_RemoveItem_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689420);
			FilterConfigPanel.NativeMethodInfoPtr_RefreshDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689421);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689422);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689423);
			FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689424);
			FilterConfigPanel.NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689425);
			FilterConfigPanel.NativeMethodInfoPtr_OpenSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689426);
			FilterConfigPanel.NativeMethodInfoPtr_CloseSearch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689427);
			FilterConfigPanel.NativeMethodInfoPtr_SearchChanged_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689428);
			FilterConfigPanel.NativeMethodInfoPtr_SearchSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689429);
			FilterConfigPanel.NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689430);
			FilterConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689431);
			FilterConfigPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, 100689432);
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x0600CA53 RID: 51795 RVA: 0x00330928 File Offset: 0x0032EB28
		// (set) Token: 0x0600CA54 RID: 51796 RVA: 0x00330964 File Offset: 0x0032EB64
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x0600CA55 RID: 51797 RVA: 0x003309A4 File Offset: 0x0032EBA4
		// (set) Token: 0x0600CA56 RID: 51798 RVA: 0x003309E4 File Offset: 0x0032EBE4
		public unsafe ItemSlot OpenSlot
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x00330A28 File Offset: 0x0032EC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332392, XrefRangeEnd = 332430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x00330A5C File Offset: 0x0032EC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332430, XrefRangeEnd = 332431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x00330A90 File Offset: 0x0032EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332431, XrefRangeEnd = 332441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5A RID: 51802 RVA: 0x00330AD4 File Offset: 0x0032ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332441, XrefRangeEnd = 332442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x00330B08 File Offset: 0x0032ED08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332442, XrefRangeEnd = 332503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ItemSlotUI ui)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ui);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x00330B4C File Offset: 0x0032ED4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332505, RefRangeEnd = 332507, XrefRangeStart = 332503, XrefRangeEnd = 332505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5D RID: 51805 RVA: 0x00330B80 File Offset: 0x0032ED80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332549, RefRangeEnd = 332550, XrefRangeStart = 332507, XrefRangeEnd = 332549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_OnClose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x00330BB4 File Offset: 0x0032EDB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 332647, RefRangeEnd = 332649, XrefRangeStart = 332550, XrefRangeEnd = 332647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_UpdateSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x00330BE8 File Offset: 0x0032EDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332649, XrefRangeEnd = 332651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterModeSelected(int filterType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref filterType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x00330C28 File Offset: 0x0032EE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FilterModeSelected(SlotFilter.EType filterType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref filterType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x00330C68 File Offset: 0x0032EE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332651, XrefRangeEnd = 332665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QualitySelected(int quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x00330CA8 File Offset: 0x0032EEA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QualitySelected(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x00330CE8 File Offset: 0x0032EEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332665, XrefRangeEnd = 332666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_AddClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x00330D1C File Offset: 0x0032EF1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332666, XrefRangeEnd = 332679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CopyClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x00330D50 File Offset: 0x0032EF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332679, XrefRangeEnd = 332684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PasteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_PasteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x00330D84 File Offset: 0x0032EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332684, XrefRangeEnd = 332701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyToSiblingsClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x00330DB8 File Offset: 0x0032EFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332701, XrefRangeEnd = 332708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ClearClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x00330DEC File Offset: 0x0032EFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332708, XrefRangeEnd = 332713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ToggleDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x00330E20 File Offset: 0x0032F020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332749, RefRangeEnd = 332750, XrefRangeStart = 332713, XrefRangeEnd = 332749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_OpenDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x00330E54 File Offset: 0x0032F054
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 332764, RefRangeEnd = 332771, XrefRangeStart = 332750, XrefRangeEnd = 332764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CloseDropdown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x00330E88 File Offset: 0x0032F088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332781, RefRangeEnd = 332782, XrefRangeStart = 332771, XrefRangeEnd = 332781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ItemClicked(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_ItemClicked_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x00330ECC File Offset: 0x0032F0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332782, XrefRangeEnd = 332790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_AddItem_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x00330F10 File Offset: 0x0032F110
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332795, RefRangeEnd = 332796, XrefRangeStart = 332790, XrefRangeEnd = 332795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(string itemID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RemoveItem_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x00330F54 File Offset: 0x0032F154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332904, RefRangeEnd = 332905, XrefRangeStart = 332796, XrefRangeEnd = 332904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RefreshDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x00330F88 File Offset: 0x0032F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332905, XrefRangeEnd = 332915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x00330FC4 File Offset: 0x0032F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332915, XrefRangeEnd = 332922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x00331000 File Offset: 0x0032F200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332922, XrefRangeEnd = 332929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverDropdown()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x0033103C File Offset: 0x0032F23C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332948, RefRangeEnd = 332949, XrefRangeStart = 332929, XrefRangeEnd = 332948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigPanel.SearchCategory GetSearchCategory(EItemCategory category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref category;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.SearchCategory>(intPtr3) : null;
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x00331088 File Offset: 0x0032F288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332977, RefRangeEnd = 332978, XrefRangeStart = 332949, XrefRangeEnd = 332977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_OpenSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x003310BC File Offset: 0x0032F2BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 332992, RefRangeEnd = 332995, XrefRangeStart = 332978, XrefRangeEnd = 332992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseSearch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_CloseSearch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x003310F0 File Offset: 0x0032F2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332995, XrefRangeEnd = 332996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchChanged(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_SearchChanged_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA76 RID: 51830 RVA: 0x00331134 File Offset: 0x0032F334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SearchSubmitted(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_SearchSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x00331178 File Offset: 0x0032F378
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333011, RefRangeEnd = 333014, XrefRangeStart = 332996, XrefRangeEnd = 333011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSearchResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA78 RID: 51832 RVA: 0x003311AC File Offset: 0x0032F3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333014, XrefRangeEnd = 333029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x003311E8 File Offset: 0x0032F3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333029, XrefRangeEnd = 333034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600CA7A RID: 51834 RVA: 0x0005FE97 File Offset: 0x0005E097
		public FilterConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600CA7B RID: 51835 RVA: 0x00331228 File Offset: 0x0032F428
		// (set) Token: 0x0600CA7C RID: 51836 RVA: 0x0005FEA0 File Offset: 0x0005E0A0
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600CA7D RID: 51837 RVA: 0x00331250 File Offset: 0x0032F450
		// (set) Token: 0x0600CA7E RID: 51838 RVA: 0x0005FEBB File Offset: 0x0005E0BB
		public unsafe ItemSlot _OpenSlot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__OpenSlot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600CA7F RID: 51839 RVA: 0x00331280 File Offset: 0x0032F480
		// (set) Token: 0x0600CA80 RID: 51840 RVA: 0x0005FEDA File Offset: 0x0005E0DA
		public unsafe GameObject ItemEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ItemEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x003312B0 File Offset: 0x0032F4B0
		// (set) Token: 0x0600CA82 RID: 51842 RVA: 0x0005FEF9 File Offset: 0x0005E0F9
		public unsafe GameObject CategoryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x0600CA83 RID: 51843 RVA: 0x003312E0 File Offset: 0x0032F4E0
		// (set) Token: 0x0600CA84 RID: 51844 RVA: 0x0005FF18 File Offset: 0x0005E118
		public unsafe GameObject SearchItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x00331310 File Offset: 0x0032F510
		// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x0005FF37 File Offset: 0x0005E137
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600CA87 RID: 51847 RVA: 0x00331340 File Offset: 0x0032F540
		// (set) Token: 0x0600CA88 RID: 51848 RVA: 0x0005FF56 File Offset: 0x0005E156
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x00331370 File Offset: 0x0032F570
		// (set) Token: 0x0600CA8A RID: 51850 RVA: 0x0005FF75 File Offset: 0x0005E175
		public unsafe Button TypeButton_None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600CA8B RID: 51851 RVA: 0x003313A0 File Offset: 0x0032F5A0
		// (set) Token: 0x0600CA8C RID: 51852 RVA: 0x0005FF94 File Offset: 0x0005E194
		public unsafe Button TypeButton_Whitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Whitelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x003313D0 File Offset: 0x0032F5D0
		// (set) Token: 0x0600CA8E RID: 51854 RVA: 0x0005FFB3 File Offset: 0x0005E1B3
		public unsafe Button TypeButton_Blacklist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeButton_Blacklist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x0600CA8F RID: 51855 RVA: 0x00331400 File Offset: 0x0032F600
		// (set) Token: 0x0600CA90 RID: 51856 RVA: 0x0005FFD2 File Offset: 0x0005E1D2
		public unsafe TextMeshProUGUI TypeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_TypeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x00331430 File Offset: 0x0032F630
		// (set) Token: 0x0600CA92 RID: 51858 RVA: 0x0005FFF1 File Offset: 0x0005E1F1
		public unsafe TextMeshProUGUI ListLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x00331460 File Offset: 0x0032F660
		// (set) Token: 0x0600CA94 RID: 51860 RVA: 0x00060010 File Offset: 0x0005E210
		public unsafe RectTransform ListContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x00331490 File Offset: 0x0032F690
		// (set) Token: 0x0600CA96 RID: 51862 RVA: 0x0006002F File Offset: 0x0005E22F
		public unsafe GameObject ListBlocker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListBlocker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListBlocker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x003314C0 File Offset: 0x0032F6C0
		// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x0006004E File Offset: 0x0005E24E
		public unsafe Il2CppReferenceArray<Button> QualityButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_QualityButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_QualityButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x003314F0 File Offset: 0x0032F6F0
		// (set) Token: 0x0600CA9A RID: 51866 RVA: 0x0006006D File Offset: 0x0005E26D
		public unsafe ScrollRect ListScrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ListScrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600CA9B RID: 51867 RVA: 0x00331520 File Offset: 0x0032F720
		// (set) Token: 0x0600CA9C RID: 51868 RVA: 0x0006008C File Offset: 0x0005E28C
		public unsafe RectTransform Dropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Dropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_Dropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600CA9D RID: 51869 RVA: 0x00331550 File Offset: 0x0032F750
		// (set) Token: 0x0600CA9E RID: 51870 RVA: 0x000600AB File Offset: 0x0005E2AB
		public unsafe Button CopyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CopyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CopyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x00331580 File Offset: 0x0032F780
		// (set) Token: 0x0600CAA0 RID: 51872 RVA: 0x000600CA File Offset: 0x0005E2CA
		public unsafe Button PasteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_PasteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_PasteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x003315B0 File Offset: 0x0032F7B0
		// (set) Token: 0x0600CAA2 RID: 51874 RVA: 0x000600E9 File Offset: 0x0005E2E9
		public unsafe Button ApplyToSiblingsButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ApplyToSiblingsButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x0600CAA3 RID: 51875 RVA: 0x003315E0 File Offset: 0x0032F7E0
		// (set) Token: 0x0600CAA4 RID: 51876 RVA: 0x00060108 File Offset: 0x0005E308
		public unsafe Button ClearButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ClearButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_ClearButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x00331610 File Offset: 0x0032F810
		// (set) Token: 0x0600CAA6 RID: 51878 RVA: 0x00060127 File Offset: 0x0005E327
		public unsafe MonoState State
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_State);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_State), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x00331640 File Offset: 0x0032F840
		// (set) Token: 0x0600CAA8 RID: 51880 RVA: 0x00060146 File Offset: 0x0005E346
		public unsafe RectTransform SearchContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x00331670 File Offset: 0x0032F870
		// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x00060165 File Offset: 0x0005E365
		public unsafe TMP_InputField SearchInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_SearchInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x0600CAAB RID: 51883 RVA: 0x003316A0 File Offset: 0x0032F8A0
		// (set) Token: 0x0600CAAC RID: 51884 RVA: 0x00060184 File Offset: 0x0005E384
		public unsafe RectTransform CategoryContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_CategoryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600CAAD RID: 51885 RVA: 0x003316D0 File Offset: 0x0032F8D0
		// (set) Token: 0x0600CAAE RID: 51886 RVA: 0x000601A3 File Offset: 0x0005E3A3
		public unsafe List<FilterConfigPanel.PanelData> _uiScreenData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__uiScreenData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FilterConfigPanel.PanelData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr__uiScreenData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600CAAF RID: 51887 RVA: 0x00331700 File Offset: 0x0032F900
		// (set) Token: 0x0600CAB0 RID: 51888 RVA: 0x000601C2 File Offset: 0x0005E3C2
		public unsafe bool mouseUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_mouseUp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_mouseUp)) = value;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600CAB1 RID: 51889 RVA: 0x00331728 File Offset: 0x0032F928
		// (set) Token: 0x0600CAB2 RID: 51890 RVA: 0x000601DD File Offset: 0x0005E3DD
		public unsafe List<FilterConfigPanel.SearchCategory> searchCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_searchCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FilterConfigPanel.SearchCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_searchCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x0600CAB3 RID: 51891 RVA: 0x00331758 File Offset: 0x0032F958
		// (set) Token: 0x0600CAB4 RID: 51892 RVA: 0x000601FC File Offset: 0x0005E3FC
		public unsafe List<RectTransform> itemEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_itemEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.NativeFieldInfoPtr_itemEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x0600CAB5 RID: 51893 RVA: 0x00331788 File Offset: 0x0032F988
		// (set) Token: 0x0600CAB6 RID: 51894 RVA: 0x0006021B File Offset: 0x0005E41B
		public unsafe static SlotFilter copiedFilter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.NativeFieldInfoPtr_copiedFilter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.NativeFieldInfoPtr_copiedFilter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040089C4 RID: 35268
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040089C5 RID: 35269
		private static readonly IntPtr NativeFieldInfoPtr__OpenSlot_k__BackingField;

		// Token: 0x040089C6 RID: 35270
		private static readonly IntPtr NativeFieldInfoPtr_ItemEntryPrefab;

		// Token: 0x040089C7 RID: 35271
		private static readonly IntPtr NativeFieldInfoPtr_CategoryPrefab;

		// Token: 0x040089C8 RID: 35272
		private static readonly IntPtr NativeFieldInfoPtr_SearchItemPrefab;

		// Token: 0x040089C9 RID: 35273
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x040089CA RID: 35274
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040089CB RID: 35275
		private static readonly IntPtr NativeFieldInfoPtr_TypeButton_None;

		// Token: 0x040089CC RID: 35276
		private static readonly IntPtr NativeFieldInfoPtr_TypeButton_Whitelist;

		// Token: 0x040089CD RID: 35277
		private static readonly IntPtr NativeFieldInfoPtr_TypeButton_Blacklist;

		// Token: 0x040089CE RID: 35278
		private static readonly IntPtr NativeFieldInfoPtr_TypeLabel;

		// Token: 0x040089CF RID: 35279
		private static readonly IntPtr NativeFieldInfoPtr_ListLabel;

		// Token: 0x040089D0 RID: 35280
		private static readonly IntPtr NativeFieldInfoPtr_ListContainer;

		// Token: 0x040089D1 RID: 35281
		private static readonly IntPtr NativeFieldInfoPtr_ListBlocker;

		// Token: 0x040089D2 RID: 35282
		private static readonly IntPtr NativeFieldInfoPtr_QualityButtons;

		// Token: 0x040089D3 RID: 35283
		private static readonly IntPtr NativeFieldInfoPtr_ListScrollRect;

		// Token: 0x040089D4 RID: 35284
		private static readonly IntPtr NativeFieldInfoPtr_Dropdown;

		// Token: 0x040089D5 RID: 35285
		private static readonly IntPtr NativeFieldInfoPtr_CopyButton;

		// Token: 0x040089D6 RID: 35286
		private static readonly IntPtr NativeFieldInfoPtr_PasteButton;

		// Token: 0x040089D7 RID: 35287
		private static readonly IntPtr NativeFieldInfoPtr_ApplyToSiblingsButton;

		// Token: 0x040089D8 RID: 35288
		private static readonly IntPtr NativeFieldInfoPtr_ClearButton;

		// Token: 0x040089D9 RID: 35289
		private static readonly IntPtr NativeFieldInfoPtr_State;

		// Token: 0x040089DA RID: 35290
		private static readonly IntPtr NativeFieldInfoPtr_SearchContainer;

		// Token: 0x040089DB RID: 35291
		private static readonly IntPtr NativeFieldInfoPtr_SearchInput;

		// Token: 0x040089DC RID: 35292
		private static readonly IntPtr NativeFieldInfoPtr_CategoryContainer;

		// Token: 0x040089DD RID: 35293
		private static readonly IntPtr NativeFieldInfoPtr__uiScreenData;

		// Token: 0x040089DE RID: 35294
		private static readonly IntPtr NativeFieldInfoPtr_mouseUp;

		// Token: 0x040089DF RID: 35295
		private static readonly IntPtr NativeFieldInfoPtr_searchCategories;

		// Token: 0x040089E0 RID: 35296
		private static readonly IntPtr NativeFieldInfoPtr_itemEntries;

		// Token: 0x040089E1 RID: 35297
		private static readonly IntPtr NativeFieldInfoPtr_copiedFilter;

		// Token: 0x040089E2 RID: 35298
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040089E3 RID: 35299
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040089E4 RID: 35300
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenSlot_Public_get_ItemSlot_0;

		// Token: 0x040089E5 RID: 35301
		private static readonly IntPtr NativeMethodInfoPtr_set_OpenSlot_Private_set_Void_ItemSlot_0;

		// Token: 0x040089E6 RID: 35302
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040089E7 RID: 35303
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040089E8 RID: 35304
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040089E9 RID: 35305
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040089EA RID: 35306
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ItemSlotUI_0;

		// Token: 0x040089EB RID: 35307
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040089EC RID: 35308
		private static readonly IntPtr NativeMethodInfoPtr_OnClose_Private_Void_0;

		// Token: 0x040089ED RID: 35309
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSearch_Private_Void_0;

		// Token: 0x040089EE RID: 35310
		private static readonly IntPtr NativeMethodInfoPtr_FilterModeSelected_Public_Void_Int32_0;

		// Token: 0x040089EF RID: 35311
		private static readonly IntPtr NativeMethodInfoPtr_FilterModeSelected_Public_Void_EType_0;

		// Token: 0x040089F0 RID: 35312
		private static readonly IntPtr NativeMethodInfoPtr_QualitySelected_Public_Void_Int32_0;

		// Token: 0x040089F1 RID: 35313
		private static readonly IntPtr NativeMethodInfoPtr_QualitySelected_Public_Void_EQuality_0;

		// Token: 0x040089F2 RID: 35314
		private static readonly IntPtr NativeMethodInfoPtr_AddClicked_Public_Void_0;

		// Token: 0x040089F3 RID: 35315
		private static readonly IntPtr NativeMethodInfoPtr_CopyClicked_Public_Void_0;

		// Token: 0x040089F4 RID: 35316
		private static readonly IntPtr NativeMethodInfoPtr_PasteClicked_Public_Void_0;

		// Token: 0x040089F5 RID: 35317
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToSiblingsClicked_Public_Void_0;

		// Token: 0x040089F6 RID: 35318
		private static readonly IntPtr NativeMethodInfoPtr_ClearClicked_Public_Void_0;

		// Token: 0x040089F7 RID: 35319
		private static readonly IntPtr NativeMethodInfoPtr_ToggleDropdown_Public_Void_0;

		// Token: 0x040089F8 RID: 35320
		private static readonly IntPtr NativeMethodInfoPtr_OpenDropdown_Public_Void_0;

		// Token: 0x040089F9 RID: 35321
		private static readonly IntPtr NativeMethodInfoPtr_CloseDropdown_Public_Void_0;

		// Token: 0x040089FA RID: 35322
		private static readonly IntPtr NativeMethodInfoPtr_ItemClicked_Private_Void_String_0;

		// Token: 0x040089FB RID: 35323
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Private_Void_String_0;

		// Token: 0x040089FC RID: 35324
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Private_Void_String_0;

		// Token: 0x040089FD RID: 35325
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplay_Private_Void_0;

		// Token: 0x040089FE RID: 35326
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverPanel_Private_Boolean_0;

		// Token: 0x040089FF RID: 35327
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverSearch_Private_Boolean_0;

		// Token: 0x04008A00 RID: 35328
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverDropdown_Private_Boolean_0;

		// Token: 0x04008A01 RID: 35329
		private static readonly IntPtr NativeMethodInfoPtr_GetSearchCategory_Private_SearchCategory_EItemCategory_0;

		// Token: 0x04008A02 RID: 35330
		private static readonly IntPtr NativeMethodInfoPtr_OpenSearch_Private_Void_0;

		// Token: 0x04008A03 RID: 35331
		private static readonly IntPtr NativeMethodInfoPtr_CloseSearch_Private_Void_0;

		// Token: 0x04008A04 RID: 35332
		private static readonly IntPtr NativeMethodInfoPtr_SearchChanged_Private_Void_String_0;

		// Token: 0x04008A05 RID: 35333
		private static readonly IntPtr NativeMethodInfoPtr_SearchSubmitted_Private_Void_String_0;

		// Token: 0x04008A06 RID: 35334
		private static readonly IntPtr NativeMethodInfoPtr_RefreshSearchResults_Private_Void_0;

		// Token: 0x04008A07 RID: 35335
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008A08 RID: 35336
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000D82 RID: 3458
		public class SearchCategory : Il2CppSystem.Object
		{
			// Token: 0x0600FBFF RID: 64511 RVA: 0x003C202C File Offset: 0x003C022C
			// Note: this type is marked as 'beforefieldinit'.
			static SearchCategory()
			{
				Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "SearchCategory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr);
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Category");
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Container");
				FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Items");
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100689433);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_SetSearch_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100689434);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_GetItem_Public_Item_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100689435);
				FilterConfigPanel.SearchCategory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, 100689436);
			}

			// Token: 0x0600FC00 RID: 64512 RVA: 0x003C20E4 File Offset: 0x003C02E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332324, RefRangeEnd = 332325, XrefRangeStart = 332312, XrefRangeEnd = 332324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void AddItem(ItemDefinition item, RectTransform entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC01 RID: 64513 RVA: 0x003C2138 File Offset: 0x003C0338
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332351, RefRangeEnd = 332352, XrefRangeStart = 332325, XrefRangeEnd = 332351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetSearch(string search)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_SetSearch_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC02 RID: 64514 RVA: 0x003C217C File Offset: 0x003C037C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332360, RefRangeEnd = 332361, XrefRangeStart = 332352, XrefRangeEnd = 332360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FilterConfigPanel.SearchCategory.Item GetItem(string itemID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr_GetItem_Public_Item_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.SearchCategory.Item>(intPtr3) : null;
			}

			// Token: 0x0600FC03 RID: 64515 RVA: 0x003C21CC File Offset: 0x003C03CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332361, XrefRangeEnd = 332369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SearchCategory() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC04 RID: 64516 RVA: 0x000774B5 File Offset: 0x000756B5
			public SearchCategory(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C94 RID: 19604
			// (get) Token: 0x0600FC05 RID: 64517 RVA: 0x003C2208 File Offset: 0x003C0408
			// (set) Token: 0x0600FC06 RID: 64518 RVA: 0x000774BE File Offset: 0x000756BE
			public unsafe EItemCategory Category
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Category)) = value;
				}
			}

			// Token: 0x17004C95 RID: 19605
			// (get) Token: 0x0600FC07 RID: 64519 RVA: 0x003C2230 File Offset: 0x003C0430
			// (set) Token: 0x0600FC08 RID: 64520 RVA: 0x000774D9 File Offset: 0x000756D9
			public unsafe RectTransform Container
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C96 RID: 19606
			// (get) Token: 0x0600FC09 RID: 64521 RVA: 0x003C2260 File Offset: 0x003C0460
			// (set) Token: 0x0600FC0A RID: 64522 RVA: 0x000774F8 File Offset: 0x000756F8
			public unsafe List<FilterConfigPanel.SearchCategory.Item> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FilterConfigPanel.SearchCategory.Item>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9F6 RID: 43510
			private static readonly IntPtr NativeFieldInfoPtr_Category;

			// Token: 0x0400A9F7 RID: 43511
			private static readonly IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x0400A9F8 RID: 43512
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x0400A9F9 RID: 43513
			private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_ItemDefinition_RectTransform_0;

			// Token: 0x0400A9FA RID: 43514
			private static readonly IntPtr NativeMethodInfoPtr_SetSearch_Public_Void_String_0;

			// Token: 0x0400A9FB RID: 43515
			private static readonly IntPtr NativeMethodInfoPtr_GetItem_Public_Item_String_0;

			// Token: 0x0400A9FC RID: 43516
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000E1C RID: 3612
			public class Item : Il2CppSystem.Object
			{
				// Token: 0x06010455 RID: 66645 RVA: 0x003DA720 File Offset: 0x003D8920
				// Note: this type is marked as 'beforefieldinit'.
				static Item()
				{
					Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory>.NativeClassPtr, "Item");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr);
					FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, "ItemDefinition");
					FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, "Entry");
					FilterConfigPanel.SearchCategory.Item.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr, 100689437);
				}

				// Token: 0x06010456 RID: 66646 RVA: 0x003DA788 File Offset: 0x003D8988
				[CallerCount(2575)]
				[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Item() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.SearchCategory.Item>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.SearchCategory.Item.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06010457 RID: 66647 RVA: 0x0007B8C2 File Offset: 0x00079AC2
				public Item(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004FA1 RID: 20385
				// (get) Token: 0x06010458 RID: 66648 RVA: 0x003DA7C4 File Offset: 0x003D89C4
				// (set) Token: 0x06010459 RID: 66649 RVA: 0x0007B8CB File Offset: 0x00079ACB
				public unsafe ItemDefinition ItemDefinition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_ItemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004FA2 RID: 20386
				// (get) Token: 0x0601045A RID: 66650 RVA: 0x003DA7F4 File Offset: 0x003D89F4
				// (set) Token: 0x0601045B RID: 66651 RVA: 0x0007B8EA File Offset: 0x00079AEA
				public unsafe RectTransform Entry
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.SearchCategory.Item.NativeFieldInfoPtr_Entry), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400AF20 RID: 44832
				private static readonly IntPtr NativeFieldInfoPtr_ItemDefinition;

				// Token: 0x0400AF21 RID: 44833
				private static readonly IntPtr NativeFieldInfoPtr_Entry;

				// Token: 0x0400AF22 RID: 44834
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000D83 RID: 3459
		[Serializable]
		public class PanelData : Il2CppSystem.Object
		{
			// Token: 0x0600FC0B RID: 64523 RVA: 0x003C2290 File Offset: 0x003C0490
			// Note: this type is marked as 'beforefieldinit'.
			static PanelData()
			{
				Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "PanelData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr);
				FilterConfigPanel.PanelData.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr, "Screen");
				FilterConfigPanel.PanelData.NativeFieldInfoPtr_DefaultPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr, "DefaultPanel");
				FilterConfigPanel.PanelData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr, 100689438);
			}

			// Token: 0x0600FC0C RID: 64524 RVA: 0x003C22F8 File Offset: 0x003C04F8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PanelData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.PanelData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.PanelData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC0D RID: 64525 RVA: 0x00077517 File Offset: 0x00075717
			public PanelData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C97 RID: 19607
			// (get) Token: 0x0600FC0E RID: 64526 RVA: 0x003C2334 File Offset: 0x003C0534
			// (set) Token: 0x0600FC0F RID: 64527 RVA: 0x00077520 File Offset: 0x00075720
			public unsafe UIScreen Screen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.PanelData.NativeFieldInfoPtr_Screen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.PanelData.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C98 RID: 19608
			// (get) Token: 0x0600FC10 RID: 64528 RVA: 0x003C2364 File Offset: 0x003C0564
			// (set) Token: 0x0600FC11 RID: 64529 RVA: 0x0007753F File Offset: 0x0007573F
			public unsafe UIPanel DefaultPanel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.PanelData.NativeFieldInfoPtr_DefaultPanel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.PanelData.NativeFieldInfoPtr_DefaultPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A9FD RID: 43517
			private static readonly IntPtr NativeFieldInfoPtr_Screen;

			// Token: 0x0400A9FE RID: 43518
			private static readonly IntPtr NativeFieldInfoPtr_DefaultPanel;

			// Token: 0x0400A9FF RID: 43519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000D84 RID: 3460
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<<Open>g__Open|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600FC12 RID: 64530 RVA: 0x003C2394 File Offset: 0x003C0594
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<<Open>g__Open|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689439);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689440);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689441);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689442);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689443);
				FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100689444);
			}

			// Token: 0x0600FC13 RID: 64531 RVA: 0x003C2474 File Offset: 0x003C0674
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC14 RID: 64532 RVA: 0x003C24BC File Offset: 0x003C06BC
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC15 RID: 64533 RVA: 0x003C24F0 File Offset: 0x003C06F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332369, XrefRangeEnd = 332375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C9C RID: 19612
			// (get) Token: 0x0600FC16 RID: 64534 RVA: 0x003C252C File Offset: 0x003C072C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FC17 RID: 64535 RVA: 0x003C256C File Offset: 0x003C076C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332375, XrefRangeEnd = 332380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C9D RID: 19613
			// (get) Token: 0x0600FC18 RID: 64536 RVA: 0x003C25A0 File Offset: 0x003C07A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600FC19 RID: 64537 RVA: 0x0007755E File Offset: 0x0007575E
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C99 RID: 19609
			// (get) Token: 0x0600FC1A RID: 64538 RVA: 0x003C25E0 File Offset: 0x003C07E0
			// (set) Token: 0x0600FC1B RID: 64539 RVA: 0x00077567 File Offset: 0x00075767
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004C9A RID: 19610
			// (get) Token: 0x0600FC1C RID: 64540 RVA: 0x003C2608 File Offset: 0x003C0808
			// (set) Token: 0x0600FC1D RID: 64541 RVA: 0x00077582 File Offset: 0x00075782
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9B RID: 19611
			// (get) Token: 0x0600FC1E RID: 64542 RVA: 0x003C2638 File Offset: 0x003C0838
			// (set) Token: 0x0600FC1F RID: 64543 RVA: 0x000775A1 File Offset: 0x000757A1
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA00 RID: 43520
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AA01 RID: 43521
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AA02 RID: 43522
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA03 RID: 43523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AA04 RID: 43524
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AA05 RID: 43525
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AA06 RID: 43526
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AA07 RID: 43527
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AA08 RID: 43528
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D85 RID: 3461
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600FC20 RID: 64544 RVA: 0x003C2668 File Offset: 0x003C0868
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr);
				FilterConfigPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9");
				FilterConfigPanel.__c.NativeFieldInfoPtr___9__44_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9__44_1");
				FilterConfigPanel.__c.NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, "<>9__64_0");
				FilterConfigPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100689446);
				FilterConfigPanel.__c.NativeMethodInfoPtr__UpdateSearch_b__44_1_Internal_Int32_Item_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100689447);
				FilterConfigPanel.__c.NativeMethodInfoPtr__GetSearchCategory_b__64_0_Internal_Int32_SearchCategory_SearchCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr, 100689448);
			}

			// Token: 0x0600FC21 RID: 64545 RVA: 0x003C270C File Offset: 0x003C090C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC22 RID: 64546 RVA: 0x003C2748 File Offset: 0x003C0948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332380, XrefRangeEnd = 332382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateSearch_b__44_1(FilterConfigPanel.SearchCategory.Item a, FilterConfigPanel.SearchCategory.Item b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__UpdateSearch_b__44_1_Internal_Int32_Item_Item_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC23 RID: 64547 RVA: 0x003C27A8 File Offset: 0x003C09A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332382, XrefRangeEnd = 332388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetSearchCategory_b__64_0(FilterConfigPanel.SearchCategory a, FilterConfigPanel.SearchCategory b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c.NativeMethodInfoPtr__GetSearchCategory_b__64_0_Internal_Int32_SearchCategory_SearchCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600FC24 RID: 64548 RVA: 0x000775C0 File Offset: 0x000757C0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C9E RID: 19614
			// (get) Token: 0x0600FC25 RID: 64549 RVA: 0x003C2808 File Offset: 0x003C0A08
			// (set) Token: 0x0600FC26 RID: 64550 RVA: 0x000775C9 File Offset: 0x000757C9
			public unsafe static FilterConfigPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9F RID: 19615
			// (get) Token: 0x0600FC27 RID: 64551 RVA: 0x003C2830 File Offset: 0x003C0A30
			// (set) Token: 0x0600FC28 RID: 64552 RVA: 0x000775DB File Offset: 0x000757DB
			public unsafe static Comparison<FilterConfigPanel.SearchCategory.Item> __9__44_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__44_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FilterConfigPanel.SearchCategory.Item>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__44_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA0 RID: 19616
			// (get) Token: 0x0600FC29 RID: 64553 RVA: 0x003C2858 File Offset: 0x003C0A58
			// (set) Token: 0x0600FC2A RID: 64554 RVA: 0x000775ED File Offset: 0x000757ED
			public unsafe static Comparison<FilterConfigPanel.SearchCategory> __9__64_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FilterConfigPanel.SearchCategory>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FilterConfigPanel.__c.NativeFieldInfoPtr___9__64_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA09 RID: 43529
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AA0A RID: 43530
			private static readonly IntPtr NativeFieldInfoPtr___9__44_1;

			// Token: 0x0400AA0B RID: 43531
			private static readonly IntPtr NativeFieldInfoPtr___9__64_0;

			// Token: 0x0400AA0C RID: 43532
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA0D RID: 43533
			private static readonly IntPtr NativeMethodInfoPtr__UpdateSearch_b__44_1_Internal_Int32_Item_Item_0;

			// Token: 0x0400AA0E RID: 43534
			private static readonly IntPtr NativeMethodInfoPtr__GetSearchCategory_b__64_0_Internal_Int32_SearchCategory_SearchCategory_0;
		}

		// Token: 0x02000D86 RID: 3462
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c__DisplayClass44_0")]
		public sealed class __c__DisplayClass44_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC2B RID: 64555 RVA: 0x003C2880 File Offset: 0x003C0A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass44_0()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c__DisplayClass44_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr);
				FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr, "item");
				FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr, 100689449);
				FilterConfigPanel.__c__DisplayClass44_0.NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr, 100689450);
			}

			// Token: 0x0600FC2C RID: 64556 RVA: 0x003C28FC File Offset: 0x003C0AFC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass44_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass44_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass44_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC2D RID: 64557 RVA: 0x003C2938 File Offset: 0x003C0B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332388, XrefRangeEnd = 332390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateSearch_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass44_0.NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC2E RID: 64558 RVA: 0x000775FF File Offset: 0x000757FF
			public __c__DisplayClass44_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CA1 RID: 19617
			// (get) Token: 0x0600FC2F RID: 64559 RVA: 0x003C296C File Offset: 0x003C0B6C
			// (set) Token: 0x0600FC30 RID: 64560 RVA: 0x00077608 File Offset: 0x00075808
			public unsafe ItemDefinition item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA2 RID: 19618
			// (get) Token: 0x0600FC31 RID: 64561 RVA: 0x003C299C File Offset: 0x003C0B9C
			// (set) Token: 0x0600FC32 RID: 64562 RVA: 0x00077627 File Offset: 0x00075827
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass44_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA0F RID: 43535
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400AA10 RID: 43536
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA11 RID: 43537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA12 RID: 43538
			private static readonly IntPtr NativeMethodInfoPtr__UpdateSearch_b__0_Internal_Void_0;
		}

		// Token: 0x02000D87 RID: 3463
		[ObfuscatedName("ScheduleOne.UI.Items.FilterConfigPanel+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Il2CppSystem.Object
		{
			// Token: 0x0600FC33 RID: 64563 RVA: 0x003C29CC File Offset: 0x003C0BCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilterConfigPanel>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr);
				FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr, "item");
				FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				FilterConfigPanel.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr, 100689451);
				FilterConfigPanel.__c__DisplayClass60_0.NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr, 100689452);
			}

			// Token: 0x0600FC34 RID: 64564 RVA: 0x003C2A48 File Offset: 0x003C0C48
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterConfigPanel.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC35 RID: 64565 RVA: 0x003C2A84 File Offset: 0x003C0C84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332390, XrefRangeEnd = 332392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplay_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterConfigPanel.__c__DisplayClass60_0.NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600FC36 RID: 64566 RVA: 0x00077646 File Offset: 0x00075846
			public __c__DisplayClass60_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CA3 RID: 19619
			// (get) Token: 0x0600FC37 RID: 64567 RVA: 0x003C2AB8 File Offset: 0x003C0CB8
			// (set) Token: 0x0600FC38 RID: 64568 RVA: 0x0007764F File Offset: 0x0007584F
			public unsafe ItemDefinition item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA4 RID: 19620
			// (get) Token: 0x0600FC39 RID: 64569 RVA: 0x003C2AE8 File Offset: 0x003C0CE8
			// (set) Token: 0x0600FC3A RID: 64570 RVA: 0x0007766E File Offset: 0x0007586E
			public unsafe FilterConfigPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilterConfigPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilterConfigPanel.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AA13 RID: 43539
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x0400AA14 RID: 43540
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AA15 RID: 43541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AA16 RID: 43542
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplay_b__0_Internal_Void_0;
		}
	}
}
