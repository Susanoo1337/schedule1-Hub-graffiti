using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000834 RID: 2100
	public class CartEntry : MonoBehaviour
	{
		// Token: 0x0600CC25 RID: 52261 RVA: 0x00336530 File Offset: 0x00334730
		// Note: this type is marked as 'beforefieldinit'.
		static CartEntry()
		{
			Il2CppClassPointerStore<CartEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CartEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartEntry>.NativeClassPtr);
			CartEntry.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "NameLabel");
			CartEntry.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "PriceLabel");
			CartEntry.NativeFieldInfoPtr_IncrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "IncrementButton");
			CartEntry.NativeFieldInfoPtr_DecrementButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "DecrementButton");
			CartEntry.NativeFieldInfoPtr_RemoveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "RemoveButton");
			CartEntry.NativeFieldInfoPtr_ModifyButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "ModifyButton");
			CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Quantity>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Cart_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Cart>k__BackingField");
			CartEntry.NativeFieldInfoPtr__Listing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, "<Listing>k__BackingField");
			CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689614);
			CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689615);
			CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689616);
			CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689617);
			CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689618);
			CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689619);
			CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689620);
			CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689621);
			CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689622);
			CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689623);
			CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689624);
			CartEntry.NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689625);
			CartEntry.NativeMethodInfoPtr_SetItemQuantity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689626);
			CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689627);
			CartEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689628);
			CartEntry.NativeMethodInfoPtr__Initialize_b__18_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689629);
			CartEntry.NativeMethodInfoPtr__Initialize_b__18_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689630);
			CartEntry.NativeMethodInfoPtr__Initialize_b__18_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689631);
			CartEntry.NativeMethodInfoPtr__SetAmount_b__23_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartEntry>.NativeClassPtr, 100689632);
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600CC26 RID: 52262 RVA: 0x00336790 File Offset: 0x00334990
		// (set) Token: 0x0600CC27 RID: 52263 RVA: 0x003367CC File Offset: 0x003349CC
		public unsafe int Quantity
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 38157, RefRangeEnd = 38163, XrefRangeStart = 38157, XrefRangeEnd = 38163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 44553, RefRangeEnd = 44554, XrefRangeStart = 44553, XrefRangeEnd = 44554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600CC28 RID: 52264 RVA: 0x0033680C File Offset: 0x00334A0C
		// (set) Token: 0x0600CC29 RID: 52265 RVA: 0x0033684C File Offset: 0x00334A4C
		public unsafe Cart Cart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Cart_Public_get_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600CC2A RID: 52266 RVA: 0x00336890 File Offset: 0x00334A90
		// (set) Token: 0x0600CC2B RID: 52267 RVA: 0x003368D0 File Offset: 0x00334AD0
		public unsafe ShopListing Listing
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600CC2C RID: 52268 RVA: 0x00336914 File Offset: 0x00334B14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335102, RefRangeEnd = 335103, XrefRangeStart = 335069, XrefRangeEnd = 335102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Cart cart, ShopListing listing, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cart);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listing);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC2D RID: 52269 RVA: 0x00336978 File Offset: 0x00334B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335103, XrefRangeEnd = 335104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC2E RID: 52270 RVA: 0x003369B8 File Offset: 0x00334BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335104, XrefRangeEnd = 335108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTitle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartEntry.NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC2F RID: 52271 RVA: 0x003369F4 File Offset: 0x00334BF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 335114, RefRangeEnd = 335117, XrefRangeStart = 335108, XrefRangeEnd = 335114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePrice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_UpdatePrice_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC30 RID: 52272 RVA: 0x00336A28 File Offset: 0x00334C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335117, XrefRangeEnd = 335118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAmount(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC31 RID: 52273 RVA: 0x00336A68 File Offset: 0x00334C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335184, RefRangeEnd = 335185, XrefRangeStart = 335118, XrefRangeEnd = 335184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAmount(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC32 RID: 52274 RVA: 0x00336AA8 File Offset: 0x00334CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335185, XrefRangeEnd = 335187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemQuantity(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr_SetItemQuantity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x00336AE8 File Offset: 0x00334CE8
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC34 RID: 52276 RVA: 0x00336B24 File Offset: 0x00334D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335187, XrefRangeEnd = 335188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC35 RID: 52277 RVA: 0x00336B58 File Offset: 0x00334D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335188, XrefRangeEnd = 335189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__18_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC36 RID: 52278 RVA: 0x00336B8C File Offset: 0x00334D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335189, XrefRangeEnd = 335190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__18_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC37 RID: 52279 RVA: 0x00336BC0 File Offset: 0x00334DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335190, XrefRangeEnd = 335191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__Initialize_b__18_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x00336BF4 File Offset: 0x00334DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 335191, XrefRangeEnd = 335193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _SetAmount_b__23_0(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartEntry.NativeMethodInfoPtr__SetAmount_b__23_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x00060D9F File Offset: 0x0005EF9F
		public CartEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E00 RID: 15872
		// (get) Token: 0x0600CC3A RID: 52282 RVA: 0x00336C34 File Offset: 0x00334E34
		// (set) Token: 0x0600CC3B RID: 52283 RVA: 0x00060DA8 File Offset: 0x0005EFA8
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E01 RID: 15873
		// (get) Token: 0x0600CC3C RID: 52284 RVA: 0x00336C64 File Offset: 0x00334E64
		// (set) Token: 0x0600CC3D RID: 52285 RVA: 0x00060DC7 File Offset: 0x0005EFC7
		public unsafe TextMeshProUGUI PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E02 RID: 15874
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x00336C94 File Offset: 0x00334E94
		// (set) Token: 0x0600CC3F RID: 52287 RVA: 0x00060DE6 File Offset: 0x0005EFE6
		public unsafe Button IncrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_IncrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E03 RID: 15875
		// (get) Token: 0x0600CC40 RID: 52288 RVA: 0x00336CC4 File Offset: 0x00334EC4
		// (set) Token: 0x0600CC41 RID: 52289 RVA: 0x00060E05 File Offset: 0x0005F005
		public unsafe Button DecrementButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_DecrementButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E04 RID: 15876
		// (get) Token: 0x0600CC42 RID: 52290 RVA: 0x00336CF4 File Offset: 0x00334EF4
		// (set) Token: 0x0600CC43 RID: 52291 RVA: 0x00060E24 File Offset: 0x0005F024
		public unsafe Button RemoveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_RemoveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E05 RID: 15877
		// (get) Token: 0x0600CC44 RID: 52292 RVA: 0x00336D24 File Offset: 0x00334F24
		// (set) Token: 0x0600CC45 RID: 52293 RVA: 0x00060E43 File Offset: 0x0005F043
		public unsafe UITrigger ModifyButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_ModifyButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UITrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr_ModifyButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E06 RID: 15878
		// (get) Token: 0x0600CC46 RID: 52294 RVA: 0x00336D54 File Offset: 0x00334F54
		// (set) Token: 0x0600CC47 RID: 52295 RVA: 0x00060E62 File Offset: 0x0005F062
		public unsafe int _Quantity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Quantity_k__BackingField)) = value;
			}
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600CC48 RID: 52296 RVA: 0x00336D7C File Offset: 0x00334F7C
		// (set) Token: 0x0600CC49 RID: 52297 RVA: 0x00060E7D File Offset: 0x0005F07D
		public unsafe Cart _Cart_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cart>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Cart_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x00336DAC File Offset: 0x00334FAC
		// (set) Token: 0x0600CC4B RID: 52299 RVA: 0x00060E9C File Offset: 0x0005F09C
		public unsafe ShopListing _Listing_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartEntry.NativeFieldInfoPtr__Listing_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04008AFB RID: 35579
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04008AFC RID: 35580
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04008AFD RID: 35581
		private static readonly IntPtr NativeFieldInfoPtr_IncrementButton;

		// Token: 0x04008AFE RID: 35582
		private static readonly IntPtr NativeFieldInfoPtr_DecrementButton;

		// Token: 0x04008AFF RID: 35583
		private static readonly IntPtr NativeFieldInfoPtr_RemoveButton;

		// Token: 0x04008B00 RID: 35584
		private static readonly IntPtr NativeFieldInfoPtr_ModifyButton;

		// Token: 0x04008B01 RID: 35585
		private static readonly IntPtr NativeFieldInfoPtr__Quantity_k__BackingField;

		// Token: 0x04008B02 RID: 35586
		private static readonly IntPtr NativeFieldInfoPtr__Cart_k__BackingField;

		// Token: 0x04008B03 RID: 35587
		private static readonly IntPtr NativeFieldInfoPtr__Listing_k__BackingField;

		// Token: 0x04008B04 RID: 35588
		private static readonly IntPtr NativeMethodInfoPtr_get_Quantity_Public_get_Int32_0;

		// Token: 0x04008B05 RID: 35589
		private static readonly IntPtr NativeMethodInfoPtr_set_Quantity_Protected_set_Void_Int32_0;

		// Token: 0x04008B06 RID: 35590
		private static readonly IntPtr NativeMethodInfoPtr_get_Cart_Public_get_Cart_0;

		// Token: 0x04008B07 RID: 35591
		private static readonly IntPtr NativeMethodInfoPtr_set_Cart_Protected_set_Void_Cart_0;

		// Token: 0x04008B08 RID: 35592
		private static readonly IntPtr NativeMethodInfoPtr_get_Listing_Public_get_ShopListing_0;

		// Token: 0x04008B09 RID: 35593
		private static readonly IntPtr NativeMethodInfoPtr_set_Listing_Protected_set_Void_ShopListing_0;

		// Token: 0x04008B0A RID: 35594
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Cart_ShopListing_Int32_0;

		// Token: 0x04008B0B RID: 35595
		private static readonly IntPtr NativeMethodInfoPtr_SetQuantity_Public_Void_Int32_0;

		// Token: 0x04008B0C RID: 35596
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTitle_Protected_Virtual_New_Void_0;

		// Token: 0x04008B0D RID: 35597
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePrice_Private_Void_0;

		// Token: 0x04008B0E RID: 35598
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAmount_Private_Void_Int32_0;

		// Token: 0x04008B0F RID: 35599
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Private_Void_Int32_0;

		// Token: 0x04008B10 RID: 35600
		private static readonly IntPtr NativeMethodInfoPtr_SetItemQuantity_Private_Void_Int32_0;

		// Token: 0x04008B11 RID: 35601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04008B12 RID: 35602
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_0;

		// Token: 0x04008B13 RID: 35603
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_1_Private_Void_0;

		// Token: 0x04008B14 RID: 35604
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_2_Private_Void_0;

		// Token: 0x04008B15 RID: 35605
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_3_Private_Void_0;

		// Token: 0x04008B16 RID: 35606
		private static readonly IntPtr NativeMethodInfoPtr__SetAmount_b__23_0_Private_Void_Single_0;
	}
}
