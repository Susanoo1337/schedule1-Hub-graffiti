using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.ProductManagerApp
{
	// Token: 0x020007AF RID: 1967
	public class ProductTypeContainer : MonoBehaviour
	{
		// Token: 0x0600BF56 RID: 48982 RVA: 0x0030EFC4 File Offset: 0x0030D1C4
		// Note: this type is marked as 'beforefieldinit'.
		static ProductTypeContainer()
		{
			Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.ProductManagerApp", "ProductTypeContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr);
			ProductTypeContainer.NativeFieldInfoPtr__drugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_drugType");
			ProductTypeContainer.NativeFieldInfoPtr__enteries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_enteries");
			ProductTypeContainer.NativeFieldInfoPtr__noneDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_noneDisplay");
			ProductTypeContainer.NativeFieldInfoPtr__dropDownIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_dropDownIndicator");
			ProductTypeContainer.NativeFieldInfoPtr__dropDownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_dropDownButton");
			ProductTypeContainer.NativeFieldInfoPtr__isExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, "_isExpanded");
			ProductTypeContainer.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688253);
			ProductTypeContainer.NativeMethodInfoPtr_get_Enteries_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688254);
			ProductTypeContainer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688255);
			ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688256);
			ProductTypeContainer.NativeMethodInfoPtr_SetDropdown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688257);
			ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688258);
			ProductTypeContainer.NativeMethodInfoPtr__Start_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr, 100688259);
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600BF57 RID: 48983 RVA: 0x0030F0F8 File Offset: 0x0030D2F8
		public unsafe EDrugType DrugType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170039DD RID: 14813
		// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x0030F134 File Offset: 0x0030D334
		public unsafe RectTransform Enteries
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr_get_Enteries_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
		}

		// Token: 0x0600BF59 RID: 48985 RVA: 0x0030F174 File Offset: 0x0030D374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318146, XrefRangeEnd = 318154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF5A RID: 48986 RVA: 0x0030F1A8 File Offset: 0x0030D3A8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 318163, RefRangeEnd = 318168, XrefRangeStart = 318154, XrefRangeEnd = 318163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshNoneDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF5B RID: 48987 RVA: 0x0030F1DC File Offset: 0x0030D3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318168, XrefRangeEnd = 318173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDropdown(bool isExpanded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isExpanded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr_SetDropdown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF5C RID: 48988 RVA: 0x0030F21C File Offset: 0x0030D41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318173, XrefRangeEnd = 318174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductTypeContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductTypeContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF5D RID: 48989 RVA: 0x0030F258 File Offset: 0x0030D458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318174, XrefRangeEnd = 318179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeContainer.NativeMethodInfoPtr__Start_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BF5E RID: 48990 RVA: 0x00059750 File Offset: 0x00057950
		public ProductTypeContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x0600BF5F RID: 48991 RVA: 0x0030F28C File Offset: 0x0030D48C
		// (set) Token: 0x0600BF60 RID: 48992 RVA: 0x00059759 File Offset: 0x00057959
		public unsafe EDrugType _drugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__drugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__drugType)) = value;
			}
		}

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0600BF61 RID: 48993 RVA: 0x0030F2B4 File Offset: 0x0030D4B4
		// (set) Token: 0x0600BF62 RID: 48994 RVA: 0x00059774 File Offset: 0x00057974
		public unsafe RectTransform _enteries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__enteries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__enteries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D8 RID: 14808
		// (get) Token: 0x0600BF63 RID: 48995 RVA: 0x0030F2E4 File Offset: 0x0030D4E4
		// (set) Token: 0x0600BF64 RID: 48996 RVA: 0x00059793 File Offset: 0x00057993
		public unsafe RectTransform _noneDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__noneDisplay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__noneDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039D9 RID: 14809
		// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x0030F314 File Offset: 0x0030D514
		// (set) Token: 0x0600BF66 RID: 48998 RVA: 0x000597B2 File Offset: 0x000579B2
		public unsafe RectTransform _dropDownIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__dropDownIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__dropDownIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DA RID: 14810
		// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x0030F344 File Offset: 0x0030D544
		// (set) Token: 0x0600BF68 RID: 49000 RVA: 0x000597D1 File Offset: 0x000579D1
		public unsafe Button _dropDownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__dropDownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__dropDownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x0030F374 File Offset: 0x0030D574
		// (set) Token: 0x0600BF6A RID: 49002 RVA: 0x000597F0 File Offset: 0x000579F0
		public unsafe bool _isExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__isExpanded);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeContainer.NativeFieldInfoPtr__isExpanded)) = value;
			}
		}

		// Token: 0x040082FB RID: 33531
		private static readonly IntPtr NativeFieldInfoPtr__drugType;

		// Token: 0x040082FC RID: 33532
		private static readonly IntPtr NativeFieldInfoPtr__enteries;

		// Token: 0x040082FD RID: 33533
		private static readonly IntPtr NativeFieldInfoPtr__noneDisplay;

		// Token: 0x040082FE RID: 33534
		private static readonly IntPtr NativeFieldInfoPtr__dropDownIndicator;

		// Token: 0x040082FF RID: 33535
		private static readonly IntPtr NativeFieldInfoPtr__dropDownButton;

		// Token: 0x04008300 RID: 33536
		private static readonly IntPtr NativeFieldInfoPtr__isExpanded;

		// Token: 0x04008301 RID: 33537
		private static readonly IntPtr NativeMethodInfoPtr_get_DrugType_Public_get_EDrugType_0;

		// Token: 0x04008302 RID: 33538
		private static readonly IntPtr NativeMethodInfoPtr_get_Enteries_Public_get_RectTransform_0;

		// Token: 0x04008303 RID: 33539
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04008304 RID: 33540
		private static readonly IntPtr NativeMethodInfoPtr_RefreshNoneDisplay_Public_Void_0;

		// Token: 0x04008305 RID: 33541
		private static readonly IntPtr NativeMethodInfoPtr_SetDropdown_Public_Void_Boolean_0;

		// Token: 0x04008306 RID: 33542
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008307 RID: 33543
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__10_0_Private_Void_0;
	}
}
