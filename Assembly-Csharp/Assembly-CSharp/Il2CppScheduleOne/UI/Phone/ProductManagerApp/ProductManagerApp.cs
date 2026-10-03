using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020007AE RID: 1966
	public class ProductManagerApp : App<ProductManagerApp>
	{
		// Token: 0x0600BF2F RID: 48943 RVA: 0x0030E738 File Offset: 0x0030C938
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerApp()
		{
			Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductManagerApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr);
			ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "FavouritesContainer");
			ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "ProductTypeContainers");
			ProductManagerApp.NativeFieldInfoPtr_DetailPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "DetailPanel");
			ProductManagerApp.NativeFieldInfoPtr_EntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "EntryPrefab");
			ProductManagerApp.NativeFieldInfoPtr_favouriteEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "favouriteEntries");
			ProductManagerApp.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "entries");
			ProductManagerApp.NativeFieldInfoPtr_selectedEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "selectedEntry");
			ProductManagerApp.NativeFieldInfoPtr__favouritesPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "_favouritesPanel");
			ProductManagerApp.NativeFieldInfoPtr__detailsPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "_detailsPanel");
			ProductManagerApp.NativeFieldInfoPtr__returnToPreviousPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "_returnToPreviousPanel");
			ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688224);
			ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688225);
			ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688226);
			ProductManagerApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688227);
			ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688228);
			ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688229);
			ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688230);
			ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688231);
			ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688232);
			ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688233);
			ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688234);
			ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688235);
			ProductManagerApp.NativeMethodInfoPtr_OnProductListedEvent_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688236);
			ProductManagerApp.NativeMethodInfoPtr_OnPanelChange_Private_Void_UIPanel_UIPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688237);
			ProductManagerApp.NativeMethodInfoPtr_MoveToDetailsPanel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688238);
			ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688239);
			ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, 100688240);
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x0030E984 File Offset: 0x0030CB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317802, XrefRangeEnd = 317807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x0030E9C0 File Offset: 0x0030CBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317807, XrefRangeEnd = 317894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x0030E9FC File Offset: 0x0030CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317894, XrefRangeEnd = 317895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x0030EA30 File Offset: 0x0030CC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317895, XrefRangeEnd = 317901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x0030EA80 File Offset: 0x0030CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317901, XrefRangeEnd = 317954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CreateEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x0030EAD0 File Offset: 0x0030CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317954, XrefRangeEnd = 317955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x0030EB14 File Offset: 0x0030CD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317955, XrefRangeEnd = 317956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductUnfavourited(ProductDefinition product)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x0030EB58 File Offset: 0x0030CD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 318001, RefRangeEnd = 318003, XrefRangeStart = 317956, XrefRangeEnd = 318001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x0030EB9C File Offset: 0x0030CD9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318055, RefRangeEnd = 318056, XrefRangeStart = 318003, XrefRangeEnd = 318055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveFavouriteEntry(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x0030EBE0 File Offset: 0x0030CDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318056, XrefRangeEnd = 318062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedRebuildLayout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3A RID: 48954 RVA: 0x0030EC14 File Offset: 0x0030CE14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318071, RefRangeEnd = 318072, XrefRangeStart = 318062, XrefRangeEnd = 318071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProduct(ProductEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x0030EC58 File Offset: 0x0030CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318072, XrefRangeEnd = 318096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerApp.NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x0030ECA4 File Offset: 0x0030CEA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318096, XrefRangeEnd = 318118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnProductListedEvent(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_OnProductListedEvent_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x0030ECE8 File Offset: 0x0030CEE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318118, XrefRangeEnd = 318122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelChange(UIPanel previous, UIPanel current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_OnPanelChange_Private_Void_UIPanel_UIPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x0030ED3C File Offset: 0x0030CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318122, XrefRangeEnd = 318123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToDetailsPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_MoveToDetailsPanel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x0030ED70 File Offset: 0x0030CF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318123, XrefRangeEnd = 318141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x0030EDAC File Offset: 0x0030CFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318141, XrefRangeEnd = 318146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x00059615 File Offset: 0x00057815
		public ProductManagerApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x0030EDEC File Offset: 0x0030CFEC
		// (set) Token: 0x0600BF43 RID: 48963 RVA: 0x0005961E File Offset: 0x0005781E
		public unsafe ProductTypeContainer FavouritesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductTypeContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_FavouritesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x0030EE1C File Offset: 0x0030D01C
		// (set) Token: 0x0600BF45 RID: 48965 RVA: 0x0005963D File Offset: 0x0005783D
		public unsafe List<ProductTypeContainer> ProductTypeContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductTypeContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_ProductTypeContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039CE RID: 14798
		// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x0030EE4C File Offset: 0x0030D04C
		// (set) Token: 0x0600BF47 RID: 48967 RVA: 0x0005965C File Offset: 0x0005785C
		public unsafe ProductAppDetailPanel DetailPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductAppDetailPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_DetailPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600BF48 RID: 48968 RVA: 0x0030EE7C File Offset: 0x0030D07C
		// (set) Token: 0x0600BF49 RID: 48969 RVA: 0x0005967B File Offset: 0x0005787B
		public unsafe GameObject EntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_EntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D0 RID: 14800
		// (get) Token: 0x0600BF4A RID: 48970 RVA: 0x0030EEAC File Offset: 0x0030D0AC
		// (set) Token: 0x0600BF4B RID: 48971 RVA: 0x0005969A File Offset: 0x0005789A
		public unsafe List<ProductEntry> favouriteEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_favouriteEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x0030EEDC File Offset: 0x0030D0DC
		// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x000596B9 File Offset: 0x000578B9
		public unsafe List<ProductEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600BF4E RID: 48974 RVA: 0x0030EF0C File Offset: 0x0030D10C
		// (set) Token: 0x0600BF4F RID: 48975 RVA: 0x000596D8 File Offset: 0x000578D8
		public unsafe ProductEntry selectedEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr_selectedEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x0600BF50 RID: 48976 RVA: 0x0030EF3C File Offset: 0x0030D13C
		// (set) Token: 0x0600BF51 RID: 48977 RVA: 0x000596F7 File Offset: 0x000578F7
		public unsafe UIPanel _favouritesPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__favouritesPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__favouritesPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x0030EF6C File Offset: 0x0030D16C
		// (set) Token: 0x0600BF53 RID: 48979 RVA: 0x00059716 File Offset: 0x00057916
		public unsafe UIPanel _detailsPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__detailsPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__detailsPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x0030EF9C File Offset: 0x0030D19C
		// (set) Token: 0x0600BF55 RID: 48981 RVA: 0x00059735 File Offset: 0x00057935
		public unsafe bool _returnToPreviousPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__returnToPreviousPanel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.NativeFieldInfoPtr__returnToPreviousPanel)) = value;
			}
		}

		// Token: 0x040082E0 RID: 33504
		private static readonly IntPtr NativeFieldInfoPtr_FavouritesContainer;

		// Token: 0x040082E1 RID: 33505
		private static readonly IntPtr NativeFieldInfoPtr_ProductTypeContainers;

		// Token: 0x040082E2 RID: 33506
		private static readonly IntPtr NativeFieldInfoPtr_DetailPanel;

		// Token: 0x040082E3 RID: 33507
		private static readonly IntPtr NativeFieldInfoPtr_EntryPrefab;

		// Token: 0x040082E4 RID: 33508
		private static readonly IntPtr NativeFieldInfoPtr_favouriteEntries;

		// Token: 0x040082E5 RID: 33509
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x040082E6 RID: 33510
		private static readonly IntPtr NativeFieldInfoPtr_selectedEntry;

		// Token: 0x040082E7 RID: 33511
		private static readonly IntPtr NativeFieldInfoPtr__favouritesPanel;

		// Token: 0x040082E8 RID: 33512
		private static readonly IntPtr NativeFieldInfoPtr__detailsPanel;

		// Token: 0x040082E9 RID: 33513
		private static readonly IntPtr NativeFieldInfoPtr__returnToPreviousPanel;

		// Token: 0x040082EA RID: 33514
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040082EB RID: 33515
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040082EC RID: 33516
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040082ED RID: 33517
		private static readonly IntPtr NativeMethodInfoPtr_OnExit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x040082EE RID: 33518
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Public_Virtual_New_Void_ProductDefinition_0;

		// Token: 0x040082EF RID: 33519
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040082F0 RID: 33520
		private static readonly IntPtr NativeMethodInfoPtr_ProductUnfavourited_Private_Void_ProductDefinition_0;

		// Token: 0x040082F1 RID: 33521
		private static readonly IntPtr NativeMethodInfoPtr_CreateFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040082F2 RID: 33522
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFavouriteEntry_Private_Void_ProductDefinition_0;

		// Token: 0x040082F3 RID: 33523
		private static readonly IntPtr NativeMethodInfoPtr_DelayedRebuildLayout_Private_Void_0;

		// Token: 0x040082F4 RID: 33524
		private static readonly IntPtr NativeMethodInfoPtr_SelectProduct_Public_Void_ProductEntry_0;

		// Token: 0x040082F5 RID: 33525
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040082F6 RID: 33526
		private static readonly IntPtr NativeMethodInfoPtr_OnProductListedEvent_Private_Void_ProductDefinition_0;

		// Token: 0x040082F7 RID: 33527
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelChange_Private_Void_UIPanel_UIPanel_0;

		// Token: 0x040082F8 RID: 33528
		private static readonly IntPtr NativeMethodInfoPtr_MoveToDetailsPanel_Public_Void_0;

		// Token: 0x040082F9 RID: 33529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040082FA RID: 33530
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000D2A RID: 3370
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<<DelayedRebuildLayout>g__Delay|19_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600F8EC RID: 63724 RVA: 0x003B93F8 File Offset: 0x003B75F8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<<DelayedRebuildLayout>g__Delay|19_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688241);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688242);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688243);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688244);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688245);
				ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100688246);
			}

			// Token: 0x0600F8ED RID: 63725 RVA: 0x003B94D8 File Offset: 0x003B76D8
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8EE RID: 63726 RVA: 0x003B9520 File Offset: 0x003B7720
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8EF RID: 63727 RVA: 0x003B9554 File Offset: 0x003B7754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317771, XrefRangeEnd = 317784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004BB5 RID: 19381
			// (get) Token: 0x0600F8F0 RID: 63728 RVA: 0x003B9590 File Offset: 0x003B7790
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8F1 RID: 63729 RVA: 0x003B95D0 File Offset: 0x003B77D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317784, XrefRangeEnd = 317789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004BB6 RID: 19382
			// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x003B9604 File Offset: 0x003B7804
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F8F3 RID: 63731 RVA: 0x00075BAF File Offset: 0x00073DAF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BB2 RID: 19378
			// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x003B9644 File Offset: 0x003B7844
			// (set) Token: 0x0600F8F5 RID: 63733 RVA: 0x00075BB8 File Offset: 0x00073DB8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004BB3 RID: 19379
			// (get) Token: 0x0600F8F6 RID: 63734 RVA: 0x003B966C File Offset: 0x003B786C
			// (set) Token: 0x0600F8F7 RID: 63735 RVA: 0x00075BD3 File Offset: 0x00073DD3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BB4 RID: 19380
			// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x003B969C File Offset: 0x003B789C
			// (set) Token: 0x0600F8F9 RID: 63737 RVA: 0x00075BF2 File Offset: 0x00073DF2
			public unsafe ProductManagerApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductManagerApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A832 RID: 43058
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A833 RID: 43059
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A834 RID: 43060
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A835 RID: 43061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A836 RID: 43062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A837 RID: 43063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A838 RID: 43064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A839 RID: 43065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A83A RID: 43066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000D2B RID: 3371
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F8FA RID: 63738 RVA: 0x003B96CC File Offset: 0x003B78CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass14_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr, 100688247);
				ProductManagerApp.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr, 100688248);
			}

			// Token: 0x0600F8FB RID: 63739 RVA: 0x003B9734 File Offset: 0x003B7934
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F8FC RID: 63740 RVA: 0x003B9770 File Offset: 0x003B7970
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317789, XrefRangeEnd = 317792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateEntry_b__0(ProductTypeContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass14_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F8FD RID: 63741 RVA: 0x00075C11 File Offset: 0x00073E11
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BB7 RID: 19383
			// (get) Token: 0x0600F8FE RID: 63742 RVA: 0x003B97C0 File Offset: 0x003B79C0
			// (set) Token: 0x0600F8FF RID: 63743 RVA: 0x00075C1A File Offset: 0x00073E1A
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass14_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass14_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A83B RID: 43067
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x0400A83C RID: 43068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A83D RID: 43069
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Boolean_ProductTypeContainer_0;
		}

		// Token: 0x02000D2C RID: 3372
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F900 RID: 63744 RVA: 0x003B97F0 File Offset: 0x003B79F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass17_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr, 100688249);
				ProductManagerApp.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr, 100688250);
			}

			// Token: 0x0600F901 RID: 63745 RVA: 0x003B9858 File Offset: 0x003B7A58
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F902 RID: 63746 RVA: 0x003B9894 File Offset: 0x003B7A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317792, XrefRangeEnd = 317797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass17_0.NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F903 RID: 63747 RVA: 0x00075C39 File Offset: 0x00073E39
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BB8 RID: 19384
			// (get) Token: 0x0600F904 RID: 63748 RVA: 0x003B98E4 File Offset: 0x003B7AE4
			// (set) Token: 0x0600F905 RID: 63749 RVA: 0x00075C42 File Offset: 0x00073E42
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass17_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass17_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A83E RID: 43070
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x0400A83F RID: 43071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A840 RID: 43072
			private static readonly IntPtr NativeMethodInfoPtr__CreateFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}

		// Token: 0x02000D2D RID: 3373
		[ObfuscatedName("ScheduleOne.UI.Phone.ProductManagerApp.ProductManagerApp+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F906 RID: 63750 RVA: 0x003B9914 File Offset: 0x003B7B14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductManagerApp>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr);
				ProductManagerApp.__c__DisplayClass18_0.NativeFieldInfoPtr_definition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr, "definition");
				ProductManagerApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr, 100688251);
				ProductManagerApp.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr, 100688252);
			}

			// Token: 0x0600F907 RID: 63751 RVA: 0x003B997C File Offset: 0x003B7B7C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerApp.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F908 RID: 63752 RVA: 0x003B99B8 File Offset: 0x003B7BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317797, XrefRangeEnd = 317802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveFavouriteEntry_b__0(ProductEntry x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerApp.__c__DisplayClass18_0.NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F909 RID: 63753 RVA: 0x00075C61 File Offset: 0x00073E61
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BB9 RID: 19385
			// (get) Token: 0x0600F90A RID: 63754 RVA: 0x003B9A08 File Offset: 0x003B7C08
			// (set) Token: 0x0600F90B RID: 63755 RVA: 0x00075C6A File Offset: 0x00073E6A
			public unsafe ProductDefinition definition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass18_0.NativeFieldInfoPtr_definition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerApp.__c__DisplayClass18_0.NativeFieldInfoPtr_definition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A841 RID: 43073
			private static readonly IntPtr NativeFieldInfoPtr_definition;

			// Token: 0x0400A842 RID: 43074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A843 RID: 43075
			private static readonly IntPtr NativeMethodInfoPtr__RemoveFavouriteEntry_b__0_Internal_Boolean_ProductEntry_0;
		}
	}
}
