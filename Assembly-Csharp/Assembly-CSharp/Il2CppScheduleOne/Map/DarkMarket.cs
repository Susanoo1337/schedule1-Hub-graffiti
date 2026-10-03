using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x020002B0 RID: 688
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		// Token: 0x06003548 RID: 13640 RVA: 0x0012CAA4 File Offset: 0x0012ACA4
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarket()
		{
			Il2CppClassPointerStore<DarkMarket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr);
			DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "<IsOpen>k__BackingField");
			DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "<Unlocked>k__BackingField");
			DarkMarket.NativeFieldInfoPtr_AccessZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "AccessZone");
			DarkMarket.NativeFieldInfoPtr_MainDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "MainDoor");
			DarkMarket.NativeFieldInfoPtr_Oscar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "Oscar");
			DarkMarket.NativeFieldInfoPtr_UnlockRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "UnlockRank");
			DarkMarket.NativeFieldInfoPtr_onUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "onUnlocked");
			DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted");
			DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted");
			DarkMarket.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670057);
			DarkMarket.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670058);
			DarkMarket.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670059);
			DarkMarket.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670060);
			DarkMarket.NativeMethodInfoPtr_add_onUnlocked_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670061);
			DarkMarket.NativeMethodInfoPtr_remove_onUnlocked_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670062);
			DarkMarket.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670063);
			DarkMarket.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670064);
			DarkMarket.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670065);
			DarkMarket.NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670066);
			DarkMarket.NativeMethodInfoPtr_OnLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670067);
			DarkMarket.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670068);
			DarkMarket.NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670069);
			DarkMarket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670070);
			DarkMarket.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670071);
			DarkMarket.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670072);
			DarkMarket.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670073);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670074);
			DarkMarket.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670075);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670076);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670077);
			DarkMarket.NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670078);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670079);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670080);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670081);
			DarkMarket.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100670082);
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x06003549 RID: 13641 RVA: 0x0012CD90 File Offset: 0x0012AF90
		// (set) Token: 0x0600354A RID: 13642 RVA: 0x0012CDCC File Offset: 0x0012AFCC
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010E1 RID: 4321
		// (get) Token: 0x0600354B RID: 13643 RVA: 0x0012CE0C File Offset: 0x0012B00C
		// (set) Token: 0x0600354C RID: 13644 RVA: 0x0012CE48 File Offset: 0x0012B048
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600354D RID: 13645 RVA: 0x0012CE88 File Offset: 0x0012B088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141243, RefRangeEnd = 141244, XrefRangeStart = 141239, XrefRangeEnd = 141243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_onUnlocked(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_add_onUnlocked_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354E RID: 13646 RVA: 0x0012CECC File Offset: 0x0012B0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141244, XrefRangeEnd = 141248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_onUnlocked(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_remove_onUnlocked_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600354F RID: 13647 RVA: 0x0012CF10 File Offset: 0x0012B110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141248, XrefRangeEnd = 141263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003550 RID: 13648 RVA: 0x0012CF4C File Offset: 0x0012B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141263, XrefRangeEnd = 141265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x0012CF9C File Offset: 0x0012B19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141265, XrefRangeEnd = 141282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003552 RID: 13650 RVA: 0x0012CFD0 File Offset: 0x0012B1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141282, XrefRangeEnd = 141299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003553 RID: 13651 RVA: 0x0012D00C File Offset: 0x0012B20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141299, XrefRangeEnd = 141321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_OnLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0012D040 File Offset: 0x0012B240
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 141342, RefRangeEnd = 141343, XrefRangeStart = 141321, XrefRangeEnd = 141342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x0012D074 File Offset: 0x0012B274
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141380, RefRangeEnd = 141384, XrefRangeStart = 141343, XrefRangeEnd = 141380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0012D0B8 File Offset: 0x0012B2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141384, XrefRangeEnd = 141387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003557 RID: 13655 RVA: 0x0012D0F4 File Offset: 0x0012B2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141387, XrefRangeEnd = 141410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003558 RID: 13656 RVA: 0x0012D130 File Offset: 0x0012B330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141410, XrefRangeEnd = 141413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003559 RID: 13657 RVA: 0x0012D16C File Offset: 0x0012B36C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x0012D1A8 File Offset: 0x0012B3A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141413, XrefRangeEnd = 141422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x0012D1DC File Offset: 0x0012B3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141422, XrefRangeEnd = 141423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355C RID: 13660 RVA: 0x0012D210 File Offset: 0x0012B410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141423, XrefRangeEnd = 141426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x0012D274 File Offset: 0x0012B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141426, XrefRangeEnd = 141435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0012D2B8 File Offset: 0x0012B4B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141454, RefRangeEnd = 141457, XrefRangeStart = 141435, XrefRangeEnd = 141454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600355F RID: 13663 RVA: 0x0012D2FC File Offset: 0x0012B4FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141457, XrefRangeEnd = 141460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003560 RID: 13664 RVA: 0x0012D34C File Offset: 0x0012B54C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141460, XrefRangeEnd = 141469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0012D390 File Offset: 0x0012B590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141469, XrefRangeEnd = 141472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x0012D3E0 File Offset: 0x0012B5E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141472, XrefRangeEnd = 141475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003563 RID: 13667 RVA: 0x0001B145 File Offset: 0x00019345
		public DarkMarket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x0012D41C File Offset: 0x0012B61C
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x0001B14E File Offset: 0x0001934E
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x0012D444 File Offset: 0x0012B644
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x0001B169 File Offset: 0x00019369
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x0012D46C File Offset: 0x0012B66C
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x0001B184 File Offset: 0x00019384
		public unsafe DarkMarketAccessZone AccessZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_AccessZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketAccessZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_AccessZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x0012D49C File Offset: 0x0012B69C
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x0001B1A3 File Offset: 0x000193A3
		public unsafe DarkMarketMainDoor MainDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_MainDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_MainDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x0012D4CC File Offset: 0x0012B6CC
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x0001B1C2 File Offset: 0x000193C2
		public unsafe Oscar Oscar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_Oscar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oscar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_Oscar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DC RID: 4316
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x0012D4FC File Offset: 0x0012B6FC
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x0001B1E1 File Offset: 0x000193E1
		public unsafe FullRank UnlockRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_UnlockRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_UnlockRank)) = value;
			}
		}

		// Token: 0x170010DD RID: 4317
		// (get) Token: 0x06003570 RID: 13680 RVA: 0x0012D524 File Offset: 0x0012B724
		// (set) Token: 0x06003571 RID: 13681 RVA: 0x0001B1FC File Offset: 0x000193FC
		public unsafe Action onUnlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_onUnlocked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_onUnlocked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010DE RID: 4318
		// (get) Token: 0x06003572 RID: 13682 RVA: 0x0012D554 File Offset: 0x0012B754
		// (set) Token: 0x06003573 RID: 13683 RVA: 0x0001B21B File Offset: 0x0001941B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x06003574 RID: 13684 RVA: 0x0012D57C File Offset: 0x0012B77C
		// (set) Token: 0x06003575 RID: 13685 RVA: 0x0001B236 File Offset: 0x00019436
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeFieldInfoPtr_AccessZone;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeFieldInfoPtr_MainDoor;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeFieldInfoPtr_Oscar;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeFieldInfoPtr_UnlockRank;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeFieldInfoPtr_onUnlocked;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeMethodInfoPtr_add_onUnlocked_Public_add_Void_Action_0;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeMethodInfoPtr_remove_onUnlocked_Public_rem_Void_Action_0;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeMethodInfoPtr_OnLoad_Private_Void_0;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
