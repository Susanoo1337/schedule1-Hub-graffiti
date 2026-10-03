using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000264 RID: 612
	[Serializable]
	public class ProductManagerData : SaveData
	{
		// Token: 0x060030A6 RID: 12454 RVA: 0x0011C608 File Offset: 0x0011A808
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerData()
		{
			Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductManagerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr);
			ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "DiscoveredProducts");
			ProductManagerData.NativeFieldInfoPtr_ListedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ListedProducts");
			ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ActiveMixOperation");
			ProductManagerData.NativeFieldInfoPtr_IsMixComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "IsMixComplete");
			ProductManagerData.NativeFieldInfoPtr_MixRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "MixRecipes");
			ProductManagerData.NativeFieldInfoPtr_ProductPrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ProductPrices");
			ProductManagerData.NativeFieldInfoPtr_FavouritedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "FavouritedProducts");
			ProductManagerData.NativeFieldInfoPtr_CreatedWeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedWeed");
			ProductManagerData.NativeFieldInfoPtr_CreatedMeth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedMeth");
			ProductManagerData.NativeFieldInfoPtr_CreatedCocaine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedCocaine");
			ProductManagerData.NativeFieldInfoPtr_CreatedShrooms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "CreatedShrooms");
			ProductManagerData.NativeFieldInfoPtr_ContractReceipts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, "ContractReceipts");
			ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_Il2CppReferenceArray_1_ShroomProductData_Il2CppReferenceArray_1_ContractReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr, 100669452);
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x0011C73C File Offset: 0x0011A93C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135254, RefRangeEnd = 135255, XrefRangeStart = 135242, XrefRangeEnd = 135254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerData(Il2CppStringArray discoveredProducts, Il2CppStringArray listedProducts, NewMixOperation activeOperation, bool isMixComplete, Il2CppReferenceArray<MixRecipeData> mixRecipes, Il2CppReferenceArray<StringIntPair> productPrices, Il2CppStringArray favouritedProducts, Il2CppReferenceArray<WeedProductData> createdWeed, Il2CppReferenceArray<MethProductData> createdMeth, Il2CppReferenceArray<CocaineProductData> createdCocaine, Il2CppReferenceArray<ShroomProductData> createdShrooms, Il2CppReferenceArray<ContractReceipt> receipts) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(discoveredProducts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listedProducts);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeOperation);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isMixComplete;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixRecipes);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productPrices);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(favouritedProducts);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdWeed);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdMeth);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdCocaine);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createdShrooms);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(receipts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_Il2CppReferenceArray_1_ShroomProductData_Il2CppReferenceArray_1_ContractReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x00018F88 File Offset: 0x00017188
		public ProductManagerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F82 RID: 3970
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x0011C858 File Offset: 0x0011AA58
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x00018F91 File Offset: 0x00017191
		public unsafe Il2CppStringArray DiscoveredProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_DiscoveredProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x0011C888 File Offset: 0x0011AA88
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00018FB0 File Offset: 0x000171B0
		public unsafe Il2CppStringArray ListedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ListedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0011C8B8 File Offset: 0x0011AAB8
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00018FCF File Offset: 0x000171CF
		public unsafe NewMixOperation ActiveMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ActiveMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x0011C8E8 File Offset: 0x0011AAE8
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00018FEE File Offset: 0x000171EE
		public unsafe bool IsMixComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_IsMixComplete)) = value;
			}
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0011C910 File Offset: 0x0011AB10
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00019009 File Offset: 0x00017209
		public unsafe Il2CppReferenceArray<MixRecipeData> MixRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MixRecipeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_MixRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x060030B3 RID: 12467 RVA: 0x0011C940 File Offset: 0x0011AB40
		// (set) Token: 0x060030B4 RID: 12468 RVA: 0x00019028 File Offset: 0x00017228
		public unsafe Il2CppReferenceArray<StringIntPair> ProductPrices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ProductPrices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x0011C970 File Offset: 0x0011AB70
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x00019047 File Offset: 0x00017247
		public unsafe Il2CppStringArray FavouritedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_FavouritedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x060030B7 RID: 12471 RVA: 0x0011C9A0 File Offset: 0x0011ABA0
		// (set) Token: 0x060030B8 RID: 12472 RVA: 0x00019066 File Offset: 0x00017266
		public unsafe Il2CppReferenceArray<WeedProductData> CreatedWeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WeedProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedWeed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x0011C9D0 File Offset: 0x0011ABD0
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x00019085 File Offset: 0x00017285
		public unsafe Il2CppReferenceArray<MethProductData> CreatedMeth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MethProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedMeth), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x0011CA00 File Offset: 0x0011AC00
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x000190A4 File Offset: 0x000172A4
		public unsafe Il2CppReferenceArray<CocaineProductData> CreatedCocaine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CocaineProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedCocaine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8C RID: 3980
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x0011CA30 File Offset: 0x0011AC30
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x000190C3 File Offset: 0x000172C3
		public unsafe Il2CppReferenceArray<ShroomProductData> CreatedShrooms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedShrooms);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ShroomProductData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_CreatedShrooms), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x0011CA60 File Offset: 0x0011AC60
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x000190E2 File Offset: 0x000172E2
		public unsafe Il2CppReferenceArray<ContractReceipt> ContractReceipts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ContractReceipts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ContractReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductManagerData.NativeFieldInfoPtr_ContractReceipts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400209F RID: 8351
		private static readonly IntPtr NativeFieldInfoPtr_DiscoveredProducts;

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeFieldInfoPtr_ListedProducts;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeFieldInfoPtr_ActiveMixOperation;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeFieldInfoPtr_IsMixComplete;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeFieldInfoPtr_MixRecipes;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_ProductPrices;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedProducts;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeFieldInfoPtr_CreatedWeed;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeFieldInfoPtr_CreatedMeth;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeFieldInfoPtr_CreatedCocaine;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeFieldInfoPtr_CreatedShrooms;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeFieldInfoPtr_ContractReceipts;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStringArray_NewMixOperation_Boolean_Il2CppReferenceArray_1_MixRecipeData_Il2CppReferenceArray_1_StringIntPair_Il2CppStringArray_Il2CppReferenceArray_1_WeedProductData_Il2CppReferenceArray_1_MethProductData_Il2CppReferenceArray_1_CocaineProductData_Il2CppReferenceArray_1_ShroomProductData_Il2CppReferenceArray_1_ContractReceipt_0;
	}
}
