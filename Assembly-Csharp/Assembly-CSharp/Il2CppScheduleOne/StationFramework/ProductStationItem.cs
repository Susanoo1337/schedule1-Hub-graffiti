using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000543 RID: 1347
	public class ProductStationItem : StationItem
	{
		// Token: 0x06007B2E RID: 31534 RVA: 0x00221264 File Offset: 0x0021F464
		// Note: this type is marked as 'beforefieldinit'.
		static ProductStationItem()
		{
			Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "ProductStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr);
			ProductStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr, "Visuals");
			ProductStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr, 100679128);
			ProductStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr, 100679129);
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x002212D0 File Offset: 0x0021F4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235357, XrefRangeEnd = 235361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x00221320 File Offset: 0x0021F520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B31 RID: 31537 RVA: 0x0003AA4A File Offset: 0x00038C4A
		public ProductStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x0022135C File Offset: 0x0021F55C
		// (set) Token: 0x06007B33 RID: 31539 RVA: 0x0003AA53 File Offset: 0x00038C53
		public unsafe ProductVisualsSetter Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductVisualsSetter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053F9 RID: 21497
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040053FA RID: 21498
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040053FB RID: 21499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
