using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x020001CA RID: 458
	public class ProductManagerLoader : Loader
	{
		// Token: 0x06002C5D RID: 11357 RVA: 0x0010E52C File Offset: 0x0010C72C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerLoader()
		{
			Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ProductManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr);
			ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100669045);
			ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100669046);
			ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100669047);
			ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100669048);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0010E5AC File Offset: 0x0010C7AC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C5F RID: 11359 RVA: 0x0010E5E8 File Offset: 0x0010C7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128970, XrefRangeEnd = 129090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C60 RID: 11360 RVA: 0x0010E638 File Offset: 0x0010C838
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129118, RefRangeEnd = 129122, XrefRangeStart = 129090, XrefRangeEnd = 129118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SanitizeProductData(ProductData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C61 RID: 11361 RVA: 0x0010E67C File Offset: 0x0010C87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129122, XrefRangeEnd = 129152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProducts(ProductManagerData productData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(productData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C62 RID: 11362 RVA: 0x00016D90 File Offset: 0x00014F90
		public ProductManagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E79 RID: 7801
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E7A RID: 7802
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001E7B RID: 7803
		private static readonly IntPtr NativeMethodInfoPtr_SanitizeProductData_Private_Void_ProductData_0;

		// Token: 0x04001E7C RID: 7804
		private static readonly IntPtr NativeMethodInfoPtr_LoadProducts_Private_Void_ProductManagerData_0;
	}
}
