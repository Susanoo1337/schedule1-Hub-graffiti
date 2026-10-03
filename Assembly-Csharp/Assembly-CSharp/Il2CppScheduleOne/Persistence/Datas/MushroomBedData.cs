using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000250 RID: 592
	public class MushroomBedData : GrowContainerData
	{
		// Token: 0x06003029 RID: 12329 RVA: 0x0011ABF8 File Offset: 0x00118DF8
		// Note: this type is marked as 'beforefieldinit'.
		static MushroomBedData()
		{
			Il2CppClassPointerStore<MushroomBedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MushroomBedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MushroomBedData>.NativeClassPtr);
			MushroomBedData.NativeFieldInfoPtr_ShroomColonyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MushroomBedData>.NativeClassPtr, "ShroomColonyData");
			MushroomBedData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_ShroomColonyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MushroomBedData>.NativeClassPtr, 100669431);
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x0011AC50 File Offset: 0x00118E50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135184, RefRangeEnd = 135186, XrefRangeStart = 135182, XrefRangeEnd = 135184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MushroomBedData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, Il2CppStringArray appliedAdditives, ShroomColonyData colonyData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MushroomBedData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingSoilUses;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waterLevel;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appliedAdditives);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(colonyData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MushroomBedData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_ShroomColonyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x00018B20 File Offset: 0x00016D20
		public MushroomBedData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x0011AD50 File Offset: 0x00118F50
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x00018B29 File Offset: 0x00016D29
		public unsafe ShroomColonyData ShroomColonyData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedData.NativeFieldInfoPtr_ShroomColonyData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShroomColonyData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MushroomBedData.NativeFieldInfoPtr_ShroomColonyData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400206A RID: 8298
		private static readonly IntPtr NativeFieldInfoPtr_ShroomColonyData;

		// Token: 0x0400206B RID: 8299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_ShroomColonyData_0;
	}
}
