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
	// Token: 0x0200024B RID: 587
	public class GrowContainerData : GridItemData
	{
		// Token: 0x06002FF3 RID: 12275 RVA: 0x0011A15C File Offset: 0x0011835C
		// Note: this type is marked as 'beforefieldinit'.
		static GrowContainerData()
		{
			Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GrowContainerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr);
			GrowContainerData.NativeFieldInfoPtr_SoilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, "SoilID");
			GrowContainerData.NativeFieldInfoPtr_SoilLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, "SoilLevel");
			GrowContainerData.NativeFieldInfoPtr_RemainingSoilUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, "RemainingSoilUses");
			GrowContainerData.NativeFieldInfoPtr_WaterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, "WaterLevel");
			GrowContainerData.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, "AppliedAdditives");
			GrowContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, 100669425);
			GrowContainerData.NativeMethodInfoPtr_ConvertOldAdditiveFormatToNew_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr, 100669426);
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x0011A218 File Offset: 0x00118418
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 135119, RefRangeEnd = 135121, XrefRangeStart = 135110, XrefRangeEnd = 135119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowContainerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, Il2CppStringArray appliedAdditives) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowContainerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
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
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x0011A304 File Offset: 0x00118504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135150, RefRangeEnd = 135151, XrefRangeStart = 135121, XrefRangeEnd = 135150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertOldAdditiveFormatToNew()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowContainerData.NativeMethodInfoPtr_ConvertOldAdditiveFormatToNew_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000188C2 File Offset: 0x00016AC2
		public GrowContainerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06002FF7 RID: 12279 RVA: 0x0011A338 File Offset: 0x00118538
		// (set) Token: 0x06002FF8 RID: 12280 RVA: 0x000188CB File Offset: 0x00016ACB
		public unsafe string SoilID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_SoilID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_SoilID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06002FF9 RID: 12281 RVA: 0x0011A360 File Offset: 0x00118560
		// (set) Token: 0x06002FFA RID: 12282 RVA: 0x000188EA File Offset: 0x00016AEA
		public unsafe float SoilLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_SoilLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_SoilLevel)) = value;
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06002FFB RID: 12283 RVA: 0x0011A388 File Offset: 0x00118588
		// (set) Token: 0x06002FFC RID: 12284 RVA: 0x00018905 File Offset: 0x00016B05
		public unsafe int RemainingSoilUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_RemainingSoilUses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_RemainingSoilUses)) = value;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06002FFD RID: 12285 RVA: 0x0011A3B0 File Offset: 0x001185B0
		// (set) Token: 0x06002FFE RID: 12286 RVA: 0x00018920 File Offset: 0x00016B20
		public unsafe float WaterLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_WaterLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_WaterLevel)) = value;
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06002FFF RID: 12287 RVA: 0x0011A3D8 File Offset: 0x001185D8
		// (set) Token: 0x06003000 RID: 12288 RVA: 0x0001893B File Offset: 0x00016B3B
		public unsafe Il2CppStringArray AppliedAdditives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_AppliedAdditives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowContainerData.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002051 RID: 8273
		private static readonly IntPtr NativeFieldInfoPtr_SoilID;

		// Token: 0x04002052 RID: 8274
		private static readonly IntPtr NativeFieldInfoPtr_SoilLevel;

		// Token: 0x04002053 RID: 8275
		private static readonly IntPtr NativeFieldInfoPtr_RemainingSoilUses;

		// Token: 0x04002054 RID: 8276
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevel;

		// Token: 0x04002055 RID: 8277
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x04002056 RID: 8278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_0;

		// Token: 0x04002057 RID: 8279
		private static readonly IntPtr NativeMethodInfoPtr_ConvertOldAdditiveFormatToNew_Public_Void_0;
	}
}
