using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.GamepadInput;
using Il2CppScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020007AD RID: 1965
	public class ProductAppDetailPanel : MonoBehaviour
	{
		// Token: 0x0600BEF5 RID: 48885 RVA: 0x0030DC6C File Offset: 0x0030BE6C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductAppDetailPanel()
		{
			Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductAppDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr);
			ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "<ActiveProduct>k__BackingField");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Min");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionColor_Max");
			ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NothingSelected");
			ProductAppDetailPanel.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "Container");
			ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "NameLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ValueLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "SuggestedPriceLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "ListedForSale");
			ProductAppDetailPanel.NativeFieldInfoPtr_FavouriteProduct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "FavouriteProduct");
			ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "DescLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "PropertyLabels");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipesLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "RecipeEntries");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionSlider");
			ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "AddictionLabel");
			ProductAppDetailPanel.NativeFieldInfoPtr__addButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "_addButton");
			ProductAppDetailPanel.NativeFieldInfoPtr__removeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "_removeButton");
			ProductAppDetailPanel.NativeFieldInfoPtr__inputValueRamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, "_inputValueRamp");
			ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688206);
			ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688207);
			ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688208);
			ProductAppDetailPanel.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688209);
			ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688210);
			ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688211);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688212);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdateFavourite_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688213);
			ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688214);
			ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688215);
			ProductAppDetailPanel.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688216);
			ProductAppDetailPanel.NativeMethodInfoPtr_AdjustPrice_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688217);
			ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688218);
			ProductAppDetailPanel.NativeMethodInfoPtr_OnToggleFavourited_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688219);
			ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688220);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688221);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_1_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688222);
			ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_2_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr, 100688223);
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x0600BEF6 RID: 48886 RVA: 0x0030DF80 File Offset: 0x0030C180
		// (set) Token: 0x0600BEF7 RID: 48887 RVA: 0x0030DFC0 File Offset: 0x0030C1C0
		public unsafe ProductDefinition ActiveProduct
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BEF8 RID: 48888 RVA: 0x0030E004 File Offset: 0x0030C204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317447, XrefRangeEnd = 317502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEF9 RID: 48889 RVA: 0x0030E038 File Offset: 0x0030C238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317502, XrefRangeEnd = 317524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFA RID: 48890 RVA: 0x0030E06C File Offset: 0x0030C26C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317635, RefRangeEnd = 317638, XrefRangeStart = 317524, XrefRangeEnd = 317635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveProduct(ProductDefinition productDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFB RID: 48891 RVA: 0x0030E0B0 File Offset: 0x0030C2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317638, XrefRangeEnd = 317644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFC RID: 48892 RVA: 0x0030E0E4 File Offset: 0x0030C2E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 317653, RefRangeEnd = 317657, XrefRangeStart = 317644, XrefRangeEnd = 317653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdateListed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFD RID: 48893 RVA: 0x0030E118 File Offset: 0x0030C318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 317666, RefRangeEnd = 317668, XrefRangeStart = 317657, XrefRangeEnd = 317666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFavourite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdateFavourite_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFE RID: 48894 RVA: 0x0030E14C File Offset: 0x0030C34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 317675, RefRangeEnd = 317678, XrefRangeStart = 317668, XrefRangeEnd = 317675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x0030E180 File Offset: 0x0030C380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317678, XrefRangeEnd = 317703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ListingToggled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_ListingToggled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x0030E1B4 File Offset: 0x0030C3B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317703, XrefRangeEnd = 317708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInputChange(GameInput.InputDeviceType device)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref device;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x0030E1F4 File Offset: 0x0030C3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317708, XrefRangeEnd = 317728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdjustPrice(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_AdjustPrice_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x0030E234 File Offset: 0x0030C434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 317753, RefRangeEnd = 317754, XrefRangeStart = 317728, XrefRangeEnd = 317753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PriceSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x0030E278 File Offset: 0x0030C478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317754, XrefRangeEnd = 317770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleFavourited(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr_OnToggleFavourited_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF04 RID: 48900 RVA: 0x0030E2B8 File Offset: 0x0030C4B8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductAppDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductAppDetailPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x0030E2F4 File Offset: 0x0030C4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_0(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x0030E334 File Offset: 0x0030C534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_1(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_1_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x0030E374 File Offset: 0x0030C574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317770, XrefRangeEnd = 317771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__22_2(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductAppDetailPanel.NativeMethodInfoPtr__Awake_b__22_2_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x000593C7 File Offset: 0x000575C7
		public ProductAppDetailPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039B8 RID: 14776
		// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x0030E3B8 File Offset: 0x0030C5B8
		// (set) Token: 0x0600BF0A RID: 48906 RVA: 0x000593D0 File Offset: 0x000575D0
		public unsafe ProductDefinition _ActiveProduct_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__ActiveProduct_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039B9 RID: 14777
		// (get) Token: 0x0600BF0B RID: 48907 RVA: 0x0030E3E8 File Offset: 0x0030C5E8
		// (set) Token: 0x0600BF0C RID: 48908 RVA: 0x000593EF File Offset: 0x000575EF
		public unsafe Color AddictionColor_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Min)) = value;
			}
		}

		// Token: 0x170039BA RID: 14778
		// (get) Token: 0x0600BF0D RID: 48909 RVA: 0x0030E410 File Offset: 0x0030C610
		// (set) Token: 0x0600BF0E RID: 48910 RVA: 0x0005940A File Offset: 0x0005760A
		public unsafe Color AddictionColor_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionColor_Max)) = value;
			}
		}

		// Token: 0x170039BB RID: 14779
		// (get) Token: 0x0600BF0F RID: 48911 RVA: 0x0030E438 File Offset: 0x0030C638
		// (set) Token: 0x0600BF10 RID: 48912 RVA: 0x00059425 File Offset: 0x00057625
		public unsafe GameObject NothingSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NothingSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039BC RID: 14780
		// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x0030E468 File Offset: 0x0030C668
		// (set) Token: 0x0600BF12 RID: 48914 RVA: 0x00059444 File Offset: 0x00057644
		public unsafe GameObject Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039BD RID: 14781
		// (get) Token: 0x0600BF13 RID: 48915 RVA: 0x0030E498 File Offset: 0x0030C698
		// (set) Token: 0x0600BF14 RID: 48916 RVA: 0x00059463 File Offset: 0x00057663
		public unsafe Text NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039BE RID: 14782
		// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x0030E4C8 File Offset: 0x0030C6C8
		// (set) Token: 0x0600BF16 RID: 48918 RVA: 0x00059482 File Offset: 0x00057682
		public unsafe InputField ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039BF RID: 14783
		// (get) Token: 0x0600BF17 RID: 48919 RVA: 0x0030E4F8 File Offset: 0x0030C6F8
		// (set) Token: 0x0600BF18 RID: 48920 RVA: 0x000594A1 File Offset: 0x000576A1
		public unsafe Text SuggestedPriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_SuggestedPriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C0 RID: 14784
		// (get) Token: 0x0600BF19 RID: 48921 RVA: 0x0030E528 File Offset: 0x0030C728
		// (set) Token: 0x0600BF1A RID: 48922 RVA: 0x000594C0 File Offset: 0x000576C0
		public unsafe Toggle ListedForSale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_ListedForSale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C1 RID: 14785
		// (get) Token: 0x0600BF1B RID: 48923 RVA: 0x0030E558 File Offset: 0x0030C758
		// (set) Token: 0x0600BF1C RID: 48924 RVA: 0x000594DF File Offset: 0x000576DF
		public unsafe Toggle FavouriteProduct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_FavouriteProduct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_FavouriteProduct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C2 RID: 14786
		// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x0030E588 File Offset: 0x0030C788
		// (set) Token: 0x0600BF1E RID: 48926 RVA: 0x000594FE File Offset: 0x000576FE
		public unsafe Text DescLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_DescLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C3 RID: 14787
		// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x0030E5B8 File Offset: 0x0030C7B8
		// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x0005951D File Offset: 0x0005771D
		public unsafe Il2CppReferenceArray<Text> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x0030E5E8 File Offset: 0x0030C7E8
		// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x0005953C File Offset: 0x0005773C
		public unsafe RectTransform RecipesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x0030E618 File Offset: 0x0030C818
		// (set) Token: 0x0600BF24 RID: 48932 RVA: 0x0005955B File Offset: 0x0005775B
		public unsafe Il2CppReferenceArray<ProductRecipe> RecipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_RecipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600BF25 RID: 48933 RVA: 0x0030E648 File Offset: 0x0030C848
		// (set) Token: 0x0600BF26 RID: 48934 RVA: 0x0005957A File Offset: 0x0005777A
		public unsafe Scrollbar AddictionSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600BF27 RID: 48935 RVA: 0x0030E678 File Offset: 0x0030C878
		// (set) Token: 0x0600BF28 RID: 48936 RVA: 0x00059599 File Offset: 0x00057799
		public unsafe Text AddictionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr_AddictionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600BF29 RID: 48937 RVA: 0x0030E6A8 File Offset: 0x0030C8A8
		// (set) Token: 0x0600BF2A RID: 48938 RVA: 0x000595B8 File Offset: 0x000577B8
		public unsafe Transform _addButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__addButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__addButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600BF2B RID: 48939 RVA: 0x0030E6D8 File Offset: 0x0030C8D8
		// (set) Token: 0x0600BF2C RID: 48940 RVA: 0x000595D7 File Offset: 0x000577D7
		public unsafe Transform _removeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__removeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__removeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0600BF2D RID: 48941 RVA: 0x0030E708 File Offset: 0x0030C908
		// (set) Token: 0x0600BF2E RID: 48942 RVA: 0x000595F6 File Offset: 0x000577F6
		public unsafe InputValueRamp _inputValueRamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__inputValueRamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputValueRamp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductAppDetailPanel.NativeFieldInfoPtr__inputValueRamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040082BB RID: 33467
		private static readonly IntPtr NativeFieldInfoPtr__ActiveProduct_k__BackingField;

		// Token: 0x040082BC RID: 33468
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Min;

		// Token: 0x040082BD RID: 33469
		private static readonly IntPtr NativeFieldInfoPtr_AddictionColor_Max;

		// Token: 0x040082BE RID: 33470
		private static readonly IntPtr NativeFieldInfoPtr_NothingSelected;

		// Token: 0x040082BF RID: 33471
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040082C0 RID: 33472
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040082C1 RID: 33473
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x040082C2 RID: 33474
		private static readonly IntPtr NativeFieldInfoPtr_SuggestedPriceLabel;

		// Token: 0x040082C3 RID: 33475
		private static readonly IntPtr NativeFieldInfoPtr_ListedForSale;

		// Token: 0x040082C4 RID: 33476
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteProduct;

		// Token: 0x040082C5 RID: 33477
		private static readonly IntPtr NativeFieldInfoPtr_DescLabel;

		// Token: 0x040082C6 RID: 33478
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x040082C7 RID: 33479
		private static readonly IntPtr NativeFieldInfoPtr_RecipesLabel;

		// Token: 0x040082C8 RID: 33480
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntries;

		// Token: 0x040082C9 RID: 33481
		private static readonly IntPtr NativeFieldInfoPtr_AddictionSlider;

		// Token: 0x040082CA RID: 33482
		private static readonly IntPtr NativeFieldInfoPtr_AddictionLabel;

		// Token: 0x040082CB RID: 33483
		private static readonly IntPtr NativeFieldInfoPtr__addButton;

		// Token: 0x040082CC RID: 33484
		private static readonly IntPtr NativeFieldInfoPtr__removeButton;

		// Token: 0x040082CD RID: 33485
		private static readonly IntPtr NativeFieldInfoPtr__inputValueRamp;

		// Token: 0x040082CE RID: 33486
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveProduct_Public_get_ProductDefinition_0;

		// Token: 0x040082CF RID: 33487
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveProduct_Protected_set_Void_ProductDefinition_0;

		// Token: 0x040082D0 RID: 33488
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040082D1 RID: 33489
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040082D2 RID: 33490
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveProduct_Public_Void_ProductDefinition_0;

		// Token: 0x040082D3 RID: 33491
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040082D4 RID: 33492
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Public_Void_0;

		// Token: 0x040082D5 RID: 33493
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFavourite_Public_Void_0;

		// Token: 0x040082D6 RID: 33494
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x040082D7 RID: 33495
		private static readonly IntPtr NativeMethodInfoPtr_ListingToggled_Private_Void_0;

		// Token: 0x040082D8 RID: 33496
		private static readonly IntPtr NativeMethodInfoPtr_OnInputChange_Private_Void_InputDeviceType_0;

		// Token: 0x040082D9 RID: 33497
		private static readonly IntPtr NativeMethodInfoPtr_AdjustPrice_Private_Void_Single_0;

		// Token: 0x040082DA RID: 33498
		private static readonly IntPtr NativeMethodInfoPtr_PriceSubmitted_Private_Void_String_0;

		// Token: 0x040082DB RID: 33499
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleFavourited_Private_Void_Boolean_0;

		// Token: 0x040082DC RID: 33500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040082DD RID: 33501
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_0_Private_Void_Boolean_0;

		// Token: 0x040082DE RID: 33502
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_1_Private_Void_Boolean_0;

		// Token: 0x040082DF RID: 33503
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__22_2_Private_Void_String_0;
	}
}
