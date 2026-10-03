using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200068B RID: 1675
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x0600A2C6 RID: 41670 RVA: 0x002B4BD4 File Offset: 0x002B2DD4
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolRoute()
		{
			Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr);
			VehiclePatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "RouteName");
			VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "Waypoints");
			VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100684824);
			VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100684825);
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x002B4C68 File Offset: 0x002B2E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286577, XrefRangeEnd = 286605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x002B4C9C File Offset: 0x002B2E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286605, XrefRangeEnd = 286610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x0004AA33 File Offset: 0x00048C33
		public VehiclePatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700310D RID: 12557
		// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x002B4CD8 File Offset: 0x002B2ED8
		// (set) Token: 0x0600A2CB RID: 41675 RVA: 0x0004AA3C File Offset: 0x00048C3C
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700310E RID: 12558
		// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x002B4D00 File Offset: 0x002B2F00
		// (set) Token: 0x0600A2CD RID: 41677 RVA: 0x0004AA5B File Offset: 0x00048C5B
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700310F RID: 12559
		// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x002B4D30 File Offset: 0x002B2F30
		// (set) Token: 0x0600A2CF RID: 41679 RVA: 0x0004AA7A File Offset: 0x00048C7A
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04007071 RID: 28785
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04007072 RID: 28786
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04007073 RID: 28787
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04007074 RID: 28788
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04007075 RID: 28789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
