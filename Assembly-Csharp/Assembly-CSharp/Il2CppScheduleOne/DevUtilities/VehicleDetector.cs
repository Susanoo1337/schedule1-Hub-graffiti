using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200040B RID: 1035
	public class VehicleDetector : MonoBehaviour
	{
		// Token: 0x06005B3E RID: 23358 RVA: 0x001B5FCC File Offset: 0x001B41CC
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleDetector()
		{
			Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "VehicleDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr);
			VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ACTIVATION_DISTANCE_SQ");
			VehicleDetector.NativeFieldInfoPtr_vehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "vehicles");
			VehicleDetector.NativeFieldInfoPtr_closestVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "closestVehicle");
			VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "<IgnoreNewDetections>k__BackingField");
			VehicleDetector.NativeFieldInfoPtr_ignoreExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "ignoreExit");
			VehicleDetector.NativeFieldInfoPtr_detectionColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "detectionColliders");
			VehicleDetector.NativeFieldInfoPtr_collidersEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, "collidersEnabled");
			VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675217);
			VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675218);
			VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675219);
			VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675220);
			VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675221);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675222);
			VehicleDetector.NativeMethodInfoPtr_OnTick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675223);
			VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675224);
			VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675225);
			VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675226);
			VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675227);
			VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675228);
			VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675229);
			VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr, 100675230);
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06005B3F RID: 23359 RVA: 0x001B61A0 File Offset: 0x001B43A0
		// (set) Token: 0x06005B40 RID: 23360 RVA: 0x001B61DC File Offset: 0x001B43DC
		public unsafe bool IgnoreNewDetections
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005B41 RID: 23361 RVA: 0x001B621C File Offset: 0x001B441C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196868, XrefRangeEnd = 196885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B42 RID: 23362 RVA: 0x001B6250 File Offset: 0x001B4450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196885, XrefRangeEnd = 196898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B43 RID: 23363 RVA: 0x001B6284 File Offset: 0x001B4484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196898, XrefRangeEnd = 196913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B44 RID: 23364 RVA: 0x001B62B8 File Offset: 0x001B44B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196913, XrefRangeEnd = 196932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerEnter(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B45 RID: 23365 RVA: 0x001B62FC File Offset: 0x001B44FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196932, XrefRangeEnd = 196950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B46 RID: 23366 RVA: 0x001B6330 File Offset: 0x001B4530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196950, XrefRangeEnd = 196967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerExit(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x001B6374 File Offset: 0x001B4574
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196983, RefRangeEnd = 196986, XrefRangeStart = 196967, XrefRangeEnd = 196983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SortVehicles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SortVehicles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B48 RID: 23368 RVA: 0x001B63A8 File Offset: 0x001B45A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196993, RefRangeEnd = 196995, XrefRangeStart = 196986, XrefRangeEnd = 196993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIgnoreNewCollisions(bool ignore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref ignore;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B49 RID: 23369 RVA: 0x001B63E8 File Offset: 0x001B45E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197000, RefRangeEnd = 197002, XrefRangeStart = 196995, XrefRangeEnd = 197000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreAnyVehiclesOccupied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B4A RID: 23370 RVA: 0x001B6424 File Offset: 0x001B4624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197006, RefRangeEnd = 197007, XrefRangeStart = 197002, XrefRangeEnd = 197006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x001B6458 File Offset: 0x001B4658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197007, XrefRangeEnd = 197015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleDetector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005B4C RID: 23372 RVA: 0x001B6494 File Offset: 0x001B4694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197015, XrefRangeEnd = 197024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float _SortVehicles_b__16_0(LandVehicle x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleDetector.NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005B4D RID: 23373 RVA: 0x0002B33B File Offset: 0x0002953B
		public VehicleDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x06005B4E RID: 23374 RVA: 0x001B64E4 File Offset: 0x001B46E4
		// (set) Token: 0x06005B4F RID: 23375 RVA: 0x0002B344 File Offset: 0x00029544
		public unsafe static float ACTIVATION_DISTANCE_SQ
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehicleDetector.NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ, (void*)(&value));
			}
		}

		// Token: 0x17001C1F RID: 7199
		// (get) Token: 0x06005B50 RID: 23376 RVA: 0x001B6500 File Offset: 0x001B4700
		// (set) Token: 0x06005B51 RID: 23377 RVA: 0x0002B352 File Offset: 0x00029552
		public unsafe List<LandVehicle> vehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_vehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06005B52 RID: 23378 RVA: 0x001B6530 File Offset: 0x001B4730
		// (set) Token: 0x06005B53 RID: 23379 RVA: 0x0002B371 File Offset: 0x00029571
		public unsafe LandVehicle closestVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_closestVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06005B54 RID: 23380 RVA: 0x001B6560 File Offset: 0x001B4760
		// (set) Token: 0x06005B55 RID: 23381 RVA: 0x0002B390 File Offset: 0x00029590
		public unsafe bool _IgnoreNewDetections_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06005B56 RID: 23382 RVA: 0x001B6588 File Offset: 0x001B4788
		// (set) Token: 0x06005B57 RID: 23383 RVA: 0x0002B3AB File Offset: 0x000295AB
		public unsafe bool ignoreExit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_ignoreExit)) = value;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06005B58 RID: 23384 RVA: 0x001B65B0 File Offset: 0x001B47B0
		// (set) Token: 0x06005B59 RID: 23385 RVA: 0x0002B3C6 File Offset: 0x000295C6
		public unsafe Il2CppReferenceArray<Collider> detectionColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_detectionColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06005B5A RID: 23386 RVA: 0x001B65E0 File Offset: 0x001B47E0
		// (set) Token: 0x06005B5B RID: 23387 RVA: 0x0002B3E5 File Offset: 0x000295E5
		public unsafe bool collidersEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleDetector.NativeFieldInfoPtr_collidersEnabled)) = value;
			}
		}

		// Token: 0x04003E8C RID: 16012
		private static readonly IntPtr NativeFieldInfoPtr_ACTIVATION_DISTANCE_SQ;

		// Token: 0x04003E8D RID: 16013
		private static readonly IntPtr NativeFieldInfoPtr_vehicles;

		// Token: 0x04003E8E RID: 16014
		private static readonly IntPtr NativeFieldInfoPtr_closestVehicle;

		// Token: 0x04003E8F RID: 16015
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreNewDetections_k__BackingField;

		// Token: 0x04003E90 RID: 16016
		private static readonly IntPtr NativeFieldInfoPtr_ignoreExit;

		// Token: 0x04003E91 RID: 16017
		private static readonly IntPtr NativeFieldInfoPtr_detectionColliders;

		// Token: 0x04003E92 RID: 16018
		private static readonly IntPtr NativeFieldInfoPtr_collidersEnabled;

		// Token: 0x04003E93 RID: 16019
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreNewDetections_Public_get_Boolean_0;

		// Token: 0x04003E94 RID: 16020
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreNewDetections_Protected_set_Void_Boolean_0;

		// Token: 0x04003E95 RID: 16021
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003E96 RID: 16022
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003E97 RID: 16023
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003E98 RID: 16024
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;

		// Token: 0x04003E99 RID: 16025
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Private_Void_0;

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;

		// Token: 0x04003E9B RID: 16027
		private static readonly IntPtr NativeMethodInfoPtr_SortVehicles_Private_Void_0;

		// Token: 0x04003E9C RID: 16028
		private static readonly IntPtr NativeMethodInfoPtr_SetIgnoreNewCollisions_Public_Void_Boolean_0;

		// Token: 0x04003E9D RID: 16029
		private static readonly IntPtr NativeMethodInfoPtr_AreAnyVehiclesOccupied_Public_Boolean_0;

		// Token: 0x04003E9E RID: 16030
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04003E9F RID: 16031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003EA0 RID: 16032
		private static readonly IntPtr NativeMethodInfoPtr__SortVehicles_b__16_0_Private_Single_LandVehicle_0;
	}
}
