using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DE RID: 222
	public class VehicleSeat : MonoBehaviour
	{
		// Token: 0x06001549 RID: 5449 RVA: 0x000C2AF4 File Offset: 0x000C0CF4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSeat()
		{
			Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleSeat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr);
			VehicleSeat.NativeFieldInfoPtr_isDriverSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "isDriverSeat");
			VehicleSeat.NativeFieldInfoPtr_Occupant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, "Occupant");
			VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100666318);
			VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr, 100666319);
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x000C2B74 File Offset: 0x000C0D74
		public unsafe bool isOccupied
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94942, XrefRangeEnd = 94946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000C2BB0 File Offset: 0x000C0DB0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSeat() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSeat>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSeat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0000BA59 File Offset: 0x00009C59
		public VehicleSeat(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000C2BEC File Offset: 0x000C0DEC
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x0000BA62 File Offset: 0x00009C62
		public unsafe bool isDriverSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_isDriverSeat)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000C2C14 File Offset: 0x000C0E14
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x0000BA7D File Offset: 0x00009C7D
		public unsafe Player Occupant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSeat.NativeFieldInfoPtr_Occupant), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeFieldInfoPtr_isDriverSeat;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeFieldInfoPtr_Occupant;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_get_isOccupied_Public_get_Boolean_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
