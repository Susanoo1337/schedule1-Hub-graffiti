using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering
{
	// Token: 0x02000221 RID: 545
	[StructLayout(2)]
	public struct CullingResults
	{
		// Token: 0x06002523 RID: 9507 RVA: 0x00094114 File Offset: 0x00092314
		// Note: this type is marked as 'beforefieldinit'.
		static CullingResults()
		{
			Il2CppClassPointerStore<CullingResults>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingResults");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingResults>.NativeClassPtr);
			CullingResults.NativeFieldInfoPtr_ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "ptr");
			CullingResults.NativeFieldInfoPtr_m_AllocationInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, "m_AllocationInfo");
			CullingResults.NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667259);
			CullingResults.NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667260);
			CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667261);
			CullingResults.NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667262);
			CullingResults.NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667263);
			CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667264);
			CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667265);
			CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667266);
			CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667267);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667268);
			CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667269);
			CullingResults.NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667270);
			CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667271);
			CullingResults.NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667272);
			CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667273);
			CullingResults.NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667274);
			CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667275);
			CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667276);
			CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667277);
			CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667278);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667279);
			CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667280);
			CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667281);
			CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667282);
			CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667283);
			CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, 100667284);
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField = IL2CPP.ResolveICall<CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegate>("UnityEngine.Rendering.CullingResults::FillLightAndReflectionProbeIndicesGraphicsBuffer");
			CullingResults.GetReflectionProbeIndexMapSizeDelegateField = IL2CPP.ResolveICall<CullingResults.GetReflectionProbeIndexMapSizeDelegate>("UnityEngine.Rendering.CullingResults::GetReflectionProbeIndexMapSize");
			CullingResults.FillReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.FillReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::FillReflectionProbeIndexMap");
			CullingResults.SetReflectionProbeIndexMapDelegateField = IL2CPP.ResolveICall<CullingResults.SetReflectionProbeIndexMapDelegate>("UnityEngine.Rendering.CullingResults::SetReflectionProbeIndexMap");
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000943B0 File Offset: 0x000925B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290329, XrefRangeEnd = 1290331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLightIndexCount(IntPtr cullingResultsPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000943F0 File Offset: 0x000925F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290331, XrefRangeEnd = 1290333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetReflectionProbeIndexCount(IntPtr cullingResultsPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x00094430 File Offset: 0x00092630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290333, XrefRangeEnd = 1290335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillLightAndReflectionProbeIndices(IntPtr cullingResultsPtr, ComputeBuffer computeBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00094474 File Offset: 0x00092674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290335, XrefRangeEnd = 1290337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLightIndexMapSize(IntPtr cullingResultsPtr)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000944B4 File Offset: 0x000926B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290337, XrefRangeEnd = 1290339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x00094504 File Offset: 0x00092704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290339, XrefRangeEnd = 1290341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLightIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexMapSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00094554 File Offset: 0x00092754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290341, XrefRangeEnd = 1290343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetShadowCasterBounds(IntPtr cullingResultsPtr, int lightIndex, out Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000945B0 File Offset: 0x000927B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290343, XrefRangeEnd = 1290345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeSpotShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x00094628 File Offset: 0x00092828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290345, XrefRangeEnd = 1290347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputePointShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fovBias;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000946BC File Offset: 0x000928BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290347, XrefRangeEnd = 1290349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitRatio;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x0009477C File Offset: 0x0009297C
		public unsafe Unity.Collections.NativeArray<VisibleLight> visibleLights
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1290352, RefRangeEnd = 1290353, XrefRangeStart = 1290349, XrefRangeEnd = 1290352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0, ref this, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Unity.Collections.NativeArray<VisibleLight>(pointer);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x0600252F RID: 9519 RVA: 0x000947A8 File Offset: 0x000929A8
		public unsafe Unity.Collections.NativeArray<VisibleReflectionProbe> visibleReflectionProbes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290356, RefRangeEnd = 1290358, XrefRangeStart = 1290353, XrefRangeEnd = 1290356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0, ref this, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Unity.Collections.NativeArray<VisibleReflectionProbe>(pointer);
			}
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000947D4 File Offset: 0x000929D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290360, RefRangeEnd = 1290362, XrefRangeStart = 1290358, XrefRangeEnd = 1290360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length) where T : new()
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = dataPointer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>.Pointer, ref this, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<T>(pointer);
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06002531 RID: 9521 RVA: 0x0009481C File Offset: 0x00092A1C
		public unsafe int lightAndReflectionProbeIndexCount
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1290366, RefRangeEnd = 1290368, XrefRangeStart = 1290362, XrefRangeEnd = 1290366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0009484C File Offset: 0x00092A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290370, RefRangeEnd = 1290372, XrefRangeStart = 1290368, XrefRangeEnd = 1290370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillLightAndReflectionProbeIndices(ComputeBuffer computeBuffer)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(computeBuffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00094884 File Offset: 0x00092A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290383, RefRangeEnd = 1290385, XrefRangeStart = 1290372, XrefRangeEnd = 1290383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allocator;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0, ref this, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Unity.Collections.NativeArray<int>(pointer);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000948BC File Offset: 0x00092ABC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290391, RefRangeEnd = 1290393, XrefRangeStart = 1290385, XrefRangeEnd = 1290391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lightIndexMap));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000948F8 File Offset: 0x00092AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1290395, RefRangeEnd = 1290397, XrefRangeStart = 1290393, XrefRangeEnd = 1290395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetShadowCasterBounds(int lightIndex, out Bounds outBounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lightIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outBounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00094944 File Offset: 0x00092B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290399, RefRangeEnd = 1290400, XrefRangeStart = 1290397, XrefRangeEnd = 1290399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000949AC File Offset: 0x00092BAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290402, RefRangeEnd = 1290403, XrefRangeStart = 1290400, XrefRangeEnd = 1290402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, CubemapFace cubemapFace, float fovBias, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubemapFace;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fovBias;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x00094A34 File Offset: 0x00092C34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290405, RefRangeEnd = 1290406, XrefRangeStart = 1290403, XrefRangeEnd = 1290405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitRatio;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x00094AE8 File Offset: 0x00092CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290410, RefRangeEnd = 1290411, XrefRangeStart = 1290406, XrefRangeEnd = 1290410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(CullingResults other)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00094B28 File Offset: 0x00092D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290411, XrefRangeEnd = 1290418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00094B6C File Offset: 0x00092D6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1290419, RefRangeEnd = 1290420, XrefRangeStart = 1290418, XrefRangeEnd = 1290419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00094B9C File Offset: 0x00092D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290420, XrefRangeEnd = 1290424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(CullingResults left, CullingResults right)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref left;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00094BE8 File Offset: 0x00092DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1290424, XrefRangeEnd = 1290426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(IntPtr cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, out Matrix4x4 viewMatrix, out Matrix4x4 projMatrix, out ShadowSplitData shadowSplitData)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cullingResultsPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activeLightIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref splitCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &splitRatio;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowResolution;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowNearPlaneOffset;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &viewMatrix;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &projMatrix;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &shadowSplitData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CullingResults.NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000111DA File Offset: 0x0000F3DA
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingResults>.NativeClassPtr, ref this));
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000111EC File Offset: 0x0000F3EC
		public static void FillLightAndReflectionProbeIndicesGraphicsBuffer(IntPtr cullingResultsPtr, GraphicsBuffer buffer)
		{
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField(cullingResultsPtr, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000111FF File Offset: 0x0000F3FF
		public static int GetReflectionProbeIndexMapSize(IntPtr cullingResultsPtr)
		{
			return CullingResults.GetReflectionProbeIndexMapSizeDelegateField(cullingResultsPtr);
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x0001120C File Offset: 0x0000F40C
		public static void FillReflectionProbeIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			CullingResults.FillReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0001121B File Offset: 0x0000F41B
		public static void SetReflectionProbeIndexMap(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize)
		{
			CullingResults.SetReflectionProbeIndexMapDelegateField(cullingResultsPtr, indexMapPtr, indexMapSize);
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x0001122A File Offset: 0x0000F42A
		public Unity.Collections.NativeArray<VisibleLight> visibleOffscreenVertexLights
		{
			get
			{
				return this.GetNativeArray<VisibleLight>(this.m_AllocationInfo.visibleOffscreenVertexLightsPtr, this.m_AllocationInfo.visibleOffscreenVertexLightCount);
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06002544 RID: 9540 RVA: 0x00094CAC File Offset: 0x00092EAC
		public int lightIndexCount
		{
			get
			{
				return CullingResults.GetLightIndexCount(this.ptr);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00094CCC File Offset: 0x00092ECC
		public int reflectionProbeIndexCount
		{
			get
			{
				return CullingResults.GetReflectionProbeIndexCount(this.ptr);
			}
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x00011248 File Offset: 0x0000F448
		public void FillLightAndReflectionProbeIndices(GraphicsBuffer buffer)
		{
			CullingResults.FillLightAndReflectionProbeIndicesGraphicsBuffer(this.ptr, buffer);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x00094CEC File Offset: 0x00092EEC
		public Unity.Collections.NativeArray<int> GetReflectionProbeIndexMap(Unity.Collections.Allocator allocator)
		{
			int reflectionProbeIndexMapSize = CullingResults.GetReflectionProbeIndexMapSize(this.ptr);
			Unity.Collections.NativeArray<int> nativeArray;
			nativeArray..ctor(reflectionProbeIndexMapSize, allocator, Unity.Collections.NativeArrayOptions.UninitializedMemory);
			CullingResults.FillReflectionProbeIndexMap(this.ptr, (IntPtr)nativeArray.GetUnsafePtr<int>(), reflectionProbeIndexMapSize);
			return nativeArray;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00011258 File Offset: 0x0000F458
		public void SetReflectionProbeIndexMap(Unity.Collections.NativeArray<int> lightIndexMap)
		{
			CullingResults.SetReflectionProbeIndexMap(this.ptr, (IntPtr)lightIndexMap.GetUnsafeReadOnlyPtr<int>(), lightIndexMap.Length);
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x00011279 File Offset: 0x0000F479
		public void Validate()
		{
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00094D30 File Offset: 0x00092F30
		public static bool operator !=(CullingResults left, CullingResults right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_ptr;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_m_AllocationInfo;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionProbeIndexCount_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Private_Static_Void_IntPtr_ComputeBuffer_0;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexMapSize_Private_Static_Int32_IntPtr_0;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr_FillLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIndexMap_Private_Static_Void_IntPtr_IntPtr_Int32_0;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Private_Static_Boolean_IntPtr_Int32_byref_Bounds_0;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FA4 RID: 8100
		private static readonly IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FA5 RID: 8101
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FA6 RID: 8102
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleLights_Public_get_NativeArray_1_VisibleLight_0;

		// Token: 0x04001FA7 RID: 8103
		private static readonly IntPtr NativeMethodInfoPtr_get_visibleReflectionProbes_Public_get_NativeArray_1_VisibleReflectionProbe_0;

		// Token: 0x04001FA8 RID: 8104
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0;

		// Token: 0x04001FA9 RID: 8105
		private static readonly IntPtr NativeMethodInfoPtr_get_lightAndReflectionProbeIndexCount_Public_get_Int32_0;

		// Token: 0x04001FAA RID: 8106
		private static readonly IntPtr NativeMethodInfoPtr_FillLightAndReflectionProbeIndices_Public_Void_ComputeBuffer_0;

		// Token: 0x04001FAB RID: 8107
		private static readonly IntPtr NativeMethodInfoPtr_GetLightIndexMap_Public_NativeArray_1_Int32_Allocator_0;

		// Token: 0x04001FAC RID: 8108
		private static readonly IntPtr NativeMethodInfoPtr_SetLightIndexMap_Public_Void_NativeArray_1_Int32_0;

		// Token: 0x04001FAD RID: 8109
		private static readonly IntPtr NativeMethodInfoPtr_GetShadowCasterBounds_Public_Boolean_Int32_byref_Bounds_0;

		// Token: 0x04001FAE RID: 8110
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FAF RID: 8111
		private static readonly IntPtr NativeMethodInfoPtr_ComputePointShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_CubemapFace_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FB0 RID: 8112
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Public_Boolean_Int32_Int32_Int32_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FB1 RID: 8113
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CullingResults_0;

		// Token: 0x04001FB2 RID: 8114
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FB3 RID: 8115
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FB4 RID: 8116
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_CullingResults_CullingResults_0;

		// Token: 0x04001FB5 RID: 8117
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected_Private_Static_Boolean_IntPtr_Int32_Int32_Int32_byref_Vector3_Int32_Single_byref_Matrix4x4_byref_Matrix4x4_byref_ShadowSplitData_0;

		// Token: 0x04001FB6 RID: 8118
		[FieldOffset(0)]
		public IntPtr ptr;

		// Token: 0x04001FB7 RID: 8119
		[FieldOffset(8)]
		public IntPtr m_AllocationInfo;

		// Token: 0x04001FB8 RID: 8120
		private static readonly CullingResults.FillLightAndReflectionProbeIndicesGraphicsBufferDelegate FillLightAndReflectionProbeIndicesGraphicsBufferDelegateField;

		// Token: 0x04001FB9 RID: 8121
		private static readonly CullingResults.GetReflectionProbeIndexMapSizeDelegate GetReflectionProbeIndexMapSizeDelegateField;

		// Token: 0x04001FBA RID: 8122
		private static readonly CullingResults.FillReflectionProbeIndexMapDelegate FillReflectionProbeIndexMapDelegateField;

		// Token: 0x04001FBB RID: 8123
		private static readonly CullingResults.SetReflectionProbeIndexMapDelegate SetReflectionProbeIndexMapDelegateField;

		// Token: 0x02000B61 RID: 2913
		private sealed class MethodInfoStoreGeneric_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0<T>
		{
			// Token: 0x04002BD7 RID: 11223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CullingResults.NativeMethodInfoPtr_GetNativeArray_Private_NativeArray_1_T_ptr_Void_Int32_0, Il2CppClassPointerStore<CullingResults>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000B62 RID: 2914
		// (Invoke) Token: 0x06003FAE RID: 16302
		private delegate void FillLightAndReflectionProbeIndicesGraphicsBufferDelegate(IntPtr cullingResultsPtr, IntPtr buffer);

		// Token: 0x02000B63 RID: 2915
		// (Invoke) Token: 0x06003FB0 RID: 16304
		private delegate int GetReflectionProbeIndexMapSizeDelegate(IntPtr cullingResultsPtr);

		// Token: 0x02000B64 RID: 2916
		// (Invoke) Token: 0x06003FB2 RID: 16306
		private delegate void FillReflectionProbeIndexMapDelegate(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize);

		// Token: 0x02000B65 RID: 2917
		// (Invoke) Token: 0x06003FB4 RID: 16308
		private delegate void SetReflectionProbeIndexMapDelegate(IntPtr cullingResultsPtr, IntPtr indexMapPtr, int indexMapSize);
	}
}
