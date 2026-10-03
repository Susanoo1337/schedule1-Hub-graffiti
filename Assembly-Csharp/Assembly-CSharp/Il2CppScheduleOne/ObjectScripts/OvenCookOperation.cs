using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005AF RID: 1455
	[Serializable]
	public class OvenCookOperation : Object
	{
		// Token: 0x06008971 RID: 35185 RVA: 0x00256358 File Offset: 0x00254558
		// Note: this type is marked as 'beforefieldinit'.
		static OvenCookOperation()
		{
			Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "OvenCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr);
			OvenCookOperation.NativeFieldInfoPtr__itemDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_itemDefinition");
			OvenCookOperation.NativeFieldInfoPtr__productionDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_productionDefinition");
			OvenCookOperation.NativeFieldInfoPtr__cookable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "_cookable");
			OvenCookOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientID");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuality");
			OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "IngredientQuantity");
			OvenCookOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "ProductID");
			OvenCookOperation.NativeFieldInfoPtr_CookProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "CookProgress");
			OvenCookOperation.NativeFieldInfoPtr_cookDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, "cookDuration");
			OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680994);
			OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680995);
			OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680996);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680997);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680998);
			OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100680999);
			OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100681000);
			OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100681001);
			OvenCookOperation.NativeMethodInfoPtr_IsComplete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100681002);
			OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100681003);
			OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr, 100681004);
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06008972 RID: 35186 RVA: 0x00256518 File Offset: 0x00254718
		public unsafe StorableItemDefinition Ingredient
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 255535, RefRangeEnd = 255544, XrefRangeStart = 255525, XrefRangeEnd = 255535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008973 RID: 35187 RVA: 0x00256558 File Offset: 0x00254758
		public unsafe StorableItemDefinition Product
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 255554, RefRangeEnd = 255558, XrefRangeStart = 255544, XrefRangeEnd = 255554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008974 RID: 35188 RVA: 0x00256598 File Offset: 0x00254798
		public unsafe CookableModule Cookable
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 255567, RefRangeEnd = 255573, XrefRangeStart = 255558, XrefRangeEnd = 255567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr3) : null;
			}
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x002565D8 File Offset: 0x002547D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255576, RefRangeEnd = 255579, XrefRangeStart = 255573, XrefRangeEnd = 255576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x00256654 File Offset: 0x00254854
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255582, RefRangeEnd = 255584, XrefRangeStart = 255579, XrefRangeEnd = 255582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation(string ingredientID, EQuality ingredientQuality, int ingredientQuantity, string productID, int progress) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ingredientQuantity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x002566DC File Offset: 0x002548DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255585, RefRangeEnd = 255586, XrefRangeStart = 255584, XrefRangeEnd = 255585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OvenCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OvenCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00256718 File Offset: 0x00254918
		[CallerCount(0)]
		public unsafe void UpdateCookProgress(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x00256758 File Offset: 0x00254958
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 255590, RefRangeEnd = 255594, XrefRangeStart = 255586, XrefRangeEnd = 255590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCookDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetCookDuration_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00256794 File Offset: 0x00254994
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255598, RefRangeEnd = 255603, XrefRangeStart = 255594, XrefRangeEnd = 255598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_IsComplete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x002567D0 File Offset: 0x002549D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 255617, RefRangeEnd = 255620, XrefRangeStart = 255603, XrefRangeEnd = 255617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetProductItem(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x0025681C File Offset: 0x00254A1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 255598, RefRangeEnd = 255603, XrefRangeStart = 255598, XrefRangeEnd = 255603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReady()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OvenCookOperation.NativeMethodInfoPtr_IsReady_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600897D RID: 35197 RVA: 0x00041333 File Offset: 0x0003F533
		public OvenCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x0600897E RID: 35198 RVA: 0x00256858 File Offset: 0x00254A58
		// (set) Token: 0x0600897F RID: 35199 RVA: 0x0004133C File Offset: 0x0003F53C
		public unsafe StorableItemDefinition _itemDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__itemDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06008980 RID: 35200 RVA: 0x00256888 File Offset: 0x00254A88
		// (set) Token: 0x06008981 RID: 35201 RVA: 0x0004135B File Offset: 0x0003F55B
		public unsafe StorableItemDefinition _productionDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__productionDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008982 RID: 35202 RVA: 0x002568B8 File Offset: 0x00254AB8
		// (set) Token: 0x06008983 RID: 35203 RVA: 0x0004137A File Offset: 0x0003F57A
		public unsafe CookableModule _cookable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookableModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr__cookable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008984 RID: 35204 RVA: 0x002568E8 File Offset: 0x00254AE8
		// (set) Token: 0x06008985 RID: 35205 RVA: 0x00041399 File Offset: 0x0003F599
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008986 RID: 35206 RVA: 0x00256910 File Offset: 0x00254B10
		// (set) Token: 0x06008987 RID: 35207 RVA: 0x000413B8 File Offset: 0x0003F5B8
		public unsafe EQuality IngredientQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuality)) = value;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06008988 RID: 35208 RVA: 0x00256938 File Offset: 0x00254B38
		// (set) Token: 0x06008989 RID: 35209 RVA: 0x000413D3 File Offset: 0x0003F5D3
		public unsafe int IngredientQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_IngredientQuantity)) = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600898A RID: 35210 RVA: 0x00256960 File Offset: 0x00254B60
		// (set) Token: 0x0600898B RID: 35211 RVA: 0x000413EE File Offset: 0x0003F5EE
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600898C RID: 35212 RVA: 0x00256988 File Offset: 0x00254B88
		// (set) Token: 0x0600898D RID: 35213 RVA: 0x0004140D File Offset: 0x0003F60D
		public unsafe int CookProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_CookProgress)) = value;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600898E RID: 35214 RVA: 0x002569B0 File Offset: 0x00254BB0
		// (set) Token: 0x0600898F RID: 35215 RVA: 0x00041428 File Offset: 0x0003F628
		public unsafe int cookDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OvenCookOperation.NativeFieldInfoPtr_cookDuration)) = value;
			}
		}

		// Token: 0x04005E06 RID: 24070
		private static readonly IntPtr NativeFieldInfoPtr__itemDefinition;

		// Token: 0x04005E07 RID: 24071
		private static readonly IntPtr NativeFieldInfoPtr__productionDefinition;

		// Token: 0x04005E08 RID: 24072
		private static readonly IntPtr NativeFieldInfoPtr__cookable;

		// Token: 0x04005E09 RID: 24073
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x04005E0A RID: 24074
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuality;

		// Token: 0x04005E0B RID: 24075
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantity;

		// Token: 0x04005E0C RID: 24076
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x04005E0D RID: 24077
		private static readonly IntPtr NativeFieldInfoPtr_CookProgress;

		// Token: 0x04005E0E RID: 24078
		private static readonly IntPtr NativeFieldInfoPtr_cookDuration;

		// Token: 0x04005E0F RID: 24079
		private static readonly IntPtr NativeMethodInfoPtr_get_Ingredient_Public_get_StorableItemDefinition_0;

		// Token: 0x04005E10 RID: 24080
		private static readonly IntPtr NativeMethodInfoPtr_get_Product_Public_get_StorableItemDefinition_0;

		// Token: 0x04005E11 RID: 24081
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookable_Public_get_CookableModule_0;

		// Token: 0x04005E12 RID: 24082
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_0;

		// Token: 0x04005E13 RID: 24083
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Int32_String_Int32_0;

		// Token: 0x04005E14 RID: 24084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005E15 RID: 24085
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCookProgress_Public_Void_Int32_0;

		// Token: 0x04005E16 RID: 24086
		private static readonly IntPtr NativeMethodInfoPtr_GetCookDuration_Public_Int32_0;

		// Token: 0x04005E17 RID: 24087
		private static readonly IntPtr NativeMethodInfoPtr_IsComplete_Public_Boolean_0;

		// Token: 0x04005E18 RID: 24088
		private static readonly IntPtr NativeMethodInfoPtr_GetProductItem_Public_ItemInstance_Int32_0;

		// Token: 0x04005E19 RID: 24089
		private static readonly IntPtr NativeMethodInfoPtr_IsReady_Public_Boolean_0;
	}
}
