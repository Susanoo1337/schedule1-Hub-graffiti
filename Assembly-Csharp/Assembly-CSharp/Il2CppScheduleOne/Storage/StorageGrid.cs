using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200052A RID: 1322
	public class StorageGrid : MonoBehaviour
	{
		// Token: 0x0600783B RID: 30779 RVA: 0x00216D94 File Offset: 0x00214F94
		// Note: this type is marked as 'beforefieldinit'.
		static StorageGrid()
		{
			Il2CppClassPointerStore<StorageGrid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageGrid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr);
			StorageGrid.NativeFieldInfoPtr_gridSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "gridSize");
			StorageGrid.NativeFieldInfoPtr_storageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "storageTiles");
			StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "coordinateStorageTilePairs");
			StorageGrid.NativeFieldInfoPtr__unoccupiedTileCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "_unoccupiedTileCount");
			StorageGrid.NativeFieldInfoPtr__unoccupiedTileCountDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, "_unoccupiedTileCountDirty");
			StorageGrid.NativeMethodInfoPtr_get_UnoccupiedTileCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678772);
			StorageGrid.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678773);
			StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678774);
			StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678775);
			StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678776);
			StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678777);
			StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678778);
			StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678779);
			StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678780);
			StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678781);
			StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678782);
			StorageGrid.NativeMethodInfoPtr_CalculateUnoccupiedTileCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678783);
			StorageGrid.NativeMethodInfoPtr_TileOccupantChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678784);
			StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr, 100678785);
		}

		// Token: 0x1700251C RID: 9500
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x00216F40 File Offset: 0x00215140
		public unsafe int UnoccupiedTileCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232514, XrefRangeEnd = 232523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_get_UnoccupiedTileCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00216F7C File Offset: 0x0021517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232523, XrefRangeEnd = 232539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00216FB0 File Offset: 0x002151B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232539, XrefRangeEnd = 232553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x00216FF4 File Offset: 0x002151F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232553, XrefRangeEnd = 232568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(StorageTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x00217038 File Offset: 0x00215238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232568, XrefRangeEnd = 232583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00217088 File Offset: 0x00215288
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 232590, RefRangeEnd = 232595, XrefRangeStart = 232583, XrefRangeEnd = 232590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageTile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr3) : null;
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x002170D8 File Offset: 0x002152D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232595, XrefRangeEnd = 232597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetUserEndCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00217114 File Offset: 0x00215314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 232602, RefRangeEnd = 232604, XrefRangeStart = 232597, XrefRangeEnd = 232602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualY()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualY_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x00217150 File Offset: 0x00215350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232604, XrefRangeEnd = 232606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetActualX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetActualX_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x0021718C File Offset: 0x0021538C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232606, XrefRangeEnd = 232607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalFootprintSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x002171C8 File Offset: 0x002153C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232677, RefRangeEnd = 232678, XrefRangeStart = 232607, XrefRangeEnd = 232677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryFitItem(int sizeX, int sizeY, List<Coordinate> lockedCoordinates, out Coordinate originCoordinate, out float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sizeX;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sizeY;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedCoordinates);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rotation;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			originCoordinate = ((intPtr4 == 0) ? null : new Coordinate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x00217264 File Offset: 0x00215464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232678, XrefRangeEnd = 232687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateUnoccupiedTileCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_CalculateUnoccupiedTileCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x002172A0 File Offset: 0x002154A0
		[CallerCount(0)]
		public unsafe void TileOccupantChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr_TileOccupantChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x002172D4 File Offset: 0x002154D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232687, XrefRangeEnd = 232702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageGrid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageGrid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageGrid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x000393A6 File Offset: 0x000375A6
		public StorageGrid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x0600784B RID: 30795 RVA: 0x00217310 File Offset: 0x00215510
		// (set) Token: 0x0600784C RID: 30796 RVA: 0x000393AF File Offset: 0x000375AF
		public unsafe static float gridSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StorageGrid.NativeFieldInfoPtr_gridSize, (void*)(&value));
			}
		}

		// Token: 0x17002518 RID: 9496
		// (get) Token: 0x0600784D RID: 30797 RVA: 0x0021732C File Offset: 0x0021552C
		// (set) Token: 0x0600784E RID: 30798 RVA: 0x000393BD File Offset: 0x000375BD
		public unsafe List<StorageTile> storageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_storageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002519 RID: 9497
		// (get) Token: 0x0600784F RID: 30799 RVA: 0x0021735C File Offset: 0x0021555C
		// (set) Token: 0x06007850 RID: 30800 RVA: 0x000393DC File Offset: 0x000375DC
		public unsafe List<CoordinateStorageTilePair> coordinateStorageTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateStorageTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr_coordinateStorageTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700251A RID: 9498
		// (get) Token: 0x06007851 RID: 30801 RVA: 0x0021738C File Offset: 0x0021558C
		// (set) Token: 0x06007852 RID: 30802 RVA: 0x000393FB File Offset: 0x000375FB
		public unsafe int _unoccupiedTileCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr__unoccupiedTileCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr__unoccupiedTileCount)) = value;
			}
		}

		// Token: 0x1700251B RID: 9499
		// (get) Token: 0x06007853 RID: 30803 RVA: 0x002173B4 File Offset: 0x002155B4
		// (set) Token: 0x06007854 RID: 30804 RVA: 0x00039416 File Offset: 0x00037616
		public unsafe bool _unoccupiedTileCountDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr__unoccupiedTileCountDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageGrid.NativeFieldInfoPtr__unoccupiedTileCountDirty)) = value;
			}
		}

		// Token: 0x040051F7 RID: 20983
		private static readonly IntPtr NativeFieldInfoPtr_gridSize;

		// Token: 0x040051F8 RID: 20984
		private static readonly IntPtr NativeFieldInfoPtr_storageTiles;

		// Token: 0x040051F9 RID: 20985
		private static readonly IntPtr NativeFieldInfoPtr_coordinateStorageTilePairs;

		// Token: 0x040051FA RID: 20986
		private static readonly IntPtr NativeFieldInfoPtr__unoccupiedTileCount;

		// Token: 0x040051FB RID: 20987
		private static readonly IntPtr NativeFieldInfoPtr__unoccupiedTileCountDirty;

		// Token: 0x040051FC RID: 20988
		private static readonly IntPtr NativeMethodInfoPtr_get_UnoccupiedTileCount_Public_get_Int32_0;

		// Token: 0x040051FD RID: 20989
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040051FE RID: 20990
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_StorageTile_0;

		// Token: 0x040051FF RID: 20991
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_StorageTile_0;

		// Token: 0x04005200 RID: 20992
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x04005201 RID: 20993
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_StorageTile_Coordinate_0;

		// Token: 0x04005202 RID: 20994
		private static readonly IntPtr NativeMethodInfoPtr_GetUserEndCapacity_Public_Int32_0;

		// Token: 0x04005203 RID: 20995
		private static readonly IntPtr NativeMethodInfoPtr_GetActualY_Public_Int32_0;

		// Token: 0x04005204 RID: 20996
		private static readonly IntPtr NativeMethodInfoPtr_GetActualX_Public_Int32_0;

		// Token: 0x04005205 RID: 20997
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalFootprintSize_Public_Int32_0;

		// Token: 0x04005206 RID: 20998
		private static readonly IntPtr NativeMethodInfoPtr_TryFitItem_Public_Boolean_Int32_Int32_List_1_Coordinate_byref_Coordinate_byref_Single_0;

		// Token: 0x04005207 RID: 20999
		private static readonly IntPtr NativeMethodInfoPtr_CalculateUnoccupiedTileCount_Private_Int32_0;

		// Token: 0x04005208 RID: 21000
		private static readonly IntPtr NativeMethodInfoPtr_TileOccupantChanged_Private_Void_0;

		// Token: 0x04005209 RID: 21001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
