using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000251 RID: 593
	[Serializable]
	public class PackagingStationData : GridItemData
	{
		// Token: 0x0600302E RID: 12334 RVA: 0x0011AD80 File Offset: 0x00118F80
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationData()
		{
			Il2CppClassPointerStore<PackagingStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagingStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationData>.NativeClassPtr);
			PackagingStationData.NativeFieldInfoPtr_Contents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationData>.NativeClassPtr, "Contents");
			PackagingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationData>.NativeClassPtr, 100669432);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0011ADD8 File Offset: 0x00118FD8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 135060, RefRangeEnd = 135067, XrefRangeStart = 135060, XrefRangeEnd = 135067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00018B48 File Offset: 0x00016D48
		public PackagingStationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06003031 RID: 12337 RVA: 0x0011AE84 File Offset: 0x00119084
		// (set) Token: 0x06003032 RID: 12338 RVA: 0x00018B51 File Offset: 0x00016D51
		public unsafe ItemSet Contents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationData.NativeFieldInfoPtr_Contents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationData.NativeFieldInfoPtr_Contents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400206C RID: 8300
		private static readonly IntPtr NativeFieldInfoPtr_Contents;

		// Token: 0x0400206D RID: 8301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_0;
	}
}
