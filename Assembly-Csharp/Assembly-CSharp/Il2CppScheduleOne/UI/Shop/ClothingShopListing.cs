using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000838 RID: 2104
	public class ClothingShopListing : ShopListing
	{
		// Token: 0x0600CC6E RID: 52334 RVA: 0x00337508 File Offset: 0x00335708
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopListing()
		{
			Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopListing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr);
			ClothingShopListing.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, "Color");
			ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr, 100689649);
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x00337560 File Offset: 0x00335760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 335382, RefRangeEnd = 335383, XrefRangeStart = 335371, XrefRangeEnd = 335382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopListing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopListing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopListing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600CC70 RID: 52336 RVA: 0x00060F88 File Offset: 0x0005F188
		public ClothingShopListing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600CC71 RID: 52337 RVA: 0x0033759C File Offset: 0x0033579C
		// (set) Token: 0x0600CC72 RID: 52338 RVA: 0x00060F91 File Offset: 0x0005F191
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopListing.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04008B2D RID: 35629
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04008B2E RID: 35630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
