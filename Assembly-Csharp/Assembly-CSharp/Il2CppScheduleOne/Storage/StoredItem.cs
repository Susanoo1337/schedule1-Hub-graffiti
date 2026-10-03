using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000530 RID: 1328
	public class StoredItem : MonoBehaviour
	{
		// Token: 0x060078AD RID: 30893 RVA: 0x00218594 File Offset: 0x00216794
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem()
		{
			Il2CppClassPointerStore<StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem>.NativeClassPtr);
			StoredItem.NativeFieldInfoPtr__item_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<item>k__BackingField");
			StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<Destroyed>k__BackingField");
			StoredItem.NativeFieldInfoPtr_buildPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "buildPoint");
			StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "CoordinateFootprintTilePairs");
			StoredItem.NativeFieldInfoPtr_footprintX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintX");
			StoredItem.NativeFieldInfoPtr_footprintY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "footprintY");
			StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<parentGrid>k__BackingField");
			StoredItem.NativeFieldInfoPtr_coordinatePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "coordinatePairs");
			StoredItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "rotation");
			StoredItem.NativeFieldInfoPtr_xSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "xSize");
			StoredItem.NativeFieldInfoPtr_ySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "ySize");
			StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678822);
			StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678823);
			StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678824);
			StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678825);
			StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678826);
			StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678827);
			StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678828);
			StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678829);
			StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678830);
			StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678831);
			StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678832);
			StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678833);
			StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678834);
			StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678835);
			StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678836);
			StoredItem.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678837);
			StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678838);
			StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678839);
			StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, 100678840);
		}

		// Token: 0x17002547 RID: 9543
		// (get) Token: 0x060078AE RID: 30894 RVA: 0x0021881C File Offset: 0x00216A1C
		// (set) Token: 0x060078AF RID: 30895 RVA: 0x0021885C File Offset: 0x00216A5C
		public unsafe StorableItemInstance item
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002548 RID: 9544
		// (get) Token: 0x060078B0 RID: 30896 RVA: 0x002188A0 File Offset: 0x00216AA0
		// (set) Token: 0x060078B1 RID: 30897 RVA: 0x002188DC File Offset: 0x00216ADC
		public unsafe bool Destroyed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 33070, RefRangeEnd = 33090, XrefRangeStart = 33070, XrefRangeEnd = 33090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002549 RID: 9545
		// (get) Token: 0x060078B2 RID: 30898 RVA: 0x0021891C File Offset: 0x00216B1C
		public unsafe FootprintTile OriginFootprint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233164, XrefRangeEnd = 233167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
			}
		}

		// Token: 0x1700254A RID: 9546
		// (get) Token: 0x060078B3 RID: 30899 RVA: 0x0021895C File Offset: 0x00216B5C
		public unsafe int FootprintX
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 233188, RefRangeEnd = 233192, XrefRangeStart = 233167, XrefRangeEnd = 233188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700254B RID: 9547
		// (get) Token: 0x060078B4 RID: 30900 RVA: 0x00218998 File Offset: 0x00216B98
		public unsafe int FootprintY
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 233213, RefRangeEnd = 233217, XrefRangeStart = 233192, XrefRangeEnd = 233213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700254C RID: 9548
		// (get) Token: 0x060078B5 RID: 30901 RVA: 0x002189D4 File Offset: 0x00216BD4
		// (set) Token: 0x060078B6 RID: 30902 RVA: 0x00218A14 File Offset: 0x00216C14
		public unsafe StorageGrid parentGrid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700254D RID: 9549
		// (get) Token: 0x060078B7 RID: 30903 RVA: 0x00218A58 File Offset: 0x00216C58
		public unsafe List<CoordinatePair> CoordinatePairs
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 32794, RefRangeEnd = 32795, XrefRangeStart = 32794, XrefRangeEnd = 32795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr3) : null;
			}
		}

		// Token: 0x1700254E RID: 9550
		// (get) Token: 0x060078B8 RID: 30904 RVA: 0x00218A98 File Offset: 0x00216C98
		public unsafe float Rotation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_Rotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x060078B9 RID: 30905 RVA: 0x00218AD4 File Offset: 0x00216CD4
		public unsafe int totalArea
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233217, XrefRangeEnd = 233218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060078BA RID: 30906 RVA: 0x00218B10 File Offset: 0x00216D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233218, XrefRangeEnd = 233231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BB RID: 30907 RVA: 0x00218B4C File Offset: 0x00216D4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 233280, RefRangeEnd = 233286, XrefRangeStart = 233231, XrefRangeEnd = 233280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BC RID: 30908 RVA: 0x00218BC8 File Offset: 0x00216DC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233322, RefRangeEnd = 233323, XrefRangeStart = 233286, XrefRangeEnd = 233322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshTransform()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_RefreshTransform_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BD RID: 30909 RVA: 0x00218BFC File Offset: 0x00216DFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233336, RefRangeEnd = 233338, XrefRangeStart = 233323, XrefRangeEnd = 233336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BE RID: 30910 RVA: 0x00218C38 File Offset: 0x00216E38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 233352, RefRangeEnd = 233354, XrefRangeStart = 233338, XrefRangeEnd = 233352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearFootprintOccupancy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078BF RID: 30911 RVA: 0x00218C6C File Offset: 0x00216E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233354, XrefRangeEnd = 233361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr3) : null;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x00218CBC File Offset: 0x00216EBC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 233376, RefRangeEnd = 233382, XrefRangeStart = 233361, XrefRangeEnd = 233376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x00039710 File Offset: 0x00037910
		public StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x060078C2 RID: 30914 RVA: 0x00218CF8 File Offset: 0x00216EF8
		// (set) Token: 0x060078C3 RID: 30915 RVA: 0x00039719 File Offset: 0x00037919
		public unsafe StorableItemInstance _item_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__item_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x060078C4 RID: 30916 RVA: 0x00218D28 File Offset: 0x00216F28
		// (set) Token: 0x060078C5 RID: 30917 RVA: 0x00039738 File Offset: 0x00037938
		public unsafe bool _Destroyed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__Destroyed_k__BackingField)) = value;
			}
		}

		// Token: 0x1700253E RID: 9534
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x00218D50 File Offset: 0x00216F50
		// (set) Token: 0x060078C7 RID: 30919 RVA: 0x00039753 File Offset: 0x00037953
		public unsafe Transform buildPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_buildPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253F RID: 9535
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x00218D80 File Offset: 0x00216F80
		// (set) Token: 0x060078C9 RID: 30921 RVA: 0x00039772 File Offset: 0x00037972
		public unsafe List<CoordinateStorageFootprintTilePair> CoordinateFootprintTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageFootprintTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_CoordinateFootprintTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x060078CA RID: 30922 RVA: 0x00218DB0 File Offset: 0x00216FB0
		// (set) Token: 0x060078CB RID: 30923 RVA: 0x00039791 File Offset: 0x00037991
		public unsafe int footprintX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintX)) = value;
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x00218DD8 File Offset: 0x00216FD8
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x000397AC File Offset: 0x000379AC
		public unsafe int footprintY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_footprintY)) = value;
			}
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x00218E00 File Offset: 0x00217000
		// (set) Token: 0x060078CF RID: 30927 RVA: 0x000397C7 File Offset: 0x000379C7
		public unsafe StorageGrid _parentGrid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageGrid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr__parentGrid_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002543 RID: 9539
		// (get) Token: 0x060078D0 RID: 30928 RVA: 0x00218E30 File Offset: 0x00217030
		// (set) Token: 0x060078D1 RID: 30929 RVA: 0x000397E6 File Offset: 0x000379E6
		public unsafe List<CoordinatePair> coordinatePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinatePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_coordinatePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002544 RID: 9540
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x00218E60 File Offset: 0x00217060
		// (set) Token: 0x060078D3 RID: 30931 RVA: 0x00039805 File Offset: 0x00037A05
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17002545 RID: 9541
		// (get) Token: 0x060078D4 RID: 30932 RVA: 0x00218E88 File Offset: 0x00217088
		// (set) Token: 0x060078D5 RID: 30933 RVA: 0x00039820 File Offset: 0x00037A20
		public unsafe int xSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_xSize)) = value;
			}
		}

		// Token: 0x17002546 RID: 9542
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x00218EB0 File Offset: 0x002170B0
		// (set) Token: 0x060078D7 RID: 30935 RVA: 0x0003983B File Offset: 0x00037A3B
		public unsafe int ySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem.NativeFieldInfoPtr_ySize)) = value;
			}
		}

		// Token: 0x04005242 RID: 21058
		private static readonly IntPtr NativeFieldInfoPtr__item_k__BackingField;

		// Token: 0x04005243 RID: 21059
		private static readonly IntPtr NativeFieldInfoPtr__Destroyed_k__BackingField;

		// Token: 0x04005244 RID: 21060
		private static readonly IntPtr NativeFieldInfoPtr_buildPoint;

		// Token: 0x04005245 RID: 21061
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateFootprintTilePairs;

		// Token: 0x04005246 RID: 21062
		private static readonly IntPtr NativeFieldInfoPtr_footprintX;

		// Token: 0x04005247 RID: 21063
		private static readonly IntPtr NativeFieldInfoPtr_footprintY;

		// Token: 0x04005248 RID: 21064
		private static readonly IntPtr NativeFieldInfoPtr__parentGrid_k__BackingField;

		// Token: 0x04005249 RID: 21065
		private static readonly IntPtr NativeFieldInfoPtr_coordinatePairs;

		// Token: 0x0400524A RID: 21066
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x0400524B RID: 21067
		private static readonly IntPtr NativeFieldInfoPtr_xSize;

		// Token: 0x0400524C RID: 21068
		private static readonly IntPtr NativeFieldInfoPtr_ySize;

		// Token: 0x0400524D RID: 21069
		private static readonly IntPtr NativeMethodInfoPtr_get_item_Public_get_StorableItemInstance_0;

		// Token: 0x0400524E RID: 21070
		private static readonly IntPtr NativeMethodInfoPtr_set_item_Protected_set_Void_StorableItemInstance_0;

		// Token: 0x0400524F RID: 21071
		private static readonly IntPtr NativeMethodInfoPtr_get_Destroyed_Public_get_Boolean_0;

		// Token: 0x04005250 RID: 21072
		private static readonly IntPtr NativeMethodInfoPtr_set_Destroyed_Private_set_Void_Boolean_0;

		// Token: 0x04005251 RID: 21073
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginFootprint_Public_get_FootprintTile_0;

		// Token: 0x04005252 RID: 21074
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintX_Public_get_Int32_0;

		// Token: 0x04005253 RID: 21075
		private static readonly IntPtr NativeMethodInfoPtr_get_FootprintY_Public_get_Int32_0;

		// Token: 0x04005254 RID: 21076
		private static readonly IntPtr NativeMethodInfoPtr_get_parentGrid_Public_get_StorageGrid_0;

		// Token: 0x04005255 RID: 21077
		private static readonly IntPtr NativeMethodInfoPtr_set_parentGrid_Protected_set_Void_StorageGrid_0;

		// Token: 0x04005256 RID: 21078
		private static readonly IntPtr NativeMethodInfoPtr_get_CoordinatePairs_Public_get_List_1_CoordinatePair_0;

		// Token: 0x04005257 RID: 21079
		private static readonly IntPtr NativeMethodInfoPtr_get_Rotation_Public_get_Single_0;

		// Token: 0x04005258 RID: 21080
		private static readonly IntPtr NativeMethodInfoPtr_get_totalArea_Public_get_Int32_0;

		// Token: 0x04005259 RID: 21081
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400525A RID: 21082
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_New_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400525B RID: 21083
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTransform_Private_Void_0;

		// Token: 0x0400525C RID: 21084
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x0400525D RID: 21085
		private static readonly IntPtr NativeMethodInfoPtr_ClearFootprintOccupancy_Public_Void_0;

		// Token: 0x0400525E RID: 21086
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_FootprintTile_Coordinate_0;

		// Token: 0x0400525F RID: 21087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB2 RID: 2994
		[ObfuscatedName("ScheduleOne.Storage.StoredItem+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EAED RID: 60141 RVA: 0x00390B64 File Offset: 0x0038ED64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StoredItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr);
				StoredItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9");
				StoredItem.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__14_0");
				StoredItem.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, "<>9__17_0");
				StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678842);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678843);
				StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr, 100678844);
			}

			// Token: 0x0600EAEE RID: 60142 RVA: 0x00390C08 File Offset: 0x0038EE08
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAEF RID: 60143 RVA: 0x00390C44 File Offset: 0x0038EE44
			[CallerCount(0)]
			public unsafe int _get_FootprintX_b__14_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EAF0 RID: 60144 RVA: 0x00390C98 File Offset: 0x0038EE98
			[CallerCount(0)]
			public unsafe int _get_FootprintY_b__17_0(CoordinateStorageFootprintTilePair c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(c));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem.__c.NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EAF1 RID: 60145 RVA: 0x0006ED4B File Offset: 0x0006CF4B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004745 RID: 18245
			// (get) Token: 0x0600EAF2 RID: 60146 RVA: 0x00390CEC File Offset: 0x0038EEEC
			// (set) Token: 0x0600EAF3 RID: 60147 RVA: 0x0006ED54 File Offset: 0x0006CF54
			public unsafe static StoredItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004746 RID: 18246
			// (get) Token: 0x0600EAF4 RID: 60148 RVA: 0x00390D14 File Offset: 0x0038EF14
			// (set) Token: 0x0600EAF5 RID: 60149 RVA: 0x0006ED66 File Offset: 0x0006CF66
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004747 RID: 18247
			// (get) Token: 0x0600EAF6 RID: 60150 RVA: 0x00390D3C File Offset: 0x0038EF3C
			// (set) Token: 0x0600EAF7 RID: 60151 RVA: 0x0006ED78 File Offset: 0x0006CF78
			public unsafe static Func<CoordinateStorageFootprintTilePair, int> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CoordinateStorageFootprintTilePair, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StoredItem.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F38 RID: 40760
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009F39 RID: 40761
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009F3A RID: 40762
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04009F3B RID: 40763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F3C RID: 40764
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintX_b__14_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;

			// Token: 0x04009F3D RID: 40765
			private static readonly IntPtr NativeMethodInfoPtr__get_FootprintY_b__17_0_Internal_Int32_CoordinateStorageFootprintTilePair_0;
		}
	}
}
