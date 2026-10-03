using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Core.Items.Framework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000344 RID: 836
	public class ItemFilter_Category : ItemFilter
	{
		// Token: 0x060047B1 RID: 18353 RVA: 0x0016EAA4 File Offset: 0x0016CCA4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Category()
		{
			Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Category");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr);
			ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, "AcceptedCategories");
			ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100672473);
			ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr, 100672474);
		}

		// Token: 0x060047B2 RID: 18354 RVA: 0x0016EB10 File Offset: 0x0016CD10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166948, RefRangeEnd = 166952, XrefRangeStart = 166939, XrefRangeEnd = 166948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Category(List<EItemCategory> acceptedCategories) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Category>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(acceptedCategories);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Category.NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B3 RID: 18355 RVA: 0x0016EB5C File Offset: 0x0016CD5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166952, XrefRangeEnd = 166955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Category.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047B4 RID: 18356 RVA: 0x00022FFC File Offset: 0x000211FC
		public ItemFilter_Category(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x060047B5 RID: 18357 RVA: 0x0016EBB4 File Offset: 0x0016CDB4
		// (set) Token: 0x060047B6 RID: 18358 RVA: 0x00023005 File Offset: 0x00021205
		public unsafe List<EItemCategory> AcceptedCategories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EItemCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_Category.NativeFieldInfoPtr_AcceptedCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030BB RID: 12475
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedCategories;

		// Token: 0x040030BC RID: 12476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_EItemCategory_0;

		// Token: 0x040030BD RID: 12477
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
