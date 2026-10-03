using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000358 RID: 856
	public class ItemSlotLock : Object
	{
		// Token: 0x060048AB RID: 18603 RVA: 0x0017249C File Offset: 0x0017069C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotLock()
		{
			Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr);
			ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<Slot>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockOwner>k__BackingField");
			ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, "<LockReason>k__BackingField");
			ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672606);
			ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672607);
			ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672608);
			ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672609);
			ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672610);
			ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672611);
			ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr, 100672612);
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x00172594 File Offset: 0x00170794
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x001725D4 File Offset: 0x001707D4
		public unsafe ItemSlot Slot
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 3712, RefRangeEnd = 3724, XrefRangeStart = 3712, XrefRangeEnd = 3724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x060048AE RID: 18606 RVA: 0x00172618 File Offset: 0x00170818
		// (set) Token: 0x060048AF RID: 18607 RVA: 0x00172658 File Offset: 0x00170858
		public unsafe NetworkObject LockOwner
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x060048B0 RID: 18608 RVA: 0x0017269C File Offset: 0x0017089C
		// (set) Token: 0x060048B1 RID: 18609 RVA: 0x001726D4 File Offset: 0x001708D4
		public unsafe string LockReason
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_get_LockReason_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00172718 File Offset: 0x00170918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168416, XrefRangeEnd = 168424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotLock(ItemSlot slot, NetworkObject lockOwner, string lockReason) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotLock>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotLock.NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x0002355B File Offset: 0x0002175B
		public ItemSlotLock(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x060048B4 RID: 18612 RVA: 0x00172788 File Offset: 0x00170988
		// (set) Token: 0x060048B5 RID: 18613 RVA: 0x00023564 File Offset: 0x00021764
		public unsafe ItemSlot _Slot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__Slot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x060048B6 RID: 18614 RVA: 0x001727B8 File Offset: 0x001709B8
		// (set) Token: 0x060048B7 RID: 18615 RVA: 0x00023583 File Offset: 0x00021783
		public unsafe NetworkObject _LockOwner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockOwner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x001727E8 File Offset: 0x001709E8
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x000235A2 File Offset: 0x000217A2
		public unsafe string _LockReason_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotLock.NativeFieldInfoPtr__LockReason_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeFieldInfoPtr__Slot_k__BackingField;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeFieldInfoPtr__LockOwner_k__BackingField;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeFieldInfoPtr__LockReason_k__BackingField;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Public_get_ItemSlot_0;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeMethodInfoPtr_set_Slot_Protected_set_Void_ItemSlot_0;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr_get_LockOwner_Public_get_NetworkObject_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_set_LockOwner_Protected_set_Void_NetworkObject_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_get_LockReason_Public_get_String_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_set_LockReason_Protected_set_Void_String_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemSlot_NetworkObject_String_0;
	}
}
