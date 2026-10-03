using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000D9 RID: 217
	public class VehicleInitializer : NetworkBehaviour
	{
		// Token: 0x060014B6 RID: 5302 RVA: 0x000C0B9C File Offset: 0x000BED9C
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleInitializer()
		{
			Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr);
			VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "InitialParkingLot");
			VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted");
			VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleInitializerAssembly-CSharp.dll_Excuted");
			VehicleInitializer.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666256);
			VehicleInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666257);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666258);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666259);
			VehicleInitializer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666260);
			VehicleInitializer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr, 100666261);
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x000C0C80 File Offset: 0x000BEE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94386, XrefRangeEnd = 94409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x000C0CBC File Offset: 0x000BEEBC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleInitializer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x000C0CF8 File Offset: 0x000BEEF8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x000C0D34 File Offset: 0x000BEF34
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x000C0D70 File Offset: 0x000BEF70
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x000C0DAC File Offset: 0x000BEFAC
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleInitializer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0000B5C0 File Offset: 0x000097C0
		public VehicleInitializer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000C0DE8 File Offset: 0x000BEFE8
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x0000B5C9 File Offset: 0x000097C9
		public unsafe ParkingLot InitialParkingLot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParkingLot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_InitialParkingLot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000C0E18 File Offset: 0x000BF018
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000C0E40 File Offset: 0x000BF040
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x0000B603 File Offset: 0x00009803
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleInitializer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeFieldInfoPtr_InitialParkingLot;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
