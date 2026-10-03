using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000546 RID: 1350
	[Serializable]
	public class StationRecipe : ScriptableObject
	{
		// Token: 0x06007B86 RID: 31622 RVA: 0x0022232C File Offset: 0x0022052C
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipe()
		{
			Il2CppClassPointerStore<StationRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "StationRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr);
			StationRecipe.NativeFieldInfoPtr_IsDiscovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IsDiscovered");
			StationRecipe.NativeFieldInfoPtr_RecipeTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "RecipeTitle");
			StationRecipe.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Unlocked");
			StationRecipe.NativeFieldInfoPtr_Ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Ingredients");
			StationRecipe.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "Product");
			StationRecipe.NativeFieldInfoPtr_FinalLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "FinalLiquidColor");
			StationRecipe.NativeFieldInfoPtr_CookTime_Mins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTime_Mins");
			StationRecipe.NativeFieldInfoPtr_CookTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperature");
			StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "CookTemperatureTolerance");
			StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "QualityCalculationMethod");
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679170);
			StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679171);
			StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679172);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679173);
			StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679174);
			StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679175);
			StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679176);
			StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, 100679177);
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x002224C4 File Offset: 0x002206C4
		public unsafe float CookTemperatureLowerBound
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 235768, RefRangeEnd = 235770, XrefRangeStart = 235768, XrefRangeEnd = 235768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06007B88 RID: 31624 RVA: 0x00222500 File Offset: 0x00220700
		public unsafe float CookTemperatureUpperBound
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 235770, RefRangeEnd = 235775, XrefRangeStart = 235770, XrefRangeEnd = 235770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700264A RID: 9802
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x0022253C File Offset: 0x0022073C
		public unsafe string RecipeID
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 235780, RefRangeEnd = 235784, XrefRangeStart = 235775, XrefRangeEnd = 235780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_get_RecipeID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x00222574 File Offset: 0x00220774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 235790, RefRangeEnd = 235792, XrefRangeStart = 235784, XrefRangeEnd = 235790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x002225C4 File Offset: 0x002207C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235796, RefRangeEnd = 235797, XrefRangeStart = 235792, XrefRangeEnd = 235796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorableItemInstance GetProductInstance(EQuality quality)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quality;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StorableItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x00222610 File Offset: 0x00220810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235849, RefRangeEnd = 235850, XrefRangeStart = 235797, XrefRangeEnd = 235849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoIngredientsSuffice(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x00222660 File Offset: 0x00220860
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 235863, RefRangeEnd = 235866, XrefRangeStart = 235850, XrefRangeEnd = 235863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality CalculateQuality(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x002226B0 File Offset: 0x002208B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235866, XrefRangeEnd = 235874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x0003AD48 File Offset: 0x00038F48
		public StationRecipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700263E RID: 9790
		// (get) Token: 0x06007B90 RID: 31632 RVA: 0x002226EC File Offset: 0x002208EC
		// (set) Token: 0x06007B91 RID: 31633 RVA: 0x0003AD51 File Offset: 0x00038F51
		public unsafe bool IsDiscovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_IsDiscovered)) = value;
			}
		}

		// Token: 0x1700263F RID: 9791
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x00222714 File Offset: 0x00220914
		// (set) Token: 0x06007B93 RID: 31635 RVA: 0x0003AD6C File Offset: 0x00038F6C
		public unsafe string RecipeTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_RecipeTitle), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002640 RID: 9792
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x0022273C File Offset: 0x0022093C
		// (set) Token: 0x06007B95 RID: 31637 RVA: 0x0003AD8B File Offset: 0x00038F8B
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17002641 RID: 9793
		// (get) Token: 0x06007B96 RID: 31638 RVA: 0x00222764 File Offset: 0x00220964
		// (set) Token: 0x06007B97 RID: 31639 RVA: 0x0003ADA6 File Offset: 0x00038FA6
		public unsafe List<StationRecipe.IngredientQuantity> Ingredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe.IngredientQuantity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002642 RID: 9794
		// (get) Token: 0x06007B98 RID: 31640 RVA: 0x00222794 File Offset: 0x00220994
		// (set) Token: 0x06007B99 RID: 31641 RVA: 0x0003ADC5 File Offset: 0x00038FC5
		public unsafe StationRecipe.ItemQuantity Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe.ItemQuantity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002643 RID: 9795
		// (get) Token: 0x06007B9A RID: 31642 RVA: 0x002227C4 File Offset: 0x002209C4
		// (set) Token: 0x06007B9B RID: 31643 RVA: 0x0003ADE4 File Offset: 0x00038FE4
		public unsafe Color FinalLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_FinalLiquidColor)) = value;
			}
		}

		// Token: 0x17002644 RID: 9796
		// (get) Token: 0x06007B9C RID: 31644 RVA: 0x002227EC File Offset: 0x002209EC
		// (set) Token: 0x06007B9D RID: 31645 RVA: 0x0003ADFF File Offset: 0x00038FFF
		public unsafe int CookTime_Mins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTime_Mins)) = value;
			}
		}

		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x00222814 File Offset: 0x00220A14
		// (set) Token: 0x06007B9F RID: 31647 RVA: 0x0003AE1A File Offset: 0x0003901A
		public unsafe float CookTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperature)) = value;
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06007BA0 RID: 31648 RVA: 0x0022283C File Offset: 0x00220A3C
		// (set) Token: 0x06007BA1 RID: 31649 RVA: 0x0003AE35 File Offset: 0x00039035
		public unsafe float CookTemperatureTolerance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_CookTemperatureTolerance)) = value;
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x06007BA2 RID: 31650 RVA: 0x00222864 File Offset: 0x00220A64
		// (set) Token: 0x06007BA3 RID: 31651 RVA: 0x0003AE50 File Offset: 0x00039050
		public unsafe StationRecipe.EQualityCalculationMethod QualityCalculationMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.NativeFieldInfoPtr_QualityCalculationMethod)) = value;
			}
		}

		// Token: 0x04005431 RID: 21553
		private static readonly IntPtr NativeFieldInfoPtr_IsDiscovered;

		// Token: 0x04005432 RID: 21554
		private static readonly IntPtr NativeFieldInfoPtr_RecipeTitle;

		// Token: 0x04005433 RID: 21555
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04005434 RID: 21556
		private static readonly IntPtr NativeFieldInfoPtr_Ingredients;

		// Token: 0x04005435 RID: 21557
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x04005436 RID: 21558
		private static readonly IntPtr NativeFieldInfoPtr_FinalLiquidColor;

		// Token: 0x04005437 RID: 21559
		private static readonly IntPtr NativeFieldInfoPtr_CookTime_Mins;

		// Token: 0x04005438 RID: 21560
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperature;

		// Token: 0x04005439 RID: 21561
		private static readonly IntPtr NativeFieldInfoPtr_CookTemperatureTolerance;

		// Token: 0x0400543A RID: 21562
		private static readonly IntPtr NativeFieldInfoPtr_QualityCalculationMethod;

		// Token: 0x0400543B RID: 21563
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureLowerBound_Public_get_Single_0;

		// Token: 0x0400543C RID: 21564
		private static readonly IntPtr NativeMethodInfoPtr_get_CookTemperatureUpperBound_Public_get_Single_0;

		// Token: 0x0400543D RID: 21565
		private static readonly IntPtr NativeMethodInfoPtr_get_RecipeID_Public_get_String_0;

		// Token: 0x0400543E RID: 21566
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_List_1_ItemInstance_0;

		// Token: 0x0400543F RID: 21567
		private static readonly IntPtr NativeMethodInfoPtr_GetProductInstance_Public_StorableItemInstance_EQuality_0;

		// Token: 0x04005440 RID: 21568
		private static readonly IntPtr NativeMethodInfoPtr_DoIngredientsSuffice_Public_Boolean_List_1_ItemInstance_0;

		// Token: 0x04005441 RID: 21569
		private static readonly IntPtr NativeMethodInfoPtr_CalculateQuality_Public_EQuality_List_1_ItemInstance_0;

		// Token: 0x04005442 RID: 21570
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BC1 RID: 3009
		[OriginalName("Assembly-CSharp.dll", "", "EQualityCalculationMethod")]
		public enum EQualityCalculationMethod
		{
			// Token: 0x04009F7B RID: 40827
			Additive
		}

		// Token: 0x02000BC2 RID: 3010
		[Serializable]
		public class ItemQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600EB5E RID: 60254 RVA: 0x00392050 File Offset: 0x00390250
			// Note: this type is marked as 'beforefieldinit'.
			static ItemQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "ItemQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr);
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Item");
				StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr, 100679178);
			}

			// Token: 0x0600EB5F RID: 60255 RVA: 0x003920B8 File Offset: 0x003902B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235742, XrefRangeEnd = 235743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ItemQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.ItemQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.ItemQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB60 RID: 60256 RVA: 0x0006F06C File Offset: 0x0006D26C
			public ItemQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004765 RID: 18277
			// (get) Token: 0x0600EB61 RID: 60257 RVA: 0x003920F4 File Offset: 0x003902F4
			// (set) Token: 0x0600EB62 RID: 60258 RVA: 0x0006F075 File Offset: 0x0006D275
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004766 RID: 18278
			// (get) Token: 0x0600EB63 RID: 60259 RVA: 0x00392124 File Offset: 0x00390324
			// (set) Token: 0x0600EB64 RID: 60260 RVA: 0x0006F094 File Offset: 0x0006D294
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.ItemQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009F7C RID: 40828
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04009F7D RID: 40829
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009F7E RID: 40830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC3 RID: 3011
		[Serializable]
		public class IngredientQuantity : Il2CppSystem.Object
		{
			// Token: 0x0600EB65 RID: 60261 RVA: 0x0039214C File Offset: 0x0039034C
			// Note: this type is marked as 'beforefieldinit'.
			static IngredientQuantity()
			{
				Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "IngredientQuantity");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr);
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Items");
				StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, "Quantity");
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679179);
				StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr, 100679180);
			}

			// Token: 0x17004769 RID: 18281
			// (get) Token: 0x0600EB66 RID: 60262 RVA: 0x003921C8 File Offset: 0x003903C8
			public unsafe ItemDefinition Item
			{
				[CallerCount(9)]
				[CachedScanResults(RefRangeStart = 235746, RefRangeEnd = 235755, XrefRangeStart = 235743, XrefRangeEnd = 235746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x0600EB67 RID: 60263 RVA: 0x00392208 File Offset: 0x00390408
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 235763, RefRangeEnd = 235765, XrefRangeStart = 235755, XrefRangeEnd = 235763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IngredientQuantity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.IngredientQuantity>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.IngredientQuantity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB68 RID: 60264 RVA: 0x0006F0AF File Offset: 0x0006D2AF
			public IngredientQuantity(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004767 RID: 18279
			// (get) Token: 0x0600EB69 RID: 60265 RVA: 0x00392244 File Offset: 0x00390444
			// (set) Token: 0x0600EB6A RID: 60266 RVA: 0x0006F0B8 File Offset: 0x0006D2B8
			public unsafe List<ItemDefinition> Items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004768 RID: 18280
			// (get) Token: 0x0600EB6B RID: 60267 RVA: 0x00392274 File Offset: 0x00390474
			// (set) Token: 0x0600EB6C RID: 60268 RVA: 0x0006F0D7 File Offset: 0x0006D2D7
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.IngredientQuantity.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04009F7F RID: 40831
			private static readonly IntPtr NativeFieldInfoPtr_Items;

			// Token: 0x04009F80 RID: 40832
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04009F81 RID: 40833
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemDefinition_0;

			// Token: 0x04009F82 RID: 40834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BC4 RID: 3012
		[ObfuscatedName("ScheduleOne.StationFramework.StationRecipe+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB6D RID: 60269 RVA: 0x0039229C File Offset: 0x0039049C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipe>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr);
				StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, "ingredientVariant");
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679181);
				StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr, 100679182);
			}

			// Token: 0x0600EB6E RID: 60270 RVA: 0x00392304 File Offset: 0x00390504
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipe.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB6F RID: 60271 RVA: 0x00392340 File Offset: 0x00390540
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235765, XrefRangeEnd = 235768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DoIngredientsSuffice_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipe.__c__DisplayClass21_0.NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB70 RID: 60272 RVA: 0x0006F0F2 File Offset: 0x0006D2F2
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700476A RID: 18282
			// (get) Token: 0x0600EB71 RID: 60273 RVA: 0x00392390 File Offset: 0x00390590
			// (set) Token: 0x0600EB72 RID: 60274 RVA: 0x0006F0FB File Offset: 0x0006D2FB
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipe.__c__DisplayClass21_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009F83 RID: 40835
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x04009F84 RID: 40836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009F85 RID: 40837
			private static readonly IntPtr NativeMethodInfoPtr__DoIngredientsSuffice_b__0_Internal_Boolean_ItemInstance_0;
		}
	}
}
