using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200016D RID: 365
	public class Sweatshop : Property
	{
		// Token: 0x0600249F RID: 9375 RVA: 0x000F4710 File Offset: 0x000F2910
		// Note: this type is marked as 'beforefieldinit'.
		static Sweatshop()
		{
			Il2CppClassPointerStore<Sweatshop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Sweatshop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr);
			Sweatshop.NativeFieldInfoPtr_pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "pots");
			Sweatshop.NativeFieldInfoPtr_packagingStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "packagingStations");
			Sweatshop.NativeFieldInfoPtr_mixingStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "mixingStations");
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.SweatshopAssembly-CSharp.dll_Excuted");
			Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668057);
			Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668058);
			Sweatshop.NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668059);
			Sweatshop.NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668060);
			Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668061);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668062);
			Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668063);
			Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668064);
			Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr, 100668065);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x000F4858 File Offset: 0x000F2A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114701, XrefRangeEnd = 114718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x000F4894 File Offset: 0x000F2A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114718, XrefRangeEnd = 114744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVariables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr_UpdateVariables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x000F48C8 File Offset: 0x000F2AC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114744, XrefRangeEnd = 114759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildableItemRemoved(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x000F490C File Offset: 0x000F2B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114759, XrefRangeEnd = 114774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildableItemAdded(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x000F4950 File Offset: 0x000F2B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114774, XrefRangeEnd = 114799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sweatshop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sweatshop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sweatshop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x000F498C File Offset: 0x000F2B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x000F49C8 File Offset: 0x000F2BC8
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x000F4A04 File Offset: 0x000F2C04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x000F4A40 File Offset: 0x000F2C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sweatshop.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000134FE File Offset: 0x000116FE
		public Sweatshop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060024AA RID: 9386 RVA: 0x000F4A7C File Offset: 0x000F2C7C
		// (set) Token: 0x060024AB RID: 9387 RVA: 0x00013507 File Offset: 0x00011707
		public unsafe List<Pot> pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x000F4AAC File Offset: 0x000F2CAC
		// (set) Token: 0x060024AD RID: 9389 RVA: 0x00013526 File Offset: 0x00011726
		public unsafe List<PackagingStation> packagingStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_packagingStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_packagingStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x000F4ADC File Offset: 0x000F2CDC
		// (set) Token: 0x060024AF RID: 9391 RVA: 0x00013545 File Offset: 0x00011745
		public unsafe List<MixingStation> mixingStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_mixingStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_mixingStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000F4B0C File Offset: 0x000F2D0C
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x00013564 File Offset: 0x00011764
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000F4B34 File Offset: 0x000F2D34
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x0001357F File Offset: 0x0001177F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sweatshop.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeFieldInfoPtr_pots;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeFieldInfoPtr_packagingStations;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeFieldInfoPtr_mixingStations;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04001954 RID: 6484
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04001955 RID: 6485
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001956 RID: 6486
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVariables_Private_Void_0;

		// Token: 0x04001957 RID: 6487
		private static readonly IntPtr NativeMethodInfoPtr_BuildableItemRemoved_Private_Void_BuildableItem_0;

		// Token: 0x04001958 RID: 6488
		private static readonly IntPtr NativeMethodInfoPtr_BuildableItemAdded_Private_Void_BuildableItem_0;

		// Token: 0x04001959 RID: 6489
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400195A RID: 6490
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400195B RID: 6491
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400195C RID: 6492
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400195D RID: 6493
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
