using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Temperature;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000119 RID: 281
	[Serializable]
	public class Tile : MonoBehaviour
	{
		// Token: 0x06001B38 RID: 6968 RVA: 0x000D4E88 File Offset: 0x000D3088
		// Note: this type is marked as 'beforefieldinit'.
		static Tile()
		{
			Il2CppClassPointerStore<Tile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Tile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tile>.NativeClassPtr);
			Tile.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "x");
			Tile.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "y");
			Tile.NativeFieldInfoPtr_AvailableOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "AvailableOffset");
			Tile.NativeFieldInfoPtr_OwnerGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OwnerGrid");
			Tile.NativeFieldInfoPtr_LightExposureNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "LightExposureNode");
			Tile.NativeFieldInfoPtr_BuildableOccupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "BuildableOccupants");
			Tile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "OccupantTiles");
			Tile.NativeFieldInfoPtr_onTileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "onTileChanged");
			Tile.NativeFieldInfoPtr_onTileTemperatureChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "onTileTemperatureChanged");
			Tile.NativeFieldInfoPtr__cosmeticTileTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "_cosmeticTileTemperature");
			Tile.NativeFieldInfoPtr__cachedCosmeticTemperatureEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "_cachedCosmeticTemperatureEmitters");
			Tile.NativeFieldInfoPtr__tileTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "_tileTemperature");
			Tile.NativeFieldInfoPtr__cachedTemperatureEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Tile>.NativeClassPtr, "_cachedTemperatureEmitters");
			Tile.NativeMethodInfoPtr_get_CosmeticTileTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666915);
			Tile.NativeMethodInfoPtr_get_TileTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666916);
			Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666917);
			Tile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666918);
			Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666919);
			Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666920);
			Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666921);
			Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666922);
			Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666923);
			Tile.NativeMethodInfoPtr_OnCosmeticTemperatureEmittersChanged_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666924);
			Tile.NativeMethodInfoPtr_OnTemperatureEmittersChanged_Private_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666925);
			Tile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile>.NativeClassPtr, 100666926);
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x000D50AC File Offset: 0x000D32AC
		public unsafe float CosmeticTileTemperature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101819, RefRangeEnd = 101820, XrefRangeStart = 101813, XrefRangeEnd = 101819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_CosmeticTileTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x000D50E8 File Offset: 0x000D32E8
		public unsafe float TileTemperature
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 101826, RefRangeEnd = 101828, XrefRangeStart = 101820, XrefRangeEnd = 101826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_get_TileTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000D5124 File Offset: 0x000D3324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101828, XrefRangeEnd = 101829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializePropertyTile(int _x, int _y, float _available_Offset, Grid _ownerGrid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _available_Offset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_ownerGrid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000D5194 File Offset: 0x000D3394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101829, XrefRangeEnd = 101855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x000D51C8 File Offset: 0x000D33C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101855, XrefRangeEnd = 101871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x000D521C File Offset: 0x000D341C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101877, RefRangeEnd = 101878, XrefRangeStart = 101871, XrefRangeEnd = 101877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(GridItem occ, FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occ);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x000D5270 File Offset: 0x000D3470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101878, XrefRangeEnd = 101887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeBuiltOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x000D52B8 File Offset: 0x000D34B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101911, RefRangeEnd = 101912, XrefRangeStart = 101887, XrefRangeEnd = 101911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetSurroundingTiles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr3) : null;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000D52F8 File Offset: 0x000D34F8
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsIndoorTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Tile.NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000D5340 File Offset: 0x000D3540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101912, XrefRangeEnd = 101913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCosmeticTemperatureEmittersChanged(string propertyCode, Il2CppStructArray<TemperatureEmitterInfo> emitters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(emitters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_OnCosmeticTemperatureEmittersChanged_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x000D5394 File Offset: 0x000D3594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101913, XrefRangeEnd = 101914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTemperatureEmittersChanged(Il2CppStructArray<TemperatureEmitterInfo> emitters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emitters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr_OnTemperatureEmittersChanged_Private_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000D53D8 File Offset: 0x000D35D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
		public Tile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x000D5414 File Offset: 0x000D3614
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0000ECF9 File Offset: 0x0000CEF9
		public unsafe int x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000D543C File Offset: 0x000D363C
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0000ED14 File Offset: 0x0000CF14
		public unsafe int y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000D5464 File Offset: 0x000D3664
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0000ED2F File Offset: 0x0000CF2F
		public unsafe float AvailableOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_AvailableOffset)) = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000D548C File Offset: 0x000D368C
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0000ED4A File Offset: 0x0000CF4A
		public unsafe Grid OwnerGrid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OwnerGrid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000D54BC File Offset: 0x000D36BC
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0000ED69 File Offset: 0x0000CF69
		public unsafe LightExposureNode LightExposureNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightExposureNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_LightExposureNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x000D54EC File Offset: 0x000D36EC
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0000ED88 File Offset: 0x0000CF88
		public unsafe List<GridItem> BuildableOccupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_BuildableOccupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x000D551C File Offset: 0x000D371C
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0000EDA7 File Offset: 0x0000CFA7
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x000D554C File Offset: 0x000D374C
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0000EDC6 File Offset: 0x0000CFC6
		public unsafe Tile.TileChange onTileChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile.TileChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x000D557C File Offset: 0x000D377C
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0000EDE5 File Offset: 0x0000CFE5
		public unsafe Action<Tile, float> onTileTemperatureChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileTemperatureChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Tile, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr_onTileTemperatureChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x000D55AC File Offset: 0x000D37AC
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0000EE04 File Offset: 0x0000D004
		public unsafe float _cosmeticTileTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cosmeticTileTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cosmeticTileTemperature)) = value;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x000D55D4 File Offset: 0x000D37D4
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0000EE1F File Offset: 0x0000D01F
		public unsafe Il2CppStructArray<TemperatureEmitterInfo> _cachedCosmeticTemperatureEmitters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cachedCosmeticTemperatureEmitters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TemperatureEmitterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cachedCosmeticTemperatureEmitters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x000D5604 File Offset: 0x000D3804
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0000EE3E File Offset: 0x0000D03E
		public unsafe float _tileTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__tileTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__tileTemperature)) = value;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x000D562C File Offset: 0x000D382C
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x0000EE59 File Offset: 0x0000D059
		public unsafe Il2CppStructArray<TemperatureEmitterInfo> _cachedTemperatureEmitters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cachedTemperatureEmitters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TemperatureEmitterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Tile.NativeFieldInfoPtr__cachedTemperatureEmitters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr_AvailableOffset;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_OwnerGrid;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_LightExposureNode;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_BuildableOccupants;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr_onTileChanged;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr_onTileTemperatureChanged;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeFieldInfoPtr__cosmeticTileTemperature;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeFieldInfoPtr__cachedCosmeticTemperatureEmitters;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeFieldInfoPtr__tileTemperature;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeFieldInfoPtr__cachedTemperatureEmitters;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_get_CosmeticTileTemperature_Public_get_Single_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_get_TileTemperature_Public_get_Single_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_InitializePropertyTile_Public_Void_Int32_Int32_Single_Grid_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_GridItem_FootprintTile_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_CanBeBuiltOn_Public_Virtual_New_Boolean_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingTiles_Public_List_1_Tile_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_IsIndoorTile_Public_Virtual_New_Boolean_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_OnCosmeticTemperatureEmittersChanged_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_OnTemperatureEmittersChanged_Private_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000947 RID: 2375
		public sealed class TileChange : MulticastDelegate
		{
			// Token: 0x0600D884 RID: 55428 RVA: 0x0035CB30 File Offset: 0x0035AD30
			// Note: this type is marked as 'beforefieldinit'.
			static TileChange()
			{
				Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Tile>.NativeClassPtr, "TileChange");
				Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100666927);
				Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100666928);
				Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100666929);
				Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr, 100666930);
			}

			// Token: 0x0600D885 RID: 55429 RVA: 0x0035CBA4 File Offset: 0x0035ADA4
			[CallerCount(329)]
			[CachedScanResults(RefRangeStart = 101484, RefRangeEnd = 101813, XrefRangeStart = 101474, XrefRangeEnd = 101484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TileChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Tile.TileChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D886 RID: 55430 RVA: 0x0035CC00 File Offset: 0x0035AE00
			[CallerCount(0)]
			public unsafe void Invoke(Tile thisTile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D887 RID: 55431 RVA: 0x0035CC44 File Offset: 0x0035AE44
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Tile thisTile, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisTile);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D888 RID: 55432 RVA: 0x0035CCB8 File Offset: 0x0035AEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tile.TileChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D889 RID: 55433 RVA: 0x00065D29 File Offset: 0x00063F29
			public TileChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D88A RID: 55434 RVA: 0x00065D32 File Offset: 0x00063F32
			public static implicit operator Tile.TileChange(Action<Tile> A_0)
			{
				return DelegateSupport.ConvertDelegate<Tile.TileChange>(A_0);
			}

			// Token: 0x0600D88B RID: 55435 RVA: 0x00065D3A File Offset: 0x00063F3A
			public static Tile.TileChange operator +(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Tile.TileChange>();
			}

			// Token: 0x0600D88C RID: 55436 RVA: 0x00065D48 File Offset: 0x00063F48
			public static Tile.TileChange operator -(Tile.TileChange A_0, Tile.TileChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Tile.TileChange>();
				}
				return result;
			}

			// Token: 0x040093A8 RID: 37800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040093A9 RID: 37801
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Tile_0;

			// Token: 0x040093AA RID: 37802
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Tile_AsyncCallback_Object_0;

			// Token: 0x040093AB RID: 37803
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
