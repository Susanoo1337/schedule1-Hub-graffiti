using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000259 RID: 601
	public class ToggleableItemData : GridItemData
	{
		// Token: 0x0600305C RID: 12380 RVA: 0x0011B7E0 File Offset: 0x001199E0
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableItemData()
		{
			Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ToggleableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr);
			ToggleableItemData.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr, "IsOn");
			ToggleableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr, 100669440);
		}

		// Token: 0x0600305D RID: 12381 RVA: 0x0011B838 File Offset: 0x00119A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135204, RefRangeEnd = 135205, XrefRangeStart = 135198, XrefRangeEnd = 135204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, bool isOn) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600305E RID: 12382 RVA: 0x00018CD9 File Offset: 0x00016ED9
		public ToggleableItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x0600305F RID: 12383 RVA: 0x0011B8DC File Offset: 0x00119ADC
		// (set) Token: 0x06003060 RID: 12384 RVA: 0x00018CE2 File Offset: 0x00016EE2
		public unsafe bool IsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItemData.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItemData.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x0400207F RID: 8319
		private static readonly IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x04002080 RID: 8320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_Boolean_0;
	}
}
