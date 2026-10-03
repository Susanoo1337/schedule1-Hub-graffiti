using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000112 RID: 274
	[Serializable]
	public sealed class CoordinateProceduralTilePair : ValueType
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x000D3700 File Offset: 0x000D1900
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinateProceduralTilePair()
		{
			Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "CoordinateProceduralTilePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr);
			CoordinateProceduralTilePair.NativeFieldInfoPtr_coord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "coord");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileParent");
			CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, "tileIndex");
			CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr, 100666875);
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06001ABB RID: 6843 RVA: 0x000D3780 File Offset: 0x000D1980
		public unsafe ProceduralTile tile
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 100932, RefRangeEnd = 100940, XrefRangeStart = 100921, XrefRangeEnd = 100932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoordinateProceduralTilePair.NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralTile>(intPtr3) : null;
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0000E850 File Offset: 0x0000CA50
		public CoordinateProceduralTilePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0000E859 File Offset: 0x0000CA59
		public CoordinateProceduralTilePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoordinateProceduralTilePair>.NativeClassPtr))
		{
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x000D37C4 File Offset: 0x000D19C4
		// (set) Token: 0x06001ABF RID: 6847 RVA: 0x0000E86B File Offset: 0x0000CA6B
		public unsafe Coordinate coord
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coordinate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_coord), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x000D37F4 File Offset: 0x000D19F4
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0000E88A File Offset: 0x0000CA8A
		public unsafe NetworkObject tileParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x000D3824 File Offset: 0x000D1A24
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0000E8A9 File Offset: 0x0000CAA9
		public unsafe int tileIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CoordinateProceduralTilePair.NativeFieldInfoPtr_tileIndex)) = value;
			}
		}

		// Token: 0x0400128E RID: 4750
		private static readonly IntPtr NativeFieldInfoPtr_coord;

		// Token: 0x0400128F RID: 4751
		private static readonly IntPtr NativeFieldInfoPtr_tileParent;

		// Token: 0x04001290 RID: 4752
		private static readonly IntPtr NativeFieldInfoPtr_tileIndex;

		// Token: 0x04001291 RID: 4753
		private static readonly IntPtr NativeMethodInfoPtr_get_tile_Public_get_ProceduralTile_0;
	}
}
