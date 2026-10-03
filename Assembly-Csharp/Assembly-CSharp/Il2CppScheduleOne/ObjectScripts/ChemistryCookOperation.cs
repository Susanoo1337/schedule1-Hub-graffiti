using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x020005A4 RID: 1444
	public class ChemistryCookOperation : Il2CppSystem.Object
	{
		// Token: 0x06008569 RID: 34153 RVA: 0x00246678 File Offset: 0x00244878
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryCookOperation()
		{
			Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "ChemistryCookOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr);
			ChemistryCookOperation.NativeFieldInfoPtr_recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "recipe");
			ChemistryCookOperation.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "RecipeID");
			ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "ProductQuality");
			ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "StartLiquidColor");
			ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "LiquidLevel");
			ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, "CurrentTime");
			ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680453);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680454);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680455);
			ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680456);
			ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680457);
			ChemistryCookOperation.NativeMethodInfoPtr_IsComplete_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680458);
			ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr, 100680459);
		}

		// Token: 0x1700294B RID: 10571
		// (get) Token: 0x0600856A RID: 34154 RVA: 0x002467AC File Offset: 0x002449AC
		public unsafe StationRecipe Recipe
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 250310, RefRangeEnd = 250322, XrefRangeStart = 250292, XrefRangeEnd = 250310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
		}

		// Token: 0x0600856B RID: 34155 RVA: 0x002467EC File Offset: 0x002449EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250325, RefRangeEnd = 250327, XrefRangeStart = 250322, XrefRangeEnd = 250325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(StationRecipe recipe, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856C RID: 34156 RVA: 0x00246870 File Offset: 0x00244A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 250329, RefRangeEnd = 250331, XrefRangeStart = 250327, XrefRangeEnd = 250329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation(string recipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime = 0) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856D RID: 34157 RVA: 0x002468F4 File Offset: 0x00244AF4
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryCookOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryCookOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856E RID: 34158 RVA: 0x00246930 File Offset: 0x00244B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250331, XrefRangeEnd = 250332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Progress(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_Progress_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600856F RID: 34159 RVA: 0x00246970 File Offset: 0x00244B70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250332, XrefRangeEnd = 250333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr_IsComplete_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008570 RID: 34160 RVA: 0x002469AC File Offset: 0x00244BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250333, XrefRangeEnd = 250336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Recipe_b__2_0(StationRecipe r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryCookOperation.NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008571 RID: 34161 RVA: 0x0003F655 File Offset: 0x0003D855
		public ChemistryCookOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002945 RID: 10565
		// (get) Token: 0x06008572 RID: 34162 RVA: 0x002469FC File Offset: 0x00244BFC
		// (set) Token: 0x06008573 RID: 34163 RVA: 0x0003F65E File Offset: 0x0003D85E
		public unsafe StationRecipe recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002946 RID: 10566
		// (get) Token: 0x06008574 RID: 34164 RVA: 0x00246A2C File Offset: 0x00244C2C
		// (set) Token: 0x06008575 RID: 34165 RVA: 0x0003F67D File Offset: 0x0003D87D
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002947 RID: 10567
		// (get) Token: 0x06008576 RID: 34166 RVA: 0x00246A54 File Offset: 0x00244C54
		// (set) Token: 0x06008577 RID: 34167 RVA: 0x0003F69C File Offset: 0x0003D89C
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17002948 RID: 10568
		// (get) Token: 0x06008578 RID: 34168 RVA: 0x00246A7C File Offset: 0x00244C7C
		// (set) Token: 0x06008579 RID: 34169 RVA: 0x0003F6B7 File Offset: 0x0003D8B7
		public unsafe Color StartLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x17002949 RID: 10569
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x00246AA4 File Offset: 0x00244CA4
		// (set) Token: 0x0600857B RID: 34171 RVA: 0x0003F6D2 File Offset: 0x0003D8D2
		public unsafe float LiquidLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x1700294A RID: 10570
		// (get) Token: 0x0600857C RID: 34172 RVA: 0x00246ACC File Offset: 0x00244CCC
		// (set) Token: 0x0600857D RID: 34173 RVA: 0x0003F6ED File Offset: 0x0003D8ED
		public unsafe int CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryCookOperation.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x04005B10 RID: 23312
		private static readonly IntPtr NativeFieldInfoPtr_recipe;

		// Token: 0x04005B11 RID: 23313
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04005B12 RID: 23314
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04005B13 RID: 23315
		private static readonly IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x04005B14 RID: 23316
		private static readonly IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x04005B15 RID: 23317
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x04005B16 RID: 23318
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04005B17 RID: 23319
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipe_EQuality_Color_Single_Int32_0;

		// Token: 0x04005B18 RID: 23320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_EQuality_Color_Single_Int32_0;

		// Token: 0x04005B19 RID: 23321
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005B1A RID: 23322
		private static readonly IntPtr NativeMethodInfoPtr_Progress_Public_Void_Int32_0;

		// Token: 0x04005B1B RID: 23323
		private static readonly IntPtr NativeMethodInfoPtr_IsComplete_Public_Boolean_0;

		// Token: 0x04005B1C RID: 23324
		private static readonly IntPtr NativeMethodInfoPtr__get_Recipe_b__2_0_Private_Boolean_StationRecipe_0;
	}
}
