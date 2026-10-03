using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000082 RID: 130
	public sealed class GeometryUtility : Object
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x0002B738 File Offset: 0x00029938
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryUtility()
		{
			Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GeometryUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663981);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663982);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663983);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663984);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663985);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663986);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663987);
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.Internal_CalculateBounds_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected");
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0002B804 File Offset: 0x00029A04
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1232796, RefRangeEnd = 1232800, XrefRangeStart = 1232786, XrefRangeEnd = 1232796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002B848 File Offset: 0x00029A48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1232807, RefRangeEnd = 1232808, XrefRangeStart = 1232800, XrefRangeEnd = 1232807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002B890 File Offset: 0x00029A90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1232810, RefRangeEnd = 1232812, XrefRangeStart = 1232808, XrefRangeEnd = 1232810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldToProjectionMatrix;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0002B8D4 File Offset: 0x00029AD4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1232814, RefRangeEnd = 1232820, XrefRangeStart = 1232812, XrefRangeEnd = 1232814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0002B924 File Offset: 0x00029B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232820, XrefRangeEnd = 1232822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes([Out] Il2CppStructArray<Plane> planes, Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002B978 File Offset: 0x00029B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232822, XrefRangeEnd = 1232824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB_Injected(Il2CppStructArray<Plane> planes, ref Bounds bounds)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002B9C8 File Offset: 0x00029BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232824, XrefRangeEnd = 1232826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes_Injected([Out] Il2CppStructArray<Plane> planes, ref Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00004FAE File Offset: 0x000031AE
		public GeometryUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00004FB7 File Offset: 0x000031B7
		public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002BA1C File Offset: 0x00029C1C
		public static Bounds CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = positions.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.", "positions");
			}
			return GeometryUtility.Internal_CalculateBounds(positions, transform);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002BA68 File Offset: 0x00029C68
		public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
		{
			bool flag = vertices == null || vertices.Length < 3;
			bool result;
			if (flag)
			{
				plane = new Plane(Vector3.up, 0f);
				result = false;
			}
			else
			{
				bool flag2 = vertices.Length == 3;
				if (flag2)
				{
					Vector3 a = vertices[0];
					Vector3 b = vertices[1];
					Vector3 c = vertices[2];
					plane = new Plane(a, b, c);
					result = (plane.normal.sqrMagnitude > 0f);
				}
				else
				{
					Vector3 zero = Vector3.zero;
					int num = vertices.Length - 1;
					Vector3 vector = vertices[num];
					for (int i = 0; i < vertices.Length; i++)
					{
						Vector3 vector2 = vertices[i];
						zero.x += (vector.y - vector2.y) * (vector.z + vector2.z);
						zero.y += (vector.z - vector2.z) * (vector.x + vector2.x);
						zero.z += (vector.x - vector2.x) * (vector.y + vector2.y);
						vector = vector2;
					}
					zero.Normalize();
					float num2 = 0f;
					for (int j = 0; j < vertices.Length; j++)
					{
						Vector3 rhs = vertices[j];
						num2 -= Vector3.Dot(zero, rhs);
					}
					num2 /= (float)vertices.Length;
					plane = new Plane(zero, num2);
					result = (plane.normal.sqrMagnitude > 0f);
				}
			}
			return result;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002BC44 File Offset: 0x00029E44
		public static Bounds Internal_CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			Bounds result;
			GeometryUtility.Internal_CalculateBounds_Injected(positions, ref transform, out result);
			return result;
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00004FC4 File Offset: 0x000031C4
		public static void Internal_CalculateBounds_Injected(Il2CppStructArray<Vector3> positions, ref Matrix4x4 transform, out Bounds ret)
		{
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), ref transform, out ret);
		}

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0;

		// Token: 0x04000566 RID: 1382
		private static readonly GeometryUtility.Internal_CalculateBounds_InjectedDelegate Internal_CalculateBounds_InjectedDelegateField;

		// Token: 0x020004E2 RID: 1250
		// (Invoke) Token: 0x06003276 RID: 12918
		private delegate void Internal_CalculateBounds_InjectedDelegate(IntPtr positions, IntPtr transform, [Out] IntPtr ret);
	}
}
