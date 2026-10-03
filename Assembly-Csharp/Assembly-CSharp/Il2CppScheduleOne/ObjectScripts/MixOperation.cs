using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Effects;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005B3 RID: 1459
	[Serializable]
	public class MixOperation : Object
	{
		// Token: 0x06008ACB RID: 35531 RVA: 0x0025BC7C File Offset: 0x00259E7C
		// Note: this type is marked as 'beforefieldinit'.
		static MixOperation()
		{
			Il2CppClassPointerStore<MixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "MixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixOperation>.NativeClassPtr);
			MixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductID");
			MixOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "ProductQuality");
			MixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "IngredientID");
			MixOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, "Quantity");
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100681189);
			MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100681190);
			MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Effect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100681191);
			MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixOperation>.NativeClassPtr, 100681192);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x0025BD4C File Offset: 0x00259F4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 257372, RefRangeEnd = 257374, XrefRangeStart = 257369, XrefRangeEnd = 257372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x0025BDC8 File Offset: 0x00259FC8
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x0025BE04 File Offset: 0x0025A004
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257400, RefRangeEnd = 257403, XrefRangeStart = 257374, XrefRangeEnd = 257400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EDrugType GetOutput(out List<Effect> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Effect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			properties = ((intPtr4 == 0) ? null : new List<Effect>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x0025BE64 File Offset: 0x0025A064
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 257414, RefRangeEnd = 257417, XrefRangeStart = 257403, XrefRangeEnd = 257414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixOperation.NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00041C43 File Offset: 0x0003FE43
		public MixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x0025BEC4 File Offset: 0x0025A0C4
		// (set) Token: 0x06008AD2 RID: 35538 RVA: 0x00041C4C File Offset: 0x0003FE4C
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x0025BEEC File Offset: 0x0025A0EC
		// (set) Token: 0x06008AD4 RID: 35540 RVA: 0x00041C6B File Offset: 0x0003FE6B
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x06008AD5 RID: 35541 RVA: 0x0025BF14 File Offset: 0x0025A114
		// (set) Token: 0x06008AD6 RID: 35542 RVA: 0x00041C86 File Offset: 0x0003FE86
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x0025BF3C File Offset: 0x0025A13C
		// (set) Token: 0x06008AD8 RID: 35544 RVA: 0x00041CA5 File Offset: 0x0003FEA5
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x04005F0C RID: 24332
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x04005F0D RID: 24333
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04005F0E RID: 24334
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x04005F0F RID: 24335
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04005F10 RID: 24336
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_String_Int32_0;

		// Token: 0x04005F11 RID: 24337
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F12 RID: 24338
		private static readonly IntPtr NativeMethodInfoPtr_GetOutput_Public_EDrugType_byref_List_1_Effect_0;

		// Token: 0x04005F13 RID: 24339
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Public_Boolean_byref_ProductDefinition_0;
	}
}
