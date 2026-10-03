using System;
using Il2CppFishNet.Serializing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x020005C7 RID: 1479
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x06008F87 RID: 36743 RVA: 0x0026DCBC File Offset: 0x0026BEBC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberInstance()
		{
			Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr);
			TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "TRASH_CAPACITY");
			TrashGrabberInstance.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "Content");
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681897);
			TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681898);
			TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681899);
			TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681900);
			TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681901);
			TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681902);
			TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681903);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681904);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681905);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681906);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681907);
			TrashGrabberInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681908);
			TrashGrabberInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100681909);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x0026DE18 File Offset: 0x0026C018
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263339, RefRangeEnd = 263340, XrefRangeStart = 263333, XrefRangeEnd = 263339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x0026DE74 File Offset: 0x0026C074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263340, XrefRangeEnd = 263352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x0026DECC File Offset: 0x0026C0CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263354, RefRangeEnd = 263355, XrefRangeStart = 263352, XrefRangeEnd = 263354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContentData(TrashContentData content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x0026DF10 File Offset: 0x0026C110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263355, XrefRangeEnd = 263361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x0026DF5C File Offset: 0x0026C15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263364, RefRangeEnd = 263365, XrefRangeStart = 263361, XrefRangeEnd = 263364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x0026DFAC File Offset: 0x0026C1AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263368, RefRangeEnd = 263370, XrefRangeStart = 263365, XrefRangeEnd = 263368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x0026DFFC File Offset: 0x0026C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263370, XrefRangeEnd = 263373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0026E030 File Offset: 0x0026C230
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 263375, RefRangeEnd = 263382, XrefRangeStart = 263373, XrefRangeEnd = 263375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x0026E06C File Offset: 0x0026C26C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 263407, RefRangeEnd = 263410, XrefRangeStart = 263382, XrefRangeEnd = 263407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetTrashIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x0026E0AC File Offset: 0x0026C2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263410, XrefRangeEnd = 263434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetTrashQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x0026E0EC File Offset: 0x0026C2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263458, RefRangeEnd = 263459, XrefRangeStart = 263434, XrefRangeEnd = 263458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ushort> GetTrashUshortQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr3) : null;
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x0026E12C File Offset: 0x0026C32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263459, XrefRangeEnd = 263483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(Writer writer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(writer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x0026E17C File Offset: 0x0026C37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263483, XrefRangeEnd = 263498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Read(Reader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x00043D8A File Offset: 0x00041F8A
		public TrashGrabberInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0026E1CC File Offset: 0x0026C3CC
		// (set) Token: 0x06008F97 RID: 36759 RVA: 0x00043D93 File Offset: 0x00041F93
		public unsafe static int TRASH_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06008F98 RID: 36760 RVA: 0x0026E1E8 File Offset: 0x0026C3E8
		// (set) Token: 0x06008F99 RID: 36761 RVA: 0x00043DA1 File Offset: 0x00041FA1
		public unsafe TrashContent Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006280 RID: 25216
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CAPACITY;

		// Token: 0x04006281 RID: 25217
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04006282 RID: 25218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04006283 RID: 25219
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04006284 RID: 25220
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0;

		// Token: 0x04006285 RID: 25221
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04006286 RID: 25222
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04006287 RID: 25223
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04006288 RID: 25224
		private static readonly IntPtr NativeMethodInfoPtr_ClearTrash_Public_Void_0;

		// Token: 0x04006289 RID: 25225
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x0400628A RID: 25226
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0;

		// Token: 0x0400628B RID: 25227
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0;

		// Token: 0x0400628C RID: 25228
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0;

		// Token: 0x0400628D RID: 25229
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Writer_0;

		// Token: 0x0400628E RID: 25230
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Void_Reader_0;
	}
}
