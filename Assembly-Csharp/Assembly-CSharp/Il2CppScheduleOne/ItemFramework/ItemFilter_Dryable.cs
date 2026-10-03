using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000346 RID: 838
	public class ItemFilter_Dryable : ItemFilter
	{
		// Token: 0x060047BF RID: 18367 RVA: 0x0016EDBC File Offset: 0x0016CFBC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_Dryable()
		{
			Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_Dryable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr);
			ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100672479);
			ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100672480);
			ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr, 100672481);
		}

		// Token: 0x060047C0 RID: 18368 RVA: 0x0016EE28 File Offset: 0x0016D028
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_Dryable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_Dryable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C1 RID: 18369 RVA: 0x0016EE64 File Offset: 0x0016D064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166964, XrefRangeEnd = 166981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_Dryable.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0016EEBC File Offset: 0x0016D0BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166998, RefRangeEnd = 166999, XrefRangeStart = 166981, XrefRangeEnd = 166998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsItemDryable(ItemInstance instance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_Dryable.NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x00023048 File Offset: 0x00021248
		public ItemFilter_Dryable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030C3 RID: 12483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030C4 RID: 12484
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;

		// Token: 0x040030C5 RID: 12485
		private static readonly IntPtr NativeMethodInfoPtr_IsItemDryable_Public_Static_Boolean_ItemInstance_0;
	}
}
