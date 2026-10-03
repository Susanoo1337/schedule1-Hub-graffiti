using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000255 RID: 597
	public class SoilPourerData : GridItemData
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x0011B2BC File Offset: 0x001194BC
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourerData()
		{
			Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SoilPourerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr);
			SoilPourerData.NativeFieldInfoPtr_SoilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr, "SoilID");
			SoilPourerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr, 100669436);
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0011B314 File Offset: 0x00119514
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 135060, RefRangeEnd = 135067, XrefRangeStart = 135060, XrefRangeEnd = 135067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00018C03 File Offset: 0x00016E03
		public SoilPourerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06003047 RID: 12359 RVA: 0x0011B3C0 File Offset: 0x001195C0
		// (set) Token: 0x06003048 RID: 12360 RVA: 0x00018C0C File Offset: 0x00016E0C
		public unsafe string SoilID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourerData.NativeFieldInfoPtr_SoilID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourerData.NativeFieldInfoPtr_SoilID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002075 RID: 8309
		private static readonly IntPtr NativeFieldInfoPtr_SoilID;

		// Token: 0x04002076 RID: 8310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0;
	}
}
