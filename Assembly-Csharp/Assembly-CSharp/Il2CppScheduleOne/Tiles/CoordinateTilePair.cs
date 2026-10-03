using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000111 RID: 273
	[Serializable]
	public sealed class CoordinateTilePair : ValueType
	{
		// Token: 0x06001AB3 RID: 6835 RVA: 0x000D3648 File Offset: 0x000D1848
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateTilePair()
		{
			Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr);
			CoordinateTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "coord");
			CoordinateTilePair.NativeFieldInfoPtr_tile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr, "tile");
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0000E7F7 File Offset: 0x0000C9F7
		public CoordinateTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0000E800 File Offset: 0x0000CA00
		public CoordinateTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x000D36A0 File Offset: 0x000D18A0
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x0000E812 File Offset: 0x0000CA12
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x000D36D0 File Offset: 0x000D18D0
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x0000E831 File Offset: 0x0000CA31
		public unsafe Tile tile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateTilePair.NativeFieldInfoPtr_tile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400128C RID: 4748
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400128D RID: 4749
		private static readonly IntPtr NativeFieldInfoPtr_tile;
	}
}
