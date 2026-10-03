using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200055D RID: 1373
	[Serializable]
	public class ProductList : Object
	{
		// Token: 0x06007CDF RID: 31967 RVA: 0x00226D40 File Offset: 0x00224F40
		// Note: this type is marked as 'beforefieldinit'.
		static ProductList()
		{
			Il2CppClassPointerStore<ProductList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList>.NativeClassPtr);
			ProductList.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "entries");
			ProductList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679333);
			ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679334);
			ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679335);
			ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679336);
			ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679337);
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x00226DE8 File Offset: 0x00224FE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 237355, RefRangeEnd = 237362, XrefRangeStart = 237347, XrefRangeEnd = 237355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00226E24 File Offset: 0x00225024
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237395, RefRangeEnd = 237399, XrefRangeStart = 237362, XrefRangeEnd = 237395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCommaSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007CE2 RID: 31970 RVA: 0x00226E5C File Offset: 0x0022505C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237399, XrefRangeEnd = 237427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLineSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x00226E94 File Offset: 0x00225094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237453, RefRangeEnd = 237454, XrefRangeStart = 237427, XrefRangeEnd = 237453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x00226ECC File Offset: 0x002250CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237468, RefRangeEnd = 237471, XrefRangeStart = 237454, XrefRangeEnd = 237468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x0003B732 File Offset: 0x00039932
		public ProductList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x00226F08 File Offset: 0x00225108
		// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x0003B73B File Offset: 0x0003993B
		public unsafe List<ProductList.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005528 RID: 21800
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04005529 RID: 21801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400552A RID: 21802
		private static readonly IntPtr NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0;

		// Token: 0x0400552B RID: 21803
		private static readonly IntPtr NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0;

		// Token: 0x0400552C RID: 21804
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x0400552D RID: 21805
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0;

		// Token: 0x02000BCB RID: 3019
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600EBAD RID: 60333 RVA: 0x00392DB0 File Offset: 0x00390FB0
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr);
				ProductList.Entry.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "ProductID");
				ProductList.Entry.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quality");
				ProductList.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quantity");
				ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, 100679338);
				ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, 100679339);
			}

			// Token: 0x0600EBAE RID: 60334 RVA: 0x00392E40 File Offset: 0x00391040
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 237335, RefRangeEnd = 237341, XrefRangeStart = 237333, XrefRangeEnd = 237335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string productID, EQuality quality, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quality;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EBAF RID: 60335 RVA: 0x00392EA8 File Offset: 0x003910A8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 237345, RefRangeEnd = 237347, XrefRangeStart = 237341, XrefRangeEnd = 237345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EBB0 RID: 60336 RVA: 0x0006F2CB File Offset: 0x0006D4CB
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700477B RID: 18299
			// (get) Token: 0x0600EBB1 RID: 60337 RVA: 0x00392EE4 File Offset: 0x003910E4
			// (set) Token: 0x0600EBB2 RID: 60338 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700477C RID: 18300
			// (get) Token: 0x0600EBB3 RID: 60339 RVA: 0x00392F0C File Offset: 0x0039110C
			// (set) Token: 0x0600EBB4 RID: 60340 RVA: 0x0006F2F3 File Offset: 0x0006D4F3
			public unsafe EQuality Quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality)) = value;
				}
			}

			// Token: 0x1700477D RID: 18301
			// (get) Token: 0x0600EBB5 RID: 60341 RVA: 0x00392F34 File Offset: 0x00391134
			// (set) Token: 0x0600EBB6 RID: 60342 RVA: 0x0006F30E File Offset: 0x0006D50E
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009FA4 RID: 40868
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04009FA5 RID: 40869
			private static readonly IntPtr NativeFieldInfoPtr_Quality;

			// Token: 0x04009FA6 RID: 40870
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009FA7 RID: 40871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_0;

			// Token: 0x04009FA8 RID: 40872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
