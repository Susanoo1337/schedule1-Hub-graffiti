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
	// Token: 0x02000248 RID: 584
	public class ChemistryStationData : GridItemData
	{
		// Token: 0x06002FD0 RID: 12240 RVA: 0x00119AE8 File Offset: 0x00117CE8
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationData()
		{
			Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr);
			ChemistryStationData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "InputContents");
			ChemistryStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "OutputContents");
			ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentRecipeID");
			ChemistryStationData.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "ProductQuality");
			ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "StartLiquidColor");
			ChemistryStationData.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "LiquidLevel");
			ChemistryStationData.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentTime");
			ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, 100669422);
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00119BB8 File Offset: 0x00117DB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135091, RefRangeEnd = 135092, XrefRangeStart = 135082, XrefRangeEnd = 135091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContents);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentRecipeID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x0001872C File Offset: 0x0001692C
		public ChemistryStationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002FD3 RID: 12243 RVA: 0x00119CC4 File Offset: 0x00117EC4
		// (set) Token: 0x06002FD4 RID: 12244 RVA: 0x00018735 File Offset: 0x00016935
		public unsafe ItemSet InputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002FD5 RID: 12245 RVA: 0x00119CF4 File Offset: 0x00117EF4
		// (set) Token: 0x06002FD6 RID: 12246 RVA: 0x00018754 File Offset: 0x00016954
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002FD7 RID: 12247 RVA: 0x00119D24 File Offset: 0x00117F24
		// (set) Token: 0x06002FD8 RID: 12248 RVA: 0x00018773 File Offset: 0x00016973
		public unsafe string CurrentRecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x00119D4C File Offset: 0x00117F4C
		// (set) Token: 0x06002FDA RID: 12250 RVA: 0x00018792 File Offset: 0x00016992
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06002FDB RID: 12251 RVA: 0x00119D74 File Offset: 0x00117F74
		// (set) Token: 0x06002FDC RID: 12252 RVA: 0x000187AD File Offset: 0x000169AD
		public unsafe Color StartLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002FDD RID: 12253 RVA: 0x00119D9C File Offset: 0x00117F9C
		// (set) Token: 0x06002FDE RID: 12254 RVA: 0x000187C8 File Offset: 0x000169C8
		public unsafe float LiquidLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002FDF RID: 12255 RVA: 0x00119DC4 File Offset: 0x00117FC4
		// (set) Token: 0x06002FE0 RID: 12256 RVA: 0x000187E3 File Offset: 0x000169E3
		public unsafe int CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x04002041 RID: 8257
		private static readonly IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x04002042 RID: 8258
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x04002043 RID: 8259
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRecipeID;

		// Token: 0x04002044 RID: 8260
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04002045 RID: 8261
		private static readonly IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x04002046 RID: 8262
		private static readonly IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x04002047 RID: 8263
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x04002048 RID: 8264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0;
	}
}
