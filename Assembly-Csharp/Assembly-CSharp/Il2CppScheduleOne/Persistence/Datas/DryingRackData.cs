using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000249 RID: 585
	public class DryingRackData : GridItemData
	{
		// Token: 0x06002FE1 RID: 12257 RVA: 0x00119DEC File Offset: 0x00117FEC
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackData()
		{
			Il2CppClassPointerStore<DryingRackData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr);
			DryingRackData.NativeFieldInfoPtr_Input = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Input");
			DryingRackData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "Output");
			DryingRackData.NativeFieldInfoPtr_DryingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, "DryingOperations");
			DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr, 100669423);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00119E6C File Offset: 0x0011806C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135102, RefRangeEnd = 135103, XrefRangeStart = 135092, XrefRangeEnd = 135102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet input, ItemSet output, Il2CppReferenceArray<DryingOperation> dryingOperations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dryingOperations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x000187FE File Offset: 0x000169FE
		public DryingRackData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x00119F3C File Offset: 0x0011813C
		// (set) Token: 0x06002FE5 RID: 12261 RVA: 0x00018807 File Offset: 0x00016A07
		public unsafe ItemSet Input
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Input), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06002FE6 RID: 12262 RVA: 0x00119F6C File Offset: 0x0011816C
		// (set) Token: 0x06002FE7 RID: 12263 RVA: 0x00018826 File Offset: 0x00016A26
		public unsafe ItemSet Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_Output), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x00119F9C File Offset: 0x0011819C
		// (set) Token: 0x06002FE9 RID: 12265 RVA: 0x00018845 File Offset: 0x00016A45
		public unsafe Il2CppReferenceArray<DryingOperation> DryingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DryingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackData.NativeFieldInfoPtr_DryingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002049 RID: 8265
		private static readonly IntPtr NativeFieldInfoPtr_Input;

		// Token: 0x0400204A RID: 8266
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x0400204B RID: 8267
		private static readonly IntPtr NativeFieldInfoPtr_DryingOperations;

		// Token: 0x0400204C RID: 8268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_Il2CppReferenceArray_1_DryingOperation_0;
	}
}
