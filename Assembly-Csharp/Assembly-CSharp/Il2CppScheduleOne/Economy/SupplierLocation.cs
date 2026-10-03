using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200039E RID: 926
	public class SupplierLocation : MonoBehaviour
	{
		// Token: 0x06005418 RID: 21528 RVA: 0x0019E830 File Offset: 0x0019CA30
		// Note: this type is marked as 'beforefieldinit'.
		static SupplierLocation()
		{
			Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "SupplierLocation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr);
			SupplierLocation.NativeFieldInfoPtr_AllLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "AllLocations");
			SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "<ActiveSupplier>k__BackingField");
			SupplierLocation.NativeFieldInfoPtr_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationName");
			SupplierLocation.NativeFieldInfoPtr_LocationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "LocationDescription");
			SupplierLocation.NativeFieldInfoPtr_GenericContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "GenericContainer");
			SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "SupplierStandPoint");
			SupplierLocation.NativeFieldInfoPtr_DeliveryBays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "DeliveryBays");
			SupplierLocation.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "PoI");
			SupplierLocation.NativeFieldInfoPtr_configs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, "configs");
			SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674356);
			SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674357);
			SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674358);
			SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674359);
			SupplierLocation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674360);
			SupplierLocation.NativeMethodInfoPtr_OnSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674361);
			SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674362);
			SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674363);
			SupplierLocation.NativeMethodInfoPtr_SetDeliveryBaysVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674364);
			SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr, 100674365);
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06005419 RID: 21529 RVA: 0x0019E9DC File Offset: 0x0019CBDC
		public unsafe bool IsOccupied
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 187863, RefRangeEnd = 187864, XrefRangeStart = 187859, XrefRangeEnd = 187863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600541A RID: 21530 RVA: 0x0019EA18 File Offset: 0x0019CC18
		// (set) Token: 0x0600541B RID: 21531 RVA: 0x0019EA58 File Offset: 0x0019CC58
		public unsafe Supplier ActiveSupplier
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 2958, RefRangeEnd = 2959, XrefRangeStart = 2958, XrefRangeEnd = 2959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600541C RID: 21532 RVA: 0x0019EA9C File Offset: 0x0019CC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187864, XrefRangeEnd = 187889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541D RID: 21533 RVA: 0x0019EAD0 File Offset: 0x0019CCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187889, XrefRangeEnd = 187917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541E RID: 21534 RVA: 0x0019EB04 File Offset: 0x0019CD04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187917, XrefRangeEnd = 187918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_OnSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600541F RID: 21535 RVA: 0x0019EB38 File Offset: 0x0019CD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 187918, XrefRangeEnd = 187926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005420 RID: 21536 RVA: 0x0019EB6C File Offset: 0x0019CD6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 187956, RefRangeEnd = 187959, XrefRangeStart = 187926, XrefRangeEnd = 187956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSupplier(Supplier supplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(supplier);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005421 RID: 21537 RVA: 0x0019EBB0 File Offset: 0x0019CDB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 187966, RefRangeEnd = 187968, XrefRangeStart = 187959, XrefRangeEnd = 187966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDeliveryBaysVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr_SetDeliveryBaysVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005422 RID: 21538 RVA: 0x0019EBF0 File Offset: 0x0019CDF0
		[CallerCount(204)]
		[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 356, XrefRangeStart = 152, XrefRangeEnd = 356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SupplierLocation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SupplierLocation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SupplierLocation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005423 RID: 21539 RVA: 0x00027B8C File Offset: 0x00025D8C
		public SupplierLocation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x06005424 RID: 21540 RVA: 0x0019EC2C File Offset: 0x0019CE2C
		// (set) Token: 0x06005425 RID: 21541 RVA: 0x00027B95 File Offset: 0x00025D95
		public unsafe static List<SupplierLocation> AllLocations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SupplierLocation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SupplierLocation.NativeFieldInfoPtr_AllLocations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x06005426 RID: 21542 RVA: 0x0019EC54 File Offset: 0x0019CE54
		// (set) Token: 0x06005427 RID: 21543 RVA: 0x00027BA7 File Offset: 0x00025DA7
		public unsafe Supplier _ActiveSupplier_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Supplier>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr__ActiveSupplier_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06005428 RID: 21544 RVA: 0x0019EC84 File Offset: 0x0019CE84
		// (set) Token: 0x06005429 RID: 21545 RVA: 0x00027BC6 File Offset: 0x00025DC6
		public unsafe string LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x0600542A RID: 21546 RVA: 0x0019ECAC File Offset: 0x0019CEAC
		// (set) Token: 0x0600542B RID: 21547 RVA: 0x00027BE5 File Offset: 0x00025DE5
		public unsafe string LocationDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_LocationDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600542C RID: 21548 RVA: 0x0019ECD4 File Offset: 0x0019CED4
		// (set) Token: 0x0600542D RID: 21549 RVA: 0x00027C04 File Offset: 0x00025E04
		public unsafe Transform GenericContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_GenericContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600542E RID: 21550 RVA: 0x0019ED04 File Offset: 0x0019CF04
		// (set) Token: 0x0600542F RID: 21551 RVA: 0x00027C23 File Offset: 0x00025E23
		public unsafe Transform SupplierStandPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_SupplierStandPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x0019ED34 File Offset: 0x0019CF34
		// (set) Token: 0x06005431 RID: 21553 RVA: 0x00027C42 File Offset: 0x00025E42
		public unsafe Il2CppReferenceArray<WorldStorageEntity> DeliveryBays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WorldStorageEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_DeliveryBays), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x0019ED64 File Offset: 0x0019CF64
		// (set) Token: 0x06005433 RID: 21555 RVA: 0x00027C61 File Offset: 0x00025E61
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06005434 RID: 21556 RVA: 0x0019ED94 File Offset: 0x0019CF94
		// (set) Token: 0x06005435 RID: 21557 RVA: 0x00027C80 File Offset: 0x00025E80
		public unsafe Il2CppReferenceArray<SupplierLocationConfiguration> configs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SupplierLocationConfiguration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SupplierLocation.NativeFieldInfoPtr_configs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeFieldInfoPtr_AllLocations;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeFieldInfoPtr__ActiveSupplier_k__BackingField;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeFieldInfoPtr_LocationName;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeFieldInfoPtr_LocationDescription;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeFieldInfoPtr_GenericContainer;

		// Token: 0x040039FD RID: 14845
		private static readonly IntPtr NativeFieldInfoPtr_SupplierStandPoint;

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeFieldInfoPtr_DeliveryBays;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeFieldInfoPtr_configs;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOccupied_Public_get_Boolean_0;

		// Token: 0x04003A02 RID: 14850
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSupplier_Public_get_Supplier_0;

		// Token: 0x04003A03 RID: 14851
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveSupplier_Private_set_Void_Supplier_0;

		// Token: 0x04003A04 RID: 14852
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04003A05 RID: 14853
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04003A06 RID: 14854
		private static readonly IntPtr NativeMethodInfoPtr_OnSleep_Private_Void_0;

		// Token: 0x04003A07 RID: 14855
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04003A08 RID: 14856
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSupplier_Public_Void_Supplier_0;

		// Token: 0x04003A09 RID: 14857
		private static readonly IntPtr NativeMethodInfoPtr_SetDeliveryBaysVisible_Private_Void_Boolean_0;

		// Token: 0x04003A0A RID: 14858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
