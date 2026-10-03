using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DC RID: 220
	public class VehicleObstacle : MonoBehaviour
	{
		// Token: 0x06001539 RID: 5433 RVA: 0x000C2858 File Offset: 0x000C0A58
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleObstacle()
		{
			Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleObstacle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr);
			VehicleObstacle.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "col");
			VehicleObstacle.NativeFieldInfoPtr_twoSided = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "twoSided");
			VehicleObstacle.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, "type");
			VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr, 100666313);
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x000C28D8 File Offset: 0x000C0AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94903, XrefRangeEnd = 94904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleObstacle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleObstacle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleObstacle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0000B9E0 File Offset: 0x00009BE0
		public VehicleObstacle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x000C2914 File Offset: 0x000C0B14
		// (set) Token: 0x0600153D RID: 5437 RVA: 0x0000B9E9 File Offset: 0x00009BE9
		public unsafe Collider col
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000C2944 File Offset: 0x000C0B44
		// (set) Token: 0x0600153F RID: 5439 RVA: 0x0000BA08 File Offset: 0x00009C08
		public unsafe bool twoSided
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_twoSided)) = value;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x000C296C File Offset: 0x000C0B6C
		// (set) Token: 0x06001541 RID: 5441 RVA: 0x0000BA23 File Offset: 0x00009C23
		public unsafe VehicleObstacle.EObstacleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleObstacle.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr_col;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_twoSided;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000920 RID: 2336
		[OriginalName("Assembly-CSharp.dll", "", "EObstacleType")]
		public enum EObstacleType
		{
			// Token: 0x040092C2 RID: 37570
			Generic,
			// Token: 0x040092C3 RID: 37571
			TrafficLight
		}
	}
}
