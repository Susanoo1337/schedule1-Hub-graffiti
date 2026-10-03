using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000511 RID: 1297
	public class CocaPlant : Plant
	{
		// Token: 0x060074FE RID: 29950 RVA: 0x0020AA88 File Offset: 0x00208C88
		// Note: this type is marked as 'beforefieldinit'.
		static CocaPlant()
		{
			Il2CppClassPointerStore<CocaPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "CocaPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr);
			CocaPlant.NativeFieldInfoPtr_Harvestable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, "Harvestable");
			CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678338);
			CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678339);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x0020AAF4 File Offset: 0x00208CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228593, XrefRangeEnd = 228599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x0020AB4C File Offset: 0x00208D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228599, XrefRangeEnd = 228600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00037E0A File Offset: 0x0003600A
		public CocaPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x06007502 RID: 29954 RVA: 0x0020AB88 File Offset: 0x00208D88
		// (set) Token: 0x06007503 RID: 29955 RVA: 0x00037E13 File Offset: 0x00036013
		public unsafe PlantHarvestable Harvestable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FAA RID: 20394
		private static readonly IntPtr NativeFieldInfoPtr_Harvestable;

		// Token: 0x04004FAB RID: 20395
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04004FAC RID: 20396
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
