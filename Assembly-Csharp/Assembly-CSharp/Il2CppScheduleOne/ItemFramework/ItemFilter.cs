using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000343 RID: 835
	public class ItemFilter : Object
	{
		// Token: 0x060047AD RID: 18349 RVA: 0x0016E9B8 File Offset: 0x0016CBB8
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter()
		{
			Il2CppClassPointerStore<ItemFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr);
			ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100672471);
			ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr, 100672472);
		}

		// Token: 0x060047AE RID: 18350 RVA: 0x0016EA10 File Offset: 0x0016CC10
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047AF RID: 18351 RVA: 0x0016EA68 File Offset: 0x0016CC68
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047B0 RID: 18352 RVA: 0x00022FF3 File Offset: 0x000211F3
		public ItemFilter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040030B9 RID: 12473
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_New_Boolean_ItemInstance_0;

		// Token: 0x040030BA RID: 12474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
