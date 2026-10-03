using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Product.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200055B RID: 1371
	public class ProductIconManager : Singleton<ProductIconManager>
	{
		// Token: 0x06007CB0 RID: 31920 RVA: 0x00225FEC File Offset: 0x002241EC
		// Note: this type is marked as 'beforefieldinit'.
		static ProductIconManager()
		{
			Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductIconManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr);
			ProductIconManager.NativeFieldInfoPtr_ProductIconPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "ProductIconPath");
			ProductIconManager.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "icons");
			ProductIconManager.NativeFieldInfoPtr_IconGenerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "IconGenerator");
			ProductIconManager.NativeFieldInfoPtr_Products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Products");
			ProductIconManager.NativeFieldInfoPtr_Packaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "Packaging");
			ProductIconManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679293);
			ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679294);
			ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679295);
			ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679296);
			ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, 100679297);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x002260E4 File Offset: 0x002242E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236784, XrefRangeEnd = 236793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductIconManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x00226120 File Offset: 0x00224320
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236813, RefRangeEnd = 236817, XrefRangeStart = 236793, XrefRangeEnd = 236813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GetIcon(string productID, string packagingID, bool ignoreError = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x00226190 File Offset: 0x00224390
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 236850, RefRangeEnd = 236854, XrefRangeStart = 236817, XrefRangeEnd = 236850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprite GenerateIcons(string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x002261E0 File Offset: 0x002243E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236854, XrefRangeEnd = 236856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GenerateProductTexture(string productID, string packagingID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x00226244 File Offset: 0x00224444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236856, XrefRangeEnd = 236866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductIconManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CB6 RID: 31926 RVA: 0x0003B654 File Offset: 0x00039854
		public ProductIconManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x00226280 File Offset: 0x00224480
		// (set) Token: 0x06007CB8 RID: 31928 RVA: 0x0003B65D File Offset: 0x0003985D
		public unsafe static string ProductIconPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ProductIconManager.NativeFieldInfoPtr_ProductIconPath, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ProductIconManager.NativeFieldInfoPtr_ProductIconPath, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700269D RID: 9885
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x002262A0 File Offset: 0x002244A0
		// (set) Token: 0x06007CBA RID: 31930 RVA: 0x0003B66F File Offset: 0x0003986F
		public unsafe List<ProductIconManager.ProductIcon> icons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductIconManager.ProductIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269E RID: 9886
		// (get) Token: 0x06007CBB RID: 31931 RVA: 0x002262D0 File Offset: 0x002244D0
		// (set) Token: 0x06007CBC RID: 31932 RVA: 0x0003B68E File Offset: 0x0003988E
		public unsafe IconGenerator IconGenerator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IconGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_IconGenerator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700269F RID: 9887
		// (get) Token: 0x06007CBD RID: 31933 RVA: 0x00226300 File Offset: 0x00224500
		// (set) Token: 0x06007CBE RID: 31934 RVA: 0x0003B6AD File Offset: 0x000398AD
		public unsafe Il2CppReferenceArray<ProductDefinition> Products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026A0 RID: 9888
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x00226330 File Offset: 0x00224530
		// (set) Token: 0x06007CC0 RID: 31936 RVA: 0x0003B6CC File Offset: 0x000398CC
		public unsafe Il2CppReferenceArray<PackagingDefinition> Packaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PackagingDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.NativeFieldInfoPtr_Packaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005504 RID: 21764
		private static readonly IntPtr NativeFieldInfoPtr_ProductIconPath;

		// Token: 0x04005505 RID: 21765
		private static readonly IntPtr NativeFieldInfoPtr_icons;

		// Token: 0x04005506 RID: 21766
		private static readonly IntPtr NativeFieldInfoPtr_IconGenerator;

		// Token: 0x04005507 RID: 21767
		private static readonly IntPtr NativeFieldInfoPtr_Products;

		// Token: 0x04005508 RID: 21768
		private static readonly IntPtr NativeFieldInfoPtr_Packaging;

		// Token: 0x04005509 RID: 21769
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400550A RID: 21770
		private static readonly IntPtr NativeMethodInfoPtr_GetIcon_Public_Sprite_String_String_Boolean_0;

		// Token: 0x0400550B RID: 21771
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcons_Public_Sprite_String_0;

		// Token: 0x0400550C RID: 21772
		private static readonly IntPtr NativeMethodInfoPtr_GenerateProductTexture_Private_Texture2D_String_String_0;

		// Token: 0x0400550D RID: 21773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC7 RID: 3015
		[Serializable]
		public class ProductIcon : Il2CppSystem.Object
		{
			// Token: 0x0600EB83 RID: 60291 RVA: 0x00392690 File Offset: 0x00390890
			// Note: this type is marked as 'beforefieldinit'.
			static ProductIcon()
			{
				Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "ProductIcon");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr);
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "name");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "ProductID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "PackagingID");
				ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, "Icon");
				ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr, 100679298);
			}

			// Token: 0x0600EB84 RID: 60292 RVA: 0x00392720 File Offset: 0x00390920
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ProductIcon() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.ProductIcon>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.ProductIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB85 RID: 60293 RVA: 0x0006F174 File Offset: 0x0006D374
			public ProductIcon(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700476F RID: 18287
			// (get) Token: 0x0600EB86 RID: 60294 RVA: 0x0039275C File Offset: 0x0039095C
			// (set) Token: 0x0600EB87 RID: 60295 RVA: 0x0006F17D File Offset: 0x0006D37D
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004770 RID: 18288
			// (get) Token: 0x0600EB88 RID: 60296 RVA: 0x00392784 File Offset: 0x00390984
			// (set) Token: 0x0600EB89 RID: 60297 RVA: 0x0006F19C File Offset: 0x0006D39C
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004771 RID: 18289
			// (get) Token: 0x0600EB8A RID: 60298 RVA: 0x003927AC File Offset: 0x003909AC
			// (set) Token: 0x0600EB8B RID: 60299 RVA: 0x0006F1BB File Offset: 0x0006D3BB
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004772 RID: 18290
			// (get) Token: 0x0600EB8C RID: 60300 RVA: 0x003927D4 File Offset: 0x003909D4
			// (set) Token: 0x0600EB8D RID: 60301 RVA: 0x0006F1DA File Offset: 0x0006D3DA
			public unsafe Sprite Icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.ProductIcon.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F8E RID: 40846
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04009F8F RID: 40847
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04009F90 RID: 40848
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04009F91 RID: 40849
			private static readonly IntPtr NativeFieldInfoPtr_Icon;

			// Token: 0x04009F92 RID: 40850
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC8 RID: 3016
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB8E RID: 60302 RVA: 0x00392804 File Offset: 0x00390A04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, "packagingID");
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679299);
				ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr, 100679300);
			}

			// Token: 0x0600EB8F RID: 60303 RVA: 0x00392880 File Offset: 0x00390A80
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB90 RID: 60304 RVA: 0x003928BC File Offset: 0x00390ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236783, XrefRangeEnd = 236784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIcon_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass7_0.NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB91 RID: 60305 RVA: 0x0006F1F9 File Offset: 0x0006D3F9
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004773 RID: 18291
			// (get) Token: 0x0600EB92 RID: 60306 RVA: 0x0039290C File Offset: 0x00390B0C
			// (set) Token: 0x0600EB93 RID: 60307 RVA: 0x0006F202 File Offset: 0x0006D402
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004774 RID: 18292
			// (get) Token: 0x0600EB94 RID: 60308 RVA: 0x00392934 File Offset: 0x00390B34
			// (set) Token: 0x0600EB95 RID: 60309 RVA: 0x0006F221 File Offset: 0x0006D421
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass7_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009F93 RID: 40851
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04009F94 RID: 40852
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04009F95 RID: 40853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F96 RID: 40854
			private static readonly IntPtr NativeMethodInfoPtr__GetIcon_b__0_Internal_Boolean_ProductIcon_0;
		}

		// Token: 0x02000BC9 RID: 3017
		[ObfuscatedName("ScheduleOne.Product.ProductIconManager+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB96 RID: 60310 RVA: 0x0039295C File Offset: 0x00390B5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductIconManager>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr);
				ProductIconManager.__c__DisplayClass8_0.NativeFieldInfoPtr_productID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr, "productID");
				ProductIconManager.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr, 100679301);
				ProductIconManager.__c__DisplayClass8_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr, 100679302);
			}

			// Token: 0x0600EB97 RID: 60311 RVA: 0x003929C4 File Offset: 0x00390BC4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductIconManager.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB98 RID: 60312 RVA: 0x00392A00 File Offset: 0x00390C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateIcons_b__0(ProductIconManager.ProductIcon x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductIconManager.__c__DisplayClass8_0.NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB99 RID: 60313 RVA: 0x0006F240 File Offset: 0x0006D440
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004775 RID: 18293
			// (get) Token: 0x0600EB9A RID: 60314 RVA: 0x00392A50 File Offset: 0x00390C50
			// (set) Token: 0x0600EB9B RID: 60315 RVA: 0x0006F249 File Offset: 0x0006D449
			public unsafe string productID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass8_0.NativeFieldInfoPtr_productID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductIconManager.__c__DisplayClass8_0.NativeFieldInfoPtr_productID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009F97 RID: 40855
			private static readonly IntPtr NativeFieldInfoPtr_productID;

			// Token: 0x04009F98 RID: 40856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F99 RID: 40857
			private static readonly IntPtr NativeMethodInfoPtr__GenerateIcons_b__0_Internal_Boolean_ProductIcon_0;
		}
	}
}
