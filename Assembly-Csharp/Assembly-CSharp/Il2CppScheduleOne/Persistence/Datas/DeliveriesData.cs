using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Delivery;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000204 RID: 516
	public class DeliveriesData : SaveData
	{
		// Token: 0x06002DD0 RID: 11728 RVA: 0x00113E8C File Offset: 0x0011208C
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveriesData()
		{
			Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DeliveriesData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr);
			DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "ActiveDeliveries");
			DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "DeliveryVehicles");
			DeliveriesData.NativeFieldInfoPtr_DeliveryHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "DeliveryHistory");
			DeliveriesData.NativeFieldInfoPtr_DisplayedDeliveryHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, "DisplayedDeliveryHistory");
			DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_Il2CppReferenceArray_1_DeliveryReceipt_Il2CppReferenceArray_1_DeliveryReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr, 100669321);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x00113F20 File Offset: 0x00112120
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 134371, RefRangeEnd = 134373, XrefRangeStart = 134366, XrefRangeEnd = 134371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveriesData(Il2CppReferenceArray<DeliveryInstance> deliveries, Il2CppReferenceArray<VehicleData> deliveryVehicles, Il2CppReferenceArray<DeliveryReceipt> deliveryHistory, Il2CppReferenceArray<DeliveryReceipt> displayedDeliveryHistory) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveriesData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(deliveries);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryVehicles);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(deliveryHistory);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(displayedDeliveryHistory);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveriesData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_Il2CppReferenceArray_1_DeliveryReceipt_Il2CppReferenceArray_1_DeliveryReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x0001730B File Offset: 0x0001550B
		public DeliveriesData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x00113FA4 File Offset: 0x001121A4
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00017314 File Offset: 0x00015514
		public unsafe Il2CppReferenceArray<DeliveryInstance> ActiveDeliveries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_ActiveDeliveries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x00113FD4 File Offset: 0x001121D4
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x00017333 File Offset: 0x00015533
		public unsafe Il2CppReferenceArray<VehicleData> DeliveryVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VehicleData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x00114004 File Offset: 0x00112204
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x00017352 File Offset: 0x00015552
		public unsafe Il2CppReferenceArray<DeliveryReceipt> DeliveryHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DeliveryHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x00114034 File Offset: 0x00112234
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x00017371 File Offset: 0x00015571
		public unsafe Il2CppReferenceArray<DeliveryReceipt> DisplayedDeliveryHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DisplayedDeliveryHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DeliveryReceipt>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveriesData.NativeFieldInfoPtr_DisplayedDeliveryHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_ActiveDeliveries;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryVehicles;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryHistory;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedDeliveryHistory;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_DeliveryInstance_Il2CppReferenceArray_1_VehicleData_Il2CppReferenceArray_1_DeliveryReceipt_Il2CppReferenceArray_1_DeliveryReceipt_0;
	}
}
