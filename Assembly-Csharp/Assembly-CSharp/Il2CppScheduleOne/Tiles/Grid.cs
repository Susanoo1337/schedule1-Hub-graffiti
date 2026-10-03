using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Temperature;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000116 RID: 278
	public class Grid : MonoBehaviour
	{
		// Token: 0x06001AE8 RID: 6888 RVA: 0x000D3E38 File Offset: 0x000D2038
		// Note: this type is marked as 'beforefieldinit'.
		static Grid()
		{
			Il2CppClassPointerStore<Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grid>.NativeClassPtr);
			Grid.NativeFieldInfoPtr_TileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "TileSize");
			Grid.NativeFieldInfoPtr_Tiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "Tiles");
			Grid.NativeFieldInfoPtr_CoordinateTilePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "CoordinateTilePairs");
			Grid.NativeFieldInfoPtr__parentProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_parentProperty");
			Grid.NativeFieldInfoPtr__guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_guid");
			Grid.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<GUID>k__BackingField");
			Grid.NativeFieldInfoPtr_OnCosmeticTemperatureEmittersChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "OnCosmeticTemperatureEmittersChanged");
			Grid.NativeFieldInfoPtr_OnTemperatureEmittersChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "OnTemperatureEmittersChanged");
			Grid.NativeFieldInfoPtr__TemperatureEmitterInfos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<TemperatureEmitterInfos>k__BackingField");
			Grid.NativeFieldInfoPtr__coordinateToTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_coordinateToTile");
			Grid.NativeFieldInfoPtr__cosmeticTemperatureEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_cosmeticTemperatureEmitters");
			Grid.NativeFieldInfoPtr__temperatureEmitters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_temperatureEmitters");
			Grid.NativeFieldInfoPtr__Width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<Width>k__BackingField");
			Grid.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "<Height>k__BackingField");
			Grid.NativeFieldInfoPtr__cosmeticEmittersChangedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_cosmeticEmittersChangedThisFrame");
			Grid.NativeFieldInfoPtr__emittersChangedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grid>.NativeClassPtr, "_emittersChangedThisFrame");
			Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666883);
			Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666884);
			Grid.NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666885);
			Grid.NativeMethodInfoPtr_get_Container_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666886);
			Grid.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666887);
			Grid.NativeMethodInfoPtr_get_TemperatureEmitterInfos_Public_get_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666888);
			Grid.NativeMethodInfoPtr_set_TemperatureEmitterInfos_Private_set_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666889);
			Grid.NativeMethodInfoPtr_get_Width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666890);
			Grid.NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666891);
			Grid.NativeMethodInfoPtr_get_Height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666892);
			Grid.NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666893);
			Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666894);
			Grid.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666895);
			Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666896);
			Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666897);
			Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666898);
			Grid.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666899);
			Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666900);
			Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666901);
			Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666902);
			Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666903);
			Grid.NativeMethodInfoPtr_AddTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666904);
			Grid.NativeMethodInfoPtr_RemoveTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666905);
			Grid.NativeMethodInfoPtr_CosmeticTemperatureEmittersChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666906);
			Grid.NativeMethodInfoPtr_TemperatureEmittersChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666907);
			Grid.NativeMethodInfoPtr_SetGridSize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666908);
			Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grid>.NativeClassPtr, 100666909);
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000D41C4 File Offset: 0x000D23C4
		// (set) Token: 0x06001AEA RID: 6890 RVA: 0x000D4200 File Offset: 0x000D2400
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000D4240 File Offset: 0x000D2440
		public unsafe Property ParentProperty
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x000D4280 File Offset: 0x000D2480
		public unsafe Transform Container
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 101084, RefRangeEnd = 101085, XrefRangeStart = 101082, XrefRangeEnd = 101084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_Container_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x000D42C0 File Offset: 0x000D24C0
		public unsafe Vector3 Origin
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 101087, RefRangeEnd = 101108, XrefRangeStart = 101085, XrefRangeEnd = 101087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x000D42FC File Offset: 0x000D24FC
		// (set) Token: 0x06001AEF RID: 6895 RVA: 0x000D433C File Offset: 0x000D253C
		public unsafe Il2CppStructArray<TemperatureEmitterInfo> TemperatureEmitterInfos
		{
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 43093, RefRangeEnd = 43137, XrefRangeStart = 43093, XrefRangeEnd = 43137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_TemperatureEmitterInfos_Public_get_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TemperatureEmitterInfo>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_TemperatureEmitterInfos_Private_set_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x000D4380 File Offset: 0x000D2580
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x000D43BC File Offset: 0x000D25BC
		public unsafe int Width
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_Width_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x000D43FC File Offset: 0x000D25FC
		// (set) Token: 0x06001AF3 RID: 6899 RVA: 0x000D4438 File Offset: 0x000D2638
		public unsafe int Height
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_get_Height_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x000D4478 File Offset: 0x000D2678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101108, XrefRangeEnd = 101144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Grid.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000D44B4 File Offset: 0x000D26B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101144, XrefRangeEnd = 101175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x000D44E8 File Offset: 0x000D26E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101192, RefRangeEnd = 101193, XrefRangeStart = 101175, XrefRangeEnd = 101192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessCoordinateDataPairs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000D451C File Offset: 0x000D271C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101193, XrefRangeEnd = 101207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x000D4560 File Offset: 0x000D2760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101207, XrefRangeEnd = 101233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeregisterTile(Tile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x000D45A4 File Offset: 0x000D27A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101233, XrefRangeEnd = 101236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x000D45D8 File Offset: 0x000D27D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101236, XrefRangeEnd = 101240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x000D4618 File Offset: 0x000D2818
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101250, RefRangeEnd = 101253, XrefRangeStart = 101240, XrefRangeEnd = 101250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tileToMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr3) : null;
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x000D4668 File Offset: 0x000D2868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101264, RefRangeEnd = 101265, XrefRangeStart = 101253, XrefRangeEnd = 101264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, GridItem tileOwner = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gridCoord);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tileOwner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x000D46DC File Offset: 0x000D28DC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 101271, RefRangeEnd = 101299, XrefRangeStart = 101265, XrefRangeEnd = 101271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetTile(Coordinate coord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(coord);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x000D472C File Offset: 0x000D292C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101328, RefRangeEnd = 101331, XrefRangeStart = 101299, XrefRangeEnd = 101328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emitter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyCosmetic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_AddTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x000D477C File Offset: 0x000D297C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 101360, RefRangeEnd = 101363, XrefRangeStart = 101331, XrefRangeEnd = 101360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(emitter);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlyCosmetic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_RemoveTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x000D47CC File Offset: 0x000D29CC
		[CallerCount(0)]
		public unsafe void CosmeticTemperatureEmittersChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_CosmeticTemperatureEmittersChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x000D4800 File Offset: 0x000D2A00
		[CallerCount(0)]
		public unsafe void TemperatureEmittersChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_TemperatureEmittersChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x000D4834 File Offset: 0x000D2A34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101377, RefRangeEnd = 101378, XrefRangeStart = 101363, XrefRangeEnd = 101377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGridSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr_SetGridSize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x000D4868 File Offset: 0x000D2A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101378, XrefRangeEnd = 101415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0000EA3A File Offset: 0x0000CC3A
		public Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x000D48A4 File Offset: 0x000D2AA4
		// (set) Token: 0x06001B06 RID: 6918 RVA: 0x0000EA43 File Offset: 0x0000CC43
		public unsafe static float TileSize
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Grid.NativeFieldInfoPtr_TileSize, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Grid.NativeFieldInfoPtr_TileSize, (void*)(&value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x000D48C0 File Offset: 0x000D2AC0
		// (set) Token: 0x06001B08 RID: 6920 RVA: 0x0000EA51 File Offset: 0x0000CC51
		public unsafe List<Tile> Tiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_Tiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x000D48F0 File Offset: 0x000D2AF0
		// (set) Token: 0x06001B0A RID: 6922 RVA: 0x0000EA70 File Offset: 0x0000CC70
		public unsafe List<CoordinateTilePair> CoordinateTilePairs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CoordinateTilePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_CoordinateTilePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x000D4920 File Offset: 0x000D2B20
		// (set) Token: 0x06001B0C RID: 6924 RVA: 0x0000EA8F File Offset: 0x0000CC8F
		public unsafe Property _parentProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__parentProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__parentProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x000D4950 File Offset: 0x000D2B50
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x0000EAAE File Offset: 0x0000CCAE
		public unsafe string _guid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__guid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__guid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001B0F RID: 6927 RVA: 0x000D4978 File Offset: 0x000D2B78
		// (set) Token: 0x06001B10 RID: 6928 RVA: 0x0000EACD File Offset: 0x0000CCCD
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x000D49A0 File Offset: 0x000D2BA0
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public unsafe Action<string, Il2CppStructArray<TemperatureEmitterInfo>> OnCosmeticTemperatureEmittersChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_OnCosmeticTemperatureEmittersChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Il2CppStructArray<TemperatureEmitterInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_OnCosmeticTemperatureEmittersChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x000D49D0 File Offset: 0x000D2BD0
		// (set) Token: 0x06001B14 RID: 6932 RVA: 0x0000EB07 File Offset: 0x0000CD07
		public unsafe Action<Il2CppStructArray<TemperatureEmitterInfo>> OnTemperatureEmittersChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_OnTemperatureEmittersChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStructArray<TemperatureEmitterInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr_OnTemperatureEmittersChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001B15 RID: 6933 RVA: 0x000D4A00 File Offset: 0x000D2C00
		// (set) Token: 0x06001B16 RID: 6934 RVA: 0x0000EB26 File Offset: 0x0000CD26
		public unsafe Il2CppStructArray<TemperatureEmitterInfo> _TemperatureEmitterInfos_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__TemperatureEmitterInfos_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TemperatureEmitterInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__TemperatureEmitterInfos_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001B17 RID: 6935 RVA: 0x000D4A30 File Offset: 0x000D2C30
		// (set) Token: 0x06001B18 RID: 6936 RVA: 0x0000EB45 File Offset: 0x0000CD45
		public unsafe Dictionary<Coordinate, Tile> _coordinateToTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Coordinate, Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__coordinateToTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x000D4A60 File Offset: 0x000D2C60
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0000EB64 File Offset: 0x0000CD64
		public unsafe List<TemperatureEmitter> _cosmeticTemperatureEmitters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__cosmeticTemperatureEmitters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemperatureEmitter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__cosmeticTemperatureEmitters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x000D4A90 File Offset: 0x000D2C90
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0000EB83 File Offset: 0x0000CD83
		public unsafe List<TemperatureEmitter> _temperatureEmitters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__temperatureEmitters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TemperatureEmitter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__temperatureEmitters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x000D4AC0 File Offset: 0x000D2CC0
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0000EBA2 File Offset: 0x0000CDA2
		public unsafe int _Width_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__Width_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__Width_k__BackingField)) = value;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x000D4AE8 File Offset: 0x000D2CE8
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0000EBBD File Offset: 0x0000CDBD
		public unsafe int _Height_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__Height_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__Height_k__BackingField)) = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001B21 RID: 6945 RVA: 0x000D4B10 File Offset: 0x000D2D10
		// (set) Token: 0x06001B22 RID: 6946 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		public unsafe bool _cosmeticEmittersChangedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__cosmeticEmittersChangedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__cosmeticEmittersChangedThisFrame)) = value;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001B23 RID: 6947 RVA: 0x000D4B38 File Offset: 0x000D2D38
		// (set) Token: 0x06001B24 RID: 6948 RVA: 0x0000EBF3 File Offset: 0x0000CDF3
		public unsafe bool _emittersChangedThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__emittersChangedThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Grid.NativeFieldInfoPtr__emittersChangedThisFrame)) = value;
			}
		}

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeFieldInfoPtr_TileSize;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeFieldInfoPtr_Tiles;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeFieldInfoPtr_CoordinateTilePairs;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeFieldInfoPtr__parentProperty;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeFieldInfoPtr__guid;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeFieldInfoPtr_OnCosmeticTemperatureEmittersChanged;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeFieldInfoPtr_OnTemperatureEmittersChanged;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr__TemperatureEmitterInfos_k__BackingField;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr__coordinateToTile;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr__cosmeticTemperatureEmitters;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr__temperatureEmitters;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr__Width_k__BackingField;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr__Height_k__BackingField;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr__cosmeticEmittersChangedThisFrame;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr__emittersChangedThisFrame;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentProperty_Public_get_Property_0;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeMethodInfoPtr_get_Container_Public_get_Transform_0;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_get_Origin_Public_get_Vector3_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_get_TemperatureEmitterInfos_Public_get_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_set_TemperatureEmitterInfos_Private_set_Void_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr_get_Width_Public_get_Int32_0;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_set_Width_Private_set_Void_Int32_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_get_Height_Public_get_Int32_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_set_Height_Private_set_Void_Int32_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_ProcessCoordinateDataPairs_Private_Void_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_RegisterTile_Public_Void_Tile_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_DeregisterTile_Public_Void_Tile_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchedCoordinate_Public_Coordinate_FootprintTile_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_IsTileValidAtCoordinate_Public_Boolean_Coordinate_FootprintTile_GridItem_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_GetTile_Public_Tile_Coordinate_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_AddTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTemperatureEmitter_Public_Void_TemperatureEmitter_Boolean_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_CosmeticTemperatureEmittersChanged_Private_Void_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_TemperatureEmittersChanged_Private_Void_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_SetGridSize_Private_Void_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
