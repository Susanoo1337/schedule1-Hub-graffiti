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
	// Token: 0x020001FE RID: 510
	[Serializable]
	public class ItemSet : Object
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x00112EFC File Offset: 0x001110FC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSet()
		{
			Il2CppClassPointerStore<ItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSet>.NativeClassPtr);
			ItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "Items");
			ItemSet.NativeFieldInfoPtr_SlotFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "SlotFilters");
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669304);
			ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669305);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669306);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669307);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669308);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669309);
			ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669310);
			ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669311);
			ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100669312);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00113008 File Offset: 0x00111208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134127, XrefRangeEnd = 134138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemData> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00113054 File Offset: 0x00111254
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134139, RefRangeEnd = 134143, XrefRangeStart = 134138, XrefRangeEnd = 134139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJSON()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x0011308C File Offset: 0x0011128C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 134176, RefRangeEnd = 134199, XrefRangeStart = 134143, XrefRangeEnd = 134176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x001130D8 File Offset: 0x001112D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134222, RefRangeEnd = 134224, XrefRangeStart = 134199, XrefRangeEnd = 134222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(Il2CppReferenceArray<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x00113124 File Offset: 0x00111324
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 134233, RefRangeEnd = 134248, XrefRangeStart = 134224, XrefRangeEnd = 134233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(List<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x00113168 File Offset: 0x00111368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 134252, RefRangeEnd = 134256, XrefRangeStart = 134248, XrefRangeEnd = 134252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(Il2CppReferenceArray<ItemSlot> slots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x001131AC File Offset: 0x001113AC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 134258, RefRangeEnd = 134264, XrefRangeStart = 134256, XrefRangeEnd = 134258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTo(ItemSlot slot, int index = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x001131FC File Offset: 0x001113FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 134282, RefRangeEnd = 134287, XrefRangeStart = 134264, XrefRangeEnd = 134282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize(string json, out DeserializedItemSet itemSet)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			itemSet = ((intPtr4 == 0) ? null : new DeserializedItemSet(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00113260 File Offset: 0x00111460
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134310, RefRangeEnd = 134312, XrefRangeStart = 134287, XrefRangeEnd = 134310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryDeserialize(ItemSet set, out DeserializedItemSet itemSet)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(set);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			itemSet = ((intPtr4 == 0) ? null : new DeserializedItemSet(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00016FA2 File Offset: 0x000151A2
		public ItemSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002D85 RID: 11653 RVA: 0x001132C4 File Offset: 0x001114C4
		// (set) Token: 0x06002D86 RID: 11654 RVA: 0x00016FAB File Offset: 0x000151AB
		public unsafe Il2CppStringArray Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x06002D87 RID: 11655 RVA: 0x001132F4 File Offset: 0x001114F4
		// (set) Token: 0x06002D88 RID: 11656 RVA: 0x00016FCA File Offset: 0x000151CA
		public unsafe Il2CppReferenceArray<SlotFilter> SlotFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_SlotFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_SlotFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001F2D RID: 7981
		private static readonly IntPtr NativeFieldInfoPtr_SlotFilters;

		// Token: 0x04001F2E RID: 7982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0;

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeMethodInfoPtr_GetJSON_Public_String_0;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001F33 RID: 7987
		private static readonly IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001F34 RID: 7988
		private static readonly IntPtr NativeMethodInfoPtr_LoadTo_Public_Void_ItemSlot_Int32_0;

		// Token: 0x04001F35 RID: 7989
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_String_byref_DeserializedItemSet_0;

		// Token: 0x04001F36 RID: 7990
		private static readonly IntPtr NativeMethodInfoPtr_TryDeserialize_Public_Static_Boolean_ItemSet_byref_DeserializedItemSet_0;
	}
}
