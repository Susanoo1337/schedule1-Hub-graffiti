using System;
using Il2Cpp;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000451 RID: 1105
	public class CartelRegionActivities : NetworkBehaviour
	{
		// Token: 0x06006442 RID: 25666 RVA: 0x001D6F04 File Offset: 0x001D5104
		// Note: this type is marked as 'beforefieldinit'.
		static CartelRegionActivities()
		{
			Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelRegionActivities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr);
			CartelRegionActivities.NativeFieldInfoPtr_MIN_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "MIN_COOLDOWN");
			CartelRegionActivities.NativeFieldInfoPtr_MAX_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "MAX_COOLDOWN");
			CartelRegionActivities.NativeFieldInfoPtr_TEST_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "TEST_MODE");
			CartelRegionActivities.NativeFieldInfoPtr__CurrentActivity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "<CurrentActivity>k__BackingField");
			CartelRegionActivities.NativeFieldInfoPtr__HoursUntilNextActivity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "<HoursUntilNextActivity>k__BackingField");
			CartelRegionActivities.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "Active");
			CartelRegionActivities.NativeFieldInfoPtr_Region = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "Region");
			CartelRegionActivities.NativeFieldInfoPtr_Activities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "Activities");
			CartelRegionActivities.NativeFieldInfoPtr_AmbushLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "AmbushLocations");
			CartelRegionActivities.NativeFieldInfoPtr_CartelDealer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "CartelDealer");
			CartelRegionActivities.NativeFieldInfoPtr__debugActivityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "_debugActivityIndex");
			CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted");
			CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelRegionActivitiesAssembly-CSharp.dll_Excuted");
			CartelRegionActivities.NativeMethodInfoPtr_get_CurrentActivity_Public_get_CartelActivity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676479);
			CartelRegionActivities.NativeMethodInfoPtr_set_CurrentActivity_Private_set_Void_CartelActivity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676480);
			CartelRegionActivities.NativeMethodInfoPtr_get_HoursUntilNextActivity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676481);
			CartelRegionActivities.NativeMethodInfoPtr_set_HoursUntilNextActivity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676482);
			CartelRegionActivities.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676483);
			CartelRegionActivities.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676484);
			CartelRegionActivities.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676485);
			CartelRegionActivities.NativeMethodInfoPtr_HourPass_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676486);
			CartelRegionActivities.NativeMethodInfoPtr_TryStartActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676487);
			CartelRegionActivities.NativeMethodInfoPtr_StartActivity_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676488);
			CartelRegionActivities.NativeMethodInfoPtr_StartAcivity_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676489);
			CartelRegionActivities.NativeMethodInfoPtr_ActivateDeal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676490);
			CartelRegionActivities.NativeMethodInfoPtr_StartActivity_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676491);
			CartelRegionActivities.NativeMethodInfoPtr_ActivityEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676492);
			CartelRegionActivities.NativeMethodInfoPtr_GetData_Public_CartelRegionalActivityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676493);
			CartelRegionActivities.NativeMethodInfoPtr_Load_Public_Void_CartelRegionalActivityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676494);
			CartelRegionActivities.NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676495);
			CartelRegionActivities.NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676496);
			CartelRegionActivities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676497);
			CartelRegionActivities.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676498);
			CartelRegionActivities.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676499);
			CartelRegionActivities.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676500);
			CartelRegionActivities.NativeMethodInfoPtr_RpcWriter___Observers_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676501);
			CartelRegionActivities.NativeMethodInfoPtr_RpcLogic___StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676502);
			CartelRegionActivities.NativeMethodInfoPtr_RpcReader___Observers_StartActivity_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676503);
			CartelRegionActivities.NativeMethodInfoPtr_RpcWriter___Target_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676504);
			CartelRegionActivities.NativeMethodInfoPtr_RpcReader___Target_StartActivity_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676505);
			CartelRegionActivities.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr, 100676506);
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06006443 RID: 25667 RVA: 0x001D7268 File Offset: 0x001D5468
		// (set) Token: 0x06006444 RID: 25668 RVA: 0x001D72A8 File Offset: 0x001D54A8
		public unsafe CartelActivity CurrentActivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_get_CurrentActivity_Public_get_CartelActivity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelActivity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_set_CurrentActivity_Private_set_Void_CartelActivity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06006445 RID: 25669 RVA: 0x001D72EC File Offset: 0x001D54EC
		// (set) Token: 0x06006446 RID: 25670 RVA: 0x001D7328 File Offset: 0x001D5528
		public unsafe int HoursUntilNextActivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_get_HoursUntilNextActivity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_set_HoursUntilNextActivity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006447 RID: 25671 RVA: 0x001D7368 File Offset: 0x001D5568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210684, XrefRangeEnd = 210693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006448 RID: 25672 RVA: 0x001D73A4 File Offset: 0x001D55A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210693, XrefRangeEnd = 210734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006449 RID: 25673 RVA: 0x001D73D8 File Offset: 0x001D55D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210734, XrefRangeEnd = 210744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644A RID: 25674 RVA: 0x001D7428 File Offset: 0x001D5628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210744, XrefRangeEnd = 210756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_HourPass_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x001D745C File Offset: 0x001D565C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210816, RefRangeEnd = 210817, XrefRangeStart = 210756, XrefRangeEnd = 210816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_TryStartActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x001D7490 File Offset: 0x001D5690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210817, XrefRangeEnd = 210818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_StartActivity_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x001D74C4 File Offset: 0x001D56C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210818, XrefRangeEnd = 210819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAcivity(int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_StartAcivity_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x001D7504 File Offset: 0x001D5704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210819, XrefRangeEnd = 210820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivateDeal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_ActivateDeal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x001D7538 File Offset: 0x001D5738
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 210861, RefRangeEnd = 210867, XrefRangeStart = 210820, XrefRangeEnd = 210861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartActivity(NetworkConnection conn, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_StartActivity_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x001D7588 File Offset: 0x001D5788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210867, XrefRangeEnd = 210883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivityEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_ActivityEnded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x001D75BC File Offset: 0x001D57BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210894, RefRangeEnd = 210895, XrefRangeStart = 210883, XrefRangeEnd = 210894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelRegionalActivityData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_GetData_Public_CartelRegionalActivityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelRegionalActivityData>(intPtr3) : null;
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x001D75FC File Offset: 0x001D57FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 210899, RefRangeEnd = 210900, XrefRangeStart = 210895, XrefRangeEnd = 210899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(CartelRegionalActivityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_Load_Public_Void_CartelRegionalActivityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x001D7640 File Offset: 0x001D5840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 210958, RefRangeEnd = 210962, XrefRangeStart = 210900, XrefRangeEnd = 210958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNewCooldown(EMapRegion region)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_EMapRegion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x001D7680 File Offset: 0x001D5880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210962, XrefRangeEnd = 210963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CartelStatusChange(ECartelStatus oldStatus, ECartelStatus newStatus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldStatus;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newStatus;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x001D76CC File Offset: 0x001D58CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210963, XrefRangeEnd = 210971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelRegionActivities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelRegionActivities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x001D7708 File Offset: 0x001D5908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210971, XrefRangeEnd = 210984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006457 RID: 25687 RVA: 0x001D7744 File Offset: 0x001D5944
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006458 RID: 25688 RVA: 0x001D7780 File Offset: 0x001D5980
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006459 RID: 25689 RVA: 0x001D77BC File Offset: 0x001D59BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210984, XrefRangeEnd = 210995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_RpcWriter___Observers_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645A RID: 25690 RVA: 0x001D780C File Offset: 0x001D5A0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211033, RefRangeEnd = 211036, XrefRangeStart = 210995, XrefRangeEnd = 211033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_RpcLogic___StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645B RID: 25691 RVA: 0x001D785C File Offset: 0x001D5A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211036, XrefRangeEnd = 211041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_RpcReader___Observers_StartActivity_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645C RID: 25692 RVA: 0x001D78AC File Offset: 0x001D5AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211041, XrefRangeEnd = 211052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartActivity_2681120339(NetworkConnection conn, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_RpcWriter___Target_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645D RID: 25693 RVA: 0x001D78FC File Offset: 0x001D5AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211052, XrefRangeEnd = 211057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartActivity_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelRegionActivities.NativeMethodInfoPtr_RpcReader___Target_StartActivity_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645E RID: 25694 RVA: 0x001D794C File Offset: 0x001D5B4C
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelRegionActivities.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x0002F354 File Offset: 0x0002D554
		public CartelRegionActivities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06006460 RID: 25696 RVA: 0x001D7988 File Offset: 0x001D5B88
		// (set) Token: 0x06006461 RID: 25697 RVA: 0x0002F35D File Offset: 0x0002D55D
		public unsafe static int MIN_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelRegionActivities.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelRegionActivities.NativeFieldInfoPtr_MIN_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06006462 RID: 25698 RVA: 0x001D79A4 File Offset: 0x001D5BA4
		// (set) Token: 0x06006463 RID: 25699 RVA: 0x0002F36B File Offset: 0x0002D56B
		public unsafe static int MAX_COOLDOWN
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelRegionActivities.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelRegionActivities.NativeFieldInfoPtr_MAX_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06006464 RID: 25700 RVA: 0x001D79C0 File Offset: 0x001D5BC0
		// (set) Token: 0x06006465 RID: 25701 RVA: 0x0002F379 File Offset: 0x0002D579
		public unsafe bool TEST_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_TEST_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_TEST_MODE)) = value;
			}
		}

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06006466 RID: 25702 RVA: 0x001D79E8 File Offset: 0x001D5BE8
		// (set) Token: 0x06006467 RID: 25703 RVA: 0x0002F394 File Offset: 0x0002D594
		public unsafe CartelActivity _CurrentActivity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__CurrentActivity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelActivity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__CurrentActivity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06006468 RID: 25704 RVA: 0x001D7A18 File Offset: 0x001D5C18
		// (set) Token: 0x06006469 RID: 25705 RVA: 0x0002F3B3 File Offset: 0x0002D5B3
		public unsafe int _HoursUntilNextActivity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__HoursUntilNextActivity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__HoursUntilNextActivity_k__BackingField)) = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600646A RID: 25706 RVA: 0x001D7A40 File Offset: 0x001D5C40
		// (set) Token: 0x0600646B RID: 25707 RVA: 0x0002F3CE File Offset: 0x0002D5CE
		public unsafe bool Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Active)) = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600646C RID: 25708 RVA: 0x001D7A68 File Offset: 0x001D5C68
		// (set) Token: 0x0600646D RID: 25709 RVA: 0x0002F3E9 File Offset: 0x0002D5E9
		public unsafe EMapRegion Region
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Region);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Region)) = value;
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600646E RID: 25710 RVA: 0x001D7A90 File Offset: 0x001D5C90
		// (set) Token: 0x0600646F RID: 25711 RVA: 0x0002F404 File Offset: 0x0002D604
		public unsafe List<CartelActivity> Activities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Activities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelActivity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_Activities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06006470 RID: 25712 RVA: 0x001D7AC0 File Offset: 0x001D5CC0
		// (set) Token: 0x06006471 RID: 25713 RVA: 0x0002F423 File Offset: 0x0002D623
		public unsafe Il2CppReferenceArray<CartelAmbushLocation> AmbushLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_AmbushLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelAmbushLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_AmbushLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06006472 RID: 25714 RVA: 0x001D7AF0 File Offset: 0x001D5CF0
		// (set) Token: 0x06006473 RID: 25715 RVA: 0x0002F442 File Offset: 0x0002D642
		public unsafe CartelDealer CartelDealer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_CartelDealer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelDealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_CartelDealer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06006474 RID: 25716 RVA: 0x001D7B20 File Offset: 0x001D5D20
		// (set) Token: 0x06006475 RID: 25717 RVA: 0x0002F461 File Offset: 0x0002D661
		public unsafe int _debugActivityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__debugActivityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr__debugActivityIndex)) = value;
			}
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06006476 RID: 25718 RVA: 0x001D7B48 File Offset: 0x001D5D48
		// (set) Token: 0x06006477 RID: 25719 RVA: 0x0002F47C File Offset: 0x0002D67C
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06006478 RID: 25720 RVA: 0x001D7B70 File Offset: 0x001D5D70
		// (set) Token: 0x06006479 RID: 25721 RVA: 0x0002F497 File Offset: 0x0002D697
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelRegionActivities.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004523 RID: 17699
		private static readonly IntPtr NativeFieldInfoPtr_MIN_COOLDOWN;

		// Token: 0x04004524 RID: 17700
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COOLDOWN;

		// Token: 0x04004525 RID: 17701
		private static readonly IntPtr NativeFieldInfoPtr_TEST_MODE;

		// Token: 0x04004526 RID: 17702
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActivity_k__BackingField;

		// Token: 0x04004527 RID: 17703
		private static readonly IntPtr NativeFieldInfoPtr__HoursUntilNextActivity_k__BackingField;

		// Token: 0x04004528 RID: 17704
		private static readonly IntPtr NativeFieldInfoPtr_Active;

		// Token: 0x04004529 RID: 17705
		private static readonly IntPtr NativeFieldInfoPtr_Region;

		// Token: 0x0400452A RID: 17706
		private static readonly IntPtr NativeFieldInfoPtr_Activities;

		// Token: 0x0400452B RID: 17707
		private static readonly IntPtr NativeFieldInfoPtr_AmbushLocations;

		// Token: 0x0400452C RID: 17708
		private static readonly IntPtr NativeFieldInfoPtr_CartelDealer;

		// Token: 0x0400452D RID: 17709
		private static readonly IntPtr NativeFieldInfoPtr__debugActivityIndex;

		// Token: 0x0400452E RID: 17710
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400452F RID: 17711
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004530 RID: 17712
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActivity_Public_get_CartelActivity_0;

		// Token: 0x04004531 RID: 17713
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActivity_Private_set_Void_CartelActivity_0;

		// Token: 0x04004532 RID: 17714
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursUntilNextActivity_Public_get_Int32_0;

		// Token: 0x04004533 RID: 17715
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursUntilNextActivity_Public_set_Void_Int32_0;

		// Token: 0x04004534 RID: 17716
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_0;

		// Token: 0x04004535 RID: 17717
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004536 RID: 17718
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004537 RID: 17719
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Public_Void_0;

		// Token: 0x04004538 RID: 17720
		private static readonly IntPtr NativeMethodInfoPtr_TryStartActivity_Private_Void_0;

		// Token: 0x04004539 RID: 17721
		private static readonly IntPtr NativeMethodInfoPtr_StartActivity_Public_Void_0;

		// Token: 0x0400453A RID: 17722
		private static readonly IntPtr NativeMethodInfoPtr_StartAcivity_Private_Void_Int32_0;

		// Token: 0x0400453B RID: 17723
		private static readonly IntPtr NativeMethodInfoPtr_ActivateDeal_Public_Void_0;

		// Token: 0x0400453C RID: 17724
		private static readonly IntPtr NativeMethodInfoPtr_StartActivity_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400453D RID: 17725
		private static readonly IntPtr NativeMethodInfoPtr_ActivityEnded_Private_Void_0;

		// Token: 0x0400453E RID: 17726
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_CartelRegionalActivityData_0;

		// Token: 0x0400453F RID: 17727
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_CartelRegionalActivityData_0;

		// Token: 0x04004540 RID: 17728
		private static readonly IntPtr NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_EMapRegion_0;

		// Token: 0x04004541 RID: 17729
		private static readonly IntPtr NativeMethodInfoPtr_CartelStatusChange_Private_Void_ECartelStatus_ECartelStatus_0;

		// Token: 0x04004542 RID: 17730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004543 RID: 17731
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004544 RID: 17732
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004545 RID: 17733
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004546 RID: 17734
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04004547 RID: 17735
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04004548 RID: 17736
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartActivity_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004549 RID: 17737
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartActivity_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400454A RID: 17738
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartActivity_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400454B RID: 17739
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
