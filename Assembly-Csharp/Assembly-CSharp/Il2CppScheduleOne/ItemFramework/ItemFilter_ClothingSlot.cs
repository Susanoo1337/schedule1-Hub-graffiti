using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000345 RID: 837
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x060047B7 RID: 18359 RVA: 0x0016EBE4 File Offset: 0x0016CDE4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ClothingSlot()
		{
			Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ClothingSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr);
			ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, "<SlotType>k__BackingField");
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100672475);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100672476);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100672477);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100672478);
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x060047B8 RID: 18360 RVA: 0x0016EC78 File Offset: 0x0016CE78
		// (set) Token: 0x060047B9 RID: 18361 RVA: 0x0016ECB4 File Offset: 0x0016CEB4
		public unsafe EClothingSlot SlotType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29049, RefRangeEnd = 29051, XrefRangeStart = 29049, XrefRangeEnd = 29051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 29051, RefRangeEnd = 29056, XrefRangeStart = 29051, XrefRangeEnd = 29056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x0016ECF4 File Offset: 0x0016CEF4
		[CallerCount(83)]
		[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ClothingSlot(EClothingSlot slot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047BB RID: 18363 RVA: 0x0016ED3C File Offset: 0x0016CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166955, XrefRangeEnd = 166964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047BC RID: 18364 RVA: 0x00023024 File Offset: 0x00021224
		public ItemFilter_ClothingSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x060047BD RID: 18365 RVA: 0x0016ED94 File Offset: 0x0016CF94
		// (set) Token: 0x060047BE RID: 18366 RVA: 0x0002302D File Offset: 0x0002122D
		public unsafe EClothingSlot _SlotType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField)) = value;
			}
		}

		// Token: 0x040030BE RID: 12478
		private static readonly IntPtr NativeFieldInfoPtr__SlotType_k__BackingField;

		// Token: 0x040030BF RID: 12479
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0;

		// Token: 0x040030C0 RID: 12480
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0;

		// Token: 0x040030C1 RID: 12481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0;

		// Token: 0x040030C2 RID: 12482
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
