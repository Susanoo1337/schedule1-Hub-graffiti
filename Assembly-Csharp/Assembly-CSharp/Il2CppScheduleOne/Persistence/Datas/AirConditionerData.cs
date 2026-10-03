using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Temperature;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000244 RID: 580
	[Serializable]
	public class AirConditionerData : GridItemData
	{
		// Token: 0x06002FB0 RID: 12208 RVA: 0x001194B8 File Offset: 0x001176B8
		// Note: this type is marked as 'beforefieldinit'.
		static AirConditionerData()
		{
			Il2CppClassPointerStore<AirConditionerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "AirConditionerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AirConditionerData>.NativeClassPtr);
			AirConditionerData.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AirConditionerData>.NativeClassPtr, "Mode");
			AirConditionerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_EMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AirConditionerData>.NativeClassPtr, 100669418);
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00119510 File Offset: 0x00117710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135051, RefRangeEnd = 135052, XrefRangeStart = 135045, XrefRangeEnd = 135051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AirConditionerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, AirConditioner.EMode mode) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AirConditionerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AirConditionerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_EMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x000185E2 File Offset: 0x000167E2
		public AirConditionerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06002FB3 RID: 12211 RVA: 0x001195B4 File Offset: 0x001177B4
		// (set) Token: 0x06002FB4 RID: 12212 RVA: 0x000185EB File Offset: 0x000167EB
		public unsafe AirConditioner.EMode Mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditionerData.NativeFieldInfoPtr_Mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AirConditionerData.NativeFieldInfoPtr_Mode)) = value;
			}
		}

		// Token: 0x04002033 RID: 8243
		private static readonly IntPtr NativeFieldInfoPtr_Mode;

		// Token: 0x04002034 RID: 8244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_EMode_0;
	}
}
