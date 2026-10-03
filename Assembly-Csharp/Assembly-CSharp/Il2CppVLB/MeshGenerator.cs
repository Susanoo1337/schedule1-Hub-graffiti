using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x02000063 RID: 99
	public static class MeshGenerator : Il2CppSystem.Object
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x0008F088 File Offset: 0x0008D288
		// Note: this type is marked as 'beforefieldinit'.
		static MeshGenerator()
		{
			Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "MeshGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr);
			MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "kMinTruncatedRadius");
			MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664055);
			MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664056);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664057);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664058);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664059);
			MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664060);
			MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664061);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664062);
			MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664063);
			MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664064);
			MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664065);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664066);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664067);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664068);
			MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, 100664069);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0008F1F8 File Offset: 0x0008D3F8
		[CallerCount(0)]
		public unsafe static float GetAngleOffset(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0008F238 File Offset: 0x0008D438
		[CallerCount(0)]
		public unsafe static float GetRadiiScale(int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0008F278 File Offset: 0x0008D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71799, XrefRangeEnd = 71801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0008F30C File Offset: 0x0008D50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71801, XrefRangeEnd = 71803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref coneAngle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0008F394 File Offset: 0x0008D594
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 71851, RefRangeEnd = 71855, XrefRangeStart = 71803, XrefRangeEnd = 71851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cap;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0008F428 File Offset: 0x0008D628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71907, RefRangeEnd = 71908, XrefRangeStart = 71855, XrefRangeEnd = 71907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Mesh GenerateConeZ_Radii_DoubleCaps(float lengthZ, float radiusStart, float radiusEnd, int numSides, bool inverted)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inverted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr3) : null;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0008F4A0 File Offset: 0x0008D6A0
		[CallerCount(0)]
		public unsafe static Bounds ComputeBounds(float lengthZ, float radiusStart, float radiusEnd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lengthZ;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusStart;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref radiusEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0008F4FC File Offset: 0x0008D6FC
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalVerticesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0008F548 File Offset: 0x0008D748
		[CallerCount(0)]
		public unsafe static int GetCapAdditionalIndicesCount(MeshGenerator.CapMode capMode, int numSides)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref capMode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSides;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0008F594 File Offset: 0x0008D794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71908, XrefRangeEnd = 71912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetVertexCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0008F5FC File Offset: 0x0008D7FC
		[CallerCount(0)]
		public unsafe static int GetIndicesCount(int numSides, int numSegments, MeshGenerator.CapMode capMode, bool doubleSided)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref numSides;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numSegments;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref doubleSided;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0008F664 File Offset: 0x0008D864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71912, XrefRangeEnd = 71916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0008F694 File Offset: 0x0008D894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71916, XrefRangeEnd = 71920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0008F6C4 File Offset: 0x0008D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71920, XrefRangeEnd = 71921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDVertexCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0008F6F4 File Offset: 0x0008D8F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71921, XrefRangeEnd = 71922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSharedMeshHDIndicesCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000053AA File Offset: 0x000035AA
		public MeshGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x0008F724 File Offset: 0x0008D924
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x000053B3 File Offset: 0x000035B3
		public unsafe static float kMinTruncatedRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MeshGenerator.NativeFieldInfoPtr_kMinTruncatedRadius, (void*)(&value));
			}
		}

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_kMinTruncatedRadius;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_GetAngleOffset_Private_Static_Single_Int32_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_GetRadiiScale_Private_Static_Single_Int32_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_RadiusAndAngle_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Angle_Public_Static_Mesh_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_Public_Static_Mesh_Single_Single_Single_Int32_Int32_Boolean_Boolean_0;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConeZ_Radii_DoubleCaps_Public_Static_Mesh_Single_Single_Single_Int32_Boolean_0;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeMethodInfoPtr_ComputeBounds_Public_Static_Bounds_Single_Single_Single_0;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalVerticesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeMethodInfoPtr_GetCapAdditionalIndicesCount_Private_Static_Int32_CapMode_Int32_0;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeMethodInfoPtr_GetVertexCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_GetIndicesCount_Public_Static_Int32_Int32_Int32_CapMode_Boolean_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshVertexCount_Public_Static_Int32_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshIndicesCount_Public_Static_Int32_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDVertexCount_Public_Static_Int32_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_GetSharedMeshHDIndicesCount_Public_Static_Int32_0;

		// Token: 0x02000883 RID: 2179
		[OriginalName("Assembly-CSharp.dll", "", "CapMode")]
		public enum CapMode
		{
			// Token: 0x04008F31 RID: 36657
			None,
			// Token: 0x04008F32 RID: 36658
			OneVertexPerCap_1Cap,
			// Token: 0x04008F33 RID: 36659
			OneVertexPerCap_2Caps,
			// Token: 0x04008F34 RID: 36660
			SpecificVerticesPerCap_1Cap,
			// Token: 0x04008F35 RID: 36661
			SpecificVerticesPerCap_2Caps
		}

		// Token: 0x02000884 RID: 2180
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D22A RID: 53802 RVA: 0x00348FF4 File Offset: 0x003471F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "numSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCountSides");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertSidesStartFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, "vertCenterFromSlide");
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664070);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664071);
				MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr, 100664072);
			}

			// Token: 0x0600D22B RID: 53803 RVA: 0x003490AC File Offset: 0x003472AC
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D22C RID: 53804 RVA: 0x003490E8 File Offset: 0x003472E8
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__0(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D22D RID: 53805 RVA: 0x00349134 File Offset: 0x00347334
			[CallerCount(0)]
			public unsafe int _GenerateConeZ_Radii_DoubleCaps_b__1(int slideID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_0.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D22E RID: 53806 RVA: 0x000636CF File Offset: 0x000618CF
			public __c__DisplayClass6_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDB RID: 16347
			// (get) Token: 0x0600D22F RID: 53807 RVA: 0x00349180 File Offset: 0x00347380
			// (set) Token: 0x0600D230 RID: 53808 RVA: 0x000636D8 File Offset: 0x000618D8
			public unsafe int numSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_numSides)) = value;
				}
			}

			// Token: 0x17003FDC RID: 16348
			// (get) Token: 0x0600D231 RID: 53809 RVA: 0x003491A8 File Offset: 0x003473A8
			// (set) Token: 0x0600D232 RID: 53810 RVA: 0x000636F3 File Offset: 0x000618F3
			public unsafe int vertCountSides
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCountSides)) = value;
				}
			}

			// Token: 0x17003FDD RID: 16349
			// (get) Token: 0x0600D233 RID: 53811 RVA: 0x003491D0 File Offset: 0x003473D0
			// (set) Token: 0x0600D234 RID: 53812 RVA: 0x0006370E File Offset: 0x0006190E
			public unsafe Func<int, int> vertSidesStartFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertSidesStartFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDE RID: 16350
			// (get) Token: 0x0600D235 RID: 53813 RVA: 0x00349200 File Offset: 0x00347400
			// (set) Token: 0x0600D236 RID: 53814 RVA: 0x0006372D File Offset: 0x0006192D
			public unsafe Func<int, int> vertCenterFromSlide
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_0.NativeFieldInfoPtr_vertCenterFromSlide), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F36 RID: 36662
			private static readonly IntPtr NativeFieldInfoPtr_numSides;

			// Token: 0x04008F37 RID: 36663
			private static readonly IntPtr NativeFieldInfoPtr_vertCountSides;

			// Token: 0x04008F38 RID: 36664
			private static readonly IntPtr NativeFieldInfoPtr_vertSidesStartFromSlide;

			// Token: 0x04008F39 RID: 36665
			private static readonly IntPtr NativeFieldInfoPtr_vertCenterFromSlide;

			// Token: 0x04008F3A RID: 36666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F3B RID: 36667
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__0_Internal_Int32_Int32_0;

			// Token: 0x04008F3C RID: 36668
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__1_Internal_Int32_Int32_0;
		}

		// Token: 0x02000885 RID: 2181
		[ObfuscatedName("VLB.MeshGenerator+<>c__DisplayClass6_1")]
		public sealed class __c__DisplayClass6_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D237 RID: 53815 RVA: 0x00349230 File Offset: 0x00347430
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_1()
			{
				Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshGenerator>.NativeClassPtr, "<>c__DisplayClass6_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr);
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "indices");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "ind");
				MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, "CS$<>8__locals1");
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664073);
				MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr, 100664074);
			}

			// Token: 0x0600D238 RID: 53816 RVA: 0x003492C0 File Offset: 0x003474C0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshGenerator.__c__DisplayClass6_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D239 RID: 53817 RVA: 0x003492FC File Offset: 0x003474FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71798, XrefRangeEnd = 71799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GenerateConeZ_Radii_DoubleCaps_b__2(int slideID, bool invert)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref slideID;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MeshGenerator.__c__DisplayClass6_1.NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D23A RID: 53818 RVA: 0x0006374C File Offset: 0x0006194C
			public __c__DisplayClass6_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FDF RID: 16351
			// (get) Token: 0x0600D23B RID: 53819 RVA: 0x00349348 File Offset: 0x00347548
			// (set) Token: 0x0600D23C RID: 53820 RVA: 0x00063755 File Offset: 0x00061955
			public unsafe Il2CppStructArray<int> indices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_indices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE0 RID: 16352
			// (get) Token: 0x0600D23D RID: 53821 RVA: 0x00349378 File Offset: 0x00347578
			// (set) Token: 0x0600D23E RID: 53822 RVA: 0x00063774 File Offset: 0x00061974
			public unsafe int ind
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_ind)) = value;
				}
			}

			// Token: 0x17003FE1 RID: 16353
			// (get) Token: 0x0600D23F RID: 53823 RVA: 0x003493A0 File Offset: 0x003475A0
			// (set) Token: 0x0600D240 RID: 53824 RVA: 0x0006378F File Offset: 0x0006198F
			public unsafe MeshGenerator.__c__DisplayClass6_0 field_Public___c__DisplayClass6_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshGenerator.__c__DisplayClass6_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MeshGenerator.__c__DisplayClass6_1.NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F3D RID: 36669
			private static readonly IntPtr NativeFieldInfoPtr_indices;

			// Token: 0x04008F3E RID: 36670
			private static readonly IntPtr NativeFieldInfoPtr_ind;

			// Token: 0x04008F3F RID: 36671
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass6_0_0;

			// Token: 0x04008F40 RID: 36672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F41 RID: 36673
			private static readonly IntPtr NativeMethodInfoPtr__GenerateConeZ_Radii_DoubleCaps_b__2_Internal_Void_Int32_Boolean_0;
		}
	}
}
