using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200018D RID: 397
	public class UseChemistryStationTask : Task
	{
		// Token: 0x06002839 RID: 10297 RVA: 0x000FFEA8 File Offset: 0x000FE0A8
		// Note: this type is marked as 'beforefieldinit'.
		static UseChemistryStationTask()
		{
			Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "UseChemistryStationTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr);
			UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "STIR_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "TEMPERATURE_TIME");
			UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<CurrentStep>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Station>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "<Recipe>k__BackingField");
			UseChemistryStationTask.NativeFieldInfoPtr_beaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "beaker");
			UseChemistryStationTask.NativeFieldInfoPtr_stirringRod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirringRod");
			UseChemistryStationTask.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "items");
			UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "ingredientPieces");
			UseChemistryStationTask.NativeFieldInfoPtr_stirProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "stirProgress");
			UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "timeInTemperatureRange");
			UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, "RemovedIngredients");
			UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668450);
			UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668451);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668452);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668453);
			UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668454);
			UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668455);
			UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668456);
			UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668457);
			UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668458);
			UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668459);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668460);
			UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668461);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668462);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668463);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668464);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668465);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668466);
			UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668467);
			UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668468);
			UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr, 100668469);
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x00100158 File Offset: 0x000FE358
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x00100194 File Offset: 0x000FE394
		public unsafe ChemistryStation.EStep CurrentStep
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x001001D4 File Offset: 0x000FE3D4
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x00100214 File Offset: 0x000FE414
		public unsafe ChemistryStation Station
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 94584, RefRangeEnd = 94585, XrefRangeStart = 94584, XrefRangeEnd = 94585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x00100258 File Offset: 0x000FE458
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x00100298 File Offset: 0x000FE498
		public unsafe StationRecipe Recipe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x001002DC File Offset: 0x000FE4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120723, XrefRangeEnd = 120733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStepDescription(ChemistryStation.EStep step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00100314 File Offset: 0x000FE514
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 120878, RefRangeEnd = 120880, XrefRangeStart = 120733, XrefRangeEnd = 120878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseChemistryStationTask(ChemistryStation station, StationRecipe recipe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseChemistryStationTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00100374 File Offset: 0x000FE574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120880, XrefRangeEnd = 120883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x001003B0 File Offset: 0x000FE5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120924, RefRangeEnd = 120925, XrefRangeStart = 120883, XrefRangeEnd = 120924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInstruction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_UpdateInstruction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x001003E4 File Offset: 0x000FE5E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 120935, RefRangeEnd = 120936, XrefRangeStart = 120925, XrefRangeEnd = 120935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckProgress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00100418 File Offset: 0x000FE618
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 120971, RefRangeEnd = 120979, XrefRangeStart = 120936, XrefRangeEnd = 120971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProgressStep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_ProgressStep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x0010044C File Offset: 0x000FE64C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121009, RefRangeEnd = 121010, XrefRangeStart = 120979, XrefRangeEnd = 121009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_CombineIngredients()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00100480 File Offset: 0x000FE680
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121028, RefRangeEnd = 121029, XrefRangeStart = 121010, XrefRangeEnd = 121028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StirMixture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x001004B4 File Offset: 0x000FE6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121029, XrefRangeEnd = 121032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_LowerBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x001004E8 File Offset: 0x000FE6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121032, XrefRangeEnd = 121035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_PourIntoBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x0010051C File Offset: 0x000FE71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121035, XrefRangeEnd = 121038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_RaiseBoilingFlask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00100550 File Offset: 0x000FE750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121065, RefRangeEnd = 121066, XrefRangeStart = 121038, XrefRangeEnd = 121065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckStep_StartHeat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseChemistryStationTask.NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00100584 File Offset: 0x000FE784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121066, XrefRangeEnd = 121092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Success()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_Success_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x001005C0 File Offset: 0x000FE7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121092, XrefRangeEnd = 121129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseChemistryStationTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0001527E File Offset: 0x0001347E
		public UseChemistryStationTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x0600284F RID: 10319 RVA: 0x001005FC File Offset: 0x000FE7FC
		// (set) Token: 0x06002850 RID: 10320 RVA: 0x00015287 File Offset: 0x00013487
		public unsafe static float STIR_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_STIR_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002851 RID: 10321 RVA: 0x00100618 File Offset: 0x000FE818
		// (set) Token: 0x06002852 RID: 10322 RVA: 0x00015295 File Offset: 0x00013495
		public unsafe static float TEMPERATURE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseChemistryStationTask.NativeFieldInfoPtr_TEMPERATURE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x00100634 File Offset: 0x000FE834
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x000152A3 File Offset: 0x000134A3
		public unsafe ChemistryStation.EStep _CurrentStep_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__CurrentStep_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x0010065C File Offset: 0x000FE85C
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x000152BE File Offset: 0x000134BE
		public unsafe ChemistryStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x0010068C File Offset: 0x000FE88C
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x000152DD File Offset: 0x000134DD
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x001006BC File Offset: 0x000FE8BC
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x000152FC File Offset: 0x000134FC
		public unsafe Beaker beaker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_beaker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x001006EC File Offset: 0x000FE8EC
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x0001531B File Offset: 0x0001351B
		public unsafe StirringRod stirringRod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StirringRod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirringRod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x0010071C File Offset: 0x000FE91C
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x0001533A File Offset: 0x0001353A
		public unsafe List<StationItem> items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x0010074C File Offset: 0x000FE94C
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x00015359 File Offset: 0x00013559
		public unsafe List<IngredientPiece> ingredientPieces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IngredientPiece>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_ingredientPieces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x0010077C File Offset: 0x000FE97C
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x00015378 File Offset: 0x00013578
		public unsafe float stirProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_stirProgress)) = value;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x001007A4 File Offset: 0x000FE9A4
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x00015393 File Offset: 0x00013593
		public unsafe float timeInTemperatureRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_timeInTemperatureRange)) = value;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x001007CC File Offset: 0x000FE9CC
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x000153AE File Offset: 0x000135AE
		public unsafe Il2CppReferenceArray<ItemInstance> RemovedIngredients
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseChemistryStationTask.NativeFieldInfoPtr_RemovedIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001BAC RID: 7084
		private static readonly IntPtr NativeFieldInfoPtr_STIR_TIME;

		// Token: 0x04001BAD RID: 7085
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_TIME;

		// Token: 0x04001BAE RID: 7086
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStep_k__BackingField;

		// Token: 0x04001BAF RID: 7087
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04001BB0 RID: 7088
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x04001BB1 RID: 7089
		private static readonly IntPtr NativeFieldInfoPtr_beaker;

		// Token: 0x04001BB2 RID: 7090
		private static readonly IntPtr NativeFieldInfoPtr_stirringRod;

		// Token: 0x04001BB3 RID: 7091
		private static readonly IntPtr NativeFieldInfoPtr_items;

		// Token: 0x04001BB4 RID: 7092
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPieces;

		// Token: 0x04001BB5 RID: 7093
		private static readonly IntPtr NativeFieldInfoPtr_stirProgress;

		// Token: 0x04001BB6 RID: 7094
		private static readonly IntPtr NativeFieldInfoPtr_timeInTemperatureRange;

		// Token: 0x04001BB7 RID: 7095
		private static readonly IntPtr NativeFieldInfoPtr_RemovedIngredients;

		// Token: 0x04001BB8 RID: 7096
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStep_Public_get_EStep_0;

		// Token: 0x04001BB9 RID: 7097
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStep_Private_set_Void_EStep_0;

		// Token: 0x04001BBA RID: 7098
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0;

		// Token: 0x04001BBB RID: 7099
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Private_set_Void_ChemistryStation_0;

		// Token: 0x04001BBC RID: 7100
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x04001BBD RID: 7101
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x04001BBE RID: 7102
		private static readonly IntPtr NativeMethodInfoPtr_GetStepDescription_Public_Static_String_EStep_0;

		// Token: 0x04001BBF RID: 7103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChemistryStation_StationRecipe_0;

		// Token: 0x04001BC0 RID: 7104
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001BC1 RID: 7105
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInstruction_Private_Void_0;

		// Token: 0x04001BC2 RID: 7106
		private static readonly IntPtr NativeMethodInfoPtr_CheckProgress_Private_Void_0;

		// Token: 0x04001BC3 RID: 7107
		private static readonly IntPtr NativeMethodInfoPtr_ProgressStep_Private_Void_0;

		// Token: 0x04001BC4 RID: 7108
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_CombineIngredients_Private_Void_0;

		// Token: 0x04001BC5 RID: 7109
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StirMixture_Private_Void_0;

		// Token: 0x04001BC6 RID: 7110
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_LowerBoilingFlask_Private_Void_0;

		// Token: 0x04001BC7 RID: 7111
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_PourIntoBoilingFlask_Private_Void_0;

		// Token: 0x04001BC8 RID: 7112
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_RaiseBoilingFlask_Private_Void_0;

		// Token: 0x04001BC9 RID: 7113
		private static readonly IntPtr NativeMethodInfoPtr_CheckStep_StartHeat_Private_Void_0;

		// Token: 0x04001BCA RID: 7114
		private static readonly IntPtr NativeMethodInfoPtr_Success_Public_Virtual_Void_0;

		// Token: 0x04001BCB RID: 7115
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;
	}
}
