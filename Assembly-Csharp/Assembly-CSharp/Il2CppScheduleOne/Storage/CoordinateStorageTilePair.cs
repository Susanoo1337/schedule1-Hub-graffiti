using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000529 RID: 1321
	[Serializable]
	public sealed class CoordinateStorageTilePair : ValueType
	{
		// Token: 0x06007834 RID: 30772 RVA: 0x00216CDC File Offset: 0x00214EDC
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateStorageTilePair()
		{
			Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "CoordinateStorageTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr);
			CoordinateStorageTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "coord");
			CoordinateStorageTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x0003934D File Offset: 0x0003754D
		public CoordinateStorageTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x00039356 File Offset: 0x00037556
		public CoordinateStorageTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateStorageTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x06007837 RID: 30775 RVA: 0x00216D34 File Offset: 0x00214F34
		// (set) Token: 0x06007838 RID: 30776 RVA: 0x00039368 File Offset: 0x00037568
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x06007839 RID: 30777 RVA: 0x00216D64 File Offset: 0x00214F64
		// (set) Token: 0x0600783A RID: 30778 RVA: 0x00039387 File Offset: 0x00037587
		public unsafe StorageTile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateStorageTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051F5 RID: 20981
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x040051F6 RID: 20982
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
