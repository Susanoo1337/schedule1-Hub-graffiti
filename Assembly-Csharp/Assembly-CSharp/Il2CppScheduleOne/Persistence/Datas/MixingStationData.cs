using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200024F RID: 591
	public class MixingStationData : GridItemData
	{
		// Token: 0x0600301C RID: 12316 RVA: 0x0011A974 File Offset: 0x00118B74
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationData()
		{
			Il2CppClassPointerStore<MixingStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr);
			MixingStationData.NativeFieldInfoPtr_ProductContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "ProductContents");
			MixingStationData.NativeFieldInfoPtr_MixerContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "MixerContents");
			MixingStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "OutputContents");
			MixingStationData.NativeFieldInfoPtr_CurrentMixOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixOperation");
			MixingStationData.NativeFieldInfoPtr_CurrentMixTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, "CurrentMixTime");
			MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr, 100669430);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x0011AA1C File Offset: 0x00118C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135181, RefRangeEnd = 135182, XrefRangeStart = 135171, XrefRangeEnd = 135181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet productContents, ItemSet mixerContents, ItemSet outputContents, MixOperation currentMixOperation, int currentMixTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(productContents);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixerContents);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentMixOperation);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentMixTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00018A80 File Offset: 0x00016C80
		public MixingStationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x0600301F RID: 12319 RVA: 0x0011AB10 File Offset: 0x00118D10
		// (set) Token: 0x06003020 RID: 12320 RVA: 0x00018A89 File Offset: 0x00016C89
		public unsafe ItemSet ProductContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_ProductContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06003021 RID: 12321 RVA: 0x0011AB40 File Offset: 0x00118D40
		// (set) Token: 0x06003022 RID: 12322 RVA: 0x00018AA8 File Offset: 0x00016CA8
		public unsafe ItemSet MixerContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_MixerContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x0011AB70 File Offset: 0x00118D70
		// (set) Token: 0x06003024 RID: 12324 RVA: 0x00018AC7 File Offset: 0x00016CC7
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x0011ABA0 File Offset: 0x00118DA0
		// (set) Token: 0x06003026 RID: 12326 RVA: 0x00018AE6 File Offset: 0x00016CE6
		public unsafe MixOperation CurrentMixOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixOperation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06003027 RID: 12327 RVA: 0x0011ABD0 File Offset: 0x00118DD0
		// (set) Token: 0x06003028 RID: 12328 RVA: 0x00018B05 File Offset: 0x00016D05
		public unsafe int CurrentMixTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationData.NativeFieldInfoPtr_CurrentMixTime)) = value;
			}
		}

		// Token: 0x04002064 RID: 8292
		private static readonly IntPtr NativeFieldInfoPtr_ProductContents;

		// Token: 0x04002065 RID: 8293
		private static readonly IntPtr NativeFieldInfoPtr_MixerContents;

		// Token: 0x04002066 RID: 8294
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x04002067 RID: 8295
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMixOperation;

		// Token: 0x04002068 RID: 8296
		private static readonly IntPtr NativeFieldInfoPtr_CurrentMixTime;

		// Token: 0x04002069 RID: 8297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_ItemSet_MixOperation_Int32_0;
	}
}
