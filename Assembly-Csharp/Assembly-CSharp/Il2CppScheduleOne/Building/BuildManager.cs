using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppScheduleOne.UI.Input;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x02000459 RID: 1113
	public class BuildManager : NetworkSingleton<BuildManager>
	{
		// Token: 0x060064F0 RID: 25840 RVA: 0x001D90F4 File Offset: 0x001D72F4
		// Note: this type is marked as 'beforefieldinit'.
		static BuildManager()
		{
			Il2CppClassPointerStore<BuildManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager>.NativeClassPtr);
			BuildManager.NativeFieldInfoPtr_PlaceSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "PlaceSounds");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_White = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_White");
			BuildManager.NativeFieldInfoPtr_ghostMaterial_Red = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ghostMaterial_Red");
			BuildManager.NativeFieldInfoPtr_PlaceObjectAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "PlaceObjectAction");
			BuildManager.NativeFieldInfoPtr_RotateLeftAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "RotateLeftAction");
			BuildManager.NativeFieldInfoPtr_RotateRightAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "RotateRightAction");
			BuildManager.NativeFieldInfoPtr_ToggleHeatmapInputModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "ToggleHeatmapInputModule");
			BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<isBuilding>k__BackingField");
			BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<currentBuildHandler>k__BackingField");
			BuildManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Building.BuildManagerAssembly-CSharp.dll_Excuted");
			BuildManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Building.BuildManagerAssembly-CSharp.dll_Excuted");
			BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676552);
			BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676553);
			BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676554);
			BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676555);
			BuildManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676556);
			BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676557);
			BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676558);
			BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676559);
			BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676560);
			BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676561);
			BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676562);
			BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676563);
			BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676564);
			BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676565);
			BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676566);
			BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_Action_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676567);
			BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676568);
			BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676569);
			BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676570);
			BuildManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676571);
			BuildManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676572);
			BuildManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676573);
			BuildManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, 100676574);
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060064F1 RID: 25841 RVA: 0x001D93CC File Offset: 0x001D75CC
		// (set) Token: 0x060064F2 RID: 25842 RVA: 0x001D9408 File Offset: 0x001D7608
		public unsafe bool isBuilding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060064F3 RID: 25843 RVA: 0x001D9448 File Offset: 0x001D7648
		// (set) Token: 0x060064F4 RID: 25844 RVA: 0x001D9488 File Offset: 0x001D7688
		public unsafe GameObject currentBuildHandler
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060064F5 RID: 25845 RVA: 0x001D94CC File Offset: 0x001D76CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211432, XrefRangeEnd = 211435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F6 RID: 25846 RVA: 0x001D9508 File Offset: 0x001D7708
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211468, RefRangeEnd = 211470, XrefRangeStart = 211435, XrefRangeEnd = 211468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartBuilding(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F7 RID: 25847 RVA: 0x001D954C File Offset: 0x001D774C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211474, RefRangeEnd = 211476, XrefRangeStart = 211470, XrefRangeEnd = 211474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopBuilding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_StopBuilding_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x001D9580 File Offset: 0x001D7780
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211491, RefRangeEnd = 211492, XrefRangeStart = 211476, XrefRangeEnd = 211491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x001D95CC File Offset: 0x001D77CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211492, XrefRangeEnd = 211497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableColliders(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FA RID: 25850 RVA: 0x001D9610 File Offset: 0x001D7810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211497, XrefRangeEnd = 211507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableLights(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FB RID: 25851 RVA: 0x001D9654 File Offset: 0x001D7854
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211515, RefRangeEnd = 211518, XrefRangeStart = 211507, XrefRangeEnd = 211515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNetworking(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FC RID: 25852 RVA: 0x001D9698 File Offset: 0x001D7898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211518, XrefRangeEnd = 211523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableSpriteRenderers(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FD RID: 25853 RVA: 0x001D96DC File Offset: 0x001D78DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211542, RefRangeEnd = 211545, XrefRangeStart = 211523, XrefRangeEnd = 211542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allMaterials;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FE RID: 25854 RVA: 0x001D9740 File Offset: 0x001D7940
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211560, RefRangeEnd = 211563, XrefRangeStart = 211545, XrefRangeEnd = 211560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableNavigation(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060064FF RID: 25855 RVA: 0x001D9784 File Offset: 0x001D7984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211563, XrefRangeEnd = 211568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableCanvases(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006500 RID: 25856 RVA: 0x001D97C8 File Offset: 0x001D79C8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 211606, RefRangeEnd = 211620, XrefRangeStart = 211568, XrefRangeEnd = 211606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "", Action<GridItem> onBeforeSpawn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onBeforeSpawn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_Action_1_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x06006501 RID: 25857 RVA: 0x001D986C File Offset: 0x001D7A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211620, XrefRangeEnd = 211649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(matches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x001D98F0 File Offset: 0x001D7AF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211679, RefRangeEnd = 211684, XrefRangeStart = 211649, XrefRangeEnd = 211679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentSurface);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativePosition;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref relativeRotation;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x06006503 RID: 25859 RVA: 0x001D9984 File Offset: 0x001D7B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211684, XrefRangeEnd = 211694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006504 RID: 25860 RVA: 0x001D99C0 File Offset: 0x001D7BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211694, XrefRangeEnd = 211697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006505 RID: 25861 RVA: 0x001D99FC File Offset: 0x001D7BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211697, XrefRangeEnd = 211700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006506 RID: 25862 RVA: 0x001D9A38 File Offset: 0x001D7C38
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006507 RID: 25863 RVA: 0x001D9A74 File Offset: 0x001D7C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211700, XrefRangeEnd = 211703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006508 RID: 25864 RVA: 0x0002F900 File Offset: 0x0002DB00
		public BuildManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x06006509 RID: 25865 RVA: 0x001D9AB0 File Offset: 0x001D7CB0
		// (set) Token: 0x0600650A RID: 25866 RVA: 0x0002F909 File Offset: 0x0002DB09
		public unsafe List<BuildManager.BuildSound> PlaceSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildManager.BuildSound>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceSounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x0600650B RID: 25867 RVA: 0x001D9AE0 File Offset: 0x001D7CE0
		// (set) Token: 0x0600650C RID: 25868 RVA: 0x0002F928 File Offset: 0x0002DB28
		public unsafe Material ghostMaterial_White
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_White), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x0600650D RID: 25869 RVA: 0x001D9B10 File Offset: 0x001D7D10
		// (set) Token: 0x0600650E RID: 25870 RVA: 0x0002F947 File Offset: 0x0002DB47
		public unsafe Material ghostMaterial_Red
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ghostMaterial_Red), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x0600650F RID: 25871 RVA: 0x001D9B40 File Offset: 0x001D7D40
		// (set) Token: 0x06006510 RID: 25872 RVA: 0x0002F966 File Offset: 0x0002DB66
		public unsafe InputActionReference PlaceObjectAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceObjectAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_PlaceObjectAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06006511 RID: 25873 RVA: 0x001D9B70 File Offset: 0x001D7D70
		// (set) Token: 0x06006512 RID: 25874 RVA: 0x0002F985 File Offset: 0x0002DB85
		public unsafe InputActionReference RotateLeftAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_RotateLeftAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_RotateLeftAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x06006513 RID: 25875 RVA: 0x001D9BA0 File Offset: 0x001D7DA0
		// (set) Token: 0x06006514 RID: 25876 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		public unsafe InputActionReference RotateRightAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_RotateRightAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_RotateRightAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x06006515 RID: 25877 RVA: 0x001D9BD0 File Offset: 0x001D7DD0
		// (set) Token: 0x06006516 RID: 25878 RVA: 0x0002F9C3 File Offset: 0x0002DBC3
		public unsafe InputPromptsData ToggleHeatmapInputModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ToggleHeatmapInputModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputPromptsData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_ToggleHeatmapInputModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06006517 RID: 25879 RVA: 0x001D9C00 File Offset: 0x001D7E00
		// (set) Token: 0x06006518 RID: 25880 RVA: 0x0002F9E2 File Offset: 0x0002DBE2
		public unsafe bool _isBuilding_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__isBuilding_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06006519 RID: 25881 RVA: 0x001D9C28 File Offset: 0x001D7E28
		// (set) Token: 0x0600651A RID: 25882 RVA: 0x0002F9FD File Offset: 0x0002DBFD
		public unsafe GameObject _currentBuildHandler_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr__currentBuildHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x0600651B RID: 25883 RVA: 0x001D9C58 File Offset: 0x001D7E58
		// (set) Token: 0x0600651C RID: 25884 RVA: 0x0002FA1C File Offset: 0x0002DC1C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x0600651D RID: 25885 RVA: 0x001D9C80 File Offset: 0x001D7E80
		// (set) Token: 0x0600651E RID: 25886 RVA: 0x0002FA37 File Offset: 0x0002DC37
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004592 RID: 17810
		private static readonly IntPtr NativeFieldInfoPtr_PlaceSounds;

		// Token: 0x04004593 RID: 17811
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_White;

		// Token: 0x04004594 RID: 17812
		private static readonly IntPtr NativeFieldInfoPtr_ghostMaterial_Red;

		// Token: 0x04004595 RID: 17813
		private static readonly IntPtr NativeFieldInfoPtr_PlaceObjectAction;

		// Token: 0x04004596 RID: 17814
		private static readonly IntPtr NativeFieldInfoPtr_RotateLeftAction;

		// Token: 0x04004597 RID: 17815
		private static readonly IntPtr NativeFieldInfoPtr_RotateRightAction;

		// Token: 0x04004598 RID: 17816
		private static readonly IntPtr NativeFieldInfoPtr_ToggleHeatmapInputModule;

		// Token: 0x04004599 RID: 17817
		private static readonly IntPtr NativeFieldInfoPtr__isBuilding_k__BackingField;

		// Token: 0x0400459A RID: 17818
		private static readonly IntPtr NativeFieldInfoPtr__currentBuildHandler_k__BackingField;

		// Token: 0x0400459B RID: 17819
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400459C RID: 17820
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400459D RID: 17821
		private static readonly IntPtr NativeMethodInfoPtr_get_isBuilding_Public_get_Boolean_0;

		// Token: 0x0400459E RID: 17822
		private static readonly IntPtr NativeMethodInfoPtr_set_isBuilding_Protected_set_Void_Boolean_0;

		// Token: 0x0400459F RID: 17823
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBuildHandler_Public_get_GameObject_0;

		// Token: 0x040045A0 RID: 17824
		private static readonly IntPtr NativeMethodInfoPtr_set_currentBuildHandler_Protected_set_Void_GameObject_0;

		// Token: 0x040045A1 RID: 17825
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040045A2 RID: 17826
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Void_ItemInstance_0;

		// Token: 0x040045A3 RID: 17827
		private static readonly IntPtr NativeMethodInfoPtr_StopBuilding_Public_Void_0;

		// Token: 0x040045A4 RID: 17828
		private static readonly IntPtr NativeMethodInfoPtr_PlayBuildSound_Public_Void_EBuildSoundType_Vector3_0;

		// Token: 0x040045A5 RID: 17829
		private static readonly IntPtr NativeMethodInfoPtr_DisableColliders_Public_Void_GameObject_0;

		// Token: 0x040045A6 RID: 17830
		private static readonly IntPtr NativeMethodInfoPtr_DisableLights_Public_Void_GameObject_0;

		// Token: 0x040045A7 RID: 17831
		private static readonly IntPtr NativeMethodInfoPtr_DisableNetworking_Public_Void_GameObject_0;

		// Token: 0x040045A8 RID: 17832
		private static readonly IntPtr NativeMethodInfoPtr_DisableSpriteRenderers_Public_Void_GameObject_0;

		// Token: 0x040045A9 RID: 17833
		private static readonly IntPtr NativeMethodInfoPtr_ApplyMaterial_Public_Void_GameObject_Material_Boolean_0;

		// Token: 0x040045AA RID: 17834
		private static readonly IntPtr NativeMethodInfoPtr_DisableNavigation_Public_Void_GameObject_0;

		// Token: 0x040045AB RID: 17835
		private static readonly IntPtr NativeMethodInfoPtr_DisableCanvases_Public_Void_GameObject_0;

		// Token: 0x040045AC RID: 17836
		private static readonly IntPtr NativeMethodInfoPtr_CreateGridItem_Public_GridItem_ItemInstance_Grid_Vector2_Int32_String_Action_1_GridItem_0;

		// Token: 0x040045AD RID: 17837
		private static readonly IntPtr NativeMethodInfoPtr_CreateProceduralGridItem_Public_ProceduralGridItem_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x040045AE RID: 17838
		private static readonly IntPtr NativeMethodInfoPtr_CreateSurfaceItem_Public_SurfaceItem_ItemInstance_Surface_Vector3_Quaternion_String_0;

		// Token: 0x040045AF RID: 17839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045B0 RID: 17840
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040045B1 RID: 17841
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040045B2 RID: 17842
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040045B3 RID: 17843
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000B41 RID: 2881
		[Serializable]
		public class BuildSound : Il2CppSystem.Object
		{
			// Token: 0x0600E70A RID: 59146 RVA: 0x00385794 File Offset: 0x00383994
			// Note: this type is marked as 'beforefieldinit'.
			static BuildSound()
			{
				Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "BuildSound");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr);
				BuildManager.BuildSound.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Type");
				BuildManager.BuildSound.NativeFieldInfoPtr_Sound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, "Sound");
				BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr, 100676575);
			}

			// Token: 0x0600E70B RID: 59147 RVA: 0x003857FC File Offset: 0x003839FC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuildSound() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.BuildSound>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.BuildSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E70C RID: 59148 RVA: 0x0006CF9A File Offset: 0x0006B19A
			public BuildSound(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700461E RID: 17950
			// (get) Token: 0x0600E70D RID: 59149 RVA: 0x00385838 File Offset: 0x00383A38
			// (set) Token: 0x0600E70E RID: 59150 RVA: 0x0006CFA3 File Offset: 0x0006B1A3
			public unsafe BuildableItemDefinition.EBuildSoundType Type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Type)) = value;
				}
			}

			// Token: 0x1700461F RID: 17951
			// (get) Token: 0x0600E70F RID: 59151 RVA: 0x00385860 File Offset: 0x00383A60
			// (set) Token: 0x0600E710 RID: 59152 RVA: 0x0006CFBE File Offset: 0x0006B1BE
			public unsafe AudioSourceController Sound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.BuildSound.NativeFieldInfoPtr_Sound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CD1 RID: 40145
			private static readonly IntPtr NativeFieldInfoPtr_Type;

			// Token: 0x04009CD2 RID: 40146
			private static readonly IntPtr NativeFieldInfoPtr_Sound;

			// Token: 0x04009CD3 RID: 40147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B42 RID: 2882
		[ObfuscatedName("ScheduleOne.Building.BuildManager+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E711 RID: 59153 RVA: 0x00385890 File Offset: 0x00383A90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuildManager>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr);
				BuildManager.__c__DisplayClass19_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr, "type");
				BuildManager.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr, 100676576);
				BuildManager.__c__DisplayClass19_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr, 100676577);
			}

			// Token: 0x0600E712 RID: 59154 RVA: 0x003858F8 File Offset: 0x00383AF8
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildManager.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E713 RID: 59155 RVA: 0x00385934 File Offset: 0x00383B34
			[CallerCount(0)]
			public unsafe bool _PlayBuildSound_b__0(BuildManager.BuildSound s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildManager.__c__DisplayClass19_0.NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E714 RID: 59156 RVA: 0x0006CFDD File Offset: 0x0006B1DD
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004620 RID: 17952
			// (get) Token: 0x0600E715 RID: 59157 RVA: 0x00385984 File Offset: 0x00383B84
			// (set) Token: 0x0600E716 RID: 59158 RVA: 0x0006CFE6 File Offset: 0x0006B1E6
			public unsafe BuildableItemDefinition.EBuildSoundType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass19_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildManager.__c__DisplayClass19_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04009CD4 RID: 40148
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04009CD5 RID: 40149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CD6 RID: 40150
			private static readonly IntPtr NativeMethodInfoPtr__PlayBuildSound_b__0_Internal_Boolean_BuildSound_0;
		}
	}
}
