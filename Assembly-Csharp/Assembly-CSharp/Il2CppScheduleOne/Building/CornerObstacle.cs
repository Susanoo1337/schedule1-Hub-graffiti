using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000468 RID: 1128
	public class CornerObstacle : MonoBehaviour
	{
		// Token: 0x060065ED RID: 26093 RVA: 0x001DC8E8 File Offset: 0x001DAAE8
		// Note: this type is marked as 'beforefieldinit'.
		static CornerObstacle()
		{
			Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "CornerObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr);
			CornerObstacle.NativeFieldInfoPtr_obstacleEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "obstacleEnabled");
			CornerObstacle.NativeFieldInfoPtr_parentFootprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "parentFootprint");
			CornerObstacle.NativeFieldInfoPtr_coordinates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, "coordinates");
			CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676668);
			CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676669);
			CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr, 100676670);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x001DC990 File Offset: 0x001DAB90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213362, RefRangeEnd = 213364, XrefRangeStart = 213332, XrefRangeEnd = 213362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tile> GetNeighbourTiles(Tile pairedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tile>>(intPtr3) : null;
		}

		// Token: 0x060065EF RID: 26095 RVA: 0x001DC9E0 File Offset: 0x001DABE0
		[CallerCount(0)]
		public unsafe bool ApproxEquals(float a, float b, float precision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x001DCA48 File Offset: 0x001DAC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213364, XrefRangeEnd = 213367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CornerObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CornerObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CornerObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065F1 RID: 26097 RVA: 0x0002FFD5 File Offset: 0x0002E1D5
		public CornerObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x060065F2 RID: 26098 RVA: 0x001DCA84 File Offset: 0x001DAC84
		// (set) Token: 0x060065F3 RID: 26099 RVA: 0x0002FFDE File Offset: 0x0002E1DE
		public unsafe bool obstacleEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_obstacleEnabled)) = value;
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x060065F4 RID: 26100 RVA: 0x001DCAAC File Offset: 0x001DACAC
		// (set) Token: 0x060065F5 RID: 26101 RVA: 0x0002FFF9 File Offset: 0x0002E1F9
		public unsafe FootprintTile parentFootprint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_parentFootprint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x060065F6 RID: 26102 RVA: 0x001DCADC File Offset: 0x001DACDC
		// (set) Token: 0x060065F7 RID: 26103 RVA: 0x00030018 File Offset: 0x0002E218
		public unsafe Vector2 coordinates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CornerObstacle.NativeFieldInfoPtr_coordinates)) = value;
			}
		}

		// Token: 0x04004639 RID: 17977
		private static readonly IntPtr NativeFieldInfoPtr_obstacleEnabled;

		// Token: 0x0400463A RID: 17978
		private static readonly IntPtr NativeFieldInfoPtr_parentFootprint;

		// Token: 0x0400463B RID: 17979
		private static readonly IntPtr NativeFieldInfoPtr_coordinates;

		// Token: 0x0400463C RID: 17980
		private static readonly IntPtr NativeMethodInfoPtr_GetNeighbourTiles_Public_List_1_Tile_Tile_0;

		// Token: 0x0400463D RID: 17981
		private static readonly IntPtr NativeMethodInfoPtr_ApproxEquals_Private_Boolean_Single_Single_Single_0;

		// Token: 0x0400463E RID: 17982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
