using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x020001AE RID: 430
	public static class ItemDeserializer : Object
	{
		// Token: 0x06002AD6 RID: 10966 RVA: 0x0001641B File Offset: 0x0001461B
		// Note: this type is marked as 'beforefieldinit'.
		static ItemDeserializer()
		{
			Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "ItemDeserializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr);
			ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemDeserializer>.NativeClassPtr, 100668781);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00108DF8 File Offset: 0x00106FF8
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 124949, RefRangeEnd = 124983, XrefRangeStart = 124913, XrefRangeEnd = 124949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance LoadItem(string itemString)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemDeserializer.NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00016454 File Offset: 0x00014654
		public ItemDeserializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D7A RID: 7546
		private static readonly IntPtr NativeMethodInfoPtr_LoadItem_Public_Static_ItemInstance_String_0;
	}
}
