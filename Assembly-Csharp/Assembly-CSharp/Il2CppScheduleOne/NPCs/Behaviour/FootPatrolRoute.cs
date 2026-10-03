using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200067A RID: 1658
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x06009FFD RID: 40957 RVA: 0x002AAAD4 File Offset: 0x002A8CD4
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolRoute()
		{
			Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr);
			FootPatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "RouteName");
			FootPatrolRoute.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "PathColor");
			FootPatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "Waypoints");
			FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100684421);
			FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100684422);
			FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100684423);
			FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100684424);
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x002AABA4 File Offset: 0x002A8DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282745, XrefRangeEnd = 282773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x002AABD8 File Offset: 0x002A8DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282773, XrefRangeEnd = 282784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x002AAC0C File Offset: 0x002A8E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaypoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x002AAC40 File Offset: 0x002A8E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282784, XrefRangeEnd = 282789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A002 RID: 40962 RVA: 0x00049966 File Offset: 0x00047B66
		public FootPatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600A003 RID: 40963 RVA: 0x002AAC7C File Offset: 0x002A8E7C
		// (set) Token: 0x0600A004 RID: 40964 RVA: 0x0004996F File Offset: 0x00047B6F
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x002AACA4 File Offset: 0x002A8EA4
		// (set) Token: 0x0600A006 RID: 40966 RVA: 0x0004998E File Offset: 0x00047B8E
		public unsafe Color PathColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor)) = value;
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600A007 RID: 40967 RVA: 0x002AACCC File Offset: 0x002A8ECC
		// (set) Token: 0x0600A008 RID: 40968 RVA: 0x000499A9 File Offset: 0x00047BA9
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x0600A009 RID: 40969 RVA: 0x002AACFC File Offset: 0x002A8EFC
		// (set) Token: 0x0600A00A RID: 40970 RVA: 0x000499C8 File Offset: 0x00047BC8
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04006E68 RID: 28264
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04006E69 RID: 28265
		private static readonly IntPtr NativeFieldInfoPtr_PathColor;

		// Token: 0x04006E6A RID: 28266
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04006E6B RID: 28267
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04006E6C RID: 28268
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04006E6D RID: 28269
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006E6E RID: 28270
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0;

		// Token: 0x04006E6F RID: 28271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
