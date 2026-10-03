using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Configuration
{
	// Token: 0x02000425 RID: 1061
	public class ConfigurationServiceNetworker : NetworkBehaviour
	{
		// Token: 0x06005DBD RID: 23997 RVA: 0x001BE7B8 File Offset: 0x001BC9B8
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurationServiceNetworker()
		{
			Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Configuration", "ConfigurationServiceNetworker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr);
			ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Configuration.ConfigurationServiceNetworkerAssembly-CSharp.dll_Excuted");
			ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Configuration.ConfigurationServiceNetworkerAssembly-CSharp.dll_Excuted");
			ConfigurationServiceNetworker.NativeMethodInfoPtr_get__configurationService_Private_get_ConfigurationService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675543);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675544);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675545);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675546);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_OnConfigChanged_Private_Void_BaseConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675547);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_ApplySettingsJson_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675548);
			ConfigurationServiceNetworker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675549);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675550);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675551);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675552);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcWriter___Observers_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675553);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcLogic___ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675554);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcReader___Observers_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675555);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcWriter___Target_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675556);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcReader___Target_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675557);
			ConfigurationServiceNetworker.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr, 100675558);
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x06005DBE RID: 23998 RVA: 0x001BE950 File Offset: 0x001BCB50
		public unsafe ConfigurationService _configurationService
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 200062, RefRangeEnd = 200067, XrefRangeStart = 200059, XrefRangeEnd = 200062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_get__configurationService_Private_get_ConfigurationService_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationService>(intPtr3) : null;
			}
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x001BE990 File Offset: 0x001BCB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200067, XrefRangeEnd = 200083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartServer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x001BE9CC File Offset: 0x001BCBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200083, XrefRangeEnd = 200103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x001BEA00 File Offset: 0x001BCC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200103, XrefRangeEnd = 200121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x001BEA50 File Offset: 0x001BCC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200121, XrefRangeEnd = 200124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnConfigChanged(BaseConfiguration changedConfig)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(changedConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_OnConfigChanged_Private_Void_BaseConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x001BEA94 File Offset: 0x001BCC94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200154, RefRangeEnd = 200156, XrefRangeStart = 200124, XrefRangeEnd = 200154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySettingsJson(NetworkConnection conn, string configName, string settingsJson)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(configName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(settingsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_ApplySettingsJson_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x001BEAFC File Offset: 0x001BCCFC
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 65655, RefRangeEnd = 65684, XrefRangeStart = 65655, XrefRangeEnd = 65684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigurationServiceNetworker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigurationServiceNetworker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x001BEB38 File Offset: 0x001BCD38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200156, XrefRangeEnd = 200169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x001BEB74 File Offset: 0x001BCD74
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 65684, RefRangeEnd = 65712, XrefRangeStart = 65684, XrefRangeEnd = 65712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x001BEBB0 File Offset: 0x001BCDB0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x001BEBEC File Offset: 0x001BCDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200169, XrefRangeEnd = 200180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(configName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(settingsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcWriter___Observers_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x001BEC54 File Offset: 0x001BCE54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 200212, RefRangeEnd = 200214, XrefRangeStart = 200180, XrefRangeEnd = 200212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(configName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(settingsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcLogic___ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x001BECBC File Offset: 0x001BCEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200214, XrefRangeEnd = 200218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_ApplySettingsJson_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcReader___Observers_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x001BED0C File Offset: 0x001BCF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200218, XrefRangeEnd = 200229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(configName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(settingsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcWriter___Target_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x001BED74 File Offset: 0x001BCF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200229, XrefRangeEnd = 200234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_ApplySettingsJson_3895153758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurationServiceNetworker.NativeMethodInfoPtr_RpcReader___Target_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x001BEDC4 File Offset: 0x001BCFC4
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfigurationServiceNetworker.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x0002C6E9 File Offset: 0x0002A8E9
		public ConfigurationServiceNetworker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x06005DCF RID: 24015 RVA: 0x001BEE00 File Offset: 0x001BD000
		// (set) Token: 0x06005DD0 RID: 24016 RVA: 0x0002C6F2 File Offset: 0x0002A8F2
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x06005DD1 RID: 24017 RVA: 0x001BEE28 File Offset: 0x001BD028
		// (set) Token: 0x06005DD2 RID: 24018 RVA: 0x0002C70D File Offset: 0x0002A90D
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigurationServiceNetworker.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400404B RID: 16459
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400404D RID: 16461
		private static readonly IntPtr NativeMethodInfoPtr_get__configurationService_Private_get_ConfigurationService_0;

		// Token: 0x0400404E RID: 16462
		private static readonly IntPtr NativeMethodInfoPtr_OnStartServer_Public_Virtual_Void_0;

		// Token: 0x0400404F RID: 16463
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004050 RID: 16464
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004051 RID: 16465
		private static readonly IntPtr NativeMethodInfoPtr_OnConfigChanged_Private_Void_BaseConfiguration_0;

		// Token: 0x04004052 RID: 16466
		private static readonly IntPtr NativeMethodInfoPtr_ApplySettingsJson_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04004053 RID: 16467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004054 RID: 16468
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004055 RID: 16469
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004056 RID: 16470
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004057 RID: 16471
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04004058 RID: 16472
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x04004059 RID: 16473
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400405A RID: 16474
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_ApplySettingsJson_3895153758_Private_Void_NetworkConnection_String_String_0;

		// Token: 0x0400405B RID: 16475
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_ApplySettingsJson_3895153758_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400405C RID: 16476
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
