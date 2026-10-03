using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.Delivery
{
	// Token: 0x0200041C RID: 1052
	public class DeliveryVehicle : MonoBehaviour
	{
		// Token: 0x06005CDD RID: 23773 RVA: 0x001BB788 File Offset: 0x001B9988
		// Note: this type is marked as 'beforefieldinit'.
		static DeliveryVehicle()
		{
			Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Delivery", "DeliveryVehicle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr);
			DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<Vehicle>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "<ActiveDelivery>k__BackingField");
			DeliveryVehicle.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, "GUID");
			DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675430);
			DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675431);
			DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675432);
			DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675433);
			DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675434);
			DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675435);
			DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675436);
			DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr, 100675437);
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06005CDE RID: 23774 RVA: 0x001BB894 File Offset: 0x001B9A94
		// (set) Token: 0x06005CDF RID: 23775 RVA: 0x001BB8D4 File Offset: 0x001B9AD4
		public unsafe LandVehicle Vehicle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06005CE0 RID: 23776 RVA: 0x001BB918 File Offset: 0x001B9B18
		// (set) Token: 0x06005CE1 RID: 23777 RVA: 0x001BB958 File Offset: 0x001B9B58
		public unsafe DeliveryInstance ActiveDelivery
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2960, RefRangeEnd = 2963, XrefRangeStart = 2960, XrefRangeEnd = 2963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x001BB99C File Offset: 0x001B9B9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199192, XrefRangeEnd = 199199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x001BB9D0 File Offset: 0x001B9BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199225, RefRangeEnd = 199226, XrefRangeStart = 199199, XrefRangeEnd = 199225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Activate(DeliveryInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x001BBA14 File Offset: 0x001B9C14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199239, RefRangeEnd = 199241, XrefRangeStart = 199226, XrefRangeEnd = 199239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr_Deactivate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x001BBA48 File Offset: 0x001B9C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199241, XrefRangeEnd = 199245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeliveryVehicle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeliveryVehicle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeliveryVehicle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x0002BFF2 File Offset: 0x0002A1F2
		public DeliveryVehicle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06005CE7 RID: 23783 RVA: 0x001BBA84 File Offset: 0x001B9C84
		// (set) Token: 0x06005CE8 RID: 23784 RVA: 0x0002BFFB File Offset: 0x0002A1FB
		public unsafe LandVehicle _Vehicle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__Vehicle_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06005CE9 RID: 23785 RVA: 0x001BBAB4 File Offset: 0x001B9CB4
		// (set) Token: 0x06005CEA RID: 23786 RVA: 0x0002C01A File Offset: 0x0002A21A
		public unsafe DeliveryInstance _ActiveDelivery_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr__ActiveDelivery_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06005CEB RID: 23787 RVA: 0x001BBAE4 File Offset: 0x001B9CE4
		// (set) Token: 0x06005CEC RID: 23788 RVA: 0x0002C039 File Offset: 0x0002A239
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeliveryVehicle.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003FB8 RID: 16312
		private static readonly IntPtr NativeFieldInfoPtr__Vehicle_k__BackingField;

		// Token: 0x04003FB9 RID: 16313
		private static readonly IntPtr NativeFieldInfoPtr__ActiveDelivery_k__BackingField;

		// Token: 0x04003FBA RID: 16314
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04003FBB RID: 16315
		private static readonly IntPtr NativeMethodInfoPtr_get_Vehicle_Public_get_LandVehicle_0;

		// Token: 0x04003FBC RID: 16316
		private static readonly IntPtr NativeMethodInfoPtr_set_Vehicle_Private_set_Void_LandVehicle_0;

		// Token: 0x04003FBD RID: 16317
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDelivery_Public_get_DeliveryInstance_0;

		// Token: 0x04003FBE RID: 16318
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveDelivery_Private_set_Void_DeliveryInstance_0;

		// Token: 0x04003FBF RID: 16319
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003FC0 RID: 16320
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_DeliveryInstance_0;

		// Token: 0x04003FC1 RID: 16321
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Void_0;

		// Token: 0x04003FC2 RID: 16322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
