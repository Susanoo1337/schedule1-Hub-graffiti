using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000450 RID: 1104
	public class CartelMeetingController : MonoBehaviour
	{
		// Token: 0x0600643D RID: 25661 RVA: 0x001D6E40 File Offset: 0x001D5040
		// Note: this type is marked as 'beforefieldinit'.
		static CartelMeetingController()
		{
			Il2CppClassPointerStore<CartelMeetingController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelMeetingController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelMeetingController>.NativeClassPtr);
			CartelMeetingController.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelMeetingController>.NativeClassPtr, "Vehicle");
			CartelMeetingController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelMeetingController>.NativeClassPtr, 100676478);
		}

		// Token: 0x0600643E RID: 25662 RVA: 0x001D6E98 File Offset: 0x001D5098
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelMeetingController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelMeetingController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelMeetingController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643F RID: 25663 RVA: 0x0002F32C File Offset: 0x0002D52C
		public CartelMeetingController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x001D6ED4 File Offset: 0x001D50D4
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x0002F335 File Offset: 0x0002D535
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelMeetingController.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelMeetingController.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004521 RID: 17697
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04004522 RID: 17698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
