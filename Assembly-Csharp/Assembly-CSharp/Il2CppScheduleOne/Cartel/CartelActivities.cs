using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Map;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Cartel
{
	// Token: 0x02000448 RID: 1096
	public class CartelActivities : NetworkBehaviour
	{
		// Token: 0x06006313 RID: 25363 RVA: 0x001D2840 File Offset: 0x001D0A40
		// Note: this type is marked as 'beforefieldinit'.
		static CartelActivities()
		{
			Il2CppClassPointerStore<CartelActivities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cartel", "CartelActivities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr);
			CartelActivities.NativeFieldInfoPtr_MAX_COOLDOWN_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "MAX_COOLDOWN_HOURS");
			CartelActivities.NativeFieldInfoPtr_MIN_COOLDOWN_HOURS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "MIN_COOLDOWN_HOURS");
			CartelActivities.NativeFieldInfoPtr__CurrentGlobalActivity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "<CurrentGlobalActivity>k__BackingField");
			CartelActivities.NativeFieldInfoPtr__HoursUntilNextGlobalActivity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "<HoursUntilNextGlobalActivity>k__BackingField");
			CartelActivities.NativeFieldInfoPtr_GlobalActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "GlobalActivities");
			CartelActivities.NativeFieldInfoPtr_RegionalActivities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "RegionalActivities");
			CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted");
			CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Cartel.CartelActivitiesAssembly-CSharp.dll_Excuted");
			CartelActivities.NativeMethodInfoPtr_get_CurrentGlobalActivity_Public_get_CartelActivity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676310);
			CartelActivities.NativeMethodInfoPtr_set_CurrentGlobalActivity_Private_set_Void_CartelActivity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676311);
			CartelActivities.NativeMethodInfoPtr_get_HoursUntilNextGlobalActivity_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676312);
			CartelActivities.NativeMethodInfoPtr_set_HoursUntilNextGlobalActivity_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676313);
			CartelActivities.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676314);
			CartelActivities.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676315);
			CartelActivities.NativeMethodInfoPtr_GetRegionalActivities_Public_CartelRegionActivities_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676316);
			CartelActivities.NativeMethodInfoPtr_HourPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676317);
			CartelActivities.NativeMethodInfoPtr_TryStartActivity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676318);
			CartelActivities.NativeMethodInfoPtr_StartGlobalActivity_Private_Void_NetworkConnection_EMapRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676319);
			CartelActivities.NativeMethodInfoPtr_ActivityEnded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676320);
			CartelActivities.NativeMethodInfoPtr_CanNewActivityBegin_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676321);
			CartelActivities.NativeMethodInfoPtr_GetActivitiesReadyToStart_Private_List_1_CartelActivity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676322);
			CartelActivities.NativeMethodInfoPtr_GetValidRegionsForActivity_Private_List_1_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676323);
			CartelActivities.NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676324);
			CartelActivities.NativeMethodInfoPtr_GetInfluenceFraction_Private_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676325);
			CartelActivities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676326);
			CartelActivities.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676327);
			CartelActivities.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676328);
			CartelActivities.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676329);
			CartelActivities.NativeMethodInfoPtr_RpcWriter___Observers_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676330);
			CartelActivities.NativeMethodInfoPtr_RpcLogic___StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676331);
			CartelActivities.NativeMethodInfoPtr_RpcReader___Observers_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676332);
			CartelActivities.NativeMethodInfoPtr_RpcWriter___Target_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676333);
			CartelActivities.NativeMethodInfoPtr_RpcReader___Target_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676334);
			CartelActivities.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, 100676335);
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06006314 RID: 25364 RVA: 0x001D2B18 File Offset: 0x001D0D18
		// (set) Token: 0x06006315 RID: 25365 RVA: 0x001D2B58 File Offset: 0x001D0D58
		public unsafe CartelActivity CurrentGlobalActivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_get_CurrentGlobalActivity_Public_get_CartelActivity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_set_CurrentGlobalActivity_Private_set_Void_CartelActivity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06006316 RID: 25366 RVA: 0x001D2B9C File Offset: 0x001D0D9C
		// (set) Token: 0x06006317 RID: 25367 RVA: 0x001D2BD8 File Offset: 0x001D0DD8
		public unsafe int HoursUntilNextGlobalActivity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_get_HoursUntilNextGlobalActivity_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_set_HoursUntilNextGlobalActivity_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006318 RID: 25368 RVA: 0x001D2C18 File Offset: 0x001D0E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208769, XrefRangeEnd = 208787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006319 RID: 25369 RVA: 0x001D2C4C File Offset: 0x001D0E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208787, XrefRangeEnd = 208797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivities.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631A RID: 25370 RVA: 0x001D2C9C File Offset: 0x001D0E9C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208808, RefRangeEnd = 208813, XrefRangeStart = 208797, XrefRangeEnd = 208808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelRegionActivities GetRegionalActivities(EMapRegion region)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_GetRegionalActivities_Public_CartelRegionActivities_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CartelRegionActivities>(intPtr3) : null;
		}

		// Token: 0x0600631B RID: 25371 RVA: 0x001D2CE8 File Offset: 0x001D0EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208813, XrefRangeEnd = 208829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HourPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_HourPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631C RID: 25372 RVA: 0x001D2D1C File Offset: 0x001D0F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 208910, RefRangeEnd = 208911, XrefRangeStart = 208829, XrefRangeEnd = 208910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryStartActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_TryStartActivity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631D RID: 25373 RVA: 0x001D2D50 File Offset: 0x001D0F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 208954, RefRangeEnd = 208956, XrefRangeStart = 208911, XrefRangeEnd = 208954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGlobalActivity(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_StartGlobalActivity_Private_Void_NetworkConnection_EMapRegion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631E RID: 25374 RVA: 0x001D2DB0 File Offset: 0x001D0FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208956, XrefRangeEnd = 208971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ActivityEnded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_ActivityEnded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600631F RID: 25375 RVA: 0x001D2DE4 File Offset: 0x001D0FE4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 29255, RefRangeEnd = 29273, XrefRangeStart = 29255, XrefRangeEnd = 29273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanNewActivityBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_CanNewActivityBegin_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006320 RID: 25376 RVA: 0x001D2E20 File Offset: 0x001D1020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208971, XrefRangeEnd = 208987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<CartelActivity> GetActivitiesReadyToStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_GetActivitiesReadyToStart_Private_List_1_CartelActivity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CartelActivity>>(intPtr3) : null;
		}

		// Token: 0x06006321 RID: 25377 RVA: 0x001D2E60 File Offset: 0x001D1060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209037, RefRangeEnd = 209038, XrefRangeStart = 208987, XrefRangeEnd = 209037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EMapRegion> GetValidRegionsForActivity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_GetValidRegionsForActivity_Private_List_1_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EMapRegion>>(intPtr3) : null;
		}

		// Token: 0x06006322 RID: 25378 RVA: 0x001D2EA0 File Offset: 0x001D10A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209080, RefRangeEnd = 209083, XrefRangeStart = 209038, XrefRangeEnd = 209080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNewCooldown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006323 RID: 25379 RVA: 0x001D2ED0 File Offset: 0x001D10D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 209113, RefRangeEnd = 209114, XrefRangeStart = 209083, XrefRangeEnd = 209113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetInfluenceFraction()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_GetInfluenceFraction_Private_Static_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006324 RID: 25380 RVA: 0x001D2F00 File Offset: 0x001D1100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209114, XrefRangeEnd = 209122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CartelActivities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006325 RID: 25381 RVA: 0x001D2F3C File Offset: 0x001D113C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209122, XrefRangeEnd = 209135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivities.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006326 RID: 25382 RVA: 0x001D2F78 File Offset: 0x001D1178
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivities.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006327 RID: 25383 RVA: 0x001D2FB4 File Offset: 0x001D11B4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivities.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006328 RID: 25384 RVA: 0x001D2FF0 File Offset: 0x001D11F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209135, XrefRangeEnd = 209147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_RpcWriter___Observers_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006329 RID: 25385 RVA: 0x001D3050 File Offset: 0x001D1250
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 209167, RefRangeEnd = 209170, XrefRangeStart = 209147, XrefRangeEnd = 209167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_RpcLogic___StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632A RID: 25386 RVA: 0x001D30B0 File Offset: 0x001D12B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209170, XrefRangeEnd = 209176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_RpcReader___Observers_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632B RID: 25387 RVA: 0x001D3100 File Offset: 0x001D1300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209176, XrefRangeEnd = 209188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartGlobalActivity_1796582335(NetworkConnection conn, EMapRegion region, int activityIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref region;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activityIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_RpcWriter___Target_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x001D3160 File Offset: 0x001D1360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 209188, XrefRangeEnd = 209194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartGlobalActivity_1796582335(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.NativeMethodInfoPtr_RpcReader___Target_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x001D31B0 File Offset: 0x001D13B0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CartelActivities.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x0002EC33 File Offset: 0x0002CE33
		public CartelActivities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600632F RID: 25391 RVA: 0x001D31EC File Offset: 0x001D13EC
		// (set) Token: 0x06006330 RID: 25392 RVA: 0x0002EC3C File Offset: 0x0002CE3C
		public unsafe static int MAX_COOLDOWN_HOURS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelActivities.NativeFieldInfoPtr_MAX_COOLDOWN_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelActivities.NativeFieldInfoPtr_MAX_COOLDOWN_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x001D3208 File Offset: 0x001D1408
		// (set) Token: 0x06006332 RID: 25394 RVA: 0x0002EC4A File Offset: 0x0002CE4A
		public unsafe static int MIN_COOLDOWN_HOURS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CartelActivities.NativeFieldInfoPtr_MIN_COOLDOWN_HOURS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CartelActivities.NativeFieldInfoPtr_MIN_COOLDOWN_HOURS, (void*)(&value));
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06006333 RID: 25395 RVA: 0x001D3224 File Offset: 0x001D1424
		// (set) Token: 0x06006334 RID: 25396 RVA: 0x0002EC58 File Offset: 0x0002CE58
		public unsafe CartelActivity _CurrentGlobalActivity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr__CurrentGlobalActivity_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelActivity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr__CurrentGlobalActivity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06006335 RID: 25397 RVA: 0x001D3254 File Offset: 0x001D1454
		// (set) Token: 0x06006336 RID: 25398 RVA: 0x0002EC77 File Offset: 0x0002CE77
		public unsafe int _HoursUntilNextGlobalActivity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr__HoursUntilNextGlobalActivity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr__HoursUntilNextGlobalActivity_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x001D327C File Offset: 0x001D147C
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x0002EC92 File Offset: 0x0002CE92
		public unsafe List<CartelActivity> GlobalActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_GlobalActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CartelActivity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_GlobalActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x001D32AC File Offset: 0x001D14AC
		// (set) Token: 0x0600633A RID: 25402 RVA: 0x0002ECB1 File Offset: 0x0002CEB1
		public unsafe Il2CppReferenceArray<CartelRegionActivities> RegionalActivities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_RegionalActivities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CartelRegionActivities>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_RegionalActivities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600633B RID: 25403 RVA: 0x001D32DC File Offset: 0x001D14DC
		// (set) Token: 0x0600633C RID: 25404 RVA: 0x0002ECD0 File Offset: 0x0002CED0
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x001D3304 File Offset: 0x001D1504
		// (set) Token: 0x0600633E RID: 25406 RVA: 0x0002ECEB File Offset: 0x0002CEEB
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CartelActivities.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004449 RID: 17481
		private static readonly IntPtr NativeFieldInfoPtr_MAX_COOLDOWN_HOURS;

		// Token: 0x0400444A RID: 17482
		private static readonly IntPtr NativeFieldInfoPtr_MIN_COOLDOWN_HOURS;

		// Token: 0x0400444B RID: 17483
		private static readonly IntPtr NativeFieldInfoPtr__CurrentGlobalActivity_k__BackingField;

		// Token: 0x0400444C RID: 17484
		private static readonly IntPtr NativeFieldInfoPtr__HoursUntilNextGlobalActivity_k__BackingField;

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeFieldInfoPtr_GlobalActivities;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeFieldInfoPtr_RegionalActivities;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentGlobalActivity_Public_get_CartelActivity_0;

		// Token: 0x04004452 RID: 17490
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentGlobalActivity_Private_set_Void_CartelActivity_0;

		// Token: 0x04004453 RID: 17491
		private static readonly IntPtr NativeMethodInfoPtr_get_HoursUntilNextGlobalActivity_Public_get_Int32_0;

		// Token: 0x04004454 RID: 17492
		private static readonly IntPtr NativeMethodInfoPtr_set_HoursUntilNextGlobalActivity_Public_set_Void_Int32_0;

		// Token: 0x04004455 RID: 17493
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeMethodInfoPtr_GetRegionalActivities_Public_CartelRegionActivities_EMapRegion_0;

		// Token: 0x04004458 RID: 17496
		private static readonly IntPtr NativeMethodInfoPtr_HourPass_Private_Void_0;

		// Token: 0x04004459 RID: 17497
		private static readonly IntPtr NativeMethodInfoPtr_TryStartActivity_Private_Void_0;

		// Token: 0x0400445A RID: 17498
		private static readonly IntPtr NativeMethodInfoPtr_StartGlobalActivity_Private_Void_NetworkConnection_EMapRegion_Int32_0;

		// Token: 0x0400445B RID: 17499
		private static readonly IntPtr NativeMethodInfoPtr_ActivityEnded_Private_Void_0;

		// Token: 0x0400445C RID: 17500
		private static readonly IntPtr NativeMethodInfoPtr_CanNewActivityBegin_Private_Boolean_0;

		// Token: 0x0400445D RID: 17501
		private static readonly IntPtr NativeMethodInfoPtr_GetActivitiesReadyToStart_Private_List_1_CartelActivity_0;

		// Token: 0x0400445E RID: 17502
		private static readonly IntPtr NativeMethodInfoPtr_GetValidRegionsForActivity_Private_List_1_EMapRegion_0;

		// Token: 0x0400445F RID: 17503
		private static readonly IntPtr NativeMethodInfoPtr_GetNewCooldown_Public_Static_Int32_0;

		// Token: 0x04004460 RID: 17504
		private static readonly IntPtr NativeMethodInfoPtr_GetInfluenceFraction_Private_Static_Single_0;

		// Token: 0x04004461 RID: 17505
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004462 RID: 17506
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004463 RID: 17507
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004464 RID: 17508
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004465 RID: 17509
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0;

		// Token: 0x04004466 RID: 17510
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0;

		// Token: 0x04004467 RID: 17511
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004468 RID: 17512
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartGlobalActivity_1796582335_Private_Void_NetworkConnection_EMapRegion_Int32_0;

		// Token: 0x04004469 RID: 17513
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartGlobalActivity_1796582335_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400446A RID: 17514
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000B39 RID: 2873
		[ObfuscatedName("ScheduleOne.Cartel.CartelActivities+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E6C7 RID: 59079 RVA: 0x00384BE0 File Offset: 0x00382DE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CartelActivities>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr);
				CartelActivities.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr, "<>9");
				CartelActivities.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr, "<>9__16_0");
				CartelActivities.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr, 100676337);
				CartelActivities.__c.NativeMethodInfoPtr__TryStartActivity_b__16_0_Internal_Int32_EMapRegion_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr, 100676338);
			}

			// Token: 0x0600E6C8 RID: 59080 RVA: 0x00384C5C File Offset: 0x00382E5C
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CartelActivities.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E6C9 RID: 59081 RVA: 0x00384C98 File Offset: 0x00382E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208758, XrefRangeEnd = 208769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _TryStartActivity_b__16_0(EMapRegion a, EMapRegion b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CartelActivities.__c.NativeMethodInfoPtr__TryStartActivity_b__16_0_Internal_Int32_EMapRegion_EMapRegion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E6CA RID: 59082 RVA: 0x0006CDA1 File Offset: 0x0006AFA1
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700460B RID: 17931
			// (get) Token: 0x0600E6CB RID: 59083 RVA: 0x00384CF0 File Offset: 0x00382EF0
			// (set) Token: 0x0600E6CC RID: 59084 RVA: 0x0006CDAA File Offset: 0x0006AFAA
			public unsafe static CartelActivities.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelActivities.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CartelActivities.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelActivities.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700460C RID: 17932
			// (get) Token: 0x0600E6CD RID: 59085 RVA: 0x00384D18 File Offset: 0x00382F18
			// (set) Token: 0x0600E6CE RID: 59086 RVA: 0x0006CDBC File Offset: 0x0006AFBC
			public unsafe static Comparison<EMapRegion> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CartelActivities.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<EMapRegion>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CartelActivities.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009CAA RID: 40106
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009CAB RID: 40107
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009CAC RID: 40108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009CAD RID: 40109
			private static readonly IntPtr NativeMethodInfoPtr__TryStartActivity_b__16_0_Internal_Int32_EMapRegion_EMapRegion_0;
		}
	}
}
