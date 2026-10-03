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
	// Token: 0x0200024E RID: 590
	public class LabOvenData : GridItemData
	{
		// Token: 0x0600300B RID: 12299 RVA: 0x0011A668 File Offset: 0x00118868
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenData()
		{
			Il2CppClassPointerStore<LabOvenData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr);
			LabOvenData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "InputContents");
			LabOvenData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "OutputContents");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientID");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuantity");
			LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentIngredientQuality");
			LabOvenData.NativeFieldInfoPtr_CurrentProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentProductID");
			LabOvenData.NativeFieldInfoPtr_CurrentCookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, "CurrentCookProgress");
			LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr, 100669429);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x0011A738 File Offset: 0x00118938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 135170, RefRangeEnd = 135171, XrefRangeStart = 135160, XrefRangeEnd = 135170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string ingredientID, int currentIngredientQuantity, EQuality ingredientQuality, string productID, int currentCookProgress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenData>.NativeClassPtr))
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
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentIngredientQuantity;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentCookProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x000189AA File Offset: 0x00016BAA
		public LabOvenData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x0600300E RID: 12302 RVA: 0x0011A84C File Offset: 0x00118A4C
		// (set) Token: 0x0600300F RID: 12303 RVA: 0x000189B3 File Offset: 0x00016BB3
		public unsafe ItemSet InputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06003010 RID: 12304 RVA: 0x0011A87C File Offset: 0x00118A7C
		// (set) Token: 0x06003011 RID: 12305 RVA: 0x000189D2 File Offset: 0x00016BD2
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x0011A8AC File Offset: 0x00118AAC
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x000189F1 File Offset: 0x00016BF1
		public unsafe string CurrentIngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x0011A8D4 File Offset: 0x00118AD4
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00018A10 File Offset: 0x00016C10
		public unsafe int CurrentIngredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuantity)) = value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06003016 RID: 12310 RVA: 0x0011A8FC File Offset: 0x00118AFC
		// (set) Token: 0x06003017 RID: 12311 RVA: 0x00018A2B File Offset: 0x00016C2B
		public unsafe EQuality CurrentIngredientQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentIngredientQuality)) = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x0011A924 File Offset: 0x00118B24
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00018A46 File Offset: 0x00016C46
		public unsafe string CurrentProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x0011A94C File Offset: 0x00118B4C
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x00018A65 File Offset: 0x00016C65
		public unsafe int CurrentCookProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenData.NativeFieldInfoPtr_CurrentCookProgress)) = value;
			}
		}

		// Token: 0x0400205C RID: 8284
		private static readonly IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x0400205D RID: 8285
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x0400205E RID: 8286
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientID;

		// Token: 0x0400205F RID: 8287
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientQuantity;

		// Token: 0x04002060 RID: 8288
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIngredientQuality;

		// Token: 0x04002061 RID: 8289
		private static readonly IntPtr NativeFieldInfoPtr_CurrentProductID;

		// Token: 0x04002062 RID: 8290
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCookProgress;

		// Token: 0x04002063 RID: 8291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_Int32_EQuality_String_Int32_0;
	}
}
