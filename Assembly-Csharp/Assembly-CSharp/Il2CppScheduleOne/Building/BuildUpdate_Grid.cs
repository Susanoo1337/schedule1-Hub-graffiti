using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000464 RID: 1124
	public class BuildUpdate_Grid : BuildUpdate_Base
	{
		// Token: 0x0600656B RID: 25963 RVA: 0x001DADC4 File Offset: 0x001D8FC4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Grid()
		{
			Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Grid");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr);
			BuildUpdate_Grid.NativeFieldInfoPtr__GhostModel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "<GhostModel>k__BackingField");
			BuildUpdate_Grid.NativeFieldInfoPtr__BuildableItemClass_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "<BuildableItemClass>k__BackingField");
			BuildUpdate_Grid.NativeFieldInfoPtr__ItemInstance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "<ItemInstance>k__BackingField");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionRange");
			BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "detectionMask");
			BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "rotation_Smoothing");
			BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "AllowRotation");
			BuildUpdate_Grid.NativeFieldInfoPtr_showTemperaturesByDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "showTemperaturesByDefault");
			BuildUpdate_Grid.NativeFieldInfoPtr_allowToggleShowTemperatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "allowToggleShowTemperatures");
			BuildUpdate_Grid.NativeFieldInfoPtr__validPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "_validPosition");
			BuildUpdate_Grid.NativeFieldInfoPtr__currentGhostMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "_currentGhostMaterial");
			BuildUpdate_Grid.NativeFieldInfoPtr__rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "_rotation");
			BuildUpdate_Grid.NativeFieldInfoPtr__closestIntersection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "_closestIntersection");
			BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "verticalOffset");
			BuildUpdate_Grid.NativeFieldInfoPtr__showTemperatures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, "_showTemperatures");
			BuildUpdate_Grid.NativeMethodInfoPtr_get_GhostModel_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676614);
			BuildUpdate_Grid.NativeMethodInfoPtr_set_GhostModel_Private_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676615);
			BuildUpdate_Grid.NativeMethodInfoPtr_get_BuildableItemClass_Public_get_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676616);
			BuildUpdate_Grid.NativeMethodInfoPtr_set_BuildableItemClass_Private_set_Void_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676617);
			BuildUpdate_Grid.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676618);
			BuildUpdate_Grid.NativeMethodInfoPtr_set_ItemInstance_Private_set_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676619);
			BuildUpdate_Grid.NativeMethodInfoPtr_get_AllowToggleShowTemperatures_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676620);
			BuildUpdate_Grid.NativeMethodInfoPtr_get_closestIntersection_Protected_get_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676621);
			BuildUpdate_Grid.NativeMethodInfoPtr_set_closestIntersection_Protected_set_Void_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676622);
			BuildUpdate_Grid.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_GridItem_ItemInstance_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676623);
			BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676624);
			BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676625);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckToggleTemperatureDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676626);
			BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676627);
			BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676628);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676629);
			BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676630);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676631);
			BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676632);
			BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676633);
			BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676634);
			BuildUpdate_Grid.NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_New_Void_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676635);
			BuildUpdate_Grid.NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_New_Void_TileIntersection_TileIntersection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676636);
			BuildUpdate_Grid.NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_New_Void_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676637);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676638);
			BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676639);
			BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr, 100676640);
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x0600656C RID: 25964 RVA: 0x001DB13C File Offset: 0x001D933C
		// (set) Token: 0x0600656D RID: 25965 RVA: 0x001DB17C File Offset: 0x001D937C
		public unsafe GameObject GhostModel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_get_GhostModel_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_set_GhostModel_Private_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x0600656E RID: 25966 RVA: 0x001DB1C0 File Offset: 0x001D93C0
		// (set) Token: 0x0600656F RID: 25967 RVA: 0x001DB200 File Offset: 0x001D9400
		public unsafe GridItem BuildableItemClass
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_get_BuildableItemClass_Public_get_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_set_BuildableItemClass_Private_set_Void_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06006570 RID: 25968 RVA: 0x001DB244 File Offset: 0x001D9444
		// (set) Token: 0x06006571 RID: 25969 RVA: 0x001DB284 File Offset: 0x001D9484
		public unsafe ItemInstance ItemInstance
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 2964, RefRangeEnd = 2977, XrefRangeStart = 2964, XrefRangeEnd = 2977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 2978, RefRangeEnd = 2980, XrefRangeStart = 2978, XrefRangeEnd = 2980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_set_ItemInstance_Private_set_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x06006572 RID: 25970 RVA: 0x001DB2C8 File Offset: 0x001D94C8
		public unsafe bool AllowToggleShowTemperatures
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 212214, RefRangeEnd = 212215, XrefRangeStart = 212214, XrefRangeEnd = 212214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_get_AllowToggleShowTemperatures_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x001DB304 File Offset: 0x001D9504
		// (set) Token: 0x06006574 RID: 25972 RVA: 0x001DB344 File Offset: 0x001D9544
		public unsafe TileIntersection closestIntersection
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_get_closestIntersection_Protected_get_TileIntersection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TileIntersection>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212215, XrefRangeEnd = 212217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_set_closestIntersection_Protected_set_Void_TileIntersection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x001DB388 File Offset: 0x001D9588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212220, RefRangeEnd = 212221, XrefRangeStart = 212217, XrefRangeEnd = 212220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buildableItemClass);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ghostModel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_GridItem_ItemInstance_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x001DB3FC File Offset: 0x001D95FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212221, XrefRangeEnd = 212259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x001DB438 File Offset: 0x001D9638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212280, RefRangeEnd = 212281, XrefRangeStart = 212259, XrefRangeEnd = 212280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x001DB474 File Offset: 0x001D9674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212281, XrefRangeEnd = 212295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckToggleTemperatureDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_CheckToggleTemperatureDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x001DB4A8 File Offset: 0x001D96A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212295, XrefRangeEnd = 212405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x001DB4E4 File Offset: 0x001D96E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212434, RefRangeEnd = 212435, XrefRangeStart = 212405, XrefRangeEnd = 212434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PositionObjectInFrontOfPlayer(float dist, bool sanitizeForward, bool buildPointAsOrigin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dist;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sanitizeForward;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref buildPointAsOrigin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x001DB540 File Offset: 0x001D9740
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212453, RefRangeEnd = 212454, XrefRangeStart = 212435, XrefRangeEnd = 212453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_CheckRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x001DB574 File Offset: 0x001D9774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 212486, RefRangeEnd = 212488, XrefRangeStart = 212454, XrefRangeEnd = 212486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_ApplyRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x001DB5A8 File Offset: 0x001D97A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 212510, RefRangeEnd = 212513, XrefRangeStart = 212488, XrefRangeEnd = 212510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<TileIntersection> GetRelevantIntersections(FootprintTile tile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(tile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TileIntersection>>(intPtr3) : null;
		}

		// Token: 0x0600657E RID: 25982 RVA: 0x001DB5F8 File Offset: 0x001D97F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212513, XrefRangeEnd = 212647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckIntersections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600657F RID: 25983 RVA: 0x001DB634 File Offset: 0x001D9834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212664, RefRangeEnd = 212665, XrefRangeStart = 212647, XrefRangeEnd = 212664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateMaterials()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006580 RID: 25984 RVA: 0x001DB668 File Offset: 0x001D9868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212665, XrefRangeEnd = 212719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GridItem Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_Place_Protected_Virtual_New_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x001DB6B4 File Offset: 0x001D98B4
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlacedObjectPreSpawn(GridItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_New_Void_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x001DB704 File Offset: 0x001D9904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212719, XrefRangeEnd = 212735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnClosestIntersectionChanged(TileIntersection previous, TileIntersection current)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(previous);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_New_Void_TileIntersection_TileIntersection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x001DB764 File Offset: 0x001D9964
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212746, RefRangeEnd = 212747, XrefRangeStart = 212735, XrefRangeEnd = 212746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetShowTemperatures(bool show, Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref show;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Grid.NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_New_Void_Boolean_Property_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006584 RID: 25988 RVA: 0x001DB7C0 File Offset: 0x001D99C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212747, XrefRangeEnd = 212753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2 GetOriginCoordinate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006585 RID: 25989 RVA: 0x001DB7FC File Offset: 0x001D99FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212753, XrefRangeEnd = 212768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grid GetHoveredGrid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Grid>(intPtr3) : null;
		}

		// Token: 0x06006586 RID: 25990 RVA: 0x001DB83C File Offset: 0x001D9A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212769, RefRangeEnd = 212770, XrefRangeStart = 212768, XrefRangeEnd = 212769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Grid() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Grid>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Grid.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x0002FBCD File Offset: 0x0002DDCD
		public BuildUpdate_Grid(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06006588 RID: 25992 RVA: 0x001DB878 File Offset: 0x001D9A78
		// (set) Token: 0x06006589 RID: 25993 RVA: 0x0002FBD6 File Offset: 0x0002DDD6
		public unsafe GameObject _GhostModel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__GhostModel_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__GhostModel_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600658A RID: 25994 RVA: 0x001DB8A8 File Offset: 0x001D9AA8
		// (set) Token: 0x0600658B RID: 25995 RVA: 0x0002FBF5 File Offset: 0x0002DDF5
		public unsafe GridItem _BuildableItemClass_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__BuildableItemClass_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__BuildableItemClass_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600658C RID: 25996 RVA: 0x001DB8D8 File Offset: 0x001D9AD8
		// (set) Token: 0x0600658D RID: 25997 RVA: 0x0002FC14 File Offset: 0x0002DE14
		public unsafe ItemInstance _ItemInstance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__ItemInstance_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__ItemInstance_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600658E RID: 25998 RVA: 0x001DB908 File Offset: 0x001D9B08
		// (set) Token: 0x0600658F RID: 25999 RVA: 0x0002FC33 File Offset: 0x0002DE33
		public unsafe float detectionRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionRange)) = value;
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x06006590 RID: 26000 RVA: 0x001DB930 File Offset: 0x001D9B30
		// (set) Token: 0x06006591 RID: 26001 RVA: 0x0002FC4E File Offset: 0x0002DE4E
		public unsafe LayerMask detectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_detectionMask)) = value;
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x001DB958 File Offset: 0x001D9B58
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x0002FC69 File Offset: 0x0002DE69
		public unsafe float rotation_Smoothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_rotation_Smoothing)) = value;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x001DB980 File Offset: 0x001D9B80
		// (set) Token: 0x06006595 RID: 26005 RVA: 0x0002FC84 File Offset: 0x0002DE84
		public unsafe bool AllowRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_AllowRotation)) = value;
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x001DB9A8 File Offset: 0x001D9BA8
		// (set) Token: 0x06006597 RID: 26007 RVA: 0x0002FC9F File Offset: 0x0002DE9F
		public unsafe bool showTemperaturesByDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_showTemperaturesByDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_showTemperaturesByDefault)) = value;
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06006598 RID: 26008 RVA: 0x001DB9D0 File Offset: 0x001D9BD0
		// (set) Token: 0x06006599 RID: 26009 RVA: 0x0002FCBA File Offset: 0x0002DEBA
		public unsafe bool allowToggleShowTemperatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_allowToggleShowTemperatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_allowToggleShowTemperatures)) = value;
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x0600659A RID: 26010 RVA: 0x001DB9F8 File Offset: 0x001D9BF8
		// (set) Token: 0x0600659B RID: 26011 RVA: 0x0002FCD5 File Offset: 0x0002DED5
		public unsafe bool _validPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__validPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__validPosition)) = value;
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600659C RID: 26012 RVA: 0x001DBA20 File Offset: 0x001D9C20
		// (set) Token: 0x0600659D RID: 26013 RVA: 0x0002FCF0 File Offset: 0x0002DEF0
		public unsafe Material _currentGhostMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__currentGhostMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__currentGhostMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600659E RID: 26014 RVA: 0x001DBA50 File Offset: 0x001D9C50
		// (set) Token: 0x0600659F RID: 26015 RVA: 0x0002FD0F File Offset: 0x0002DF0F
		public unsafe float _rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__rotation)) = value;
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x060065A0 RID: 26016 RVA: 0x001DBA78 File Offset: 0x001D9C78
		// (set) Token: 0x060065A1 RID: 26017 RVA: 0x0002FD2A File Offset: 0x0002DF2A
		public unsafe TileIntersection _closestIntersection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__closestIntersection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TileIntersection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__closestIntersection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x060065A2 RID: 26018 RVA: 0x001DBAA8 File Offset: 0x001D9CA8
		// (set) Token: 0x060065A3 RID: 26019 RVA: 0x0002FD49 File Offset: 0x0002DF49
		public unsafe float verticalOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr_verticalOffset)) = value;
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x060065A4 RID: 26020 RVA: 0x001DBAD0 File Offset: 0x001D9CD0
		// (set) Token: 0x060065A5 RID: 26021 RVA: 0x0002FD64 File Offset: 0x0002DF64
		public unsafe bool _showTemperatures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__showTemperatures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Grid.NativeFieldInfoPtr__showTemperatures)) = value;
			}
		}

		// Token: 0x040045E2 RID: 17890
		private static readonly IntPtr NativeFieldInfoPtr__GhostModel_k__BackingField;

		// Token: 0x040045E3 RID: 17891
		private static readonly IntPtr NativeFieldInfoPtr__BuildableItemClass_k__BackingField;

		// Token: 0x040045E4 RID: 17892
		private static readonly IntPtr NativeFieldInfoPtr__ItemInstance_k__BackingField;

		// Token: 0x040045E5 RID: 17893
		private static readonly IntPtr NativeFieldInfoPtr_detectionRange;

		// Token: 0x040045E6 RID: 17894
		private static readonly IntPtr NativeFieldInfoPtr_detectionMask;

		// Token: 0x040045E7 RID: 17895
		private static readonly IntPtr NativeFieldInfoPtr_rotation_Smoothing;

		// Token: 0x040045E8 RID: 17896
		private static readonly IntPtr NativeFieldInfoPtr_AllowRotation;

		// Token: 0x040045E9 RID: 17897
		private static readonly IntPtr NativeFieldInfoPtr_showTemperaturesByDefault;

		// Token: 0x040045EA RID: 17898
		private static readonly IntPtr NativeFieldInfoPtr_allowToggleShowTemperatures;

		// Token: 0x040045EB RID: 17899
		private static readonly IntPtr NativeFieldInfoPtr__validPosition;

		// Token: 0x040045EC RID: 17900
		private static readonly IntPtr NativeFieldInfoPtr__currentGhostMaterial;

		// Token: 0x040045ED RID: 17901
		private static readonly IntPtr NativeFieldInfoPtr__rotation;

		// Token: 0x040045EE RID: 17902
		private static readonly IntPtr NativeFieldInfoPtr__closestIntersection;

		// Token: 0x040045EF RID: 17903
		private static readonly IntPtr NativeFieldInfoPtr_verticalOffset;

		// Token: 0x040045F0 RID: 17904
		private static readonly IntPtr NativeFieldInfoPtr__showTemperatures;

		// Token: 0x040045F1 RID: 17905
		private static readonly IntPtr NativeMethodInfoPtr_get_GhostModel_Public_get_GameObject_0;

		// Token: 0x040045F2 RID: 17906
		private static readonly IntPtr NativeMethodInfoPtr_set_GhostModel_Private_set_Void_GameObject_0;

		// Token: 0x040045F3 RID: 17907
		private static readonly IntPtr NativeMethodInfoPtr_get_BuildableItemClass_Public_get_GridItem_0;

		// Token: 0x040045F4 RID: 17908
		private static readonly IntPtr NativeMethodInfoPtr_set_BuildableItemClass_Private_set_Void_GridItem_0;

		// Token: 0x040045F5 RID: 17909
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemInstance_Public_get_ItemInstance_0;

		// Token: 0x040045F6 RID: 17910
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemInstance_Private_set_Void_ItemInstance_0;

		// Token: 0x040045F7 RID: 17911
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowToggleShowTemperatures_Public_get_Boolean_0;

		// Token: 0x040045F8 RID: 17912
		private static readonly IntPtr NativeMethodInfoPtr_get_closestIntersection_Protected_get_TileIntersection_0;

		// Token: 0x040045F9 RID: 17913
		private static readonly IntPtr NativeMethodInfoPtr_set_closestIntersection_Protected_set_Void_TileIntersection_0;

		// Token: 0x040045FA RID: 17914
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_GridItem_ItemInstance_GameObject_0;

		// Token: 0x040045FB RID: 17915
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040045FC RID: 17916
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040045FD RID: 17917
		private static readonly IntPtr NativeMethodInfoPtr_CheckToggleTemperatureDisplay_Private_Void_0;

		// Token: 0x040045FE RID: 17918
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040045FF RID: 17919
		private static readonly IntPtr NativeMethodInfoPtr_PositionObjectInFrontOfPlayer_Protected_Void_Single_Boolean_Boolean_0;

		// Token: 0x04004600 RID: 17920
		private static readonly IntPtr NativeMethodInfoPtr_CheckRotation_Protected_Void_0;

		// Token: 0x04004601 RID: 17921
		private static readonly IntPtr NativeMethodInfoPtr_ApplyRotation_Protected_Void_0;

		// Token: 0x04004602 RID: 17922
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantIntersections_Private_List_1_TileIntersection_FootprintTile_0;

		// Token: 0x04004603 RID: 17923
		private static readonly IntPtr NativeMethodInfoPtr_CheckIntersections_Protected_Virtual_New_Void_0;

		// Token: 0x04004604 RID: 17924
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMaterials_Protected_Void_0;

		// Token: 0x04004605 RID: 17925
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_New_GridItem_0;

		// Token: 0x04004606 RID: 17926
		private static readonly IntPtr NativeMethodInfoPtr_OnPlacedObjectPreSpawn_Protected_Virtual_New_Void_GridItem_0;

		// Token: 0x04004607 RID: 17927
		private static readonly IntPtr NativeMethodInfoPtr_OnClosestIntersectionChanged_Protected_Virtual_New_Void_TileIntersection_TileIntersection_0;

		// Token: 0x04004608 RID: 17928
		private static readonly IntPtr NativeMethodInfoPtr_SetShowTemperatures_Protected_Virtual_New_Void_Boolean_Property_0;

		// Token: 0x04004609 RID: 17929
		private static readonly IntPtr NativeMethodInfoPtr_GetOriginCoordinate_Private_Vector2_0;

		// Token: 0x0400460A RID: 17930
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredGrid_Private_Grid_0;

		// Token: 0x0400460B RID: 17931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
