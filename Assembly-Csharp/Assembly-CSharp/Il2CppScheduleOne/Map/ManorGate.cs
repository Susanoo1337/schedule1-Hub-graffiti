using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Tools;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002BB RID: 699
	public class ManorGate : Gate
	{
		// Token: 0x0600362F RID: 13871 RVA: 0x0012F648 File Offset: 0x0012D848
		// Note: this type is marked as 'beforefieldinit'.
		static ManorGate()
		{
			Il2CppClassPointerStore<ManorGate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "ManorGate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManorGate>.NativeClassPtr);
			ManorGate.NativeFieldInfoPtr_IntercomInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomInt");
			ManorGate.NativeFieldInfoPtr_IntercomLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "IntercomLight");
			ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "ExteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorVehicleDetector");
			ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "InteriorPlayerDetector");
			ManorGate.NativeFieldInfoPtr_intercomActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "intercomActive");
			ManorGate.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted");
			ManorGate.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted");
			ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670149);
			ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670150);
			ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670151);
			ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670152);
			ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670153);
			ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670154);
			ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670155);
			ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670156);
			ManorGate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670157);
			ManorGate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670158);
			ManorGate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670159);
			ManorGate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManorGate>.NativeClassPtr, 100670160);
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x0012F81C File Offset: 0x0012DA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141992, XrefRangeEnd = 142000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x0012F858 File Offset: 0x0012DA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142000, XrefRangeEnd = 142013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDetection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateDetection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0012F88C File Offset: 0x0012DA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142013, XrefRangeEnd = 142015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IntercomBuzzed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0012F8C0 File Offset: 0x0012DAC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142019, RefRangeEnd = 142020, XrefRangeStart = 142015, XrefRangeEnd = 142019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnterable(bool enterable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enterable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0012F900 File Offset: 0x0012DB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142022, RefRangeEnd = 142023, XrefRangeStart = 142020, XrefRangeEnd = 142022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_ActivateIntercom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0012F934 File Offset: 0x0012DB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142023, XrefRangeEnd = 142025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIntercomActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0012F974 File Offset: 0x0012DB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142025, XrefRangeEnd = 142027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateIntercom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr_UpdateIntercom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x0012F9A8 File Offset: 0x0012DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManorGate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManorGate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManorGate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x0012F9E4 File Offset: 0x0012DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142027, XrefRangeEnd = 142040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x0012FA20 File Offset: 0x0012DC20
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x0012FA5C File Offset: 0x0012DC5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x0012FA98 File Offset: 0x0012DC98
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManorGate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x0001B8A7 File Offset: 0x00019AA7
		public ManorGate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600363D RID: 13885 RVA: 0x0012FAD4 File Offset: 0x0012DCD4
		// (set) Token: 0x0600363E RID: 13886 RVA: 0x0001B8B0 File Offset: 0x00019AB0
		public unsafe InteractableObject IntercomInt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomInt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0012FB04 File Offset: 0x0012DD04
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x0001B8CF File Offset: 0x00019ACF
		public unsafe Light IntercomLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_IntercomLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0012FB34 File Offset: 0x0012DD34
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x0001B8EE File Offset: 0x00019AEE
		public unsafe VehicleDetector ExteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0012FB64 File Offset: 0x0012DD64
		// (set) Token: 0x06003644 RID: 13892 RVA: 0x0001B90D File Offset: 0x00019B0D
		public unsafe PlayerDetector ExteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_ExteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06003645 RID: 13893 RVA: 0x0012FB94 File Offset: 0x0012DD94
		// (set) Token: 0x06003646 RID: 13894 RVA: 0x0001B92C File Offset: 0x00019B2C
		public unsafe VehicleDetector InteriorVehicleDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorVehicleDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0012FBC4 File Offset: 0x0012DDC4
		// (set) Token: 0x06003648 RID: 13896 RVA: 0x0001B94B File Offset: 0x00019B4B
		public unsafe PlayerDetector InteriorPlayerDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_InteriorPlayerDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0012FBF4 File Offset: 0x0012DDF4
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x0001B96A File Offset: 0x00019B6A
		public unsafe bool intercomActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_intercomActive)) = value;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x0012FC1C File Offset: 0x0012DE1C
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x0001B985 File Offset: 0x00019B85
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x0012FC44 File Offset: 0x0012DE44
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x0001B9A0 File Offset: 0x00019BA0
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManorGate.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002447 RID: 9287
		private static readonly IntPtr NativeFieldInfoPtr_IntercomInt;

		// Token: 0x04002448 RID: 9288
		private static readonly IntPtr NativeFieldInfoPtr_IntercomLight;

		// Token: 0x04002449 RID: 9289
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorVehicleDetector;

		// Token: 0x0400244A RID: 9290
		private static readonly IntPtr NativeFieldInfoPtr_ExteriorPlayerDetector;

		// Token: 0x0400244B RID: 9291
		private static readonly IntPtr NativeFieldInfoPtr_InteriorVehicleDetector;

		// Token: 0x0400244C RID: 9292
		private static readonly IntPtr NativeFieldInfoPtr_InteriorPlayerDetector;

		// Token: 0x0400244D RID: 9293
		private static readonly IntPtr NativeFieldInfoPtr_intercomActive;

		// Token: 0x0400244E RID: 9294
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400244F RID: 9295
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002450 RID: 9296
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002451 RID: 9297
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDetection_Private_Void_0;

		// Token: 0x04002452 RID: 9298
		private static readonly IntPtr NativeMethodInfoPtr_IntercomBuzzed_Public_Void_0;

		// Token: 0x04002453 RID: 9299
		private static readonly IntPtr NativeMethodInfoPtr_SetEnterable_Public_Void_Boolean_0;

		// Token: 0x04002454 RID: 9300
		private static readonly IntPtr NativeMethodInfoPtr_ActivateIntercom_Public_Void_0;

		// Token: 0x04002455 RID: 9301
		private static readonly IntPtr NativeMethodInfoPtr_SetIntercomActive_Public_Void_Boolean_0;

		// Token: 0x04002456 RID: 9302
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIntercom_Private_Void_0;

		// Token: 0x04002457 RID: 9303
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002458 RID: 9304
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002459 RID: 9305
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400245A RID: 9306
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400245B RID: 9307
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
