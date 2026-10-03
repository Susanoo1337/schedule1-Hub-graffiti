using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Quests;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200065C RID: 1628
	public class CustomerAttendDealBehaviour : Behaviour
	{
		// Token: 0x06009BCE RID: 39886 RVA: 0x0029A384 File Offset: 0x00298584
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerAttendDealBehaviour()
		{
			Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "CustomerAttendDealBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr);
			CustomerAttendDealBehaviour.NativeFieldInfoPtr_DestinationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "DestinationThreshold");
			CustomerAttendDealBehaviour.NativeFieldInfoPtr_WalkSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "WalkSpeedMultiplier");
			CustomerAttendDealBehaviour.NativeFieldInfoPtr__contract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "_contract");
			CustomerAttendDealBehaviour.NativeFieldInfoPtr__customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "_customer");
			CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CustomerAttendDealBehaviourAssembly-CSharp.dll_Excuted");
			CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CustomerAttendDealBehaviourAssembly-CSharp.dll_Excuted");
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_get__location_Private_get_DeliveryLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683621);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683622);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_SetContract_Public_Void_Contract_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683623);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683624);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683625);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683626);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683627);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_EnsureNPCHasEnoughCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683628);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683629);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_CheckWarp_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683630);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683631);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683632);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683633);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683634);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683635);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683636);
			CustomerAttendDealBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr, 100683637);
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x0029A580 File Offset: 0x00298780
		public unsafe DeliveryLocation _location
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr_get__location_Private_get_DeliveryLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr3) : null;
			}
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x0029A5C0 File Offset: 0x002987C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277431, XrefRangeEnd = 277444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x0029A5FC File Offset: 0x002987FC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109090, RefRangeEnd = 109096, XrefRangeStart = 109090, XrefRangeEnd = 109096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetContract(Contract contract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(contract);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr_SetContract_Public_Void_Contract_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x0029A640 File Offset: 0x00298840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277444, XrefRangeEnd = 277465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Activate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Activate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x0029A67C File Offset: 0x0029887C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277465, XrefRangeEnd = 277475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x0029A6B8 File Offset: 0x002988B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277475, XrefRangeEnd = 277483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deactivate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x0029A6F4 File Offset: 0x002988F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277483, XrefRangeEnd = 277491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Pause_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x0029A730 File Offset: 0x00298930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277491, XrefRangeEnd = 277496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureNPCHasEnoughCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr_EnsureNPCHasEnoughCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x0029A764 File Offset: 0x00298964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277496, XrefRangeEnd = 277508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnActiveTick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x0029A7A0 File Offset: 0x002989A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277553, RefRangeEnd = 277554, XrefRangeStart = 277508, XrefRangeEnd = 277553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWarp()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr_CheckWarp_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x0029A7D4 File Offset: 0x002989D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 277562, RefRangeEnd = 277563, XrefRangeStart = 277554, XrefRangeEnd = 277562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x0029A810 File Offset: 0x00298A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277563, XrefRangeEnd = 277571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x0029A85C File Offset: 0x00298A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 276250, RefRangeEnd = 276252, XrefRangeStart = 276250, XrefRangeEnd = 276252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerAttendDealBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAttendDealBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAttendDealBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x0029A898 File Offset: 0x00298A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277571, XrefRangeEnd = 277572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x0029A8D4 File Offset: 0x00298AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277572, XrefRangeEnd = 277573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x0029A910 File Offset: 0x00298B10
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x0029A94C File Offset: 0x00298B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277573, XrefRangeEnd = 277585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CustomerAttendDealBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0004862D File Offset: 0x0004682D
		public CustomerAttendDealBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x06009BE1 RID: 39905 RVA: 0x0029A988 File Offset: 0x00298B88
		// (set) Token: 0x06009BE2 RID: 39906 RVA: 0x00048636 File Offset: 0x00046836
		public unsafe static float DestinationThreshold
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CustomerAttendDealBehaviour.NativeFieldInfoPtr_DestinationThreshold, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomerAttendDealBehaviour.NativeFieldInfoPtr_DestinationThreshold, (void*)(&value));
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06009BE3 RID: 39907 RVA: 0x0029A9A4 File Offset: 0x00298BA4
		// (set) Token: 0x06009BE4 RID: 39908 RVA: 0x00048644 File Offset: 0x00046844
		public unsafe static float WalkSpeedMultiplier
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CustomerAttendDealBehaviour.NativeFieldInfoPtr_WalkSpeedMultiplier, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CustomerAttendDealBehaviour.NativeFieldInfoPtr_WalkSpeedMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x06009BE5 RID: 39909 RVA: 0x0029A9C0 File Offset: 0x00298BC0
		// (set) Token: 0x06009BE6 RID: 39910 RVA: 0x00048652 File Offset: 0x00046852
		public unsafe Contract _contract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr__contract);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Contract>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr__contract), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06009BE7 RID: 39911 RVA: 0x0029A9F0 File Offset: 0x00298BF0
		// (set) Token: 0x06009BE8 RID: 39912 RVA: 0x00048671 File Offset: 0x00046871
		public unsafe Customer _customer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr__customer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr__customer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x06009BE9 RID: 39913 RVA: 0x0029AA20 File Offset: 0x00298C20
		// (set) Token: 0x06009BEA RID: 39914 RVA: 0x00048690 File Offset: 0x00046890
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009BEB RID: 39915 RVA: 0x0029AA48 File Offset: 0x00298C48
		// (set) Token: 0x06009BEC RID: 39916 RVA: 0x000486AB File Offset: 0x000468AB
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAttendDealBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006B25 RID: 27429
		private static readonly IntPtr NativeFieldInfoPtr_DestinationThreshold;

		// Token: 0x04006B26 RID: 27430
		private static readonly IntPtr NativeFieldInfoPtr_WalkSpeedMultiplier;

		// Token: 0x04006B27 RID: 27431
		private static readonly IntPtr NativeFieldInfoPtr__contract;

		// Token: 0x04006B28 RID: 27432
		private static readonly IntPtr NativeFieldInfoPtr__customer;

		// Token: 0x04006B29 RID: 27433
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006B2A RID: 27434
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006B2B RID: 27435
		private static readonly IntPtr NativeMethodInfoPtr_get__location_Private_get_DeliveryLocation_0;

		// Token: 0x04006B2C RID: 27436
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04006B2D RID: 27437
		private static readonly IntPtr NativeMethodInfoPtr_SetContract_Public_Void_Contract_0;

		// Token: 0x04006B2E RID: 27438
		private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Virtual_Void_0;

		// Token: 0x04006B2F RID: 27439
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04006B30 RID: 27440
		private static readonly IntPtr NativeMethodInfoPtr_Deactivate_Public_Virtual_Void_0;

		// Token: 0x04006B31 RID: 27441
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Virtual_Void_0;

		// Token: 0x04006B32 RID: 27442
		private static readonly IntPtr NativeMethodInfoPtr_EnsureNPCHasEnoughCash_Private_Void_0;

		// Token: 0x04006B33 RID: 27443
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveTick_Public_Virtual_Void_0;

		// Token: 0x04006B34 RID: 27444
		private static readonly IntPtr NativeMethodInfoPtr_CheckWarp_Private_Void_0;

		// Token: 0x04006B35 RID: 27445
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04006B36 RID: 27446
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x04006B37 RID: 27447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006B38 RID: 27448
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006B39 RID: 27449
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006B3A RID: 27450
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006B3B RID: 27451
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
