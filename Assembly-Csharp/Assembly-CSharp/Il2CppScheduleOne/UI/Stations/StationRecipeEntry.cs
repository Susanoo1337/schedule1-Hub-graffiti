using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077D RID: 1917
	public class StationRecipeEntry : MonoBehaviour
	{
		// Token: 0x0600BA8F RID: 47759 RVA: 0x002FFEA8 File Offset: 0x002FE0A8
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeEntry()
		{
			Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "StationRecipeEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr);
			StationRecipeEntry.NativeFieldInfoPtr_ValidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "ValidColor");
			StationRecipeEntry.NativeFieldInfoPtr_InvalidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "InvalidColor");
			StationRecipeEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Button");
			StationRecipeEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "Icon");
			StationRecipeEntry.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "TitleLabel");
			StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "CookingTimeLabel");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientRects");
			StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "IngredientQuantities");
			StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<IsValid>k__BackingField");
			StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<Recipe>k__BackingField");
			StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687653);
			StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687654);
			StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687655);
			StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687656);
			StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687657);
			StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687658);
			StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687659);
			StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, 100687660);
		}

		// Token: 0x17003871 RID: 14449
		// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x00300040 File Offset: 0x002FE240
		// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x0030007C File Offset: 0x002FE27C
		public unsafe bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003872 RID: 14450
		// (get) Token: 0x0600BA92 RID: 47762 RVA: 0x003000BC File Offset: 0x002FE2BC
		// (set) Token: 0x0600BA93 RID: 47763 RVA: 0x003000FC File Offset: 0x002FE2FC
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x00300140 File Offset: 0x002FE340
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 311572, RefRangeEnd = 311576, XrefRangeStart = 311507, XrefRangeEnd = 311572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x00300184 File Offset: 0x002FE384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311639, RefRangeEnd = 311641, XrefRangeStart = 311576, XrefRangeEnd = 311639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshValidity(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x003001C8 File Offset: 0x002FE3C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311711, RefRangeEnd = 311712, XrefRangeStart = 311641, XrefRangeEnd = 311711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetIngredientsMatchDelta(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x00300218 File Offset: 0x002FE418
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x00056FBC File Offset: 0x000551BC
		public StationRecipeEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003867 RID: 14439
		// (get) Token: 0x0600BA99 RID: 47769 RVA: 0x00300254 File Offset: 0x002FE454
		// (set) Token: 0x0600BA9A RID: 47770 RVA: 0x00056FC5 File Offset: 0x000551C5
		public unsafe static Color ValidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_ValidColor, (void*)(&value));
			}
		}

		// Token: 0x17003868 RID: 14440
		// (get) Token: 0x0600BA9B RID: 47771 RVA: 0x00300270 File Offset: 0x002FE470
		// (set) Token: 0x0600BA9C RID: 47772 RVA: 0x00056FD3 File Offset: 0x000551D3
		public unsafe static Color InvalidColor
		{
			get
			{
				Color result;
				IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.NativeFieldInfoPtr_InvalidColor, (void*)(&value));
			}
		}

		// Token: 0x17003869 RID: 14441
		// (get) Token: 0x0600BA9D RID: 47773 RVA: 0x0030028C File Offset: 0x002FE48C
		// (set) Token: 0x0600BA9E RID: 47774 RVA: 0x00056FE1 File Offset: 0x000551E1
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386A RID: 14442
		// (get) Token: 0x0600BA9F RID: 47775 RVA: 0x003002BC File Offset: 0x002FE4BC
		// (set) Token: 0x0600BAA0 RID: 47776 RVA: 0x00057000 File Offset: 0x00055200
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x003002EC File Offset: 0x002FE4EC
		// (set) Token: 0x0600BAA2 RID: 47778 RVA: 0x0005701F File Offset: 0x0005521F
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x0030031C File Offset: 0x002FE51C
		// (set) Token: 0x0600BAA4 RID: 47780 RVA: 0x0005703E File Offset: 0x0005523E
		public unsafe TextMeshProUGUI CookingTimeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_CookingTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386D RID: 14445
		// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x0030034C File Offset: 0x002FE54C
		// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x0005705D File Offset: 0x0005525D
		public unsafe Il2CppReferenceArray<RectTransform> IngredientRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386E RID: 14446
		// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x0030037C File Offset: 0x002FE57C
		// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x0005707C File Offset: 0x0005527C
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> IngredientQuantities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr_IngredientQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700386F RID: 14447
		// (get) Token: 0x0600BAA9 RID: 47785 RVA: 0x003003AC File Offset: 0x002FE5AC
		// (set) Token: 0x0600BAAA RID: 47786 RVA: 0x0005709B File Offset: 0x0005529B
		public unsafe bool _IsValid_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__IsValid_k__BackingField)) = value;
			}
		}

		// Token: 0x17003870 RID: 14448
		// (get) Token: 0x0600BAAB RID: 47787 RVA: 0x003003D4 File Offset: 0x002FE5D4
		// (set) Token: 0x0600BAAC RID: 47788 RVA: 0x000570B6 File Offset: 0x000552B6
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007FE6 RID: 32742
		private static readonly IntPtr NativeFieldInfoPtr_ValidColor;

		// Token: 0x04007FE7 RID: 32743
		private static readonly IntPtr NativeFieldInfoPtr_InvalidColor;

		// Token: 0x04007FE8 RID: 32744
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04007FE9 RID: 32745
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04007FEA RID: 32746
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04007FEB RID: 32747
		private static readonly IntPtr NativeFieldInfoPtr_CookingTimeLabel;

		// Token: 0x04007FEC RID: 32748
		private static readonly IntPtr NativeFieldInfoPtr_IngredientRects;

		// Token: 0x04007FED RID: 32749
		private static readonly IntPtr NativeFieldInfoPtr_IngredientQuantities;

		// Token: 0x04007FEE RID: 32750
		private static readonly IntPtr NativeFieldInfoPtr__IsValid_k__BackingField;

		// Token: 0x04007FEF RID: 32751
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04007FF0 RID: 32752
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x04007FF1 RID: 32753
		private static readonly IntPtr NativeMethodInfoPtr_set_IsValid_Private_set_Void_Boolean_0;

		// Token: 0x04007FF2 RID: 32754
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04007FF3 RID: 32755
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04007FF4 RID: 32756
		private static readonly IntPtr NativeMethodInfoPtr_AssignRecipe_Public_Void_StationRecipe_0;

		// Token: 0x04007FF5 RID: 32757
		private static readonly IntPtr NativeMethodInfoPtr_RefreshValidity_Public_Void_List_1_ItemInstance_0;

		// Token: 0x04007FF6 RID: 32758
		private static readonly IntPtr NativeMethodInfoPtr_GetIngredientsMatchDelta_Public_Single_List_1_ItemInstance_0;

		// Token: 0x04007FF7 RID: 32759
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D08 RID: 3336
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F7A6 RID: 63398 RVA: 0x003B592C File Offset: 0x003B3B2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr);
				StationRecipeEntry.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9");
				StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, "<>9__18_0");
				StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100687663);
				StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr, 100687664);
			}

			// Token: 0x0600F7A7 RID: 63399 RVA: 0x003B59A8 File Offset: 0x003B3BA8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7A8 RID: 63400 RVA: 0x003B59E4 File Offset: 0x003B3BE4
			[CallerCount(0)]
			public unsafe int _GetIngredientsMatchDelta_b__18_0(StationRecipe.IngredientQuantity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F7A9 RID: 63401 RVA: 0x000751C4 File Offset: 0x000733C4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B4F RID: 19279
			// (get) Token: 0x0600F7AA RID: 63402 RVA: 0x003B5A34 File Offset: 0x003B3C34
			// (set) Token: 0x0600F7AB RID: 63403 RVA: 0x000751CD File Offset: 0x000733CD
			public unsafe static StationRecipeEntry.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B50 RID: 19280
			// (get) Token: 0x0600F7AC RID: 63404 RVA: 0x003B5A5C File Offset: 0x003B3C5C
			// (set) Token: 0x0600F7AD RID: 63405 RVA: 0x000751DF File Offset: 0x000733DF
			public unsafe static Func<StationRecipe.IngredientQuantity, int> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StationRecipe.IngredientQuantity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(StationRecipeEntry.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A774 RID: 42868
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A775 RID: 42869
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400A776 RID: 42870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A777 RID: 42871
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__18_0_Internal_Int32_IngredientQuantity_0;
		}

		// Token: 0x02000D09 RID: 3337
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7AE RID: 63406 RVA: 0x003B5A84 File Offset: 0x003B3C84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100687665);
				StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr, 100687666);
			}

			// Token: 0x0600F7AF RID: 63407 RVA: 0x003B5AEC File Offset: 0x003B3CEC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7B0 RID: 63408 RVA: 0x003B5B28 File Offset: 0x003B3D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RefreshValidity_b__0(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass17_0.NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F7B1 RID: 63409 RVA: 0x000751F1 File Offset: 0x000733F1
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B51 RID: 19281
			// (get) Token: 0x0600F7B2 RID: 63410 RVA: 0x003B5B78 File Offset: 0x003B3D78
			// (set) Token: 0x0600F7B3 RID: 63411 RVA: 0x000751FA File Offset: 0x000733FA
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass17_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A778 RID: 42872
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x0400A779 RID: 42873
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A77A RID: 42874
			private static readonly IntPtr NativeMethodInfoPtr__RefreshValidity_b__0_Internal_Boolean_ItemInstance_0;
		}

		// Token: 0x02000D0A RID: 3338
		[ObfuscatedName("ScheduleOne.UI.Stations.StationRecipeEntry+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7B4 RID: 63412 RVA: 0x003B5BA8 File Offset: 0x003B3DA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StationRecipeEntry>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr);
				StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, "ingredientVariant");
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100687667);
				StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr, 100687668);
			}

			// Token: 0x0600F7B5 RID: 63413 RVA: 0x003B5C10 File Offset: 0x003B3E10
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeEntry.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7B6 RID: 63414 RVA: 0x003B5C4C File Offset: 0x003B3E4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetIngredientsMatchDelta_b__1(ItemInstance x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeEntry.__c__DisplayClass18_0.NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F7B7 RID: 63415 RVA: 0x00075219 File Offset: 0x00073419
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B52 RID: 19282
			// (get) Token: 0x0600F7B8 RID: 63416 RVA: 0x003B5C9C File Offset: 0x003B3E9C
			// (set) Token: 0x0600F7B9 RID: 63417 RVA: 0x00075222 File Offset: 0x00073422
			public unsafe ItemDefinition ingredientVariant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeEntry.__c__DisplayClass18_0.NativeFieldInfoPtr_ingredientVariant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A77B RID: 42875
			private static readonly IntPtr NativeFieldInfoPtr_ingredientVariant;

			// Token: 0x0400A77C RID: 42876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A77D RID: 42877
			private static readonly IntPtr NativeMethodInfoPtr__GetIngredientsMatchDelta_b__1_Internal_Boolean_ItemInstance_0;
		}
	}
}
