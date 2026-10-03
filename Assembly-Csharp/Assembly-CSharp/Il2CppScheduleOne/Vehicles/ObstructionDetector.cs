using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000CF RID: 207
	public class ObstructionDetector : MonoBehaviour
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x000BEC74 File Offset: 0x000BCE74
		// Note: this type is marked as 'beforefieldinit'.
		static ObstructionDetector()
		{
			Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ObstructionDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr);
			ObstructionDetector.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicle");
			ObstructionDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicles");
			ObstructionDetector.NativeFieldInfoPtr_npcs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "npcs");
			ObstructionDetector.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "players");
			ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "vehicleObstacles");
			ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "closestObstructionDistance");
			ObstructionDetector.NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, "range");
			ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100666201);
			ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100666202);
			ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100666203);
			ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr, 100666204);
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x000BED80 File Offset: 0x000BCF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93519, XrefRangeEnd = 93530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x000BEDBC File Offset: 0x000BCFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93530, XrefRangeEnd = 93622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObstructionDetector.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x000BEDF8 File Offset: 0x000BCFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93622, XrefRangeEnd = 93683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x000BEE3C File Offset: 0x000BD03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93683, XrefRangeEnd = 93712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObstructionDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObstructionDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObstructionDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0000B013 File Offset: 0x00009213
		public ObstructionDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000BEE78 File Offset: 0x000BD078
		// (set) Token: 0x0600140C RID: 5132 RVA: 0x0000B01C File Offset: 0x0000921C
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x000BEEA8 File Offset: 0x000BD0A8
		// (set) Token: 0x0600140E RID: 5134 RVA: 0x0000B03B File Offset: 0x0000923B
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x000BEED8 File Offset: 0x000BD0D8
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x0000B05A File Offset: 0x0000925A
		public unsafe List<NPC> npcs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_npcs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x000BEF08 File Offset: 0x000BD108
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x0000B079 File Offset: 0x00009279
		public unsafe List<PlayerMovement> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayerMovement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x000BEF38 File Offset: 0x000BD138
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x0000B098 File Offset: 0x00009298
		public unsafe List<VehicleObstacle> vehicleObstacles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleObstacle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_vehicleObstacles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x000BEF68 File Offset: 0x000BD168
		// (set) Token: 0x06001416 RID: 5142 RVA: 0x0000B0B7 File Offset: 0x000092B7
		public unsafe float closestObstructionDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_closestObstructionDistance)) = value;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x000BEF90 File Offset: 0x000BD190
		// (set) Token: 0x06001418 RID: 5144 RVA: 0x0000B0D2 File Offset: 0x000092D2
		public unsafe float range
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObstructionDetector.NativeFieldInfoPtr_range)) = value;
			}
		}

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_npcs;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeFieldInfoPtr_vehicleObstacles;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeFieldInfoPtr_closestObstructionDistance;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeFieldInfoPtr_range;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
