using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000836 RID: 2102
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x0600CC50 RID: 52304 RVA: 0x00336EAC File Offset: 0x003350AC
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryButton()
		{
			Il2CppClassPointerStore<CategoryButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CategoryButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr);
			CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "<isSelected>k__BackingField");
			CategoryButton.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "Category");
			CategoryButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "button");
			CategoryButton.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "shop");
			CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689635);
			CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689636);
			CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689637);
			CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689638);
			CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689639);
			CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689640);
			CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689641);
			CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100689642);
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600CC51 RID: 52305 RVA: 0x00336FCC File Offset: 0x003351CC
		// (set) Token: 0x0600CC52 RID: 52306 RVA: 0x00337008 File Offset: 0x00335208
		public unsafe bool isSelected
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x00337048 File Offset: 0x00335248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335207, XrefRangeEnd = 335224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x0033707C File Offset: 0x0033527C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335224, XrefRangeEnd = 335228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x003370B0 File Offset: 0x003352B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335228, XrefRangeEnd = 335229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x003370E4 File Offset: 0x003352E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335229, XrefRangeEnd = 335232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x00337118 File Offset: 0x00335318
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 335244, RefRangeEnd = 335253, XrefRangeStart = 335232, XrefRangeEnd = 335244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x0033714C File Offset: 0x0033534C
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CategoryButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC59 RID: 52313 RVA: 0x00060EC4 File Offset: 0x0005F0C4
		public CategoryButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600CC5A RID: 52314 RVA: 0x00337188 File Offset: 0x00335388
		// (set) Token: 0x0600CC5B RID: 52315 RVA: 0x00060ECD File Offset: 0x0005F0CD
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600CC5C RID: 52316 RVA: 0x003371B0 File Offset: 0x003353B0
		// (set) Token: 0x0600CC5D RID: 52317 RVA: 0x00060EE8 File Offset: 0x0005F0E8
		public unsafe EShopCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600CC5E RID: 52318 RVA: 0x003371D8 File Offset: 0x003353D8
		// (set) Token: 0x0600CC5F RID: 52319 RVA: 0x00060F03 File Offset: 0x0005F103
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00337208 File Offset: 0x00335408
		// (set) Token: 0x0600CC61 RID: 52321 RVA: 0x00060F22 File Offset: 0x0005F122
		public unsafe ShopInterface shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008B19 RID: 35609
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04008B1A RID: 35610
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04008B1B RID: 35611
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04008B1C RID: 35612
		private static readonly IntPtr NativeFieldInfoPtr_shop;

		// Token: 0x04008B1D RID: 35613
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04008B1E RID: 35614
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04008B1F RID: 35615
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04008B20 RID: 35616
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04008B21 RID: 35617
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Public_Void_0;

		// Token: 0x04008B22 RID: 35618
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

		// Token: 0x04008B23 RID: 35619
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x04008B24 RID: 35620
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
