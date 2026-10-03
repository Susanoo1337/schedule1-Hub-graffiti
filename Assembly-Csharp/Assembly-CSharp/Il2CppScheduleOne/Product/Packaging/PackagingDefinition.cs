using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Product.Packaging
{
	// Token: 0x02000573 RID: 1395
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x06007F43 RID: 32579 RVA: 0x00230DAC File Offset: 0x0022EFAC
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingDefinition()
		{
			Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product.Packaging", "PackagingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr);
			PackagingDefinition.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Quantity");
			PackagingDefinition.NativeFieldInfoPtr_StealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StealthLevel");
			PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "FunctionalPackaging");
			PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Equippable_Filled");
			PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StoredItem_Filled");
			PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, 100679715);
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00230E54 File Offset: 0x0022F054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243096, XrefRangeEnd = 243097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x0003C63F File Offset: 0x0003A83F
		public PackagingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x06007F46 RID: 32582 RVA: 0x00230E90 File Offset: 0x0022F090
		// (set) Token: 0x06007F47 RID: 32583 RVA: 0x0003C648 File Offset: 0x0003A848
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x06007F48 RID: 32584 RVA: 0x00230EB8 File Offset: 0x0022F0B8
		// (set) Token: 0x06007F49 RID: 32585 RVA: 0x0003C663 File Offset: 0x0003A863
		public unsafe EStealthLevel StealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel)) = value;
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x06007F4A RID: 32586 RVA: 0x00230EE0 File Offset: 0x0022F0E0
		// (set) Token: 0x06007F4B RID: 32587 RVA: 0x0003C67E File Offset: 0x0003A87E
		public unsafe FunctionalPackaging FunctionalPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x06007F4C RID: 32588 RVA: 0x00230F10 File Offset: 0x0022F110
		// (set) Token: 0x06007F4D RID: 32589 RVA: 0x0003C69D File Offset: 0x0003A89D
		public unsafe Equippable Equippable_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x06007F4E RID: 32590 RVA: 0x00230F40 File Offset: 0x0022F140
		// (set) Token: 0x06007F4F RID: 32591 RVA: 0x0003C6BC File Offset: 0x0003A8BC
		public unsafe StoredItem StoredItem_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056E5 RID: 22245
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x040056E6 RID: 22246
		private static readonly IntPtr NativeFieldInfoPtr_StealthLevel;

		// Token: 0x040056E7 RID: 22247
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalPackaging;

		// Token: 0x040056E8 RID: 22248
		private static readonly IntPtr NativeFieldInfoPtr_Equippable_Filled;

		// Token: 0x040056E9 RID: 22249
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem_Filled;

		// Token: 0x040056EA RID: 22250
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
