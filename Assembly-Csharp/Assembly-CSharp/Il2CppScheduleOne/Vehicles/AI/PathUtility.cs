using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000EB RID: 235
	public static class PathUtility : Il2CppSystem.Object
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x000C53AC File Offset: 0x000C35AC
		// Note: this type is marked as 'beforefieldinit'.
		static PathUtility()
		{
			Il2CppClassPointerStore<PathUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "PathUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathUtility>.NativeClassPtr);
			PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666423);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666424);
			PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666425);
			PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666426);
			PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666427);
			PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666428);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666429);
			PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666430);
			PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathUtility>.NativeClassPtr, 100666431);
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000C5490 File Offset: 0x000C3690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95687, XrefRangeEnd = 95691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAverageAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, int sampleCount, float stepSize)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sampleCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stepSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000C54FC File Offset: 0x000C36FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95691, XrefRangeEnd = 95693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000C555C File Offset: 0x000C375C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95693, XrefRangeEnd = 95694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPoint(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distance, int startPointIndex, float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000C55D8 File Offset: 0x000C37D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 95721, RefRangeEnd = 95731, XrefRangeStart = 95694, XrefRangeEnd = 95721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetPointAheadOfPathPoint(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000C5644 File Offset: 0x000C3844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95748, RefRangeEnd = 95749, XrefRangeStart = 95731, XrefRangeEnd = 95748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateAngleChangeOverPath(PathSmoothingUtility.SmoothedPath path, int startPointIndex, float pointLerp, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPointIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pointLerp;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x000C56B0 File Offset: 0x000C38B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95761, RefRangeEnd = 95762, XrefRangeStart = 95749, XrefRangeEnd = 95761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CalculateCTE(Vector3 flatCarPos, Transform vehicleTransform, Vector3 wp_from, Vector3 wp_to, PathSmoothingUtility.SmoothedPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref flatCarPos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(vehicleTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_from;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wp_to;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000C5730 File Offset: 0x000C3930
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 95781, RefRangeEnd = 95793, XrefRangeStart = 95762, XrefRangeEnd = 95781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnPath(PathSmoothingUtility.SmoothedPath path, Vector3 point, out int startPointIndex, out int endPointIndex, out float pointLerp)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &startPointIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPointIndex;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pointLerp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000C57AC File Offset: 0x000C39AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95793, XrefRangeEnd = 95797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetAheadPointDirection(PathSmoothingUtility.SmoothedPath path, Vector3 referencePoint, float distanceAhead)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref referencePoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceAhead;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000C580C File Offset: 0x000C3A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95797, XrefRangeEnd = 95801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnLine(Vector3 point, Vector3 line_start, Vector3 line_end, bool clamp = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clamp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathUtility.NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x0000C317 File Offset: 0x0000A517
		public PathUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000F94 RID: 3988
		private static readonly IntPtr NativeMethodInfoPtr_GetAverageAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Int32_Single_0;

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPoint_Public_Static_Vector3_SmoothedPath_Vector3_Single_Int32_Single_0;

		// Token: 0x04000F97 RID: 3991
		private static readonly IntPtr NativeMethodInfoPtr_GetPointAheadOfPathPoint_Public_Static_Vector3_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04000F98 RID: 3992
		private static readonly IntPtr NativeMethodInfoPtr_CalculateAngleChangeOverPath_Public_Static_Single_SmoothedPath_Int32_Single_Single_0;

		// Token: 0x04000F99 RID: 3993
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCTE_Public_Static_Single_Vector3_Transform_Vector3_Vector3_SmoothedPath_0;

		// Token: 0x04000F9A RID: 3994
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPath_Public_Static_Vector3_SmoothedPath_Vector3_byref_Int32_byref_Int32_byref_Single_0;

		// Token: 0x04000F9B RID: 3995
		private static readonly IntPtr NativeMethodInfoPtr_GetAheadPointDirection_Public_Static_Vector3_SmoothedPath_Vector3_Single_0;

		// Token: 0x04000F9C RID: 3996
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnLine_Private_Static_Vector3_Vector3_Vector3_Vector3_Boolean_0;
	}
}
