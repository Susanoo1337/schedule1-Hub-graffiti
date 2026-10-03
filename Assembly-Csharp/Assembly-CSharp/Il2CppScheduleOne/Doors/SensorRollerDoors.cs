using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x020003AE RID: 942
	public class SensorRollerDoors : RollerDoor
	{
		// Token: 0x060055AF RID: 21935 RVA: 0x001A3D68 File Offset: 0x001A1F68
		// Note: this type is marked as 'beforefieldinit'.
		static SensorRollerDoors()
		{
			Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "SensorRollerDoors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr);
			SensorRollerDoors.NativeFieldInfoPtr_Detector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "Detector");
			SensorRollerDoors.NativeFieldInfoPtr_ClipDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "ClipDetector");
			SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, "DetectPlayerOccupiedVehiclesOnly");
			SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100674526);
			SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr, 100674527);
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x001A3DFC File Offset: 0x001A1FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189497, XrefRangeEnd = 189508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensorRollerDoors.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x001A3E38 File Offset: 0x001A2038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensorRollerDoors() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensorRollerDoors>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensorRollerDoors.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x000287E3 File Offset: 0x000269E3
		public SensorRollerDoors(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x001A3E74 File Offset: 0x001A2074
		// (set) Token: 0x060055B4 RID: 21940 RVA: 0x000287EC File Offset: 0x000269EC
		public unsafe VehicleDetector Detector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_Detector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060055B5 RID: 21941 RVA: 0x001A3EA4 File Offset: 0x001A20A4
		// (set) Token: 0x060055B6 RID: 21942 RVA: 0x0002880B File Offset: 0x00026A0B
		public unsafe VehicleDetector ClipDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_ClipDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060055B7 RID: 21943 RVA: 0x001A3ED4 File Offset: 0x001A20D4
		// (set) Token: 0x060055B8 RID: 21944 RVA: 0x0002882A File Offset: 0x00026A2A
		public unsafe bool DetectPlayerOccupiedVehiclesOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SensorRollerDoors.NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly)) = value;
			}
		}

		// Token: 0x04003B0F RID: 15119
		private static readonly IntPtr NativeFieldInfoPtr_Detector;

		// Token: 0x04003B10 RID: 15120
		private static readonly IntPtr NativeFieldInfoPtr_ClipDetector;

		// Token: 0x04003B11 RID: 15121
		private static readonly IntPtr NativeFieldInfoPtr_DetectPlayerOccupiedVehiclesOnly;

		// Token: 0x04003B12 RID: 15122
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04003B13 RID: 15123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
