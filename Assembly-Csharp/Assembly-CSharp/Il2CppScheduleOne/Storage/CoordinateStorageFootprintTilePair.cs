using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200052F RID: 1327
	[Serializable]
	public sealed class CoordinateStorageFootprintTilePair : ValueType
	{
		// Token: 0x060078A6 RID: 30886 RVA: 0x002184DC File Offset: 0x002166DC
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr);
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x060078A7 RID: 30887 RVA: 0x000396B7 File Offset: 0x000378B7
		public CoordinateStorageFootprintTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060078A8 RID: 30888 RVA: 0x000396C0 File Offset: 0x000378C0
		public CoordinateStorageFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x060078A9 RID: 30889 RVA: 0x00218534 File Offset: 0x00216734
		// (set) Token: 0x060078AA RID: 30890 RVA: 0x000396D2 File Offset: 0x000378D2
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x060078AB RID: 30891 RVA: 0x00218564 File Offset: 0x00216764
		// (set) Token: 0x060078AC RID: 30892 RVA: 0x000396F1 File Offset: 0x000378F1
		public unsafe FootprintTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageFootprintTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005240 RID: 21056
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x04005241 RID: 21057
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
