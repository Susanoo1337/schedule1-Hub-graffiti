using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000349 RID: 841
	public class ItemFilter_MixingIngredient : ItemFilter
	{
		// Token: 0x060047D2 RID: 18386 RVA: 0x0016F1B0 File Offset: 0x0016D3B0
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_MixingIngredient()
		{
			Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_MixingIngredient");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100672486);
			ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr, 100672487);
		}

		// Token: 0x060047D3 RID: 18387 RVA: 0x0016F208 File Offset: 0x0016D408
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_MixingIngredient() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_MixingIngredient>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_MixingIngredient.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047D4 RID: 18388 RVA: 0x0016F244 File Offset: 0x0016D444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167019, XrefRangeEnd = 167028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_MixingIngredient.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x000230B8 File Offset: 0x000212B8
		public ItemFilter_MixingIngredient(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030CD RID: 12493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030CE RID: 12494
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
