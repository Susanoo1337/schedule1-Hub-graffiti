using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000523 RID: 1315
	public class WeedPlant : Plant
	{
		// Token: 0x0600779F RID: 30623 RVA: 0x002140F8 File Offset: 0x002122F8
		// Note: this type is marked as 'beforefieldinit'.
		static WeedPlant()
		{
			Il2CppClassPointerStore<WeedPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "WeedPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr);
			WeedPlant.NativeFieldInfoPtr_BranchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, "BranchPrefab");
			WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678669);
			WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678670);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x00214164 File Offset: 0x00212364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231270, XrefRangeEnd = 231276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x002141BC File Offset: 0x002123BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230238, RefRangeEnd = 230239, XrefRangeStart = 230238, XrefRangeEnd = 230239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x000390DC File Offset: 0x000372DC
		public WeedPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x060077A3 RID: 30627 RVA: 0x002141F8 File Offset: 0x002123F8
		// (set) Token: 0x060077A4 RID: 30628 RVA: 0x000390E5 File Offset: 0x000372E5
		public unsafe PlantHarvestable BranchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005180 RID: 20864
		private static readonly IntPtr NativeFieldInfoPtr_BranchPrefab;

		// Token: 0x04005181 RID: 20865
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005182 RID: 20866
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
