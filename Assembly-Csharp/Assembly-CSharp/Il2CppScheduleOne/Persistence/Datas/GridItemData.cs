using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200024A RID: 586
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x06002FEA RID: 12266 RVA: 0x00119FCC File Offset: 0x001181CC
		// Note: this type is marked as 'beforefieldinit'.
		static GridItemData()
		{
			Il2CppClassPointerStore<GridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItemData>.NativeClassPtr);
			GridItemData.NativeFieldInfoPtr_GridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "GridGUID");
			GridItemData.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "OriginCoordinate");
			GridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "Rotation");
			GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, 100669424);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x0011A04C File Offset: 0x0011824C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135109, RefRangeEnd = 135110, XrefRangeStart = 135103, XrefRangeEnd = 135109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00018864 File Offset: 0x00016A64
		public GridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x0011A0E4 File Offset: 0x001182E4
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x0001886D File Offset: 0x00016A6D
		public unsafe string GridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06002FEF RID: 12271 RVA: 0x0011A10C File Offset: 0x0011830C
		// (set) Token: 0x06002FF0 RID: 12272 RVA: 0x0001888C File Offset: 0x00016A8C
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x0011A134 File Offset: 0x00118334
		// (set) Token: 0x06002FF2 RID: 12274 RVA: 0x000188A7 File Offset: 0x00016AA7
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x0400204D RID: 8269
		private static readonly IntPtr NativeFieldInfoPtr_GridGUID;

		// Token: 0x0400204E RID: 8270
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x0400204F RID: 8271
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04002050 RID: 8272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0;
	}
}
