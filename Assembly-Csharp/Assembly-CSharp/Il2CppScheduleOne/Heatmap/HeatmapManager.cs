using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Temperature;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Heatmap
{
	// Token: 0x0200033B RID: 827
	public class HeatmapManager : Singleton<HeatmapManager>
	{
		// Token: 0x06004727 RID: 18215 RVA: 0x0016CE94 File Offset: 0x0016B094
		// Note: this type is marked as 'beforefieldinit'.
		static HeatmapManager()
		{
			Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Heatmap", "HeatmapManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr);
			HeatmapManager.NativeFieldInfoPtr_onHeatmapVisibilityChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "onHeatmapVisibilityChanged");
			HeatmapManager.NativeFieldInfoPtr__shader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_shader");
			HeatmapManager.NativeFieldInfoPtr__heatmaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_heatmaps");
			HeatmapManager.NativeFieldInfoPtr__heatmapRegionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_heatmapRegionPrefab");
			HeatmapManager.NativeFieldInfoPtr__heatmapMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_heatmapMat");
			HeatmapManager.NativeFieldInfoPtr__gradientTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_gradientTexture");
			HeatmapManager.NativeFieldInfoPtr__propertyCodeToTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_propertyCodeToTest");
			HeatmapManager.NativeFieldInfoPtr__propertyGridMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_propertyGridMasks");
			HeatmapManager.NativeFieldInfoPtr__propertyRegionReferences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_propertyRegionReferences");
			HeatmapManager.NativeFieldInfoPtr__kernal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_kernal");
			HeatmapManager.NativeFieldInfoPtr__textureDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "_textureDepth");
			HeatmapManager.NativeFieldInfoPtr_TEXTURE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "TEXTURE_SIZE");
			HeatmapManager.NativeFieldInfoPtr_MAX_REGIONS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "MAX_REGIONS");
			HeatmapManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672418);
			HeatmapManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672419);
			HeatmapManager.NativeMethodInfoPtr_Initialise_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672420);
			HeatmapManager.NativeMethodInfoPtr_SetShader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672421);
			HeatmapManager.NativeMethodInfoPtr_SetPropertyData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672422);
			HeatmapManager.NativeMethodInfoPtr_OnEmitterUpdate_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672423);
			HeatmapManager.NativeMethodInfoPtr_DispatchHeatmap_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672424);
			HeatmapManager.NativeMethodInfoPtr_GetPropertyRegionStartAndEndIndex_Private_Vector2Int_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672425);
			HeatmapManager.NativeMethodInfoPtr_SetHeatmapActive_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672426);
			HeatmapManager.NativeMethodInfoPtr_SetHeatmapActive_Public_Void_Property_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672427);
			HeatmapManager.NativeMethodInfoPtr_ToggleHeatmapActive_Public_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672428);
			HeatmapManager.NativeMethodInfoPtr_SetAllHeatmapsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672429);
			HeatmapManager.NativeMethodInfoPtr_IsHeatmapActive_Public_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672430);
			HeatmapManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672431);
			HeatmapManager.NativeMethodInfoPtr_TurnOnAllHeatmaps_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672432);
			HeatmapManager.NativeMethodInfoPtr_TurnOffAllHeatmaps_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672433);
			HeatmapManager.NativeMethodInfoPtr_RunDispatchHeatmap_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672434);
			HeatmapManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672435);
			HeatmapManager.NativeMethodInfoPtr__RunDispatchHeatmap_b__31_0_Private_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, 100672436);
		}

		// Token: 0x06004728 RID: 18216 RVA: 0x0016D144 File Offset: 0x0016B344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166395, XrefRangeEnd = 166412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeatmapManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004729 RID: 18217 RVA: 0x0016D180 File Offset: 0x0016B380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166412, XrefRangeEnd = 166418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeatmapManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472A RID: 18218 RVA: 0x0016D1BC File Offset: 0x0016B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166418, XrefRangeEnd = 166432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialise()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_Initialise_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472B RID: 18219 RVA: 0x0016D1F0 File Offset: 0x0016B3F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166471, RefRangeEnd = 166472, XrefRangeStart = 166432, XrefRangeEnd = 166471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_SetShader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472C RID: 18220 RVA: 0x0016D224 File Offset: 0x0016B424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166561, RefRangeEnd = 166562, XrefRangeStart = 166472, XrefRangeEnd = 166561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPropertyData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_SetPropertyData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472D RID: 18221 RVA: 0x0016D258 File Offset: 0x0016B458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166562, XrefRangeEnd = 166563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEmitterUpdate(string propertyCode, Il2CppStructArray<TemperatureEmitterInfo> emitterInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(emitterInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_OnEmitterUpdate_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472E RID: 18222 RVA: 0x0016D2AC File Offset: 0x0016B4AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166620, RefRangeEnd = 166623, XrefRangeStart = 166563, XrefRangeEnd = 166620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchHeatmap(string propertyCode, Il2CppStructArray<TemperatureEmitterInfo> emitterInfos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(emitterInfos);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_DispatchHeatmap_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600472F RID: 18223 RVA: 0x0016D300 File Offset: 0x0016B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166623, XrefRangeEnd = 166631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int GetPropertyRegionStartAndEndIndex(string propertyCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_GetPropertyRegionStartAndEndIndex_Private_Vector2Int_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004730 RID: 18224 RVA: 0x0016D350 File Offset: 0x0016B550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166631, XrefRangeEnd = 166638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeatmapActive(string propertyCode, bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyCode);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_SetHeatmapActive_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004731 RID: 18225 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 166661, RefRangeEnd = 166671, XrefRangeStart = 166638, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHeatmapActive(Property property, bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_SetHeatmapActive_Public_Void_Property_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x0016D3F0 File Offset: 0x0016B5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166671, XrefRangeEnd = 166681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleHeatmapActive(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_ToggleHeatmapActive_Public_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x0016D434 File Offset: 0x0016B634
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166700, RefRangeEnd = 166702, XrefRangeStart = 166681, XrefRangeEnd = 166700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAllHeatmapsActive(bool isActive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isActive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_SetAllHeatmapsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004734 RID: 18228 RVA: 0x0016D474 File Offset: 0x0016B674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 166717, RefRangeEnd = 166719, XrefRangeStart = 166702, XrefRangeEnd = 166717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHeatmapActive(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_IsHeatmapActive_Public_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004735 RID: 18229 RVA: 0x0016D4C4 File Offset: 0x0016B6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166719, XrefRangeEnd = 166723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HeatmapManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004736 RID: 18230 RVA: 0x0016D500 File Offset: 0x0016B700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166723, XrefRangeEnd = 166742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOnAllHeatmaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_TurnOnAllHeatmaps_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004737 RID: 18231 RVA: 0x0016D534 File Offset: 0x0016B734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166742, XrefRangeEnd = 166761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOffAllHeatmaps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_TurnOffAllHeatmaps_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004738 RID: 18232 RVA: 0x0016D568 File Offset: 0x0016B768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166761, XrefRangeEnd = 166782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunDispatchHeatmap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr_RunDispatchHeatmap_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004739 RID: 18233 RVA: 0x0016D59C File Offset: 0x0016B79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166782, XrefRangeEnd = 166785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HeatmapManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600473A RID: 18234 RVA: 0x0016D5D8 File Offset: 0x0016B7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166785, XrefRangeEnd = 166787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _RunDispatchHeatmap_b__31_0(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.NativeMethodInfoPtr__RunDispatchHeatmap_b__31_0_Private_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00022C06 File Offset: 0x00020E06
		public HeatmapManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x0600473C RID: 18236 RVA: 0x0016D628 File Offset: 0x0016B828
		// (set) Token: 0x0600473D RID: 18237 RVA: 0x00022C0F File Offset: 0x00020E0F
		public unsafe Action<Property, bool> onHeatmapVisibilityChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr_onHeatmapVisibilityChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Property, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr_onHeatmapVisibilityChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x0600473E RID: 18238 RVA: 0x0016D658 File Offset: 0x0016B858
		// (set) Token: 0x0600473F RID: 18239 RVA: 0x00022C2E File Offset: 0x00020E2E
		public unsafe ComputeShader _shader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__shader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__shader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x06004740 RID: 18240 RVA: 0x0016D688 File Offset: 0x0016B888
		// (set) Token: 0x06004741 RID: 18241 RVA: 0x00022C4D File Offset: 0x00020E4D
		public unsafe RenderTexture _heatmaps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmaps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmaps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06004742 RID: 18242 RVA: 0x0016D6B8 File Offset: 0x0016B8B8
		// (set) Token: 0x06004743 RID: 18243 RVA: 0x00022C6C File Offset: 0x00020E6C
		public unsafe HeatmapRegion _heatmapRegionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmapRegionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HeatmapRegion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmapRegionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x0016D6E8 File Offset: 0x0016B8E8
		// (set) Token: 0x06004745 RID: 18245 RVA: 0x00022C8B File Offset: 0x00020E8B
		public unsafe Material _heatmapMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmapMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__heatmapMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x0016D718 File Offset: 0x0016B918
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x00022CAA File Offset: 0x00020EAA
		public unsafe Texture2D _gradientTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__gradientTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__gradientTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x06004748 RID: 18248 RVA: 0x0016D748 File Offset: 0x0016B948
		// (set) Token: 0x06004749 RID: 18249 RVA: 0x00022CC9 File Offset: 0x00020EC9
		public unsafe string _propertyCodeToTest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyCodeToTest);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyCodeToTest), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x0600474A RID: 18250 RVA: 0x0016D770 File Offset: 0x0016B970
		// (set) Token: 0x0600474B RID: 18251 RVA: 0x00022CE8 File Offset: 0x00020EE8
		public unsafe Dictionary<string, HeatmapManager.PropertyData> _propertyGridMasks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyGridMasks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HeatmapManager.PropertyData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyGridMasks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x0600474C RID: 18252 RVA: 0x0016D7A0 File Offset: 0x0016B9A0
		// (set) Token: 0x0600474D RID: 18253 RVA: 0x00022D07 File Offset: 0x00020F07
		public unsafe List<HeatmapManager.PropertyRegionReference> _propertyRegionReferences
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyRegionReferences);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HeatmapManager.PropertyRegionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__propertyRegionReferences), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x0600474E RID: 18254 RVA: 0x0016D7D0 File Offset: 0x0016B9D0
		// (set) Token: 0x0600474F RID: 18255 RVA: 0x00022D26 File Offset: 0x00020F26
		public unsafe int _kernal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__kernal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__kernal)) = value;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004750 RID: 18256 RVA: 0x0016D7F8 File Offset: 0x0016B9F8
		// (set) Token: 0x06004751 RID: 18257 RVA: 0x00022D41 File Offset: 0x00020F41
		public unsafe int _textureDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__textureDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.NativeFieldInfoPtr__textureDepth)) = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06004752 RID: 18258 RVA: 0x0016D820 File Offset: 0x0016BA20
		// (set) Token: 0x06004753 RID: 18259 RVA: 0x00022D5C File Offset: 0x00020F5C
		public unsafe static int TEXTURE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HeatmapManager.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeatmapManager.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x0016D83C File Offset: 0x0016BA3C
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x00022D6A File Offset: 0x00020F6A
		public unsafe static int MAX_REGIONS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(HeatmapManager.NativeFieldInfoPtr_MAX_REGIONS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HeatmapManager.NativeFieldInfoPtr_MAX_REGIONS, (void*)(&value));
			}
		}

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeFieldInfoPtr_onHeatmapVisibilityChanged;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeFieldInfoPtr__shader;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeFieldInfoPtr__heatmaps;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeFieldInfoPtr__heatmapRegionPrefab;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeFieldInfoPtr__heatmapMat;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeFieldInfoPtr__gradientTexture;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeFieldInfoPtr__propertyCodeToTest;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeFieldInfoPtr__propertyGridMasks;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeFieldInfoPtr__propertyRegionReferences;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeFieldInfoPtr__kernal;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeFieldInfoPtr__textureDepth;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeFieldInfoPtr_TEXTURE_SIZE;

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeFieldInfoPtr_MAX_REGIONS;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003073 RID: 12403
		private static readonly IntPtr NativeMethodInfoPtr_Initialise_Private_Void_0;

		// Token: 0x04003074 RID: 12404
		private static readonly IntPtr NativeMethodInfoPtr_SetShader_Private_Void_0;

		// Token: 0x04003075 RID: 12405
		private static readonly IntPtr NativeMethodInfoPtr_SetPropertyData_Private_Void_0;

		// Token: 0x04003076 RID: 12406
		private static readonly IntPtr NativeMethodInfoPtr_OnEmitterUpdate_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x04003077 RID: 12407
		private static readonly IntPtr NativeMethodInfoPtr_DispatchHeatmap_Private_Void_String_Il2CppStructArray_1_TemperatureEmitterInfo_0;

		// Token: 0x04003078 RID: 12408
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyRegionStartAndEndIndex_Private_Vector2Int_String_0;

		// Token: 0x04003079 RID: 12409
		private static readonly IntPtr NativeMethodInfoPtr_SetHeatmapActive_Public_Void_String_Boolean_0;

		// Token: 0x0400307A RID: 12410
		private static readonly IntPtr NativeMethodInfoPtr_SetHeatmapActive_Public_Void_Property_Boolean_0;

		// Token: 0x0400307B RID: 12411
		private static readonly IntPtr NativeMethodInfoPtr_ToggleHeatmapActive_Public_Void_Property_0;

		// Token: 0x0400307C RID: 12412
		private static readonly IntPtr NativeMethodInfoPtr_SetAllHeatmapsActive_Public_Void_Boolean_0;

		// Token: 0x0400307D RID: 12413
		private static readonly IntPtr NativeMethodInfoPtr_IsHeatmapActive_Public_Boolean_Property_0;

		// Token: 0x0400307E RID: 12414
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400307F RID: 12415
		private static readonly IntPtr NativeMethodInfoPtr_TurnOnAllHeatmaps_Public_Void_0;

		// Token: 0x04003080 RID: 12416
		private static readonly IntPtr NativeMethodInfoPtr_TurnOffAllHeatmaps_Public_Void_0;

		// Token: 0x04003081 RID: 12417
		private static readonly IntPtr NativeMethodInfoPtr_RunDispatchHeatmap_Public_Void_0;

		// Token: 0x04003082 RID: 12418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003083 RID: 12419
		private static readonly IntPtr NativeMethodInfoPtr__RunDispatchHeatmap_b__31_0_Private_Boolean_Property_0;

		// Token: 0x02000A67 RID: 2663
		[Serializable]
		public class PropertyData : Il2CppSystem.Object
		{
			// Token: 0x0600E0D2 RID: 57554 RVA: 0x00373FB0 File Offset: 0x003721B0
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyData()
			{
				Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "PropertyData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr);
				HeatmapManager.PropertyData.NativeFieldInfoPtr_MaskData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, "MaskData");
				HeatmapManager.PropertyData.NativeFieldInfoPtr_Matrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, "Matrices");
				HeatmapManager.PropertyData.NativeFieldInfoPtr_Regions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, "Regions");
				HeatmapManager.PropertyData.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, "Property");
				HeatmapManager.PropertyData.NativeFieldInfoPtr_InitialDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, "InitialDispatched");
				HeatmapManager.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr, 100672437);
			}

			// Token: 0x0600E0D3 RID: 57555 RVA: 0x00374054 File Offset: 0x00372254
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertyData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatmapManager.PropertyData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HeatmapManager.PropertyData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0D4 RID: 57556 RVA: 0x00069F5C File Offset: 0x0006815C
			public PropertyData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446F RID: 17519
			// (get) Token: 0x0600E0D5 RID: 57557 RVA: 0x00374090 File Offset: 0x00372290
			// (set) Token: 0x0600E0D6 RID: 57558 RVA: 0x00069F65 File Offset: 0x00068165
			public unsafe Il2CppStructArray<int> MaskData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_MaskData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_MaskData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004470 RID: 17520
			// (get) Token: 0x0600E0D7 RID: 57559 RVA: 0x003740C0 File Offset: 0x003722C0
			// (set) Token: 0x0600E0D8 RID: 57560 RVA: 0x00069F84 File Offset: 0x00068184
			public unsafe Il2CppStructArray<Matrix4x4> Matrices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Matrices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Matrix4x4>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Matrices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004471 RID: 17521
			// (get) Token: 0x0600E0D9 RID: 57561 RVA: 0x003740F0 File Offset: 0x003722F0
			// (set) Token: 0x0600E0DA RID: 57562 RVA: 0x00069FA3 File Offset: 0x000681A3
			public unsafe List<HeatmapRegion> Regions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Regions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HeatmapRegion>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Regions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004472 RID: 17522
			// (get) Token: 0x0600E0DB RID: 57563 RVA: 0x00374120 File Offset: 0x00372320
			// (set) Token: 0x0600E0DC RID: 57564 RVA: 0x00069FC2 File Offset: 0x000681C2
			public unsafe Property Property
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Property);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004473 RID: 17523
			// (get) Token: 0x0600E0DD RID: 57565 RVA: 0x00374150 File Offset: 0x00372350
			// (set) Token: 0x0600E0DE RID: 57566 RVA: 0x00069FE1 File Offset: 0x000681E1
			public unsafe bool InitialDispatched
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_InitialDispatched);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyData.NativeFieldInfoPtr_InitialDispatched)) = value;
				}
			}

			// Token: 0x04009904 RID: 39172
			private static readonly IntPtr NativeFieldInfoPtr_MaskData;

			// Token: 0x04009905 RID: 39173
			private static readonly IntPtr NativeFieldInfoPtr_Matrices;

			// Token: 0x04009906 RID: 39174
			private static readonly IntPtr NativeFieldInfoPtr_Regions;

			// Token: 0x04009907 RID: 39175
			private static readonly IntPtr NativeFieldInfoPtr_Property;

			// Token: 0x04009908 RID: 39176
			private static readonly IntPtr NativeFieldInfoPtr_InitialDispatched;

			// Token: 0x04009909 RID: 39177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A68 RID: 2664
		public sealed class PropertyRegionReference : ValueType
		{
			// Token: 0x0600E0DF RID: 57567 RVA: 0x00374178 File Offset: 0x00372378
			// Note: this type is marked as 'beforefieldinit'.
			static PropertyRegionReference()
			{
				Il2CppClassPointerStore<HeatmapManager.PropertyRegionReference>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeatmapManager>.NativeClassPtr, "PropertyRegionReference");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeatmapManager.PropertyRegionReference>.NativeClassPtr);
				HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_PropertyCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyRegionReference>.NativeClassPtr, "PropertyCode");
				HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_RegionAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeatmapManager.PropertyRegionReference>.NativeClassPtr, "RegionAmount");
			}

			// Token: 0x0600E0E0 RID: 57568 RVA: 0x00069FFC File Offset: 0x000681FC
			public PropertyRegionReference(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E0E1 RID: 57569 RVA: 0x0006A005 File Offset: 0x00068205
			public PropertyRegionReference() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeatmapManager.PropertyRegionReference>.NativeClassPtr))
			{
			}

			// Token: 0x17004474 RID: 17524
			// (get) Token: 0x0600E0E2 RID: 57570 RVA: 0x003741CC File Offset: 0x003723CC
			// (set) Token: 0x0600E0E3 RID: 57571 RVA: 0x0006A017 File Offset: 0x00068217
			public unsafe string PropertyCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_PropertyCode);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_PropertyCode), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004475 RID: 17525
			// (get) Token: 0x0600E0E4 RID: 57572 RVA: 0x003741F4 File Offset: 0x003723F4
			// (set) Token: 0x0600E0E5 RID: 57573 RVA: 0x0006A036 File Offset: 0x00068236
			public unsafe int RegionAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_RegionAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HeatmapManager.PropertyRegionReference.NativeFieldInfoPtr_RegionAmount)) = value;
				}
			}

			// Token: 0x0400990A RID: 39178
			private static readonly IntPtr NativeFieldInfoPtr_PropertyCode;

			// Token: 0x0400990B RID: 39179
			private static readonly IntPtr NativeFieldInfoPtr_RegionAmount;
		}
	}
}
