using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026E RID: 622
	[Serializable]
	public class ShopData : SaveData
	{
		// Token: 0x06003134 RID: 12596 RVA: 0x0011DDE4 File Offset: 0x0011BFE4
		// Note: this type is marked as 'beforefieldinit'.
		static ShopData()
		{
			Il2CppClassPointerStore<ShopData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ShopData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopData>.NativeClassPtr);
			ShopData.NativeFieldInfoPtr_ShopCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ShopCode");
			ShopData.NativeFieldInfoPtr_ItemStockQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopData>.NativeClassPtr, "ItemStockQuantities");
			ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopData>.NativeClassPtr, 100669466);
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x0011DE50 File Offset: 0x0011C050
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134812, XrefRangeStart = 134800, XrefRangeEnd = 134812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopData(string shopCode, Il2CppReferenceArray<StringIntPair> itemStockQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(shopCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemStockQuantities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003136 RID: 12598 RVA: 0x0001960A File Offset: 0x0001780A
		public ShopData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x0011DEB0 File Offset: 0x0011C0B0
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x00019613 File Offset: 0x00017813
		public unsafe string ShopCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ShopCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x0011DED8 File Offset: 0x0011C0D8
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x00019632 File Offset: 0x00017832
		public unsafe Il2CppReferenceArray<StringIntPair> ItemStockQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StringIntPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShopData.NativeFieldInfoPtr_ItemStockQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020E3 RID: 8419
		private static readonly IntPtr NativeFieldInfoPtr_ShopCode;

		// Token: 0x040020E4 RID: 8420
		private static readonly IntPtr NativeFieldInfoPtr_ItemStockQuantities;

		// Token: 0x040020E5 RID: 8421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_StringIntPair_0;
	}
}
