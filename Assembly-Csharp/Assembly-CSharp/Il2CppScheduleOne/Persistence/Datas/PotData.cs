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
	// Token: 0x02000253 RID: 595
	public class PotData : GrowContainerData
	{
		// Token: 0x06003038 RID: 12344 RVA: 0x0011AFE8 File Offset: 0x001191E8
		// Note: this type is marked as 'beforefieldinit'.
		static PotData()
		{
			Il2CppClassPointerStore<PotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotData>.NativeClassPtr);
			PotData.NativeFieldInfoPtr_PlantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "PlantData");
			PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotData>.NativeClassPtr, 100669434);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0011B040 File Offset: 0x00119240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135184, RefRangeEnd = 135186, XrefRangeStart = 135184, XrefRangeEnd = 135186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, Il2CppStringArray appliedAdditives, PlantData plantData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotData>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plantData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00018B98 File Offset: 0x00016D98
		public PotData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F65 RID: 3941
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0011B140 File Offset: 0x00119340
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x00018BA1 File Offset: 0x00016DA1
		public unsafe PlantData PlantData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002070 RID: 8304
		private static readonly IntPtr NativeFieldInfoPtr_PlantData;

		// Token: 0x04002071 RID: 8305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0;
	}
}
