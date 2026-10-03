using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000118 RID: 280
	public class ProceduralTile : MonoBehaviour
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x000D4B9C File Offset: 0x000D2D9C
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralTile()
		{
			Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "ProceduralTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr);
			ProceduralTile.NativeFieldInfoPtr_TileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "TileType");
			ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "ParentBuildableItem");
			ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "MatchedFootprintTile");
			ProceduralTile.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "Occupants");
			ProceduralTile.NativeFieldInfoPtr_OccupantTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, "OccupantTiles");
			ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100666911);
			ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100666912);
			ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100666913);
			ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr, 100666914);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x000D4C80 File Offset: 0x000D2E80
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000D4CBC File Offset: 0x000D2EBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101444, RefRangeEnd = 101445, XrefRangeStart = 101430, XrefRangeEnd = 101444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000D4D10 File Offset: 0x000D2F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 101457, RefRangeEnd = 101459, XrefRangeStart = 101445, XrefRangeEnd = 101457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOccupant(FootprintTile footprint, ProceduralGridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(footprint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000D4D64 File Offset: 0x000D2F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101459, XrefRangeEnd = 101474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x0000EC50 File Offset: 0x0000CE50
		public ProceduralTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x000D4DA0 File Offset: 0x000D2FA0
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0000EC59 File Offset: 0x0000CE59
		public unsafe ProceduralTile.EProceduralTileType TileType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_TileType)) = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x000D4DC8 File Offset: 0x000D2FC8
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0000EC74 File Offset: 0x0000CE74
		public unsafe BuildableItem ParentBuildableItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_ParentBuildableItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x000D4DF8 File Offset: 0x000D2FF8
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0000EC93 File Offset: 0x0000CE93
		public unsafe FootprintTile MatchedFootprintTile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FootprintTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_MatchedFootprintTile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x000D4E28 File Offset: 0x000D3028
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0000ECB2 File Offset: 0x0000CEB2
		public unsafe List<ProceduralGridItem> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralGridItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x000D4E58 File Offset: 0x000D3058
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0000ECD1 File Offset: 0x0000CED1
		public unsafe List<FootprintTile> OccupantTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FootprintTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProceduralTile.NativeFieldInfoPtr_OccupantTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeFieldInfoPtr_TileType;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeFieldInfoPtr_ParentBuildableItem;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeFieldInfoPtr_MatchedFootprintTile;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_OccupantTiles;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_AddOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_RemoveOccupant_Public_Void_FootprintTile_ProceduralGridItem_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000946 RID: 2374
		[OriginalName("Assembly-CSharp.dll", "", "EProceduralTileType")]
		public enum EProceduralTileType
		{
			// Token: 0x040093A7 RID: 37799
			Rack
		}
	}
}
