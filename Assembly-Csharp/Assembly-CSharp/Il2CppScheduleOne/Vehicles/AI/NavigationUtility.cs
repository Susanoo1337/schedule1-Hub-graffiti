using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020000E6 RID: 230
	public class NavigationUtility : Il2CppSystem.Object
	{
		// Token: 0x06001616 RID: 5654 RVA: 0x000C4B74 File Offset: 0x000C2D74
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationUtility()
		{
			Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr);
			NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "ROAD_MULTIPLIER");
			NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "OFFROAD_MULTIPLIER");
			NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666375);
			NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666376);
			NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666377);
			NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666378);
			NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666379);
			NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666380);
			NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666381);
			NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666382);
			NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666383);
			NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100666384);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x000C4C94 File Offset: 0x000C2E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95505, XrefRangeEnd = 95525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(navSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000C4D40 File Offset: 0x000C2F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95525, XrefRangeEnd = 95563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustExitPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000C4D78 File Offset: 0x000C2F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95563, XrefRangeEnd = 95582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustEntryPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000C4DB0 File Offset: 0x000C2FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95582, XrefRangeEnd = 95597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectorList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thresholdDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000C4E10 File Offset: 0x000C3010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95597, XrefRangeEnd = 95605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitLink);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitPoint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000C4EC8 File Offset: 0x000C30C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95605, XrefRangeEnd = 95639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathGroup group, float duration = 10f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000C4F0C File Offset: 0x000C310C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95639, XrefRangeEnd = 95654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000C4F50 File Offset: 0x000C3150
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 95666, RefRangeEnd = 95668, XrefRangeStart = 95654, XrefRangeEnd = 95666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref destination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000C4F90 File Offset: 0x000C3190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95668, XrefRangeEnd = 95671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000C4FEC File Offset: 0x000C31EC
		[CallerCount(2575)]
		[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x0000C1D8 File Offset: 0x0000A3D8
		public NavigationUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x000C5028 File Offset: 0x000C3228
		// (set) Token: 0x06001623 RID: 5667 RVA: 0x0000C1E1 File Offset: 0x0000A3E1
		public unsafe static float ROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x000C5044 File Offset: 0x000C3244
		// (set) Token: 0x06001625 RID: 5669 RVA: 0x0000C1EF File Offset: 0x0000A3EF
		public unsafe static float OFFROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr_ROAD_MULTIPLIER;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeFieldInfoPtr_OFFROAD_MULTIPLIER;

		// Token: 0x04000F80 RID: 3968
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0;

		// Token: 0x04000F81 RID: 3969
		private static readonly IntPtr NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04000F82 RID: 3970
		private static readonly IntPtr NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04000F83 RID: 3971
		private static readonly IntPtr NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0;

		// Token: 0x04000F84 RID: 3972
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0;

		// Token: 0x04000F85 RID: 3973
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0;

		// Token: 0x04000F86 RID: 3974
		private static readonly IntPtr NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0;

		// Token: 0x04000F87 RID: 3975
		private static readonly IntPtr NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0;

		// Token: 0x04000F88 RID: 3976
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04000F89 RID: 3977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000926 RID: 2342
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationCalculationResult")]
		public enum ENavigationCalculationResult
		{
			// Token: 0x040092DD RID: 37597
			Success,
			// Token: 0x040092DE RID: 37598
			Failed
		}

		// Token: 0x02000927 RID: 2343
		public sealed class NavigationCalculationCallback : MulticastDelegate
		{
			// Token: 0x0600D76F RID: 55151 RVA: 0x00359BC0 File Offset: 0x00357DC0
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCalculationCallback()
			{
				Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "NavigationCalculationCallback");
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100666385);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100666386);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100666387);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100666388);
			}

			// Token: 0x0600D770 RID: 55152 RVA: 0x00359C34 File Offset: 0x00357E34
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 95337, RefRangeEnd = 95356, XrefRangeStart = 95334, XrefRangeEnd = 95337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCalculationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D771 RID: 55153 RVA: 0x00359C90 File Offset: 0x00357E90
			[CallerCount(0)]
			public unsafe void Invoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D772 RID: 55154 RVA: 0x00359CE0 File Offset: 0x00357EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95356, XrefRangeEnd = 95360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D773 RID: 55155 RVA: 0x00359D64 File Offset: 0x00357F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D774 RID: 55156 RVA: 0x0006538E File Offset: 0x0006358E
			public NavigationCalculationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D775 RID: 55157 RVA: 0x00065397 File Offset: 0x00063597
			public static implicit operator NavigationUtility.NavigationCalculationCallback(Action<NavigationUtility.ENavigationCalculationResult, PathSmoothingUtility.SmoothedPath> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.NavigationCalculationCallback>(A_0);
			}

			// Token: 0x0600D776 RID: 55158 RVA: 0x0006539F File Offset: 0x0006359F
			public static NavigationUtility.NavigationCalculationCallback operator +(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.NavigationCalculationCallback>();
			}

			// Token: 0x0600D777 RID: 55159 RVA: 0x000653AD File Offset: 0x000635AD
			public static NavigationUtility.NavigationCalculationCallback operator -(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.NavigationCalculationCallback>();
				}
				return result;
			}

			// Token: 0x040092DF RID: 37599
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040092E0 RID: 37600
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0;

			// Token: 0x040092E1 RID: 37601
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0;

			// Token: 0x040092E2 RID: 37602
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000928 RID: 2344
		public sealed class PathGroupEvent : MulticastDelegate
		{
			// Token: 0x0600D778 RID: 55160 RVA: 0x00359DA8 File Offset: 0x00357FA8
			// Note: this type is marked as 'beforefieldinit'.
			static PathGroupEvent()
			{
				Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "PathGroupEvent");
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100666389);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100666390);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100666391);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100666392);
			}

			// Token: 0x0600D779 RID: 55161 RVA: 0x00359E1C File Offset: 0x0035801C
			[CallerCount(628)]
			[CachedScanResults(RefRangeStart = 71168, RefRangeEnd = 71796, XrefRangeStart = 71168, XrefRangeEnd = 71796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathGroupEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77A RID: 55162 RVA: 0x00359E78 File Offset: 0x00358078
			[CallerCount(0)]
			public unsafe void Invoke(PathGroup calculatedGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77B RID: 55163 RVA: 0x00359EBC File Offset: 0x003580BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 71797, RefRangeEnd = 71798, XrefRangeStart = 71797, XrefRangeEnd = 71798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PathGroup calculatedGroup, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D77C RID: 55164 RVA: 0x00359F30 File Offset: 0x00358130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77D RID: 55165 RVA: 0x000653BE File Offset: 0x000635BE
			public PathGroupEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D77E RID: 55166 RVA: 0x000653C7 File Offset: 0x000635C7
			public static implicit operator NavigationUtility.PathGroupEvent(Action<PathGroup> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.PathGroupEvent>(A_0);
			}

			// Token: 0x0600D77F RID: 55167 RVA: 0x000653CF File Offset: 0x000635CF
			public static NavigationUtility.PathGroupEvent operator +(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.PathGroupEvent>();
			}

			// Token: 0x0600D780 RID: 55168 RVA: 0x000653DD File Offset: 0x000635DD
			public static NavigationUtility.PathGroupEvent operator -(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.PathGroupEvent>();
				}
				return result;
			}

			// Token: 0x040092E3 RID: 37603
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040092E4 RID: 37604
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0;

			// Token: 0x040092E5 RID: 37605
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0;

			// Token: 0x040092E6 RID: 37606
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000929 RID: 2345
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D781 RID: 55169 RVA: 0x00359F74 File Offset: 0x00358174
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr);
				NavigationUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9");
				NavigationUtility.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9__5_5");
				NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100666394);
				NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100666395);
			}

			// Token: 0x0600D782 RID: 55170 RVA: 0x00359FF0 File Offset: 0x003581F0
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D783 RID: 55171 RVA: 0x0035A02C File Offset: 0x0035822C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95360, XrefRangeEnd = 95365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculatePath_b__5_5(PathGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D784 RID: 55172 RVA: 0x000653EE File Offset: 0x000635EE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CA RID: 16842
			// (get) Token: 0x0600D785 RID: 55173 RVA: 0x0035A07C File Offset: 0x0035827C
			// (set) Token: 0x0600D786 RID: 55174 RVA: 0x000653F7 File Offset: 0x000635F7
			public unsafe static NavigationUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CB RID: 16843
			// (get) Token: 0x0600D787 RID: 55175 RVA: 0x0035A0A4 File Offset: 0x003582A4
			// (set) Token: 0x0600D788 RID: 55176 RVA: 0x00065409 File Offset: 0x00063609
			public unsafe static Func<PathGroup, float> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PathGroup, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092E7 RID: 37607
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040092E8 RID: 37608
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x040092E9 RID: 37609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092EA RID: 37610
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0;
		}

		// Token: 0x0200092A RID: 2346
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D789 RID: 55177 RVA: 0x0035A0CC File Offset: 0x003582CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastGeneratedPathGroup");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "pathGroupGenerated");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "flags");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "startPosition");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "destination");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "generalSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "roadSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "navSettings");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<>9__4");
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666396);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666397);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666398);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666399);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666400);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666401);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100666402);
			}

			// Token: 0x0600D78A RID: 55178 RVA: 0x0035A260 File Offset: 0x00358460
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78B RID: 55179 RVA: 0x0035A29C File Offset: 0x0035849C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78C RID: 55180 RVA: 0x0035A2E0 File Offset: 0x003584E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95435, XrefRangeEnd = 95436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PathGroup_PDM_0(PathGroup pg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78D RID: 55181 RVA: 0x0035A324 File Offset: 0x00358524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95436, XrefRangeEnd = 95441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D78E RID: 55182 RVA: 0x0035A364 File Offset: 0x00358564
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30481, RefRangeEnd = 30482, XrefRangeStart = 30481, XrefRangeEnd = 30482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D78F RID: 55183 RVA: 0x0035A3A0 File Offset: 0x003585A0
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 95441, RefRangeEnd = 95458, XrefRangeStart = 95441, XrefRangeEnd = 95441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D790 RID: 55184 RVA: 0x0035A3DC File Offset: 0x003585DC
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 95441, RefRangeEnd = 95458, XrefRangeStart = 95441, XrefRangeEnd = 95458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D791 RID: 55185 RVA: 0x0006541B File Offset: 0x0006361B
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041CC RID: 16844
			// (get) Token: 0x0600D792 RID: 55186 RVA: 0x0035A418 File Offset: 0x00358618
			// (set) Token: 0x0600D793 RID: 55187 RVA: 0x00065424 File Offset: 0x00063624
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CD RID: 16845
			// (get) Token: 0x0600D794 RID: 55188 RVA: 0x0035A448 File Offset: 0x00358648
			// (set) Token: 0x0600D795 RID: 55189 RVA: 0x00065443 File Offset: 0x00063643
			public unsafe PathGroup lastGeneratedPathGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041CE RID: 16846
			// (get) Token: 0x0600D796 RID: 55190 RVA: 0x0035A478 File Offset: 0x00358678
			// (set) Token: 0x0600D797 RID: 55191 RVA: 0x00065462 File Offset: 0x00063662
			public unsafe bool pathGroupGenerated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated)) = value;
				}
			}

			// Token: 0x170041CF RID: 16847
			// (get) Token: 0x0600D798 RID: 55192 RVA: 0x0035A4A0 File Offset: 0x003586A0
			// (set) Token: 0x0600D799 RID: 55193 RVA: 0x0006547D File Offset: 0x0006367D
			public unsafe DriveFlags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D0 RID: 16848
			// (get) Token: 0x0600D79A RID: 55194 RVA: 0x0035A4D0 File Offset: 0x003586D0
			// (set) Token: 0x0600D79B RID: 55195 RVA: 0x0006549C File Offset: 0x0006369C
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x170041D1 RID: 16849
			// (get) Token: 0x0600D79C RID: 55196 RVA: 0x0035A4F8 File Offset: 0x003586F8
			// (set) Token: 0x0600D79D RID: 55197 RVA: 0x000654B7 File Offset: 0x000636B7
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x170041D2 RID: 16850
			// (get) Token: 0x0600D79E RID: 55198 RVA: 0x0035A520 File Offset: 0x00358720
			// (set) Token: 0x0600D79F RID: 55199 RVA: 0x000654D2 File Offset: 0x000636D2
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D3 RID: 16851
			// (get) Token: 0x0600D7A0 RID: 55200 RVA: 0x0035A550 File Offset: 0x00358750
			// (set) Token: 0x0600D7A1 RID: 55201 RVA: 0x000654F1 File Offset: 0x000636F1
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D4 RID: 16852
			// (get) Token: 0x0600D7A2 RID: 55202 RVA: 0x0035A580 File Offset: 0x00358780
			// (set) Token: 0x0600D7A3 RID: 55203 RVA: 0x00065510 File Offset: 0x00063710
			public unsafe NavigationSettings navSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D5 RID: 16853
			// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x0035A5B0 File Offset: 0x003587B0
			// (set) Token: 0x0600D7A5 RID: 55205 RVA: 0x0006552F File Offset: 0x0006372F
			public unsafe NavigationUtility.NavigationCalculationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.NavigationCalculationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041D6 RID: 16854
			// (get) Token: 0x0600D7A6 RID: 55206 RVA: 0x0035A5E0 File Offset: 0x003587E0
			// (set) Token: 0x0600D7A7 RID: 55207 RVA: 0x0006554E File Offset: 0x0006374E
			public unsafe Func<bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092EB RID: 37611
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x040092EC RID: 37612
			private static readonly IntPtr NativeFieldInfoPtr_lastGeneratedPathGroup;

			// Token: 0x040092ED RID: 37613
			private static readonly IntPtr NativeFieldInfoPtr_pathGroupGenerated;

			// Token: 0x040092EE RID: 37614
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x040092EF RID: 37615
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x040092F0 RID: 37616
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x040092F1 RID: 37617
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x040092F2 RID: 37618
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x040092F3 RID: 37619
			private static readonly IntPtr NativeFieldInfoPtr_navSettings;

			// Token: 0x040092F4 RID: 37620
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x040092F5 RID: 37621
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x040092F6 RID: 37622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092F7 RID: 37623
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x040092F8 RID: 37624
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0;

			// Token: 0x040092F9 RID: 37625
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040092FA RID: 37626
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0;

			// Token: 0x040092FB RID: 37627
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0;

			// Token: 0x040092FC RID: 37628
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0;

			// Token: 0x02000DB1 RID: 3505
			[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0+<<CalculatePath>g__Routine|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600FD44 RID: 64836 RVA: 0x003C5324 File Offset: 0x003C3524
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique()
				{
					Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<<CalculatePath>g__Routine|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<>1__state");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<>2__current");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<>4__this");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__finalGroup_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<finalGroup>5__2");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPointChecks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<entryPointChecks>5__3");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__exitPointChecks_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<exitPointChecks>5__4");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__closestNodeLinks_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<closestNodeLinks>5__5");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<nodeLinksClosestToLocation>5__6");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedEntryPoints_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<checkedEntryPoints>5__7");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__groups_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<groups>5__8");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__i_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<i>5__9");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPoint_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<entryPoint>5__10");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedExitPoints_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<checkedExitPoints>5__11");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__j_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, "<j>5__12");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666403);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666404);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666405);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666406);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666407);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr, 100666408);
				}

				// Token: 0x0600FD45 RID: 64837 RVA: 0x003C54E0 File Offset: 0x003C36E0
				[CallerCount(83)]
				[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD46 RID: 64838 RVA: 0x003C5528 File Offset: 0x003C3728
				[CallerCount(14950)]
				[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600FD47 RID: 64839 RVA: 0x003C555C File Offset: 0x003C375C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95365, XrefRangeEnd = 95430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004D01 RID: 19713
				// (get) Token: 0x0600FD48 RID: 64840 RVA: 0x003C5598 File Offset: 0x003C3798
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD49 RID: 64841 RVA: 0x003C55D8 File Offset: 0x003C37D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95430, XrefRangeEnd = 95435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004D02 RID: 19714
				// (get) Token: 0x0600FD4A RID: 64842 RVA: 0x003C560C File Offset: 0x003C380C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600FD4B RID: 64843 RVA: 0x00077EE1 File Offset: 0x000760E1
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004CF3 RID: 19699
				// (get) Token: 0x0600FD4C RID: 64844 RVA: 0x003C564C File Offset: 0x003C384C
				// (set) Token: 0x0600FD4D RID: 64845 RVA: 0x00077EEA File Offset: 0x000760EA
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004CF4 RID: 19700
				// (get) Token: 0x0600FD4E RID: 64846 RVA: 0x003C5674 File Offset: 0x003C3874
				// (set) Token: 0x0600FD4F RID: 64847 RVA: 0x00077F05 File Offset: 0x00076105
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CF5 RID: 19701
				// (get) Token: 0x0600FD50 RID: 64848 RVA: 0x003C56A4 File Offset: 0x003C38A4
				// (set) Token: 0x0600FD51 RID: 64849 RVA: 0x00077F24 File Offset: 0x00076124
				public unsafe NavigationUtility.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CF6 RID: 19702
				// (get) Token: 0x0600FD52 RID: 64850 RVA: 0x003C56D4 File Offset: 0x003C38D4
				// (set) Token: 0x0600FD53 RID: 64851 RVA: 0x00077F43 File Offset: 0x00076143
				public unsafe PathGroup _finalGroup_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__finalGroup_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__finalGroup_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CF7 RID: 19703
				// (get) Token: 0x0600FD54 RID: 64852 RVA: 0x003C5704 File Offset: 0x003C3904
				// (set) Token: 0x0600FD55 RID: 64853 RVA: 0x00077F62 File Offset: 0x00076162
				public unsafe int _entryPointChecks_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPointChecks_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPointChecks_5__3)) = value;
					}
				}

				// Token: 0x17004CF8 RID: 19704
				// (get) Token: 0x0600FD56 RID: 64854 RVA: 0x003C572C File Offset: 0x003C392C
				// (set) Token: 0x0600FD57 RID: 64855 RVA: 0x00077F7D File Offset: 0x0007617D
				public unsafe int _exitPointChecks_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__exitPointChecks_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__exitPointChecks_5__4)) = value;
					}
				}

				// Token: 0x17004CF9 RID: 19705
				// (get) Token: 0x0600FD58 RID: 64856 RVA: 0x003C5754 File Offset: 0x003C3954
				// (set) Token: 0x0600FD59 RID: 64857 RVA: 0x00077F98 File Offset: 0x00076198
				public unsafe List<NodeLink> _closestNodeLinks_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__closestNodeLinks_5__5);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__closestNodeLinks_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CFA RID: 19706
				// (get) Token: 0x0600FD5A RID: 64858 RVA: 0x003C5784 File Offset: 0x003C3984
				// (set) Token: 0x0600FD5B RID: 64859 RVA: 0x00077FB7 File Offset: 0x000761B7
				public unsafe List<NodeLink> _nodeLinksClosestToLocation_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__6);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CFB RID: 19707
				// (get) Token: 0x0600FD5C RID: 64860 RVA: 0x003C57B4 File Offset: 0x003C39B4
				// (set) Token: 0x0600FD5D RID: 64861 RVA: 0x00077FD6 File Offset: 0x000761D6
				public unsafe List<Vector3> _checkedEntryPoints_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedEntryPoints_5__7);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedEntryPoints_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CFC RID: 19708
				// (get) Token: 0x0600FD5E RID: 64862 RVA: 0x003C57E4 File Offset: 0x003C39E4
				// (set) Token: 0x0600FD5F RID: 64863 RVA: 0x00077FF5 File Offset: 0x000761F5
				public unsafe List<PathGroup> _groups_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__groups_5__8);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathGroup>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__groups_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004CFD RID: 19709
				// (get) Token: 0x0600FD60 RID: 64864 RVA: 0x003C5814 File Offset: 0x003C3A14
				// (set) Token: 0x0600FD61 RID: 64865 RVA: 0x00078014 File Offset: 0x00076214
				public unsafe int _i_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__i_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__i_5__9)) = value;
					}
				}

				// Token: 0x17004CFE RID: 19710
				// (get) Token: 0x0600FD62 RID: 64866 RVA: 0x003C583C File Offset: 0x003C3A3C
				// (set) Token: 0x0600FD63 RID: 64867 RVA: 0x0007802F File Offset: 0x0007622F
				public unsafe Vector3 _entryPoint_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPoint_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__entryPoint_5__10)) = value;
					}
				}

				// Token: 0x17004CFF RID: 19711
				// (get) Token: 0x0600FD64 RID: 64868 RVA: 0x003C5864 File Offset: 0x003C3A64
				// (set) Token: 0x0600FD65 RID: 64869 RVA: 0x0007804A File Offset: 0x0007624A
				public unsafe List<Vector3> _checkedExitPoints_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedExitPoints_5__11);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__checkedExitPoints_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004D00 RID: 19712
				// (get) Token: 0x0600FD66 RID: 64870 RVA: 0x003C5894 File Offset: 0x003C3A94
				// (set) Token: 0x0600FD67 RID: 64871 RVA: 0x00078069 File Offset: 0x00076269
				public unsafe int _j_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__j_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLiIn1NoInVeLiUnique.NativeFieldInfoPtr__j_5__12)) = value;
					}
				}

				// Token: 0x0400AAC4 RID: 43716
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400AAC5 RID: 43717
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400AAC6 RID: 43718
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400AAC7 RID: 43719
				private static readonly IntPtr NativeFieldInfoPtr__finalGroup_5__2;

				// Token: 0x0400AAC8 RID: 43720
				private static readonly IntPtr NativeFieldInfoPtr__entryPointChecks_5__3;

				// Token: 0x0400AAC9 RID: 43721
				private static readonly IntPtr NativeFieldInfoPtr__exitPointChecks_5__4;

				// Token: 0x0400AACA RID: 43722
				private static readonly IntPtr NativeFieldInfoPtr__closestNodeLinks_5__5;

				// Token: 0x0400AACB RID: 43723
				private static readonly IntPtr NativeFieldInfoPtr__nodeLinksClosestToLocation_5__6;

				// Token: 0x0400AACC RID: 43724
				private static readonly IntPtr NativeFieldInfoPtr__checkedEntryPoints_5__7;

				// Token: 0x0400AACD RID: 43725
				private static readonly IntPtr NativeFieldInfoPtr__groups_5__8;

				// Token: 0x0400AACE RID: 43726
				private static readonly IntPtr NativeFieldInfoPtr__i_5__9;

				// Token: 0x0400AACF RID: 43727
				private static readonly IntPtr NativeFieldInfoPtr__entryPoint_5__10;

				// Token: 0x0400AAD0 RID: 43728
				private static readonly IntPtr NativeFieldInfoPtr__checkedExitPoints_5__11;

				// Token: 0x0400AAD1 RID: 43729
				private static readonly IntPtr NativeFieldInfoPtr__j_5__12;

				// Token: 0x0400AAD2 RID: 43730
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400AAD3 RID: 43731
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAD4 RID: 43732
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400AAD5 RID: 43733
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400AAD6 RID: 43734
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400AAD7 RID: 43735
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200092B RID: 2347
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7A8 RID: 55208 RVA: 0x0035A610 File Offset: 0x00358810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100666409);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100666410);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100666411);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100666412);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100666413);
			}

			// Token: 0x0600D7A9 RID: 55209 RVA: 0x0035A6B4 File Offset: 0x003588B4
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7AA RID: 55210 RVA: 0x0035A6F0 File Offset: 0x003588F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29107, RefRangeEnd = 29109, XrefRangeStart = 29107, XrefRangeEnd = 29109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7AB RID: 55211 RVA: 0x0035A734 File Offset: 0x00358934
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 95441, RefRangeEnd = 95458, XrefRangeStart = 95441, XrefRangeEnd = 95458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7AC RID: 55212 RVA: 0x0035A770 File Offset: 0x00358970
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 95441, RefRangeEnd = 95458, XrefRangeStart = 95441, XrefRangeEnd = 95458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7AD RID: 55213 RVA: 0x0035A7AC File Offset: 0x003589AC
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 95441, RefRangeEnd = 95458, XrefRangeStart = 95441, XrefRangeEnd = 95458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7AE RID: 55214 RVA: 0x0006556D File Offset: 0x0006376D
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D7 RID: 16855
			// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x0035A7E8 File Offset: 0x003589E8
			// (set) Token: 0x0600D7B0 RID: 55216 RVA: 0x00065576 File Offset: 0x00063776
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092FD RID: 37629
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x040092FE RID: 37630
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092FF RID: 37631
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x04009300 RID: 37632
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0;

			// Token: 0x04009301 RID: 37633
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0;

			// Token: 0x04009302 RID: 37634
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0;
		}

		// Token: 0x0200092C RID: 2348
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<GenerateNavigationGroup>d__9")]
		public sealed class _GenerateNavigationGroup_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D7B1 RID: 55217 RVA: 0x0035A818 File Offset: 0x00358A18
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateNavigationGroup_d__9()
			{
				Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<GenerateNavigationGroup>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>1__state");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>2__current");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "startPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "destination");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "generalSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "entryPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>8__1");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "callback");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "roadSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitLink");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<destinationOnGraph>5__2");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_StartToEntry>5__3");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_EntryToExit>5__4");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666414);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666415);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666416);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666417);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666418);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100666419);
			}

			// Token: 0x0600D7B2 RID: 55218 RVA: 0x0035A9D4 File Offset: 0x00358BD4
			[CallerCount(83)]
			[CachedScanResults(RefRangeStart = 65267, RefRangeEnd = 65350, XrefRangeStart = 65267, XrefRangeEnd = 65350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GenerateNavigationGroup_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7B3 RID: 55219 RVA: 0x0035AA1C File Offset: 0x00358C1C
			[CallerCount(14950)]
			[CachedScanResults(RefRangeStart = 4192, RefRangeEnd = 19142, XrefRangeStart = 4192, XrefRangeEnd = 19142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7B4 RID: 55220 RVA: 0x0035AA50 File Offset: 0x00358C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95458, XrefRangeEnd = 95500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041E6 RID: 16870
			// (get) Token: 0x0600D7B5 RID: 55221 RVA: 0x0035AA8C File Offset: 0x00358C8C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7B6 RID: 55222 RVA: 0x0035AACC File Offset: 0x00358CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95500, XrefRangeEnd = 95505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041E7 RID: 16871
			// (get) Token: 0x0600D7B7 RID: 55223 RVA: 0x0035AB00 File Offset: 0x00358D00
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 19619, RefRangeEnd = 19643, XrefRangeStart = 19619, XrefRangeEnd = 19643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7B8 RID: 55224 RVA: 0x00065595 File Offset: 0x00063795
			public _GenerateNavigationGroup_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D8 RID: 16856
			// (get) Token: 0x0600D7B9 RID: 55225 RVA: 0x0035AB40 File Offset: 0x00358D40
			// (set) Token: 0x0600D7BA RID: 55226 RVA: 0x0006559E File Offset: 0x0006379E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041D9 RID: 16857
			// (get) Token: 0x0600D7BB RID: 55227 RVA: 0x0035AB68 File Offset: 0x00358D68
			// (set) Token: 0x0600D7BC RID: 55228 RVA: 0x000655B9 File Offset: 0x000637B9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DA RID: 16858
			// (get) Token: 0x0600D7BD RID: 55229 RVA: 0x0035AB98 File Offset: 0x00358D98
			// (set) Token: 0x0600D7BE RID: 55230 RVA: 0x000655D8 File Offset: 0x000637D8
			public unsafe Vector3 startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x170041DB RID: 16859
			// (get) Token: 0x0600D7BF RID: 55231 RVA: 0x0035ABC0 File Offset: 0x00358DC0
			// (set) Token: 0x0600D7C0 RID: 55232 RVA: 0x000655F3 File Offset: 0x000637F3
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x170041DC RID: 16860
			// (get) Token: 0x0600D7C1 RID: 55233 RVA: 0x0035ABE8 File Offset: 0x00358DE8
			// (set) Token: 0x0600D7C2 RID: 55234 RVA: 0x0006560E File Offset: 0x0006380E
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DD RID: 16861
			// (get) Token: 0x0600D7C3 RID: 55235 RVA: 0x0035AC18 File Offset: 0x00358E18
			// (set) Token: 0x0600D7C4 RID: 55236 RVA: 0x0006562D File Offset: 0x0006382D
			public unsafe Vector3 entryPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint)) = value;
				}
			}

			// Token: 0x170041DE RID: 16862
			// (get) Token: 0x0600D7C5 RID: 55237 RVA: 0x0035AC40 File Offset: 0x00358E40
			// (set) Token: 0x0600D7C6 RID: 55238 RVA: 0x00065648 File Offset: 0x00063848
			public unsafe NavigationUtility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041DF RID: 16863
			// (get) Token: 0x0600D7C7 RID: 55239 RVA: 0x0035AC70 File Offset: 0x00358E70
			// (set) Token: 0x0600D7C8 RID: 55240 RVA: 0x00065667 File Offset: 0x00063867
			public unsafe NavigationUtility.PathGroupEvent callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.PathGroupEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E0 RID: 16864
			// (get) Token: 0x0600D7C9 RID: 55241 RVA: 0x0035ACA0 File Offset: 0x00358EA0
			// (set) Token: 0x0600D7CA RID: 55242 RVA: 0x00065686 File Offset: 0x00063886
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E1 RID: 16865
			// (get) Token: 0x0600D7CB RID: 55243 RVA: 0x0035ACD0 File Offset: 0x00358ED0
			// (set) Token: 0x0600D7CC RID: 55244 RVA: 0x000656A5 File Offset: 0x000638A5
			public unsafe NodeLink exitLink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E2 RID: 16866
			// (get) Token: 0x0600D7CD RID: 55245 RVA: 0x0035AD00 File Offset: 0x00358F00
			// (set) Token: 0x0600D7CE RID: 55246 RVA: 0x000656C4 File Offset: 0x000638C4
			public unsafe Vector3 exitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint)) = value;
				}
			}

			// Token: 0x170041E3 RID: 16867
			// (get) Token: 0x0600D7CF RID: 55247 RVA: 0x0035AD28 File Offset: 0x00358F28
			// (set) Token: 0x0600D7D0 RID: 55248 RVA: 0x000656DF File Offset: 0x000638DF
			public unsafe Vector3 _destinationOnGraph_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2)) = value;
				}
			}

			// Token: 0x170041E4 RID: 16868
			// (get) Token: 0x0600D7D1 RID: 55249 RVA: 0x0035AD50 File Offset: 0x00358F50
			// (set) Token: 0x0600D7D2 RID: 55250 RVA: 0x000656FA File Offset: 0x000638FA
			public unsafe Path _path_StartToEntry_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E5 RID: 16869
			// (get) Token: 0x0600D7D3 RID: 55251 RVA: 0x0035AD80 File Offset: 0x00358F80
			// (set) Token: 0x0600D7D4 RID: 55252 RVA: 0x00065719 File Offset: 0x00063919
			public unsafe Path _path_EntryToExit_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009303 RID: 37635
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009304 RID: 37636
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009305 RID: 37637
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x04009306 RID: 37638
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04009307 RID: 37639
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x04009308 RID: 37640
			private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

			// Token: 0x04009309 RID: 37641
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400930A RID: 37642
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400930B RID: 37643
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x0400930C RID: 37644
			private static readonly IntPtr NativeFieldInfoPtr_exitLink;

			// Token: 0x0400930D RID: 37645
			private static readonly IntPtr NativeFieldInfoPtr_exitPoint;

			// Token: 0x0400930E RID: 37646
			private static readonly IntPtr NativeFieldInfoPtr__destinationOnGraph_5__2;

			// Token: 0x0400930F RID: 37647
			private static readonly IntPtr NativeFieldInfoPtr__path_StartToEntry_5__3;

			// Token: 0x04009310 RID: 37648
			private static readonly IntPtr NativeFieldInfoPtr__path_EntryToExit_5__4;

			// Token: 0x04009311 RID: 37649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009312 RID: 37650
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009313 RID: 37651
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009314 RID: 37652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009315 RID: 37653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009316 RID: 37654
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
