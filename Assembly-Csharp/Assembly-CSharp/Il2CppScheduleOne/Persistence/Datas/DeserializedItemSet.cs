using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020001FD RID: 509
	public class DeserializedItemSet : Object
	{
		// Token: 0x06002D70 RID: 11632 RVA: 0x00112CDC File Offset: 0x00110EDC
		// Note: this type is marked as 'beforefieldinit'.
		static DeserializedItemSet()
		{
			Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeserializedItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr);
			DeserializedItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, "Items");
			DeserializedItemSet.NativeFieldInfoPtr_SlotFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, "SlotFilters");
			DeserializedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100669300);
			DeserializedItemSet.NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100669301);
			DeserializedItemSet.NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100669302);
			DeserializedItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr, 100669303);
		}

		// Token: 0x06002D71 RID: 11633 RVA: 0x00112D84 File Offset: 0x00110F84
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializedItemSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializedItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x00112DC0 File Offset: 0x00110FC0
		[CallerCount(0)]
		public unsafe ItemInstance GetItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x00112E0C File Offset: 0x0011100C
		[CallerCount(0)]
		public unsafe SlotFilter GetSlotFilterAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SlotFilter>(intPtr3) : null;
		}

		// Token: 0x06002D74 RID: 11636 RVA: 0x00112E58 File Offset: 0x00111058
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 134124, RefRangeEnd = 134127, XrefRangeStart = 134116, XrefRangeEnd = 134124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(List<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializedItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D75 RID: 11637 RVA: 0x00016F5B File Offset: 0x0001515B
		public DeserializedItemSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x00112E9C File Offset: 0x0011109C
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x00016F64 File Offset: 0x00015164
		public unsafe Il2CppReferenceArray<ItemInstance> Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x00112ECC File Offset: 0x001110CC
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x00016F83 File Offset: 0x00015183
		public unsafe Il2CppReferenceArray<SlotFilter> SlotFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_SlotFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeserializedItemSet.NativeFieldInfoPtr_SlotFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F26 RID: 7974
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001F27 RID: 7975
		private static readonly IntPtr NativeFieldInfoPtr_SlotFilters;

		// Token: 0x04001F28 RID: 7976
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F29 RID: 7977
		private static readonly IntPtr NativeMethodInfoPtr_GetItemAt_Public_ItemInstance_Int32_0;

		// Token: 0x04001F2A RID: 7978
		private static readonly IntPtr NativeMethodInfoPtr_GetSlotFilterAt_Public_SlotFilter_Int32_0;

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0;
	}
}
