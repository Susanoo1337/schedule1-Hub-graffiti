using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000076 RID: 118
	public static class Utils : Il2CppSystem.Object
	{
		// Token: 0x06000896 RID: 2198 RVA: 0x00096958 File Offset: 0x00094B58
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kEpsilon");
			Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "ms_FloatPackingPrecision");
			Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "kFloatPackingHighMinShaderLevel");
			Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664379);
			Utils.NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664380);
			Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664381);
			Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664382);
			Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664383);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664384);
			Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664385);
			Utils.NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664386);
			Utils.NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664387);
			Utils.NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664388);
			Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664389);
			Utils.NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664390);
			Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664391);
			Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664392);
			Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664393);
			Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664394);
			Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664395);
			Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664396);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664397);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664398);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664399);
			Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664400);
			Utils.NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664401);
			Utils.NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664402);
			Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664403);
			Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664404);
			Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664405);
			Utils.NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664406);
			Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664407);
			Utils.NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664408);
			Utils.NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664409);
			Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664410);
			Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664411);
			Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664412);
			Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664413);
			Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664414);
			Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664415);
			Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664416);
			Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664417);
			Utils.NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664418);
			Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664419);
			Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100664420);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00096D0C File Offset: 0x00094F0C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 73950, RefRangeEnd = 73969, XrefRangeStart = 73949, XrefRangeEnd = 73950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallOffEnd;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref spotAngle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00096D58 File Offset: 0x00094F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 73970, RefRangeEnd = 73972, XrefRangeStart = 73969, XrefRangeEnd = 73970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ComputeSpotAngle(float fallOffEnd, float coneRadiusEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref fallOffEnd;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00096DA4 File Offset: 0x00094FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73972, XrefRangeEnd = 73988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Swap<T>(ref T a, ref T b)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(a);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(b);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			a = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			b = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00096E1C File Offset: 0x0009501C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74003, RefRangeEnd = 74006, XrefRangeStart = 73988, XrefRangeEnd = 74003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPath(Transform current)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(current);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00096E58 File Offset: 0x00095058
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74025, RefRangeEnd = 74029, XrefRangeStart = 74006, XrefRangeEnd = 74025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T NewWithComponent<T>(string name) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00096E98 File Offset: 0x00095098
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74036, RefRangeEnd = 74041, XrefRangeStart = 74029, XrefRangeEnd = 74036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00096ED8 File Offset: 0x000950D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74041, XrefRangeEnd = 74050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00096F18 File Offset: 0x00095118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74050, XrefRangeEnd = 74058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForeachComponentsInAnyChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00096F70 File Offset: 0x00095170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 74068, RefRangeEnd = 74071, XrefRangeStart = 74058, XrefRangeEnd = 74068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ForeachComponentsInDirectChildrenOnly<T>(this GameObject self, Action<T> lambda, bool includeInactive = false) where T : Component
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeInactive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.MethodInfoStoreGeneric_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00096FC8 File Offset: 0x000951C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74085, RefRangeEnd = 74087, XrefRangeStart = 74071, XrefRangeEnd = 74085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupDepthCamera(Camera depthCamera, float coneApexOffsetZ, float maxGeometryDistance, float coneRadiusStart, float coneRadiusEnd, Vector3 beamLocalForward, Vector3 lossyScale, bool isScalable, Quaternion beamInternalLocalRotation, bool shouldScaleMinNearClipPlane)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(depthCamera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneApexOffsetZ;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxGeometryDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneRadiusEnd;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beamLocalForward;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lossyScale;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isScalable;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beamInternalLocalRotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldScaleMinNearClipPlane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00097080 File Offset: 0x00095280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74087, XrefRangeEnd = 74094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFlag(this Enum mask, Enum flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000970D4 File Offset: 0x000952D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74099, RefRangeEnd = 74100, XrefRangeStart = 74094, XrefRangeEnd = 74099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Divide(this Vector3 aVector, Vector3 scale)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00097120 File Offset: 0x00095320
		[CallerCount(155)]
		[CachedScanResults(RefRangeStart = 19464, RefRangeEnd = 19619, XrefRangeStart = 19464, XrefRangeEnd = 19619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 xy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00097160 File Offset: 0x00095360
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 74100, RefRangeEnd = 74109, XrefRangeStart = 74100, XrefRangeEnd = 74100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector2 xz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000971A0 File Offset: 0x000953A0
		[CallerCount(0)]
		public unsafe static Vector2 yz(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000971E0 File Offset: 0x000953E0
		[CallerCount(0)]
		public unsafe static Vector2 yx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00097220 File Offset: 0x00095420
		[CallerCount(0)]
		public unsafe static Vector2 zx(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00097260 File Offset: 0x00095460
		[CallerCount(0)]
		public unsafe static Vector2 zy(this Vector3 aVector)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref aVector;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000972A0 File Offset: 0x000954A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 74109, RefRangeEnd = 74116, XrefRangeStart = 74109, XrefRangeEnd = 74109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(this float a, float b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000972FC File Offset: 0x000954FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74116, RefRangeEnd = 74117, XrefRangeStart = 74116, XrefRangeEnd = 74116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(this Vector2 a, Vector2 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00097358 File Offset: 0x00095558
		[CallerCount(0)]
		public unsafe static bool Approximately(this Vector3 a, Vector3 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000973B4 File Offset: 0x000955B4
		[CallerCount(0)]
		public unsafe static bool Approximately(this Vector4 a, Vector4 b, float epsilon = 1E-05f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref epsilon;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x00097410 File Offset: 0x00095610
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 74117, RefRangeEnd = 74121, XrefRangeStart = 74117, XrefRangeEnd = 74117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 AsVector4(this Vector3 vec3, float w)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec3;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref w;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0009745C File Offset: 0x0009565C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74121, RefRangeEnd = 74122, XrefRangeStart = 74121, XrefRangeEnd = 74121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 PlaneEquation(Vector3 normalizedNormal, Vector3 pt)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedNormal;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000974A8 File Offset: 0x000956A8
		[CallerCount(0)]
		public unsafe static float GetVolumeCubic(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x000974E8 File Offset: 0x000956E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74122, RefRangeEnd = 74124, XrefRangeStart = 74122, XrefRangeEnd = 74122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMaxArea2D(this Bounds self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00097528 File Offset: 0x00095728
		[CallerCount(0)]
		public unsafe static Color Opaque(this Color self)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00097568 File Offset: 0x00095768
		[CallerCount(0)]
		public unsafe static Color ComputeComplementaryColor(this Color self, bool blackAndWhite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref self;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blackAndWhite;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000975B4 File Offset: 0x000957B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74126, RefRangeEnd = 74127, XrefRangeStart = 74124, XrefRangeEnd = 74126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref translation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00097600 File Offset: 0x00095800
		[CallerCount(0)]
		public unsafe static Vector3 ClosestPointOnPlaneCustom(this Plane plane, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0009764C File Offset: 0x0009584C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74127, RefRangeEnd = 74128, XrefRangeStart = 74127, XrefRangeEnd = 74127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAlmostZero(float f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref f;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0009768C File Offset: 0x0009588C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 74128, RefRangeEnd = 74129, XrefRangeStart = 74128, XrefRangeEnd = 74128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(this Plane plane)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref plane;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x000976CC File Offset: 0x000958CC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 74132, RefRangeEnd = 74186, XrefRangeStart = 74129, XrefRangeEnd = 74132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mat);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00097724 File Offset: 0x00095924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74186, XrefRangeEnd = 74188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetShaderKeywordEnabled(string name, bool enabled)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00097768 File Offset: 0x00095968
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74195, RefRangeEnd = 74197, XrefRangeStart = 74188, XrefRangeEnd = 74195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000977B8 File Offset: 0x000959B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74197, XrefRangeEnd = 74202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Color> SampleInArray(this Gradient self, int samplesCount)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref samplesCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr3) : null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x0009780C File Offset: 0x00095A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74202, XrefRangeEnd = 74206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 Vector4_Floor(Vector4 vec)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vec;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x0009784C File Offset: 0x00095A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74206, XrefRangeEnd = 74210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref floatPackingPrecision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00097898 File Offset: 0x00095A98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 74215, RefRangeEnd = 74220, XrefRangeStart = 74210, XrefRangeEnd = 74215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utils.FloatPackingPrecision GetFloatPackingPrecision()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x000978C8 File Offset: 0x00095AC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 74225, RefRangeEnd = 74227, XrefRangeStart = 74220, XrefRangeEnd = 74225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAtLeastOneFlag(this Enum mask, Enum flags)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mask);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0009791C File Offset: 0x00095B1C
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkCurrentSceneDirty()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00097944 File Offset: 0x00095B44
		[CallerCount(14950)]
		[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void MarkObjectDirty(UnityEngine.Object obj)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0000615A File Offset: 0x0000435A
		public Utils(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0009797C File Offset: 0x00095B7C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00006163 File Offset: 0x00004363
		public unsafe static float kEpsilon
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kEpsilon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kEpsilon, (void*)(&value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00097998 File Offset: 0x00095B98
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00006171 File Offset: 0x00004371
		public unsafe static Utils.FloatPackingPrecision ms_FloatPackingPrecision
		{
			get
			{
				Utils.FloatPackingPrecision result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_ms_FloatPackingPrecision, (void*)(&value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000979B4 File Offset: 0x00095BB4
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x0000617F File Offset: 0x0000437F
		public unsafe static int kFloatPackingHighMinShaderLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel, (void*)(&value));
			}
		}

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_kEpsilon;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_ms_FloatPackingPrecision;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_kFloatPackingHighMinShaderLevel;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeMethodInfoPtr_ComputeConeRadiusEnd_Public_Static_Single_Single_Single_0;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeMethodInfoPtr_ComputeSpotAngle_Public_Static_Single_Single_Single_0;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeMethodInfoPtr_GetPath_Public_Static_String_Transform_0;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_SetupDepthCamera_Public_Static_Void_Camera_Single_Single_Single_Single_Vector3_Vector3_Boolean_Quaternion_Boolean_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_HasFlag_Public_Static_Boolean_Enum_Enum_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_Divide_Public_Static_Vector3_Vector3_Vector3_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_xy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_xz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_yz_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_yx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_zx_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_zy_Public_Static_Vector2_Vector3_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_Single_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector2_Vector2_Single_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector3_Vector3_Single_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Vector4_Vector4_Single_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_AsVector4_Public_Static_Vector4_Vector3_Single_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_PlaneEquation_Public_Static_Vector4_Vector3_Vector3_0;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeMethodInfoPtr_GetVolumeCubic_Public_Static_Single_Bounds_0;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxArea2D_Public_Static_Single_Bounds_0;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeMethodInfoPtr_Opaque_Public_Static_Color_Color_0;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeMethodInfoPtr_ComputeComplementaryColor_Public_Static_Color_Color_Boolean_0;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeMethodInfoPtr_TranslateCustom_Public_Static_Plane_Plane_Vector3_0;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeMethodInfoPtr_ClosestPointOnPlaneCustom_Public_Static_Vector3_Plane_Vector3_0;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeMethodInfoPtr_IsAlmostZero_Public_Static_Boolean_Single_0;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_Plane_0;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeMethodInfoPtr_SetKeywordEnabled_Public_Static_Void_Material_String_Boolean_0;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderKeywordEnabled_Public_Static_Void_String_Boolean_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr_SampleInMatrix_Public_Static_Matrix4x4_Gradient_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_SampleInArray_Public_Static_Il2CppStructArray_1_Color_Gradient_Int32_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_Vector4_Floor_Private_Static_Vector4_Vector4_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_PackToFloat_Public_Static_Single_Color_Int32_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_GetFloatPackingPrecision_Public_Static_FloatPackingPrecision_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_HasAtLeastOneFlag_Public_Static_Boolean_Enum_Enum_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_MarkCurrentSceneDirty_Public_Static_Void_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_MarkObjectDirty_Public_Static_Void_Object_0;

		// Token: 0x02000896 RID: 2198
		[OriginalName("Assembly-CSharp.dll", "", "FloatPackingPrecision")]
		public enum FloatPackingPrecision
		{
			// Token: 0x04008FC4 RID: 36804
			High = 64,
			// Token: 0x04008FC5 RID: 36805
			Low = 8,
			// Token: 0x04008FC6 RID: 36806
			Undef = 0
		}

		// Token: 0x02000897 RID: 2199
		private sealed class MethodInfoStoreGeneric_Swap_Public_Static_Void_byref_T_byref_T_0<T>
		{
			// Token: 0x04008FC7 RID: 36807
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_Swap_Public_Static_Void_byref_T_byref_T_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000898 RID: 2200
		private sealed class MethodInfoStoreGeneric_NewWithComponent_Public_Static_T_String_0<T>
		{
			// Token: 0x04008FC8 RID: 36808
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_NewWithComponent_Public_Static_T_String_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000899 RID: 2201
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_GameObject_0<T>
		{
			// Token: 0x04008FC9 RID: 36809
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_GameObject_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089A RID: 2202
		private sealed class MethodInfoStoreGeneric_GetOrAddComponent_Public_Static_T_MonoBehaviour_0<T>
		{
			// Token: 0x04008FCA RID: 36810
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_GetOrAddComponent_Public_Static_T_MonoBehaviour_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089B RID: 2203
		private sealed class MethodInfoStoreGeneric_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>
		{
			// Token: 0x04008FCB RID: 36811
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_ForeachComponentsInAnyChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200089C RID: 2204
		private sealed class MethodInfoStoreGeneric_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0<T>
		{
			// Token: 0x04008FCC RID: 36812
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utils.NativeMethodInfoPtr_ForeachComponentsInDirectChildrenOnly_Public_Static_Void_GameObject_Action_1_T_Boolean_0, Il2CppClassPointerStore<Utils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
