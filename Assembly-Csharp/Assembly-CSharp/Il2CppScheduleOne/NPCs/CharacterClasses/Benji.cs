using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000651 RID: 1617
	public class Benji : Dealer
	{
		// Token: 0x06009A25 RID: 39461 RVA: 0x002941E8 File Offset: 0x002923E8
		// Note: this type is marked as 'beforefieldinit'.
		static Benji()
		{
			Il2CppClassPointerStore<Benji>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Benji");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benji>.NativeClassPtr);
			Benji.NativeFieldInfoPtr_CompletedDealsVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "CompletedDealsVariable");
			Benji.NativeFieldInfoPtr_onRecruitmentRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "onRecruitmentRequested");
			Benji.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted");
			Benji.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted");
			Benji.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683365);
			Benji.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683366);
			Benji.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683367);
			Benji.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683368);
			Benji.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683369);
			Benji.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683370);
			Benji.NativeMethodInfoPtr_IncrementCompletedDeals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683371);
			Benji.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683372);
			Benji.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683373);
			Benji.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683374);
			Benji.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683375);
			Benji.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100683376);
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x00294358 File Offset: 0x00292558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274380, XrefRangeEnd = 274388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x002943A8 File Offset: 0x002925A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274388, XrefRangeEnd = 274433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x002943E4 File Offset: 0x002925E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274433, XrefRangeEnd = 274443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x00294434 File Offset: 0x00292634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274443, XrefRangeEnd = 274453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x00294484 File Offset: 0x00292684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274453, XrefRangeEnd = 274455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x002944C0 File Offset: 0x002926C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274455, XrefRangeEnd = 274458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x002944FC File Offset: 0x002926FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274458, XrefRangeEnd = 274473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementCompletedDeals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benji.NativeMethodInfoPtr_IncrementCompletedDeals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00294530 File Offset: 0x00292730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274473, XrefRangeEnd = 274480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benji() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benji>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benji.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x0029456C File Offset: 0x0029276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274480, XrefRangeEnd = 274481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x002945A8 File Offset: 0x002927A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274481, XrefRangeEnd = 274482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x002945E4 File Offset: 0x002927E4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x00294620 File Offset: 0x00292820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x00047C9B File Offset: 0x00045E9B
		public Benji(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x0029465C File Offset: 0x0029285C
		// (set) Token: 0x06009A34 RID: 39476 RVA: 0x00047CA4 File Offset: 0x00045EA4
		public unsafe string CompletedDealsVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_CompletedDealsVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_CompletedDealsVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x00294684 File Offset: 0x00292884
		// (set) Token: 0x06009A36 RID: 39478 RVA: 0x00047CC3 File Offset: 0x00045EC3
		public unsafe UnityEvent onRecruitmentRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_onRecruitmentRequested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_onRecruitmentRequested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009A37 RID: 39479 RVA: 0x002946B4 File Offset: 0x002928B4
		// (set) Token: 0x06009A38 RID: 39480 RVA: 0x00047CE2 File Offset: 0x00045EE2
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x002946DC File Offset: 0x002928DC
		// (set) Token: 0x06009A3A RID: 39482 RVA: 0x00047CFD File Offset: 0x00045EFD
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040069E9 RID: 27113
		private static readonly IntPtr NativeFieldInfoPtr_CompletedDealsVariable;

		// Token: 0x040069EA RID: 27114
		private static readonly IntPtr NativeFieldInfoPtr_onRecruitmentRequested;

		// Token: 0x040069EB RID: 27115
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040069EC RID: 27116
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040069ED RID: 27117
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040069EE RID: 27118
		private static readonly IntPtr NativeMethodInfoPtr_OnTick_Protected_Virtual_Void_0;

		// Token: 0x040069EF RID: 27119
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0;

		// Token: 0x040069F0 RID: 27120
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0;

		// Token: 0x040069F1 RID: 27121
		private static readonly IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0;

		// Token: 0x040069F2 RID: 27122
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0;

		// Token: 0x040069F3 RID: 27123
		private static readonly IntPtr NativeMethodInfoPtr_IncrementCompletedDeals_Private_Void_0;

		// Token: 0x040069F4 RID: 27124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040069F5 RID: 27125
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040069F6 RID: 27126
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040069F7 RID: 27127
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040069F8 RID: 27128
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
