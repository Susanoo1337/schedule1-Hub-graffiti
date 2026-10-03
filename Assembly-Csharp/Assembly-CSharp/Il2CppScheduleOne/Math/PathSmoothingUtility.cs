using System;
using Il2CppFluffyUnderware.Curvy;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Math
{
	// Token: 0x020003E2 RID: 994
	public static class PathSmoothingUtility : Il2CppSystem.Object
	{
		// Token: 0x060058D9 RID: 22745 RVA: 0x001AE684 File Offset: 0x001AC884
		// Note: this type is marked as 'beforefieldinit'.
		static PathSmoothingUtility()
		{
			Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Math", "PathSmoothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr);
			PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "MinControlPointDistance");
			PathSmoothingUtility.NativeFieldInfoPtr__spline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "_spline");
			PathSmoothingUtility.NativeMethodInfoPtr_EnsureSplineInitialized_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100674951);
			PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100674952);
			PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Private_Static_Void_SmoothedPath_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100674953);
			PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100674954);
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x001AE72C File Offset: 0x001AC92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193551, RefRangeEnd = 193552, XrefRangeStart = 193533, XrefRangeEnd = 193551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureSplineInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_EnsureSplineInitialized_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x001AE754 File Offset: 0x001AC954
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193629, RefRangeEnd = 193630, XrefRangeStart = 193552, XrefRangeEnd = 193629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 20f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCPDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x001AE7A8 File Offset: 0x001AC9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193630, XrefRangeEnd = 193641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Private_Static_Void_SmoothedPath_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x001AE7FC File Offset: 0x001AC9FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193658, RefRangeEnd = 193659, XrefRangeStart = 193641, XrefRangeEnd = 193658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x0002A0D0 File Offset: 0x000282D0
		public PathSmoothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x060058DF RID: 22751 RVA: 0x001AE850 File Offset: 0x001ACA50
		// (set) Token: 0x060058E0 RID: 22752 RVA: 0x0002A0D9 File Offset: 0x000282D9
		public unsafe static float MinControlPointDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&value));
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x060058E1 RID: 22753 RVA: 0x001AE86C File Offset: 0x001ACA6C
		// (set) Token: 0x060058E2 RID: 22754 RVA: 0x0002A0E7 File Offset: 0x000282E7
		public unsafe static CurvySpline _spline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr__spline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurvySpline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr__spline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D10 RID: 15632
		private static readonly IntPtr NativeFieldInfoPtr_MinControlPointDistance;

		// Token: 0x04003D11 RID: 15633
		private static readonly IntPtr NativeFieldInfoPtr__spline;

		// Token: 0x04003D12 RID: 15634
		private static readonly IntPtr NativeMethodInfoPtr_EnsureSplineInitialized_Public_Static_Void_0;

		// Token: 0x04003D13 RID: 15635
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0;

		// Token: 0x04003D14 RID: 15636
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Private_Static_Void_SmoothedPath_Color_Single_0;

		// Token: 0x04003D15 RID: 15637
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0;

		// Token: 0x02000ADC RID: 2780
		public class SmoothedPath : Il2CppSystem.Object
		{
			// Token: 0x0600E4B2 RID: 58546 RVA: 0x0037EF54 File Offset: 0x0037D154
			// Note: this type is marked as 'beforefieldinit'.
			static SmoothedPath()
			{
				Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "SmoothedPath");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr);
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "MARGIN");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "vectorPath");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "segmentBounds");
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100674955);
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100674956);
			}

			// Token: 0x0600E4B3 RID: 58547 RVA: 0x0037EFE4 File Offset: 0x0037D1E4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 193515, RefRangeEnd = 193516, XrefRangeStart = 193496, XrefRangeEnd = 193515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitializePath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4B4 RID: 58548 RVA: 0x0037F018 File Offset: 0x0037D218
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 193531, RefRangeEnd = 193533, XrefRangeStart = 193516, XrefRangeEnd = 193531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmoothedPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4B5 RID: 58549 RVA: 0x0006BD31 File Offset: 0x00069F31
			public SmoothedPath(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004588 RID: 17800
			// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x0037F054 File Offset: 0x0037D254
			// (set) Token: 0x0600E4B7 RID: 58551 RVA: 0x0006BD3A File Offset: 0x00069F3A
			public unsafe static float MARGIN
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&value));
				}
			}

			// Token: 0x17004589 RID: 17801
			// (get) Token: 0x0600E4B8 RID: 58552 RVA: 0x0037F070 File Offset: 0x0037D270
			// (set) Token: 0x0600E4B9 RID: 58553 RVA: 0x0006BD48 File Offset: 0x00069F48
			public unsafe List<Vector3> vectorPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700458A RID: 17802
			// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x0037F0A0 File Offset: 0x0037D2A0
			// (set) Token: 0x0600E4BB RID: 58555 RVA: 0x0006BD67 File Offset: 0x00069F67
			public unsafe List<Bounds> segmentBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bounds>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B4C RID: 39756
			private static readonly IntPtr NativeFieldInfoPtr_MARGIN;

			// Token: 0x04009B4D RID: 39757
			private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

			// Token: 0x04009B4E RID: 39758
			private static readonly IntPtr NativeFieldInfoPtr_segmentBounds;

			// Token: 0x04009B4F RID: 39759
			private static readonly IntPtr NativeMethodInfoPtr_InitializePath_Public_Void_0;

			// Token: 0x04009B50 RID: 39760
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
