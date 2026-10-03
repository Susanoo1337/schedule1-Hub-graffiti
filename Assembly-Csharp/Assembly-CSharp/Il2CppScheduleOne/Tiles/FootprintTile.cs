using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tiles
{
	// Token: 0x02000115 RID: 277
	public class FootprintTile : MonoBehaviour
	{
		// Token: 0x06001AD2 RID: 6866 RVA: 0x000D3A30 File Offset: 0x000D1C30
		// Note: this type is marked as 'beforefieldinit'.
		static FootprintTile()
		{
			Il2CppClassPointerStore<FootprintTile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tiles", "FootprintTile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr);
			FootprintTile.NativeFieldInfoPtr_tileAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileAppearance");
			FootprintTile.NativeFieldInfoPtr_tileDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "tileDetector");
			FootprintTile.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "X");
			FootprintTile.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Y");
			FootprintTile.NativeFieldInfoPtr_RequiredOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "RequiredOffset");
			FootprintTile.NativeFieldInfoPtr_Corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "Corners");
			FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, "<MatchedStandardTile>k__BackingField");
			FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666877);
			FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666878);
			FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666879);
			FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666880);
			FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666881);
			FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr, 100666882);
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001AD3 RID: 6867 RVA: 0x000D3B64 File Offset: 0x000D1D64
		// (set) Token: 0x06001AD4 RID: 6868 RVA: 0x000D3BA4 File Offset: 0x000D1DA4
		public unsafe Tile MatchedStandardTile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x000D3BE8 File Offset: 0x000D1DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100996, XrefRangeEnd = 101001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000D3C24 File Offset: 0x000D1E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Tile matchedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootprintTile.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000D3C74 File Offset: 0x000D1E74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 101073, RefRangeEnd = 101074, XrefRangeStart = 101001, XrefRangeEnd = 101073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreCornerObstaclesBlocked(Tile proposedTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(proposedTile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x000D3CC4 File Offset: 0x000D1EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101074, XrefRangeEnd = 101082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootprintTile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootprintTile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootprintTile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0000E964 File Offset: 0x0000CB64
		public FootprintTile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x000D3D00 File Offset: 0x000D1F00
		// (set) Token: 0x06001ADB RID: 6875 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public unsafe TileAppearance tileAppearance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileAppearance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileAppearance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x000D3D30 File Offset: 0x000D1F30
		// (set) Token: 0x06001ADD RID: 6877 RVA: 0x0000E98C File Offset: 0x0000CB8C
		public unsafe TileDetector tileDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_tileDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x000D3D60 File Offset: 0x000D1F60
		// (set) Token: 0x06001ADF RID: 6879 RVA: 0x0000E9AB File Offset: 0x0000CBAB
		public unsafe int X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_X)) = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x000D3D88 File Offset: 0x000D1F88
		// (set) Token: 0x06001AE1 RID: 6881 RVA: 0x0000E9C6 File Offset: 0x0000CBC6
		public unsafe int Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Y)) = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x000D3DB0 File Offset: 0x000D1FB0
		// (set) Token: 0x06001AE3 RID: 6883 RVA: 0x0000E9E1 File Offset: 0x0000CBE1
		public unsafe float RequiredOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_RequiredOffset)) = value;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001AE4 RID: 6884 RVA: 0x000D3DD8 File Offset: 0x000D1FD8
		// (set) Token: 0x06001AE5 RID: 6885 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public unsafe List<CornerObstacle> Corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CornerObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr_Corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001AE6 RID: 6886 RVA: 0x000D3E08 File Offset: 0x000D2008
		// (set) Token: 0x06001AE7 RID: 6887 RVA: 0x0000EA1B File Offset: 0x0000CC1B
		public unsafe Tile _MatchedStandardTile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootprintTile.NativeFieldInfoPtr__MatchedStandardTile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_tileAppearance;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_tileDetector;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeFieldInfoPtr_RequiredOffset;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeFieldInfoPtr_Corners;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeFieldInfoPtr__MatchedStandardTile_k__BackingField;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchedStandardTile_Public_get_Tile_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_set_MatchedStandardTile_Protected_set_Void_Tile_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Tile_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_AreCornerObstaclesBlocked_Public_Boolean_Tile_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
