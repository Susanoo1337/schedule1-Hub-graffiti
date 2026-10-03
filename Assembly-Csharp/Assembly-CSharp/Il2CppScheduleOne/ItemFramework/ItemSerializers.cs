using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000356 RID: 854
	public static class ItemSerializers : Object
	{
		// Token: 0x06004856 RID: 18518 RVA: 0x00170E88 File Offset: 0x0016F088
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSerializers()
		{
			Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSerializers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr);
			ItemSerializers.NativeFieldInfoPtr_NullItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, "NullItem");
			ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100672555);
			ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100672556);
			ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100672557);
			ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSerializers>.NativeClassPtr, 100672558);
		}

		// Token: 0x06004857 RID: 18519 RVA: 0x00170F1C File Offset: 0x0016F11C
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 167681, RefRangeEnd = 167773, XrefRangeStart = 167677, XrefRangeEnd = 167681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteItemInstance(this Writer writer, ItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004858 RID: 18520 RVA: 0x00170F64 File Offset: 0x0016F164
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 167776, RefRangeEnd = 167822, XrefRangeStart = 167773, XrefRangeEnd = 167776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ItemInstance ReadItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004859 RID: 18521 RVA: 0x00170FA8 File Offset: 0x0016F1A8
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 167681, RefRangeEnd = 167773, XrefRangeStart = 167681, XrefRangeEnd = 167773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteProductItemInstance(this Writer writer, ProductItemInstance value)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600485A RID: 18522 RVA: 0x00170FF0 File Offset: 0x0016F1F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 167827, RefRangeEnd = 167832, XrefRangeStart = 167822, XrefRangeEnd = 167827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ProductItemInstance ReadProductItemInstance(this Reader reader)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSerializers.NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600485B RID: 18523 RVA: 0x00023391 File Offset: 0x00021591
		public ItemSerializers(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x0600485C RID: 18524 RVA: 0x00171034 File Offset: 0x0016F234
		// (set) Token: 0x0600485D RID: 18525 RVA: 0x0002339A File Offset: 0x0002159A
		public unsafe static string NullItem
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ItemSerializers.NativeFieldInfoPtr_NullItem, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ItemSerializers.NativeFieldInfoPtr_NullItem, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003125 RID: 12581
		private static readonly IntPtr NativeFieldInfoPtr_NullItem;

		// Token: 0x04003126 RID: 12582
		private static readonly IntPtr NativeMethodInfoPtr_WriteItemInstance_Public_Static_Void_Writer_ItemInstance_0;

		// Token: 0x04003127 RID: 12583
		private static readonly IntPtr NativeMethodInfoPtr_ReadItemInstance_Public_Static_ItemInstance_Reader_0;

		// Token: 0x04003128 RID: 12584
		private static readonly IntPtr NativeMethodInfoPtr_WriteProductItemInstance_Public_Static_Void_Writer_ProductItemInstance_0;

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeMethodInfoPtr_ReadProductItemInstance_Public_Static_ProductItemInstance_Reader_0;
	}
}
