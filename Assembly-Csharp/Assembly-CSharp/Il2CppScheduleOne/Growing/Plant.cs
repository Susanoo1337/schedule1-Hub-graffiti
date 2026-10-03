using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200051A RID: 1306
	public class Plant : MonoBehaviour
	{
		// Token: 0x06007680 RID: 30336 RVA: 0x002101CC File Offset: 0x0020E3CC
		// Note: this type is marked as 'beforefieldinit'.
		static Plant()
		{
			Il2CppClassPointerStore<Plant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "Plant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plant>.NativeClassPtr);
			Plant.NativeFieldInfoPtr_BaseQualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseQualityLevel");
			Plant.NativeFieldInfoPtr__Pot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<Pot>k__BackingField");
			Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<NormalizedGrowthProgress>k__BackingField");
			Plant.NativeFieldInfoPtr__YieldMultiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<YieldMultiplier>k__BackingField");
			Plant.NativeFieldInfoPtr__QualityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "<QualityLevel>k__BackingField");
			Plant.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "VisualsContainer");
			Plant.NativeFieldInfoPtr_GrowthStages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthStages");
			Plant.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "Collider");
			Plant.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SnipSound");
			Plant.NativeFieldInfoPtr_DestroySound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "DestroySound");
			Plant.NativeFieldInfoPtr_FullyGrownParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "FullyGrownParticles");
			Plant.NativeFieldInfoPtr_HarvestLabelPositionTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "HarvestLabelPositionTransform");
			Plant.NativeFieldInfoPtr__harvestables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "_harvestables");
			Plant.NativeFieldInfoPtr_SeedDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "SeedDefinition");
			Plant.NativeFieldInfoPtr_GrowthTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "GrowthTime");
			Plant.NativeFieldInfoPtr_BaseYieldQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "BaseYieldQuantity");
			Plant.NativeFieldInfoPtr_HarvestTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "HarvestTarget");
			Plant.NativeFieldInfoPtr_MinColliderScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "MinColliderScale");
			Plant.NativeFieldInfoPtr_ColliderScaleThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "ColliderScaleThreshold");
			Plant.NativeFieldInfoPtr_PlantScrapPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "PlantScrapPrefab");
			Plant.NativeFieldInfoPtr_ActiveHarvestables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "ActiveHarvestables");
			Plant.NativeFieldInfoPtr_onFullyHarvested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plant>.NativeClassPtr, "onFullyHarvested");
			Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678532);
			Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678533);
			Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678534);
			Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678535);
			Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678536);
			Plant.NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678537);
			Plant.NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678538);
			Plant.NativeMethodInfoPtr_get_QualityLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678539);
			Plant.NativeMethodInfoPtr_set_QualityLevel_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678540);
			Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678541);
			Plant.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678542);
			Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678543);
			Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678544);
			Plant.NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678545);
			Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678546);
			Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678547);
			Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678548);
			Plant.NativeMethodInfoPtr_OnFullyHarvested_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678549);
			Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678550);
			Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678551);
			Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678552);
			Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678553);
			Plant.NativeMethodInfoPtr_ResizeCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678554);
			Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678555);
			Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678556);
			Plant.NativeMethodInfoPtr_ActivateAllLures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678557);
			Plant.NativeMethodInfoPtr_DeactivateAllLures_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678558);
			Plant.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plant>.NativeClassPtr, 100678559);
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06007681 RID: 30337 RVA: 0x002105E4 File Offset: 0x0020E7E4
		// (set) Token: 0x06007682 RID: 30338 RVA: 0x00210624 File Offset: 0x0020E824
		public unsafe Pot Pot
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_Pot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024B8 RID: 9400
		// (get) Token: 0x06007683 RID: 30339 RVA: 0x00210668 File Offset: 0x0020E868
		// (set) Token: 0x06007684 RID: 30340 RVA: 0x002106A4 File Offset: 0x0020E8A4
		public unsafe float NormalizedGrowthProgress
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 55725, RefRangeEnd = 55726, XrefRangeStart = 55725, XrefRangeEnd = 55726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024B9 RID: 9401
		// (get) Token: 0x06007685 RID: 30341 RVA: 0x002106E4 File Offset: 0x0020E8E4
		public unsafe bool IsFullyGrown
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 229983, RefRangeEnd = 229986, XrefRangeStart = 229983, XrefRangeEnd = 229983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170024BA RID: 9402
		// (get) Token: 0x06007686 RID: 30342 RVA: 0x00210720 File Offset: 0x0020E920
		// (set) Token: 0x06007687 RID: 30343 RVA: 0x0021075C File Offset: 0x0020E95C
		public unsafe float YieldMultiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 126089, RefRangeEnd = 126091, XrefRangeStart = 126089, XrefRangeEnd = 126091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024BB RID: 9403
		// (get) Token: 0x06007688 RID: 30344 RVA: 0x0021079C File Offset: 0x0020E99C
		// (set) Token: 0x06007689 RID: 30345 RVA: 0x002107D8 File Offset: 0x0020E9D8
		public unsafe float QualityLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29130, RefRangeEnd = 29131, XrefRangeStart = 29130, XrefRangeEnd = 29131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_QualityLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29131, RefRangeEnd = 29133, XrefRangeStart = 29131, XrefRangeEnd = 29133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_set_QualityLevel_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170024BC RID: 9404
		// (get) Token: 0x0600768A RID: 30346 RVA: 0x00210818 File Offset: 0x0020EA18
		public unsafe PlantGrowthStage FinalGrowthStage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 229986, RefRangeEnd = 229987, XrefRangeStart = 229986, XrefRangeEnd = 229986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantGrowthStage>(intPtr3) : null;
			}
		}

		// Token: 0x0600768B RID: 30347 RVA: 0x00210858 File Offset: 0x0020EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229987, XrefRangeEnd = 229994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768C RID: 30348 RVA: 0x0021088C File Offset: 0x0020EA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229994, XrefRangeEnd = 230011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(NetworkObject pot, float growthProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768D RID: 30349 RVA: 0x002108E8 File Offset: 0x0020EAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230011, XrefRangeEnd = 230019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinPass(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768E RID: 30350 RVA: 0x00210934 File Offset: 0x0020EB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230019, RefRangeEnd = 230021, XrefRangeStart = 230019, XrefRangeEnd = 230019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(additive);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInitialApplication;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600768F RID: 30351 RVA: 0x00210984 File Offset: 0x0020EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230021, XrefRangeEnd = 230031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetNormalizedGrowthProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007690 RID: 30352 RVA: 0x002109D0 File Offset: 0x0020EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230031, XrefRangeEnd = 230038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007691 RID: 30353 RVA: 0x00210A0C File Offset: 0x0020EC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230038, XrefRangeEnd = 230049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHarvestableActive(int index, bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00210A64 File Offset: 0x0020EC64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230079, RefRangeEnd = 230080, XrefRangeStart = 230049, XrefRangeEnd = 230079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnFullyHarvested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_OnFullyHarvested_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x00210A98 File Offset: 0x0020EC98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230084, RefRangeEnd = 230085, XrefRangeStart = 230080, XrefRangeEnd = 230084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHarvestableActive(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00210AE4 File Offset: 0x0020ECE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230112, RefRangeEnd = 230113, XrefRangeStart = 230085, XrefRangeEnd = 230112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrowthDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GrowthDone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00210B18 File Offset: 0x0020ED18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230140, RefRangeEnd = 230141, XrefRangeStart = 230113, XrefRangeEnd = 230140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GenerateUniqueIntegers(int min, int max, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00210B80 File Offset: 0x0020ED80
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 230144, RefRangeEnd = 230156, XrefRangeStart = 230141, XrefRangeEnd = 230144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007697 RID: 30359 RVA: 0x00210BC0 File Offset: 0x0020EDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230156, XrefRangeEnd = 230164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResizeCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_ResizeCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007698 RID: 30360 RVA: 0x00210BF4 File Offset: 0x0020EDF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230164, XrefRangeEnd = 230170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Plant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06007699 RID: 30361 RVA: 0x00210C4C File Offset: 0x0020EE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230177, RefRangeEnd = 230178, XrefRangeStart = 230170, XrefRangeEnd = 230177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData GetPlantData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_GetPlantData_Public_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr3) : null;
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x00210C8C File Offset: 0x0020EE8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230201, RefRangeEnd = 230202, XrefRangeStart = 230178, XrefRangeEnd = 230201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateAllLures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_ActivateAllLures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600769B RID: 30363 RVA: 0x00210CC0 File Offset: 0x0020EEC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230225, RefRangeEnd = 230226, XrefRangeStart = 230202, XrefRangeEnd = 230225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeactivateAllLures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr_DeactivateAllLures_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600769C RID: 30364 RVA: 0x00210CF4 File Offset: 0x0020EEF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 230238, RefRangeEnd = 230239, XrefRangeStart = 230226, XrefRangeEnd = 230238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Plant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Plant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Plant.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x000388FE File Offset: 0x00036AFE
		public Plant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024A1 RID: 9377
		// (get) Token: 0x0600769E RID: 30366 RVA: 0x00210D30 File Offset: 0x0020EF30
		// (set) Token: 0x0600769F RID: 30367 RVA: 0x00038907 File Offset: 0x00036B07
		public unsafe static float BaseQualityLevel
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Plant.NativeFieldInfoPtr_BaseQualityLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Plant.NativeFieldInfoPtr_BaseQualityLevel, (void*)(&value));
			}
		}

		// Token: 0x170024A2 RID: 9378
		// (get) Token: 0x060076A0 RID: 30368 RVA: 0x00210D4C File Offset: 0x0020EF4C
		// (set) Token: 0x060076A1 RID: 30369 RVA: 0x00038915 File Offset: 0x00036B15
		public unsafe Pot _Pot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__Pot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A3 RID: 9379
		// (get) Token: 0x060076A2 RID: 30370 RVA: 0x00210D7C File Offset: 0x0020EF7C
		// (set) Token: 0x060076A3 RID: 30371 RVA: 0x00038934 File Offset: 0x00036B34
		public unsafe float _NormalizedGrowthProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x170024A4 RID: 9380
		// (get) Token: 0x060076A4 RID: 30372 RVA: 0x00210DA4 File Offset: 0x0020EFA4
		// (set) Token: 0x060076A5 RID: 30373 RVA: 0x0003894F File Offset: 0x00036B4F
		public unsafe float _YieldMultiplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__YieldMultiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__YieldMultiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x170024A5 RID: 9381
		// (get) Token: 0x060076A6 RID: 30374 RVA: 0x00210DCC File Offset: 0x0020EFCC
		// (set) Token: 0x060076A7 RID: 30375 RVA: 0x0003896A File Offset: 0x00036B6A
		public unsafe float _QualityLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__QualityLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__QualityLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x170024A6 RID: 9382
		// (get) Token: 0x060076A8 RID: 30376 RVA: 0x00210DF4 File Offset: 0x0020EFF4
		// (set) Token: 0x060076A9 RID: 30377 RVA: 0x00038985 File Offset: 0x00036B85
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A7 RID: 9383
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x00210E24 File Offset: 0x0020F024
		// (set) Token: 0x060076AB RID: 30379 RVA: 0x000389A4 File Offset: 0x00036BA4
		public unsafe Il2CppReferenceArray<PlantGrowthStage> GrowthStages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlantGrowthStage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthStages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A8 RID: 9384
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x00210E54 File Offset: 0x0020F054
		// (set) Token: 0x060076AD RID: 30381 RVA: 0x000389C3 File Offset: 0x00036BC3
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024A9 RID: 9385
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x00210E84 File Offset: 0x0020F084
		// (set) Token: 0x060076AF RID: 30383 RVA: 0x000389E2 File Offset: 0x00036BE2
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AA RID: 9386
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x00210EB4 File Offset: 0x0020F0B4
		// (set) Token: 0x060076B1 RID: 30385 RVA: 0x00038A01 File Offset: 0x00036C01
		public unsafe AudioSourceController DestroySound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_DestroySound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AB RID: 9387
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x00210EE4 File Offset: 0x0020F0E4
		// (set) Token: 0x060076B3 RID: 30387 RVA: 0x00038A20 File Offset: 0x00036C20
		public unsafe ParticleSystem FullyGrownParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_FullyGrownParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AC RID: 9388
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x00210F14 File Offset: 0x0020F114
		// (set) Token: 0x060076B5 RID: 30389 RVA: 0x00038A3F File Offset: 0x00036C3F
		public unsafe Transform HarvestLabelPositionTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestLabelPositionTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestLabelPositionTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AD RID: 9389
		// (get) Token: 0x060076B6 RID: 30390 RVA: 0x00210F44 File Offset: 0x0020F144
		// (set) Token: 0x060076B7 RID: 30391 RVA: 0x00038A5E File Offset: 0x00036C5E
		public unsafe List<PlantHarvestable> _harvestables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__harvestables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlantHarvestable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr__harvestables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AE RID: 9390
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x00210F74 File Offset: 0x0020F174
		// (set) Token: 0x060076B9 RID: 30393 RVA: 0x00038A7D File Offset: 0x00036C7D
		public unsafe SeedDefinition SeedDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SeedDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_SeedDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024AF RID: 9391
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x00210FA4 File Offset: 0x0020F1A4
		// (set) Token: 0x060076BB RID: 30395 RVA: 0x00038A9C File Offset: 0x00036C9C
		public unsafe int GrowthTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_GrowthTime)) = value;
			}
		}

		// Token: 0x170024B0 RID: 9392
		// (get) Token: 0x060076BC RID: 30396 RVA: 0x00210FCC File Offset: 0x0020F1CC
		// (set) Token: 0x060076BD RID: 30397 RVA: 0x00038AB7 File Offset: 0x00036CB7
		public unsafe int BaseYieldQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_BaseYieldQuantity)) = value;
			}
		}

		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x060076BE RID: 30398 RVA: 0x00210FF4 File Offset: 0x0020F1F4
		// (set) Token: 0x060076BF RID: 30399 RVA: 0x00038AD2 File Offset: 0x00036CD2
		public unsafe string HarvestTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_HarvestTarget), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170024B2 RID: 9394
		// (get) Token: 0x060076C0 RID: 30400 RVA: 0x0021101C File Offset: 0x0020F21C
		// (set) Token: 0x060076C1 RID: 30401 RVA: 0x00038AF1 File Offset: 0x00036CF1
		public unsafe float MinColliderScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_MinColliderScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_MinColliderScale)) = value;
			}
		}

		// Token: 0x170024B3 RID: 9395
		// (get) Token: 0x060076C2 RID: 30402 RVA: 0x00211044 File Offset: 0x0020F244
		// (set) Token: 0x060076C3 RID: 30403 RVA: 0x00038B0C File Offset: 0x00036D0C
		public unsafe float ColliderScaleThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ColliderScaleThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ColliderScaleThreshold)) = value;
			}
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x060076C4 RID: 30404 RVA: 0x0021106C File Offset: 0x0020F26C
		// (set) Token: 0x060076C5 RID: 30405 RVA: 0x00038B27 File Offset: 0x00036D27
		public unsafe TrashItem PlantScrapPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_PlantScrapPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x060076C6 RID: 30406 RVA: 0x0021109C File Offset: 0x0020F29C
		// (set) Token: 0x060076C7 RID: 30407 RVA: 0x00038B46 File Offset: 0x00036D46
		public unsafe List<int> ActiveHarvestables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_ActiveHarvestables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x060076C8 RID: 30408 RVA: 0x002110CC File Offset: 0x0020F2CC
		// (set) Token: 0x060076C9 RID: 30409 RVA: 0x00038B65 File Offset: 0x00036D65
		public unsafe Action onFullyHarvested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onFullyHarvested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Plant.NativeFieldInfoPtr_onFullyHarvested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050B8 RID: 20664
		private static readonly IntPtr NativeFieldInfoPtr_BaseQualityLevel;

		// Token: 0x040050B9 RID: 20665
		private static readonly IntPtr NativeFieldInfoPtr__Pot_k__BackingField;

		// Token: 0x040050BA RID: 20666
		private static readonly IntPtr NativeFieldInfoPtr__NormalizedGrowthProgress_k__BackingField;

		// Token: 0x040050BB RID: 20667
		private static readonly IntPtr NativeFieldInfoPtr__YieldMultiplier_k__BackingField;

		// Token: 0x040050BC RID: 20668
		private static readonly IntPtr NativeFieldInfoPtr__QualityLevel_k__BackingField;

		// Token: 0x040050BD RID: 20669
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x040050BE RID: 20670
		private static readonly IntPtr NativeFieldInfoPtr_GrowthStages;

		// Token: 0x040050BF RID: 20671
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x040050C0 RID: 20672
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x040050C1 RID: 20673
		private static readonly IntPtr NativeFieldInfoPtr_DestroySound;

		// Token: 0x040050C2 RID: 20674
		private static readonly IntPtr NativeFieldInfoPtr_FullyGrownParticles;

		// Token: 0x040050C3 RID: 20675
		private static readonly IntPtr NativeFieldInfoPtr_HarvestLabelPositionTransform;

		// Token: 0x040050C4 RID: 20676
		private static readonly IntPtr NativeFieldInfoPtr__harvestables;

		// Token: 0x040050C5 RID: 20677
		private static readonly IntPtr NativeFieldInfoPtr_SeedDefinition;

		// Token: 0x040050C6 RID: 20678
		private static readonly IntPtr NativeFieldInfoPtr_GrowthTime;

		// Token: 0x040050C7 RID: 20679
		private static readonly IntPtr NativeFieldInfoPtr_BaseYieldQuantity;

		// Token: 0x040050C8 RID: 20680
		private static readonly IntPtr NativeFieldInfoPtr_HarvestTarget;

		// Token: 0x040050C9 RID: 20681
		private static readonly IntPtr NativeFieldInfoPtr_MinColliderScale;

		// Token: 0x040050CA RID: 20682
		private static readonly IntPtr NativeFieldInfoPtr_ColliderScaleThreshold;

		// Token: 0x040050CB RID: 20683
		private static readonly IntPtr NativeFieldInfoPtr_PlantScrapPrefab;

		// Token: 0x040050CC RID: 20684
		private static readonly IntPtr NativeFieldInfoPtr_ActiveHarvestables;

		// Token: 0x040050CD RID: 20685
		private static readonly IntPtr NativeFieldInfoPtr_onFullyHarvested;

		// Token: 0x040050CE RID: 20686
		private static readonly IntPtr NativeMethodInfoPtr_get_Pot_Public_get_Pot_0;

		// Token: 0x040050CF RID: 20687
		private static readonly IntPtr NativeMethodInfoPtr_set_Pot_Protected_set_Void_Pot_0;

		// Token: 0x040050D0 RID: 20688
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedGrowthProgress_Public_get_Single_0;

		// Token: 0x040050D1 RID: 20689
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalizedGrowthProgress_Protected_set_Void_Single_0;

		// Token: 0x040050D2 RID: 20690
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFullyGrown_Public_get_Boolean_0;

		// Token: 0x040050D3 RID: 20691
		private static readonly IntPtr NativeMethodInfoPtr_get_YieldMultiplier_Public_get_Single_0;

		// Token: 0x040050D4 RID: 20692
		private static readonly IntPtr NativeMethodInfoPtr_set_YieldMultiplier_Private_set_Void_Single_0;

		// Token: 0x040050D5 RID: 20693
		private static readonly IntPtr NativeMethodInfoPtr_get_QualityLevel_Public_get_Single_0;

		// Token: 0x040050D6 RID: 20694
		private static readonly IntPtr NativeMethodInfoPtr_set_QualityLevel_Private_set_Void_Single_0;

		// Token: 0x040050D7 RID: 20695
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalGrowthStage_Public_get_PlantGrowthStage_0;

		// Token: 0x040050D8 RID: 20696
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040050D9 RID: 20697
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_NetworkObject_Single_0;

		// Token: 0x040050DA RID: 20698
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Public_Virtual_New_Void_Int32_0;

		// Token: 0x040050DB RID: 20699
		private static readonly IntPtr NativeMethodInfoPtr_AdditiveApplied_Public_Void_AdditiveDefinition_Boolean_0;

		// Token: 0x040050DC RID: 20700
		private static readonly IntPtr NativeMethodInfoPtr_SetNormalizedGrowthProgress_Public_Virtual_New_Void_Single_0;

		// Token: 0x040050DD RID: 20701
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x040050DE RID: 20702
		private static readonly IntPtr NativeMethodInfoPtr_SetHarvestableActive_Public_Virtual_New_Void_Int32_Boolean_0;

		// Token: 0x040050DF RID: 20703
		private static readonly IntPtr NativeMethodInfoPtr_OnFullyHarvested_Private_Void_0;

		// Token: 0x040050E0 RID: 20704
		private static readonly IntPtr NativeMethodInfoPtr_IsHarvestableActive_Public_Boolean_Int32_0;

		// Token: 0x040050E1 RID: 20705
		private static readonly IntPtr NativeMethodInfoPtr_GrowthDone_Private_Void_0;

		// Token: 0x040050E2 RID: 20706
		private static readonly IntPtr NativeMethodInfoPtr_GenerateUniqueIntegers_Private_List_1_Int32_Int32_Int32_Int32_0;

		// Token: 0x040050E3 RID: 20707
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x040050E4 RID: 20708
		private static readonly IntPtr NativeMethodInfoPtr_ResizeCollider_Private_Void_0;

		// Token: 0x040050E5 RID: 20709
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_New_ItemInstance_Int32_0;

		// Token: 0x040050E6 RID: 20710
		private static readonly IntPtr NativeMethodInfoPtr_GetPlantData_Public_PlantData_0;

		// Token: 0x040050E7 RID: 20711
		private static readonly IntPtr NativeMethodInfoPtr_ActivateAllLures_Public_Void_0;

		// Token: 0x040050E8 RID: 20712
		private static readonly IntPtr NativeMethodInfoPtr_DeactivateAllLures_Public_Void_0;

		// Token: 0x040050E9 RID: 20713
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
