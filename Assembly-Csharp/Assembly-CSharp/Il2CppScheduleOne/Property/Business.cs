using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Money;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000162 RID: 354
	public class Business : Property
	{
		// Token: 0x060022B5 RID: 8885 RVA: 0x000ED594 File Offset: 0x000EB794
		// Note: this type is marked as 'beforefieldinit'.
		static Business()
		{
			Il2CppClassPointerStore<Business>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "Business");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business>.NativeClassPtr);
			Business.NativeFieldInfoPtr_Businesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "Businesses");
			Business.NativeFieldInfoPtr_UnownedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "UnownedBusinesses");
			Business.NativeFieldInfoPtr_OwnedBusinesses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "OwnedBusinesses");
			Business.NativeFieldInfoPtr_LaunderCapacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderCapacity");
			Business.NativeFieldInfoPtr_LaunderingOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "LaunderingOperations");
			Business.NativeFieldInfoPtr_onOperationStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationStarted");
			Business.NativeFieldInfoPtr_onOperationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "onOperationFinished");
			Business.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "loader");
			Business.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted");
			Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667764);
			Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667765);
			Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667766);
			Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667767);
			Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667768);
			Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667769);
			Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667770);
			Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667771);
			Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667772);
			Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667773);
			Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667774);
			Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667775);
			Business.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667776);
			Business.NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667777);
			Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667778);
			Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667779);
			Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667780);
			Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667781);
			Business.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667782);
			Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667784);
			Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667785);
			Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667786);
			Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667787);
			Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667788);
			Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667789);
			Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667790);
			Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667791);
			Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667792);
			Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667793);
			Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667794);
			Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business>.NativeClassPtr, 100667795);
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x000ED8F8 File Offset: 0x000EBAF8
		public unsafe float currentLaunderTotal
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 111879, RefRangeEnd = 111887, XrefRangeStart = 111861, XrefRangeEnd = 111879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x000ED934 File Offset: 0x000EBB34
		public unsafe float appliedLaunderLimit
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 111888, RefRangeEnd = 111889, XrefRangeStart = 111887, XrefRangeEnd = 111888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x000ED970 File Offset: 0x000EBB70
		public new unsafe virtual Loader Loader
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 111889, RefRangeEnd = 111907, XrefRangeStart = 111889, XrefRangeEnd = 111889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x000ED9B0 File Offset: 0x000EBBB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111907, XrefRangeEnd = 111908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x000ED9EC File Offset: 0x000EBBEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111908, XrefRangeEnd = 111938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x000EDA28 File Offset: 0x000EBC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111938, XrefRangeEnd = 111953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x000EDA64 File Offset: 0x000EBC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111953, XrefRangeEnd = 111959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetNetworth(MoneyManager.FloatContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x000EDAB4 File Offset: 0x000EBCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111959, XrefRangeEnd = 111969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x000EDB04 File Offset: 0x000EBD04
		[CallerCount(0)]
		public unsafe virtual void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x000EDB40 File Offset: 0x000EBD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111969, XrefRangeEnd = 111981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void MinsPass(int mins)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref mins;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x000EDB8C File Offset: 0x000EBD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111981, XrefRangeEnd = 112005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TimeSkipped(int minsPassed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minsPassed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x000EDBCC File Offset: 0x000EBDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112005, XrefRangeEnd = 112051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x000EDC10 File Offset: 0x000EBE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112051, XrefRangeEnd = 112057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(PropertyData propertyData, string propertyDataString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(propertyDataString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x000EDC70 File Offset: 0x000EBE70
		[CallerCount(170)]
		[CachedScanResults(RefRangeStart = 31151, RefRangeEnd = 31321, XrefRangeStart = 31151, XrefRangeEnd = 31321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanDeliverToProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x000EDCB8 File Offset: 0x000EBEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112057, XrefRangeEnd = 112075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecieveOwned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x000EDCF4 File Offset: 0x000EBEF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112087, RefRangeEnd = 112089, XrefRangeStart = 112075, XrefRangeEnd = 112087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x000EDD40 File Offset: 0x000EBF40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112121, RefRangeEnd = 112124, XrefRangeStart = 112089, XrefRangeEnd = 112121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x000EDDA0 File Offset: 0x000EBFA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112178, RefRangeEnd = 112179, XrefRangeStart = 112124, XrefRangeEnd = 112178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteOperation(LaunderingOperation op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x000EDDE4 File Offset: 0x000EBFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112179, XrefRangeEnd = 112195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Business() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x000EDE20 File Offset: 0x000EC020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112195, XrefRangeEnd = 112216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x000EDE5C File Offset: 0x000EC05C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x000EDE98 File Offset: 0x000EC098
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x000EDED4 File Offset: 0x000EC0D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112087, RefRangeEnd = 112089, XrefRangeStart = 112087, XrefRangeEnd = 112089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x000EDF20 File Offset: 0x000EC120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112216, XrefRangeEnd = 112217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x000EDF6C File Offset: 0x000EC16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112217, XrefRangeEnd = 112222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x000EDFD0 File Offset: 0x000EC1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112222, XrefRangeEnd = 112234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x000EE030 File Offset: 0x000EC230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 112250, RefRangeEnd = 112252, XrefRangeStart = 112234, XrefRangeEnd = 112250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x000EE090 File Offset: 0x000EC290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112252, XrefRangeEnd = 112258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x000EE0E0 File Offset: 0x000EC2E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112258, XrefRangeEnd = 112270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutesSinceStarted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x000EE140 File Offset: 0x000EC340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112270, XrefRangeEnd = 112275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000EE190 File Offset: 0x000EC390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 112295, RefRangeEnd = 112296, XrefRangeStart = 112275, XrefRangeEnd = 112295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Business.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00012857 File Offset: 0x00010A57
		public Business(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x000EE1CC File Offset: 0x000EC3CC
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00012860 File Offset: 0x00010A60
		public unsafe static List<Business> Businesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_Businesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_Businesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x000EE1F4 File Offset: 0x000EC3F4
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x00012872 File Offset: 0x00010A72
		public unsafe static List<Business> UnownedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_UnownedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_UnownedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x000EE21C File Offset: 0x000EC41C
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x00012884 File Offset: 0x00010A84
		public unsafe static List<Business> OwnedBusinesses
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_OwnedBusinesses, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Business>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_OwnedBusinesses, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x000EE244 File Offset: 0x000EC444
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x00012896 File Offset: 0x00010A96
		public unsafe float LaunderCapacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderCapacity)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000EE26C File Offset: 0x000EC46C
		// (set) Token: 0x060022DF RID: 8927 RVA: 0x000128B1 File Offset: 0x00010AB1
		public unsafe List<LaunderingOperation> LaunderingOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_LaunderingOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000EE29C File Offset: 0x000EC49C
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x000128D0 File Offset: 0x00010AD0
		public unsafe static Action<LaunderingOperation> onOperationStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x000EE2C4 File Offset: 0x000EC4C4
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x000128E2 File Offset: 0x00010AE2
		public unsafe static Action<LaunderingOperation> onOperationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Business.NativeFieldInfoPtr_onOperationFinished, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LaunderingOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Business.NativeFieldInfoPtr_onOperationFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x000EE2EC File Offset: 0x000EC4EC
		// (set) Token: 0x060022E5 RID: 8933 RVA: 0x000128F4 File Offset: 0x00010AF4
		public new unsafe BusinessLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000EE31C File Offset: 0x000EC51C
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00012913 File Offset: 0x00010B13
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000EE344 File Offset: 0x000EC544
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x0001292E File Offset: 0x00010B2E
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Business.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040017ED RID: 6125
		private static readonly IntPtr NativeFieldInfoPtr_Businesses;

		// Token: 0x040017EE RID: 6126
		private static readonly IntPtr NativeFieldInfoPtr_UnownedBusinesses;

		// Token: 0x040017EF RID: 6127
		private static readonly IntPtr NativeFieldInfoPtr_OwnedBusinesses;

		// Token: 0x040017F0 RID: 6128
		private static readonly IntPtr NativeFieldInfoPtr_LaunderCapacity;

		// Token: 0x040017F1 RID: 6129
		private static readonly IntPtr NativeFieldInfoPtr_LaunderingOperations;

		// Token: 0x040017F2 RID: 6130
		private static readonly IntPtr NativeFieldInfoPtr_onOperationStarted;

		// Token: 0x040017F3 RID: 6131
		private static readonly IntPtr NativeFieldInfoPtr_onOperationFinished;

		// Token: 0x040017F4 RID: 6132
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040017F5 RID: 6133
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040017F6 RID: 6134
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040017F7 RID: 6135
		private static readonly IntPtr NativeMethodInfoPtr_get_currentLaunderTotal_Public_get_Single_0;

		// Token: 0x040017F8 RID: 6136
		private static readonly IntPtr NativeMethodInfoPtr_get_appliedLaunderLimit_Public_get_Single_0;

		// Token: 0x040017F9 RID: 6137
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x040017FA RID: 6138
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040017FB RID: 6139
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x040017FC RID: 6140
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_1;

		// Token: 0x040017FD RID: 6141
		private static readonly IntPtr NativeMethodInfoPtr_GetNetworth_Protected_Virtual_Void_FloatContainer_0;

		// Token: 0x040017FE RID: 6142
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040017FF RID: 6143
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04001800 RID: 6144
		private static readonly IntPtr NativeMethodInfoPtr_MinsPass_Protected_Virtual_New_Void_Int32_0;

		// Token: 0x04001801 RID: 6145
		private static readonly IntPtr NativeMethodInfoPtr_TimeSkipped_Private_Void_Int32_0;

		// Token: 0x04001802 RID: 6146
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04001803 RID: 6147
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_PropertyData_String_0;

		// Token: 0x04001804 RID: 6148
		private static readonly IntPtr NativeMethodInfoPtr_CanDeliverToProperty_Public_Virtual_Boolean_0;

		// Token: 0x04001805 RID: 6149
		private static readonly IntPtr NativeMethodInfoPtr_RecieveOwned_Protected_Virtual_Void_1;

		// Token: 0x04001806 RID: 6150
		private static readonly IntPtr NativeMethodInfoPtr_StartLaunderingOperation_Public_Void_Single_Int32_0;

		// Token: 0x04001807 RID: 6151
		private static readonly IntPtr NativeMethodInfoPtr_ReceiveLaunderingOperation_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04001808 RID: 6152
		private static readonly IntPtr NativeMethodInfoPtr_CompleteOperation_Protected_Void_LaunderingOperation_0;

		// Token: 0x04001809 RID: 6153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400180A RID: 6154
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_StartLaunderingOperation_1481775633_Private_Void_Single_Int32_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartLaunderingOperation_1481775633_Public_Void_Single_Int32_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_StartLaunderingOperation_1481775633_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_NetworkConnection_Single_Int32_0;

		// Token: 0x04001814 RID: 6164
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ReceiveLaunderingOperation_1001022388_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001815 RID: 6165
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000972 RID: 2418
		[ObfuscatedName("ScheduleOne.Property.Business+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600D995 RID: 55701 RVA: 0x0035FD8C File Offset: 0x0035DF8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Business.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Business>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Business.__c>.NativeClassPtr);
				Business.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9");
				Business.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, "<>9__8_0");
				Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100667797);
				Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Business.__c>.NativeClassPtr, 100667798);
			}

			// Token: 0x0600D996 RID: 55702 RVA: 0x0035FE08 File Offset: 0x0035E008
			[CallerCount(2575)]
			[CachedScanResults(RefRangeStart = 370, RefRangeEnd = 2945, XrefRangeStart = 370, XrefRangeEnd = 2945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Business.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D997 RID: 55703 RVA: 0x0035FE44 File Offset: 0x0035E044
			[CallerCount(0)]
			public unsafe float _get_currentLaunderTotal_b__8_0(LaunderingOperation x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Business.__c.NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D998 RID: 55704 RVA: 0x000664E0 File Offset: 0x000646E0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004272 RID: 17010
			// (get) Token: 0x0600D999 RID: 55705 RVA: 0x0035FE94 File Offset: 0x0035E094
			// (set) Token: 0x0600D99A RID: 55706 RVA: 0x000664E9 File Offset: 0x000646E9
			public unsafe static Business.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Business.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004273 RID: 17011
			// (get) Token: 0x0600D99B RID: 55707 RVA: 0x0035FEBC File Offset: 0x0035E0BC
			// (set) Token: 0x0600D99C RID: 55708 RVA: 0x000664FB File Offset: 0x000646FB
			public unsafe static Func<LaunderingOperation, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Business.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LaunderingOperation, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Business.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009482 RID: 38018
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009483 RID: 38019
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04009484 RID: 38020
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009485 RID: 38021
			private static readonly IntPtr NativeMethodInfoPtr__get_currentLaunderTotal_b__8_0_Internal_Single_LaunderingOperation_0;
		}
	}
}
