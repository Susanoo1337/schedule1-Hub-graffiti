using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Object.Synchronizing;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020000DA RID: 218
	public class VehicleLights : NetworkBehaviour
	{
		// Token: 0x060014C4 RID: 5316 RVA: 0x000C0E68 File Offset: 0x000BF068
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleLights()
		{
			Il2CppClassPointerStore<VehicleLights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "VehicleLights");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr);
			VehicleLights.NativeFieldInfoPtr__debug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "_debug");
			VehicleLights.NativeFieldInfoPtr__HeadlightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "<HeadlightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_headLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMeshes");
			VehicleLights.NativeFieldInfoPtr_headLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightSources");
			VehicleLights.NativeFieldInfoPtr_headlightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headlightMat_On");
			VehicleLights.NativeFieldInfoPtr_headLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_headLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "headLightsApplied");
			VehicleLights.NativeFieldInfoPtr_brakeLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMeshes");
			VehicleLights.NativeFieldInfoPtr_brakeLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightSources");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_On");
			VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_brakeLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "brakeLightsApplied");
			VehicleLights.NativeFieldInfoPtr_hasReverseLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "hasReverseLights");
			VehicleLights.NativeFieldInfoPtr_reverseLightMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMeshes");
			VehicleLights.NativeFieldInfoPtr_reverseLightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightSources");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_On = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_On");
			VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightMat_Off");
			VehicleLights.NativeFieldInfoPtr_reverseLightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "reverseLightsApplied");
			VehicleLights.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "vehicle");
			VehicleLights.NativeFieldInfoPtr_syncVar____HeadlightsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "syncVar___<HeadlightsOn>k__BackingField");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Vehicles.VehicleLightsAssembly-CSharp.dll_Excuted");
			VehicleLights.NativeMethodInfoPtr_get_HeadlightsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666262);
			VehicleLights.NativeMethodInfoPtr_set_HeadlightsOn_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666263);
			VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666264);
			VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666265);
			VehicleLights.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666266);
			VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666267);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666268);
			VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666269);
			VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666270);
			VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_HeadlightsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666271);
			VehicleLights.NativeMethodInfoPtr_RpcLogic___set_HeadlightsOn_1140765316_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666272);
			VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_HeadlightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666273);
			VehicleLights.NativeMethodInfoPtr_sync___get_value__HeadlightsOn_k__BackingField_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666274);
			VehicleLights.NativeMethodInfoPtr_sync___set_value__HeadlightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666275);
			VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666276);
			VehicleLights.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr, 100666277);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060014C5 RID: 5317 RVA: 0x000C1190 File Offset: 0x000BF390
		// (set) Token: 0x060014C6 RID: 5318 RVA: 0x000C11CC File Offset: 0x000BF3CC
		public unsafe bool HeadlightsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_get_HeadlightsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 94431, RefRangeEnd = 94433, XrefRangeStart = 94409, XrefRangeEnd = 94431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_set_HeadlightsOn_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x000C120C File Offset: 0x000BF40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94433, XrefRangeEnd = 94437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x000C1248 File Offset: 0x000BF448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94437, XrefRangeEnd = 94465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x000C1284 File Offset: 0x000BF484
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 94493, RefRangeEnd = 94494, XrefRangeStart = 94465, XrefRangeEnd = 94493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000C12B8 File Offset: 0x000BF4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94494, XrefRangeEnd = 94495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleLights() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleLights>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000C12F4 File Offset: 0x000BF4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94495, XrefRangeEnd = 94518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x000C1330 File Offset: 0x000BF530
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x000C136C File Offset: 0x000BF56C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x000C13A8 File Offset: 0x000BF5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94518, XrefRangeEnd = 94528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_set_HeadlightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcWriter___Server_set_HeadlightsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x000C13E8 File Offset: 0x000BF5E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 94535, RefRangeEnd = 94538, XrefRangeStart = 94528, XrefRangeEnd = 94535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___set_HeadlightsOn_1140765316(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcLogic___set_HeadlightsOn_1140765316_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x000C1428 File Offset: 0x000BF628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94538, XrefRangeEnd = 94541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_set_HeadlightsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_RpcReader___Server_set_HeadlightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060014D1 RID: 5329 RVA: 0x000C148C File Offset: 0x000BF68C
		// (set) Token: 0x060014D2 RID: 5330 RVA: 0x000C14C8 File Offset: 0x000BF6C8
		public unsafe bool SyncAccessor_<HeadlightsOn>k__BackingField
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___get_value__HeadlightsOn_k__BackingField_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94541, XrefRangeEnd = 94549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_sync___set_value__HeadlightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000C1514 File Offset: 0x000BF714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94549, XrefRangeEnd = 94550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadSyncVar___ScheduleOne_Vehicles_VehicleLights(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref UInt321;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref Boolean2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehicleLights.NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000C1588 File Offset: 0x000BF788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94550, XrefRangeEnd = 94554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleLights.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0000B61E File Offset: 0x0000981E
		public VehicleLights(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060014D6 RID: 5334 RVA: 0x000C15BC File Offset: 0x000BF7BC
		// (set) Token: 0x060014D7 RID: 5335 RVA: 0x0000B627 File Offset: 0x00009827
		public unsafe bool _debug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__debug);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__debug)) = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x000C15E4 File Offset: 0x000BF7E4
		// (set) Token: 0x060014D9 RID: 5337 RVA: 0x0000B642 File Offset: 0x00009842
		public unsafe bool _HeadlightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__HeadlightsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr__HeadlightsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060014DA RID: 5338 RVA: 0x000C160C File Offset: 0x000BF80C
		// (set) Token: 0x060014DB RID: 5339 RVA: 0x0000B65D File Offset: 0x0000985D
		public unsafe Il2CppReferenceArray<MeshRenderer> headLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x000C163C File Offset: 0x000BF83C
		// (set) Token: 0x060014DD RID: 5341 RVA: 0x0000B67C File Offset: 0x0000987C
		public unsafe Il2CppReferenceArray<OptimizedLight> headLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x000C166C File Offset: 0x000BF86C
		// (set) Token: 0x060014DF RID: 5343 RVA: 0x0000B69B File Offset: 0x0000989B
		public unsafe Material headlightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headlightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060014E0 RID: 5344 RVA: 0x000C169C File Offset: 0x000BF89C
		// (set) Token: 0x060014E1 RID: 5345 RVA: 0x0000B6BA File Offset: 0x000098BA
		public unsafe Material headLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x000C16CC File Offset: 0x000BF8CC
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x0000B6D9 File Offset: 0x000098D9
		public unsafe bool headLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_headLightsApplied)) = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060014E4 RID: 5348 RVA: 0x000C16F4 File Offset: 0x000BF8F4
		// (set) Token: 0x060014E5 RID: 5349 RVA: 0x0000B6F4 File Offset: 0x000098F4
		public unsafe Il2CppReferenceArray<MeshRenderer> brakeLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x000C1724 File Offset: 0x000BF924
		// (set) Token: 0x060014E7 RID: 5351 RVA: 0x0000B713 File Offset: 0x00009913
		public unsafe Il2CppReferenceArray<Light> brakeLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060014E8 RID: 5352 RVA: 0x000C1754 File Offset: 0x000BF954
		// (set) Token: 0x060014E9 RID: 5353 RVA: 0x0000B732 File Offset: 0x00009932
		public unsafe Material brakeLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x000C1784 File Offset: 0x000BF984
		// (set) Token: 0x060014EB RID: 5355 RVA: 0x0000B751 File Offset: 0x00009951
		public unsafe Material brakeLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x000C17B4 File Offset: 0x000BF9B4
		// (set) Token: 0x060014ED RID: 5357 RVA: 0x0000B770 File Offset: 0x00009970
		public unsafe bool brakeLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_brakeLightsApplied)) = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x000C17DC File Offset: 0x000BF9DC
		// (set) Token: 0x060014EF RID: 5359 RVA: 0x0000B78B File Offset: 0x0000998B
		public unsafe bool hasReverseLights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_hasReverseLights)) = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x000C1804 File Offset: 0x000BFA04
		// (set) Token: 0x060014F1 RID: 5361 RVA: 0x0000B7A6 File Offset: 0x000099A6
		public unsafe Il2CppReferenceArray<MeshRenderer> reverseLightMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000C1834 File Offset: 0x000BFA34
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x0000B7C5 File Offset: 0x000099C5
		public unsafe Il2CppReferenceArray<Light> reverseLightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Light>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x000C1864 File Offset: 0x000BFA64
		// (set) Token: 0x060014F5 RID: 5365 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public unsafe Material reverseLightMat_On
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_On), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x000C1894 File Offset: 0x000BFA94
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x0000B803 File Offset: 0x00009A03
		public unsafe Material reverseLightMat_Off
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightMat_Off), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000C18C4 File Offset: 0x000BFAC4
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x0000B822 File Offset: 0x00009A22
		public unsafe bool reverseLightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_reverseLightsApplied)) = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x000C18EC File Offset: 0x000BFAEC
		// (set) Token: 0x060014FB RID: 5371 RVA: 0x0000B83D File Offset: 0x00009A3D
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000C191C File Offset: 0x000BFB1C
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x0000B85C File Offset: 0x00009A5C
		public unsafe SyncVar<bool> syncVar____HeadlightsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____HeadlightsOn_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SyncVar<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_syncVar____HeadlightsOn_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000C194C File Offset: 0x000BFB4C
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0000B87B File Offset: 0x00009A7B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000C1974 File Offset: 0x000BFB74
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000B896 File Offset: 0x00009A96
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleLights.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeFieldInfoPtr__debug;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeFieldInfoPtr__HeadlightsOn_k__BackingField;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeFieldInfoPtr_headLightMeshes;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeFieldInfoPtr_headLightSources;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeFieldInfoPtr_headlightMat_On;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeFieldInfoPtr_headLightMat_Off;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr_headLightsApplied;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMeshes;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightSources;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_On;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightMat_Off;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeFieldInfoPtr_brakeLightsApplied;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeFieldInfoPtr_hasReverseLights;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMeshes;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightSources;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_On;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightMat_Off;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeFieldInfoPtr_reverseLightsApplied;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeFieldInfoPtr_syncVar____HeadlightsOn_k__BackingField;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_get_HeadlightsOn_Public_get_Boolean_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_set_HeadlightsOn_Public_set_Void_Boolean_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04000EBA RID: 3770
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04000EBB RID: 3771
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04000EBC RID: 3772
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_set_HeadlightsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04000EBD RID: 3773
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___set_HeadlightsOn_1140765316_Public_Void_Boolean_0;

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_set_HeadlightsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeMethodInfoPtr_sync___get_value__HeadlightsOn_k__BackingField_Public_get_Boolean_0;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeMethodInfoPtr_sync___set_value__HeadlightsOn_k__BackingField_Public_set_Void_Boolean_Boolean_0;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeMethodInfoPtr_ReadSyncVar___ScheduleOne_Vehicles_VehicleLights_Public_Virtual_Boolean_PooledReader_UInt32_Boolean_0;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
