using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x0200011D RID: 285
	public class TileDetector : MonoBehaviour
	{
		// Token: 0x06001B6E RID: 7022 RVA: 0x000D58DC File Offset: 0x000D3ADC
		// Note: this type is marked as 'beforefieldinit'.
		static TileDetector()
		{
			Il2CppClassPointerStore<TileDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "TileDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileDetector>.NativeClassPtr);
			TileDetector.NativeFieldInfoPtr_detectionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "detectionRadius");
			TileDetector.NativeFieldInfoPtr_tileDetectionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "tileDetectionMode");
			TileDetector.NativeFieldInfoPtr_intersectedTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedTiles");
			TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedOutdoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedIndoorTiles");
			TileDetector.NativeFieldInfoPtr_intersectedStorageTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedStorageTiles");
			TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, "intersectedProceduralTiles");
			TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666935);
			TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666936);
			TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666937);
			TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666938);
			TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666939);
			TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileDetector>.NativeClassPtr, 100666940);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x000D5A10 File Offset: 0x000D3C10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101931, XrefRangeEnd = 102028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections(bool sort = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TileDetector.NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x000D5A5C File Offset: 0x000D3C5C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 102034, RefRangeEnd = 102039, XrefRangeStart = 102028, XrefRangeEnd = 102034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> OrderList<T>(List<T> list) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000D5AAC File Offset: 0x000D3CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102039, XrefRangeEnd = 102062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tile GetClosestTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestTile_Public_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000D5AEC File Offset: 0x000D3CEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 102085, RefRangeEnd = 102087, XrefRangeStart = 102062, XrefRangeEnd = 102085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile GetClosestProceduralTile()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000D5B2C File Offset: 0x000D3D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102087, XrefRangeEnd = 102119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TileDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000D5B68 File Offset: 0x000D3D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102119, XrefRangeEnd = 102128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _OrderList_b__8_0<T>(T x) where T : MonoBehaviour
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = x;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref x;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TileDetector.MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000EEFD File Offset: 0x0000D0FD
		public TileDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000D5C00 File Offset: 0x000D3E00
		// (set) Token: 0x06001B77 RID: 7031 RVA: 0x0000EF06 File Offset: 0x0000D106
		public unsafe float detectionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_detectionRadius)) = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x000D5C28 File Offset: 0x000D3E28
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000EF21 File Offset: 0x0000D121
		public unsafe ETileDetectionMode tileDetectionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_tileDetectionMode)) = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x000D5C50 File Offset: 0x000D3E50
		// (set) Token: 0x06001B7B RID: 7035 RVA: 0x0000EF3C File Offset: 0x0000D13C
		public unsafe List<Tile> intersectedTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000D5C80 File Offset: 0x000D3E80
		// (set) Token: 0x06001B7D RID: 7037 RVA: 0x0000EF5B File Offset: 0x0000D15B
		public unsafe List<Tile> intersectedOutdoorTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedOutdoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001B7E RID: 7038 RVA: 0x000D5CB0 File Offset: 0x000D3EB0
		// (set) Token: 0x06001B7F RID: 7039 RVA: 0x0000EF7A File Offset: 0x0000D17A
		public unsafe List<Tile> intersectedIndoorTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedIndoorTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000D5CE0 File Offset: 0x000D3EE0
		// (set) Token: 0x06001B81 RID: 7041 RVA: 0x0000EF99 File Offset: 0x0000D199
		public unsafe List<StorageTile> intersectedStorageTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StorageTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedStorageTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000D5D10 File Offset: 0x000D3F10
		// (set) Token: 0x06001B83 RID: 7043 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		public unsafe List<ProceduralTile> intersectedProceduralTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TileDetector.NativeFieldInfoPtr_intersectedProceduralTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_detectionRadius;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_tileDetectionMode;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_intersectedTiles;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_intersectedOutdoorTiles;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_intersectedIndoorTiles;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeFieldInfoPtr_intersectedStorageTiles;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeFieldInfoPtr_intersectedProceduralTiles;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestTile_Public_Tile_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestProceduralTile_Public_ProceduralTile_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0;

		// Token: 0x02000948 RID: 2376
		private sealed class MethodInfoStoreGeneric_OrderList_Public_List_1_T_List_1_T_0<T>
		{
			// Token: 0x040093AC RID: 37804
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr_OrderList_Public_List_1_T_List_1_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000949 RID: 2377
		private sealed class MethodInfoStoreGeneric__OrderList_b__8_0_Private_Single_T_0<T>
		{
			// Token: 0x040093AD RID: 37805
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TileDetector.NativeMethodInfoPtr__OrderList_b__8_0_Private_Single_T_0, Il2CppClassPointerStore<TileDetector>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
