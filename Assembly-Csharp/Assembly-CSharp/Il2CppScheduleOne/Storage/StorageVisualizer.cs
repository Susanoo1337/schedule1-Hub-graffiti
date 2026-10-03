using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200052E RID: 1326
	public class StorageVisualizer : MonoBehaviour
	{
		// Token: 0x0600788D RID: 30861 RVA: 0x00217FCC File Offset: 0x002161CC
		// Note: this type is marked as 'beforefieldinit'.
		static StorageVisualizer()
		{
			Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr);
			StorageVisualizer.NativeFieldInfoPtr_StorageGrids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "StorageGrids");
			StorageVisualizer.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "ItemContainer");
			StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "FullRefreshOnItemRemoved");
			StorageVisualizer.NativeFieldInfoPtr_itemSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "itemSlots");
			StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "totalFootprintCapacity");
			StorageVisualizer.NativeFieldInfoPtr_activeStoredItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "activeStoredItems");
			StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, "BlockRefreshes");
			StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678813);
			StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678814);
			StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678815);
			StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678816);
			StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678817);
			StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678818);
			StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678819);
			StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678820);
			StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr, 100678821);
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x0021813C File Offset: 0x0021633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232861, XrefRangeEnd = 232865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00218178 File Offset: 0x00216378
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 232882, RefRangeEnd = 232899, XrefRangeStart = 232865, XrefRangeEnd = 232882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSlot(ItemSlot slot, bool update = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref update;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x002181C8 File Offset: 0x002163C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232899, XrefRangeEnd = 232901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetVisualRepresentation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x00218208 File Offset: 0x00216408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232901, XrefRangeEnd = 233050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageVisualizer.NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00218244 File Offset: 0x00216444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233102, RefRangeEnd = 233103, XrefRangeStart = 233050, XrefRangeEnd = 233102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<StoredItem> EnsureSufficientStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<StoredItem>>(intPtr3) : null;
		}

		// Token: 0x06007893 RID: 30867 RVA: 0x002182A4 File Offset: 0x002164A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233124, RefRangeEnd = 233125, XrefRangeStart = 233103, XrefRangeEnd = 233124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyExcessStoredItems(StorableItemInstance item, int quantityRequirement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantityRequirement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x002182F4 File Offset: 0x002164F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233162, RefRangeEnd = 233164, XrefRangeStart = 233125, XrefRangeEnd = 233162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<StorableItemInstance, int> GetContentsDictionary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, int>>(intPtr3) : null;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x00218334 File Offset: 0x00216534
		[CallerCount(0)]
		public unsafe void QueueRefresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr_QueueRefresh_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00218368 File Offset: 0x00216568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x000395E1 File Offset: 0x000377E1
		public StorageVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002533 RID: 9523
		// (get) Token: 0x06007898 RID: 30872 RVA: 0x002183A4 File Offset: 0x002165A4
		// (set) Token: 0x06007899 RID: 30873 RVA: 0x000395EA File Offset: 0x000377EA
		public unsafe Il2CppReferenceArray<StorageGrid> StorageGrids
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StorageGrid>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_StorageGrids), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002534 RID: 9524
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x002183D4 File Offset: 0x002165D4
		// (set) Token: 0x0600789B RID: 30875 RVA: 0x00039609 File Offset: 0x00037809
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002535 RID: 9525
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x00218404 File Offset: 0x00216604
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x00039628 File Offset: 0x00037828
		public unsafe bool FullRefreshOnItemRemoved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_FullRefreshOnItemRemoved)) = value;
			}
		}

		// Token: 0x17002536 RID: 9526
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x0021842C File Offset: 0x0021662C
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x00039643 File Offset: 0x00037843
		public unsafe List<ItemSlot> itemSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_itemSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x0021845C File Offset: 0x0021665C
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x00039662 File Offset: 0x00037862
		public unsafe int totalFootprintCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_totalFootprintCapacity)) = value;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x00218484 File Offset: 0x00216684
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x0003967D File Offset: 0x0003787D
		public unsafe Dictionary<StorableItemInstance, List<StoredItem>> activeStoredItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StorableItemInstance, List<StoredItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_activeStoredItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x002184B4 File Offset: 0x002166B4
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x0003969C File Offset: 0x0003789C
		public unsafe bool BlockRefreshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageVisualizer.NativeFieldInfoPtr_BlockRefreshes)) = value;
			}
		}

		// Token: 0x04005230 RID: 21040
		private static readonly IntPtr NativeFieldInfoPtr_StorageGrids;

		// Token: 0x04005231 RID: 21041
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04005232 RID: 21042
		private static readonly IntPtr NativeFieldInfoPtr_FullRefreshOnItemRemoved;

		// Token: 0x04005233 RID: 21043
		private static readonly IntPtr NativeFieldInfoPtr_itemSlots;

		// Token: 0x04005234 RID: 21044
		private static readonly IntPtr NativeFieldInfoPtr_totalFootprintCapacity;

		// Token: 0x04005235 RID: 21045
		private static readonly IntPtr NativeFieldInfoPtr_activeStoredItems;

		// Token: 0x04005236 RID: 21046
		private static readonly IntPtr NativeFieldInfoPtr_BlockRefreshes;

		// Token: 0x04005237 RID: 21047
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04005238 RID: 21048
		private static readonly IntPtr NativeMethodInfoPtr_AddSlot_Public_Void_ItemSlot_Boolean_0;

		// Token: 0x04005239 RID: 21049
		private static readonly IntPtr NativeMethodInfoPtr_GetVisualRepresentation_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x0400523A RID: 21050
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Public_Virtual_New_Void_0;

		// Token: 0x0400523B RID: 21051
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSufficientStoredItems_Private_List_1_StoredItem_StorableItemInstance_Int32_0;

		// Token: 0x0400523C RID: 21052
		private static readonly IntPtr NativeMethodInfoPtr_DestroyExcessStoredItems_Private_Void_StorableItemInstance_Int32_0;

		// Token: 0x0400523D RID: 21053
		private static readonly IntPtr NativeMethodInfoPtr_GetContentsDictionary_Public_Dictionary_2_StorableItemInstance_Int32_0;

		// Token: 0x0400523E RID: 21054
		private static readonly IntPtr NativeMethodInfoPtr_QueueRefresh_Protected_Void_0;

		// Token: 0x0400523F RID: 21055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
