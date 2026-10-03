using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020007A6 RID: 1958
	public class CounterOfferProductSelector : MonoBehaviour
	{
		// Token: 0x0600BD9B RID: 48539 RVA: 0x0030992C File Offset: 0x00307B2C
		// Note: this type is marked as 'beforefieldinit'.
		static CounterOfferProductSelector()
		{
			Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CounterOfferProductSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr);
			CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ENTRIES_PER_PAGE");
			CounterOfferProductSelector.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "Container");
			CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "SearchBar");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductContainer");
			CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "PageLabel");
			CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "ProductEntryPrefab");
			CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<IsOpen>k__BackingField");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductPreviewed");
			CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "onProductSelected");
			CounterOfferProductSelector.NativeFieldInfoPtr_uiSelectionScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "uiSelectionScreen");
			CounterOfferProductSelector.NativeFieldInfoPtr_uiSearchPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "uiSearchPanel");
			CounterOfferProductSelector.NativeFieldInfoPtr_uiWindowPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "uiWindowPanel");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntries");
			CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "productEntriesDict");
			CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "searchTerm");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageIndex");
			CounterOfferProductSelector.NativeFieldInfoPtr_pageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "pageCount");
			CounterOfferProductSelector.NativeFieldInfoPtr_results = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "results");
			CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "lastPreviewedResult");
			CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688017);
			CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688018);
			CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688019);
			CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688020);
			CounterOfferProductSelector.NativeMethodInfoPtr_DelaySelectSearchPanel_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688021);
			CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688022);
			CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688023);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688024);
			CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688025);
			CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688026);
			CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688027);
			CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688028);
			CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688029);
			CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688030);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688031);
			CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688032);
			CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688033);
			CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, 100688034);
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x0600BD9C RID: 48540 RVA: 0x00309C40 File Offset: 0x00307E40
		// (set) Token: 0x0600BD9D RID: 48541 RVA: 0x00309C7C File Offset: 0x00307E7C
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 46711, RefRangeEnd = 46714, XrefRangeStart = 46711, XrefRangeEnd = 46714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x00309CBC File Offset: 0x00307EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315709, XrefRangeEnd = 315719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x00309CF0 File Offset: 0x00307EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315749, RefRangeEnd = 315750, XrefRangeStart = 315719, XrefRangeEnd = 315749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x00309D24 File Offset: 0x00307F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315750, XrefRangeEnd = 315755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelaySelectSearchPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_DelaySelectSearchPanel_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x00309D64 File Offset: 0x00307F64
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 315763, RefRangeEnd = 315770, XrefRangeStart = 315755, XrefRangeEnd = 315763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x00309D98 File Offset: 0x00307F98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315770, XrefRangeEnd = 315782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x00309DCC File Offset: 0x00307FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315782, XrefRangeEnd = 315794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSearchTerm(string search)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(search);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x00309E10 File Offset: 0x00308010
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 315830, RefRangeEnd = 315832, XrefRangeStart = 315794, XrefRangeEnd = 315830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RebuildResultsList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_RebuildResultsList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00309E44 File Offset: 0x00308044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315934, RefRangeEnd = 315935, XrefRangeStart = 315832, XrefRangeEnd = 315934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ProductDefinition> GetMatchingProducts(string searchTerm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(searchTerm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x00309E94 File Offset: 0x00308094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 315957, RefRangeEnd = 315958, XrefRangeStart = 315935, XrefRangeEnd = 315957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureAllEntriesExist()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00309EC8 File Offset: 0x003080C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 316033, RefRangeEnd = 316034, XrefRangeStart = 315958, XrefRangeEnd = 316033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateProductEntry(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x00309F0C File Offset: 0x0030810C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316034, XrefRangeEnd = 316035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePage(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x00309F4C File Offset: 0x0030814C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 316109, RefRangeEnd = 316111, XrefRangeStart = 316035, XrefRangeEnd = 316109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPage(int page)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref page;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_SetPage_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x00309F8C File Offset: 0x0030818C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316111, XrefRangeEnd = 316112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductHovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x00309FD0 File Offset: 0x003081D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316112, XrefRangeEnd = 316113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductSelected(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x0030A014 File Offset: 0x00308214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316113, XrefRangeEnd = 316135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMouseOverSelector()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x0030A050 File Offset: 0x00308250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 316135, XrefRangeEnd = 316160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CounterOfferProductSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x0005872F File Offset: 0x0005692F
		public CounterOfferProductSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x0600BDAF RID: 48559 RVA: 0x0030A08C File Offset: 0x0030828C
		// (set) Token: 0x0600BDB0 RID: 48560 RVA: 0x00058738 File Offset: 0x00056938
		public unsafe static int ENTRIES_PER_PAGE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.NativeFieldInfoPtr_ENTRIES_PER_PAGE, (void*)(&value));
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x0600BDB1 RID: 48561 RVA: 0x0030A0A8 File Offset: 0x003082A8
		// (set) Token: 0x0600BDB2 RID: 48562 RVA: 0x00058746 File Offset: 0x00056946
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x0600BDB3 RID: 48563 RVA: 0x0030A0D8 File Offset: 0x003082D8
		// (set) Token: 0x0600BDB4 RID: 48564 RVA: 0x00058765 File Offset: 0x00056965
		public unsafe InputField SearchBar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_SearchBar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x0600BDB5 RID: 48565 RVA: 0x0030A108 File Offset: 0x00308308
		// (set) Token: 0x0600BDB6 RID: 48566 RVA: 0x00058784 File Offset: 0x00056984
		public unsafe RectTransform ProductContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x0600BDB7 RID: 48567 RVA: 0x0030A138 File Offset: 0x00308338
		// (set) Token: 0x0600BDB8 RID: 48568 RVA: 0x000587A3 File Offset: 0x000569A3
		public unsafe Text PageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_PageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x0600BDB9 RID: 48569 RVA: 0x0030A168 File Offset: 0x00308368
		// (set) Token: 0x0600BDBA RID: 48570 RVA: 0x000587C2 File Offset: 0x000569C2
		public unsafe GameObject ProductEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_ProductEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x0600BDBB RID: 48571 RVA: 0x0030A198 File Offset: 0x00308398
		// (set) Token: 0x0600BDBC RID: 48572 RVA: 0x000587E1 File Offset: 0x000569E1
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x0600BDBD RID: 48573 RVA: 0x0030A1C0 File Offset: 0x003083C0
		// (set) Token: 0x0600BDBE RID: 48574 RVA: 0x000587FC File Offset: 0x000569FC
		public unsafe Action<ProductDefinition> onProductPreviewed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductPreviewed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x0600BDBF RID: 48575 RVA: 0x0030A1F0 File Offset: 0x003083F0
		// (set) Token: 0x0600BDC0 RID: 48576 RVA: 0x0005881B File Offset: 0x00056A1B
		public unsafe Action<ProductDefinition> onProductSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_onProductSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x0600BDC1 RID: 48577 RVA: 0x0030A220 File Offset: 0x00308420
		// (set) Token: 0x0600BDC2 RID: 48578 RVA: 0x0005883A File Offset: 0x00056A3A
		public unsafe UIScreen uiSelectionScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiSelectionScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiSelectionScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x0600BDC3 RID: 48579 RVA: 0x0030A250 File Offset: 0x00308450
		// (set) Token: 0x0600BDC4 RID: 48580 RVA: 0x00058859 File Offset: 0x00056A59
		public unsafe UIPanel uiSearchPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiSearchPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiSearchPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x0600BDC5 RID: 48581 RVA: 0x0030A280 File Offset: 0x00308480
		// (set) Token: 0x0600BDC6 RID: 48582 RVA: 0x00058878 File Offset: 0x00056A78
		public unsafe UIPanel uiWindowPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiWindowPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_uiWindowPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x0600BDC7 RID: 48583 RVA: 0x0030A2B0 File Offset: 0x003084B0
		// (set) Token: 0x0600BDC8 RID: 48584 RVA: 0x00058897 File Offset: 0x00056A97
		public unsafe List<RectTransform> productEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x0600BDC9 RID: 48585 RVA: 0x0030A2E0 File Offset: 0x003084E0
		// (set) Token: 0x0600BDCA RID: 48586 RVA: 0x000588B6 File Offset: 0x00056AB6
		public unsafe Dictionary<ProductDefinition, RectTransform> productEntriesDict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ProductDefinition, RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_productEntriesDict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x0600BDCB RID: 48587 RVA: 0x0030A310 File Offset: 0x00308510
		// (set) Token: 0x0600BDCC RID: 48588 RVA: 0x000588D5 File Offset: 0x00056AD5
		public unsafe string searchTerm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_searchTerm), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x0600BDCD RID: 48589 RVA: 0x0030A338 File Offset: 0x00308538
		// (set) Token: 0x0600BDCE RID: 48590 RVA: 0x000588F4 File Offset: 0x00056AF4
		public unsafe int pageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageIndex)) = value;
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x0600BDCF RID: 48591 RVA: 0x0030A360 File Offset: 0x00308560
		// (set) Token: 0x0600BDD0 RID: 48592 RVA: 0x0005890F File Offset: 0x00056B0F
		public unsafe int pageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_pageCount)) = value;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x0600BDD1 RID: 48593 RVA: 0x0030A388 File Offset: 0x00308588
		// (set) Token: 0x0600BDD2 RID: 48594 RVA: 0x0005892A File Offset: 0x00056B2A
		public unsafe List<ProductDefinition> results
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_results), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x0600BDD3 RID: 48595 RVA: 0x0030A3B8 File Offset: 0x003085B8
		// (set) Token: 0x0600BDD4 RID: 48596 RVA: 0x00058949 File Offset: 0x00056B49
		public unsafe ProductDefinition lastPreviewedResult
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.NativeFieldInfoPtr_lastPreviewedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040081DB RID: 33243
		private static readonly IntPtr NativeFieldInfoPtr_ENTRIES_PER_PAGE;

		// Token: 0x040081DC RID: 33244
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040081DD RID: 33245
		private static readonly IntPtr NativeFieldInfoPtr_SearchBar;

		// Token: 0x040081DE RID: 33246
		private static readonly IntPtr NativeFieldInfoPtr_ProductContainer;

		// Token: 0x040081DF RID: 33247
		private static readonly IntPtr NativeFieldInfoPtr_PageLabel;

		// Token: 0x040081E0 RID: 33248
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntryPrefab;

		// Token: 0x040081E1 RID: 33249
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040081E2 RID: 33250
		private static readonly IntPtr NativeFieldInfoPtr_onProductPreviewed;

		// Token: 0x040081E3 RID: 33251
		private static readonly IntPtr NativeFieldInfoPtr_onProductSelected;

		// Token: 0x040081E4 RID: 33252
		private static readonly IntPtr NativeFieldInfoPtr_uiSelectionScreen;

		// Token: 0x040081E5 RID: 33253
		private static readonly IntPtr NativeFieldInfoPtr_uiSearchPanel;

		// Token: 0x040081E6 RID: 33254
		private static readonly IntPtr NativeFieldInfoPtr_uiWindowPanel;

		// Token: 0x040081E7 RID: 33255
		private static readonly IntPtr NativeFieldInfoPtr_productEntries;

		// Token: 0x040081E8 RID: 33256
		private static readonly IntPtr NativeFieldInfoPtr_productEntriesDict;

		// Token: 0x040081E9 RID: 33257
		private static readonly IntPtr NativeFieldInfoPtr_searchTerm;

		// Token: 0x040081EA RID: 33258
		private static readonly IntPtr NativeFieldInfoPtr_pageIndex;

		// Token: 0x040081EB RID: 33259
		private static readonly IntPtr NativeFieldInfoPtr_pageCount;

		// Token: 0x040081EC RID: 33260
		private static readonly IntPtr NativeFieldInfoPtr_results;

		// Token: 0x040081ED RID: 33261
		private static readonly IntPtr NativeFieldInfoPtr_lastPreviewedResult;

		// Token: 0x040081EE RID: 33262
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040081EF RID: 33263
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x040081F0 RID: 33264
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040081F1 RID: 33265
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x040081F2 RID: 33266
		private static readonly IntPtr NativeMethodInfoPtr_DelaySelectSearchPanel_Private_IEnumerator_0;

		// Token: 0x040081F3 RID: 33267
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x040081F4 RID: 33268
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040081F5 RID: 33269
		private static readonly IntPtr NativeMethodInfoPtr_SetSearchTerm_Public_Void_String_0;

		// Token: 0x040081F6 RID: 33270
		private static readonly IntPtr NativeMethodInfoPtr_RebuildResultsList_Private_Void_0;

		// Token: 0x040081F7 RID: 33271
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchingProducts_Private_List_1_ProductDefinition_String_0;

		// Token: 0x040081F8 RID: 33272
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAllEntriesExist_Private_Void_0;

		// Token: 0x040081F9 RID: 33273
		private static readonly IntPtr NativeMethodInfoPtr_CreateProductEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040081FA RID: 33274
		private static readonly IntPtr NativeMethodInfoPtr_ChangePage_Public_Void_Int32_0;

		// Token: 0x040081FB RID: 33275
		private static readonly IntPtr NativeMethodInfoPtr_SetPage_Private_Void_Int32_0;

		// Token: 0x040081FC RID: 33276
		private static readonly IntPtr NativeMethodInfoPtr_ProductHovered_Private_Void_ProductDefinition_0;

		// Token: 0x040081FD RID: 33277
		private static readonly IntPtr NativeMethodInfoPtr_ProductSelected_Private_Void_ProductDefinition_0;

		// Token: 0x040081FE RID: 33278
		private static readonly IntPtr NativeMethodInfoPtr_IsMouseOverSelector_Public_Boolean_0;

		// Token: 0x040081FF RID: 33279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D1A RID: 3354
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F82B RID: 63531 RVA: 0x003B7118 File Offset: 0x003B5318
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr);
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9");
				CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, "<>9__28_0");
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100688036);
				CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__28_0_Internal_Int32_ProductDefinition_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr, 100688037);
			}

			// Token: 0x0600F82C RID: 63532 RVA: 0x003B7194 File Offset: 0x003B5394
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F82D RID: 63533 RVA: 0x003B71D0 File Offset: 0x003B53D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315691, XrefRangeEnd = 315699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RebuildResultsList_b__28_0(ProductDefinition a, ProductDefinition b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c.NativeMethodInfoPtr__RebuildResultsList_b__28_0_Internal_Int32_ProductDefinition_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F82E RID: 63534 RVA: 0x00075579 File Offset: 0x00073779
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B70 RID: 19312
			// (get) Token: 0x0600F82F RID: 63535 RVA: 0x003B7230 File Offset: 0x003B5430
			// (set) Token: 0x0600F830 RID: 63536 RVA: 0x00075582 File Offset: 0x00073782
			public unsafe static CounterOfferProductSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B71 RID: 19313
			// (get) Token: 0x0600F831 RID: 63537 RVA: 0x003B7258 File Offset: 0x003B5458
			// (set) Token: 0x0600F832 RID: 63538 RVA: 0x00075594 File Offset: 0x00073794
			public unsafe static Comparison<ProductDefinition> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CounterOfferProductSelector.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7C2 RID: 42946
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A7C3 RID: 42947
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x0400A7C4 RID: 42948
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7C5 RID: 42949
			private static readonly IntPtr NativeMethodInfoPtr__RebuildResultsList_b__28_0_Internal_Int32_ProductDefinition_ProductDefinition_0;
		}

		// Token: 0x02000D1B RID: 3355
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F833 RID: 63539 RVA: 0x003B7280 File Offset: 0x003B5480
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr);
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, "product");
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, 100688038);
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, 100688039);
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, 100688040);
				CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__2_Internal_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr, 100688041);
			}

			// Token: 0x0600F834 RID: 63540 RVA: 0x003B7324 File Offset: 0x003B5524
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F835 RID: 63541 RVA: 0x003B7360 File Offset: 0x003B5560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315699, XrefRangeEnd = 315701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F836 RID: 63542 RVA: 0x003B7394 File Offset: 0x003B5594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315701, XrefRangeEnd = 315703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__1(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F837 RID: 63543 RVA: 0x003B73D8 File Offset: 0x003B55D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateProductEntry_b__2(BaseEventData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector.__c__DisplayClass31_0.NativeMethodInfoPtr__CreateProductEntry_b__2_Internal_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F838 RID: 63544 RVA: 0x000755A6 File Offset: 0x000737A6
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B72 RID: 19314
			// (get) Token: 0x0600F839 RID: 63545 RVA: 0x003B741C File Offset: 0x003B561C
			// (set) Token: 0x0600F83A RID: 63546 RVA: 0x000755AF File Offset: 0x000737AF
			public unsafe CounterOfferProductSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B73 RID: 19315
			// (get) Token: 0x0600F83B RID: 63547 RVA: 0x003B744C File Offset: 0x003B564C
			// (set) Token: 0x0600F83C RID: 63548 RVA: 0x000755CE File Offset: 0x000737CE
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector.__c__DisplayClass31_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7C6 RID: 42950
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7C7 RID: 42951
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x0400A7C8 RID: 42952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A7C9 RID: 42953
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__0_Internal_Void_0;

			// Token: 0x0400A7CA RID: 42954
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__1_Internal_Void_BaseEventData_0;

			// Token: 0x0400A7CB RID: 42955
			private static readonly IntPtr NativeMethodInfoPtr__CreateProductEntry_b__2_Internal_Void_BaseEventData_0;
		}

		// Token: 0x02000D1C RID: 3356
		[ObfuscatedName("ScheduleOne.UI.Phone.CounterOfferProductSelector+<DelaySelectSearchPanel>d__24")]
		public sealed class _DelaySelectSearchPanel_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600F83D RID: 63549 RVA: 0x003B747C File Offset: 0x003B567C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelaySelectSearchPanel_d__24()
			{
				Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CounterOfferProductSelector>.NativeClassPtr, "<DelaySelectSearchPanel>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, "<>1__state");
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, "<>2__current");
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, "<>4__this");
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688042);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688043);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688044);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688045);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688046);
				CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr, 100688047);
			}

			// Token: 0x0600F83E RID: 63550 RVA: 0x003B755C File Offset: 0x003B575C
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelaySelectSearchPanel_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterOfferProductSelector._DelaySelectSearchPanel_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F83F RID: 63551 RVA: 0x003B75A4 File Offset: 0x003B57A4
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F840 RID: 63552 RVA: 0x003B75D8 File Offset: 0x003B57D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315703, XrefRangeEnd = 315704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004B77 RID: 19319
			// (get) Token: 0x0600F841 RID: 63553 RVA: 0x003B7614 File Offset: 0x003B5814
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F842 RID: 63554 RVA: 0x003B7654 File Offset: 0x003B5854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315704, XrefRangeEnd = 315709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B78 RID: 19320
			// (get) Token: 0x0600F843 RID: 63555 RVA: 0x003B7688 File Offset: 0x003B5888
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F844 RID: 63556 RVA: 0x000755ED File Offset: 0x000737ED
			public _DelaySelectSearchPanel_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B74 RID: 19316
			// (get) Token: 0x0600F845 RID: 63557 RVA: 0x003B76C8 File Offset: 0x003B58C8
			// (set) Token: 0x0600F846 RID: 63558 RVA: 0x000755F6 File Offset: 0x000737F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B75 RID: 19317
			// (get) Token: 0x0600F847 RID: 63559 RVA: 0x003B76F0 File Offset: 0x003B58F0
			// (set) Token: 0x0600F848 RID: 63560 RVA: 0x00075611 File Offset: 0x00073811
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B76 RID: 19318
			// (get) Token: 0x0600F849 RID: 63561 RVA: 0x003B7720 File Offset: 0x003B5920
			// (set) Token: 0x0600F84A RID: 63562 RVA: 0x00075630 File Offset: 0x00073830
			public unsafe CounterOfferProductSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CounterOfferProductSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CounterOfferProductSelector._DelaySelectSearchPanel_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A7CC RID: 42956
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A7CD RID: 42957
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A7CE RID: 42958
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A7CF RID: 42959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A7D0 RID: 42960
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7D1 RID: 42961
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A7D2 RID: 42962
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A7D3 RID: 42963
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A7D4 RID: 42964
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
