using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200048D RID: 1165
	[Serializable]
	public class TrashContent : Object
	{
		// Token: 0x060068E7 RID: 26855 RVA: 0x001E5F58 File Offset: 0x001E4158
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContent()
		{
			Il2CppClassPointerStore<TrashContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent>.NativeClassPtr);
			TrashContent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entries");
			TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677018);
			TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677019);
			TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677020);
			TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677021);
			TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677022);
			TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677023);
			TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677024);
			TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100677025);
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x001E603C File Offset: 0x001E423C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 216958, RefRangeEnd = 216965, XrefRangeStart = 216920, XrefRangeEnd = 216958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x001E608C File Offset: 0x001E428C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216982, RefRangeEnd = 216983, XrefRangeStart = 216965, XrefRangeEnd = 216982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x001E60DC File Offset: 0x001E42DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216983, XrefRangeEnd = 216997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashQuantity(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x001E612C File Offset: 0x001E432C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216999, RefRangeEnd = 217000, XrefRangeStart = 216997, XrefRangeEnd = 216999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x001E6160 File Offset: 0x001E4360
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 217014, RefRangeEnd = 217025, XrefRangeStart = 217000, XrefRangeEnd = 217014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x001E619C File Offset: 0x001E439C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 217045, RefRangeEnd = 217052, XrefRangeStart = 217025, XrefRangeEnd = 217045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr3) : null;
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x001E61DC File Offset: 0x001E43DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 217054, RefRangeEnd = 217058, XrefRangeStart = 217052, XrefRangeEnd = 217054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromData(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x001E6220 File Offset: 0x001E4420
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 217066, RefRangeEnd = 217071, XrefRangeStart = 217058, XrefRangeEnd = 217066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00031610 File Offset: 0x0002F810
		public TrashContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060068F1 RID: 26865 RVA: 0x001E625C File Offset: 0x001E445C
		// (set) Token: 0x060068F2 RID: 26866 RVA: 0x00031619 File Offset: 0x0002F819
		public unsafe List<TrashContent.Entry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContent.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004824 RID: 18468
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04004825 RID: 18469
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04004826 RID: 18470
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04004827 RID: 18471
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0;

		// Token: 0x04004828 RID: 18472
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04004829 RID: 18473
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x0400482A RID: 18474
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_TrashContentData_0;

		// Token: 0x0400482B RID: 18475
		private static readonly IntPtr NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0;

		// Token: 0x0400482C RID: 18476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B54 RID: 2900
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600E7BA RID: 59322 RVA: 0x00387838 File Offset: 0x00385A38
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr);
				TrashContent.Entry.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "TrashID");
				TrashContent.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "Quantity");
				TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitSize>k__BackingField");
				TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitValue>k__BackingField");
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677026);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677027);
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677028);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677029);
				TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100677030);
			}

			// Token: 0x17004657 RID: 18007
			// (get) Token: 0x0600E7BB RID: 59323 RVA: 0x00387918 File Offset: 0x00385B18
			// (set) Token: 0x0600E7BC RID: 59324 RVA: 0x00387954 File Offset: 0x00385B54
			public unsafe int UnitSize
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 36888, RefRangeEnd = 36892, XrefRangeStart = 36888, XrefRangeEnd = 36892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17004658 RID: 18008
			// (get) Token: 0x0600E7BD RID: 59325 RVA: 0x00387994 File Offset: 0x00385B94
			// (set) Token: 0x0600E7BE RID: 59326 RVA: 0x003879D0 File Offset: 0x00385BD0
			public unsafe int UnitValue
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 3894, RefRangeEnd = 3895, XrefRangeStart = 3894, XrefRangeEnd = 3895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 29057, RefRangeEnd = 29058, XrefRangeStart = 29057, XrefRangeEnd = 29058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600E7BF RID: 59327 RVA: 0x00387A10 File Offset: 0x00385C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216909, XrefRangeEnd = 216920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string id, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7C0 RID: 59328 RVA: 0x0006D498 File Offset: 0x0006B698
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004653 RID: 18003
			// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x00387A6C File Offset: 0x00385C6C
			// (set) Token: 0x0600E7C2 RID: 59330 RVA: 0x0006D4A1 File Offset: 0x0006B6A1
			public unsafe string TrashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004654 RID: 18004
			// (get) Token: 0x0600E7C3 RID: 59331 RVA: 0x00387A94 File Offset: 0x00385C94
			// (set) Token: 0x0600E7C4 RID: 59332 RVA: 0x0006D4C0 File Offset: 0x0006B6C0
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x17004655 RID: 18005
			// (get) Token: 0x0600E7C5 RID: 59333 RVA: 0x00387ABC File Offset: 0x00385CBC
			// (set) Token: 0x0600E7C6 RID: 59334 RVA: 0x0006D4DB File Offset: 0x0006B6DB
			public unsafe int _UnitSize_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField)) = value;
				}
			}

			// Token: 0x17004656 RID: 18006
			// (get) Token: 0x0600E7C7 RID: 59335 RVA: 0x00387AE4 File Offset: 0x00385CE4
			// (set) Token: 0x0600E7C8 RID: 59336 RVA: 0x0006D4F6 File Offset: 0x0006B6F6
			public unsafe int _UnitValue_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField)) = value;
				}
			}

			// Token: 0x04009D44 RID: 40260
			private static readonly IntPtr NativeFieldInfoPtr_TrashID;

			// Token: 0x04009D45 RID: 40261
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009D46 RID: 40262
			private static readonly IntPtr NativeFieldInfoPtr__UnitSize_k__BackingField;

			// Token: 0x04009D47 RID: 40263
			private static readonly IntPtr NativeFieldInfoPtr__UnitValue_k__BackingField;

			// Token: 0x04009D48 RID: 40264
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0;

			// Token: 0x04009D49 RID: 40265
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0;

			// Token: 0x04009D4A RID: 40266
			private static readonly IntPtr NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0;

			// Token: 0x04009D4B RID: 40267
			private static readonly IntPtr NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0;

			// Token: 0x04009D4C RID: 40268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
		}

		// Token: 0x02000B55 RID: 2901
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600E7C9 RID: 59337 RVA: 0x00387B0C File Offset: 0x00385D0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100677031);
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100677032);
			}

			// Token: 0x0600E7CA RID: 59338 RVA: 0x00387B74 File Offset: 0x00385D74
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7CB RID: 59339 RVA: 0x00387BB0 File Offset: 0x00385DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7CC RID: 59340 RVA: 0x0006D511 File Offset: 0x0006B711
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004659 RID: 18009
			// (get) Token: 0x0600E7CD RID: 59341 RVA: 0x00387C00 File Offset: 0x00385E00
			// (set) Token: 0x0600E7CE RID: 59342 RVA: 0x0006D51A File Offset: 0x0006B71A
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009D4D RID: 40269
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04009D4E RID: 40270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D4F RID: 40271
			private static readonly IntPtr NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000B56 RID: 2902
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600E7CF RID: 59343 RVA: 0x00387C28 File Offset: 0x00385E28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100677033);
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100677034);
			}

			// Token: 0x0600E7D0 RID: 59344 RVA: 0x00387C90 File Offset: 0x00385E90
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7D1 RID: 59345 RVA: 0x00387CCC File Offset: 0x00385ECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7D2 RID: 59346 RVA: 0x0006D539 File Offset: 0x0006B739
			public __c__DisplayClass3_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465A RID: 18010
			// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x00387D1C File Offset: 0x00385F1C
			// (set) Token: 0x0600E7D4 RID: 59348 RVA: 0x0006D542 File Offset: 0x0006B742
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009D50 RID: 40272
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04009D51 RID: 40273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D52 RID: 40274
			private static readonly IntPtr NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000B57 RID: 2903
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600E7D5 RID: 59349 RVA: 0x00387D44 File Offset: 0x00385F44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100677035);
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100677036);
			}

			// Token: 0x0600E7D6 RID: 59350 RVA: 0x00387DAC File Offset: 0x00385FAC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E7D7 RID: 59351 RVA: 0x00387DE8 File Offset: 0x00385FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashQuantity_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E7D8 RID: 59352 RVA: 0x0006D561 File Offset: 0x0006B761
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465B RID: 18011
			// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x00387E38 File Offset: 0x00386038
			// (set) Token: 0x0600E7DA RID: 59354 RVA: 0x0006D56A File Offset: 0x0006B76A
			public unsafe string trashID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009D53 RID: 40275
			private static readonly IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04009D54 RID: 40276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009D55 RID: 40277
			private static readonly IntPtr NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0;
		}
	}
}
