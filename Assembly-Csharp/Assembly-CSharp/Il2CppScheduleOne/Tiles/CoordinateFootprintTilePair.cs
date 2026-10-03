using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000113 RID: 275
	[Serializable]
	public sealed class CoordinateFootprintTilePair : ValueType
	{
		// Token: 0x06001AC4 RID: 6852 RVA: 0x000D384C File Offset: 0x000D1A4C
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateFootprintTilePair()
		{
			Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateFootprintTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr);
			CoordinateFootprintTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "coord");
			CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr, "footprintTile");
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		public CoordinateFootprintTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0000E8CD File Offset: 0x0000CACD
		public CoordinateFootprintTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateFootprintTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06001AC7 RID: 6855 RVA: 0x000D38A4 File Offset: 0x000D1AA4
		// (set) Token: 0x06001AC8 RID: 6856 RVA: 0x0000E8DF File Offset: 0x0000CADF
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x000D38D4 File Offset: 0x000D1AD4
		// (set) Token: 0x06001ACA RID: 6858 RVA: 0x0000E8FE File Offset: 0x0000CAFE
		public unsafe FootprintTile footprintTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateFootprintTilePair.NativeFieldInfoPtr_footprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001292 RID: 4754
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x04001293 RID: 4755
		private static readonly IntPtr NativeFieldInfoPtr_footprintTile;
	}
}
