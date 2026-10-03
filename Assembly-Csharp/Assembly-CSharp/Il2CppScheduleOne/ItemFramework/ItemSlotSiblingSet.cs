using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x02000359 RID: 857
	public class ItemSlotSiblingSet : Object
	{
		// Token: 0x060048BA RID: 18618 RVA: 0x00172810 File Offset: 0x00170A10
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSlotSiblingSet()
		{
			Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemSlotSiblingSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr);
			ItemSlotSiblingSet.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, "Slots");
			ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100672613);
			ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100672614);
			ItemSlotSiblingSet.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr, 100672615);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00172890 File Offset: 0x00170A90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168434, RefRangeEnd = 168435, XrefRangeStart = 168424, XrefRangeEnd = 168434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotSiblingSet([Optional] Il2CppReferenceArray<ItemSlot> slots)
		{
			if (slots == null)
			{
				slots = new Il2CppReferenceArray<ItemSlot>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr));
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x001728E8 File Offset: 0x00170AE8
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 168458, RefRangeEnd = 168467, XrefRangeStart = 168435, XrefRangeEnd = 168458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSlotSiblingSet(List<ItemSlot> slots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSlotSiblingSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00172934 File Offset: 0x00170B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168487, RefRangeEnd = 168489, XrefRangeStart = 168467, XrefRangeEnd = 168487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSlotSiblingSet.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048BE RID: 18622 RVA: 0x000235C1 File Offset: 0x000217C1
		public ItemSlotSiblingSet(params ItemSlot[] slots) : this(new Il2CppReferenceArray<ItemSlot>(slots))
		{
		}

		// Token: 0x060048BF RID: 18623 RVA: 0x000235CF File Offset: 0x000217CF
		public ItemSlotSiblingSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016CD RID: 5837
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x00172978 File Offset: 0x00170B78
		// (set) Token: 0x060048C1 RID: 18625 RVA: 0x000235D8 File Offset: 0x000217D8
		public unsafe List<ItemSlot> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotSiblingSet.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSlotSiblingSet.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_0;
	}
}
