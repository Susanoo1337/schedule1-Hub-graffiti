using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000347 RID: 839
	public class ItemFilter_ID : ItemFilter
	{
		// Token: 0x060047C4 RID: 18372 RVA: 0x0016EF00 File Offset: 0x0016D100
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ID()
		{
			Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr);
			ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IsWhitelist");
			ItemFilter_ID.NativeFieldInfoPtr_IDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, "IDs");
			ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100672482);
			ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr, 100672483);
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0016EF80 File Offset: 0x0016D180
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 167008, RefRangeEnd = 167014, XrefRangeStart = 166999, XrefRangeEnd = 167008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ID(List<string> ids) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ID>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ids);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ID.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0016EFCC File Offset: 0x0016D1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167014, XrefRangeEnd = 167018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ID.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x00023051 File Offset: 0x00021251
		public ItemFilter_ID(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x060047C8 RID: 18376 RVA: 0x0016F024 File Offset: 0x0016D224
		// (set) Token: 0x060047C9 RID: 18377 RVA: 0x0002305A File Offset: 0x0002125A
		public unsafe bool IsWhitelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IsWhitelist)) = value;
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x0016F04C File Offset: 0x0016D24C
		// (set) Token: 0x060047CB RID: 18379 RVA: 0x00023075 File Offset: 0x00021275
		public unsafe List<string> IDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ID.NativeFieldInfoPtr_IDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030C6 RID: 12486
		private static readonly IntPtr NativeFieldInfoPtr_IsWhitelist;

		// Token: 0x040030C7 RID: 12487
		private static readonly IntPtr NativeFieldInfoPtr_IDs;

		// Token: 0x040030C8 RID: 12488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x040030C9 RID: 12489
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
