using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Stations
{
	// Token: 0x0200077C RID: 1916
	public class ChemistryStationInterface : StationInterface<ChemistryStationInterface>
	{
		// Token: 0x0600BA61 RID: 47713 RVA: 0x002FF628 File Offset: 0x002FD828
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationInterface()
		{
			Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Stations", "ChemistryStationInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr);
			ChemistryStationInterface.NativeFieldInfoPtr__ChemistryStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "<ChemistryStation>k__BackingField");
			ChemistryStationInterface.NativeFieldInfoPtr_Recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "Recipes");
			ChemistryStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "RecipeEntryPrefab");
			ChemistryStationInterface.NativeFieldInfoPtr_InputSlotUIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "InputSlotUIs");
			ChemistryStationInterface.NativeFieldInfoPtr_OutputSlotUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "OutputSlotUI");
			ChemistryStationInterface.NativeFieldInfoPtr_RecipeSelectionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "RecipeSelectionContainer");
			ChemistryStationInterface.NativeFieldInfoPtr_SelectedRecipeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "SelectedRecipeIndicator");
			ChemistryStationInterface.NativeFieldInfoPtr_InstructionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "InstructionLabel");
			ChemistryStationInterface.NativeFieldInfoPtr_ErrorLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "ErrorLabel");
			ChemistryStationInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "BeginButton");
			ChemistryStationInterface.NativeFieldInfoPtr_RecipeContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "RecipeContainer");
			ChemistryStationInterface.NativeFieldInfoPtr_CookingInProgressContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "CookingInProgressContainer");
			ChemistryStationInterface.NativeFieldInfoPtr_InProgressRecipeEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "InProgressRecipeEntry");
			ChemistryStationInterface.NativeFieldInfoPtr_recipeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "recipeEntries");
			ChemistryStationInterface.NativeFieldInfoPtr_selectedRecipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "selectedRecipe");
			ChemistryStationInterface.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687635);
			ChemistryStationInterface.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687636);
			ChemistryStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687637);
			ChemistryStationInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687638);
			ChemistryStationInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687639);
			ChemistryStationInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687640);
			ChemistryStationInterface.NativeMethodInfoPtr_UpdateInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687641);
			ChemistryStationInterface.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687642);
			ChemistryStationInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687643);
			ChemistryStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687644);
			ChemistryStationInterface.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687645);
			ChemistryStationInterface.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687646);
			ChemistryStationInterface.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687647);
			ChemistryStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, 100687648);
		}

		// Token: 0x17003866 RID: 14438
		// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x002FF89C File Offset: 0x002FDA9C
		// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x002FF8DC File Offset: 0x002FDADC
		public unsafe ChemistryStation ChemistryStation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600BA64 RID: 47716 RVA: 0x002FF920 File Offset: 0x002FDB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311177, XrefRangeEnd = 311207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA65 RID: 47717 RVA: 0x002FF95C File Offset: 0x002FDB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311207, XrefRangeEnd = 311239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationInterface.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA66 RID: 47718 RVA: 0x002FF998 File Offset: 0x002FDB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311239, XrefRangeEnd = 311247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA67 RID: 47719 RVA: 0x002FF9CC File Offset: 0x002FDBCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311275, RefRangeEnd = 311277, XrefRangeStart = 311247, XrefRangeEnd = 311275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA68 RID: 47720 RVA: 0x002FFA00 File Offset: 0x002FDC00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311311, RefRangeEnd = 311312, XrefRangeStart = 311277, XrefRangeEnd = 311311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_UpdateInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA69 RID: 47721 RVA: 0x002FFA34 File Offset: 0x002FDC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311362, RefRangeEnd = 311364, XrefRangeStart = 311312, XrefRangeEnd = 311362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6A RID: 47722 RVA: 0x002FFA78 File Offset: 0x002FDC78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311385, RefRangeEnd = 311388, XrefRangeStart = 311364, XrefRangeEnd = 311385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6B RID: 47723 RVA: 0x002FFAAC File Offset: 0x002FDCAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311388, XrefRangeEnd = 311413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_BeginTask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6C RID: 47724 RVA: 0x002FFAE0 File Offset: 0x002FDCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311413, XrefRangeEnd = 311432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StationSlotsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6D RID: 47725 RVA: 0x002FFB14 File Offset: 0x002FDD14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311473, RefRangeEnd = 311475, XrefRangeStart = 311432, XrefRangeEnd = 311473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortRecipes(List<ItemInstance> ingredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x002FFB58 File Offset: 0x002FDD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311488, RefRangeEnd = 311490, XrefRangeStart = 311475, XrefRangeEnd = 311488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedRecipe(StationRecipeEntry entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA6F RID: 47727 RVA: 0x002FFB9C File Offset: 0x002FDD9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311490, XrefRangeEnd = 311507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600BA70 RID: 47728 RVA: 0x00056DE2 File Offset: 0x00054FE2
		public ChemistryStationInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600BA71 RID: 47729 RVA: 0x002FFBD8 File Offset: 0x002FDDD8
		// (set) Token: 0x0600BA72 RID: 47730 RVA: 0x00056DEB File Offset: 0x00054FEB
		public unsafe ChemistryStation _ChemistryStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr__ChemistryStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr__ChemistryStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600BA73 RID: 47731 RVA: 0x002FFC08 File Offset: 0x002FDE08
		// (set) Token: 0x0600BA74 RID: 47732 RVA: 0x00056E0A File Offset: 0x0005500A
		public unsafe List<StationRecipe> Recipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_Recipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_Recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600BA75 RID: 47733 RVA: 0x002FFC38 File Offset: 0x002FDE38
		// (set) Token: 0x0600BA76 RID: 47734 RVA: 0x00056E29 File Offset: 0x00055029
		public unsafe StationRecipeEntry RecipeEntryPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600BA77 RID: 47735 RVA: 0x002FFC68 File Offset: 0x002FDE68
		// (set) Token: 0x0600BA78 RID: 47736 RVA: 0x00056E48 File Offset: 0x00055048
		public unsafe Il2CppReferenceArray<ItemSlotUI> InputSlotUIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InputSlotUIs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InputSlotUIs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600BA79 RID: 47737 RVA: 0x002FFC98 File Offset: 0x002FDE98
		// (set) Token: 0x0600BA7A RID: 47738 RVA: 0x00056E67 File Offset: 0x00055067
		public unsafe ItemSlotUI OutputSlotUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_OutputSlotUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_OutputSlotUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600BA7B RID: 47739 RVA: 0x002FFCC8 File Offset: 0x002FDEC8
		// (set) Token: 0x0600BA7C RID: 47740 RVA: 0x00056E86 File Offset: 0x00055086
		public unsafe RectTransform RecipeSelectionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeSelectionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeSelectionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600BA7D RID: 47741 RVA: 0x002FFCF8 File Offset: 0x002FDEF8
		// (set) Token: 0x0600BA7E RID: 47742 RVA: 0x00056EA5 File Offset: 0x000550A5
		public unsafe RectTransform SelectedRecipeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_SelectedRecipeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_SelectedRecipeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600BA7F RID: 47743 RVA: 0x002FFD28 File Offset: 0x002FDF28
		// (set) Token: 0x0600BA80 RID: 47744 RVA: 0x00056EC4 File Offset: 0x000550C4
		public unsafe TextMeshProUGUI InstructionLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InstructionLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InstructionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700385F RID: 14431
		// (get) Token: 0x0600BA81 RID: 47745 RVA: 0x002FFD58 File Offset: 0x002FDF58
		// (set) Token: 0x0600BA82 RID: 47746 RVA: 0x00056EE3 File Offset: 0x000550E3
		public unsafe TextMeshProUGUI ErrorLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_ErrorLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_ErrorLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003860 RID: 14432
		// (get) Token: 0x0600BA83 RID: 47747 RVA: 0x002FFD88 File Offset: 0x002FDF88
		// (set) Token: 0x0600BA84 RID: 47748 RVA: 0x00056F02 File Offset: 0x00055102
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003861 RID: 14433
		// (get) Token: 0x0600BA85 RID: 47749 RVA: 0x002FFDB8 File Offset: 0x002FDFB8
		// (set) Token: 0x0600BA86 RID: 47750 RVA: 0x00056F21 File Offset: 0x00055121
		public unsafe RectTransform RecipeContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_RecipeContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003862 RID: 14434
		// (get) Token: 0x0600BA87 RID: 47751 RVA: 0x002FFDE8 File Offset: 0x002FDFE8
		// (set) Token: 0x0600BA88 RID: 47752 RVA: 0x00056F40 File Offset: 0x00055140
		public unsafe RectTransform CookingInProgressContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_CookingInProgressContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_CookingInProgressContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003863 RID: 14435
		// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x002FFE18 File Offset: 0x002FE018
		// (set) Token: 0x0600BA8A RID: 47754 RVA: 0x00056F5F File Offset: 0x0005515F
		public unsafe StationRecipeEntry InProgressRecipeEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InProgressRecipeEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_InProgressRecipeEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003864 RID: 14436
		// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x002FFE48 File Offset: 0x002FE048
		// (set) Token: 0x0600BA8C RID: 47756 RVA: 0x00056F7E File Offset: 0x0005517E
		public unsafe List<StationRecipeEntry> recipeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_recipeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipeEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_recipeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003865 RID: 14437
		// (get) Token: 0x0600BA8D RID: 47757 RVA: 0x002FFE78 File Offset: 0x002FE078
		// (set) Token: 0x0600BA8E RID: 47758 RVA: 0x00056F9D File Offset: 0x0005519D
		public unsafe StationRecipeEntry selectedRecipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_selectedRecipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.NativeFieldInfoPtr_selectedRecipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007FC9 RID: 32713
		private static readonly IntPtr NativeFieldInfoPtr__ChemistryStation_k__BackingField;

		// Token: 0x04007FCA RID: 32714
		private static readonly IntPtr NativeFieldInfoPtr_Recipes;

		// Token: 0x04007FCB RID: 32715
		private static readonly IntPtr NativeFieldInfoPtr_RecipeEntryPrefab;

		// Token: 0x04007FCC RID: 32716
		private static readonly IntPtr NativeFieldInfoPtr_InputSlotUIs;

		// Token: 0x04007FCD RID: 32717
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlotUI;

		// Token: 0x04007FCE RID: 32718
		private static readonly IntPtr NativeFieldInfoPtr_RecipeSelectionContainer;

		// Token: 0x04007FCF RID: 32719
		private static readonly IntPtr NativeFieldInfoPtr_SelectedRecipeIndicator;

		// Token: 0x04007FD0 RID: 32720
		private static readonly IntPtr NativeFieldInfoPtr_InstructionLabel;

		// Token: 0x04007FD1 RID: 32721
		private static readonly IntPtr NativeFieldInfoPtr_ErrorLabel;

		// Token: 0x04007FD2 RID: 32722
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04007FD3 RID: 32723
		private static readonly IntPtr NativeFieldInfoPtr_RecipeContainer;

		// Token: 0x04007FD4 RID: 32724
		private static readonly IntPtr NativeFieldInfoPtr_CookingInProgressContainer;

		// Token: 0x04007FD5 RID: 32725
		private static readonly IntPtr NativeFieldInfoPtr_InProgressRecipeEntry;

		// Token: 0x04007FD6 RID: 32726
		private static readonly IntPtr NativeFieldInfoPtr_recipeEntries;

		// Token: 0x04007FD7 RID: 32727
		private static readonly IntPtr NativeFieldInfoPtr_selectedRecipe;

		// Token: 0x04007FD8 RID: 32728
		private static readonly IntPtr NativeMethodInfoPtr_get_ChemistryStation_Public_get_ChemistryStation_0;

		// Token: 0x04007FD9 RID: 32729
		private static readonly IntPtr NativeMethodInfoPtr_set_ChemistryStation_Protected_set_Void_ChemistryStation_0;

		// Token: 0x04007FDA RID: 32730
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007FDB RID: 32731
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007FDC RID: 32732
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04007FDD RID: 32733
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x04007FDE RID: 32734
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInput_Private_Void_0;

		// Token: 0x04007FDF RID: 32735
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_ChemistryStation_0;

		// Token: 0x04007FE0 RID: 32736
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04007FE1 RID: 32737
		private static readonly IntPtr NativeMethodInfoPtr_BeginTask_Private_Void_0;

		// Token: 0x04007FE2 RID: 32738
		private static readonly IntPtr NativeMethodInfoPtr_StationSlotsChanged_Private_Void_0;

		// Token: 0x04007FE3 RID: 32739
		private static readonly IntPtr NativeMethodInfoPtr_SortRecipes_Private_Void_List_1_ItemInstance_0;

		// Token: 0x04007FE4 RID: 32740
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedRecipe_Private_Void_StationRecipeEntry_0;

		// Token: 0x04007FE5 RID: 32741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D06 RID: 3334
		[ObfuscatedName("ScheduleOne.UI.Stations.ChemistryStationInterface+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F798 RID: 63384 RVA: 0x003B56AC File Offset: 0x003B38AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr);
				ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_station = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr, "station");
				ChemistryStationInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr, 100687649);
				ChemistryStationInterface.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr, 100687650);
			}

			// Token: 0x0600F799 RID: 63385 RVA: 0x003B5728 File Offset: 0x003B3928
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F79A RID: 63386 RVA: 0x003B5764 File Offset: 0x003B3964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311165, XrefRangeEnd = 311171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F79B RID: 63387 RVA: 0x00075155 File Offset: 0x00073355
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B4C RID: 19276
			// (get) Token: 0x0600F79C RID: 63388 RVA: 0x003B5798 File Offset: 0x003B3998
			// (set) Token: 0x0600F79D RID: 63389 RVA: 0x0007515E File Offset: 0x0007335E
			public unsafe ChemistryStationInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStationInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B4D RID: 19277
			// (get) Token: 0x0600F79E RID: 63390 RVA: 0x003B57C8 File Offset: 0x003B39C8
			// (set) Token: 0x0600F79F RID: 63391 RVA: 0x0007517D File Offset: 0x0007337D
			public unsafe ChemistryStation station
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_station);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass25_0.NativeFieldInfoPtr_station), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A76D RID: 42861
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A76E RID: 42862
			private static readonly IntPtr NativeFieldInfoPtr_station;

			// Token: 0x0400A76F RID: 42863
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A770 RID: 42864
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D07 RID: 3335
		[ObfuscatedName("ScheduleOne.UI.Stations.ChemistryStationInterface+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F7A0 RID: 63392 RVA: 0x003B57F8 File Offset: 0x003B39F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChemistryStationInterface>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr);
				ChemistryStationInterface.__c__DisplayClass27_0.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr, "recipes");
				ChemistryStationInterface.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr, 100687651);
				ChemistryStationInterface.__c__DisplayClass27_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr, 100687652);
			}

			// Token: 0x0600F7A1 RID: 63393 RVA: 0x003B5860 File Offset: 0x003B3A60
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationInterface.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F7A2 RID: 63394 RVA: 0x003B589C File Offset: 0x003B3A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311171, XrefRangeEnd = 311177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SortRecipes_b__0(StationRecipeEntry a, StationRecipeEntry b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationInterface.__c__DisplayClass27_0.NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F7A3 RID: 63395 RVA: 0x0007519C File Offset: 0x0007339C
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B4E RID: 19278
			// (get) Token: 0x0600F7A4 RID: 63396 RVA: 0x003B58FC File Offset: 0x003B3AFC
			// (set) Token: 0x0600F7A5 RID: 63397 RVA: 0x000751A5 File Offset: 0x000733A5
			public unsafe Dictionary<StationRecipeEntry, float> recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass27_0.NativeFieldInfoPtr_recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StationRecipeEntry, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationInterface.__c__DisplayClass27_0.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A771 RID: 42865
			private static readonly IntPtr NativeFieldInfoPtr_recipes;

			// Token: 0x0400A772 RID: 42866
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A773 RID: 42867
			private static readonly IntPtr NativeMethodInfoPtr__SortRecipes_b__0_Internal_Int32_StationRecipeEntry_StationRecipeEntry_0;
		}
	}
}
